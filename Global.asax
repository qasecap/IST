<%@ Application Language="VB" %>

<script RunAt="server">
    Private ReadOnly b As New Base_IST_PPP()
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application startup
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Get the exception object.
        Dim ex As Exception = Server.GetLastError()

        If ex IsNot Nothing Then
            Dim httpException As HttpException = TryCast(ex, HttpException)
            Dim errorUrl As String, errorMessage As String, errorFile As String, errorLine As String, nalog As String
            'If Session("NALOG") IsNot Nothing Then
            '    nalog = Session("NALOG").ToString
            'End If
            ' Get the inner exception if the outer exception is an HttpException
            If httpException IsNot Nothing Then
                ex = httpException.GetBaseException()
            End If

            errorUrl = HttpContext.Current.Request.Url.ToString()
            errorMessage = ex.Message

            ' Get stack trace for the exception with source file information
            Dim st As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace(ex, True)
            ' Get the first stack frame that contains source file information
            Dim frame As System.Diagnostics.StackFrame = st.GetFrames().FirstOrDefault(Function(f) f.GetFileName() IsNot Nothing)

            If frame IsNot Nothing Then
                errorFile = frame.GetFileName()
                errorLine = frame.GetFileLineNumber().ToString()
            End If

            ' Log the exception and notify system operators
            Dim query As String = "INSERT INTO ISTMonitoringLog (ActivityID, DateInsertLog, AppUser, ActivityDescription, APPCode, ActivityStatus, UserPC) "
            query += " VALUES ('4', '" + DateTime.Now + "', '" + nalog + "', '" + errorUrl + "; " + errorFile + "', '" + errorLine + "', 'ERROR', '" + errorMessage + "') "

            Dim connLog As String = b.GetConnStr("connLog")
            'Dim result As Boolean = b.UpisPromenaBrisanje(query, connLog)

            ' Clear the error from the server
            server.ClearError()

            ' Redirect to an error page
            'Response.Redirect("~/ErrorPage.aspx")
        End If

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.

        '"prazna sesija?"
    End Sub

</script>
