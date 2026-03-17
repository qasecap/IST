Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Strings
'Imports System.Security.Cryptography
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Imports System.Linq
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Runtime.InteropServices
Imports System.Collections
Imports System.Reflection.Emit
Imports System.Diagnostics.Eventing
Imports System.Runtime
Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Configuration

Public Class FormTemplate
    Inherits Form
    Public dtMessages As DataTable
    Public dtLang As DataTable
    Public ActivateButtonColor As Color
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.DoubleBuffer Or ControlStyles.UserPaint, True)
        Dim fi As New System.IO.FileInfo(Me.GetType.Assembly.Location)
        Call readXMLtexts()

    End Sub

    Function kojianketar(ByVal koselogovao As String, ByVal DBconnectionstring As String) As String
        Dim str As String = "select top 1 anketarnalog from vezaRZSAnketarnalog where RZSUser=N'" + koselogovao + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(str, DBconnectionstring, Nothing)
        Dim pom As String = ""
        If dt.Rows.Count > 0 Then
            pom = dt.Rows(0).Item(0).ToString
        End If
        Return pom
    End Function
    Sub readXMLtexts()
        ''učitaj poruke
        ''msg xml to dt
        Dim myXMLfile As String
        'ko ide preko ISTProveriPaKreni
        myXMLfile = LokalniISTfolder + "\msgCodes.XML"
        Dim ds As New DataSet()
        Try
            ds.ReadXml(myXMLfile)
            dtMessages = ds.Tables(0)
        Catch ex As System.Exception
            'ko ide direktno preko bgd-a
            myXMLfile = ".\msgCodes.XML"
            Try
                ds.ReadXml(myXMLfile)
                dtMessages = ds.Tables(0)
            Catch ex1 As System.Exception
                ISTMessageBox.Show(ex1.ToString())
            End Try
        End Try

        Dim myTXTfile As String
        'ko ide preko ISTProveriPaKreni
        myTXTfile = LokalniISTfolder + "\txtCodes.XML"
        Dim dsT As New DataSet()
        Try
            dsT.ReadXml(myTXTfile)
            dtLang = dsT.Tables(0)
        Catch ex As System.Exception
            'ko ide direktno preko bgd-a
            myXMLfile = ".\txtCodes.XML"
            Try
                dsT.ReadXml(myXMLfile)
                dtLang = dsT.Tables(0)
            Catch ex2 As System.Exception
                ISTMessageBox.Show(ex2.ToString())
            End Try
        End Try

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTemplate))
        Me.SuspendLayout()
        '
        'FormTemplate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(336, 217)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTemplate"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "CustomGrid"
    Dim dateCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {.Alignment = DataGridViewContentAlignment.MiddleRight}
    Dim amountCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {.Alignment = DataGridViewContentAlignment.MiddleRight, .Format = "N2"}
    Dim gridCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
       .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
       .BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer)),
       .Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
       .ForeColor = System.Drawing.SystemColors.ControlLightLight,
       .SelectionBackColor = System.Drawing.SystemColors.Highlight,
       .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
       .WrapMode = System.Windows.Forms.DataGridViewTriState.[True]}
    Dim gridCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
        .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
        .BackColor = System.Drawing.SystemColors.ControlLightLight,
        .Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
        .ForeColor = System.Drawing.SystemColors.ControlText,
        .SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)),
        .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
        .WrapMode = System.Windows.Forms.DataGridViewTriState.[False]}
    Dim gridCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
        .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
        .BackColor = System.Drawing.Color.Lavender,
        .Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
        .ForeColor = System.Drawing.SystemColors.WindowText,
        .SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)),
        .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
        .WrapMode = System.Windows.Forms.DataGridViewTriState.[True]}
    Sub AapplyGridTheme(ByRef grid As DataGridView)
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.BackgroundColor = System.Drawing.SystemColors.Window
        grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        grid.ColumnHeadersDefaultCellStyle = gridCellStyle
        grid.ColumnHeadersHeight = 32
        grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grid.DefaultCellStyle = gridCellStyle2
        grid.EnableHeadersVisualStyles = False
        grid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        grid.ReadOnly = True
        grid.RowHeadersVisible = True
        grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        grid.RowHeadersDefaultCellStyle = gridCellStyle3
        grid.Font = gridCellStyle.Font
    End Sub
    Sub AsetGridRowHeader(ByRef dgv As DataGridView, Optional ByVal hSize As Boolean = False)
        dgv.TopLeftHeaderCell.Value = "NO "
        dgv.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders)
        For Each cCol As DataGridViewColumn In dgv.Columns
            If cCol.ValueType.ToString() = GetType(DateTime).ToString Then
                cCol.DefaultCellStyle = dateCellStyle
            ElseIf cCol.ValueType.ToString() = GetType(Decimal).ToString Or cCol.ValueType.ToString() = GetType(Double).ToString Then
                cCol.DefaultCellStyle = amountCellStyle
            End If
        Next
        If hSize Then
            dgv.RowHeadersWidth = dgv.RowHeadersWidth + 16
        End If
        dgv.AutoResizeColumns()
    End Sub
    Sub ArowPostPaint_HeaderCount(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        'set rowheader count
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim centerFormat As Object = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center
        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height - sender.rows(e.RowIndex).DividerHeight)
        e.Graphics.DrawString(rowIdx, grid.Font, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
#End Region

#Region "Theme"
    Public Sub SaveTheme(ByVal ISTTheme As String)
        Dim gde As String = System.Environment.GetEnvironmentVariable("TEMP") & "\ISTTheme.txt"
        SaveTextToFile(ISTTheme.Trim.ToUpper, gde)
    End Sub

    Public Function GetTheme() As String
        GetTheme = "Dark"
        Dim gde As String = System.Environment.GetEnvironmentVariable("TEMP") & "\ISTTheme.txt"
        If File.Exists(gde) Then
            Dim str As String = GetFileContents(gde)
            GetTheme = str.Trim.ToUpper
        End If
    End Function

    Function setTheme(ByVal nizobjekata() As Control, nizobjekataOrange() As System.Windows.Forms.Button, Optional theme As String = "") As Color
        Dim zapamtibojuteme As Color = Nothing
        If theme = "" Then
            theme = GetTheme()
        End If
        Call ISTTheme.ChosenTheme(theme)
        If Not nizobjekata Is Nothing Then
            For Each p As Control In nizobjekata
                If TypeOf (p) Is Panel OrElse TypeOf (p) Is System.Windows.Forms.Button Then
                    p.BackColor = ISTTheme.PanelParent
                ElseIf TypeOf (p) Is System.Windows.Forms.Label Then
                    p.ForeColor = ISTTheme.PanelParent
                End If
            Next
        End If
        If Not nizobjekataOrange Is Nothing Then
            For Each k As System.Windows.Forms.Button In nizobjekataOrange
                k.BackColor = ISTTheme.nizButtons
                k.FlatAppearance.MouseDownBackColor = ISTTheme.PanelParent
                k.FlatAppearance.MouseOverBackColor = ISTTheme.PanelParent
            Next
        End If

        ActivateButtonColor = ISTTheme.ActivateButtons
        zapamtibojuteme = ISTTheme.PanelParent
        setTheme = zapamtibojuteme
    End Function



#End Region

    Public nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
    Public nvd As String = Microsoft.VisualBasic.ChrW(34)
    Public HP As New HelpProvider
    Private LokalniISTfolder As String = Environment.GetEnvironmentVariable("TEMP") + "\IST"

    Public Overloads Sub Dispose()
        MyBase.Dispose()
    End Sub
#Region "GUI_BackUp_Restore"
    Sub BackUp(ByVal dsIST As DatasetIstrazivanja, ByVal app As String, ByVal izabranaTabela As String, tabeleIzIsta() As String, ByVal DBTxt As String, ByVal WHAT As String)
        Dim isttabele As String = ""
        If Not tabeleIzIsta Is Nothing Then
            For i As Integer = 0 To tabeleIzIsta.GetUpperBound(0)
                isttabele = isttabele + tabeleIzIsta(i).Trim.ToUpper + ";"
            Next
        End If


        Dim dFold As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\Istrazivanja"
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim dd As String = String.Format("{0:yyyyMMdd_HHmmss}", System.DateTime.Now)
        Dim folder As String = dFold
        If WHAT = "UNOS" Then
            folder = folder + "\GUIBACKUP\POLJA"
        End If
        If WHAT = "TABELE" Then
            folder = folder + "\GUIBACKUP\TABELE"
        End If

        Dim backUpMetaFileUndo As String = folder + "\BackUpUndo.txt"
        Dim backUpMetaFileRedo As String = folder + "\BackUpRedo.txt"
        Dim backUpMetaFileLast As String = folder + "\BackUpLast.txt"
        Dim backUpMetaFileFirst As String = folder + "\BackUpFirst.txt"

        If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
        If Not File.Exists(backUpMetaFileFirst) Then File.Create(backUpMetaFileFirst).Dispose()
        If Not File.Exists(backUpMetaFileUndo) Then File.Create(backUpMetaFileUndo).Dispose()

        If Not File.Exists(backUpMetaFileRedo) Then
            File.Create(backUpMetaFileRedo).Dispose()
        Else
            File.WriteAllText(backUpMetaFileRedo, "")
        End If
        If Not File.Exists(backUpMetaFileLast) Then
            File.Create(backUpMetaFileLast).Dispose()
        Else
            File.WriteAllText(backUpMetaFileLast, "")
        End If

        Dim sqlInsert As String = ""
        Dim sqlValues As String = ""
        Dim sqlI As String = ""
        Dim tTXT As String = ""
        Dim sbTXT As System.Text.StringBuilder = New System.Text.StringBuilder

        If dsIST.Tables.Count() > 0 Then
            folder = folder + "\" + dd
            Directory.CreateDirectory(folder)
            For t As Integer = 0 To dsIST.Tables().Count - 1
                If dsIST.Tables(t).Rows.Count > 0 Then
                    Dim imetabele As String = dsIST.Tables(t).TableName.ToString.Trim
                    If isttabele.IndexOf(imetabele.Trim.ToUpper + ";") >= 0 Then
                        For r As Integer = 0 To dsIST.Tables(t).Rows.Count - 1
                            sqlI = ""
                            sqlInsert = ""
                            sqlValues = ""
                            Dim vred As String = ""
                            For k As Integer = 0 To dsIST.Tables(t).Columns.Count - 1
                                sqlInsert = sqlInsert + "[" + dsIST.Tables(t).Columns(k).ColumnName + "],"
                                Dim tip As String = dsIST.Tables(t).Columns(k).DataType.Name
                                If tip = "DateTime" Then
                                    vred = "'" + CDate(dsIST.Tables(t).Rows(r)(k)).ToString("yyyy-MM-dd") + "'"
                                Else
                                    vred = "N'" + dsIST.Tables(t).Rows(r)(k).ToString.Trim.Replace("'", "''") + "'"
                                End If
                                sqlValues = sqlValues + vred + ","
                            Next
                            sqlInsert = sqlInsert.TrimEnd(",")
                            sqlValues = sqlValues.TrimEnd(",")
                            sqlI = "insert into dbo." + imetabele + " (" + sqlInsert + ") values (" + sqlValues + "); "
                            sbTXT.Append(sqlI)
                            If r < dsIST.Tables(t).Rows.Count - 1 Then sbTXT.Append(nvrd)
                        Next
                        Try
                            Select Case imetabele.Trim.ToUpper
                                Case "ISTPOLJA", "ISTTABELE", "ISTAWLS", "ISTLABELS", "ISTLK", "ISTQUESTIONEXPLANATION"
                                    imetabele = imetabele + "_" + izabranaTabela
                                Case Else
                                    imetabele = imetabele + "_" + "X"
                            End Select

                            tTXT = folder + "\" + app.Trim + "_" + imetabele + ".sql"
                            Dim outfile As New System.IO.StreamWriter(tTXT, False, System.Text.Encoding.UTF8)
                            outfile.Write(sbTXT.ToString())
                            outfile.Flush()
                            outfile.Close()
                            sbTXT.Clear()
                        Catch ex As System.Exception
                            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                        End Try
                    End If

                End If
            Next

            'doda za DB

            If DBTxt <> "" Then
                Dim strFile As String = folder + "\" + "DBDB" + ".sql"
                File.AppendAllText(strFile, DBTxt)
            End If

            'provera da li je folder prazan, tj da nije ispisao nista
            Dim folderEmpty As Boolean = True
            Dim myDir As DirectoryInfo = New DirectoryInfo(folder)
            If myDir.EnumerateFiles().Any() Then folderEmpty = False
            If folderEmpty = True Then
                Directory.Delete(folder, True)
            Else
                If File.ReadAllLines(backUpMetaFileFirst).Length = 0 Then
                    Call addLastLane(backUpMetaFileFirst, dd)
                Else
                    Call addLastLane(backUpMetaFileUndo, dd)
                End If
            End If
        End If
    End Sub

    Sub BackUpRedo(ByVal dd As String, ByVal imeFolderaIzKogaVracamo As String, ByVal dsIST As DatasetIstrazivanja, ByVal app As String, ByVal izabranaTabela As String, ByVal connectionstring As String, ByVal what As String)
        Dim isttabele As String = "ISTPOLJA;ISTLK;ISTAWLs;ISTQuestionExplanation;ISTLabels"

        Dim dFold As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\Istrazivanja"
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)

        Dim folder As String = dFold
        Dim folderIzKogaVracamo As String = dFold
        If what = "" Then what = "UNOS"
        If what = "UNOS" Then
            folder = folder + "\GUIBACKUP\POLJA"
            folderIzKogaVracamo = folderIzKogaVracamo + "\GUIBACKUP\POLJA\" + imeFolderaIzKogaVracamo
        End If


        Dim sqlInsert As String = ""
        Dim sqlValues As String = ""
        Dim sqlI As String = ""
        Dim tTXT As String = ""

        Dim sbTXT As System.Text.StringBuilder = New System.Text.StringBuilder

        If dsIST.Tables.Count() > 0 Then
            folder = folder + "\" + dd
            Directory.CreateDirectory(folder)
            For t As Integer = 0 To dsIST.Tables().Count - 1
                If dsIST.Tables(t).Rows.Count > 0 Then
                    Dim imetabele As String = dsIST.Tables(t).TableName.ToString.Trim
                    If isttabele.IndexOf(imetabele.Trim.ToUpper + ";") >= 0 Then
                        For r As Integer = 0 To dsIST.Tables(t).Rows.Count - 1
                            sqlI = ""
                            sqlInsert = ""
                            sqlValues = ""
                            Dim vred As String = ""
                            For k As Integer = 0 To dsIST.Tables(t).Columns.Count - 1
                                sqlInsert = sqlInsert + "[" + dsIST.Tables(t).Columns(k).ColumnName + "],"
                                Dim tip As String = dsIST.Tables(t).Columns(k).DataType.Name
                                If tip = "DateTime" Then
                                    vred = "'" + CDate(dsIST.Tables(t).Rows(r)(k)).ToString("yyyy-MM-dd") + "'"
                                Else
                                    vred = "N'" + dsIST.Tables(t).Rows(r)(k).ToString.Trim.Replace("'", "''") + "'"
                                End If
                                sqlValues = sqlValues + vred + ","
                            Next
                            sqlInsert = sqlInsert.TrimEnd(",")
                            sqlValues = sqlValues.TrimEnd(",")
                            sqlI = "insert into dbo." + imetabele + " (" + sqlInsert + ") values (" + sqlValues + "); "
                            sbTXT.Append(sqlI)
                            If r < dsIST.Tables(t).Rows.Count - 1 Then sbTXT.Append(nvrd)
                        Next
                        Try
                            Select Case imetabele.Trim.ToUpper
                                Case "ISTPOLJA", "ISTTABELE", "ISTAWLS", "ISTLABELS", "ISTLK", "ISTQUESTIONEXPLANATION"
                                    imetabele = imetabele + "_" + izabranaTabela
                                Case Else
                                    imetabele = imetabele + "_" + "X"
                            End Select

                            tTXT = folder + "\" + app.Trim + "_" + imetabele + ".sql"
                            Dim outfile As New System.IO.StreamWriter(tTXT, False, System.Text.Encoding.UTF8)
                            outfile.Write(sbTXT.ToString())
                            outfile.Flush()
                            outfile.Close()
                            sbTXT.Clear()
                        Catch ex As System.Exception
                            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                        End Try
                    End If
                End If

            Next

            'doda za DB
            Dim poslednjiDBTxt As String = folderIzKogaVracamo + "\DBDB.sql"
            If File.Exists(poslednjiDBTxt) Then
                'pravimo suportan opt
                Dim DBTxt As String = folder + "\DBDB.sql"
                Dim line As String = Nothing
                Dim lines() As String = System.IO.File.ReadAllLines(poslednjiDBTxt)
                Dim lineCount As Integer = lines.Length
                Dim tabela As String = ""
                Dim polje As String = ""
                If lineCount > 0 Then
                    For i As Integer = 0 To lines.Length - 1
                        Dim sqlDB As String = ""
                        Dim pp() As String = lines(i).Split(" ")
                        For l As Integer = 0 To pp.GetUpperBound(0)
                            If pp(l).Trim.ToUpper = "ADD" Then
                                tabela = pp(l - 1)
                                polje = pp(l + 1)
                                sqlDB = "ALTER TABLE " + tabela + " DROP COLUMN " + polje + ";" + nvrd

                            End If
                            If pp(l).Trim.ToUpper = "DROP" Then
                                tabela = pp(l - 1)
                                polje = pp(l + 2)
                                Dim dtsql As String = "SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS  WHERE TABLE_NAME = '" + tabela + "' and COLUMN_NAME = '" + polje + "'"
                                Dim dt As DataTable = izvrsiSQLvratiDT(dtsql, connectionstring, Nothing)
                                Dim DataType As String = dt.Rows(0).Item("DATA_TYPE")
                                sqlDB = "ALTER TABLE " + tabela + " ADD  " + polje + " " + DataType + " NULL;" + nvrd
                            End If
                        Next
                        lines(i) = sqlDB
                    Next
                    File.WriteAllLines(DBTxt, lines)
                End If
            End If
        End If

    End Sub
    Function izKogFolderaFromBackUpReStack(ByVal undoRedo As Integer, Optional ByVal dsIST As DatasetIstrazivanja = Nothing, Optional ByVal app As String = "", Optional ByVal izabranaTabela As String = "", Optional ByVal connectionstring As String = "", Optional ByVal WHAT As String = "") As String
        'undo =-1
        'redo=1
        Dim imeFolderaIzKogaVracamo As String = ""
        Dim dFold As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\Istrazivanja"
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim folder As String = dFold
        If WHAT = "" Then
            folder = folder + "\GUIBACKUP\POLJA"
        End If

        Dim backUpMetaFileUndo As String = folder + "\BackUpUndo.txt"
        Dim backUpMetaFileRedo As String = folder + "\BackUpRedo.txt"
        Dim backUpMetaFileLast As String = folder + "\BackUpLast.txt"
        Dim backUpMetaFileFirst As String = folder + "\BackUpFirst.txt"
        Dim backUpMetaFile As String = ""
        If undoRedo = -1 Then
            backUpMetaFile = backUpMetaFileUndo
            If File.ReadAllLines(backUpMetaFileUndo).Length = 0 AndAlso File.ReadAllLines(backUpMetaFileFirst).Length > 0 Then
                backUpMetaFile = backUpMetaFileFirst
            End If
        Else
            backUpMetaFile = backUpMetaFileRedo
            If File.ReadAllLines(backUpMetaFileRedo).Length = 0 AndAlso File.ReadAllLines(backUpMetaFileLast).Length > 0 Then
                backUpMetaFile = backUpMetaFileLast
            End If
        End If

        Dim lines() As String = System.IO.File.ReadAllLines(backUpMetaFile)
        Dim lineCount As Integer = lines.Length

        Dim undoVisible As String = "1"
        Dim redoVisible As String = "1"

        If lineCount > 0 Then
            imeFolderaIzKogaVracamo = lines(lineCount - 1)

            If undoRedo = -1 Then 'undo
                If File.ReadAllLines(backUpMetaFileRedo).Length = 0 AndAlso File.ReadAllLines(backUpMetaFileLast).Length = 0 Then
                    Dim dd As String = String.Format("{0:yyyyMMdd_HHmmss}", System.DateTime.Now)
                    Call BackUpRedo(dd, imeFolderaIzKogaVracamo, dsIST, app, izabranaTabela, connectionstring, WHAT)
                    Call addLastLane(backUpMetaFileLast, dd)
                End If
                If File.ReadAllLines(backUpMetaFileUndo).Length = 0 AndAlso File.ReadAllLines(backUpMetaFileFirst).Length = 1 Then
                    undoVisible = "0"
                End If
                If File.ReadAllLines(backUpMetaFileUndo).Length > 0 Then
                    Call addLastLane(backUpMetaFileRedo, lines(lineCount - 1))
                    Call DeleteLastLine(backUpMetaFileUndo)
                End If

            End If

            If undoRedo = 1 Then 'redo
                If File.ReadAllLines(backUpMetaFileRedo).Length = 0 AndAlso File.ReadAllLines(backUpMetaFileLast).Length = 1 Then
                    redoVisible = "0"
                End If
                If File.ReadAllLines(backUpMetaFileRedo).Length > 0 Then
                    Call addLastLane(backUpMetaFileUndo, lines(lineCount - 1))
                    Call DeleteLastLine(backUpMetaFileRedo)
                End If

            End If

        End If

        Return imeFolderaIzKogaVracamo + ";" + undoVisible + ";" + redoVisible

    End Function
    'by using the Using statement, it takes care of the disposal of the object, allowing the object to cleanly terminate its resources
    Sub addLastLane(ByVal filepath As String, ByVal line As String)
        Using sw As StreamWriter = File.AppendText(filepath)
            sw.WriteLine(line)
        End Using
    End Sub
    Sub DeleteLastLine(ByVal filepath As String)
        Dim lines As List(Of String) = File.ReadAllLines(filepath).ToList()
        File.WriteAllLines(filepath, lines.GetRange(0, lines.Count - 1).ToArray())
    End Sub


    Sub subRestore(ByVal vtvt As String, ByVal imeFolderaIzKogaVracamo As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String)
        Dim dFold As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\Istrazivanja"
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim folder As String = dFold

        If what = "UNOS" Then
            folder = folder + "\GUIBACKUP\POLJA\"
        End If
        If what = "TABELE" Then
            folder = folder + "\GUIBACKUP\TABELE\"
        End If


        If imeFolderaIzKogaVracamo <> "" Then
            folder = folder + imeFolderaIzKogaVracamo
        Else
            folder = folder + "NEMAODAKLEDAVRATI"
        End If

        Dim ffiles() As String = {}
        Dim ffile As String = ""

        If Directory.Exists(folder) Then
            ffiles = Directory.GetFiles(folder)
            For i As Integer = 0 To ffiles.GetUpperBound(0)
                Dim nname As String = GetFileName(ffiles(i)).Replace(".sql", "")

                If nname = "DBDB" Then
                    Dim DBtxt As String = GetFileContents(ffiles(i))
                    DBtxt = " begin transaction; " + nvrd + DBtxt + nvrd + " commit; "
                    Dim ok1 As String = izvrsiSQL(DBtxt, DBConnectionString)
                    If ok1 <> "ok" Then
                        ISTMessageBox.Show(DBtxt + nvrd + nvrd + "is not executed! ER144", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    'nname = nname.TrimStart("_")
                    Dim pn() As String = nname.Split("_")
                    Dim sifist As String = pn(0)
                    Dim ISTTabela As String = pn(1)
                    Dim tabela As String = pn(2)

                    Dim strTXT As String = GetFileContents(ffiles(i))
                    If strTXT <> "" Then
                        Dim wwherevod As String = " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126)  and '" + vtvt + "' <= vdo "
                        Dim sqlD As String = "delete from " + ISTTabela + " where 2=2" + wwherevod
                        If tabela <> "X" Then sqlD = sqlD + " and tabela='" + tabela + "'"
                        sqlD = sqlD + ";" + nvrd
                        strTXT = sqlD + strTXT
                        'AANEV_IST_X
                        strTXT = " begin transaction; " + nvrd + strTXT + nvrd + " commit; "
                        Dim ok1 As String = izvrsiSQL(strTXT, ISTConnectionString)
                        If ok1 <> "ok" Then
                            ISTMessageBox.Show(strTXT + nvrd + nvrd + "is not executed! ER145", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If

            Next
        Else
            MsgBox("nema")
        End If

    End Sub

    Function param(ByVal tabele As String) As String()

        If tabele = "" Then
            param = Nothing
            Exit Function
        End If

        Dim tabeleIzIstaZaBackUP() As String = {}
        Dim tIST As Integer = -1

        Dim pp() As String = tabele.Split(";")
        For i As Integer = 0 To pp.GetUpperBound(0)
            tIST = tIST + 1
            ReDim Preserve tabeleIzIstaZaBackUP(tIST)
            tabeleIzIstaZaBackUP(tIST) = pp(i)
        Next

        param = tabeleIzIstaZaBackUP

    End Function
    Function dbBackUpFile(ByVal slqDBDropTip As String, ByVal action As String, ByVal connectionstring As String) As String

        If slqDBDropTip.IndexOf("#") < 0 Then slqDBDropTip = slqDBDropTip + "#"
        Dim bb() As String = slqDBDropTip.Split("#")
        Dim sqlDB As String = ""
        For i As Integer = 0 To bb.GetUpperBound(0)
            If bb(i).Trim <> "" Then
                Dim pp() As String = bb(i).Split(";")
                If action = "DROP" Then
                    sqlDB = sqlDB + "ALTER TABLE " + pp(0).Trim + " DROP COLUMN " + pp(1).Trim + ";" + nvrd
                ElseIf action = "ADDPK" Then
                    Dim str As String = "select OBJECT_NAME(OBJECT_ID) AS NameofConstraint" +
                    " From sys.objects" +
                    " Where OBJECT_NAME(parent_object_id) =N'" + pp(0).Trim + "'" +
                    " And type_desc Like 'PRIMARY_KEY_CONSTRAINT'"

                    Dim dt As New DataTable
                    dt = izvrsiSQLvratiDT(str, connectionstring, Nothing)
                    Dim NameofConstraint As String = ""
                    If dt.Rows.Count > 0 AndAlso Not dt.Rows(0).Item("NameofConstraint") Is System.DBNull.Value Then NameofConstraint = dt.Rows(0).Item("NameofConstraint").ToString.Trim

                    If NameofConstraint <> "" Then
                        sqlDB = sqlDB + "alter table " + pp(0).Trim + " DROP CONSTRAINT [" + NameofConstraint + "];" + nvrd    'skida PK
                    End If


                ElseIf action = "ADD" OrElse action = "ALTER COLUMN" Then
                    Dim dtsql As String = "SELECT DATA_TYPE,isnull(numeric_precision,0) as numeric_precision," +
                        " isnull(numeric_scale,0) as numeric_scale,isnull(CHARACTER_MAXIMUM_LENGTH,0) as CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE" +
                        " FROM INFORMATION_SCHEMA.COLUMNS" +
                        " WHERE TABLE_NAME = N'" + pp(0).Trim + "' and COLUMN_NAME = N'" + pp(1).Trim + "'"

                    Dim dt As DataTable = izvrsiSQLvratiDT(dtsql, connectionstring, Nothing)
                    Dim DataType As String = dt.Rows(0).Item("DATA_TYPE").ToString.Trim
                    Dim numeric_precision As String = dt.Rows(0).Item("numeric_precision").ToString.Trim
                    Dim numeric_scale As String = dt.Rows(0).Item("numeric_scale").ToString.Trim
                    Dim IS_NULLABLE As String = dt.Rows(0).Item("IS_NULLABLE").ToString.Trim
                    Dim CHARACTER_MAXIMUM_LENGTH As String = dt.Rows(0).Item("CHARACTER_MAXIMUM_LENGTH").ToString.Trim

                    Dim rest As String = ""

                    If CHARACTER_MAXIMUM_LENGTH <> "0" Then
                        rest = rest + "(" + CHARACTER_MAXIMUM_LENGTH + ")"
                    ElseIf numeric_precision <> "0" Then
                        rest = rest + "(" + numeric_precision
                        If numeric_scale <> "0" Then
                            rest = rest + "," + numeric_scale
                        End If
                        rest = rest + ")"
                    End If

                    If IS_NULLABLE = "YES" Then
                        rest = rest + " NULL"
                    Else
                        rest = rest + " NOT NULL"
                    End If

                    sqlDB = sqlDB + "ALTER TABLE " + pp(0).Trim + " " + action + "  " + pp(1).Trim + " " + DataType + " " + rest + ";" + nvrd

                ElseIf action = "RENAME" Then
                    sqlDB = sqlDB + pp(0) + ";" + nvrd
                ElseIf action = "DROPTABLE" Then
                    'sqlDB = sqlDB + pp(0) + nvrd
                ElseIf action = "DROPCONSTRAINT" Then

                    sqlDB = "select Col.Column_Name As pk from INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col WHERE" +
                            " Col.Constraint_Name = Tab.Constraint_Name " +
                            " And Col.Table_Name = Tab.Table_Name " +
                            " And Constraint_Type = 'PRIMARY KEY' " +
                            " AND Col.Table_Name =N'" + pp(0).Trim + "'"
                    Dim dt1 As New DataTable
                    dt1 = izvrsiSQLvratiDT(sqlDB, connectionstring, Nothing)
                    Dim nn As String = ""

                    For ii As Integer = 0 To dt1.Rows.Count - 1
                        nn = nn + dt1.Rows(ii).Item("pk").ToString.Trim + ","
                    Next
                    nn = nn.TrimEnd(",")

                    If pp(1) <> "" Then
                        sqlDB = sqlDB + " alter table " + pp(0).Trim + " ADD PRIMARY KEY (" + nn + ");" + nvrd
                    End If

                End If
            End If
        Next
        Return sqlDB
    End Function
    Function napraviIzOpenFormeBackUpIzvrsiSQL(ByVal dIST As DatasetIstrazivanja, ByVal sifist As String, ByVal glavnatabela As String, ByVal DBConnectionString As String, ByVal ISTConnectionString As String, ByVal strI As String, Optional ByVal isttabele As String = "", Optional ByVal slqDBDropTip As String = "", Optional ByVal DBDropTip As String = "", Optional WHAT As String = "") As String
        If isttabele = "" Then isttabele = "ISTPOLJA"
        Dim DBtxt As String = ""
        If slqDBDropTip <> "" AndAlso DBDropTip <> "" Then
            Dim pp() As String = slqDBDropTip.Split("#")
            Dim ppDrop() As String = DBDropTip.Split("#")
            If pp.Length <> ppDrop.Length Then
                ISTMessageBox.Show("napraviBackUpizvrsiSQLISTTABLES" + nvrd + nvrd + "pp<>ppdrop")
            End If
            For i As Integer = 0 To pp.GetUpperBound(0)
                pp(i) = pp(i).TrimEnd("#")
                If ppDrop(i) = "DROP" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "ADD", DBConnectionString)
                ElseIf ppDrop(i) = "ADD" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "DROP", DBConnectionString)
                ElseIf ppDrop(i) = "ALTER COLUMN" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "ALTER COLUMN", DBConnectionString)
                ElseIf ppDrop(i) = "RENAME" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "RENAME", DBConnectionString)
                ElseIf ppDrop(i) = "DROPTABLE" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "DROPTABLE", DBConnectionString)
                ElseIf ppDrop(i) = "ADDPK" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "ADDPK", DBConnectionString)
                ElseIf ppDrop(i) = "DROPCONSTRAINT" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "DROPCONSTRAINT", DBConnectionString)
                End If
            Next
        End If

        If WHAT = "" Then
            Call BackUp(dIST, sifist, glavnatabela.Trim, param(isttabele), DBtxt, "UNOS")
        End If

        Dim p As String = "nok"
        If strI <> "" Then
            strI = " begin transaction; " + nvrd + strI + nvrd + " commit;"
            p = izvrsiSQL(strI, ISTConnectionString)
        Else
            p = "ok"
        End If

        'p = "ok"
        Return p
    End Function

#End Region

#Region "TreeView"
    Function ttTtt(ByVal nnode As TreeNode) As String()
        Dim alla As String = ""
        Dim ttabela As String = nnode.Tag
        Dim cc As String = GetChildren(nnode)
        Dim pp As String = AllParents(nnode)
        alla = (pp + cc).TrimEnd("#").TrimStart("#").Trim.ToUpper
        Dim tt() As String = alla.Trim.ToUpper.Split("#")
        'Dim nadnadtabela As String = tt(0)
        Return tt
    End Function
    Function AllParents(ByVal node As TreeNode) As String
        Dim lista As String = ""
        While (node.Parent IsNot Nothing)
            'lista = lista + node.Parent.Text + "#"
            lista = lista + node.Parent.Tag + "#"
            node = node.Parent
        End While
        Dim lista1 As String = ""
        Dim tt() As String = lista.Split("#")
        For i As Integer = tt.GetUpperBound(0) To 0 Step -1
            lista1 = lista1 + tt(i) + "#"
        Next
        Return lista1
    End Function
    Dim cnodes As String = ""

    Function GetChildren(parentNode As TreeNode) As String
        cnodes = ""
        'cnodes = cnodes + parentNode.Text + "#"
        cnodes = cnodes + parentNode.Tag + "#"
        GetAllChildren(parentNode, cnodes)
        Return cnodes
    End Function

    Sub GetAllChildren(parentNode As TreeNode, nodes As String)
        For Each childNode As TreeNode In parentNode.Nodes
            'cnodes = cnodes + childNode.Text + "#"
            cnodes = cnodes + childNode.Tag + "#"
            GetAllChildren(childNode, cnodes)
        Next
    End Sub
    Sub fontRegularSelectedNode(ByVal tv As Windows.Forms.TreeView)
        For Each nn As TreeNode In tv.Nodes
            nn.NodeFont = New Font(tv.Font, FontStyle.Regular)
            RecursiveBOLD(tv, nn)
        Next
    End Sub
    Private Sub RecursiveBOLD(ByVal tv As Windows.Forms.TreeView, ByVal treeNode As TreeNode)
        For Each tn As TreeNode In treeNode.Nodes
            tn.NodeFont = New Font(tv.Font, FontStyle.Regular)
            RecursiveBOLD(tv, tn)
        Next
    End Sub
    Dim NodesThatMatch As New List(Of TreeNode)
    Function SearchTheTreeView(ByVal tv As Windows.Forms.TreeView, ByVal TextToFind As String) As TreeNode
        '  Empty previous
        NodesThatMatch.Clear()
        ' Keep calling RecursiveSearch
        For Each nn As TreeNode In tv.Nodes
            If nn.Tag.trim.toupper = TextToFind.Trim.ToUpper Then
                NodesThatMatch.Add(nn)
            End If
            RecursiveSearch(nn, TextToFind)
        Next
        If NodesThatMatch.Count > 0 Then
            Return NodesThatMatch(0)
        Else
            Return Nothing
        End If
    End Function
    Sub RecursiveSearch(ByVal treeNode As TreeNode, ByVal TextToFind As String)
        ' Keep calling the test recursively.
        For Each nn As TreeNode In treeNode.Nodes
            If nn.Tag.trim.toupper = TextToFind.Trim.ToUpper Then
                NodesThatMatch.Add(nn)
            End If
            RecursiveSearch(nn, TextToFind)
        Next
    End Sub
#End Region

    Sub UpdateReg(ByVal app As String)

        Dim rr As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser
        Dim registrySubKey As Microsoft.Win32.RegistryKey
        registrySubKey = rr.OpenSubKey("SOFTWARE\VB and VBA Program Settings\Istrazivanja\Izbor", True)

        Dim valueNames As String() = registrySubKey.GetValueNames()
        Dim valuedata As String = ""
        Dim pp() As String = {"", "", "", "", "", ""}  '6

        Dim pom As Integer = -1
        If valueNames.Count <= 5 Then
            pom = valueNames.Count
        Else
            pom = 5
        End If

        For i As Integer = 0 To pom - 1 ' valueNames.GetUpperBound(0)
            valuedata = registrySubKey.GetValue(valueNames(i))
            pp(i) = valuedata
        Next
        Dim bpp() As String = {}
        Dim ibb As Integer = -1

        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i) <> "" AndAlso pp(i).Trim.ToUpper <> app.Trim.ToUpper Then
                ibb = ibb + 1
                ReDim Preserve bpp(ibb)
                bpp(ibb) = pp(i)
            End If
        Next

        registrySubKey.SetValue("1", app, Microsoft.Win32.RegistryValueKind.String)

        For i As Integer = 0 To bpp.GetUpperBound(0)
            registrySubKey.SetValue(CStr(i + 2).Trim, bpp(i), Microsoft.Win32.RegistryValueKind.String)
        Next


        registrySubKey.Flush()

    End Sub
    Sub DeleteReg(ByVal app As String)
        Dim rr As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser
        Dim registrySubKey As Microsoft.Win32.RegistryKey
        registrySubKey = rr.OpenSubKey("SOFTWARE\VB and VBA Program Settings\Istrazivanja\Izbor")

        Dim valueNames As String() = registrySubKey.GetValueNames()
        Dim valuedata As String = ""
        Dim pp() As String = {}
        Dim ipp As Integer = -1

        For i As Integer = 0 To valueNames.GetUpperBound(0)
            valuedata = registrySubKey.GetValue(valueNames(i))
            If valuedata.Trim.ToUpper = app.Trim.ToUpper Then
                registrySubKey.SetValue(valueNames(i), "", Microsoft.Win32.RegistryValueKind.String)
                Exit For
            End If
        Next
        registrySubKey.Flush()
    End Sub
    Shared Function addmvt(ByVal addmissingvalue As String) As String
        Dim f2 As String = "" : Dim f3 As String = ""
        addmissingvalue = addmissingvalue.Trim.ToUpper.Replace("ADDMISSINGVALUE", "")
        'f2="!8refuse,f3="?9dontknow
        Dim imaf2 As Boolean = False : Dim imaf3 As Boolean = False
        If addmissingvalue.ToUpper.IndexOf("F2") >= 0 Then imaf2 = True
        If addmissingvalue.ToUpper.IndexOf("F3") >= 0 Then imaf3 = True
        If imaf2 = True AndAlso imaf3 = True Then
            'Dim pomF2F3() As String = addmissingvalue.ToUpper.Split("F3")
            Dim pomF2F3() As String = Strings.Split(addmissingvalue.ToUpper, "F3")
            f2 = pomF2F3(0).Replace("F2", "").Replace("=", "")
            f3 = pomF2F3(1).Replace("=", "").Replace("}", "")
        End If
        If imaf2 = True AndAlso imaf3 = False Then
            f2 = addmissingvalue.Trim.ToUpper.Replace("F2", "").Replace("=", "").Replace("}", "")
        End If
        If imaf2 = False AndAlso imaf3 = True Then
            f3 = addmissingvalue.Trim.ToUpper.Replace("F3", "").Replace("=", "").Replace("}", "")
        End If
        addmvt = f2 + "$" + f3
    End Function

    Public Shared Function getMessageText(ByVal dt As DataTable, ByVal msgNumber As String, ByVal lang As String) As String
        getMessageText = ""
        If lang Is Nothing Or lang = "" Then lang = "EN"
        Dim pomtxt As String = "msgID='" + msgNumber + "'"
        Dim msgRow As DataRow() = dt.Select(pomtxt)
        Try
            If msgRow.Length > 0 Then
                If msgRow(0).Item("msgtext" + "-" + lang).GetType Is GetType(System.DBNull) OrElse
                   CStr(msgRow(0).Item("msgtext" + "-" + lang)) = "NaN" OrElse
                    msgRow(0).Item("msgtext" + "-" + lang).trim = "" Then
                    getMessageText = "Empty in msgCodes.xml"
                Else
                    'If msgRow.ToString.IndexOf("+vbcrlf+") >= 0 Then
                    '    getMessageText = msgRow(0).Item("msgtext" + "-" + lang).replace("+vbcrlf+", vbCrLf).Trim
                    'Else
                    '    getMessageText = msgRow(0).Item("msgtext" + "-" + lang).Trim
                    'End If
                    getMessageText = msgRow(0).Item("msgtext" + "-" + lang).Trim
                End If
            End If

            'If msgRow.Length > 0 Then
            '    getMessageText = msgRow(0).Item("msgtext" + "-" + lang).Trim
            'End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error - function getMessageText", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function getControlText(ByVal dt As DataTable, ByVal txtFormID As String, ByVal txtControlID As String, ByVal lang As String) As String
        getControlText = ""
        If lang Is Nothing Or lang = "" Then lang = "EN"
        Dim pomtxt As String = "txtFormID='" + txtFormID + "' and txtControlID='" + txtControlID + "'"
        Dim txtRow As DataRow() = dt.Select(pomtxt)
        Try
            If txtRow.Length > 0 Then
                If txtRow(0).Item("txtText" + "-" + lang).GetType Is GetType(System.DBNull) OrElse
                    CStr(txtRow(0).Item("txtText" + "-" + lang)) = "NaN" OrElse
                     txtRow(0).Item("txtText" + "-" + lang).trim = "" Then
                    getControlText = "Empty in txtCodes.xml"
                Else
                    getControlText = txtRow(0).Item("txtText" + "-" + lang).Trim
                End If

                'getControlText = txtRow(0).Item("txtText" + "-" + lang).Trim
            End If
        Catch ex As System.Exception

            ISTMessageBox.Show(ex.Message, "Error - function getControlText", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function getControlText2(ByVal dt As DataTable, ByVal txtControlID As String, ByVal lang As String) As String
        getControlText2 = ""
        If lang Is Nothing Or lang = "" Then lang = "EN"
        Dim pomtxt As String = "txtControlID='" + txtControlID + "'"
        Dim txtRow As DataRow() = dt.Select(pomtxt)
        Try
            'If txtRow.Length > 0 Then
            '    getControlText2 = txtRow(0).Item("txtText" + "-" + lang).Trim
            'End If
            If txtRow.Length > 0 Then
                If txtRow(0).Item("txtText" + "-" + lang).GetType Is GetType(System.DBNull) OrElse
                    CStr(txtRow(0).Item("txtText" + "-" + lang)) = "NaN" OrElse
                     txtRow(0).Item("txtText" + "-" + lang).trim = "" Then
                    getControlText2 = "Empty in txtCodes.xml"
                Else
                    getControlText2 = txtRow(0).Item("txtText" + "-" + lang).Trim
                End If

                'getControlText = txtRow(0).Item("txtText" + "-" + lang).Trim
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error - function getControlText2", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Function

    Function getDTVBText(ByVal dt As DataTable, ByVal txtFormID As String) As DataTable
        getDTVBText = Nothing
        Dim dv As DataView = dt.DefaultView
        dv.RowFilter = "txtFormID='" + txtFormID + "'"
        Try
            getDTVBText = dv.ToTable
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error - function getDTVBText", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Function

    Public Shared Function NZ(ByVal nesto, Optional ByVal uSta = Nothing) As String
        If nesto Is Nothing OrElse nesto.GetType Is GetType(System.DBNull) OrElse CStr(nesto) = "NaN" Then
            If uSta Is Nothing Then
                Return ""
            Else
                Return uSta
            End If
        Else
            Return CStr(nesto)
        End If
    End Function

    Function DADD(ByVal sd As String, ByVal am As Integer, ByVal ad As Integer) As String
        'MS SQL SERVER
        Dim sql As String = "dateadd(day," + ad.ToString + ",dateadd(month," + am.ToString + ",'" + sd + "'))"
        Return sql
    End Function

    Function IsNumericDataColumn(ByVal datatype As String) As Boolean
        IsNumericDataColumn = False
        If datatype = "" Then Return False
        Dim numericTypes = {GetType(Byte), GetType(Decimal), GetType(Double), GetType(Int16), GetType(Int32), GetType(Int64), GetType(SByte), GetType(Single), GetType(UInt16), GetType(UInt32), GetType(UInt64)}

        If datatype.Trim.ToUpper = "BYTE" OrElse datatype.Trim.ToUpper = "DECIMAL" OrElse datatype.Trim.ToUpper = "DOUBLE" OrElse
            datatype.Trim.ToUpper = "INT16" OrElse datatype.Trim.ToUpper = "INT32" OrElse datatype.Trim.ToUpper = "INT64" OrElse
            datatype.Trim.ToUpper = "SBYTE" OrElse datatype.Trim.ToUpper = "SINGLE" OrElse datatype.Trim.ToUpper = "UINT16" OrElse datatype.Trim.ToUpper = "UINT32" OrElse datatype.Trim.ToUpper = "UINT64" Then
            IsNumericDataColumn = True
        End If
    End Function

    Function checkBaza(ByVal app As String, ByVal appT As String, ByVal appR As String, ByVal ISTconn As String, ByVal jezik As String) As Boolean
        checkBaza = False

        Dim sql As String = "select pravabaza,server from vbazaServer where sifist='" + app.Trim + "'"
        Dim sqlT As String = "select pravabaza,server from vbazaServer where sifist='" + appT.Trim + "'"
        Dim sqlR As String = "select pravabaza,server from vbazaServer where sifist='" + appR.Trim + "'"

        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sql, ISTconn, jezik)
        Dim dtT As System.Data.DataTable = izvrsiSQLvratiDT(sqlT, ISTconn, jezik)
        Dim dtR As System.Data.DataTable = izvrsiSQLvratiDT(sqlR, ISTconn, jezik)

        Dim pb As String = ""
        If dt.Rows.Count > 0 AndAlso Not dt.Rows(0).Item("pravabaza") Is System.DBNull.Value Then pb = dt.Rows(0).Item("pravabaza").ToString.Trim.ToUpper
        If dt.Rows.Count > 0 AndAlso Not dt.Rows(0).Item("server") Is System.DBNull.Value Then pb = pb + ";" + dt.Rows(0).Item("server").ToString.Trim.ToUpper

        Dim pbT As String = ""
        If dtT.Rows.Count > 0 AndAlso Not dtT.Rows(0).Item("pravabaza") Is System.DBNull.Value Then pbT = dtT.Rows(0).Item("pravabaza").ToString.Trim.ToUpper
        If dtT.Rows.Count > 0 AndAlso Not dtT.Rows(0).Item("server") Is System.DBNull.Value Then pbT = pbT + ";" + dtT.Rows(0).Item("server").ToString.Trim.ToUpper

        Dim pbR As String = ""
        If dtR.Rows.Count > 0 AndAlso Not dtR.Rows(0).Item("pravabaza") Is System.DBNull.Value Then pbR = dtR.Rows(0).Item("pravabaza").ToString.Trim.ToUpper
        If dtR.Rows.Count > 0 AndAlso Not dtR.Rows(0).Item("server") Is System.DBNull.Value Then pbR = pbR + ";" + dtR.Rows(0).Item("server").ToString.Trim.ToUpper

        If pb = pbT AndAlso pb = pbR Then
            checkBaza = True
        End If

    End Function

    Private Function fdtvISTPoljaKljucPoTabeli(ByVal app As String, ByVal tabela As String, ByVal ISTconn As String, ByVal god As String, ByVal mes As String) As DataTable
        Dim godina As Integer = CInt(god)
        Dim mesec As Integer = CInt(mes)
        Dim d As Date = New Date(godina, mesec, 2)
        '2017-09-19 00:34:43.087 mi treba
        Dim vtvt As String = d.ToString("yyyy-MM-dd")
        Dim sql As String = "exec usp_vISTPoljaKljucPoTabeli @sifist=N'" + app.Trim + "', @tabela=N'" + tabela.Trim + "',@vt='" + vtvt + "'"
        fdtvISTPoljaKljucPoTabeli = izvrsiSQLvratiDT(sql, ISTconn, Nothing)
    End Function
    Dim fpm As Boolean = False
    Dim fpg As Boolean = False
    Dim fpmonth As Boolean = False
    Dim fpy As Boolean = False
    Dim fpk As Boolean = False
    Dim fpq As Boolean = False
    Dim fpp As Boolean = False
    Dim fph As Boolean = False
    Dim strLeftJoin As String = ""
    Dim strSelect As String = ""
    Dim strSelectactbDB As String = ""
    Dim postojiPoljeLK As Boolean
    Dim zakljucanOdmahSve As Boolean
    Dim iskljucenaLKsemZaAdresare As Integer
    Dim iskljucenaLKCela As Integer

    Public Function ZameniISTPM(ByVal sstr As String, ByVal ggod As String, ByVal mmes As String, ByVal imaG As Boolean, ByVal imaGE As Boolean, ByVal imaM As Boolean, ByVal imaME As Boolean) As String

        Dim sql As String = sstr
        Dim god As String = CStr(ggod)
        Dim mes As String = CStr(mmes).Trim.PadLeft(2, "0"c)

        'PM
        If mes = 1 Then mes = "12" : god = CStr(god - 1)
        If mes > 1 Then mes = CStr(mes - 1).Trim.PadLeft(2, "0"c) : god = CStr(god)
        Dim istpm As String = "god='" + god + "' and mes='" + mes + "'"
        Dim istpmonth As String = "ISTYear='" + god + "' and ISTMonth='" + mes + "'"

        'PK
        god = CStr(god)
        mes = CStr(mes).Trim.PadLeft(2, "0"c)
        If mes >= 4 Then mes = CStr(mes - 3).Trim.PadLeft(2, "0"c) : god = CStr(god)
        If mes < 4 Then mes = CStr(mes + 9).Trim.PadLeft(2, "0"c) : god = CStr(god - 1)
        Dim istpk As String = "god='" + god + "' and mes='" + mes + "'"
        Dim istpq As String = "ISTYear='" + god + "' and ISTMonth='" + mes + "'"

        'PP
        god = CStr(god)
        mes = CStr(mes).Trim.PadLeft(2, "0"c)
        If mes >= 7 Then mes = CStr(mes - 6).Trim.PadLeft(2, "0"c) : god = CStr(god)
        If mes < 7 Then mes = CStr(mes + 6).Trim.PadLeft(2, "0"c) : god = CStr(god - 1)
        Dim istpp As String = "god='" + god + "' and mes='" + mes + "'"
        Dim istph As String = "ISTYear='" + god + "' and ISTMonth='" + mes + "'"

        'PG
        god = CStr(god)
        mes = CStr(mes).Trim.PadLeft(2, "0"c)
        Dim istpg As String = ""
        Dim istpy As String = ""

        If imaG = True And imaM = True Then istpg = "god='" + CStr(god - 1) + "' and mes='" + mes + "'"
        If imaGE = True And imaME = True Then istpy = "ISTYear='" + CStr(god - 1) + "' and ISTMonth='" + mes + "'"
        If imaG = True And imaM = False Then istpg = "god='" + CStr(god - 1) + "'"
        If imaGE = True And imaME = False Then istpy = "ISTYear='" + CStr(god - 1) + "'"

        sql = strrpl(sql, "{ISTPM}", istpm)
        sql = strrpl(sql, "{ISTPG}", istpg)
        sql = strrpl(sql, "{ISTPMonth}", istpmonth)
        sql = strrpl(sql, "{ISTPY}", istpy)
        sql = strrpl(sql, "{ISTPK}", istpk)
        sql = strrpl(sql, "{ISTPQ}", istpq)
        sql = strrpl(sql, "{ISTPP}", istpp)
        sql = strrpl(sql, "{ISTPH}", istph)

        sstr = sql

        Return sstr
    End Function

    Function filterstrLeftJoin(ByVal dr As DataRow, ByVal upit As String, ByVal filter As String, ByVal ime As String) As String
        filterstrLeftJoin = ""

        If dr.Item(upit).ToString.Trim <> "" AndAlso dr.Item(filter).ToString.Trim <> "" AndAlso dr.Item(filter).ToString.Trim.IndexOf("=") > 0 Then
            Dim a As String = ""
            Dim p As String = dr.Item(filter).ToString.Trim.ToUpper
            Dim pp() As String = p.Split("=")
            Dim c As String = ""
            For ii As Integer = 0 To pp.GetUpperBound(0)
                If pp(ii).IndexOf("D.") = 0 Then
                    a = a + " PODACI." + pp(ii).Replace("D.", "") + "="
                Else
                    a = a + " " + ime + dr.Item("poljeORG").ToString.Trim + ".f_" + pp(ii).Trim + "="
                    c = pp(ii).Trim + " as f_" + pp(ii).Trim + ","
                End If
            Next
            a = a.TrimEnd("=")
            Dim b As String = dr.Item(upit).ToString.Trim.ToUpper
            If b.IndexOf("DISTINCT") > 0 Then b = b.Replace("DISTINCT", "")
            b = b.Replace("SELECT", "SELECT DISTINCT " + c)
            filterstrLeftJoin = filterstrLeftJoin + b + " " + " and " + a + " "

        ElseIf dr.Item(upit).ToString.Trim <> "" AndAlso dr.Item(filter).ToString.Trim = "" Then
            filterstrLeftJoin = filterstrLeftJoin + dr.Item(upit) + " "
        End If

    End Function
    Function zameniD(ByVal izraz As String, ByVal tabela As String) As String
        Dim t As String = tabela
        izraz = izraz.Trim.ToUpper
        Dim bbb() As String = razkvantaj(izraz)
        For i As Integer = 0 To bbb.GetUpperBound(0)
            If bbb(i).Trim.IndexOf("D.") = 0 Then
                'sa ekrana pokupi D.
                Dim cime As String = bbb(i).Replace("D.", "").ToString.Trim
                bbb(i) = tabela + "." + cime
            End If
        Next
        Dim zzz1 As String = ustringaj(bbb).ToUpper
        zameniD = zzz1
    End Function

    Public Shared Function zameniDecryptIST(ByVal sql As String) As String

        sql = sql.Trim.ToUpper

        Dim bbb() As String = razkvantaj(sql)
        For i As Integer = 0 To bbb.GetUpperBound(0)
            If bbb(i).Trim.IndexOf("DECRYPTIST.") = 0 Then
                'sa ekrana pokupi D.
                bbb(i) = bbb(i).Replace("DECRYPTIST.", "").ToString.Trim
                bbb(i) = "Trim(Convert(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, Convert(varbinary(256), (Case when trim(" + bbb(i).ToString.Trim + ")='' then NULL else " + bbb(i).ToString.Trim + " end), 1), 1, Convert(varbinary, @Hash)))))"
            End If
        Next
        Dim zzz1 As String = ustringaj(bbb).ToUpper
        zzz1 = " Declare @Lozinka NVARCHAR(50);    " + vbCrLf +
                  " Declare @Hash NVARCHAR(50);    " + vbCrLf +
                  " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';    " + vbCrLf +
                  " Set @Hash  = '12345';    " + vbCrLf +
                  " Declare @a as varbinary(256);  " + vbCrLf + zzz1
        zameniDecryptIST = zzz1
    End Function

    Function fdtusp_vISTPoljaPregledTabela(ByVal app As String, ByVal tabela As String,
                                           ByVal uslov As String, ByVal ISTconn As String,
                                           ByVal god As String, ByVal mes As String) As System.Data.DataTable
        Dim godina As Integer = CInt(god)
        Dim mesec As Integer = CInt(mes)
        Dim d As Date = New Date(godina, mesec, 2)
        '2017-09-19 00:34:43.087 mi treba
        Dim vtvt As String = d.ToString("yyyy-MM-dd")
        Dim sql As String = "exec usp_vISTPoljaPregledTabela @vt='" + vtvt + "',@sifist=N'" + app.Trim + "',@tabela=N'" + tabela + "',@uslov=N'" + uslov + "'"
        fdtusp_vISTPoljaPregledTabela = izvrsiSQLvratiDT(sql, ISTconn, Nothing)
    End Function

    Public Sub CopyFile(ByVal sourcePath As String, ByVal DestinationPath As String, ByVal fName As String)
        If System.IO.File.Exists(sourcePath + fName) = True Then System.IO.File.Copy(sourcePath + fName, DestinationPath + fName)
    End Sub

    Sub sveuLAT()
        For Each cntl As Control In Me.Controls
            If TypeOf cntl Is GroupBox Then
                cntl.Text = konverzijaCirLat(cntl.Text)
                For Each gbc As Control In cntl.Controls
                    gbc.Text = konverzijaCirLat(gbc.Text)
                Next
            ElseIf TypeOf cntl Is PictureBox Then
                For Each pbc As Control In cntl.Controls
                    If Not (pbc.Tag Is "nediraj") Then pbc.Text = konverzijaCirLat(pbc.Text)
                Next
            ElseIf TypeOf cntl Is Panel Then
                cntl.Text = konverzijaCirLat(cntl.Text)
                For Each pc As Control In cntl.Controls
                    If TypeOf pc Is GroupBox Then
                        pc.Text = konverzijaCirLat(pc.Text)
                        For Each gbc As Control In pc.Controls
                            gbc.Text = konverzijaCirLat(gbc.Text)
                        Next
                    ElseIf TypeOf pc Is Panel Then
                        pc.Text = konverzijaCirLat(pc.Text)
                        For Each pc1 As Control In pc.Controls
                            pc1.Text = konverzijaCirLat(pc1.Text)
                        Next
                    ElseIf TypeOf pc Is TabControl Then
                        For Each tp As TabPage In CType(pc, TabControl).TabPages
                            tp.Text = konverzijaCirLat(tp.Text)
                            For Each tcc As Control In tp.Controls
                                tcc.Text = konverzijaCirLat(tcc.Text)
                            Next
                        Next
                    ElseIf TypeOf pc Is System.Windows.Forms.ToolBar Then
                        For i As Integer = 0 To CType(pc, System.Windows.Forms.ToolBar).Buttons.Count - 1
                            CType(pc, System.Windows.Forms.ToolBar).Buttons.Item(i).Text = konverzijaCirLat(CType(pc, System.Windows.Forms.ToolBar).Buttons.Item(i).Text)
                        Next
                    Else
                        If Not (pc.Tag Is "nediraj") Then pc.Text = konverzijaCirLat(pc.Text)
                    End If
                Next
            ElseIf TypeOf cntl Is TabControl Then
                For Each tp As TabPage In CType(cntl, TabControl).TabPages
                    tp.Text = konverzijaCirLat(tp.Text)
                    For Each tcc As Control In tp.Controls
                        tcc.Text = konverzijaCirLat(tcc.Text)
                    Next
                Next
            ElseIf TypeOf cntl Is System.Windows.Forms.ToolBar Then
                For i As Integer = 0 To CType(cntl, System.Windows.Forms.ToolBar).Buttons.Count - 1
                    CType(cntl, System.Windows.Forms.ToolBar).Buttons.Item(i).Text = konverzijaCirLat(CType(cntl, System.Windows.Forms.ToolBar).Buttons.Item(i).Text)
                Next
            Else
                If Not (cntl.Tag Is "nediraj") Then cntl.Text = konverzijaCirLat(cntl.Text)
            End If
        Next

        If Not Me.Menu Is Nothing Then
            For Each ii As MenuItem In Me.Menu.MenuItems
                If Not (ii.Tag Is "nediraj") Then ii.Text = konverzijaCirLat(ii.Text)
                For Each ii1 As MenuItem In ii.MenuItems
                    If Not (ii1.Tag Is "nediraj") Then ii1.Text = konverzijaCirLat(ii1.Text)
                    For Each ii2 As MenuItem In ii1.MenuItems
                        If Not (ii2.Tag Is "nediraj") Then ii2.Text = konverzijaCirLat(ii2.Text)
                    Next
                Next
            Next
        End If
        Me.Text = konverzijaCirLat(Me.Text)
    End Sub

    Sub sveuCIR()
        For Each cntl As Control In Me.Controls
            If TypeOf cntl Is GroupBox Then
                cntl.Text = konverzijaLatCir(cntl.Text)
                For Each gbc As Control In cntl.Controls
                    gbc.Text = konverzijaLatCir(gbc.Text)
                Next
            ElseIf TypeOf cntl Is PictureBox Then
                For Each pbc As Control In cntl.Controls
                    If Not (pbc.Tag Is "nediraj") Then pbc.Text = konverzijaLatCir(pbc.Text)
                Next
            ElseIf TypeOf cntl Is Panel Then
                cntl.Text = konverzijaLatCir(cntl.Text)
                For Each pc As Control In cntl.Controls
                    If TypeOf pc Is GroupBox Then
                        pc.Text = konverzijaLatCir(pc.Text)
                        For Each gbc As Control In pc.Controls
                            gbc.Text = konverzijaLatCir(gbc.Text)
                        Next
                    ElseIf TypeOf pc Is Panel Then
                        pc.Text = konverzijaLatCir(pc.Text)
                        For Each pc1 As Control In pc.Controls
                            pc1.Text = konverzijaLatCir(pc1.Text)
                        Next
                    ElseIf TypeOf pc Is TabControl Then
                        For Each tp As TabPage In CType(pc, TabControl).TabPages
                            tp.Text = konverzijaLatCir(tp.Text)
                            For Each tcc As Control In tp.Controls
                                tcc.Text = konverzijaLatCir(tcc.Text)
                            Next
                        Next
                    ElseIf TypeOf pc Is System.Windows.Forms.ToolBar Then
                        For i As Integer = 0 To CType(pc, System.Windows.Forms.ToolBar).Buttons.Count - 1
                            CType(pc, System.Windows.Forms.ToolBar).Buttons.Item(i).Text = konverzijaLatCir(CType(pc, System.Windows.Forms.ToolBar).Buttons.Item(i).Text)
                        Next
                    Else
                        If Not (pc.Tag Is "nediraj") Then pc.Text = konverzijaLatCir(pc.Text)
                    End If
                Next
            ElseIf TypeOf cntl Is TabControl Then
                For Each tp As TabPage In CType(cntl, TabControl).TabPages
                    tp.Text = konverzijaLatCir(tp.Text)
                    For Each tcc As Control In tp.Controls
                        tcc.Text = konverzijaLatCir(tcc.Text)
                    Next
                Next
            ElseIf TypeOf cntl Is System.Windows.Forms.ToolBar Then
                For i As Integer = 0 To CType(cntl, System.Windows.Forms.ToolBar).Buttons.Count - 1
                    CType(cntl, System.Windows.Forms.ToolBar).Buttons.Item(i).Text = konverzijaLatCir(CType(cntl, System.Windows.Forms.ToolBar).Buttons.Item(i).Text)
                Next
            Else
                If Not (cntl.Tag Is "nediraj") Then cntl.Text = konverzijaLatCir(cntl.Text)
            End If
        Next

        If Not Me.Menu Is Nothing Then
            For Each ii As MenuItem In Me.Menu.MenuItems
                If Not (ii.Tag Is "nediraj") Then ii.Text = konverzijaLatCir(ii.Text)
                For Each ii1 As MenuItem In ii.MenuItems
                    If Not (ii1.Tag Is "nediraj") Then ii1.Text = konverzijaLatCir(ii1.Text)
                    For Each ii2 As MenuItem In ii1.MenuItems
                        If Not (ii2.Tag Is "nediraj") Then ii2.Text = konverzijaLatCir(ii2.Text)
                    Next
                Next
            Next
        End If
        Me.Text = konverzijaLatCir(Me.Text)
    End Sub

    Function ProveraUnosLOCKTemplate(ByVal tabela As String, ByVal konpravaBaza As String,
                                   ByVal GGG As String, ByVal MMM As String, ByVal jezik As String, ByVal ssql As String) As Integer ' vraca 1 ako je zakljucan unos

        ProveraUnosLOCKTemplate = 0

        Dim sql As String = " Select * from " & tabela & " where 2=3  "
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(sql, konpravaBaza, jezik)
        Dim ImaG As Boolean = False
        Dim ImaM As Boolean = False
        Dim ImaGE As Boolean = False
        Dim ImaME As Boolean = False
        If Not dt.Columns("GOD") Is Nothing Then ImaG = True
        If Not dt.Columns("MES") Is Nothing Then ImaM = True
        If Not dt.Columns("ISTYEAR") Is Nothing Then ImaGE = True
        If Not dt.Columns("ISTMONTH") Is Nothing Then ImaME = True

        If Not dt.Columns("LK") Is Nothing Then 'ima kolonu LK
            Dim GG As String = CStr(GGG)
            Dim MM As String = CStr(MMM).Trim.PadLeft(2, "0"c)
            sql = " Select min(cast(isnull(LK,0) As Integer)) As LK from " & tabela & " where 2=2  "
            If ImaG Then sql = sql + " And god='" + GG + "'"
            If ImaM Then sql = sql + " and mes='" + MM + "'"
            If ImaGE Then sql = sql + " And ISTYEAR='" + GG + "'"
            If ImaME Then sql = sql + " and ISTMONTH='" + MM + "'"

            If ssql <> "" Then sql = sql + " and " & ssql

            Dim dt1 As New System.Data.DataTable
            dt1 = izvrsiSQLvratiDT(sql, konpravaBaza, jezik)
            If (Not (dt1.Rows(0).Item("LK").GetType Is GetType(System.DBNull))) AndAlso dt1.Rows(0).Item("LK").ToString.Trim = "1" Then
                'zakljucan materijal u celoj vrtacki
                ProveraUnosLOCKTemplate = 1
            End If
        End If
        Return ProveraUnosLOCKTemplate
    End Function

    Public Function NadjiKontrolu(ByVal parent As Control, ByVal ident As String) As Control
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If child.Name.Trim.ToUpper = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluKojaJeFP(ByVal parent As Control, ByVal ident As String) As System.Windows.Forms.TextBox
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If TypeOf child Is System.Windows.Forms.TextBox AndAlso child.Name.Trim.ToUpper = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluKojaJeLABELA(ByVal parent As Control, ByVal ident As String) As Control
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If TypeOf child Is System.Windows.Forms.Label AndAlso child.Name.Trim.ToUpper = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluKojaJePanel(ByVal parent As Control, ByVal ident As String) As Control
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If TypeOf child Is Panel AndAlso child.Name.Trim.ToUpper = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluKojaJeRB(ByVal parent As Control, ByVal ident As String) As Control
        Dim control As Control = Nothing
        Dim m As Integer = 0
        For Each child As Control In parent.Controls
            If TypeOf child Is Panel AndAlso Mid(child.Name.ToString.Trim.ToUpper, 1, 2) = "RG" Then
                For Each kk As Control In child.Controls
                    If TypeOf kk Is RadioButton AndAlso kk.Name.Trim.ToUpper = ident.Trim.ToUpper Then
                        control = kk
                        Exit For
                        m = 1
                    End If
                Next
                If m = 1 Then Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluKojaNijeLABELA(ByVal parent As Control, ByVal ident As String) As Control
        If ident Is Nothing Then NadjiKontroluKojaNijeLABELA = Nothing : Exit Function
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If Not TypeOf child Is System.Windows.Forms.Label AndAlso child.Name.Trim.ToUpper = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluSkr(ByVal parent As Control, ByVal ident As String, ByVal k As Integer) As Control
        If ident Is Nothing Then NadjiKontroluSkr = Nothing : Exit Function
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If child.Name.Trim.ToUpper.Length >= k AndAlso child.Name.Trim.ToUpper.Substring(k) = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluSkrKojaNijeLABELA(ByVal parent As Control, ByVal ident As String, ByVal k As Integer) As Control
        If ident Is Nothing Then NadjiKontroluSkrKojaNijeLABELA = Nothing : Exit Function
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If Not TypeOf child Is System.Windows.Forms.Label AndAlso child.Name.Trim.ToUpper.Length >= k AndAlso child.Name.Trim.ToUpper.Substring(k) = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluSkrKojaNijeLABELAiNijeFP(ByVal parent As Control, ByVal ident As String, ByVal k As Integer) As Control
        If ident Is Nothing Then NadjiKontroluSkrKojaNijeLABELAiNijeFP = Nothing : Exit Function
        'If k = 3 Then Panel
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If Not TypeOf child Is System.Windows.Forms.Label AndAlso child.Name.Trim.ToUpper.Length >= k AndAlso child.Name.Trim.ToUpper.Substring(k - 2, 2) <> "FP" AndAlso child.Name.Trim.ToUpper.Substring(k) = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluKojaNijeLABELAiNijeFP(ByVal parent As Control, ByVal ident As String) As Control
        If ident Is Nothing Then NadjiKontroluKojaNijeLABELAiNijeFP = Nothing : Exit Function
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If Not TypeOf child Is System.Windows.Forms.Label AndAlso child.Name.Trim.ToUpper.Length >= 3 AndAlso child.Name.Trim.ToUpper.Substring(0, 2) <> "FP" AndAlso child.Name.Trim.ToUpper.Substring(2) = ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluSkrKojaJeDATAGRIDVIEW(ByVal parent As Control, ByVal ident As String) As Control
        If ident Is Nothing Then NadjiKontroluSkrKojaJeDATAGRIDVIEW = Nothing : Exit Function
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If TypeOf child Is DataGridView2 AndAlso child.Name.Trim.ToUpper = "IDGV" + ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluSkrKojaJeBUTTON(ByVal parent As Control, ByVal ident As String) As Control
        If ident Is Nothing Then NadjiKontroluSkrKojaJeBUTTON = Nothing : Exit Function
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If TypeOf child Is System.Windows.Forms.Button AndAlso child.Name.Trim.ToUpper = "BTN" + ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    'Public Function NadjiKontroluSkrKojaJeBUTTONDBTNSAVE(ByVal parent As Control) As Control
    '    Dim control As Control = Nothing
    '    For Each child As Control In parent.Controls
    '        If TypeOf child Is Button AndAlso child.Name.Trim.ToUpper.IndexOf("DBTNSAVE") = 0 Then
    '            control = child
    '            'Exit For
    '        End If
    '    Next
    '    Return control
    'End Function

    Public Function NadjiKontroluSkrKojaJeBUTTONPLUS(ByVal parent As Control, ByVal ident As String) As Control
        If ident Is Nothing Then NadjiKontroluSkrKojaJeBUTTONPLUS = Nothing : Exit Function
        Dim control As Control = Nothing
        For Each child As Control In parent.Controls
            If TypeOf child Is System.Windows.Forms.Button AndAlso child.Name.Trim.ToUpper = "BTNPLUS" + ident.Trim.ToUpper Then
                control = child
                Exit For
            End If
        Next
        Return control
    End Function

    Public Function NadjiKontroluSkrKojaNijeLABELAiKojaJeUKLJUCU(ByVal parent As Control, ByVal ident As String, ByVal k As Integer) As Control
        If ident Is Nothing Then NadjiKontroluSkrKojaNijeLABELAiKojaJeUKLJUCU = Nothing : Exit Function
        Dim control As Control = Nothing
        For Each k1 As Control In parent.Controls
            If Mid(k1.Name.Trim.ToUpper, 1, 1) = "G" Then
                For Each child As Control In k1.Controls
                    If Not TypeOf child Is System.Windows.Forms.Label AndAlso child.Name.Trim.ToUpper.Length >= k AndAlso child.Name.Trim.ToUpper.Substring(k) = ident.Trim.ToUpper Then
                        control = child
                        Exit For
                    End If
                Next
            End If
        Next
        Return control
    End Function

    Function getttt(ByVal text As String, ByVal what As String) As String
        getttt = ""
        If text.Trim.ToUpper.IndexOf(what) >= 0 Then
            Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
            getttt = text.Trim.ToUpper.Substring(b + what.Length)
        End If
    End Function

    Public Shared Function newintersect(ByVal list1() As System.Windows.Forms.TextBox, ByVal list2() As System.Windows.Forms.TextBox) As System.Windows.Forms.TextBox()
        Dim ImaUPrvomImauDrugom() As System.Windows.Forms.TextBox = {}
        Dim ii As Integer = -1
        If Not (list1 Is Nothing) AndAlso list1.Length > 0 AndAlso Not (list2 Is Nothing) AndAlso list2.Length > 0 Then
            Dim smaller As HashSet(Of System.Windows.Forms.TextBox)
            Dim larger As System.Windows.Forms.TextBox()
            If list1.Length < list2.Length Then
                smaller = New HashSet(Of System.Windows.Forms.TextBox)(list1)
                larger = list2
            Else
                smaller = New HashSet(Of System.Windows.Forms.TextBox)(list2)
                larger = list1
            End If
            For Each item As System.Windows.Forms.TextBox In larger
                If smaller.Contains(item) Then
                    ii = ii + 1
                    ReDim Preserve ImaUPrvomImauDrugom(ii)
                    ImaUPrvomImauDrugom(ii) = item
                End If
            Next
        Else
            'prazan skup
        End If
        Return ImaUPrvomImauDrugom
    End Function
    Public Shared Function newintersectString(ByVal list1() As String, ByVal list2() As String) As String()
        Dim ImaUPrvomImauDrugom() As String = {}
        Dim ii As Integer = -1
        If Not (list1 Is Nothing) AndAlso list1.Length > 0 AndAlso Not (list2 Is Nothing) AndAlso list2.Length > 0 Then
            Dim smaller As HashSet(Of String)
            Dim larger As String()
            If list1.Length < list2.Length Then
                smaller = New HashSet(Of String)(list1)
                larger = list2
            Else
                smaller = New HashSet(Of String)(list2)
                larger = list1
            End If
            For Each item As String In larger
                If smaller.Contains(item) Then
                    ii = ii + 1
                    ReDim Preserve ImaUPrvomImauDrugom(ii)
                    ImaUPrvomImauDrugom(ii) = item
                End If
            Next
        Else
            'prazan skup
        End If
        Return ImaUPrvomImauDrugom
    End Function
    Public Shared Function newexcept(ByVal list1() As System.Windows.Forms.TextBox, ByVal list2() As System.Windows.Forms.TextBox) As System.Windows.Forms.TextBox()
        Dim ImauPrvomNemauDrugom() As System.Windows.Forms.TextBox = {}
        Dim ii As Integer = -1
        If Not (list1 Is Nothing) AndAlso list1.Length > 0 AndAlso Not (list2 Is Nothing) AndAlso list2.Length > 0 Then
            Dim llist2 As HashSet(Of System.Windows.Forms.TextBox)
            llist2 = New HashSet(Of System.Windows.Forms.TextBox)(list2)
            For Each item As System.Windows.Forms.TextBox In list1
                If Not llist2.Contains(item) Then
                    ii = ii + 1
                    ReDim Preserve ImauPrvomNemauDrugom(ii)
                    ImauPrvomNemauDrugom(ii) = item
                End If
            Next
        Else
            ImauPrvomNemauDrugom = list1
        End If

        Return ImauPrvomNemauDrugom
    End Function
    Public Shared Function newexceptString(ByVal list1() As String, ByVal list2() As String) As String()
        Dim ImauPrvomNemauDrugom() As String = {}
        Dim ii As Integer = -1
        If Not (list1 Is Nothing) AndAlso list1.Length > 0 AndAlso Not (list2 Is Nothing) AndAlso list2.Length > 0 Then
            Dim llist2 As HashSet(Of String)
            llist2 = New HashSet(Of String)(list2)
            For Each item As String In list1
                If Not llist2.Contains(item) Then
                    ii = ii + 1
                    ReDim Preserve ImauPrvomNemauDrugom(ii)
                    ImauPrvomNemauDrugom(ii) = item
                End If
            Next
        Else
            ImauPrvomNemauDrugom = list1
        End If

        Return ImauPrvomNemauDrugom
    End Function
    Public Shared Function konverzijaLatCir(ByVal naziv As String) As String

        naziv = Replace(naziv, "q", "љ")
        naziv = Replace(naziv, "Q", "Љ")
        naziv = Replace(naziv, "w", "њ")
        naziv = Replace(naziv, "W", "Њ")
        naziv = Replace(naziv, "\", "ж")
        naziv = Replace(naziv, "|", "Ж")
        naziv = Replace(naziv, "x", "џ")
        naziv = Replace(naziv, "X", "Џ")
        naziv = Replace(naziv, "[", "ш")
        naziv = Replace(naziv, "{", "Ш")
        naziv = Replace(naziv, "]", "ђ")
        naziv = Replace(naziv, "}", "Ђ")
        'naziv = Replace(naziv, ";", "ч")
        'naziv = Replace(naziv, ":", "Ч")
        'naziv = Replace(naziv, "'", "ћ")
        naziv = Replace(naziv, "" + Chr(34) + "", "Ћ")

        naziv = Replace(naziv, "Dž", "Џ")
        naziv = Replace(naziv, "DŽ", "Џ")
        naziv = Replace(naziv, "Đ", "Ђ")
        naziv = Replace(naziv, "Ž", "Ж")
        naziv = Replace(naziv, "Ć", "Ћ")
        naziv = Replace(naziv, "Č", "Ч")
        naziv = Replace(naziv, "Š", "Ш")

        naziv = Replace(naziv, "dž", "џ")
        naziv = Replace(naziv, "đ", "ђ")
        naziv = Replace(naziv, "ž", "ж")
        naziv = Replace(naziv, "ć", "ћ")
        naziv = Replace(naziv, "č", "ч")
        naziv = Replace(naziv, "š", "ш")

        naziv = Replace(naziv, "Dj", "Ђ")
        naziv = Replace(naziv, "Zh", "Ж")
        naziv = Replace(naziv, "Lj", "Љ")
        naziv = Replace(naziv, "LJ", "Љ")
        naziv = Replace(naziv, "Nj", "Њ")
        naziv = Replace(naziv, "NJ", "Њ")
        naziv = Replace(naziv, "Th", "Ћ")
        naziv = Replace(naziv, "Ch", "Ч")
        naziv = Replace(naziv, "Dz", "Џ")
        naziv = Replace(naziv, "Sh", "Ш")

        naziv = Replace(naziv, "dj", "ђ")
        naziv = Replace(naziv, "zh", "ж")
        naziv = Replace(naziv, "lj", "љ")
        naziv = Replace(naziv, "nj", "њ")
        naziv = Replace(naziv, "th", "ћ")
        naziv = Replace(naziv, "ch", "ч")
        naziv = Replace(naziv, "dz", "џ")
        naziv = Replace(naziv, "sh", "ш")

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

        'MAK
        naziv = Replace(naziv, "ć", "ќ")
        naziv = Replace(naziv, "đ", "ѓ")

        naziv = Replace(naziv, "Ć", "Ќ")
        naziv = Replace(naziv, "Đ", "Ѓ")

        Return naziv
    End Function

    Public Shared Function konverzijaCirLat(ByVal naziv As String) As String

        naziv = Replace(naziv, "\", "ž")
        naziv = Replace(naziv, "|", "Ž")
        naziv = Replace(naziv, "[", "š")
        naziv = Replace(naziv, "{", "Š")
        naziv = Replace(naziv, "]", "đ")
        naziv = Replace(naziv, "}", "Đ")
        'naziv = Replace(naziv, ";", "č")
        'naziv = Replace(naziv, ":", "Č")
        'naziv = Replace(naziv, "'", "ć")
        naziv = Replace(naziv, "" + Chr(34) + "", "Ć")

        naziv = Replace(naziv, "Џ", "Dž")
        naziv = Replace(naziv, "Џ", "DŽ")
        naziv = Replace(naziv, "Ђ", "Đ")
        naziv = Replace(naziv, "Ж", "Ž")
        naziv = Replace(naziv, "Ћ", "Ć")
        naziv = Replace(naziv, "Ч", "Č")
        naziv = Replace(naziv, "Ш", "Š")

        naziv = Replace(naziv, "џ", "dž")
        naziv = Replace(naziv, "ђ", "đ")
        naziv = Replace(naziv, "ж", "ž")
        naziv = Replace(naziv, "ћ", "ć")
        naziv = Replace(naziv, "ч", "č")
        naziv = Replace(naziv, "ш", "š")

        naziv = Replace(naziv, "Ђ", "Dj")
        naziv = Replace(naziv, "Ж", "Zh")
        naziv = Replace(naziv, "Љ", "Lj")
        naziv = Replace(naziv, "Љ", "LJ")
        naziv = Replace(naziv, "Њ", "Nj")
        naziv = Replace(naziv, "Њ", "NJ")
        naziv = Replace(naziv, "Ћ", "Th")
        naziv = Replace(naziv, "Ч", "Ch")
        naziv = Replace(naziv, "Џ", "Dz")
        naziv = Replace(naziv, "Ш", "Sh")

        naziv = Replace(naziv, "ђ", "dj")
        naziv = Replace(naziv, "ж", "zh")
        naziv = Replace(naziv, "љ", "lj")
        naziv = Replace(naziv, "њ", "nj")
        naziv = Replace(naziv, "ћ", "th")
        naziv = Replace(naziv, "ч", "ch")
        naziv = Replace(naziv, "џ", "dz")
        naziv = Replace(naziv, "ш", "sh")

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

        'MAK
        naziv = Replace(naziv, "ќ", "ć")
        naziv = Replace(naziv, "ѓ", "đ")

        naziv = Replace(naziv, "Ќ", "Ć")
        naziv = Replace(naziv, "Ѓ", "Đ")

        'ЌЃШ
        'ќѓш
        Return naziv
    End Function
    '*******
    'bilo u popisadresar, preseljeno ovde, proveriti da se nije poremetilo, ne bi trebalo
    'da ne iscrtava panel (bilo koju kontrolu), nego prikaže "odjednom"
    Dim suspendCounter As Integer = 0
    Dim WM_SETREDRAW As Integer = 11
    Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Boolean, ByVal lParam As Int32) As Int32
    Public Sub SuspendDrawing(ByVal cntl As Control)
        If suspendCounter = 0 Then SendMessage(cntl.Handle, WM_SETREDRAW, False, 0)
        suspendCounter += 1
    End Sub
    Public Sub ResumeDrawing(ByVal cntl As Control)
        suspendCounter -= 1
        If suspendCounter = 0 Then
            SendMessage(cntl.Handle, WM_SETREDRAW, True, 0)
            cntl.Refresh()
        End If
    End Sub
    'da ne iscrtava grid, nego da prikaže "odjednom"
    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)
    End Sub

    '*******
    Public Function dajBazuServer(ByVal sifist As String, ByVal kon As String) As String
        Dim dt As New System.Data.DataTable
        Dim sql As String = " select pravaBaza,konekcija,naziv,periodika,server from vBazaServer where sifist='" + sifist + "'"
        dt = izvrsiSQLvratiDT(sql, kon, Nothing)
        dajBazuServer = dt.Rows(0).Item("pravaBaza").ToString.ToUpper.Trim + "$" + dt.Rows(0).Item("server").ToString.ToUpper.Trim
    End Function

    Public Shared Function IsBase64String(ByVal value As String) As Boolean
        If String.IsNullOrEmpty(value) Then
            Return False
        End If

        Try
            If value.ToUpper.StartsWith("0X02000") Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared ReadOnly _salt As Byte() = Encoding.ASCII.GetBytes("P0%9g256")
    Private Shared ReadOnly _sheredSecret As String = "T1@a2"

    Private Shared Function ReadByteArray(memoryStream1 As MemoryStream) As Byte()
        Throw New NotImplementedException()
    End Function

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
    Public Shared Function countString(ByVal inputString As String, ByVal stringToBeSearchedInsideTheInputString As String) As Integer
        Return System.Text.RegularExpressions.Regex.Split(inputString, stringToBeSearchedInsideTheInputString).Length - 1
    End Function

    Public Sub UpisiULogMonitoring(param1 As String, param2 As String, param3 As String, param4 As String, param5 As String, param6 As String, param7 As String, param8 As String, depoconnstring As String)
        Dim sqlLOG As String = ""
        sqlLOG = "exec InsertIntoISTMonitoringLog N'" + param1.Trim + "', N'" + param2.Trim + "', N'" + param3.Trim + "', N'" + param4.Trim + "', N'" + param5.Trim +
                 "', N'" + param6.Trim + "', N'" + param7.Trim + "', N'" + param8.Trim + "' ;"
        Call izvrsiSQL(sqlLOG, depoconnstring)
    End Sub

    Public Shared Function izvrsiSQL(ByVal sql As String, ByVal connPravaBaza As String) As String
        izvrsiSQL = "ok"
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)

        Dim sql2 As String = " SET NOCOUNT ON;SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " + nvrd +
                  " BEGIN TRAN " + nvrd + sql + nvrd +
                  " COMMIT TRAN "
        Dim webServiceUrl As String = ""
        Try
            Dim praviconnstring As String = ""
            If connPravaBaza.Trim.ToUpper.IndexOf("IDINAZMAJA;") > 0 Then
                praviconnstring = connPravaBaza.Replace("idinazmaja;", "")
                Dim ok As String = ""
                Try
                    If getOfficeFromConfig().Trim.ToUpper = "KGZ" Then
                        webServiceUrl = "http://212.42.101.101/service.asmx"
                        Dim ws As New WSISTKGZ.ServiceSoapClient("ServiceSoap2", webServiceUrl)
                        ok = ws.IzvrsiSQL(Encrypt(sql2), Encrypt(praviconnstring))
                    Else
                        webServiceUrl = "https://istcapi.stat.gov.rs/wsIST/service.asmx"
                        Dim ws As New WSIST.ServiceSoapClient("ServiceSoap", webServiceUrl)
                        ok = ws.IzvrsiSQL(Encrypt(sql2), Encrypt(praviconnstring))
                    End If
                    If ok <> "ok" Then izvrsiSQL = "nok"
                Catch ex As System.Exception
                    izvrsiSQL = "nok"
                    ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else

                praviconnstring = connPravaBaza

                Dim conn As New SqlClient.SqlConnection(praviconnstring)
                Dim cmd As SqlClient.SqlCommand = Nothing
                Try
                    conn.Open()
                    cmd = New SqlClient.SqlCommand("", conn)
                    cmd.CommandText = sql2
                    cmd.CommandTimeout = 0
                    cmd.ExecuteNonQuery()
                Catch ex As System.Exception
                    Try
                        cmd.CommandText = sql
                        cmd.ExecuteNonQuery()
                    Catch ex2 As System.Exception
                        izvrsiSQL = "nok"
                        ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Finally
                    conn.Dispose()
                    If Not cmd Is Nothing Then cmd.Dispose()
                End Try
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Public Shared Function izvrsiSQLVratiBrojSlogova(ByVal sql As String, ByVal connPravaBaza As String) As Integer
        izvrsiSQLVratiBrojSlogova = 0
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim sql2 As String = " SET NOCOUNT ON;SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " + nvrd +
                  " BEGIN TRAN " + nvrd + sql + nvrd +
                  " COMMIT TRAN "

        Dim webServiceUrl As String = "https://istcapi.stat.gov.rs/wsIST/service.asmx"
        Try
            Dim praviconnstring As String = ""
            If connPravaBaza.Trim.ToUpper.IndexOf("IDINAZMAJA;") > 0 Then
                praviconnstring = connPravaBaza.Replace("idinazmaja;", "")
                Dim ok As String = ""
                If getOfficeFromConfig().Trim.ToUpper = "KGZ" Then
                    webServiceUrl = "http://212.42.101.101/service.asmx"
                    Dim ws As New WSISTKGZ.ServiceSoapClient("ServiceSoap2", webServiceUrl)
                    izvrsiSQLVratiBrojSlogova = ws.IzvrsiSQLVratiBrojSlogova(Encrypt(sql2), Encrypt(praviconnstring))
                Else
                    webServiceUrl = "https://istcapi.stat.gov.rs/wsIST/service.asmx"
                    Dim ws As New WSIST.ServiceSoapClient("ServiceSoap", webServiceUrl)
                    izvrsiSQLVratiBrojSlogova = ws.IzvrsiSQLVratiBrojSlogova(Encrypt(sql2), Encrypt(praviconnstring))
                End If
                    Try

                Catch ex As System.Exception
                    izvrsiSQLVratiBrojSlogova = -999
                    ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                praviconnstring = connPravaBaza
                Dim cmd As SqlClient.SqlCommand = Nothing
                Dim conn As New SqlClient.SqlConnection(praviconnstring)
                Try
                    conn.Open()
                    cmd = New SqlClient.SqlCommand("", conn)
                    cmd.CommandText = sql2
                    cmd.CommandTimeout = 0
                    izvrsiSQLVratiBrojSlogova = cmd.ExecuteNonQuery()
                Catch ex As System.Exception
                    Try
                        cmd.CommandText = sql
                        izvrsiSQLVratiBrojSlogova = cmd.ExecuteNonQuery()
                    Catch ex2 As System.Exception
                        izvrsiSQLVratiBrojSlogova = -999
                        ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Finally
                    conn.Dispose()
                    If Not cmd Is Nothing Then cmd.Dispose()
                End Try
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Public Shared Function izvrsiSQLvratiDS(ByVal sql As String, ByVal connPravaBaza As String, ByVal lang As String) As DataSet
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)

        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim adp As System.Data.SqlClient.SqlDataAdapter = Nothing
        Dim ds As New System.Data.DataSet

        If sql.Trim.ToUpper.IndexOf("DECRYPTIST") >= 0 Then
            sql = zameniDecryptIST(sql)
        End If
        Dim sql2 As String = " SET NOCOUNT ON;SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " + nvrd +
               " BEGIN TRAN " + nvrd + sql + nvrd +
               " COMMIT TRAN "

        Dim webServiceUrl As String = ""
        Dim praviconnstring As String = ""
        If connPravaBaza.Trim.ToUpper.IndexOf("IDINAZMAJA;") > 0 Then
            Try
                praviconnstring = connPravaBaza.Replace("idinazmaja;", "")
                If getOfficeFromConfig().Trim.ToUpper = "KGZ" Then
                    webServiceUrl = "http://212.42.101.101/service.asmx"
                    Dim ws As New WSISTKGZ.ServiceSoapClient("ServiceSoap2", webServiceUrl)
                    ds = ws.IzvrsiSQLvratiDT(Encrypt(sql2), Encrypt(praviconnstring), Nothing)
                Else
                    webServiceUrl = "https://istcapi.stat.gov.rs/wsIST/service.asmx"
                    Dim ws As New WSIST.ServiceSoapClient("ServiceSoap", webServiceUrl)
                    ds = ws.IzvrsiSQLvratiDT(Encrypt(sql2), Encrypt(praviconnstring), Nothing)
                End If
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            If connPravaBaza.Trim.ToUpper.IndexOf("IDINAKGZ;") > 0 Then
                praviconnstring = connPravaBaza.Replace("idinaKGZ;", "")
            Else
                praviconnstring = connPravaBaza
            End If
            Dim conn As New System.Data.SqlClient.SqlConnection(praviconnstring)
            Try
                conn.Open()
                cmd.CommandTimeout = 0
                cmd.CommandText = sql2
                cmd.Connection = conn
                adp = New System.Data.SqlClient.SqlDataAdapter(cmd)
                adp.Fill(ds)
                ds.DataSetName = "OK"
            Catch ex As System.Exception
                Try
                    cmd.CommandText = sql
                    adp = New System.Data.SqlClient.SqlDataAdapter(cmd)
                    ds.Clear()
                    adp.Fill(ds)
                Catch ex2 As System.Exception
                    ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds.DataSetName = "ERROR"
                End Try
            Finally
                adp.Dispose()
                If Not cmd Is Nothing Then cmd.Dispose()
                conn.Dispose()
            End Try
        End If

        Return ds
    End Function

    Public Shared Function izvrsiSQLvratiDT(ByVal sql As String, ByVal connPravaBaza As String, ByVal lang As String, Optional ByVal dtdest As DataTable = Nothing, Optional ByVal nizKontrolaEncrypt() As String = Nothing) As DataTable
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim cmd As New SqlClient.SqlCommand
        Dim adp As SqlClient.SqlDataAdapter = Nothing
        Dim ds As New DataSet
        Dim dt As New DataTable
        If Not dtdest Is Nothing Then dt = dtdest

        If sql.Trim.ToUpper.IndexOf("DECRYPTIST") >= 0 Then
            sql = zameniDecryptIST(sql)
        End If
        Dim sql2 As String = " SET NOCOUNT ON;SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " + nvrd +
              " BEGIN TRAN " + nvrd + sql + nvrd +
              " COMMIT TRAN "
        Dim praviconnstring As String = ""
        If connPravaBaza.Trim.ToUpper.IndexOf("IDINAZMAJA;") > 0 Then
            praviconnstring = connPravaBaza.Replace("idinazmaja;", "")
            'ISTMessageBox.Show(sql)
            Dim webServiceUrl As String = ""
            Try
                If getOfficeFromConfig().Trim.ToUpper = "KGZ" Then
                    webServiceUrl = "http://212.42.101.101/service.asmx"
                    Dim ws As New WSISTKGZ.ServiceSoapClient("ServiceSoap2", webServiceUrl)
                    'ISTMessageBox.Show(sql)
                    'ISTMessageBox.Show(praviconnstring)
                    ds = ws.IzvrsiSQLvratiDT(Encrypt(sql), Encrypt(praviconnstring), Nothing)
                    dt = ds.Tables(0)
                Else
                        webServiceUrl = "https://istcapi.stat.gov.rs/wsIST/service.asmx"
                    Dim ws As New WSIST.ServiceSoapClient("ServiceSoap", webServiceUrl)
                    ds = ws.IzvrsiSQLvratiDT(Encrypt(sql2), Encrypt(praviconnstring), Nothing)
                    dt = ds.Tables(0)
                End If

            Catch ex As Exception
                ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            If connPravaBaza.Trim.ToUpper.IndexOf("IDINAKGZ;") > 0 Then
                praviconnstring = connPravaBaza.Replace("idinaKGZ;", "")
            Else
                praviconnstring = connPravaBaza
            End If
            Dim conn As New SqlClient.SqlConnection(praviconnstring)
            conn.Open()
            Try
                cmd.CommandTimeout = 0
                cmd.CommandText = sql2
                cmd.Connection = conn
                adp = New System.Data.SqlClient.SqlDataAdapter(cmd)
                adp.Fill(dt)
            Catch ex As System.Exception
                Try
                    cmd.CommandText = sql
                    adp = New System.Data.SqlClient.SqlDataAdapter(cmd)
                    dt.Clear()
                    adp.Fill(dt)
                Catch ex2 As System.Exception
                    ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Finally
                adp.Dispose()
                If Not cmd Is Nothing Then cmd.Dispose()
                conn.Dispose()
            End Try

        End If

        If Not nizKontrolaEncrypt Is Nothing AndAlso nizKontrolaEncrypt.Length > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                For j As Integer = 0 To nizKontrolaEncrypt.GetUpperBound(0)
                    If IsBase64String(dt.Rows(i).Item(nizKontrolaEncrypt(j)).ToString.Trim) = True Then
                        'Nevena 08082022
                        dt.Rows(i).Item(nizKontrolaEncrypt(j)) = DeKripto(dt.Rows(i).Item(nizKontrolaEncrypt(j)).ToString.Trim, connPravaBaza, lang)
                    End If
                Next
            Next
        End If

        Return dt
    End Function


    Function izvrsiSQLDB(ByVal sqlDB As String, ByVal DBConnectionString As String) As String
        Dim p As String = "nok"
        sqlDB = " begin transaction; " + nvrd + sqlDB + nvrd + " commit;"
        p = izvrsiSQL(sqlDB, DBConnectionString)
        'p = "ok"
        Return p
    End Function



    Public Function izvrsiSQLvratiDTJSON(ByVal sql As String, ByVal connPravaBaza As String, ByVal lang As String, Optional ByVal dtdest As DataTable = Nothing) As DataTable
        'bez poruke

        Dim dt As New DataTable
        If Not dtdest Is Nothing Then dt = dtdest
        Dim conn As New SqlClient.SqlConnection(connPravaBaza)

        Try
            Dim sql2 As String = " SET NOCOUNT ON;SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " + nvrd +
                  " BEGIN TRAN " + nvrd + sql + nvrd +
                  " COMMIT TRAN "

            dt = izvrsiSQLvratiDT(sql2, connPravaBaza, Nothing)
        Catch ex As System.Exception
            Try
                dt = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)
            Catch ex2 As System.Exception
                dt = Nothing
                Return dt
                Exit Function
            End Try
        End Try
        Return dt
    End Function

    Public Shared Function getConnectionString(ByVal DataSource As String, ByVal InitialCatalog As String,
                                        ByVal type As String, ByVal BazaConn As String,
                                        Optional connshort As String = "x") As String
        Dim s As String = BazaConn
        Dim imaUP As Boolean = False
        If s.ToLower.IndexOf("password") >= 0 OrElse s.ToLower.IndexOf("pwd") >= 0 Then imaUP = True
        getConnectionString = ""
        Dim jjj As String = ";Integrated Security=SSPI;Persist Security Info=False"
        If type = "CAPI" Then
            getConnectionString = "Data Source=(LocalDB)\mssqllocaldb;Initial Catalog=" + InitialCatalog + ";user ID=obican; Password=obican;"
        ElseIf type.IndexOf("CLOUD") = 0 Then  'CLOUD, CLOUDMIXMODE,CLOUDCATI
            'za cloud isti user i pass kao za IST bazu, ovo treba promeniti
            getConnectionString = "Data Source=" + DataSource + ";Initial Catalog=" + InitialCatalog + ";User ID=ISTdemo;Password=IST1234##;"
        ElseIf type.IndexOf("Z") = 0 OrElse type.IndexOf("ZCAPI") = 0 Then  'CLOUD, CLOUDMIXMODE,CLOUDCATI
            'za cloud isti user i pass kao za IST bazu, ovo treba promeniti
            getConnectionString = "Data Source=172.16.18.20;Initial Catalog=" + InitialCatalog + ";Persist Security Info=True;User ID=AnkIST;Password=p0l1t1ka;idinazmaja;"
            If getOfficeFromConfig().Trim.ToUpper = "KGZ" Then
                getConnectionString = "Data Source=10.1.6.20;Initial Catalog=" + InitialCatalog + ";User ID=ISTUSER;Password=1stus3r9;idinazmaja;"
            End If
        Else
            'ovde ide i "TESTCAPI"
            getConnectionString = "Data Source=" + DataSource + ";Initial Catalog=" + InitialCatalog
            If connshort = "x" AndAlso imaUP = False Then getConnectionString = getConnectionString + jjj
            If imaUP = True Then
                getConnectionString = "Data Source=" + DataSource + ";Initial Catalog=" + InitialCatalog + ";user ID=" + uuser(BazaConn) + "; Password=" + ppassword(BazaConn) + ";"
            End If
        End If
        getConnectionString = getConnectionString.Replace(";;", ";")
        'ISTMessageBox.Show(getConnectionString)
    End Function
    Public Shared Function getOfficeFromConfig() As String
        Dim nv As System.Collections.Specialized.NameValueCollection
        nv = CType(ConfigurationManager.GetSection("Istrazivanja"), System.Collections.Specialized.NameValueCollection)
        For Each k As String In nv.Keys
            Dim v As String = nv.Item(k).Trim.ToUpper
            If k.Trim.ToUpper = "OFFICE" Then
                getOfficeFromConfig = v
                Exit For
            End If
        Next
    End Function
    Public Shared Function uuser(ByVal conn As String) As String
        uuser = ""
        If conn <> "" Then
            Dim tt As String() = conn.Split(";")
            For i As Integer = 0 To tt.GetUpperBound(0)
                If tt(i).Trim.ToUpper.IndexOf("USER ID") >= 0 Then
                    uuser = Replace(tt(i).Trim, "user id=", "", 1, , CompareMethod.Text)
                    Exit For
                End If
            Next
        End If
    End Function

    Public Shared Function ppassword(ByVal conn As String) As String
        ppassword = ""
        If conn <> "" Then
            Dim tt As String() = conn.Split(";")
            For i As Integer = 0 To tt.GetUpperBound(0)
                If tt(i).Trim.ToUpper.IndexOf("PASSWORD") >= 0 Then
                    ppassword = Replace(tt(i).Trim, "password=", "", 1, , CompareMethod.Text)
                    Exit For
                End If
            Next
        End If
    End Function
    Function ISTuser(ByVal ISTconn As String) As String
        ISTuser = ""
        If ISTconn <> "" Then
            Dim tt As String() = ISTconn.Split(";")
            For i As Integer = 0 To tt.GetUpperBound(0)
                If tt(i).Trim.ToUpper.IndexOf("USER ID") >= 0 Then
                    ISTuser = Replace(tt(i).Trim, "user id=", "", 1, , CompareMethod.Text)
                    Exit For
                End If
            Next
        End If
    End Function

    Function ISTpassword(ByVal ISTconn As String) As String
        ISTpassword = ""
        If ISTconn <> "" Then
            Dim tt As String() = ISTconn.Split(";")
            For i As Integer = 0 To tt.GetUpperBound(0)
                If tt(i).Trim.ToUpper.IndexOf("PASSWORD") >= 0 Then
                    ISTpassword = Replace(tt(i).Trim, "password=", "", 1, , CompareMethod.Text)
                    Exit For
                End If
            Next
        End If
    End Function


    Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub
    Public Structure RGBColors
        Public Shared bBackColor As Color = Color.FromArgb(233, 151, 30)   'naranžasta
        Public Shared fBackColor As Color = Color.FromArgb(3, 10, 26)      'reach black
        Public Shared mBackColor As Color = Color.FromArgb(252, 251, 249)  ' skoro bela 
    End Structure
    Sub obojDG(ByVal dg As DataGrid, Optional ByVal x As Integer = 0)

        dg.Font = New System.Drawing.Font("Verdana", 8.75!)
        dg.AlternatingBackColor = RGBColors.mBackColor

        If x = 1 Then
            dg.BackColor = Color.White
        Else
            dg.BackColor = System.Drawing.Color.SeaShell
        End If

        dg.CaptionBackColor = RGBColors.mBackColor
        dg.HeaderBackColor = System.Drawing.SystemColors.ControlLight
        dg.BackgroundColor = RGBColors.mBackColor

        dg.HeaderFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dg.HeaderForeColor = System.Drawing.Color.Black

        dg.CaptionFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dg.CaptionForeColor = System.Drawing.Color.Black

        dg.BorderStyle = BorderStyle.None

        dg.ForeColor = System.Drawing.Color.Black
        dg.GridLineColor = Color.DarkGray
        dg.GridLineStyle = DataGridLineStyle.Solid


        dg.LinkColor = System.Drawing.Color.RoyalBlue
        dg.ParentRowsBackColor = System.Drawing.SystemColors.Control
        dg.ParentRowsForeColor = System.Drawing.Color.RoyalBlue

        dg.SelectionBackColor = System.Drawing.Color.SteelBlue
        dg.SelectionForeColor = System.Drawing.Color.White

        dg.PreferredRowHeight = 22
    End Sub
    Public Sub srediGridView(ByVal dgv As DataGridView, Optional AutoResizeColumns As Boolean = False, Optional iRowHeadersWidth As Integer = 100,
                      Optional iColumnHeadersHeight As Integer = 50, Optional iGridWidth As Integer = 100,
                      Optional iGridFontSize As Integer = 8, Optional iGridHeaderRowFontSize As Integer = 7, Optional iRowsHeight As Integer = 22, Optional ByVal x As Integer = 0, Optional ByVal fBorderStyle As Integer = 0)

        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)

        dgv.BackgroundColor = RGBColors.mBackColor

        dgv.AlternatingRowsDefaultCellStyle.Font = New Font("Verdana", iGridFontSize)
        dgv.DefaultCellStyle.Font = New Font("Verdana", iGridFontSize)
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", iGridHeaderRowFontSize, FontStyle.Bold)

        dgv.RowHeadersWidth = iRowHeadersWidth
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing

        dgv.RowTemplate.MinimumHeight = iRowsHeight
        dgv.EditMode = DataGridViewEditMode.EditOnKeystroke

        dgv.ColumnHeadersHeight = iColumnHeadersHeight
        'dgv.ReadOnly = True
        dgv.RowTemplate.Height = 20

        dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable

        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToOrderColumns = True
        dgv.AllowUserToResizeColumns = True
        dgv.AllowUserToResizeRows = True

        dgv.RowHeadersVisible = True
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        If fBorderStyle = 1 Then
            dgv.BorderStyle = BorderStyle.FixedSingle
        Else
            dgv.BorderStyle = BorderStyle.None
        End If

        dgv.GridColor = Color.DarkGray
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgv.ForeColor = Color.Black

        dgv.AlternatingRowsDefaultCellStyle.BackColor = RGBColors.mBackColor
        dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight

        If x = 1 Then
            dgv.RowsDefaultCellStyle.BackColor = Color.White
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Else
            dgv.RowsDefaultCellStyle.BackColor = Color.SeaShell
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        End If

        'usporava, pa je izbačeno da ne bude po default-u
        If AutoResizeColumns = True Then
            dgv.AutoResizeColumns()
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If
    End Sub

    Public Sub popuniGrid(ByVal sql As String, ByVal dgv As DataGridView, ByVal kkon As String)
        Dim dt As New System.Data.DataTable
        dt.Clear()

        dt = izvrsiSQLvratiDT(sql, kkon, Nothing)
        dgv.DataSource = dt
    End Sub

    Public Sub popuniDGridView(ByVal dgv As DataGridView, ByVal kon As String, ByVal str As String, ByVal lang As String)
        Dim rs As Long
        Try

            Dim trtDS As New DataSet
            trtDS = izvrsiSQLvratiDS(str, kon, Nothing)
            rs = trtDS.Tables(0).Rows.Count

            ''MSG 8
            Dim msgtxt1 As String = getMessageText(dtMessages, "8", lang) + nvrd
            ''MSG 9
            Dim msgtxt2 As String = getMessageText(dtMessages, "9", lang) + nvrd
            ''MSG 10
            Dim msgtxt3 As String = getMessageText(dtMessages, "10", lang) + nvrd

            dgv.DataSource = trtDS.Tables(0)
        Catch ex As System.Exception
            Dim msgtxt As String = ex.Message
            If CType(ex, SqlClient.SqlException).ErrorCode = -2147217913 Then
                'poruka = "Датум мора бити у фомату GGGGMMDD или MM.DD.GGGG или MM/DD/GGG ili MM-DD-GGGG!"
                ''MSG 11
                msgtxt = getMessageText(dtMessages, "11", lang) + nvrd
            End If
            ISTMessageBox.Show(msgtxt, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End Try

    End Sub

    Public Sub popunicbo(ByVal cbo As System.Windows.Forms.ComboBox, ByVal str As String, ByVal ConnectionString As String, Optional ByVal saPraznim As Boolean = True, Optional ByVal saAll As Boolean = False, Optional ByVal saBlankom As Boolean = False, Optional ByVal saZvezdicom As Boolean = False)

        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(str, ConnectionString, Nothing)
        Dim ds As System.Data.DataSet = New System.Data.DataSet

        ds.Tables.Add("tablename")
        ds.Tables("tablename").Columns.Add("displaymember", GetType(String))
        ds.Tables("tablename").Columns.Add("valuemember", GetType(String))

        If saPraznim = True Then
            'ubaci prazan
            Dim dr0 As System.Data.DataRow = ds.Tables("tablename").NewRow()
            dr0("displaymember") = ""
            dr0("valuemember") = ""
            ds.Tables("tablename").Rows.Add(dr0)
        End If

        If saBlankom = True Then
            'ubaci prazan
            Dim dr0 As System.Data.DataRow = ds.Tables("tablename").NewRow()
            dr0("displaymember") = " "
            dr0("valuemember") = " "
            ds.Tables("tablename").Rows.Add(dr0)
        End If

        If saZvezdicom = True Then
            'ubaci prazan
            Dim dr0 As System.Data.DataRow = ds.Tables("tablename").NewRow()
            dr0("displaymember") = "*"
            dr0("valuemember") = "*"
            ds.Tables("tablename").Rows.Add(dr0)
        End If

        If saAll = True Then
            'ubaci all
            Dim dr0 As System.Data.DataRow = ds.Tables("tablename").NewRow()
            dr0("displaymember") = "All"
            dr0("valuemember") = "All"
            ds.Tables("tablename").Rows.Add(dr0)
        End If

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim dr As System.Data.DataRow = ds.Tables("tablename").NewRow()
            dr("displaymember") = dt.Rows(i).Item("displaymember")
            dr("valuemember") = dt.Rows(i).Item("valuemember")
            ds.Tables("tablename").Rows.Add(dr)
        Next

        cbo.DisplayMember = "displaymember"
        cbo.ValueMember = "valuemember"
        cbo.DataSource = ds.Tables("tablename")
    End Sub

    Public Sub popunicboDT(ByVal cbo As System.Windows.Forms.ComboBox, ByVal dt As DataTable, Optional ByVal saPraznim As Boolean = True, Optional ByVal saAll As Boolean = False)

        Dim ds As System.Data.DataSet = New System.Data.DataSet
        ds.Tables.Add("tablename")
        ds.Tables("tablename").Columns.Add("displaymember", GetType(String))
        ds.Tables("tablename").Columns.Add("valuemember", GetType(String))

        If saPraznim = True Then
            'ubaci prazan
            Dim dr0 As System.Data.DataRow = ds.Tables("tablename").NewRow()
            dr0("displaymember") = ""
            dr0("valuemember") = ""
            ds.Tables("tablename").Rows.Add(dr0)
        End If

        If saAll = True Then
            'ubaci all
            Dim dr0 As System.Data.DataRow = ds.Tables("tablename").NewRow()
            dr0("displaymember") = "All"
            dr0("valuemember") = "All"
            ds.Tables("tablename").Rows.Add(dr0)
        End If

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim dr As System.Data.DataRow = ds.Tables("tablename").NewRow()
            dr("displaymember") = dt.Rows(i).Item("displaymember")
            dr("valuemember") = dt.Rows(i).Item("valuemember")
            ds.Tables("tablename").Rows.Add(dr)
        Next

        cbo.DisplayMember = "displaymember"
        cbo.ValueMember = "valuemember"
        cbo.DataSource = ds.Tables("tablename")
    End Sub

    Public Sub popuniclb(ByVal clb As CheckedListBox, ByVal str As String, ByVal kkon As String, ByVal lang As String)

        Dim tt As String
        Dim pp As String
        'POPUNJAVAM  clbSelectKON
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(str, kkon, lang)
        Dim dvPK As New System.Data.DataView(dt)
        dvPK.Sort = "valuemember"
        Dim dtKon As New System.Data.DataTable
        dtKon.Columns.Add("valuemember")
        dtKon.Columns.Add("displaymember")
        For i As Integer = 0 To dvPK.Count - 1
            tt = dvPK(i).Item("valuemember").trim
            pp = dvPK(i).Item("displaymember").trim
            dtKon.Rows.Add(New Object() {tt, pp})
        Next

        clb.DataSource = dtKon
        clb.DisplayMember = "displaymember"
        clb.ValueMember = "valuemember"

        Dim dv As New System.Data.DataView(dtKon)
        clb.DataSource = dv

    End Sub
    Public Sub popuniclbDT(ByVal clb As CheckedListBox, ByVal dt As DataTable)

        Dim tt As String
        Dim pp As String
        'POPUNJAVAM  clbSelectKON

        Dim dvPK As New System.Data.DataView(dt)
        dvPK.Sort = "valuemember"
        Dim dtKon As New System.Data.DataTable
        dtKon.Columns.Add("valuemember")
        dtKon.Columns.Add("displaymember")
        For i As Integer = 0 To dvPK.Count - 1
            tt = dvPK(i).Item("valuemember").trim
            pp = dvPK(i).Item("displaymember").trim
            dtKon.Rows.Add(New Object() {tt, pp})
        Next

        clb.DataSource = dtKon
        clb.DisplayMember = "displaymember"
        clb.ValueMember = "valuemember"

        Dim dv As New System.Data.DataView(dtKon)
        clb.DataSource = dv

    End Sub
    Public Sub popunilb(ByVal lb As ListBox, ByVal str As String, ByVal kkon As String, ByVal lang As String)

        Dim tt As String
        Dim pp As String
        'POPUNJAVAM  clbSelectKON
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(str, kkon, lang)
        Dim dvPK As New System.Data.DataView(dt)
        dvPK.Sort = "valuemember"
        Dim dtKon As New System.Data.DataTable
        dtKon.Columns.Add("valuemember")
        dtKon.Columns.Add("displaymember")
        For i As Integer = 0 To dvPK.Count - 1
            tt = dvPK(i).Item("valuemember").trim
            pp = dvPK(i).Item("displaymember").trim
            dtKon.Rows.Add(New Object() {tt, pp})
        Next

        lb.DataSource = dtKon
        lb.DisplayMember = "displaymember"
        lb.ValueMember = "valuemember"

    End Sub
    Public Sub popunilbDT(ByVal clb As ListBox, ByVal dt As DataTable)

        Dim tt As String
        Dim pp As String
        'POPUNJAVAM  clbSelectKON

        Dim dvPK As New System.Data.DataView(dt)
        dvPK.Sort = "valuemember"
        Dim dtKon As New System.Data.DataTable
        dtKon.Columns.Add("valuemember")
        dtKon.Columns.Add("displaymember")
        For i As Integer = 0 To dvPK.Count - 1
            tt = dvPK(i).Item("valuemember").trim
            pp = dvPK(i).Item("displaymember").trim
            dtKon.Rows.Add(New Object() {tt, pp})
        Next

        clb.DataSource = dtKon
        clb.DisplayMember = "displaymember"
        clb.ValueMember = "valuemember"

        Dim dv As New System.Data.DataView(dtKon)
        clb.DataSource = dv

    End Sub
    Public Sub popunilvDT(ByVal lv As System.Windows.Forms.ListView, ByVal dt As DataTable)

        lv.View = View.Details  ' Display the List in details  
        lv.GridLines = True   ' Set the Grid lines   

        Dim r As DataRow
        For Each r In dt.Rows
            Dim it As ListViewItem = New ListViewItem(r("valuemember").ToString())
            it.SubItems.Add(r("NAZIV").ToString())
            lv.Items.Add(it)
        Next

        lv.Columns(0).Width = 100
        lv.Columns(1).Width = 500

        Dim lstviewItemImageList As ImageList = New ImageList()
        lstviewItemImageList.ImageSize = New Size(2, 25)
        lv.SmallImageList = lstviewItemImageList

    End Sub

    Public Sub Export2Excel_DGV(ByVal lokalno As Boolean, ByVal dsE As DataSet, ByVal lang As String,
                               Optional ByVal log As Boolean = False, Optional ByVal logTxt As String = "",
                               Optional ByVal konDepo As String = "")
        Dim e As Object
        If dsE Is Nothing Then Exit Sub
        Dim DS As DataSet = dsE

        If DS.Tables.Count > 0 Then
            Try
                Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
                e = CreateObject("Excel.Application")
                Dim s, b, t As Object
                Dim ww As Object
                b = e.Workbooks.Add

                If dsE.Tables.Count > b.Worksheets.count Then
                    For i As Integer = 1 To dsE.Tables.Count - b.Worksheets.count
                        b.Worksheets.add()
                    Next
                End If

                For i As Integer = 0 To dsE.Tables.Count - 1
                    '*****
                    Dim dt As DataTable = dsE.Tables(i)

                    t = dsE.Tables(i).Columns
                    ww = b.Worksheets.Item(i + 1)
                    Dim row, col As Integer
                    col = 1
                    row = 1
                    Dim matrica(dt.Rows.Count, -1) As Object
                    For Each s In t
                        ReDim Preserve matrica(dt.Rows.Count, 1 + matrica.GetUpperBound(1))
                        matrica(0, col - 1) = DirectCast(s, DataColumn).ColumnName
                        col = col + 1
                    Next

                    ''MSG 12
                    Dim msgtxt1 As String = getMessageText(dtMessages, "12", lang) + nvrd
                    ''MSG 13
                    Dim msgtxt2 As String = getMessageText(dtMessages, "13", lang) + nvrd
                    ''MSG 14
                    Dim msgtxt3 As String = getMessageText(dtMessages, "14", lang) + nvrd
                    If col > 255 Or dt.Rows.Count > 65535 Then
                        If ISTMessageBox.Show(msgtxt1 & CStr(col) & msgtxt2 & CStr(dt.Rows.Count) & msgtxt3, "?Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
                            Exit Sub
                        End If
                    End If

                    If dt.Rows.Count > 0 Then
                        Dim tipKolone As String
                        For kolona As Integer = 0 To col - 2
                            tipKolone = dt.Rows(0).Item(matrica(0, kolona)).GetType.ToString
                            If tipKolone.Trim = "System.String" Then
                                For red As Integer = 0 To dt.Rows.Count - 1
                                    matrica(red + 1, kolona) = "'" + dt.Rows(red).Item(matrica(0, kolona).Trim.ToUpper).ToString.Trim
                                Next
                            Else
                                For red As Integer = 0 To dt.Rows.Count - 1
                                    matrica(red + 1, kolona) = dt.Rows(red).Item(matrica(0, kolona).Trim.ToUpper)
                                Next
                            End If
                        Next
                    End If

                    e.visible = True
                    ww.Range("A1").Resize(matrica.GetUpperBound(0) + 1, matrica.GetUpperBound(1) + 1).value = matrica
                    ww.Name = dsE.Tables(i).TableName
                Next
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
                If lokalno = False AndAlso log = True Then Call upisiULog(logTxt, "XLS", konDepo)
            Catch ex As Exception

                ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Public Sub Export2XML_DGV(ByVal datumVreme As String, ByVal lokalno As Boolean, ByVal dsE As DataSet, ByVal lang As String,
                               Optional ByVal log As Boolean = False, Optional ByVal logTxt As String = "",
                               Optional ByVal konDepo As String = "")
        Dim nizImenaXMLFajlova As String = ""
        Dim imeXML As String = ""
        Dim tXML As String = ""
        Dim fold As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)
        Dim nds As New DataSet
        If dsE Is Nothing Then Exit Sub
        For tab As Integer = 0 To dsE.Tables.Count - 1
            Dim nt As New DataTable
            Dim t As Object = dsE.Tables(tab).Columns

            For Each s As Object In t
                Dim kk As New DataColumn
                kk.ColumnName = DirectCast(s, DataColumn).ColumnName
                kk.DataType = dsE.Tables(tab).Columns(CStr(kk.ColumnName)).DataType
                nt.Columns.Add(kk)
            Next
            nt.TableName = dsE.Tables(tab).TableName
            nds.Tables.Add(nt)

            For i As Integer = 0 To dsE.Tables(tab).Rows.Count - 1
                Dim red() As Object = {}
                For Each c As DataColumn In nds.Tables(tab).Columns
                    ReDim Preserve red(1 + red.GetUpperBound(0))
                    red(red.GetUpperBound(0)) = dsE.Tables(tab).Rows(i).Item(c.ColumnName)
                Next
                nds.Tables(tab).Rows.Add(red)
            Next

            imeXML = nt.TableName + "_" + datumVreme + ".XML"
            tXML = fold + "\" + imeXML
            nds.Tables(tab).WriteXml(tXML)

            nizImenaXMLFajlova = nizImenaXMLFajlova + " - " + imeXML + nvrd
        Next
        If dsE.Tables.Count > 0 Then
            ''MSG 15
            Dim msgtxt1 As String = getMessageText(dtMessages, "15", lang) + nvrd
            ''MSG 16
            Dim msgtxt2 As String = getMessageText(dtMessages, "16", lang) + nvrd
            ISTMessageBox.Show(msgtxt1 + nvrd + nizImenaXMLFajlova & msgtxt2, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If lokalno = False AndAlso log = True Then Call upisiULog(logTxt, "XML", konDepo)
        End If
    End Sub

    Public Sub Export2JSON_DGV(ByVal datumVreme As String, ByVal lokalno As Boolean, ByVal dsE As DataSet, ByVal lang As String,
                               Optional ByVal log As Boolean = False, Optional ByVal logTxt As String = "",
                               Optional ByVal konDepo As String = "")
        Dim nizImenaJSONFajlova As String = ""
        Dim imeJSON As String = ""
        Dim tJSON As String = ""
        Dim fold As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)
        Dim nds As New DataSet
        If dsE Is Nothing Then Exit Sub
        For tab As Integer = 0 To dsE.Tables.Count - 1
            Dim nt As New DataTable
            Dim t As Object = dsE.Tables(tab).Columns

            For Each s As Object In t
                Dim kk As New DataColumn
                kk.ColumnName = DirectCast(s, DataColumn).ColumnName
                kk.DataType = dsE.Tables(tab).Columns(CStr(kk.ColumnName)).DataType
                nt.Columns.Add(kk)
            Next
            nt.TableName = dsE.Tables(tab).TableName
            nds.Tables.Add(nt)

            For i As Integer = 0 To dsE.Tables(tab).Rows.Count - 1
                Dim red() As Object = {}
                For Each c As DataColumn In nds.Tables(tab).Columns
                    ReDim Preserve red(1 + red.GetUpperBound(0))
                    red(red.GetUpperBound(0)) = dsE.Tables(tab).Rows(i).Item(c.ColumnName)
                Next
                nds.Tables(tab).Rows.Add(red)
            Next

            imeJSON = nt.TableName + "_" + datumVreme + ".JSON"
            tJSON = fold + "\" + imeJSON

            'ispis
            Dim sbJson As System.Text.StringBuilder = New System.Text.StringBuilder
            If dsE.Tables(tab).Rows.Count > 0 Then
                sbJson.Append("{" + nvrd + "  " + """" + nt.TableName.Trim.ToUpper + """" + ": [" + nvrd)
                For i As Integer = 0 To dsE.Tables(tab).Rows.Count - 1
                    sbJson.Append("    {" + nvrd)
                    For j As Integer = 0 To dsE.Tables(tab).Columns.Count - 1
                        If j < dsE.Tables(tab).Columns.Count - 1 Then
                            sbJson.Append("      " + """" + dsE.Tables(tab).Columns(j).ColumnName.ToString() + """: " + """" + dsE.Tables(tab).Rows(i)(j).ToString() + """," + nvrd)
                        ElseIf j = dsE.Tables(tab).Columns.Count - 1 Then
                            sbJson.Append("      " + """" + dsE.Tables(tab).Columns(j).ColumnName.ToString() + """: " + """" + dsE.Tables(tab).Rows(i)(j).ToString() + """")
                        End If
                    Next
                    If i = dsE.Tables(tab).Rows.Count - 1 Then
                        sbJson.Append(nvrd + "    }" + nvrd)
                    Else
                        sbJson.Append(nvrd + "    }," + nvrd)
                    End If
                Next
                sbJson.Append("  ]" + nvrd + "}" + nvrd)
            Else
            End If
            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(tJSON, False, System.Text.Encoding.UTF8)
                outfile.Write(sbJson.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
            nizImenaJSONFajlova = nizImenaJSONFajlova + " - " + imeJSON + nvrd
        Next
        If dsE.Tables.Count > 0 Then
            ''MSG 16
            Dim msgtxt16 As String = getMessageText(dtMessages, "16", lang) + nvrd
            ''MSG 17
            Dim msgtxt17 As String = getMessageText(dtMessages, "17", lang) + nvrd
            ISTMessageBox.Show(msgtxt17 + nvrd + nizImenaJSONFajlova.Trim + ".JSON" & msgtxt16, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If lokalno = False AndAlso log = True Then Call upisiULog(logTxt, "JSON", konDepo)
        End If
    End Sub

    Sub upisiULog(ByVal txt As String, ByVal tip As String, ByVal konDepo As String)
        Dim str As String = txt.Replace("'", "''").ToUpper
        Dim upit As String = "insert into dbo.ISTLogExcelXMLJSON (ko_insert,ExcelXMLJSON,upit,odakle) values('" +
        GetUserName.ToString.Trim + "','" + tip + "','" + str + "','NaprednaPretraga')"
        izvrsiSQL(upit, konDepo)
    End Sub

    Sub centriraj(ByVal cntl As Control)
        Dim x As Integer = Me.Left + (Me.Width - cntl.Width) / 2
        Dim y As Integer = Me.Top + (Me.Height - cntl.Height) / 2
        cntl.Location = New Point(x, y)
    End Sub

    Sub centrirajP(ByVal parent As Control, ByVal cntl As Control)
        Dim x As Integer = parent.Left + (parent.Width - cntl.Width) / 2
        Dim y As Integer = parent.Top + (parent.Height - cntl.Height) / 2
        cntl.Location = New Point(x, y)
    End Sub

    '**************
    'RAZNO ZA RAD SA FAJLOVIMA
    Declare Function GetUserName Lib "advapi32.dll" Alias _
            "GetUserNameA" (ByVal lpBuffer As String,
            ByRef nSize As Integer) As Integer

    Public Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))
    End Function

    Public Function GetUserNameIzBaze(ByVal pravabaza As String) As String
        'GetUserNameIzBaze = GetUserName()
        GetUserNameIzBaze = ""
        Dim sql As String = "select suser_sname() as ko "
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, pravabaza, Nothing)
        If dt.Rows.Count = 1 Then
            GetUserNameIzBaze = dt.Rows(0).Item("ko").ToString.Trim
        End If
    End Function

    Public Function GetUserNameCAPI(ByVal ISTConnectionString As String, ByVal capiserver As String, ByVal capibaza As String, ByVal DBconnectionstring As String, Optional txtmode As String = "CAPI") As String
        GetUserNameCAPI = ""
        Dim appRegKeyL As Microsoft.Win32.RegistryKey
        Dim keyValue = "SOFTWARE\VB and VBA Program Settings\Istrazivanja\IzabranDatum"
        appRegKeyL = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyValue, False)
        If appRegKeyL IsNot Nothing Then
            GetUserNameCAPI = appRegKeyL.GetValue("ISTUser", Nothing)
            appRegKeyL.Close()
        End If
        If GetUserNameCAPI Is Nothing OrElse GetUserNameCAPI.Trim = "" Then
            GetUserNameCAPI = GetUserName.Trim
        End If
        Return GetUserNameCAPI
    End Function

    Public Function GetTXTDir() As String
        GetTXTDir = ""
        Dim appRegKeyL As Microsoft.Win32.RegistryKey
        Dim keyValue = "SOFTWARE\VB and VBA Program Settings\Istrazivanja\IzabranDatum"
        appRegKeyL = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyValue, False)
        If appRegKeyL IsNot Nothing Then
            GetTXTDir = appRegKeyL.GetValue("ISTLocation", Nothing) + "\SQLTXT\"
            appRegKeyL.Close()
        End If

        Return GetTXTDir
    End Function

    Public Function zameniCAPIUSER(ByVal p As String, ByVal txtmode As String, Optional CAPIServer As String = "", Optional CAPIBaza As String = "") As String
        Dim pom As String = p

        If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse
           txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then   'može i testcapi
            'preuzmi god, mes, sifist i istuser iz CAPIdata
            Dim dt As New Data.DataTable
            Dim sql As String = "select top 1 * from CAPIdata"
            'mora sa "" za konekciju
            Dim konCAPI As String = getConnectionString(CAPIServer.Trim, CAPIBaza.Trim, txtmode, "")
            dt = izvrsiSQLvratiDT(sql, konCAPI, Nothing)
            Dim logovan As String = dt.Rows(0).Item("ISTUser").ToString.Trim
            pom = strrpl(p, "{CAPIUSER}", "'" + logovan + "'")
            pom = strrpl(pom, "{CAPIUSER", "'" + logovan + "'")
        ElseIf txtmode.Trim.ToUpper = "ZCAPI" OrElse txtmode.Trim.ToUpper = "Z" Then
            Dim logovan As String = GetUserNameZ()
            pom = strrpl(p, "{CAPIUSER}", "'" + logovan + "'")
            pom = strrpl(pom, "{CAPIUSER", "'" + logovan + "'")
        Else
            pom = strrpl(p, "{CAPIUSER}", "''")
            pom = strrpl(pom, "{CAPIUSER", "''")
        End If

        zameniCAPIUSER = pom

    End Function

    Public Function GetUserNameZ() As String
        GetUserNameZ = ""
        Dim appRegKeyL As Microsoft.Win32.RegistryKey
        Dim keyValue = "SOFTWARE\VB and VBA Program Settings\Istrazivanja\IzabranDatum"
        appRegKeyL = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyValue, False)
        If appRegKeyL IsNot Nothing Then
            GetUserNameZ = appRegKeyL.GetValue("ISTUser", Nothing)
            appRegKeyL.Close()
        End If

        If GetUserNameZ Is Nothing OrElse GetUserNameZ.Trim = "" Then
            GetUserNameZ = GetUserName.Trim
        End If
        Return GetUserNameZ
    End Function


    Public Function GetDateTimeIzBaze(ByVal pravabaza As String) As String
        'GetUserNameIzBaze = GetUserName()
        GetDateTimeIzBaze = ""
        Dim sql As String = "select getdate() as dt "
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, pravabaza, Nothing)
        If dt.Rows.Count = 1 Then
            GetDateTimeIzBaze = CDate(dt.Rows(0).Item("dt")).ToString("yyyy-MM-dd HH:mm:ss")
        End If
        'N2 = Format(CDate(c.Text), "dd.MM.yyyy")
    End Function

    Public Function GetUserNameWitnDomain() As String
        GetUserNameWitnDomain = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
    End Function

    Public Function GetHostName() As String
        Dim strHostName As String = System.Net.Dns.GetHostName()
        GetHostName = strHostName.Trim.ToUpper
    End Function

    Public Function isDataReaderOnly(ByVal pravabaza As String) As Boolean
        isDataReaderOnly = False
        Dim koWin As String = GetUserName.ToString.Trim
        Dim sql As String = "select  P.Name " +
        "From sys.database_principals P Inner Join " +
        "sys.database_role_members M on P.Principal_ID = M.member_principal_ID Inner Join " +
        "sys.database_principals R on R.Principal_ID = M.role_principal_ID " +
        "Where P.Name ='" + koWin + "' and r.name='db_datareader' " +
        "And Not exists( " +
        "select P.Name " +
        "From sys.database_principals P Inner Join " +
        "sys.database_role_members M on P.Principal_ID = M.member_principal_ID Inner Join " +
        "sys.database_principals R on R.Principal_ID = M.role_principal_ID " +
        "Where P.Name ='" + koWin + "' and r.name<>'db_datareader') "

        Dim dt As DataTable = izvrsiSQLvratiDT(sql, pravabaza, Nothing)
        If dt.Rows.Count = 1 Then
            isDataReaderOnly = True
        End If
    End Function

    Public Function GetIPAddress() As String
        Dim GetIPv4Address As String = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = ipheal.ToString()
            End If
        Next
        GetIPAddress = GetIPv4Address
    End Function

    Public Function SaveTextToFile(ByVal strData As String, ByVal FullPath As String, Optional ByVal ErrInfo As String = "") As Boolean
        Dim bAns As Boolean = False
        Dim objReader As System.IO.StreamWriter
        Try
            objReader = New System.IO.StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As System.Exception
            ErrInfo = Ex.Message
        End Try
        Return bAns
    End Function

    Public Function GetFileContents(ByVal FullPath As String, Optional ByRef ErrInfo As String = "") As String
        GetFileContents = ""
        Dim strContents As String
        Dim objReader As System.IO.StreamReader
        Try
            objReader = New System.IO.StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As System.Exception
            ErrInfo = Ex.Message
        End Try
    End Function
    Public Function GetFileName(ByVal path As String) As String
        Dim _filename As String = System.IO.Path.GetFileName(path)
        Return _filename
    End Function
    Public Sub DoRefresh(ByVal con As String)
    End Sub

    Public Sub End_Excel_App(datestart As Date, dateEnd As Date)
        Dim xlp() As Process = Process.GetProcessesByName("EXCEL")
        For Each Process As Process In xlp
            If Process.StartTime >= datestart And Process.StartTime <= dateEnd Then
                Process.Kill()
                Exit For
            End If
        Next
    End Sub
    Public Sub End_OO_App(datestart As Date, dateEnd As Date)
        Dim xlp() As Process = Process.GetProcessesByName("SOFFICE.BIN")
        For Each Process As Process In xlp
            If Process.StartTime >= datestart And Process.StartTime <= dateEnd Then
                Process.Kill()
                Exit For
            End If
        Next
        Dim xlp2() As Process = Process.GetProcessesByName("SOFFICE")
        For Each Process As Process In xlp2
            If Process.StartTime >= datestart And Process.StartTime <= dateEnd Then
                Process.Kill()
                Exit For
            End If
        Next
    End Sub
    Public Sub End_Word_App(datestart As Date, dateEnd As Date)
        Dim xlp() As Process = Process.GetProcessesByName("WORD")
        For Each Process As Process In xlp
            If Process.StartTime >= datestart And Process.StartTime <= dateEnd Then
                Process.Kill()
                Exit For
            End If
        Next
    End Sub
    Public Sub End_App(ByVal WHAT As String, Optional ByVal datestart As Date = Nothing, Optional ByVal dateEnd As Date = Nothing, Optional ByVal msgg As Boolean = True)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim xlp() As Process = Process.GetProcessesByName(WHAT)
        If Not datestart = Nothing AndAlso Not dateEnd = Nothing Then
            For Each Process As Process In xlp
                If Process.StartTime >= datestart And Process.StartTime <= dateEnd Then
                    Process.Kill()
                    'Exit For
                End If
            Next
        Else
            For Each Process As Process In xlp
                Process.Kill()
            Next
        End If
        If msgg = True Then ISTMessageBox.Show("ALL " + WHAT + " processes are killed!")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub DeleteFilesFromFolders(ByVal sourcePath As String, ByVal lang As String)
        Dim nvrd As String = ChrW(13) + ChrW(10)
        Try
            If (System.IO.Directory.Exists(sourcePath)) Then
                Dim dirs0 As String() = System.IO.Directory.GetDirectories(sourcePath)
                Dim files As String() = System.IO.Directory.GetFiles(sourcePath)
                For Each file As String In files
                    System.IO.File.SetAttributes(file, System.IO.FileAttributes.Normal)
                    Kill(file)
                    System.IO.File.Delete(file)
                Next
                For Each dir As String In dirs0
                    Dim files0 As String() = System.IO.Directory.GetFiles(dir)
                    For Each file As String In files0
                        System.IO.File.SetAttributes(file, System.IO.FileAttributes.Normal)
                        Kill(file)
                        System.IO.File.Delete(file)
                    Next
                    Dim dirs1 As String() = System.IO.Directory.GetDirectories(dir)
                    For Each dir1 As String In dirs1
                        Dim files1 As String() = System.IO.Directory.GetFiles(dir1)
                        For Each file As String In files1
                            System.IO.File.SetAttributes(file, System.IO.FileAttributes.Normal)
                            Kill(file)
                            System.IO.File.Delete(file)
                        Next
                        System.IO.Directory.Delete(dir1, True)
                    Next
                    System.IO.Directory.Delete(dir, True)
                Next
                System.IO.Directory.Delete(sourcePath, True)
            End If
        Catch ex As System.Exception
            ''MSG 18
            Dim msgtxt18 As String = getMessageText(dtMessages, "18", lang) + nvrd
            Dim por As String = msgtxt18 + sourcePath + nvrd
            ISTMessageBox.Show(por + ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
        End Try
    End Sub

    Public Sub DeleteTxtFilesFromFolders(ByVal sourcePath As String)
        If (System.IO.Directory.Exists(sourcePath)) Then
            For Each fName As String In System.IO.Directory.GetFiles(sourcePath)
                If System.IO.File.Exists(fName) AndAlso fName.Substring(fName.Length - 4) = ".txt" Then
                    System.IO.File.Delete(fName)
                End If
            Next
        End If
    End Sub

    Public Sub CopyFiles(ByVal sourcePath As String, ByVal DestinationPath As String)
        If (System.IO.Directory.Exists(sourcePath)) Then
            For Each fName As String In System.IO.Directory.GetFiles(sourcePath)
                If System.IO.File.Exists(fName) Then
                    Dim dFile As String = String.Empty
                    dFile = System.IO.Path.GetFileName(fName)
                    Dim dFilePath As String = String.Empty
                    dFilePath = DestinationPath + dFile
                    System.IO.File.Copy(fName, dFilePath, True)
                End If
            Next
        End If
    End Sub

    Public Sub CopyDirectory(ByVal SourcePath As String, ByVal DestPath As String, Optional ByVal Overwrite As Boolean = False)
        Dim SourceDir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(SourcePath)
        Dim DestDir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(DestPath)
        If SourceDir.Exists Then
            If Not DestDir.Parent.Exists Then
                Throw New System.IO.DirectoryNotFoundException("Destination directory does Not exist: " + DestDir.Parent.FullName)
            End If
            If Not DestDir.Exists Then
                DestDir.Create()
            End If
            ' copy all the files of the current directory
            Dim ChildFile As System.IO.FileInfo
            For Each ChildFile In SourceDir.GetFiles()
                If Overwrite Then
                    ChildFile.CopyTo(System.IO.Path.Combine(DestDir.FullName, ChildFile.Name), True)
                Else
                    If Not System.IO.File.Exists(System.IO.Path.Combine(DestDir.FullName, ChildFile.Name)) Then
                        ChildFile.CopyTo(System.IO.Path.Combine(DestDir.FullName, ChildFile.Name), True)
                    End If
                End If
            Next
            Dim SubDir As System.IO.DirectoryInfo
            For Each SubDir In SourceDir.GetDirectories()
                CopyDirectory(SubDir.FullName, System.IO.Path.Combine(DestDir.FullName, SubDir.Name), Overwrite)
            Next
        Else
            Throw New System.IO.DirectoryNotFoundException("Source directory does not exist: " + SourceDir.FullName)
        End If
    End Sub

    Public Function SamoInteger(ByVal znak As Char) As String
        If znak >= "0" And znak <= "9" Or znak = Chr(13) Or znak = Chr(8) Then
            SamoInteger = znak
        Else
            SamoInteger = ""
        End If
    End Function

    Public Function SamoDecimal(ByVal znak As Char) As String
        If znak >= "0" And znak <= "9" Or znak = Chr(13) Or znak = "." Or znak = Chr(8) Then
            SamoDecimal = znak
        Else
            SamoDecimal = ""
        End If
    End Function

    Public Shared Function ustringaj(ByVal n As String(), Optional ByVal poc As Integer = 0, Optional ByVal kraj As Integer = -9) As String
        Dim trt As String = ""
        If kraj = -9 Then kraj = n.GetUpperBound(0)
        For i As Integer = poc To kraj
            trt = trt + " " & n(i)
        Next
        trt = trt.Replace(" ' ", "'").Replace("[ , ]", ",").Replace("[ ( ]", "(").Replace("[ ) ]", ")").Replace("[ + ]", "+").Replace("[ - ]", "-").Replace("[ * ]", "*").Replace("[ / ]", "/").Replace("[ > ]", ">").Replace("[ < ]", "<").Replace("[ = ]", "=").Replace("[ <= ]", "<=").Replace("[ >= ]", ">=").Replace("[ <> ]", "<>").Replace("[ . ]", ".").Replace("% ", "%").Replace(" %", "%")
        Return trt
    End Function

    Public Shared Function razkvantaj(ByVal s As String, Optional notUpper As Boolean = False) As String()
        Dim trt(0) As String
        If notUpper = False Then s = s.Trim.ToUpper
        trt(0) = Mid(s, 1, 1)
        Dim ZTip As znak = TipZnaka(trt(0))
        For i As Integer = 2 To s.Length
            Dim p As String = Mid(s, i, 1)
            If TipZnaka(p) = znak.blanko Then
                ZTip = znak.blanko
            Else
                If ZTip <> znak.zagrada AndAlso TipZnaka(p) = ZTip Then
                    trt(trt.GetUpperBound(0)) = trt(trt.GetUpperBound(0)) + p
                Else
                    ReDim Preserve trt(1 + trt.GetUpperBound(0))
                    trt(trt.GetUpperBound(0)) = p
                    ZTip = TipZnaka(p)
                End If
                If TipZnaka(p) = znak.zagrada Then ZTip = znak.blanko
            End If
        Next
        Return trt
    End Function

    Public Function ZameniGGGMMM(ByVal str As String, ByVal god As String, ByVal mes As Integer, ByVal vtwhere As String,
                                 ByVal GWhere As String, ByVal mWhere As String, ByVal YWhere As String,
                                 ByVal Optional sifist As String = "", Optional goredole As Integer = 0) As String
        '     sql = ZameniGGGMMM(sql, Me.mvt.G.ToString, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
        Dim sql As String = ""
        'zamena GGG,MMM
        sql = str

        sql = strrpl(sql, "{SIFIST}", "'" + sifist + "'")
        sql = strrpl(sql, "{APPCODE}", "'" + sifist + "'")

        sql = sql.Replace("DDMMGGGG", "99qwerty99")
        sql = sql.Replace("DDMMYYYY", "99qwertyE99")

        sql = strrpl(sql, "{GGG}", "'" + god + "'")
        sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", mes) + "'")
        sql = strrpl(sql, "{YYY}", "'" + god + "'")

        If goredole = 0 Then
            sql = GGMMGoreDole(sql, god, mes)
        End If

        sql = strrpl(sql, "VRTACKA", vtwhere)
        If sql.Trim.ToUpper.IndexOf("{GGG") < 0 AndAlso sql.Trim.ToUpper.IndexOf("GGG") >= 0 Then sql = strrpl(sql, "GGG", GWhere)
        If sql.Trim.ToUpper.IndexOf("{MMM") < 0 AndAlso sql.Trim.ToUpper.IndexOf("MMM") >= 0 Then sql = strrpl(sql, "MMM", mWhere)
        If sql.Trim.ToUpper.IndexOf("{YYY") < 0 AndAlso sql.Trim.ToUpper.IndexOf("YYY") >= 0 Then sql = strrpl(sql, "YYY", YWhere)

        sql = strrpl(sql, "{GGG", "'" + god + "'")
        sql = strrpl(sql, "{MMM", "'" + String.Format("{0:d2}", mes) + "'")
        sql = strrpl(sql, "{YYY", "'" + god + "'")

        sql = sql.Replace(ChrW(26), "")
        sql = sql.Replace("99qwerty99", "DDMMGGGG")
        sql = sql.Replace("99qwertyE99", "DDMMYYYY")

        str = sql

        Return str
    End Function

    Public Function ZameniGGGMMMBezApostrofa(ByVal str As String, ByVal god As String, ByVal mes As Integer, ByVal vtwhere As String,
                                 ByVal GWhere As String, ByVal mWhere As String, ByVal YWhere As String,
                                 ByVal Optional sifist As String = "", Optional goredole As Integer = 0) As String
        '     sql = ZameniGGGMMM(sql, Me.mvt.G.ToString, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
        Dim sql As String = ""
        'zamena GGG,MMM
        sql = str

        sql = Replace(sql, "{sifist", "{SIFIST", 1, , CompareMethod.Text)
        sql = Replace(sql, "{appcode", "{APPCODE", 1, , CompareMethod.Text)
        sql = Replace(sql, "{ggg", "{GGG", 1, , CompareMethod.Text)
        sql = Replace(sql, "{mmm", "{MMM", 1, , CompareMethod.Text)
        sql = Replace(sql, "{yyy", "{YYY", 1, , CompareMethod.Text)

        sql = strrpl(sql, "{SIFIST}", sifist)
        sql = strrpl(sql, "{APPCODE}", sifist)

        sql = sql.Replace("DDMMGGGG", "99qwerty99")
        sql = sql.Replace("DDMMYYYY", "99qwertyE99")

        sql = strrpl(sql, "{GGG}", god)
        sql = strrpl(sql, "{MMM}", String.Format("{0:d2}", mes))
        sql = strrpl(sql, "{YYY}", god)

        If goredole = 0 Then
            sql = GGMMGoreDole(sql, god, mes, True)
        End If

        sql = strrpl(sql, "VRTACKA", vtwhere)
        If sql.Trim.ToUpper.IndexOf("{GGG") < 0 AndAlso sql.Trim.ToUpper.IndexOf("GGG") >= 0 Then sql = strrpl(sql, "GGG", GWhere)
        If sql.Trim.ToUpper.IndexOf("{MMM") < 0 AndAlso sql.Trim.ToUpper.IndexOf("MMM") >= 0 Then sql = strrpl(sql, "MMM", mWhere)
        If sql.Trim.ToUpper.IndexOf("{YYY") < 0 AndAlso sql.Trim.ToUpper.IndexOf("YYY") >= 0 Then sql = strrpl(sql, "YYY", YWhere)

        sql = strrpl(sql, "{GGG", god)
        sql = strrpl(sql, "{MMM", String.Format("{0:d2}", mes))
        sql = strrpl(sql, "{YYY", god)

        sql = sql.Replace(ChrW(26), "")
        sql = sql.Replace("99qwerty99", "DDMMGGGG")
        sql = sql.Replace("99qwertyE99", "DDMMYYYY")

        str = sql

        Return str
    End Function

    Public Function ZameniGGGMMMSimple(ByVal str As String, ByVal god As String, ByVal mes As Integer, ByVal vtwhere As String,
                                 ByVal GWhere As String, ByVal mWhere As String, ByVal YWhere As String) As String
        Dim sql As String = ""
        'zamena GGG,MMM
        sql = str
        sql = strrpl(sql, "{GGG}", "'" + god + "'")
        sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", mes) + "'")
        sql = strrpl(sql, "{YYY}", "'" + god + "'")

        sql = GGMMGoreDole(sql, god, mes)

        sql = strrpl(sql, "VRTACKA", vtwhere)
        If sql.Trim.ToUpper.IndexOf("{GGG") < 0 AndAlso sql.Trim.ToUpper.IndexOf("GGG") >= 0 Then sql = strrpl(sql, "GGG", GWhere)
        If sql.Trim.ToUpper.IndexOf("{MMM") < 0 AndAlso sql.Trim.ToUpper.IndexOf("MMM") >= 0 Then sql = strrpl(sql, "MMM", mWhere)
        If sql.Trim.ToUpper.IndexOf("{YYY") < 0 AndAlso sql.Trim.ToUpper.IndexOf("YYY") >= 0 Then sql = strrpl(sql, "YYY", YWhere)

        sql = strrpl(sql, "{GGG", "'" + god + "'")
        sql = strrpl(sql, "{MMM", "'" + String.Format("{0:d2}", mes) + "'")
        sql = strrpl(sql, "{YYY", "'" + god + "'")

        sql = sql.Replace(Microsoft.VisualBasic.Strings.ChrW(26), "")
        str = sql
        Return str
    End Function

    Public Function strrpl(ByVal q As String, ByVal r As String, ByVal p As String) As String
        Dim i As Integer
        Do
            i = q.ToUpper.IndexOf(r.ToUpper)
            If i >= 0 Then
                q = q.Substring(0, i) + p + q.Substring(i + r.Length)
                i += p.Length
            End If
        Loop While i >= 0 And i < q.Length
        Return q
    End Function

    Public Function GGMMGoreDole(ByVal s As String, ByVal god As String, ByVal mes As String, Optional bezapostrofa As Boolean = False) As String
        Dim izlaz As String = s
        Dim q As Integer
        Do
            q = izlaz.ToUpper.IndexOf("{GGG")
            If q < 0 Then q = izlaz.ToUpper.IndexOf("{YYY")
            If q >= 0 Then
                Dim i As Integer = q
                While izlaz.Substring(i, 1) <> "}"
                    i += 1
                End While
                Dim s1 As String = izlaz.Substring(q + 1, i - q - 1)
                Dim broj As Integer = CInt(s1.Substring(4)) : Dim znak As String = s1.Substring(3, 1)
                Dim r As String
                If znak = "-" Then
                    r = CStr(CInt(god) - broj)
                Else
                    r = CStr(CInt(god) + broj)
                End If
                If bezapostrofa = False Then
                    izlaz = strrpl(izlaz, "{" + s1 + "}", "'" + r + "'")
                Else
                    izlaz = strrpl(izlaz, "{" + s1 + "}", r)
                End If

            End If
        Loop While q >= 0 And q < izlaz.Length
        Do 'MMM
            q = izlaz.ToUpper.IndexOf("{MMM")

            If q >= 0 Then
                Dim i As Integer = q
                While izlaz.Substring(i, 1) <> "}"
                    i += 1
                End While
                Dim s1 As String = izlaz.Substring(q + 1, i - q - 1)
                Dim broj As Integer = CInt(s1.Substring(4))
                Dim znak As String = s1.Substring(3, 1)
                Dim r As String
                If znak = "-" Then
                    r = CStr(MinusMMM(CInt(mes) - broj))
                Else : r = CStr(MinusMMM(CInt(mes) + broj)) ' "+"
                End If
                If bezapostrofa = False Then
                    izlaz = strrpl(izlaz, "{" + s1 + "}", "'" + r.PadLeft(2, System.Convert.ToChar("0")) + "'")
                Else
                    izlaz = strrpl(izlaz, "{" + s1 + "}", r.PadLeft(2, System.Convert.ToChar("0")))
                End If

            End If
        Loop While q >= 0 And q < izlaz.Length
        Do 'GGM
            q = izlaz.ToUpper.IndexOf("{GGM")
            If q < 0 Then q = izlaz.ToUpper.IndexOf("{YYM")
            If q >= 0 Then
                Dim i As Integer = q
                While izlaz.Substring(i, 1) <> "}"
                    i += 1
                End While
                Dim s1 As String = izlaz.Substring(q + 1, i - q - 1)
                Dim broj As Integer = CInt(s1.Substring(4))
                Dim znak As String = s1.Substring(3, 1)
                Dim r As String
                If znak = "-" Then
                    If broj >= CInt(mes) Then r = CStr(CInt(god) - 1 + CInt((broj - CInt(mes)) / 12)) Else r = god
                Else ' "+"
                    If broj + CInt(mes) > 12 Then r = CStr(CInt(broj + CInt(mes)) / 12) Else r = god
                End If
                If bezapostrofa = False Then
                    izlaz = strrpl(izlaz, "{" + s1 + "}", "'" + r + "'")
                Else
                    izlaz = strrpl(izlaz, "{" + s1 + "}", r)
                End If

            End If
        Loop While q >= 0 And q < izlaz.Length
        Return izlaz
    End Function

    Public Function MinusMMM(ByVal m1 As Integer) As Integer
        Dim x As Integer = m1 Mod 12
        If x > 0 Then
            Return x
        Else
            Return x + 12
        End If
    End Function

    Enum znak
        slovo
        zagrada
        operator1
        blanko
    End Enum

    Public Shared Function TipZnaka(ByVal s As String) As znak
        Dim c As Char = CChar(Mid(s, 1, 1))
        If ILOD(c) Then Return znak.slovo
        If c = "_"c Or c = "." Or c = "["c Or c = "]"c Or c = "'"c Then Return znak.slovo
        If c = "("c Or c = ")"c Then Return znak.zagrada
        If c = " " Then Return znak.blanko
        If c = "+"c Or c = "-"c Or c = "*"c Or c = "/" Or c = "="c Or c = ">"c Or c = "<"c Or c = "," Then Return znak.operator1
        Return Nothing 'ili return znak.slovo?
    End Function

    Public Shared Function ILOD(ByVal cchh As Char) As Boolean
        Select Case Asc(cchh)
            Case 48 To 57, 65 To 90, 97 To 122
                ILOD = True
            Case Else
                ILOD = False
        End Select
    End Function

    Public Function zameniRPIZRAZ(ByVal rpIzraz As String) As String

        zameniRPIZRAZ = ""

        'If rpIzraz.IndexOf("BUTTON") >= 0 Then
        '    rpIzraz = Replace(rpIzraz, "button", "", 1, , CompareMethod.Text)
        'End If

        rpIzraz = SrediIzrazZaFP(rpIzraz)

        If rpIzraz.Trim.ToUpper.IndexOf("'SYSTEM.INT32'") >= 0 Then
            rpIzraz = Replace(rpIzraz, "convert", "cast", 1, , CompareMethod.Text)
            rpIzraz = Replace(rpIzraz, ",'system.int32'", " as integer", 1, , CompareMethod.Text)
            rpIzraz = Replace(rpIzraz, ", 'system.int32'", " as integer", 1, , CompareMethod.Text)
            rpIzraz = Replace(rpIzraz, ",'system.int32' ", " as integer", 1, , CompareMethod.Text)
            rpIzraz = Replace(rpIzraz, ", 'system.int32' ", " as integer", 1, , CompareMethod.Text)
        End If

        zameniRPIZRAZ = rpIzraz.Trim

    End Function
    Function SrediIzrazZaFP(ByVal izr As String) As String

        SrediIzrazZaFP = ""

        If Not izr Is Nothing AndAlso izr <> "" Then
            Dim naslovForeColorOpis As String = ""
            Dim naslovBackColorOpis As String = ""
            Dim kakoL() As String = izr.Split("$")
            If kakoL.Length > 0 Then
                For iii As Integer = 0 To kakoL.Length - 1
                    kakoL(iii) = kakoL(iii).Trim.ToUpper
                    If kakoL(iii).IndexOf("FORECOLOR") >= 0 Then
                        kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("FORECOLOR", "")
                        naslovForeColorOpis = kakoL(iii)
                    ElseIf kakoL(iii).IndexOf("BACKCOLOR") >= 0 Then
                        kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("BACKCOLOR", "")
                        naslovBackColorOpis = kakoL(iii)
                    End If
                Next
            End If
            izr = Replace(izr, naslovForeColorOpis.ToLower, "", 1, , CompareMethod.Text)
            izr = Replace(izr, naslovBackColorOpis.ToLower, "", 1, , CompareMethod.Text)

            If izr.Trim.ToUpper.IndexOf("MULTILINEHEIGHT") >= 0 Then
                Dim uu() As String = izr.Split(CType("$", Char()))
                izr = ""
                For u As Integer = 0 To uu.GetUpperBound(0)
                    If uu(u).Trim.ToUpper.IndexOf("MULTILINEHEIGHT") < 0 AndAlso uu(u) <> "" Then
                        izr = izr + uu(u) + "$"
                    End If
                Next
                izr = izr + "$"
                izr = izr.Replace("$$", "$")
            End If

            If izr.Trim.ToUpper.IndexOf("FONTSIZE") >= 0 AndAlso izr.Substring(izr.Trim.ToUpper.IndexOf("FONTSIZE")).Trim.ToUpper.IndexOf("$") > 0 Then
                izr = izr.Replace(Mid(izr.Substring(izr.Trim.ToUpper.IndexOf("FONTSIZE")).Trim.ToUpper, 1 + 8, InStr(izr.Substring(izr.Trim.ToUpper.IndexOf("FONTSIZE") + 8).Trim.ToUpper, "$")), "")
                izr = Replace(izr, "fontsize", "", 1, , CompareMethod.Text)
            End If
            If izr.Trim.ToUpper.IndexOf("LHEIGHT") >= 0 AndAlso izr.Substring(izr.Trim.ToUpper.IndexOf("LHEIGHT")).Trim.ToUpper.IndexOf("$") > 0 Then
                izr = izr.Replace(Mid(izr.Substring(izr.Trim.ToUpper.IndexOf("LHEIGHT")).Trim.ToUpper, 1 + 7, InStr(izr.Substring(izr.Trim.ToUpper.IndexOf("LHEIGHT") + 7).Trim.ToUpper, "$")), "")
                izr = Replace(izr, "lheight", "", 1, , CompareMethod.Text)
            End If
            If izr.Trim.ToUpper.IndexOf("LVISINA") >= 0 AndAlso izr.Substring(izr.Trim.ToUpper.IndexOf("LVISINA")).Trim.ToUpper.IndexOf("$") > 0 Then
                izr = izr.Replace(Mid(izr.Substring(izr.Trim.ToUpper.IndexOf("LVISINA")).Trim.ToUpper, 1 + 7, InStr(izr.Substring(izr.Trim.ToUpper.IndexOf("LVISINA") + 7).Trim.ToUpper, "$")), "")
                izr = Replace(izr, "lvisina", "", 1, , CompareMethod.Text)
            End If
            izr = Replace(izr, "fontbold", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "pdesnop", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "frighta", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "fontitalic", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "borderfixed", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "remark", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "bordernone", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "multiline", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "ldesnop", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "lcentarp", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "lrighta", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "lcentera", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "forecolor", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "backcolor", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "visiblefalse", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "visibletrue", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "enabledfalse", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "enabledtrue", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "datavalidationfor", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "readonly", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "encrypt", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "fontunderline", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "remark", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "pcentarp", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "fcentera", "", 1, , CompareMethod.Text)
            izr = Replace(izr, "$$", "$", 1, , CompareMethod.Text)
            izr = Replace(izr, "$", "", 1, , CompareMethod.Text)

            If Not izr Is Nothing AndAlso izr <> "" AndAlso izr.Trim.ToUpper.IndexOf(Chr(34)) = 0 Then izr = "''"
            If Not izr Is Nothing AndAlso izr <> "" Then SrediIzrazZaFP = izr.Trim Else SrediIzrazZaFP = ""
        Else
            SrediIzrazZaFP = ""
        End If

    End Function

    Function sredjenOpis(ByVal opisG As String) As String

        sredjenOpis = ""

        If Not opisG Is Nothing AndAlso opisG <> "" Then
            Dim naslovVisina As Integer = 1
            Dim naslovFontSize As Integer = 0
            Dim naslovForeColor As String = ""
            Dim naslovBackColor As String = ""
            opisG = opisG.TrimEnd(";").TrimEnd("$")
            If opisG <> "" Then
                Dim kakoL() As String = opisG.Split("$")
                If kakoL.Length > 0 Then
                    For iii As Integer = 0 To kakoL.Length - 1
                        kakoL(iii) = kakoL(iii).Trim.ToUpper
                        If kakoL(iii).IndexOf("FONTSIZE") >= 0 Then
                            kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("FONTSIZE", "")
                            If IsNumeric(kakoL(iii)) = True Then naslovFontSize = CInt(kakoL(iii))
                        ElseIf kakoL(iii).IndexOf("LHEIGHT") >= 0 OrElse kakoL(iii).IndexOf("LVISINA") >= 0 Then
                            kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("LHEIGHT", "")
                            kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("LVISINA", "")
                            If IsNumeric(kakoL(iii)) = True Then naslovVisina = CInt(kakoL(iii))
                        ElseIf kakoL(iii).IndexOf("FORECOLOR") >= 0 Then
                            kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("FORECOLOR", "")
                            naslovForeColor = kakoL(iii)
                        ElseIf kakoL(iii).IndexOf("BACKCOLOR") >= 0 Then
                            kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("BACKCOLOR", "")
                            naslovBackColor = kakoL(iii)
                        End If
                    Next
                End If

                opisG = Replace(opisG, "fontbold", "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "fontitalic", "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "fontunderline", "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "ldesnop", "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "lcentarp", "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "lrighta", "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "lcentera", "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "lcentrea", "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "forecolor" + naslovForeColor.ToLower, "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "backcolor" + naslovBackColor.ToLower, "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "fontsize" + CStr(naslovFontSize).Trim, "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "lheight" + CStr(naslovVisina).Trim, "", 1, , CompareMethod.Text)
                opisG = Replace(opisG, "lvisina" + CStr(naslovVisina).Trim, "", 1, , CompareMethod.Text)
                'opisG = opisG.Replace("$", "").Trim
                'opisG = opisG.Replace("<br>", "").Trim
                opisG = Replace(opisG, "<br>", "", 1, , CompareMethod.Text).Replace("$", "")
            End If

            If Not opisG Is Nothing AndAlso opisG <> "" Then sredjenOpis = opisG.Trim Else sredjenOpis = ""
        Else
            sredjenOpis = ""
        End If

    End Function
    Public Function prfxt(ByVal tn As String) As String
        Dim pp() As String
        Dim prefixx As String = "dbo"
        Dim tabbb As String = tn
        If tn.IndexOf(".") > 0 Then
            pp = tn.Split(CType(".", Char()))
            prefixx = pp(0)
            tabbb = pp(1)
        End If
        Return prefixx + "." + tabbb
    End Function
    Public Function customDialogResult(ByVal options As IEnumerable(Of String),
                                       ByVal message As String, ByVal title As String, Optional ccn As Integer = 1) As String
        Dim result As String = "Cancel"
        Dim myForm As New Form With {.Text = title}

        myForm.Height = 250
        myForm.Width = myForm.Height * 1.618   'zlatni

        Dim l As New System.Windows.Forms.Label With {.Text = message}
        l.Font = New Font(Me.Font.Name, Me.Font.Size, FontStyle.Bold)
        l.Location = New Point(myForm.Height \ 6, myForm.Height \ 6) '***
        l.Anchor = AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        myForm.Controls.Add(l)

        Dim xx As Integer = -10
        Dim nn As Integer = 0
        Dim uk As Integer = 0
        For Each o As String In options
            uk = uk + 1
        Next
        For Each o As String In options
            nn = nn + 1
            Dim b As New System.Windows.Forms.Button With {.Text = o}
            b.FlatStyle = FlatStyle.Flat
            myForm.Controls.Add(b)
            AddHandler b.Click,
                Sub(sender As Object, e As EventArgs)
                    result = DirectCast(sender, System.Windows.Forms.Button).Text
                    myForm.Close()
                End Sub
            b.Font = New Font(Me.Font.Name, Me.Font.Size, FontStyle.Bold)
            If nn = 1 Then xx = (myForm.Width \ uk - b.Width) \ 2
            If nn > 1 Then xx = (nn - 1) * myForm.Width \ uk + (myForm.Width \ uk - b.Width) \ 2
            b.Location = New Point(xx, 2 * myForm.Height \ 3)
        Next

        l.Size = New Size(myForm.Width - 114, 2 * myForm.Height \ 3 - 10 - myForm.Height \ 6) '***

        myForm.FormBorderStyle = FormBorderStyle.FixedDialog
        'myForm.BackColor = Color.LightSteelBlue
        If ccn = 2 Then
            myForm.BackColor = Color.Moccasin
        End If
        myForm.StartPosition = FormStartPosition.CenterParent
        myForm.ShowDialog()

        Return result
    End Function

    Function getMultilanguageLabel(ByVal mdtLabel As DataTable, ByVal txtmode As String, ByVal tabela As String, ByVal nname As String, ByVal what As String, ByVal jezik As String, Optional ByVal idlabel As String = "1") As String
        getMultilanguageLabel = ""

        Dim labelNovo() As DataRow = Nothing
        Dim sql As String = "tabela='" + tabela.Trim.ToUpper + "' and tip='" + what + "' and IDlang='" + jezik + "'"
        'Dim MLopis As String = getMultilanguageLabel(mdtLabel, txtmode, GlavnaTabela, "", bbb(i), Me.jezik)
        If nname <> "" Then sql = sql + " and polje='" + nname + "'"
        sql = sql + " and idlabel='" + idlabel + "'"
        If mdtLabel.Rows.Count > 0 Then labelNovo = mdtLabel.Select(sql)
        Dim labeltextNovo As String = ""
        If Not labelNovo Is Nothing AndAlso labelNovo.Length > 0 Then
            labeltextNovo = labelNovo(0).Item("ttext").ToString.Trim
            getMultilanguageLabel = labeltextNovo.TrimStart("'").TrimEnd("'")
        End If
    End Function

    Function getMultilanguageMessage(ByVal mdtMessage As DataTable, ByVal txtmode As String, ByVal poruka As String, ByVal jezik As String) As String
        getMultilanguageMessage = ""

        If poruka.Trim.ToUpper.IndexOf("ISTMSG") >= 0 Then
            Dim idmsg As Integer = -999
            idmsg = poruka.Trim.ToUpper.Replace("ISTMSG", "").Replace("'", "")
            Dim msgNovo() As DataRow = Nothing
            If mdtMessage.Rows.Count > 0 Then msgNovo = mdtMessage.Select("IDlang='" + jezik + "' and IDMsg='" + CStr(idmsg).Trim + "'")
            If Not msgNovo Is Nothing AndAlso msgNovo.Length > 0 Then
                getMultilanguageMessage = msgNovo(0).Item("ttext").ToString.Trim.TrimStart("'").TrimEnd("'")
            Else
                getMultilanguageMessage = "For " + jezik + " language " + poruka + " doesn't exist in ISTMessages!"
            End If
        End If
    End Function

    Public Function Kripto(ByVal vrednost As String, ByVal konekcija As String, ByVal jezik As String) As String

        Dim Sql As String = " DECLARE @Lozinka NVARCHAR(50);      " + vbCrLf +
                            " Declare @Hash NVARCHAR(50);      " + vbCrLf +
                            " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';      " + vbCrLf +
                            " Set @Hash  = '12345';      " + vbCrLf +
                            " SELECT trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, N'" + vrednost + "', 1, CONVERT(varbinary, @Hash)) ), 1))"

        Dim dt As DataTable = izvrsiSQLvratiDT(Sql, konekcija, jezik)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            Kripto = dt.Rows(0).Item(0).ToString
        Else
            Kripto = ""
        End If
        Return Kripto
    End Function

    Public Shared Function DeKripto(ByVal vrednost As String, ByVal konekcija As String, ByVal jezik As String) As String
        Dim Sql As String = " Declare @Lozinka NVARCHAR(50);    " + vbCrLf +
                            " Declare @Hash NVARCHAR(50);    " + vbCrLf +
                            " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';    " + vbCrLf +
                            " Set @Hash  = '12345';    " + vbCrLf +
                            " Declare @a as varbinary(256);  " + vbCrLf +
                            " Set @a=convert(varbinary(256),(Select '" + vrednost + "' ),1)  " + vbCrLf +
                            " select trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, case when trim(@a)='' then NULL else @a end, 1, CONVERT(varbinary, @Hash)))))  "

        Dim dt As DataTable = izvrsiSQLvratiDT(Sql, konekcija, jezik)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            DeKripto = dt.Rows(0).Item(0).ToString
        Else
            DeKripto = ""
        End If
        Return DeKripto
    End Function
    Public Shared Function DeKriptoSQL(ByVal sql As String) As String
        DeKriptoSQL = ""
        Dim sql1 As String = sql
        Dim strSql As String = " Declare @Lozinka NVARCHAR(50);    " + vbCrLf +
                            " Declare @Hash NVARCHAR(50);    " + vbCrLf +
                            " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';    " + vbCrLf +
                            " Set @Hash  = '12345';    " + vbCrLf +
                            " Declare @a as varbinary(256);  " + vbCrLf
        Dim bbb() As String = razkvantaj(sql, True)
        Dim pp As String = ""
        For ll As Integer = 0 To bbb.GetUpperBound(0)
            pp = bbb(ll)
            If pp.Trim.ToUpper.IndexOf("DBO.DECRYPTZOKI") = 0 Then
                If ll + 3 <= bbb.GetUpperBound(0) AndAlso bbb(ll + 1).Trim = "(" AndAlso bbb(ll + 3).Trim = ")" Then
                    bbb(ll) = " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(" + bbb(ll + 2) + ")='' then NULL else " + bbb(ll + 2) + " end),1), 1, CONVERT(varbinary, @Hash))))) "
                End If
                bbb(ll + 1) = ""
                bbb(ll + 2) = ""
                bbb(ll + 3) = ""
                ll = ll + 3
            End If
        Next

        sql1 = ustringaj(bbb)
        DeKriptoSQL = strSql + vbCrLf + sql1

    End Function

End Class

Public Class FlatCombo
    Inherits System.Windows.Forms.ComboBox

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Select Case m.Msg
            Case &HF
                Dim g As Graphics = Me.CreateGraphics
                Dim pen As New Pen(Color.Black, 1)
                Dim rect As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
                g.DrawRectangle(pen, rect)
            Case Else
                Exit Select
        End Select
    End Sub

End Class

Public Class DateTimePicker2
    Inherits DateTimePicker
    Private _BackColor As Color = SystemColors.Window

    Public Sub New()
        MyBase.New()
        Me.Format = DateTimePickerFormat.Short
        'Me.Width = 88
        'Me.FontHeight = 25
        'Me.BackColor = Color.LightCyan
    End Sub

    Public Overrides Property BackColor() As Color
        Get
            Return _BackColor
        End Get
        Set(ByVal Value As Color)
            _BackColor = Value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = CInt(&H14) Then ' WM_ERASEBKGND
            Dim g As Graphics = Graphics.FromHdc(m.WParam)
            g.FillRectangle(New SolidBrush(_BackColor), ClientRectangle)
            g.Dispose()
            Return
        End If
        MyBase.WndProc(m)
    End Sub

End Class


Public Class pomTextBox
    Inherits System.Windows.Forms.TextBox
    Private _BackColor As Color = SystemColors.Window
End Class

Public Class AutoResizeDataGridTableStyle
    Inherits DataGridTableStyle

    'Private OFFSET_GRID As Integer = 39
    Public Sub New()
        MyBase.New()
        AlternatingBackColor = System.Drawing.Color.Beige
        BackColor = System.Drawing.Color.Bisque
        ForeColor = System.Drawing.Color.Black
        GridLineColor = System.Drawing.Color.DarkGray
        PreferredRowHeight = 22
        ColumnHeadersVisible = True
        RowHeadersVisible = True
    End Sub

End Class

Public Class BorderlessButton
    Inherits System.Windows.Forms.Button

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        pe.Graphics.DrawRectangle(New Pen(BackColor, 5), ClientRectangle)
    End Sub

End Class

Public Class NoMouseWheelScrollPanel
    Inherits Panel

    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        Dim mouseEvent As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mouseEvent.Handled = True
    End Sub

End Class

Public Class TransparentPanel
    Inherits Panel

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H20 ''#WS_EX_TRANSPARENT
            Return cp
        End Get
    End Property

    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        ''#MyBase.OnPaintBackground(e)
    End Sub

End Class

Public Class myPanel
    Inherits Panel

    Protected Overrides Function ScrollToControl(ByVal activeControl As System.Windows.Forms.Control) As System.Drawing.Point
        Return DisplayRectangle.Location
    End Function

End Class

Public Class AutoCompleteTextbox
    Inherits System.Windows.Forms.TextBox

    Public listBox As ListBox
    Private oldText As String
    Private panel As Panel
    Public Property AutoCompleteList As List(Of String)
    Public Property CaseSensitive As Boolean
    Public Property aHeight As Integer
    Public Property aWidth As Integer
    Public Property MinTypedCharacters As Integer
    Public Property autoCompleteStart As Integer
    Public Property autoCompleteSelStart As Integer
    Public Property autoCompleteLength As Integer
    Public Property autoCompleteExists As Boolean
    Public Property autoCompleteFilterIs As String
    Public Property autoCompleteFilterStart As String
    Public Property autoCompleteFilterLength As String
    Public Property autoCompleteFilterFor As String
    Public Property autoCompleteFilterForAssignTo As String
    Public Property autoCompleteAssignTo As String
    Public Property autoCompleteAssignStart As String
    Public Property autoCompleteAssignLength As String
    Public Property autoCompleteLimitToList As Boolean
    Public Property autoCompleteLetter As String
    Public Property autoCompleteMaxDropDownItems As Integer
    Public Property autoCompleteFromBeginning As Boolean
    Public Property assignvalue As String
    Public Property nepotrebnavalidacijaPanel As Boolean
    Public Property nepotrebnavalidacija As Boolean
    Public Property MDoubleClick As Boolean
    Public Property filtervalue As String
    Public Property CurrentAutoCompleteList As List(Of String)
    Public Property grupePitanjaCAPI As Boolean
    Public Property grupePitanjaCATI As Boolean
    Public Property skociNazadGrupa As Boolean
    Public Property uradidodeluSilom As Boolean
    Public Property izUpa As Boolean
    Public Property cT As Boolean
    '*****
    Public Property sselectedValue As String
    Public Property sselectedText As String
    Public Property AutoCompleteDataSourceDB As List(Of String)
    Public Property displayMember As String
    Public Property valueMember As String
    Public Property orderBy As String
    Public Property DataSourceDB As String
    Public Property nizPrethodnihPKKontrola() As Control()
    Public Property nizPrethodnihKontrola() As Control()
    Public Property nizACTBKontrola() As Control()
    Public Property nizACTBKontrolaIme() As String()
    Public Property nizACTBToKontrola() As Control()
    Public Property nizACTBToKontrolaIme() As String()
    Public Property otisaogore As Boolean = False
    Public Property DB As Boolean
    Public Property OnlyOneInList As Boolean
    'Public Property pomocnitext As String
    Public Property setFocusOn As Control

    Public Sub New()
        MyBase.New()
        Me.MinTypedCharacters = 2   'default je 2
        Me.autoCompleteStart = 0
        Me.autoCompleteLength = Me.Text.Length

        Me.autoCompleteFilterIs = ""
        Me.CaseSensitive = False
        Me.assignvalue = ""
        Me.sselectedValue = ""
        Me.sselectedText = ""
        Me.AutoCompleteList = New List(Of String)()
        Me.listBox = New ListBox()
        Me.listBox.Name = "SuggestionListBox"
        Me.listBox.Font = Me.Font
        Me.listBox.Visible = True

        Me.panel = New Panel()
        Me.panel.Visible = False
        Me.panel.Font = Me.Font
        Me.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel.ClientSize = New System.Drawing.Size(1, 1)
        Me.panel.Name = "SuggestionPanel"
        Me.panel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.panel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.panel.BackColor = Color.Transparent
        Me.panel.ForeColor = Color.Transparent
        Me.panel.Text = ""
        Me.panel.PerformLayout()

        If Not panel.Controls.Contains(listBox) Then
            Me.panel.Controls.Add(listBox)
        End If

        Me.listBox.Dock = DockStyle.Fill
        Me.listBox.SelectionMode = SelectionMode.One
        Me.listBox.Dock = DockStyle.Fill

        AddHandler listBox.KeyDown, AddressOf Me.listBox_KeyDown
        AddHandler listBox.MouseDown, AddressOf Me.listBox_MouseDown

        Me.CurrentAutoCompleteList = New List(Of String)()
        listBox.DataSource = CurrentAutoCompleteList

        oldText = Me.Text

    End Sub

    Public Property SelectedIndex As Integer
        Get
            Return listBox.SelectedIndex
        End Get
        Set(ByVal value As Integer)

            If listBox.Items.Count <> 0 Then
                listBox.SelectedIndex = value
            End If
        End Set
    End Property

    Public Sub HideSuggestionListBox()
        If (Parent IsNot Nothing) Then
            panel.Hide()
            If Me.Parent.Controls.Contains(panel) Then
                Me.Parent.Controls.Remove(panel)
            End If

            If TypeOf (Me.Parent) Is GroupBox Then
                Me.Parent.Height = 48
                Me.Parent.BringToFront()
            End If
        End If
    End Sub

    Protected Overrides Sub onPreviewKeyDown(ByVal args As PreviewKeyDownEventArgs)
        ''POPIS
        ''ovim se iskljucuje tab na textbox-u
        If args.KeyData = Keys.Tab AndAlso Me.Name.Substring(0, 3).Trim.ToUpper <> "DTP" Then ' AndAlso Me.Name.Substring(0, 2).Trim.ToUpper <> "TK" Then
            args.IsInputKey = True
        End If

    End Sub

    Protected Overrides Sub OnKeyDown(ByVal args As KeyEventArgs)

        Me.skociNazadGrupa = False

        If listBox.Visible = True Then
            If (args.KeyCode = Keys.Up) Then
                MoveSelectionInListBox((SelectedIndex - 1))
                args.Handled = True
            ElseIf (args.KeyCode = Keys.Down) Then
                MoveSelectionInListBox((SelectedIndex + 1))
                args.Handled = True
            ElseIf (args.KeyCode = Keys.PageUp) Then
                MoveSelectionInListBox((SelectedIndex - 10))
                args.Handled = True
            ElseIf (args.KeyCode = Keys.PageDown) Then
                MoveSelectionInListBox((SelectedIndex + 10))
                args.Handled = True
            ElseIf (args.KeyCode = Keys.Enter) Then
                SelectItem()
                args.Handled = True
            ElseIf (args.KeyCode = Keys.F4) Then
                HideSuggestionListBox()
            Else
                MyBase.OnKeyDown(args)
            End If
        Else
            Me.nepotrebnavalidacija = False

            Select Case args.KeyCode
                Case Keys.Up
                    'dodela
                    'ISTMessageBox.Show("templateOnKeyDown")
                    Call autbLeave()
                    Me.nepotrebnavalidacija = True
                    If Me.grupePitanjaCAPI = True OrElse Me.grupePitanjaCATI = True Then
                        Me.skociNazadGrupa = True
                    Else
                        If Mid(Me.Name.Trim.ToUpper, 1, 2) = "TK" Then
                            Call autbPKSelectPreviousControl()
                        Else
                            Call autbSelectPreviousControl()
                            'SendKeys.SendWait("+{TAB}")
                        End If
                    End If

                   'Me.izUpa = True

                Case Keys.Down

                    Me.izUpa = False
                    'ovim ide na pp_validating
                    SendKeys.SendWait("{Enter}")
                Case Keys.F4
                    Me.izUpa = False
                    ShowSuggestsAll()
                    panel.Show()
                    panel.BringToFront()
                    If listBox Is Nothing OrElse listBox.Items.Count = 0 Then
                        HideSuggestionListBox()
                    End If

                Case Keys.F2
                    Dim f2 As String = "" : Dim f3 As String = ""
                    If Not Me.AccessibleName Is Nothing AndAlso Me.AccessibleName.Trim.ToUpper.IndexOf("ADDMISSINGVALUE") >= 0 Then
                        Dim pp() As String = Me.AccessibleName.Split(";")
                        Dim addmissingvalue As String = ""
                        For i As Integer = 0 To pp.GetUpperBound(0)
                            If pp(i).Trim.ToUpper.IndexOf("ADDMISSINGVALUE") >= 0 Then
                                addmissingvalue = pp(i).Substring(pp(i).Trim.ToUpper.IndexOf("ADDMISSINGVALUE"))
                                Dim f2f3 As String = addmv2(addmissingvalue)
                                Dim ppom() As String = f2f3.Split("$")
                                f2 = ppom(0) : f3 = ppom(1)
                                'If f2 = "AWLVALUE" Then
                                '    f2 = dajTexZaOdrVredIzAwl(Me, "F2", Me.AccessibleName, "F2").Trim
                                'End If
                                'If f3 = "AWLVALUE" Then
                                '    f3 = dajTexZaOdrVredIzAwl(Me, "F3", Me.AccessibleName, "F3").Trim
                                'End If
                                Exit For
                            End If
                        Next
                    End If
                    Me.Text = f2
                    'Me.SelectAll()


                Case Keys.F3
                    Dim f2 As String = "" : Dim f3 As String = ""
                    If Not Me.AccessibleName Is Nothing AndAlso Me.AccessibleName.Trim.ToUpper.IndexOf("ADDMISSINGVALUE") >= 0 Then
                        Dim pp() As String = Me.AccessibleName.Split(";")
                        Dim addmissingvalue As String = ""
                        For i As Integer = 0 To pp.GetUpperBound(0)
                            If pp(i).Trim.ToUpper.IndexOf("ADDMISSINGVALUE") >= 0 Then
                                addmissingvalue = pp(i).Substring(pp(i).Trim.ToUpper.IndexOf("ADDMISSINGVALUE"))
                                Dim f2f3 As String = addmv2(addmissingvalue)
                                Dim ppom() As String = f2f3.Split("$")
                                f2 = ppom(0) : f3 = ppom(1)
                                Exit For
                            End If
                        Next
                    End If
                    Me.Text = f3
                    'Me.SelectAll()
                Case Else
                    Me.izUpa = False
            End Select
        End If
    End Sub

    Shared Function addmv2(ByVal addmissingvalue As String) As String
        Dim f2 As String = "" : Dim f3 As String = ""
        addmissingvalue = addmissingvalue.Trim.ToUpper.Replace("ADDMISSINGVALUE", "")
        'f2="!8refuse,f3="?9dontknow
        Dim imaf2 As Boolean = False : Dim imaf3 As Boolean = False
        If addmissingvalue.ToUpper.IndexOf("F2") >= 0 Then imaf2 = True
        If addmissingvalue.ToUpper.IndexOf("F3") >= 0 Then imaf3 = True
        If imaf2 = True AndAlso imaf3 = True Then
            'Dim pomF2F3() As String = addmissingvalue.ToUpper.Split("F3")
            Dim pomF2F3() As String = Strings.Split(addmissingvalue.ToUpper, "F3")
            f2 = pomF2F3(0).Replace("F2", "").Replace("=", "")
            f3 = pomF2F3(1).Replace("=", "").Replace("}", "")
        End If
        If imaf2 = True AndAlso imaf3 = False Then
            f2 = addmissingvalue.Trim.ToUpper.Replace("F2", "").Replace("=", "").Replace("}", "")
        End If
        If imaf2 = False AndAlso imaf3 = True Then
            f3 = addmissingvalue.Trim.ToUpper.Replace("F3", "").Replace("=", "").Replace("}", "")
        End If
        addmv2 = f2 + "$" + f3
    End Function
    Sub autbPKSelectPreviousControl()

        setFocusOn = Me
        Dim nizK() As Control = Me.nizPrethodnihPKKontrola

        Dim ind As Integer = Array.IndexOf(nizK, Me)

        Dim koji As Integer = -1
        For i As Integer = ind - 1 To 0 Step -1
            If nizK(i).Visible = True AndAlso nizK(i).Enabled = True AndAlso nizK(i).TabStop = True Then
                koji = i
                Exit For
            End If
        Next
        If koji > -1 Then
            setFocusOn = nizK(koji)
        End If

    End Sub

    Sub autbSelectPreviousControl()

        'If Me.Parent.Name = "FormPopisAdresar" Then
        '    Exit Sub
        'End If
        setFocusOn = Me
        Dim nizK() As Control = Me.nizPrethodnihKontrola

        If Not nizK Is Nothing AndAlso nizK.Length > 0 Then

            Dim ind As Integer = Array.IndexOf(nizK, Me)

            Dim koji As Integer = -1
            For i As Integer = ind - 1 To 0 Step -1
                If nizK(i).Visible = True AndAlso nizK(i).Enabled = True AndAlso nizK(i).TabStop = True Then
                    koji = i
                    Exit For
                End If
            Next
            If koji > -1 Then
                setFocusOn = nizK(koji)
            End If
        Else
            SendKeys.SendWait("+{TAB}")
        End If
        otisaogore = False
    End Sub
    Private Sub listBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SelectItem()
            e.Handled = True
        End If
    End Sub

    'OVO NE RADI!!!!!!!!!!!!!!!!!!!!!!!!!
    'Private Sub listBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Me.MDoubleClick = True
    '    SelectItem()
    '    Me.uradidodeluSilom = True
    'End Sub
    'Private Sub listBox_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Me.MDoubleClick = True
    '    SelectItem()
    '    Me.uradidodeluSilom = True
    'End Sub
    'OVO NE RADI!!!!!!!!!!!!!!!!!!!!!!!!!

    'OVIM iskljucujemo klik misem na autocomplete jer ako se bira misem ne upisuje u dataset i ne pamti izabrano u bazi
    Private Sub listBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.MDoubleClick = True
        Me.uradidodeluSilom = True
    End Sub
    Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
        Me.MDoubleClick = False
        If Not panel.ContainsFocus Then
            Me.cT = False
            MyBase.OnLeave(e)
            Me.HideSuggestionListBox()
            Call autbLeave()
        Else
            Me.cT = True
        End If
    End Sub


    Sub autbLeave()

        Dim f2 As String = "" : Dim f3 As String = ""
        If Not Me.AccessibleName Is Nothing AndAlso Me.AccessibleName.Trim.ToUpper.IndexOf("ADDMISSINGVALUE") >= 0 Then
            Dim pp() As String = Me.AccessibleName.Split(";")
            Dim addmissingvalue As String = ""
            For i As Integer = 0 To pp.GetUpperBound(0)
                If pp(i).Trim.ToUpper.IndexOf("ADDMISSINGVALUE") >= 0 Then
                    addmissingvalue = pp(i).Substring(pp(i).Trim.ToUpper.IndexOf("ADDMISSINGVALUE"))
                    Dim f2f3 As String = addmv2(addmissingvalue)
                    Dim ppom() As String = f2f3.Split("$")
                    f2 = ppom(0) : f3 = ppom(1)
                    'If f2 = "AWLVALUE" Then
                    '    f2 = dajTexZaOdrVredIzAwl(Me, "F2", Me.AccessibleName, "F2").Trim
                    'End If
                    'If f3 = "AWLVALUE" Then
                    '    f3 = dajTexZaOdrVredIzAwl(Me, "F3", Me.AccessibleName, "F3").Trim
                    'End If
                    Exit For
                End If
            Next
        End If

        '*****************************Dodala Nevena 02.08.2022. - moze da ostane npr samo jedno slovo u nazivu opstine i da misem (dupli klik na autb za osptinu) predje na polje iznad, 
        '*****************************posle eneterom nastavlja kao da je sve ok uneto jer mu je CurrentAutoCompleteList.Count <> 0!!!
        Dim provera As Boolean = False
        For Each cc As String In CurrentAutoCompleteList
            If Me.Text = cc OrElse Me.Text = f2 OrElse Me.Text = f3 Then
                provera = True
            End If
        Next
        If provera = False AndAlso Me.Text.Trim <> "" AndAlso Me.autoCompleteLimitToList = True AndAlso OnlyOneInList = False Then
            ISTMessageBox.Show("Morate izabrati vrednost sa liste!")
            Me.Focus()
            Exit Sub
        End If
        '*****************************


        If Me.Text.Trim <> "" AndAlso CurrentAutoCompleteList.Count = 0 AndAlso Me.autoCompleteLimitToList = True AndAlso Me.Text.Trim <> f2 AndAlso Me.Text.Trim <> f3 AndAlso OnlyOneInList = False Then
            Me.Text = ""
            Me.assignvalue = ""

            If Mid(Me.Name, 1, 2).Trim.ToUpper = "TK" Then
                'na izlasku iz kljuca svakako prazni sve
            Else
                If Not Me.nizACTBKontrola Is Nothing Then
                    Dim nizK() As Control = Me.nizACTBKontrola
                    Dim nizKIme() As String = Me.nizACTBKontrolaIme
                    Dim nizToK() As Control = Me.nizACTBToKontrola
                    Dim ind As Integer = Array.IndexOf(nizKIme, Mid(Me.Name, 3).Trim.ToUpper)
                    If ind > -1 Then nizToK(ind).Text = ""
                    'Dim ind2 As Integer = Array.IndexOf(nizKIme, Me.autoCompleteFilterForAssignTo.Trim.ToUpper)
                    'If ind2 > -1 Then nizK(ind2).Text = ""
                End If
            End If
            Me.Focus()
            Exit Sub
        End If

        If Me.Text.Trim <> "" AndAlso CurrentAutoCompleteList.Count = 0 AndAlso Me.autoCompleteLimitToList = False AndAlso OnlyOneInList = False Then
            Me.assignvalue = ""
            If Mid(Me.Name, 1, 2).Trim.ToUpper = "TK" Then
                'na izlasku iz kljuca svakako prazni sve
            Else
                If Not Me.nizACTBKontrola Is Nothing Then
                    Dim nizK() As Control = Me.nizACTBKontrola
                    Dim nizKIme() As String = Me.nizACTBKontrolaIme
                    Dim nizToK() As Control = Me.nizACTBToKontrola
                    Dim ind As Integer = Array.IndexOf(nizKIme, Mid(Me.Name, 3).Trim.ToUpper)
                    If ind > -1 AndAlso Not nizToK Is Nothing AndAlso nizToK.Length > 0 AndAlso Not nizToK(ind) Is Nothing Then
                        nizToK(ind).Text = ""
                    End If
                    'Dim ind2 As Integer = Array.IndexOf(nizKIme, Me.autoCompleteFilterForAssignTo.Trim.ToUpper)
                    'If ind2 > -1 Then nizK(ind2).Text = ""
                End If
            End If
            Exit Sub
        End If

        'dodela
        Dim dodeli As String = ""

        If Me.DB = False Then
            If Me.Text.Trim <> "" AndAlso Me.autoCompleteAssignTo <> "" Then
                Dim nizacAssignTo As String() = Me.autoCompleteAssignTo.Split("$")
                Dim nizacAssignStart As String() = Me.autoCompleteAssignStart.Split("$")
                Dim nizacAssignLength As String() = Me.autoCompleteAssignLength.Split("$")
                For Each Str As String In AutoCompleteList
                    Dim pomstr As String = ""   'za prikazivanje i izbor
                    If Me.autoCompleteLength > 0 AndAlso Me.autoCompleteLength <= Str.Length - Me.autoCompleteStart Then
                        pomstr = Str.Substring(Me.autoCompleteStart, Me.autoCompleteLength)
                    Else
                        pomstr = Str.Substring(Me.autoCompleteStart)
                    End If
                    If pomstr.ToLower.Trim = Me.Text.ToLower.Trim Then
                        For i As Integer = 0 To nizacAssignLength.GetUpperBound(0)
                            Dim acl As Integer = CInt(nizacAssignLength(i))
                            Dim acs As Integer = CInt(nizacAssignStart(i))
                            If acl > 0 Then
                                Dim dduz As Integer = acl
                                If acl > Str.Length - acs Then dduz = Str.Length - acs
                                dodeli = dodeli + Str.Substring(acs, dduz) + "$"
                            Else
                                dodeli = dodeli + Str.Substring(acs, Me.autoCompleteStart) + "$"
                            End If
                        Next

                        Exit For
                    End If
                Next
            End If
            dodeli = dodeli.Trim + "aa"
            dodeli = dodeli.Replace("$aa", "")
            Me.assignvalue = dodeli
        End If

        If Me.DB = True Then
            If Me.Text.Trim <> "" Then
                For Each Str As String In AutoCompleteDataSourceDB
                    Dim pp() As String = Str.Split("ˇ")
                    'pp(0) - value
                    'pp(1) - display
                    Dim pomstrD As String = pp(1)
                    If pomstrD.ToLower.Trim = Me.Text.ToLower.Trim Then
                        dodeli = pp(0)
                        Exit For
                    End If
                Next
            End If
            Me.sselectedValue = dodeli.Trim
            If dodeli.Trim = "" Then Me.Text = ""
            Me.sselectedText = Me.Text.Trim
        End If
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal args As EventArgs)
        If Not Me.DesignMode AndAlso Not Me.AccessibleName Is Nothing AndAlso Me.AccessibleName.IndexOf("WSAWS;") < 0 Then
            If autoCompleteLetter Is Nothing Then autoCompleteLetter = "LAT"
            If autoCompleteLetter.Trim.ToUpper <> "LAT" Then
                If Me.Text.Trim <> "" AndAlso IsNumeric(Me.Text) = False Then Me.Text = FormTemplate.konverzijaLatCir(Me.Text)
            Else
                If Me.Text.Trim <> "" AndAlso IsNumeric(Me.Text) = False Then Me.Text = FormTemplate.konverzijaCirLat(Me.Text)
            End If
            Me.SelectionStart = Me.Text.Length 'Me.SelectionStart = Me.Text.Trim.Length
            If OnlyOneInList = False Then
                ShowSuggests()
            End If

        End If
        MyBase.OnTextChanged(args)
        oldText = Me.Text
    End Sub

    Public Sub MoveSelectionInListBox(ByVal Index As Integer)
        If Index <= -1 Then
            Me.SelectedIndex = 0
        ElseIf Index > (listBox.Items.Count - 1) Then
            SelectedIndex = (listBox.Items.Count - 1)
        Else
            SelectedIndex = Index
        End If
    End Sub

    Public Function SelectItem() As Boolean
        If Me.listBox.Items.Count > 0 AndAlso Me.SelectedIndex > -1 Then
            Me.Text = Me.listBox.SelectedItem.ToString()
            Me.HideSuggestionListBox()
        End If
        Return True
    End Function

    Public Sub ShowSuggestsAll()
        panel.SuspendLayout()

        If Me.filtervalue = "" Then
            UpdateCurrentAutoCompleteList()
        Else
            UpdateCurrentAutoCompleteListFilter()
        End If

        If ((CurrentAutoCompleteList IsNot Nothing) AndAlso CurrentAutoCompleteList.Count > 0) Then
            panel.Show()
            panel.BringToFront()
            Me.Focus()
        Else
            Me.HideSuggestionListBox()
        End If
        Call maxHeight()
        panel.ResumeLayout(True)

    End Sub

    Private Sub ShowSuggests()
        If Me.Text.Length >= MinTypedCharacters Then 'Me.Text.Trim.Length >= MinTypedCharacters
            panel.SuspendLayout()
            If Me.filtervalue = "" Then
                UpdateCurrentAutoCompleteList()
            Else
                UpdateCurrentAutoCompleteListFilter()
            End If
            If ((CurrentAutoCompleteList IsNot Nothing) AndAlso CurrentAutoCompleteList.Count > 0) Then
                panel.Show()
                panel.BringToFront()
                Me.Focus()
            Else
                Me.HideSuggestionListBox()
            End If

            Call maxHeight()
            panel.ResumeLayout(True)
        Else
            If Me.filtervalue = "" Then
                UpdateCurrentAutoCompleteList()
            Else
                UpdateCurrentAutoCompleteListFilter()
            End If
            Me.HideSuggestionListBox()
        End If
    End Sub

    Private Sub UpdateCurrentAutoCompleteList()
        CurrentAutoCompleteList.Clear()

        For Each sstr As String In AutoCompleteList
            Dim pomstr As String = ""   'za prikazivanje i izbor
            If Me.autoCompleteLength > 0 AndAlso Me.autoCompleteLength <= sstr.Length - Me.autoCompleteStart Then
                pomstr = sstr.Substring(Me.autoCompleteStart, Me.autoCompleteLength)
            Else
                pomstr = sstr.Substring(Me.autoCompleteStart)
            End If
            If autoCompleteFromBeginning = False Then
                If (pomstr.ToLower.Trim.IndexOf(Me.Text.ToLower) > -1) Then 'Me.Text.ToLower.Trim
                    CurrentAutoCompleteList.Add(pomstr.Trim)
                End If
            Else
                If Me.Text.ToLower.Trim = "" Then
                    If (pomstr.ToLower.Trim.IndexOf(Me.Text.ToLower) > -1) Then
                        CurrentAutoCompleteList.Add(pomstr.Trim)
                    End If
                Else
                    If Me.Text.Length <= pomstr.Length AndAlso pomstr.Substring(0, Me.Text.Length).ToLower.Trim = Me.Text.ToLower.Trim Then
                        CurrentAutoCompleteList.Add(pomstr.Trim)
                    End If
                End If
            End If

        Next
        UpdateListBoxItems()

    End Sub

    Private Sub UpdateCurrentAutoCompleteListFilter()
        CurrentAutoCompleteList.Clear()
        If Me.DB = False Then
            For Each sstr As String In AutoCompleteList
                If sstr <> "" Then
                    If Me.autoCompleteFilterStart >= 0 Then
                        Dim pomfil As String = ""   'za filter
                        If Me.autoCompleteFilterLength <= sstr.Length - Me.autoCompleteFilterStart Then
                            pomfil = sstr.Substring(Me.autoCompleteFilterStart, Me.autoCompleteFilterLength).Trim
                        Else
                            pomfil = sstr.Substring(Me.autoCompleteFilterStart).Trim
                        End If

                        If (pomfil.ToLower.IndexOf(Me.filtervalue.ToLower) = 0) Then
                            Dim pomstr As String = ""   'za prikazivanje i izbor
                            If Me.autoCompleteLength > 0 AndAlso Me.autoCompleteLength <= sstr.Length - Me.autoCompleteStart Then
                                pomstr = sstr.Substring(Me.autoCompleteStart, Me.autoCompleteLength)
                            Else
                                pomstr = sstr.Substring(Me.autoCompleteStart)
                            End If
                            If autoCompleteFromBeginning = False Then
                                If (pomstr.ToLower.IndexOf(Me.Text.ToLower) > -1) Then CurrentAutoCompleteList.Add(pomstr.Trim)
                            Else
                                If Me.Text.ToLower.Trim = "" Then
                                    If (pomstr.ToLower.Trim.IndexOf(Me.Text.ToLower) > -1) Then 'Me.Text.ToLower.Trim
                                        CurrentAutoCompleteList.Add(pomstr.Trim)
                                    End If
                                Else
                                    If Me.Text.Length <= pomstr.Length AndAlso pomstr.Substring(0, Me.Text.Length).ToLower = Me.Text.ToLower Then
                                        CurrentAutoCompleteList.Add(pomstr.Trim)
                                    End If
                                End If
                            End If


                        End If
                    End If
                End If
            Next
        End If

        If CurrentAutoCompleteList.Count > 0 Then UpdateListBoxItems()
    End Sub

    Private Sub UpdateListBoxItems()
        'bilo svuda ParentForm
        Try
            If (Parent IsNot Nothing) Then
                panel.Width = Me.Width
                If Me.aWidth = 0 Then
                    panel.Width = Me.Width
                Else
                    panel.Width = Me.aWidth
                End If

                panel.Location = Me.Location + New Size(0, Me.Height)

                If Not Me.Parent.Controls.Contains(panel) Then Me.Parent.Controls.Add(panel)
                If Not listBox.BindingContext Is Nothing Then CType(listBox.BindingContext(CurrentAutoCompleteList), CurrencyManager).Refresh()
            End If
        Catch ex As Exception
            'ISTMessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub maxHeight()
        Dim _maxDropDownItems As Integer = autoCompleteMaxDropDownItems

        If _maxDropDownItems = 0 Then _maxDropDownItems = 12

        Dim _dropDownHeight As Integer = aHeight

        If _dropDownHeight = 0 Then _dropDownHeight = 5000

        If Me.listBox.Items.Count > 0 Then
            Dim h As Integer = 0
            Dim i As Integer = 0
            Dim maxItemHeight As Integer = 0
            Dim highestItemHeight As Integer = 0


            'NE DIRATI NE RADI BEZ OVOG
            For Each item As Object In Me.listBox.Items

                Dim itHeight As Integer = Me.listBox.GetItemHeight(i)
                If highestItemHeight < itHeight Then
                    highestItemHeight = itHeight
                End If
                h = h + itHeight
                If i <= (_maxDropDownItems - 1) Then
                    maxItemHeight = h
                End If
                i = i + 1

            Next

            If maxItemHeight > _dropDownHeight Then
                Me.listBox.Height = _dropDownHeight + 3
            Else
                If maxItemHeight > highestItemHeight Then
                    Me.listBox.Height = maxItemHeight + 3
                Else
                    Me.listBox.Height = highestItemHeight + 3
                End If
            End If
        Else
            Me.listBox.Height = 15
        End If
        ' pozicioniranje na poslednjih 12 ide ovako: listBox.TopIndex = Math.Max(listBox.Items.Count - _maxDropDownItems + 1, 0)
        listBox.TopIndex = Math.Min(listBox.Items.Count - _maxDropDownItems + 1, 0)
        Me.listBox.Height = Me.listBox.Height + 25
        Me.panel.Height = Me.listBox.Height
        If TypeOf (Me.Parent) Is GroupBox Then
            Me.Parent.Height = Me.panel.Height + 50
            Me.Parent.BringToFront()
        End If

        If Me.Parent.Height < panel.Location.Y + panel.Height Then
            panel.Location = Me.Location - New Size(0, panel.Height)
        Else
            panel.Location = Me.Location + New Size(0, Me.Height)
        End If
        panel.BringToFront()

        'OVO NIKAKO GUBI SE ALWAYS VISIBLE LABEL; ODE POZADI
        'Me.Parent.BringToFront()



    End Sub

End Class

Public Class DataGridView2
    Inherits GroupBox
    Private _Grid As DataGridView

    Public Sub New()
        _Grid = New DataGridView()
        _Grid.Dock = DockStyle.Fill
        Me.Controls.Add(_Grid)
        _Grid.TabStop = False
    End Sub

    ReadOnly Property Grid As DataGridView
        Get
            Return _Grid
        End Get
    End Property

End Class

Public Class ResizeableControl
    '  U load forme treba upisati rc = New ResizeableControl(tcT12)

    Private WithEvents mControl As Control
    Private mMouseDown As Boolean = False
    Private mEdge As EdgeEnum = EdgeEnum.None
    Private mWidth As Integer = 4
    Private mOutlineDrawn As Boolean = False

    Private Enum EdgeEnum
        None
        Right
        Left
        Top
        Bottom
        TopLeft
    End Enum

    Public Sub New(ByVal Control As Control)
        mControl = Control
    End Sub

    Private Sub mControl_MouseDown(ByVal sender As Object,
        ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles mControl.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            mMouseDown = True
        End If
    End Sub

    Private Sub mControl_MouseUp(ByVal sender As Object,
        ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles mControl.MouseUp

        mMouseDown = False
    End Sub

    Private Sub mControl_MouseMove(ByVal sender As Object,
    ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles mControl.MouseMove

        Dim c As Control = CType(sender, Control)
        Dim g As Graphics = c.CreateGraphics
        Select Case mEdge
            Case EdgeEnum.TopLeft
                g.FillRectangle(Brushes.Fuchsia,
            0, 0, mWidth * 4, mWidth * 4)
                mOutlineDrawn = True
            Case EdgeEnum.Left
                g.FillRectangle(Brushes.Fuchsia,
            0, 0, mWidth, c.Height)
                mOutlineDrawn = True
            Case EdgeEnum.Right
                g.FillRectangle(Brushes.Fuchsia,
            c.Width - mWidth, 0, c.Width, c.Height)
                mOutlineDrawn = True
            Case EdgeEnum.Top
                g.FillRectangle(Brushes.Fuchsia,
            0, 0, c.Width, mWidth)
                mOutlineDrawn = True
            Case EdgeEnum.Bottom
                g.FillRectangle(Brushes.Fuchsia,
            0, c.Height - mWidth, c.Width, mWidth)
                mOutlineDrawn = True
            Case EdgeEnum.None
                If mOutlineDrawn Then
                    c.Refresh()
                    mOutlineDrawn = False
                End If
        End Select

        If mMouseDown And mEdge <> EdgeEnum.None Then
            c.SuspendLayout()
            Select Case mEdge
                Case EdgeEnum.TopLeft
                    c.SetBounds(c.Left + e.X, c.Top + e.Y,
            c.Width, c.Height)
                Case EdgeEnum.Left
                    c.SetBounds(c.Left + e.X, c.Top,
            c.Width - e.X, c.Height)
                Case EdgeEnum.Right
                    c.SetBounds(c.Left, c.Top,
            c.Width - (c.Width - e.X), c.Height)
                Case EdgeEnum.Top
                    c.SetBounds(c.Left, c.Top + e.Y,
            c.Width, c.Height - e.Y)
                Case EdgeEnum.Bottom
                    c.SetBounds(c.Left, c.Top,
            c.Width, c.Height - (c.Height - e.Y))
            End Select
            c.ResumeLayout()
        Else
            Select Case True
                Case e.X <= (mWidth * 4) And
            e.Y <= (mWidth * 4) 'top left corner
                    c.Cursor = Cursors.SizeAll
                    mEdge = EdgeEnum.TopLeft
                Case e.X <= mWidth 'left edge
                    c.Cursor = Cursors.VSplit
                    mEdge = EdgeEnum.Left
                Case e.X > c.Width - (mWidth + 1) 'right edge
                    c.Cursor = Cursors.VSplit
                    mEdge = EdgeEnum.Right
                Case e.Y <= mWidth 'top edge
                    c.Cursor = Cursors.HSplit
                    mEdge = EdgeEnum.Top
                Case e.Y > c.Height - (mWidth + 1) 'bottom edge
                    c.Cursor = Cursors.HSplit
                    mEdge = EdgeEnum.Bottom
                Case Else 'no edge
                    c.Cursor = Cursors.Default
                    mEdge = EdgeEnum.None
            End Select
        End If
    End Sub

    Private Sub mControl_MouseLeave(ByVal sender As Object,
        ByVal e As System.EventArgs) _
        Handles mControl.MouseLeave

        Dim c As Control = CType(sender, Control)
        mEdge = EdgeEnum.None
        c.Refresh()
    End Sub


End Class
Public Class PanelBorderGainsboro
    Inherits Panel

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        pe.Graphics.DrawRectangle(New Pen(Color.Gainsboro, 1), 0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1)
        'Dim rIstCards1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(pIstCards1.Location.X - 1, pIstCards1.Location.Y - 1, pIstCards1.Width + 1, pIstCards1.Height + 1)
    End Sub

End Class

Public Class MyRenderer
    Inherits ToolStripProfessionalRenderer
    Private Structure RGBColors
        Public Shared bBackColor As Color = Color.FromArgb(233, 151, 30)
        Public Shared fBackColor As Color = Color.FromArgb(3, 10, 26)
    End Structure
    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        Try
            Dim rc As New Rectangle(Point.Empty, e.Item.Size)
            Dim c As Color = IIf(e.Item.Selected, RGBColors.bBackColor, ISTTheme.PanelParent)
            Using brush As New SolidBrush(c)
                e.Graphics.FillRectangle(brush, rc)
            End Using
        Catch ex As Exception
        End Try

    End Sub
End Class
