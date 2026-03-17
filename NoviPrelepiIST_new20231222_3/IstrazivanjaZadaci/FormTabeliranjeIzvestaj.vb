Option Strict Off

Friend Class FormTabeliranjeIzvestaj
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.FormTabeliranjeIzvestaj_Resize(Nothing, Nothing)
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ButtonExportUExcel As System.Windows.Forms.Button
    Private WithEvents MyDataGrid1 As MyDataGridControl.MyDataGrid
    Friend WithEvents ButtonIzlaz As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MyDataGrid1 = New MyDataGridControl.MyDataGrid
        Me.ButtonExportUExcel = New System.Windows.Forms.Button
        Me.ButtonIzlaz = New System.Windows.Forms.Button
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.AlternatingBackColor = System.Drawing.Color.PowderBlue
        Me.MyDataGrid1.BackColor = System.Drawing.Color.GhostWhite
        Me.MyDataGrid1.BackgroundColor = System.Drawing.Color.Lavender
        Me.MyDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MyDataGrid1.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.MyDataGrid1.CaptionFont = New System.Drawing.Font("Tahoma", 10.2!)
        Me.MyDataGrid1.CaptionForeColor = System.Drawing.Color.White
        Me.MyDataGrid1.DataMember = ""
        Me.MyDataGrid1.FlatMode = True
        Me.MyDataGrid1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.MyDataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGrid1.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.MyDataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGrid1.HeaderFont = New System.Drawing.Font("Verdana", 9.0!)
        Me.MyDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.MyDataGrid1.LinkColor = System.Drawing.Color.Teal
        Me.MyDataGrid1.Location = New System.Drawing.Point(14, 58)
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.MyDataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGrid1.SelectionBackColor = System.Drawing.Color.Teal
        Me.MyDataGrid1.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.MyDataGrid1.Size = New System.Drawing.Size(525, 281)
        Me.MyDataGrid1.TabIndex = 0
        '
        'ButtonExportUExcel
        '
        Me.ButtonExportUExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonExportUExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonExportUExcel.Location = New System.Drawing.Point(14, 13)
        Me.ButtonExportUExcel.Name = "ButtonExportUExcel"
        Me.ButtonExportUExcel.Size = New System.Drawing.Size(140, 26)
        Me.ButtonExportUExcel.TabIndex = 1
        Me.ButtonExportUExcel.Text = "Export u Excel"
        '
        'ButtonIzlaz
        '
        Me.ButtonIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzlaz.Location = New System.Drawing.Point(196, 13)
        Me.ButtonIzlaz.Name = "ButtonIzlaz"
        Me.ButtonIzlaz.Size = New System.Drawing.Size(133, 26)
        Me.ButtonIzlaz.TabIndex = 2
        Me.ButtonIzlaz.Text = "Izlaz"
        '
        'FormTabeliranjeIzvestaj
        '
        Me.AcceptButton = Me.ButtonExportUExcel
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.CancelButton = Me.ButtonIzlaz
        Me.ClientSize = New System.Drawing.Size(679, 396)
        Me.Controls.Add(Me.ButtonIzlaz)
        Me.Controls.Add(Me.ButtonExportUExcel)
        Me.Controls.Add(Me.MyDataGrid1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Name = "FormTabeliranjeIzvestaj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Izveštaj"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public tab As String

    Public Sub New( _
    ByVal tab As String)
        Me.New()
        Me.tab = tab
    End Sub

    Public Shadows Function ShowDialog( _
    ByVal t As System.Data.DataTable) As System.Windows.Forms.DialogResult
        Me.MyDataGrid1.DataSource = t
        Return MyBase.ShowDialog
    End Function

    Private Sub FormTabeliranjeIzvestaj_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        With Me.MyDataGrid1
            .Left = 0
            .Width = Me.ClientSize.Width
            If Me.ClientSize.Height > .Top Then
                .Height = Me.ClientSize.Height - .Top
            End If
        End With
    End Sub

    Private Sub ButtonExportUExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExportUExcel.Click
        Dim t As System.Data.DataTable
        t = CType(Me.MyDataGrid1.DataSource, System.Data.DataTable)
        If t Is Nothing Then
            Return
        End If
        Dim bPrikazi As Boolean = False
        Dim fileName As String = ""
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
        Dim exApp As Object = Microsoft.VisualBasic.CreateObject("Excel.Application")
        Dim wb As Object = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            wb = exApp.Workbooks.Add
            Dim ws As Object
            ws = wb.Worksheets.Item(1)
            Dim row As Integer = 1
            For Each col As System.Data.DataColumn In t.Columns
                ws.Cells.Item(row, col.Ordinal + 1).Formula = col.Caption
            Next
            For Each r As System.Data.DataRow In t.Rows
                row += 1
                For Each col As System.Data.DataColumn In t.Columns
                    If r.IsNull(col.Ordinal) Then
                        ws.Cells.Item(row, col.Ordinal + 1).Formula = ""
                    Else : ws.Cells.Item(row, col.Ordinal + 1).Formula = r.Item(col.Ordinal)
                    End If
                Next
            Next
            Dim dlg As New System.Windows.Forms.SaveFileDialog
            dlg.Filter = "Excel files (*.xls)|*.xls"
            dlg.FileName = dlg.InitialDirectory + "\Report1"
            Dim dr As System.Windows.Forms.DialogResult
            dr = dlg.ShowDialog
            fileName = dlg.FileName
            dlg.Dispose()
            If dr = System.Windows.Forms.DialogResult.OK _
            AndAlso fileName <> "" Then
                wb.SaveAs(dlg.FileName)
                bPrikazi = True
            End If
        Finally
            If Not wb Is Nothing Then
                Try
                    wb.Close(False)
                Catch
                End Try
            End If
            exApp.Quit()
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        If bPrikazi Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            proc(fileName, True, "", "")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub
    Public Sub proc(ByVal fn As String, ByVal b As Boolean, ByVal wd As String, ByVal a As String)
        Dim p As New System.Diagnostics.ProcessStartInfo
        p.FileName = fn
        p.UseShellExecute = b
        If p.UseShellExecute Then
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Else
            p.WorkingDirectory = wd
            p.Arguments = a
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
        Try
            System.Diagnostics.Process.Start(p)
        Catch e As System.Exception
            System.Windows.Forms.MessageBox.Show(e.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub
End Class