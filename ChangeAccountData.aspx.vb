'Partial Class Account
'    Inherits System.Web.UI.Page

'    Private ReadOnly b As New Base_IST_PPP()
'    Dim connIST As String = b.GetConnStr("connIST")
'    Dim connCatalog As String = b.GetConnStr("connCatalog")


'    Sub Page_Load(ByVal Src As Object, ByVal E As EventArgs) Handles Me.Load
'        Try
'            If Not IsPostBack Then    'crtam se prvi put
'                If (Session("NALOG") <> Nothing AndAlso Session("NALOG") <> "") Then
'                    'b.SetLabels(Page, Session("izabranJezik"), connIST)

'                Else    'NEMA ROLU
'                    Response.Redirect("Default.aspx")
'                    HttpContext.Current.ApplicationInstance.CompleteRequest()
'                End If


'            End If 'Not IsPostBack
'        Catch ex As Exception
'            Response.Write("<p align=center>" & ex.Message & "-" & ex.StackTrace)
'        Finally
'        End Try
'    End Sub





'End Class

'Imports System.Data.SqlClient

'Partial Class Account
'    Inherits System.Web.UI.Page

'    Private ReadOnly b As New Base_IST_PPP()
'    Dim connIST As String = b.GetConnStr("connIST")
'    Dim connCatalog As String = b.GetConnStr("connCatalog")

'    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Try
'            If Not IsPostBack Then
'                If (Session("Nalog") IsNot Nothing) Then
'                    ' Возможно, здесь вы хотите загрузить данные пользователя.
'                    LoadUserData()
'                Else
'                    ' Перенаправление на другую страницу, если сессия не активна.
'                    Response.Redirect("Default.aspx")
'                    HttpContext.Current.ApplicationInstance.CompleteRequest()
'                End If
'            End If
'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'        End Try
'    End Sub

'    ' Метод для загрузки данных пользователя
'    Private Sub LoadUserData()
'        Try
'            Dim userId As Integer = Convert.ToInt32(Session("appuser"))
'            Dim query As String = "SELECT APPUser, NameUser, LastNameUser  FROM dbo.ISTUsers as b INNER JOIN (SELECT * FROM ISTAPPUsers WHERE appuser='" + Session("NALOG") + "') as a ON a.appuser=b.APPUser"
'            '"SELECT sifist,naziv,periodika,appuser, (sifist+'/'+periodika+'/'+appuser) as keys FROM dbo.ist As b INNER JOIN (SELECT * FROM ISTAPPUsers WHERE appuser='" + Session("NALOG") + "') as a ON a.appcode=b.sifist"
'            Using conn As New SqlConnection(connCatalog)
'                Using cmd As New SqlCommand(query, conn)
'                    conn.Open()
'                    Using reader As SqlDataReader = cmd.ExecuteReader()
'                        If reader.Read() Then
'                            ' Здесь вы можете заполнить поля формы данными пользователя
'                            ' Например: txtFirstName.Text = reader("FirstName").ToString()
'                        End If
'                    End Using
'                End Using
'            End Using
'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'        End Try
'    End Sub

'    ' Метод для обновления данных пользователя
'    Protected Sub UpdateUserData(ByVal firstName As String, ByVal lastName As String, ByVal username As String)
'        Try
'            Dim userId As Integer = Convert.ToInt32(Session("appcode"))
'            Dim query As String = "UPDATE dbo.ISTUsers SET NameUser = @FirstName, LastNameUser = @LastName, APPUser = @Username WHERE appcode = @username"

'            Using conn As New SqlConnection(connCatalog)
'                Using cmd As New SqlCommand(query, conn)
'                    cmd.Parameters.AddWithValue("@FirstName", firstName)
'                    cmd.Parameters.AddWithValue("@LastName", lastName)
'                    cmd.Parameters.AddWithValue("@Username", username)
'                    conn.Open()
'                    cmd.ExecuteNonQuery()
'                End Using
'            End Using
'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'        End Try
'    End Sub
'End Class


'Imports System.Data.SqlClient

'Partial Class Account
'    Inherits System.Web.UI.Page

'    Private ReadOnly b As New Base_IST_PPP()
'    Dim connIST As String = b.GetConnStr("connIST")
'    Dim connCatalog As String = b.GetConnStr("connCatalog")

'    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Try
'            If Not IsPostBack Then
'                If (Session("Nalog") IsNot Nothing) Then
'                    ' Загружаем данные пользователя
'                    LoadUserData()
'                Else
'                    ' Перенаправление на другую страницу, если сессия не активна.
'                    Response.Redirect("Default.aspx")
'                    HttpContext.Current.ApplicationInstance.CompleteRequest()
'                End If
'            End If
'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
'        End Try
'    End Sub

'    ' Метод для загрузки данных пользователя
'    Private Sub LoadUserData()
'        Try
'            Dim userId As Integer = Convert.ToInt32(Session("NALOG"))
'            Dim query As String = "SELECT APPUser, NameUser, LastNameUser FROM dbo.ISTUsers " &
'                                  "AS b INNER JOIN (SELECT * FROM ISTAPPUsers WHERE appuser=@UserId) " &
'                                  "AS a ON a.appuser=b.APPUser"

'            Using conn As New SqlConnection(connIST)
'                Using cmd As New SqlCommand(query, conn)
'                    conn.Open()
'                    Using reader As SqlDataReader = cmd.ExecuteReader()
'                        If reader.Read() Then
'                            ' Заполняем текстовые поля данными пользователя
'                            txtFirstName.Text = reader("NameUser").ToString()
'                            txtLastName.Text = reader("LastNameUser").ToString()
'                            txtUsername.Text = reader("APPUser").ToString()
'                        End If
'                    End Using
'                End Using
'            End Using
'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
'        End Try
'    End Sub

'    ' Метод для обновления данных пользователя
'    Protected Sub UpdateUserData(ByVal firstName As String, ByVal lastName As String, ByVal username As String)
'        Try
'            Dim query As String = "UPDATE dbo.ISTUsers SET NameUser = @FirstName, LastNameUser = @LastName, APPUser = @Username WHERE APPUser = @Username"

'            Using conn As New SqlConnection(connIST)
'                Using cmd As New SqlCommand(query, conn)
'                    cmd.Parameters.AddWithValue("@FirstName", firstName)
'                    cmd.Parameters.AddWithValue("@LastName", lastName)
'                    cmd.Parameters.AddWithValue("@Username", username)
'                    conn.Open()
'                    cmd.ExecuteNonQuery()
'                End Using
'            End Using
'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
'        End Try
'    End Sub
'End Class



'Imports System.Data
'Imports System.Data.SqlClient

'Partial Class Account
'    Inherits System.Web.UI.Page

'    Private ReadOnly b As New Base_IST_PPP()
'    Dim connIST As String = b.GetConnStr("connIST")
'    Dim connCatalog As String = b.GetConnStr("connCatalog")
'    Dim BRU As String = b.GetConnStr("BRU")
'    Private fvUserDetails As Object

'    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Try
'            If Not IsPostBack Then
'                If (Session("Nalog") IsNot Nothing) Then
'                    ' Загружаем данные пользователя
'                    'LoadUserData()
'                Else
'                    ' Перенаправление на другую страницу, если сессия не активна.
'                    Response.Redirect("Default.aspx")
'                    HttpContext.Current.ApplicationInstance.CompleteRequest()
'                End If
'            End If
'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
'        End Try
'    End Sub

'    Protected Sub fvUserDetails_ItemInserting(sender As Object, e As FormViewInsertEventArgs)
'        ' Получаем данные с формы
'        Dim firstYear As String = CType(fvUserDetails.FindControl("txtFirstYear"), TextBox).Text
'        Dim kpred As String = CType(fvUserDetails.FindControl("txtKpred"), TextBox).Text
'        Dim nameCompany As String = CType(fvUserDetails.FindControl("txtNameCompany"), TextBox).Text
'        Dim fullName As String = CType(fvUserDetails.FindControl("txtFullName"), TextBox).Text
'        Dim territoryCode As String = CType(fvUserDetails.FindControl("txtTerritoryCode"), TextBox).Text

'        ' Подключаемся к базе данных
'        Dim connectionString As String = "your_connection_string_here"
'        Using conn As New SqlConnection(connectionString)
'            Dim query As String = "INSERT INTO dbo.KatmeUvedom (FirstYear, Kpred, NameCompany, FullName, TerritoryCode) " &
'                                  "VALUES (@FirstYear, @Kpred, @NameCompany, @FullName, @TerritoryCode)"

'            Dim cmd As New SqlCommand(query, conn)
'            cmd.Parameters.AddWithValue("@FirstYear", firstYear)
'            cmd.Parameters.AddWithValue("@Kpred", kpred)
'            cmd.Parameters.AddWithValue("@NameCompany", nameCompany)
'            cmd.Parameters.AddWithValue("@FullName", fullName)
'            cmd.Parameters.AddWithValue("@TerritoryCode", Convert.ToInt64(territoryCode))

'            conn.Open()
'            cmd.ExecuteNonQuery()
'        End Using
'    End Sub




'End Class




'Imports System.Data
'Imports System.Data.SqlClient

'Partial Class Account
'    Inherits System.Web.UI.Page

'    Private ReadOnly b As New Base_IST_PPP()
'    Dim connIST As String = b.GetConnStr("connIST")
'    Dim connCatalog As String = b.GetConnStr("connCatalog")
'    Dim BRU As String = b.GetConnStr("BRU")
'    Private fvUserDetails As FormView

'    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Try
'            If Not IsPostBack Then
'                If (Session("Nalog") IsNot Nothing) Then
'                    ' Загружаем данные пользователя
'                    'LoadUserData()
'                Else
'                    ' Перенаправление на другую страницу, если сессия не активна.
'                    Response.Redirect("Default.aspx")
'                    HttpContext.Current.ApplicationInstance.CompleteRequest()
'                End If
'            End If
'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
'        End Try
'    End Sub

'    Protected Sub fvUserDetails_ItemInserting(sender As Object, e As FormViewInsertEventArgs)
'        Try
'            ' Получаем данные с формы
'            Dim firstYear As String = CType(fvUserDetails.FindControl("txtFirstYear"), TextBox).Text
'            Dim kpred As String = CType(fvUserDetails.FindControl("txtKpred"), TextBox).Text
'            Dim nameCompany As String = CType(fvUserDetails.FindControl("txtNameCompany"), TextBox).Text
'            Dim fullName As String = CType(fvUserDetails.FindControl("txtFullName"), TextBox).Text
'            Dim territoryCode As String = CType(fvUserDetails.FindControl("txtTerritoryCode"), TextBox).Text

'            ' Подключаемся к базе данных
'            Dim connectionString As String = BRU ' Используем строку подключения BRU
'            Using conn As New SqlConnection(connectionString)
'                Dim query As String = "INSERT INTO census-capi_new.Businessregister.dbo.KatmeUvedom (FirstYear, Kpred, NameCompany, FullName, TerritoryCode) VALUES (@FirstYear, @Kpred, @NameCompany, @FullName, @TerritoryCode)"

'                Dim cmd As New SqlCommand(query, conn)
'                cmd.Parameters.AddWithValue("@FirstYear", firstYear)
'                cmd.Parameters.AddWithValue("@Kpred", kpred)
'                cmd.Parameters.AddWithValue("@NameCompany", nameCompany)
'                cmd.Parameters.AddWithValue("@FullName", fullName)
'                cmd.Parameters.AddWithValue("@TerritoryCode", Convert.ToInt64(territoryCode))

'                conn.Open()
'                cmd.ExecuteNonQuery()


'            End Using

'        Catch ex As Exception
'            ' Логгирование ошибки или вывод сообщения
'            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
'        End Try

'    End Sub
'End Class

Imports System.Data
Imports System.Data.SqlClient


Partial Class ChangeAccountData
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connCatalog As String = b.GetConnStr("connCatalog")
    Dim BRU As String = b.GetConnStr("BRU")
    Dim soate As String = b.GetConnStr("soate")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If (Session("Nalog") IsNot Nothing) Then
                    ' Загружаем данные пользователя
                    'LoadUserData()
                    LoadTerritoryCodes2()
                    LoadTerritoryCodes()
                    'LoadOkedData()
                    'LoadOkedData("")
                Else
                    ' Перенаправление на другую страницу, если сессия не активна.
                    Response.Redirect("Default.aspx")
                    HttpContext.Current.ApplicationInstance.CompleteRequest()
                End If
            End If
        Catch ex As Exception
            ' Логгирование ошибки или вывод сообщения
            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
        End Try
    End Sub





    'Protected Sub fvUserDetails_ItemInserting(sender As Object, e As FormViewInsertEventArgs)
    '    Try
    '        ' Получаем данные с формы
    '        Dim firstYear As String = CType(fvUserDetails.FindControl("txtFirstYear"), TextBox).Text
    '        Dim kpred As String = CType(fvUserDetails.FindControl("txtKpred"), TextBox).Text
    '        Dim nameCompany As String = CType(fvUserDetails.FindControl("txtNameCompany"), TextBox).Text
    '        Dim fullName As String = CType(fvUserDetails.FindControl("txtFullName"), TextBox).Text
    '        Dim territoryCode As String = CType(fvUserDetails.FindControl("txtTerritoryCode"), TextBox).Text

    '        ' Подключаемся к базе данных
    '        Dim connectionString As String = BRU ' Используем строку подключения BRU
    '        Using conn As New SqlConnection(connectionString)
    '            Dim query As String = "INSERT INTO dbo.KatmeUvedom (FirstYear, Kpred, NameCompany, FullName, TerritoryCode) " &
    '                                  "VALUES (@FirstYear, @Kpred, @NameCompany, @FullName, @TerritoryCode)"

    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@FirstYear", firstYear)
    '            cmd.Parameters.AddWithValue("@Kpred", kpred)
    '            cmd.Parameters.AddWithValue("@NameCompany", nameCompany)
    '            cmd.Parameters.AddWithValue("@FullName", fullName)
    '            cmd.Parameters.AddWithValue("@TerritoryCode", Convert.ToInt64(territoryCode))

    '            conn.Open()
    '            cmd.ExecuteNonQuery()
    '        End Using
    '    Catch ex As Exception
    '        ' Логгирование ошибки или вывод сообщения
    '        Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
    '    End Try
    'End Sub
    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
    '    If Not IsPostBack Then
    '        LoadTerritoryCodes()
    '    End If
    'End Sub



    'Private Sub LoadTerritoryCodes()
    '    ' Проверьте, что объект ddlTerritoryCode не равен Nothing
    '    If ddlTerritoryCode() Is Nothing Then
    '        Response.Write("<p align='center'>Элемент ddlTerritoryCode не найден.</p>")
    '        Return
    '    End If

    '    Dim connectionString As String = soate ' Проверьте, что строка подключения корректна
    '    Dim query As String = "SELECT KOD, NAME FROM dbo.SOATE"

    '    Try
    '        Using conn As New SqlConnection(connectionString)
    '            Using cmd As New SqlCommand(query, conn)
    '                conn.Open()

    '                Using reader As SqlDataReader = cmd.ExecuteReader()
    '                    ddlTerritoryCode.Items.Clear()
    '                    ddlTerritoryCode.Items.Add(New ListItem("Выберите территорию", "")) ' Значение по умолчанию

    '                    While reader.Read()
    '                        Dim territoryCode As String = reader("KOD").ToString()
    '                        Dim territoryName As String = reader("NAME").ToString()
    '                        ddlTerritoryCode.Items.Add(New ListItem(territoryName, territoryCode))
    '                    End While
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        ' Логгирование ошибки
    '        Response.Write("<p align='center'>Произошла ошибка: " & ex.Message & "</p>")
    '    End Try
    'End Sub












    'Private Sub LoadTerritoryCodes()
    '    Dim ddlTerritoryCode As DropDownList = CType(fvUserDetails.FindControl("ddlTerritoryCode"), DropDownList)
    '    Dim connectionString As String = soate ' Используем строку подключения BRU
    '    Dim query As String = "SELECT KOD, NAME FROM dbo.SOATE" ' Измените запрос в зависимости от вашей таблицы

    '    Using conn As New SqlConnection(connectionString)
    '        Dim cmd As New SqlCommand(query, conn)
    '        conn.Open()
    '        Dim reader As SqlDataReader = cmd.ExecuteReader()

    '        ddlTerritoryCode.Items.Clear()
    '        ddlTerritoryCode.Items.Add(New ListItem("Выберите территорию", "")) ' Значение по умолчанию

    '        While reader.Read()
    '            Dim territoryCode As String = reader("KOD").ToString()
    '            Dim territoryName As String = reader("NAME").ToString()
    '            ddlTerritoryCode.Items.Add(New ListItem(territoryName, territoryCode))
    '        End While
    '    End Using
    'End Sub




    'Protected Sub fvUserDetails_DataBound(sender As Object, e As EventArgs)
    '    If fvUserDetails.CurrentMode = FormViewMode.Insert Then
    '        FillTerritoryDropDownList()
    '    End If
    'End Sub

    'Private Sub FillTerritoryDropDownList()
    '    Dim connectionString As String = soate ' Используем строку подключения BRU
    '    Using conn As New SqlConnection(connectionString)
    '        Dim query As String = "SELECT KOD, NAME FROM dbo.SOATE" ' Замените на вашу таблицу и поля

    '        Dim cmd As New SqlCommand(query, conn)
    '        conn.Open()

    '        Dim reader As SqlDataReader = cmd.ExecuteReader()
    '        Dim ddlTerritoryCode As DropDownList = CType(fvUserDetails.FindControl("ddlTerritoryCode"), DropDownList)
    '        If ddlTerritoryCode IsNot Nothing Then
    '            ddlTerritoryCode.DataSource = reader
    '            ddlTerritoryCode.DataTextField = "NAME"
    '            ddlTerritoryCode.DataValueField = "KOD"
    '            ddlTerritoryCode.DataBind()

    '            ' Добавление пустого элемента в начало списка
    '            ddlTerritoryCode.Items.Insert(0, New ListItem("-- Выберите территорию --", ""))
    '        End If
    '    End Using
    'End Sub

    'Protected Sub fvUserDetails_ItemInserting(sender As Object, e As FormViewInsertEventArgs)
    '    Try
    '        Dim ddlTerritoryCode As DropDownList = CType(fvUserDetails.FindControl("ddlTerritoryCode"), DropDownList)
    '        Dim territoryCode As String = If(ddlTerritoryCode IsNot Nothing, ddlTerritoryCode.SelectedValue, "")

    '        ' Получаем данные с формы
    '        Dim firstYear As String = CType(fvUserDetails.FindControl("txtFirstYear"), TextBox).Text
    '        Dim kpred As String = CType(fvUserDetails.FindControl("txtKpred"), TextBox).Text
    '        Dim nameCompany As String = CType(fvUserDetails.FindControl("txtNameCompany"), TextBox).Text
    '        Dim fullName As String = CType(fvUserDetails.FindControl("txtFullName"), TextBox).Text

    '        ' Подключаемся к базе данных
    '        Dim connectionString As String = BRU ' Используем строку подключения BRU
    '        Using conn As New SqlConnection(connectionString)
    '            Dim query As String = "INSERT INTO dbo.KatmeUvedom (FirstYear, Kpred, NameCompany, FullName, TerritoryCode) " &
    '                              "VALUES (@FirstYear, @Kpred, @NameCompany, @FullName, @TerritoryCode)"

    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@FirstYear", firstYear)
    '            cmd.Parameters.AddWithValue("@Kpred", kpred)
    '            cmd.Parameters.AddWithValue("@NameCompany", nameCompany)
    '            cmd.Parameters.AddWithValue("@FullName", fullName)
    '            cmd.Parameters.AddWithValue("@TerritoryCode", If(String.IsNullOrEmpty(territoryCode), DBNull.Value, Convert.ToInt64(territoryCode)))

    '            conn.Open()
    '            cmd.ExecuteNonQuery()
    '        End Using
    '    Catch ex As Exception
    '        ' Логгирование ошибки или вывод сообщения
    '        Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
    '    End Try
    'End Sub




    Private Sub LoadTerritoryCodes2()
        ' Получение элемента управления FormView
        Dim ddlRegion As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlRegion"), DropDownList)
        Dim ddlDistrict As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlDistrict"), DropDownList)
        Dim ddlSettlement As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlSettlement"), DropDownList)

        ' Проверка, что элемент управления FormView найден
        If ddlRegion Is Nothing OrElse ddlDistrict Is Nothing OrElse ddlSettlement Is Nothing Then
            Return
        End If

        Dim connectionString As String = soate ' Проверьте корректность строки подключения
        Dim query As String = "SELECT distinct left(KOD, 5) as KOD, NAME FROM dbo.SOATE where [level_] = 2"

        Try
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ddlRegion.Items.Clear()
                ddlRegion.Items.Add(New ListItem("Область", "")) ' Значение по умолчанию

                While reader.Read()
                    Dim territoryCode As String = reader("KOD").ToString()
                    Dim territoryName As String = reader("NAME").ToString()
                    ddlRegion.Items.Add(New ListItem(territoryName, territoryCode))
                End While
            End Using
        Catch ex As Exception
            ' Логгирование ошибки
            Response.Write("<p align='center'>" & ex.Message & "</p>")
        End Try
    End Sub

    ' Загружаем районы в зависимости от выбранной области
    Protected Sub trnslt_ddlRegion_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim ddlRegion As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlRegion"), DropDownList)
        Dim ddlDistrict As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlDistrict"), DropDownList)

        If ddlRegion.SelectedValue = "" Then
            Return ' Если не выбрана область, не показываем районы
        End If

        ' Запрос для получения районов по выбранной области
        Dim connectionString As String = soate
        Dim query As String = "SELECT distinct left(KOD, 8) as KOD, NAME FROM dbo.SOATE WHERE KOD LIKE @RegionCode + '%' AND [level_] = 4"

        Try
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RegionCode", ddlRegion.SelectedValue)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ddlDistrict.Items.Clear()
                ddlDistrict.Items.Add(New ListItem("Район", "")) ' Значение по умолчанию

                While reader.Read()
                    Dim districtCode As String = reader("KOD").ToString()
                    Dim districtName As String = reader("NAME").ToString()
                    ddlDistrict.Items.Add(New ListItem(districtName, districtCode))
                End While
            End Using
        Catch ex As Exception
            Response.Write("<p align='center'>" & ex.Message & "</p>")
        End Try
    End Sub

    ' Загружаем населенные пункты в зависимости от выбранного района
    Protected Sub trnslt_ddlDistrict_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim ddlDistrict As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlDistrict"), DropDownList)
        Dim ddlSettlement As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlSettlement"), DropDownList)

        If ddlDistrict.SelectedValue = "" Then
            Return ' Если не выбран район, не показываем населенные пункты
        End If

        ' Запрос для получения населенных пунктов по выбранному району
        Dim connectionString As String = soate
        Dim query As String = "SELECT distinct left(KOD, 14) as KOD, NAME FROM dbo.SOATE WHERE KOD LIKE @DistrictCode + '%' AND [level_] in (7,8)"

        Try
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@DistrictCode", ddlDistrict.SelectedValue)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ddlSettlement.Items.Clear()
                ddlSettlement.Items.Add(New ListItem("Населенный пункт", "")) ' Значение по умолчанию

                While reader.Read()
                    Dim settlementCode As String = reader("KOD").ToString()
                    Dim settlementName As String = reader("NAME").ToString()
                    ddlSettlement.Items.Add(New ListItem(settlementName, settlementCode))
                End While
            End Using
        Catch ex As Exception
            Response.Write("<p align='center'>" & ex.Message & "</p>")
        End Try
    End Sub








    Private Sub LoadTerritoryCodes()
        ' Получение элемента управления FormView
        Dim ddlTerritoryCode As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlTerritoryCode"), DropDownList)

        ' Проверка, что элемент управления FormView найден


        ' Получение элемента управления DropDownList из FormView


        ' Проверка, что элемент управления DropDownList найден
        If ddlTerritoryCode Is Nothing Then

            Return
        End If

        Dim connectionString As String = soate ' Проверьте корректность строки подключения
        Dim query As String = "SELECT left(KOD, 14) as KOD, NAME FROM dbo.SOATE where [level_] in (7,8)"

        Try
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ddlTerritoryCode.Items.Clear()
                ddlTerritoryCode.Items.Add(New ListItem("Выберите территорию", "")) ' Значение по умолчанию

                While reader.Read()
                    Dim territoryCode As String = reader("KOD").ToString()
                    Dim territoryName As String = reader("NAME").ToString()
                    ddlTerritoryCode.Items.Add(New ListItem(territoryName, territoryCode))
                    ' Отладочное сообщение

                End While
            End Using
        Catch ex As Exception
            ' Логгирование ошибки
            Response.Write("<p align='center'>" & ex.Message & "</p>")
        End Try
    End Sub



    'Protected Sub Trnslt_Oked_3_com2_TextChanged(sender As Object, e As EventArgs)
    '    Dim fvUserDetails As FormView = CType(Page.FindControl("fvUserDetails"), FormView)
    '    Dim txtOked As TextBox = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), TextBox)
    '    Dim ddlOked As DropDownList = CType(fvUserDetails.FindControl("ddlOked"), DropDownList)

    '    If txtOked Is Nothing OrElse ddlOked Is Nothing Then
    '        Response.Write("<p align='center'>Не удалось найти элементы управления.</p>")
    '        Return
    '    End If

    '    Dim inputText As String = txtOked.Text.Trim()
    '    If String.IsNullOrEmpty(inputText) Then
    '        ddlOked.Items.Clear()
    '        ddlOked.Items.Add(New ListItem("Введите текст для поиска", ""))
    '        Return
    '    End If

    '    Dim query As String = "SELECT KOD, NAME FROM OKED3 WHERE KOD LIKE @InputText + '%'"
    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@InputText", inputText)
    '            conn.Open()
    '            Dim reader As SqlDataReader = cmd.ExecuteReader()

    '            ddlOked.Items.Clear()
    '            While reader.Read()
    '                Dim kod As String = reader("KOD").ToString()
    '                Dim name As String = reader("NAME").ToString()
    '                ddlOked.Items.Add(New ListItem($"{name} ({kod})", kod))
    '            End While
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p align='center'>" & ex.Message & "</p>")
    '    End Try
    'End Sub




    'Protected Sub Trnslt_Oked_3_com2_TextChanged(sender As Object, e As EventArgs)
    '    Dim txtOked As TextBox = CType(Page.FindControl("trnslt_Oked_3_com2"), TextBox)
    '    Dim ddlOked As DropDownList = CType(Page.FindControl("ddlOked"), DropDownList)

    '    If txtOked Is Nothing OrElse ddlOked Is Nothing Then
    '        Response.Write("<p align='center'>Элементы управления не найдены.</p>")
    '        Return
    '    End If

    '    Dim inputText As String = txtOked.Text.Trim()
    '    If String.IsNullOrEmpty(inputText) Then
    '        ddlOked.Items.Clear()
    '        ddlOked.Items.Add(New ListItem("Введите текст для поиска", ""))
    '        Return
    '    End If

    '    Dim query As String = "SELECT KOD, NAME FROM dbo.OKED3 WHERE KOD LIKE @InputText + '%'"
    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@InputText", inputText)
    '            conn.Open()
    '            Dim reader As SqlDataReader = cmd.ExecuteReader()

    '            ddlOked.Items.Clear()
    '            If reader.HasRows Then
    '                While reader.Read()
    '                    Dim kod As String = reader("KOD").ToString()
    '                    Dim name As String = reader("NAME").ToString()
    '                    ddlOked.Items.Add(New ListItem(name & " (" & kod & ")", kod))
    '                End While
    '            Else
    '                ddlOked.Items.Add(New ListItem("Нет совпадений.", ""))
    '            End If
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p align='center'>Ошибка: " & ex.Message & "</p>")
    '    End Try

    '    Dim updatePanel As UpdatePanel = CType(Page.FindControl("UpdatePanel1"), UpdatePanel)
    '    If updatePanel IsNot Nothing Then
    '        updatePanel.Update()
    '    Else
    '        Response.Write("<p align='center'>UpdatePanel1 не найден.</p>")
    '    End If
    'End Sub


    'Protected Sub Trnslt_Oked_3_com2_TextChanged(sender As Object, e As EventArgs)
    '    Dim txtOked As TextBox = CType(Page.FindControl("trnslt_Oked_3_com2"), TextBox)
    '    Dim ddlOked As DropDownList = CType(Page.FindControl("ddlOked"), DropDownList)

    '    If txtOked Is Nothing OrElse ddlOked Is Nothing Then
    '        Response.Write("<p align='center'>Элементы управления не найдены.</p>")
    '        Return
    '    End If

    '    Dim inputText As String = txtOked.Text.Trim()
    '    If String.IsNullOrEmpty(inputText) Then
    '        ddlOked.Items.Clear()
    '        ddlOked.Items.Add(New ListItem("Введите текст для поиска", ""))
    '        Return
    '    End If

    '    Dim query As String = "SELECT KOD, NAME FROM OKED3 WHERE KOD LIKE @InputText + '%'"
    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@InputText", inputText)
    '            conn.Open()
    '            Dim reader As SqlDataReader = cmd.ExecuteReader()

    '            ddlOked.Items.Clear()
    '            If reader.HasRows Then
    '                While reader.Read()
    '                    Dim kod As String = reader("KOD").ToString()
    '                    Dim name As String = reader("NAME").ToString()
    '                    ddlOked.Items.Add(New ListItem(name & " (" & kod & ")", kod))
    '                End While
    '            Else
    '                ddlOked.Items.Add(New ListItem("Нет совпадений.", ""))
    '            End If
    '        End Using
    '    Catch ex As Exception
    '        Response.Write(String.Format("<p align='center'>Ошибка: {0}</p>", ex.Message))
    '    End Try
    'End Sub






    'Protected Sub Trnslt_Oked_3_com2_TextChanged(sender As Object, e As EventArgs)
    '    Dim txtOked As TextBox = CType(Page.FindControl("trnslt_Oked_3_com2"), TextBox)
    '    Dim ddlOked As DropDownList = CType(Page.FindControl("ddlOked"), DropDownList)

    '    If txtOked Is Nothing OrElse ddlOked Is Nothing Then
    '        Response.Write("<p align='center'>Элементы управления не найдены.</p>")
    '        Return
    '    End If

    '    Dim inputText As String = txtOked.Text.Trim()
    '    Response.Write("<p align='center'>Введенный текст: " & inputText & "</p>") ' Отладка

    '    If String.IsNullOrEmpty(inputText) Then
    '        ddlOked.Items.Clear()
    '        ddlOked.Items.Add(New ListItem("Введите текст для поиска", ""))
    '        Return
    '    End If

    '    Dim query As String = "SELECT KOD, NAME FROM OKED3"
    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@InputText", inputText)
    '            conn.Open()
    '            Dim reader As SqlDataReader = cmd.ExecuteReader()

    '            ddlOked.Items.Clear()
    '            If reader.HasRows Then
    '                Response.Write("<p align='center'>Данные найдены:</p>")
    '                While reader.Read()
    '                    Dim kod As String = reader("KOD").ToString()
    '                    Dim name As String = reader("NAME").ToString()
    '                    ddlOked.Items.Add(New ListItem(name & " (" & kod & ")", kod))
    '                End While
    '            Else
    '                ddlOked.Items.Add(New ListItem("Нет совпадений.", ""))
    '                Response.Write("<p align='center'>Нет совпадений.</p>")
    '            End If
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p align='center'>Ошибка: " & ex.Message & "</p>")
    '    End Try

    '    ' Обновляем UpdatePanel
    '    Dim updatePanel As UpdatePanel = CType(Page.FindControl("UpdatePanel1"), UpdatePanel)
    '    If updatePanel IsNot Nothing Then
    '        updatePanel.Update()
    '    End If
    'End Sub


    'Private Sub LoadOkedData()
    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim query As String = "SELECT KOD, NAME FROM dbo.OKED3"
    '            Dim cmd As New SqlCommand(query, conn)
    '            conn.Open()

    '            Dim reader As SqlDataReader = cmd.ExecuteReader()

    '            ddlOked.Items.Clear()
    '            ddlOked.Items.Add(New ListItem("-- Выберите значение --", "")) ' Элемент по умолчанию

    '            If reader.HasRows Then
    '                While reader.Read()
    '                    Dim kod As String = reader("KOD").ToString()
    '                    Dim name As String = reader("NAME").ToString()
    '                    ddlOked.Items.Add(New ListItem(name & " (" & kod & ")", kod)) ' Используем конкатенацию
    '                End While
    '            Else
    '                ddlOked.Items.Add(New ListItem("Нет данных.", ""))
    '            End If
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p align='center'>Ошибка: " & ex.Message & "</p>")
    '    End Try

    'End Sub





    ' Метод для загрузки данных OKED3 в DropDownList
    'Private Sub LoadOkedData()
    '    Dim ddlOked As DropDownList = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), DropDownList)



    '    If ddlOked Is Nothing Then
    '        Response.Write("<p>DropDownList не найден.</p>")
    '        Return
    '    End If

    '    Dim query As String = "SELECT kod, name FROM dbo.OKED3"
    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            conn.Open()

    '            Dim reader As SqlDataReader = cmd.ExecuteReader()
    '            If Not reader.HasRows Then
    '                Response.Write("<p>Нет данных для отображения.</p>")
    '                Return
    '            End If

    '            ddlOked.Items.Clear()
    '            ddlOked.Items.Add(New ListItem("Выберите вид деятельности", "")) ' Значение по умолчанию

    '            While reader.Read()
    '                Dim okedCode As String = reader("kod").ToString()
    '                Dim okedName As String = reader("name").ToString()
    '                ddlOked.Items.Add(New ListItem(okedName, okedCode))
    '            End While
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p>Ошибка: " & ex.Message & "</p>")
    '    End Try
    'End Sub


    'Private Sub LoadOkedData()
    '    ' Попробуйте найти DropDownList
    '    Dim ddlOked As DropDownList = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), DropDownList)

    '    ' Если элемент не найден
    '    If ddlOked Is Nothing Then
    '        Response.Write("<p>DropDownList не найден.</p>")
    '        Return
    '    End If

    '    Dim query As String = "SELECT kod, name FROM dbo.OKED3"
    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            conn.Open()

    '            Dim reader As SqlDataReader = cmd.ExecuteReader()
    '            If Not reader.HasRows Then
    '                Response.Write("<p>Нет данных для отображения.</p>")
    '                Return
    '            End If

    '            ddlOked.Items.Clear()
    '            ddlOked.Items.Add(New ListItem("Выберите вид деятельности", "")) ' Значение по умолчанию

    '            While reader.Read()
    '                Dim okedCode As String = reader("kod").ToString()
    '                Dim okedName As String = reader("name").ToString()
    '                ' Формируем текст как "(код) - название", а значение как "код"
    '                Dim displayText As String = "(" & okedCode & ") - " & okedName
    '                ddlOked.Items.Add(New ListItem(displayText, okedCode))
    '            End While
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p>Ошибка: " & ex.Message & "</p>")
    '    End Try
    'End Sub







    'Private Sub LoadOkedData(searchText As String)
    '    ' Попробуйте найти DropDownList
    '    Dim ddlOked As DropDownList = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), DropDownList)

    '    ' Если элемент не найден
    '    If ddlOked Is Nothing Then
    '        Response.Write("<p>DropDownList не найден.</p>")
    '        Return
    '    End If

    '    ' Обновляем запрос для фильтрации по тексту
    '    Dim query As String = "SELECT kod, name FROM dbo.OKED3 WHERE name LIKE @SearchText"

    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
    '            conn.Open()

    '            Dim reader As SqlDataReader = cmd.ExecuteReader()
    '            If Not reader.HasRows Then
    '                ddlOked.Items.Clear()
    '                ddlOked.Items.Add(New ListItem("Нет данных для отображения", ""))
    '                Return
    '            End If

    '            ddlOked.Items.Clear()
    '            ddlOked.Items.Add(New ListItem("Выберите вид деятельности", "")) ' Значение по умолчанию

    '            While reader.Read()
    '                Dim okedCode As String = reader("kod").ToString()
    '                Dim okedName As String = reader("name").ToString()
    '                ' Формируем текст как "(код) - название", а значение как "код"
    '                Dim displayText As String = "(" & okedCode & ") - " & okedName
    '                ddlOked.Items.Add(New ListItem(displayText, okedCode))
    '            End While
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p>Ошибка: " & ex.Message & "</p>")
    '    End Try
    'End Sub




    'Protected Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
    '    ' Получаем текст из поля поиска
    '    'Dim trnslt_Oked_3_com2 As String = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), TextBox).Text
    '    Dim searchText As String = CType(fvUserDetails.FindControl("txtSearch"), TextBox).Text
    '    ' Загружаем данные с фильтрацией
    '    LoadOkedData(searchText)
    'End Sub

    '' Метод для загрузки данных с фильтрацией
    'Private Sub LoadOkedData(searchText As String)
    '    ' Попробуйте найти DropDownList
    '    Dim ddlOked As DropDownList = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), DropDownList)

    '    ' Если элемент не найден
    '    If ddlOked Is Nothing Then
    '        Response.Write("<p>DropDownList не найден.</p>")
    '        Return
    '    End If

    '    ' Обновляем запрос для фильтрации по тексту
    '    Dim query As String = "SELECT kod, name FROM dbo.OKED3 WHERE ((name LIKE @SearchText + '%') or (kod LIKE @SearchText + '%'))"

    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
    '            conn.Open()

    '            Dim reader As SqlDataReader = cmd.ExecuteReader()
    '            If Not reader.HasRows Then
    '                ddlOked.Items.Clear()
    '                ddlOked.Items.Add(New ListItem("Нет данных для отображения", ""))
    '                Return
    '            End If

    '            ddlOked.Items.Clear()
    '            ddlOked.Items.Add(New ListItem("Выберите вид деятельности", "")) ' Значение по умолчанию

    '            While reader.Read()
    '                Dim okedCode As String = reader("kod").ToString()
    '                Dim okedName As String = reader("name").ToString()
    '                ' Формируем текст как "(код) - название", а значение как "код"
    '                Dim displayText As String = "(" & okedCode & ") - " & okedName
    '                ddlOked.Items.Add(New ListItem(displayText, okedCode))
    '            End While
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p>Ошибка: " & ex.Message & "</p>")
    '    End Try
    'End Sub







    'Protected Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
    '    ' Получаем текст из поля поиска
    '    Dim searchText As String = CType(fvUserDetails.FindControl("txtSearch"), TextBox).Text
    '    ' Загружаем данные с фильтрацией
    '    LoadOkedData(searchText)
    'End Sub

    '' Метод для загрузки данных с фильтрацией
    'Private Sub LoadOkedData(searchText As String)
    '    ' Попробуйте найти DropDownList
    '    Dim ddlOked As DropDownList = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), DropDownList)

    '    ' Если элемент не найден
    '    If ddlOked Is Nothing Then
    '        Response.Write("<p>DropDownList не найден.</p>")
    '        Return
    '    End If

    '    ' Обновляем запрос для фильтрации по тексту
    '    Dim query As String = "SELECT kod, name FROM dbo.OKED3 WHERE ((name LIKE @SearchText + '%') or (kod LIKE @SearchText + '%'))"

    '    Try
    '        Using conn As New SqlConnection(connCatalog)
    '            Dim cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
    '            conn.Open()

    '            Dim reader As SqlDataReader = cmd.ExecuteReader()
    '            If Not reader.HasRows Then
    '                ddlOked.Items.Clear()
    '                ddlOked.Items.Add(New ListItem("Нет данных для отображения", ""))
    '                Return
    '            End If

    '            ddlOked.Items.Clear()
    '            ddlOked.Items.Add(New ListItem("Выберите вид деятельности", "")) ' Значение по умолчанию

    '            While reader.Read()
    '                Dim okedCode As String = reader("kod").ToString()
    '                Dim okedName As String = reader("name").ToString()
    '                ' Формируем текст как "(код) - название", а значение как "код"
    '                Dim displayText As String = "(" & okedCode & ") - " & okedName
    '                ddlOked.Items.Add(New ListItem(displayText, okedCode))
    '            End While
    '        End Using
    '    Catch ex As Exception
    '        Response.Write("<p>Ошибка: " & ex.Message & "</p>")
    '    End Try
    'End Sub








    Protected Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        ' Получаем текст из поля поиска
        Dim searchText As String = CType(fvUserDetails.FindControl("trnslt_Oked_3_com221"), TextBox).Text
        ' Загружаем данные с фильтрацией
        LoadOkedData(searchText)
    End Sub

    ' Метод для загрузки данных с фильтрацией
    Private Sub LoadOkedData(searchText As String)
        ' Получаем DropDownList
        Dim ddlOked As DropDownList = CType(fvUserDetails.FindControl("trnslt_Oked_3_com22"), DropDownList)

        ' Если элемент не найден
        If ddlOked Is Nothing Then
            Response.Write("<p>DropDownList не найден.</p>")
            Return
        End If

        ' SQL-запрос с фильтрацией по тексту
        Dim query As String = "SELECT kod, name FROM dbo.OKED3 WHERE (name LIKE @SearchText OR kod LIKE @SearchText)"

        Try
            ' Создаем подключение и выполняем запрос
            Using conn As New SqlConnection(connCatalog)
                Dim cmd As New SqlCommand(query, conn)
                ' Добавляем параметры для запроса
                cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
                conn.Open()

                ' Выполняем команду и получаем результат
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ' Если нет данных, очищаем список и выводим сообщение
                If Not reader.HasRows Then
                    ddlOked.Items.Clear()
                    ddlOked.Items.Add(New ListItem("Нет данных для отображения", ""))
                    Return
                End If

                ' Очищаем предыдущие элементы и добавляем новый элемент по умолчанию
                ddlOked.Items.Clear()
                ddlOked.Items.Add(New ListItem("Выберите вид деятельности", ""))

                ' Читаем данные из результата запроса
                While reader.Read()
                    Dim okedCode As String = reader("kod").ToString()
                    Dim okedName As String = reader("name").ToString()
                    ' Формируем текст как "(код) - название", а значение как "код"
                    Dim displayText As String = "(" & okedCode & ") - " & okedName
                    ddlOked.Items.Add(New ListItem(displayText, okedCode))
                End While
            End Using
        Catch ex As Exception
            ' В случае ошибки выводим сообщение
            Response.Write("<p>Ошибка: " & ex.Message & "</p>")
        End Try
    End Sub













    Protected Sub fvUserDetails_ItemInserting(sender As Object, e As FormViewInsertEventArgs)
        Try
            ' Получаем выбранное значение из DropDownList
            Dim trnslt_ddlRegion As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlRegion"), DropDownList)
            Dim trnslt_ddlDistrict As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlDistrict"), DropDownList)
            Dim trnslt_ddlSettlement As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlSettlement"), DropDownList)
            Dim ddlTerritoryCode As DropDownList = CType(fvUserDetails.FindControl("trnslt_ddlTerritoryCode"), DropDownList)
            Dim territoryCode2 As String = If(trnslt_ddlRegion IsNot Nothing, trnslt_ddlRegion.SelectedValue, "")
            Dim territoryCode3 As String = If(trnslt_ddlDistrict IsNot Nothing, trnslt_ddlDistrict.SelectedValue, "")
            Dim territoryCode4 As String = If(trnslt_ddlSettlement IsNot Nothing, trnslt_ddlSettlement.SelectedValue, "")
            Dim territoryCode As String = If(ddlTerritoryCode IsNot Nothing, ddlTerritoryCode.SelectedValue, "")
            'Dim firstYear As String = CType(fvUserDetails.FindControl("txtFirstYear"), TextBox).Text
            'Dim kpred As String = CType(fvUserDetails.FindControl("txtKpred"), TextBox).Text
            'Dim nameCompany As String = CType(fvUserDetails.FindControl("txtNameCompany"), TextBox).Text
            'Dim fullName As String = CType(fvUserDetails.FindControl("txtFullName"), TextBox).Text
            Dim trnslt_INN_user2 As String = CType(fvUserDetails.FindControl("trnslt_INN_user2"), TextBox).Text
            Dim trnslt_TextNameCompany2 As String = CType(fvUserDetails.FindControl("trnslt_TextNameCompany2"), TextBox).Text
            'Dim fullName As String = CType(fvUserDetails.FindControl("trnslt_K_NPU_ter2"), TextBox).Text
            Dim trnslt_ADRESS_Company2 As String = CType(fvUserDetails.FindControl("trnslt_ADRESS_Company2"), TextBox).Text
            Dim trnslt_T_ON2 As String = CType(fvUserDetails.FindControl("trnslt_T_ON2"), TextBox).Text
            Dim trnslt_Email_company2 As String = CType(fvUserDetails.FindControl("trnslt_Email_company2"), TextBox).Text
            Dim trnslt_FirstName_company2 As String = CType(fvUserDetails.FindControl("trnslt_FirstName_company2"), TextBox).Text
            'Dim trnslt_Oked_3_com2 As String = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), TextBox).Text
            'Dim lblMessage As String = CType(fvUserDetails.FindControl("lblMessage"), TextBox).Text

            'Dim okedTextBox As TextBox = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), TextBox)
            'Dim trnslt_Oked_3_com2 As String = String.Empty

            'If okedTextBox IsNot Nothing Then
            '    trnslt_Oked_3_com2 = okedTextBox.Text
            'Else
            '    ' Обработка ситуации, если элемент не найден
            '    Response.Write("<p align='center'>Поле ввода 'trnslt_Oked_3_com2' не найдено.</p>")
            'End If
            Dim ddlOked As DropDownList = CType(fvUserDetails.FindControl("trnslt_Oked_3_com2"), DropDownList)
            Dim trnslt_Oked_3_com2 As String = ""
            If ddlOked IsNot Nothing Then
                trnslt_Oked_3_com2 = ddlOked.SelectedValue ' Получение выбранного значения
            End If




            Dim currentYear As String = DateTime.Now.Year.ToString() ' Текущий год
            Dim currentMonth As String = DateTime.Now.Month.ToString("D2") ' Текущий месяц (с ведущим нулём, например, "01")
            'Dim id As String = currentYear & currentMonth

            Dim appUser As String = Session("Nalog").ToString()

            ' Соединение с первым сервером (или базой данных)
            Dim query1 As String = "SELECT * FROM dbo.ISTAPPUsers WHERE APPUser = @APPUser"
            Dim userData As DataTable = New DataTable()

            Using conn1 As New SqlConnection(connIST)
                Using cmd1 As New SqlCommand(query1, conn1)
                    cmd1.Parameters.AddWithValue("@APPUser", appUser)
                    conn1.Open()

                    Using reader1 As SqlDataReader = cmd1.ExecuteReader()
                        userData.Load(reader1)
                    End Using
                End Using
            End Using

            ' Проверьте имена столбцов
            Dim columns As String = String.Join(", ", userData.Columns.Cast(Of DataColumn)().Select(Function(c) c.ColumnName))
            Response.Write("<p align='center'>Столбцы в userData: " & columns & "</p>")

            ' Убедитесь, что K_PRED присутствует
            If Not userData.Columns.Contains("APPUser") Then
                Throw New Exception("Столбец 'K_PRED' не найден в DataTable.")
            End If


            Dim lblErrorMessage As Label = CType(fvUserDetails.FindControl("trnslt_lblErrorMessage"), Label)
            If trnslt_ddlRegion.SelectedValue = "" OrElse trnslt_ddlDistrict.SelectedValue = "" OrElse trnslt_ddlSettlement.SelectedValue = "" Then
                ' Показать сообщение об ошибке
                'lblErrorMessage.Text = "Пожалуйста, выберите область, район и населенный пункт."
                lblErrorMessage.Visible = True
                Return ' Останавливаем обработку
            End If

            ' Дальнейшая обработка формы
            lblErrorMessage.Visible = False

            ' Проверяем, что значение выбрано
            If String.IsNullOrEmpty(territoryCode2) Then
                ' Если значение не выбрано, можно либо предотвратить вставку, либо установить значение по умолчанию
                ' Пример: задаем значение по умолчанию или выбрасываем исключение
                e.Cancel = True
                Response.Write("<p align='center'>Пожалуйста, выберите территорию.</p>")
                Return
                If String.IsNullOrEmpty(trnslt_TextNameCompany2) Then
                    e.Cancel = True
                    Response.Write("<p align='center'>Пожалуйста, введите называние.</p>")
                    Return

                End If
            End If

            ' Получаем данные с формы


            ' Подключаемся к базе данных
            Dim connectionString As String = BRU ' Используем строку подключения BRU


            '        Using conn As New SqlConnection(connectionString)
            '            Dim query As String = "INSERT INTO dbo.KatmeUvedom2 (K_PRED,NAME,K_NPUF,[ADDRESS],[FIO],[T_ON],[EMAIL],[OKED_3],[INN]) " &
            '                                                        "VALUES ('122132',@NAME,@TerritoryCode,@ADDRESS,@FIO,@T_ON,@EMAIL,@OKED_3,@INN)"

            '            Dim cmd As New SqlCommand(query, conn)
            '            cmd.Parameters.AddWithValue("@INN", trnslt_INN_user2)
            '            cmd.Parameters.AddWithValue("@NAME", trnslt_TextNameCompany2)
            '            'cmd.Parameters.AddWithValue("@INN", trnslt_K_NPU_ter2)
            '            cmd.Parameters.AddWithValue("@ADDRESS", trnslt_ADRESS_Company2)
            '            cmd.Parameters.AddWithValue("@T_ON", trnslt_T_ON2)
            '            cmd.Parameters.AddWithValue("@EMAIL", trnslt_Email_company2)
            '            cmd.Parameters.AddWithValue("@FIO", trnslt_FirstName_company2)
            '            cmd.Parameters.AddWithValue("@OKED_3", trnslt_Oked_3_com2)
            '            'cmd.Parameters.AddWithValue("@FirstYear", firstYear)
            '            'cmd.Parameters.AddWithValue("@Kpred", kpred)
            '            'cmd.Parameters.AddWithValue("@NameCompany", nameCompany)
            '            'cmd.Parameters.AddWithValue("@FullName", fullName)
            '            cmd.Parameters.AddWithValue("@TerritoryCode", Convert.ToString(territoryCode))

            '            conn.Open()
            '            cmd.ExecuteNonQuery()
            '        End Using
            '    Catch ex As Exception
            '        ' Логгирование ошибки или вывод сообщения
            '        Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
            '    End Try
            'End Sub


            'Using conn As New SqlConnection(connectionString)
            '    Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.KatmeUvedom2 WHERE K_PRED = @K_PRED and GOD = @year and MES = @month"
            '    Dim insertQuery As String = "INSERT INTO dbo.KatmeUvedom2 (K_PRED, NAME, K_NPUF, [ADDRESS], [FIO], [T_ON], [EMAIL], [OKED_3], [INN]) " &
            '                                "VALUES (@K_PRED, @NAME, @TerritoryCode, @ADDRESS, @FIO, @T_ON, @EMAIL, @OKED_3, @INN)"

            '    Dim cmdCheck As New SqlCommand(checkQuery, conn)
            '    cmdCheck.Parameters.AddWithValue("@K_PRED", "122132")

            '    conn.Open()

            '    Dim recordExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
            '    If recordExists > 0 Then
            '        ' Запись уже существует
            '        Response.Write("<p align='center'>Запись с таким K_PRED уже существует.</p>")
            '        Return
            '    End If

            '    ' Если записи нет, выполняем вставку
            '    Dim cmdInsert As New SqlCommand(insertQuery, conn)
            '    cmdInsert.Parameters.AddWithValue("@K_PRED", "122132")
            '    cmdInsert.Parameters.AddWithValue("@NAME", trnslt_TextNameCompany2)
            '    cmdInsert.Parameters.AddWithValue("@TerritoryCode", Convert.ToString(territoryCode))
            '    cmdInsert.Parameters.AddWithValue("@ADDRESS", trnslt_ADRESS_Company2)
            '    cmdInsert.Parameters.AddWithValue("@T_ON", trnslt_T_ON2)
            '    cmdInsert.Parameters.AddWithValue("@EMAIL", trnslt_Email_company2)
            '    cmdInsert.Parameters.AddWithValue("@FIO", trnslt_FirstName_company2)
            '    cmdInsert.Parameters.AddWithValue("@OKED_3", trnslt_Oked_3_com2)
            '    cmdInsert.Parameters.AddWithValue("@INN", trnslt_INN_user2)

            '    cmdInsert.ExecuteNonQuery()
            'End Using




            'Using conn As New SqlConnection(connectionString)
            '    Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.KatmeUvedom3 WHERE GOD = @Year AND MES = @Month"
            '    Dim insertQuery As String = "INSERT INTO dbo.KatmeUvedom3 (GOD, MES, K_PRED, NAME, K_NPUF, [ADDRESS], [FIO], [T_ON], [EMAIL], [OKED_3], [INN]) " &
            '                                "VALUES (@Year,@Month, @K_PRED, @NAME, @TerritoryCode, @ADDRESS, @FIO, @T_ON, @EMAIL, @OKED_3, @INN)"

            '    ' Проверка наличия записи
            '    Dim cmdCheck As New SqlCommand(checkQuery, conn)
            '    cmdCheck.Parameters.AddWithValue("@Year", currentYear)
            '    cmdCheck.Parameters.AddWithValue("@Month", currentMonth)

            '    conn.Open()

            '    Dim recordExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
            '    If recordExists > 0 Then
            '        ' Запись уже существует
            '        Response.Write("<p align='center'>Запись с таким годом и месяцем уже существует.</p>")
            '        Return
            '    End If

            '    ' Вставляем новую запись
            '    Dim cmdInsert As New SqlCommand(insertQuery, conn)
            '    cmdInsert.Parameters.AddWithValue("@Year", currentYear)
            '    cmdInsert.Parameters.AddWithValue("@Month", currentMonth)
            '    cmdInsert.Parameters.AddWithValue("@K_PRED", "122132")
            '    cmdInsert.Parameters.AddWithValue("@NAME", trnslt_TextNameCompany2)
            '    cmdInsert.Parameters.AddWithValue("@TerritoryCode", Convert.ToString(territoryCode))
            '    cmdInsert.Parameters.AddWithValue("@ADDRESS", trnslt_ADRESS_Company2)
            '    cmdInsert.Parameters.AddWithValue("@T_ON", trnslt_T_ON2)
            '    cmdInsert.Parameters.AddWithValue("@EMAIL", trnslt_Email_company2)
            '    cmdInsert.Parameters.AddWithValue("@FIO", trnslt_FirstName_company2)
            '    cmdInsert.Parameters.AddWithValue("@OKED_3", trnslt_Oked_3_com2)
            '    cmdInsert.Parameters.AddWithValue("@INN", trnslt_INN_user2)

            '    cmdInsert.ExecuteNonQuery()
            'End Using








            'Using conn As New SqlConnection(connectionString)
            '    conn.Open()

            '    ' Проверка наличия записи
            '    Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.KatmeUvedom3 WHERE GOD = @Year AND MES = @Month"
            '    Using cmdCheck As New SqlCommand(checkQuery, conn)
            '        cmdCheck.Parameters.AddWithValue("@Year", currentYear)
            '        cmdCheck.Parameters.AddWithValue("@Month", currentMonth)

            '        Dim recordExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
            '        If recordExists > 0 Then
            '            ' Запись уже существует
            '            Response.Write("<p align='center'>Запись с таким годом и месяцем уже существует.</p>")
            '            Return
            '        End If
            '    End Using

            '    ' Вставляем новую запись
            '    Dim insertQuery As String = "
            '    INSERT INTO dbo.KatmeUvedom3 (GOD, MES, K_PRED, NAME, K_NPUF, [ADDRESS], [FIO], [T_ON], [EMAIL], [OKED_3], [INN])
            '    VALUES (@Year, @Month, @K_PRED, @NAME, @TerritoryCode, @ADDRESS, @FIO, @T_ON, @EMAIL, @OKED_3, @INN)"
            '    Using cmdInsert As New SqlCommand(insertQuery, conn)
            '        cmdInsert.Parameters.AddWithValue("@Year", currentYear)
            '        cmdInsert.Parameters.AddWithValue("@Month", currentMonth)
            '        cmdInsert.Parameters.AddWithValue("@K_PRED", kpred)
            '        cmdInsert.Parameters.AddWithValue("@NAME", trnslt_TextNameCompany2)
            '        cmdInsert.Parameters.AddWithValue("@TerritoryCode", territoryCode)
            '        cmdInsert.Parameters.AddWithValue("@ADDRESS", trnslt_ADRESS_Company2)
            '        cmdInsert.Parameters.AddWithValue("@T_ON", trnslt_T_ON2)
            '        cmdInsert.Parameters.AddWithValue("@EMAIL", trnslt_Email_company2)
            '        cmdInsert.Parameters.AddWithValue("@FIO", trnslt_FirstName_company2)
            '        cmdInsert.Parameters.AddWithValue("@OKED_3", trnslt_Oked_3_com2)
            '        cmdInsert.Parameters.AddWithValue("@INN", trnslt_INN_user2)

            '        cmdInsert.ExecuteNonQuery()
            '    End Using
            'End Using



            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Проверка наличия записи
                Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.KatmeUvedom3 WHERE GOD = @Year AND MES = @Month and K_PRED = @K_PRED"
                Using cmdCheck As New SqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@Year", currentYear)
                    cmdCheck.Parameters.AddWithValue("@Month", currentMonth)
                    cmdCheck.Parameters.AddWithValue("@K_PRED", appUser)

                    'Dim recordExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    'If recordExists > 0 Then
                    '    ' Если запись существует, отменяем вставку
                    '    Response.Write("<p align='center'>Запись с таким годом и месяцем уже существует.</p>")
                    '    Return

                    'Dim recordExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    'If recordExists > 0 Then
                    '    ' Найти Label внутри FormView
                    '    Dim trnslt_lblMessage As Label = CType(fvUserDetails.FindControl("trnslt_lblMessage"), Label)
                    '    If trnslt_lblMessage IsNot Nothing Then
                    '        trnslt_lblMessage.Text = "Запись с таким годом, месяцем и K_PRED уже существует."
                    '        trnslt_lblMessage.Visible = True
                    '        trnslt_lblMessage.ForeColor = Drawing.Color.Red
                    '    End If

                    '    ' Отменяем вставку
                    '    e.Cancel = True


                    '
                    '    
                    Dim recordExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If recordExists > 0 Then
                        ' Найти Label внутри FormView
                        Dim trnslt_lblMessage As Label = CType(fvUserDetails.FindControl("trnslt_lblMessage"), Label)

                        trnslt_lblMessage.Visible = True ' Делаем Label видимым
                        trnslt_lblMessage.ForeColor = Drawing.Color.Red ' Устанавливаем красный цвет текста

                        e.Cancel = True

                        Return





                    End If
                End Using

                ' Вставляем новую запись
                Dim insertQuery As String = "INSERT INTO dbo.KatmeUvedom3 (GOD, MES, K_PRED, NAME, K_NPUF,oblast,raion,punkt, [ADDRESS], [FIO], [T_ON], [EMAIL], [OKED_3], [INN]) " &
                                            "VALUES (@Year, @Month, @K_PRED, @NAME, @TerritoryCode,@oblast,@raion,@punkt, @ADDRESS, @FIO, @T_ON, @EMAIL, @OKED_3, @INN)"
                Using cmdInsert As New SqlCommand(insertQuery, conn)
                    ' Добавляем параметры для запроса
                    cmdInsert.Parameters.AddWithValue("@Year", currentYear)
                    cmdInsert.Parameters.AddWithValue("@Month", currentMonth)
                    cmdInsert.Parameters.AddWithValue("@K_PRED", appUser)
                    cmdInsert.Parameters.AddWithValue("@NAME", trnslt_TextNameCompany2)
                    cmdInsert.Parameters.AddWithValue("@TerritoryCode", territoryCode)
                    cmdInsert.Parameters.AddWithValue("@oblast", territoryCode2)
                    cmdInsert.Parameters.AddWithValue("@raion", territoryCode3)
                    cmdInsert.Parameters.AddWithValue("@punkt", territoryCode4)
                    cmdInsert.Parameters.AddWithValue("@ADDRESS", trnslt_ADRESS_Company2)
                    cmdInsert.Parameters.AddWithValue("@T_ON", trnslt_T_ON2)
                    cmdInsert.Parameters.AddWithValue("@EMAIL", trnslt_Email_company2)
                    cmdInsert.Parameters.AddWithValue("@FIO", trnslt_FirstName_company2)
                    cmdInsert.Parameters.AddWithValue("@OKED_3", trnslt_Oked_3_com2)
                    cmdInsert.Parameters.AddWithValue("@INN", trnslt_INN_user2)

                    ' Выполняем команду вставки
                    cmdInsert.ExecuteNonQuery()
                End Using
            End Using













        Catch ex As Exception
            ' Логгирование ошибки или вывод сообщения
            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
        End Try

    End Sub




End Class

