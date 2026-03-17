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



Imports System.Data
Imports System.Data.SqlClient

Partial Class Account
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connCatalog As String = b.GetConnStr("connCatalog")
    Dim BRU As String = b.GetConnStr("BRU")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If (Session("Nalog") IsNot Nothing) Then
                    ' Загружаем данные пользователя
                    LoadUserData()
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

    'Private Sub LoadUserData()
    '    Try
    '        Dim appUser As String = Session("Nalog").ToString()
    '        Dim query As String = "SELECT b.NAME, b.EMAIL, b.K_PRED, b.FIO, b.FIO FROM dbo.istusers_Account2 AS b  where  b.K_PRED = @APPUser"

    '        Using conn As New SqlConnection(BRU)
    '            Using cmd As New SqlCommand(query, conn)
    '                cmd.Parameters.AddWithValue("@APPUser", appUser) ' Используем APPUser как идентификатор
    '                conn.Open()
    '                Using reader As SqlDataReader = cmd.ExecuteReader()
    '                    If reader.Read() Then
    '                        ' Заполняем текстовые поля данными пользователя
    '                        TextNameCompany.Text = reader("NAME").ToString()
    '                        TextEmail.Text = reader("EMAIL").ToString()
    '                        txtFirstName.Text = reader("FIO").ToString()
    '                        txtLastName.Text = reader("FIO").ToString()
    '                        txtUsername.Text = reader("K_PRED").ToString()
    '                    End If
    '                End Using

    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        ' Логгирование ошибки или вывод сообщения
    '        Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
    '    End Try
    'End Sub




    ' Метод для загрузки данных пользователя
    'Private Sub LoadUserData()
    '    Try
    '        Dim appUser As String = Session("Nalog").ToString()
    '        Dim query As String = "SELECT b.NameCompany, b.UserEmailForgotPass, b.APPUser, b.NameUser, b.LastNameUser FROM dbo.ISTUsers AS b INNER JOIN (SELECT * FROM ISTAPPUsers WHERE APPUser = @APPUser) AS a ON a.APPUser = b.APPUser"

    '        Using conn As New SqlConnection(connIST)
    '            Using cmd As New SqlCommand(query, conn)
    '                cmd.Parameters.AddWithValue("@APPUser", appUser) ' Используем APPUser как идентификатор
    '                conn.Open()
    '                Using reader As SqlDataReader = cmd.ExecuteReader()
    '                    If reader.Read() Then
    '                        ' Заполняем текстовые поля данными пользователя
    '                        TextNameCompany.Text = reader("NameCompany").ToString()
    '                        TextEmail.Text = reader("UserEmailForgotPass").ToString()
    '                        txtFirstName.Text = reader("NameUser").ToString()
    '                        txtLastName.Text = reader("LastNameUser").ToString()
    '                        txtUsername.Text = reader("APPUser").ToString()
    '                    End If
    '                End Using

    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        ' Логгирование ошибки или вывод сообщения
    '        Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
    '    End Try
    'End Sub

    'Private Sub LoadUserData()
    '    Try
    '        Dim appUser As String = Session("Nalog").ToString()

    '        ' Соединение с первым сервером (или базой данных)
    '        Dim query1 As String = "SELECT * FROM .dbo.ISTAPPUsers WHERE APPUser = @APPUser"
    '        Dim userData As DataTable = New DataTable()

    '        Using conn1 As New SqlConnection(connIST)
    '            Using cmd1 As New SqlCommand(query1, conn1)
    '                cmd1.Parameters.AddWithValue("@APPUser", appUser)
    '                conn1.Open()

    '                Using reader1 As SqlDataReader = cmd1.ExecuteReader()
    '                    userData.Load(reader1)
    '                End Using
    '            End Using
    '        End Using

    '        ' Соединение со вторым сервером (или базой данных)
    '        Dim query2 As String = "SELECT NAME, EMAIL, K_PRED, FIO FROM Businessregister.dbo.NKATME WHERE K_PRED = @APPUser"

    '        Using conn2 As New SqlConnection(BRU)
    '            Using cmd2 As New SqlCommand(query2, conn2)
    '                ' Предполагаем, что K_PRED получен из первого запроса
    '                Dim kPred As String = userData.Rows(0)("K_PRED").ToString()
    '                cmd2.Parameters.AddWithValue("@APPUser", kPred)
    '                conn2.Open()

    '                Using reader2 As SqlDataReader = cmd2.ExecuteReader()
    '                    If reader2.Read() Then
    '                        ' Заполняем текстовые поля данными пользователя
    '                        TextNameCompany.Text = reader2("NAME").ToString()
    '                        TextEmail.Text = reader2("EMAIL").ToString()
    '                        txtFirstName.Text = reader2("FIO").ToString()
    '                        txtLastName.Text = reader2("FIO").ToString()
    '                        ' Убедитесь, что вы используете правильные поля для заполения
    '                        ' Возможно, вам нужно изменить название полей в соответствии с вашими данными
    '                    End If
    '                End Using
    '            End Using
    '        End Using

    '    Catch ex As Exception
    '        ' Логгирование ошибки или вывод сообщения
    '        Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
    '    End Try
    'End Sub


    Private Sub LoadUserData()
        Try
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

            ' Соединение со вторым сервером (или базой данных)
            Dim query2 As String = "SELECT K_PRED,NAME,K_NPUF,oblast,[raion],[punkt],[ADDRESS],[FIO],[T_ON],[EMAIL],[OKED_3],[OKED_3_name],[INN],[S_SPR1]   FROM Businessregister.dbo.istusers_Account2 WHERE K_PRED = @APPUser"

            Using conn2 As New SqlConnection(BRU)
                Using cmd2 As New SqlCommand(query2, conn2)
                    Dim kPred As String = userData.Rows(0)("APPUser").ToString()
                    cmd2.Parameters.AddWithValue("@APPUser", kPred)
                    conn2.Open()

                    Using reader2 As SqlDataReader = cmd2.ExecuteReader()
                        If reader2.Read() Then
                            ' Заполняем текстовые поля данными пользователя
                            trnslt_dbregistr3.Text = reader2("K_PRED").ToString()
                            trnslt_INN_user.Text = reader2("INN").ToString()
                            trnslt_TextNameCompany.Text = reader2("NAME").ToString()
                            trnslt_K_NPU_ter.Text = reader2("K_NPUF").ToString()
                            trnslt_Name_oblast.Text = reader2("oblast").ToString()
                            trnslt_Name_raion.Text = reader2("raion").ToString()
                            trnslt_Name_punkt.Text = reader2("punkt").ToString()


                            If Not IsDBNull(reader2("ADDRESS")) Then
                                trnslt_ADRESS_Company.Text = reader2("ADDRESS").ToString()
                            Else
                                trnslt_ADRESS_Company.Text = String.Empty
                            End If
                            'trnslt_ADRESS_Company.Text = reader2("ADRESS").ToString()
                            trnslt_T_ON.Text = reader2("T_ON").ToString()
                            trnslt_Email_company.Text = reader2("EMAIL").ToString()
                            trnslt_FirstName_company.Text = reader2("FIO").ToString()
                            txtLastName.Text = reader2("FIO").ToString()
                            trnslt_Oked_3_com.Text = reader2("OKED_3").ToString()
                            trnslt_Oked_3_kod.Text = reader2("OKED_3_name").ToString()

                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Логгирование ошибки или вывод сообщения
            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
        End Try
    End Sub





    Protected Sub UpdateUserData(ByVal firstName As String, ByVal lastName As String, ByVal username As String)
        Try
            Dim appUser As String = Session("Nalog").ToString()

            ' SQL-запрос для обновления данных пользователя
            Dim query As String = "UPDATE b NameUser = @FirstName, LastNameUser = @LastName FROM dbo.ISTUsers AS b INNER JOIN (SELECT * FROM ISTAPPUsers WHERE APPUser = @APPUser) AS a ON a.APPUser = b.APPUser"
            Response.Write("Update command triggered.")
            ' Создание соединения с базой данных
            Using conn As New SqlConnection(connIST)
                ' Создание команды SQL
                Using cmd As New SqlCommand(query, conn)
                    ' Добавление параметров к команде
                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@APPUser", username)
                    ' Открытие соединения и выполнение команды
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Логгирование ошибки или вывод сообщения
            Response.Write("<p align='center'>" & ex.Message & "-" & ex.StackTrace & "</p>")
        End Try
    End Sub



End Class


