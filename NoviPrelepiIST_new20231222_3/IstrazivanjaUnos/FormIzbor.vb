Imports System.Collections.Generic
Imports System.Linq
Public Class FrmIzbor
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid

    Friend WithEvents TxtTrazi As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIzbor))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.TxtTrazi = New System.Windows.Forms.TextBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(794, 461)
        Me.DataGrid1.TabIndex = 0
        '
        'TxtTrazi
        '
        Me.TxtTrazi.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtTrazi.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TxtTrazi.Location = New System.Drawing.Point(56, 0)
        Me.TxtTrazi.Name = "TxtTrazi"
        Me.TxtTrazi.Size = New System.Drawing.Size(134, 22)
        Me.TxtTrazi.TabIndex = 1
        Me.TxtTrazi.Visible = False
        '
        'FrmIzbor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(794, 461)
        Me.Controls.Add(Me.TxtTrazi)
        Me.Controls.Add(Me.DataGrid1)
        
        Me.MinimizeBox = False
        Me.Name = "FrmIzbor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.TopMost = True
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private dt As System.Data.DataTable

    'Private ddt As System.Data.DataSet
    Public Izabran As Integer = -1

    Public IzabranRed As System.Data.DataRow
    Private nonNumberEntered As Boolean = False
    Public Dobar As Integer = -1
    Dim jezik As String
    Dim sapanela As Boolean
    Dim Rel As String
    Public Sub New(ByRef tabela As System.Data.DataTable, ByVal LX As Integer, ByVal LY As Integer, ByVal jezik As String, Optional ByVal ImenaPolja() As String = Nothing,
                   Optional ByVal VrednostiPolja() As String = Nothing, Optional ByVal DonjaIvica As Integer = -999, Optional ByVal sapanela As Boolean = False, Optional ByVal Rel As String = "")
        Me.New()
        Me.Rel = Rel
        Me.dt = tabela
        Me.TxtTrazi.Tag = ""
        Me.jezik = jezik
        Me.sapanela = sapanela
        'uvek centrirano!!!!ovako je lakše
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim tbl As New DataGridTableStyle

        Me.DataGrid1.DataSource = dt.DefaultView  'dsv

        tbl.MappingName = dt.TableName
        For Each c As System.Data.DataColumn In dt.Columns
            Dim sirina As Integer = 125
            If c.MaxLength > 0 Then
                sirina = 10 * c.MaxLength
                If sirina < 50 Then sirina = 50 'bilo 30
                If sirina > 400 Then sirina = 400 'bilo 130
            End If
            tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn(c.ColumnName, c.ColumnName, sirina, IIf(c.MaxLength <= 0, 80, c.MaxLength), String.Empty, HorizontalAlignment.Left, True))
        Next

        DataGrid1.TableStyles.Clear()
        DataGrid1.TableStyles.Add(tbl)
        If Not (ImenaPolja Is Nothing) Then
            If ImenaPolja.Length = 1 Then
                Nadji(ImenaPolja(0), VrednostiPolja(0), True)
            Else 'vise kljuceva....
                NadjiNiz(ImenaPolja, VrednostiPolja)
            End If
        End If
    End Sub

    'Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
    '    DataGrid1.Select(DataGrid1.CurrentCell.RowNumber)
    '    'Nadji(Me.dt.Columns(DataGrid1.CurrentCell.ColumnNumber).ColumnName, DataGrid1.CurrentCell.ToString)
    'End Sub
    Private Function IzabraniRed() As System.Data.DataRow
        Dim dr As DataRow
        Dim dtNew As DataTable
        dtNew = dt.Clone()
        dr = dtNew.NewRow()
        For i As Integer = 0 To dt.Columns.Count - 1
            dr.Item(dt.Columns(i).ColumnName) = DataGrid1.Item(DataGrid1.CurrentRowIndex, i)
        Next
        Return dr
        'dtNew.Rows.Add(dr)
        'Return dtNew.Rows(0)
    End Function


    Private Sub DataGrid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGrid1.KeyDown
        nonNumberEntered = False
        Select Case e.KeyCode
            Case Keys.Enter
                'ISTMessageBox.Show("Enter Key Pressed")
                'ISTMessageBox.Show("sta:" & dt.Rows(DataGrid1.CurrentRowIndex).Item(0))
                Izabran = DataGrid1.CurrentRowIndex
                IzabranRed = IzabraniRed()
                Me.Close()
            Case Keys.Escape
                Izabran = -1
                Me.Close()
            Case Keys.F4, Keys.ShiftKey  ', Keys.ControlKey
                Dim gde As System.Drawing.Rectangle = DataGrid1.GetCellBounds(DataGrid1.CurrentCell.RowNumber, DataGrid1.CurrentCell.ColumnNumber)
                Dim trt As Integer = 5
                TxtTrazi.Top = gde.Top - trt
                TxtTrazi.Left = gde.Left - trt
                TxtTrazi.Width = gde.Width + 2 * trt
                TxtTrazi.Height = gde.Height + 2 * trt
                TxtTrazi.Visible = True
                TxtTrazi.Focus()
            Case Else 'da krene Nadji
                If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                    ' Determine whether the keystroke is a number from the keypad.
                    If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                        ' Determine whether the keystroke is a backspace.
                        If e.KeyCode <> Keys.Back Then
                            ' A non-numerical keystroke was pressed.
                            ' Set the flag to true and evaluate in KeyPress event.
                            nonNumberEntered = True
                            Nadji(Me.dt.Columns(DataGrid1.CurrentCell.ColumnNumber).ColumnName, Chr(e.KeyValue).ToString)
                        End If
                    Else
                        'broj
                        Dim broj As String
                        broj = e.KeyCode.ToString
                        broj = broj.Replace("NumPad", "")
                        Nadji(Me.dt.Columns(DataGrid1.CurrentCell.ColumnNumber).ColumnName, broj)
                    End If
                Else
                    'broj
                    Dim broj As String
                    broj = e.KeyCode.ToString
                    broj = broj.Replace("D", "")
                    Nadji(Me.dt.Columns(DataGrid1.CurrentCell.ColumnNumber).ColumnName, broj)
                End If

                'Nadji(Me.dt.Columns(DataGrid1.CurrentCell.ColumnNumber).ColumnName, Chr(e.KeyValue).ToString)

        End Select
        'ISTMessageBox.Show("KeyDown!!!!")
    End Sub
    Private Sub Nadji(ByVal polje As String, ByVal vrednost As String, Optional ByVal NijeSaEkrana As Boolean = False)
        If NijeSaEkrana Then 'ovo nije dobro....
            Dim r2() As System.Data.DataRow = Nothing
            Dim StrList As New List(Of String)
            If dt.Columns(polje).DataType.Name = "String" Then
                For Each dr As DataRow In dt.Rows
                    If dr(polje) IsNot Nothing Then
                        StrList.Add(dr(polje).ToString)
                    End If
                Next
                For i As Integer = 0 To StrList.Count - 1
                    If StrList(i).Trim.ToUpper.StartsWith(vrednost.Trim.ToUpper) Then
                        Me.DataGrid1.CurrentRowIndex = i
                        System.Windows.Forms.SendKeys.Send("{RIGHT}{LEFT}")
                        Exit For
                    End If
                Next
                r2 = dt.Select("2=2")

            ElseIf dt.Columns(polje).DataType.Name = "Int32" OrElse dt.Columns(polje).DataType.Name = "Int64" OrElse dt.Columns(polje).DataType.Name = "Double" Then
                If vrednost Is Nothing OrElse vrednost = "" Then vrednost = "0"
                Dim sss As String = polje & " = " & vrednost.Trim & ""
                r2 = dt.Select(sss)
            End If

            If r2.Length = 1 Then
                If Me.Rel = "R" Then
                    If CType((r2(0)), System.Data.DataRow).Item(polje).ToString.Trim.ToUpper() = vrednost.ToString.Trim.ToUpper Then
                        Dobar = 1
                        IzabranRed = CType((r2(0)), System.Data.DataRow)
                    Else
                        Dobar = -1
                    End If
                Else
                    If CType((r2(0)), System.Data.DataRow).ItemArray(0).ToString.Trim.ToUpper() = vrednost.ToString.Trim.ToUpper Then
                        Dobar = 1
                    Else
                        Dobar = -1
                    End If
                End If

            Else
                Dobar = -1
            End If
        Else
            If dt.Columns(polje).DataType.Name = "String" OrElse dt.Columns(polje).DataType.Name = "Int32" OrElse dt.Columns(polje).DataType.Name = "Int64" OrElse dt.Columns(polje).DataType.Name = "Double" Then
                Dim vvv(dt.Rows.Count) As String
                Dim vrd As String = vrednost.Trim.ToUpper
                Dim curC As Integer = DataGrid1.CurrentCell.ColumnNumber
                'If DataGrid1.CurrentCell.ColumnNumber = 0 Then curC = 0 Else curC = DataGrid1.CurrentCell.ColumnNumber
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim cvrc As String = CType(DataGrid1.Item(i, curC), String).Trim.ToUpper
                    If cvrc.Length >= vrednost.Trim.Length Then
                        vvv(i) = cvrc.Substring(0, vrednost.Length)
                    End If
                Next
                Dim r2 As Integer = Array.IndexOf(vvv, vrd)
                If r2 < 0 Then
                    Dim ii As Integer = vrednost.Trim.ToUpper.Length - 1
                    Dim skr As String

                    While r2 < 0 And ii > 0
                        skr = vrednost.Trim.ToUpper.Substring(0, ii)
                        vrd = vrednost.Trim.ToUpper.Substring(0, ii)
                        For jj As Integer = 0 To dt.Rows.Count

                            If IsNothing(vvv(jj)) = False AndAlso vvv(jj).Substring(0, ii) = vrd Then
                                r2 = jj
                                Exit For
                            End If

                        Next
                        ii -= 1
                        If r2 >= 0 Then Exit While
                    End While
                    ''msg 191
                    Dim msgtxt191 As String = getMessageText(dtMessages, "191", Me.jezik) + nvrd
                    If r2 < 0 Then ISTMessageBox.Show(msgtxt191)

                End If
                If r2 >= 0 Then
                    Me.DataGrid1.CurrentRowIndex = r2
                    Me.DataGrid1.Refresh()
                    System.Windows.Forms.SendKeys.Send("{RIGHT}{LEFT}")
                End If
            End If
        End If
    End Sub

    Private Sub NadjiNiz(ByVal polja() As String, ByVal vrednosti() As String)

        'Dim nenul As Integer = vrednosti.GetUpperBound(0) '0
        'For i As Integer = 0 To vrednosti.GetUpperBound(0)
        '    If vrednosti(i).GetType Is GetType(System.DBNull) OrElse vrednosti(i) = "" Then
        '        nenul = i - 1
        '        Exit For
        '    Else
        '        vrednosti(i) = vrednosti(i).Replace("'", "''")
        '    End If
        'Next
        'While nenul >= 0
        '    Dim qqq As String = "2=2 "
        '    For i As Integer = 0 To nenul - 1
        '        qqq = qqq & " and " & polja(i) & "= '" & vrednosti(i) & "' "
        '    Next
        '    Dim sss As String = qqq
        '    If (dt.Columns(polja(nenul))).DataType.Name.Trim.ToUpper.IndexOf("INT") = 0 Then
        '        sss = qqq & " and " & polja(nenul) & " >= '" & vrednosti(nenul).ToString.Trim.ToUpper & "'"
        '    Else
        '        sss = qqq & " and " & polja(nenul) & " LIKE '" & vrednosti(nenul).Trim.ToUpper & "%'"
        '    End If

        '    Dim r2() As System.Data.DataRow = dt.Select(sss)

        '    If r2.Length = 0 Then
        '        Dim ii As Integer = vrednosti(nenul).Trim.ToUpper.Length - 1
        '        While r2.Length = 0 And ii >= 0
        '            If (dt.Columns(polja(nenul))).DataType.Name.Trim.ToUpper.IndexOf("INT") = 0 Then
        '                If vrednosti(nenul).ToString.Trim.ToUpper.Substring(0, ii) = "" Then
        '                    sss = qqq & " and " & polja(nenul) & " LIKE '" & vrednosti(nenul).Trim.ToUpper.Substring(0, ii) & "%'"
        '                Else
        '                    sss = qqq & " and " & polja(nenul) & " >= '" & vrednosti(nenul).ToString.Trim.ToUpper.Substring(0, ii) & "'"
        '                End If
        '            Else
        '                sss = qqq & " and " & polja(nenul) & " >= '" & vrednosti(nenul).ToString.Trim.ToUpper.Substring(0, ii) & "'"
        '            End If

        '            r2 = dt.Select(sss)
        '            ii = ii - 1
        '            If r2.Length > 0 Then Exit While
        '        End While 'r2.length
        '    End If
        '    If r2.Length > 0 Then
        '        Dim rr() As System.Data.DataRow = dt.Select("2=2")
        '        Me.DataGrid1.CurrentRowIndex = Array.IndexOf(rr, r2(0))
        '        System.Windows.Forms.SendKeys.Send("{RIGHT}{LEFT}")
        '        System.Windows.Forms.SendKeys.Send("{RIGHT}{LEFT}")
        '        Exit While
        '    Else
        '        nenul = nenul - 1
        '    End If
        'End While ' nenul >= 0



        Dim tip() As String
        Dim indtip As Integer = -1

        For i As Integer = 0 To polja.GetUpperBound(0)
            indtip = indtip + 1
            ReDim Preserve tip(indtip)
            If dt.Columns(polja(i)).DataType.Name = "Int32" OrElse dt.Columns(polja(i)).DataType.Name = "Int64" OrElse dt.Columns(polja(i)).DataType.Name = "Double" Then
                tip(indtip) = "I"
            Else
                tip(indtip) = ""
            End If
        Next

        Dim StrList As New List(Of String)
        For Each dr As DataRow In dt.Rows
            Dim str As String = ""
            For i As Integer = 0 To polja.GetUpperBound(0)
                If dr(polja(i)) IsNot Nothing Then
                    str = str + dr(polja(i)).ToString + "ˇ"
                End If
            Next
            str = str.TrimEnd("ˇ")
            StrList.Add(str)
        Next
        'svi
        Dim dokle As Integer = polja.GetUpperBound(0) '0
        Dim ok As Boolean = False
        While dokle >= 0
            ok = False
            For i As Integer = 0 To StrList.Count - 1
                Dim pp() As String = StrList(i).Trim.ToUpper.Split("ˇ")
                ok = True
                For p As Integer = 0 To dokle
                    If tip(p) = "I" AndAlso IsNumeric(pp(p)) AndAlso IsNumeric(vrednosti(p)) Then
                        If CInt(pp(p)) < CInt(vrednosti(p)) Then
                            ok = False
                        End If
                    Else
                        If Not pp(p).Trim.ToUpper.StartsWith(vrednosti(p).Trim.ToUpper) Then
                            ok = False
                        End If
                    End If
                Next

                If ok = True Then
                    If sapanela = True Then
                        Me.DataGrid1.CurrentRowIndex = 0
                    Else
                        Me.DataGrid1.CurrentRowIndex = i
                    End If
                    System.Windows.Forms.SendKeys.Send("{RIGHT}{LEFT}")
                    System.Windows.Forms.SendKeys.Send("{RIGHT}{LEFT}")
                    Exit For
                End If

            Next

            If ok = True Then
                Exit While
            Else
                dokle = dokle - 1
            End If

        End While ' dokle >= 0
    End Sub
    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Izabran = DataGrid1.CurrentRowIndex
        IzabranRed = IzabraniRed()
        Me.Close()
    End Sub

    Private Sub TxtTrazi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTrazi.Leave
        Me.TxtTrazi.Visible = False
        DataGrid1.Focus()
        If CType(TxtTrazi.Tag, String) = "" Then
            Nadji(Me.dt.Columns(DataGrid1.CurrentCell.ColumnNumber).ColumnName, TxtTrazi.Text.Trim)
        End If
        Me.TxtTrazi.Tag = ""
    End Sub

    Private Sub TxtTrazi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTrazi.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case Keys.Escape
                TxtTrazi.Tag = "ESC"
                System.Windows.Forms.SendKeys.Send("{TAB}")
                'Case Else
        End Select
    End Sub

End Class

Public Class dgrDatagridTextBoxColumn
    Inherits System.Windows.Forms.DataGridTextBoxColumn

    Public Sub New(ByVal strMappingName As String, ByVal strHeaderText As String, ByVal intColWidth As Integer, ByVal intMaxLength As Integer, ByVal strFormat As String, ByVal strAlignment As String, ByVal blnIsReadOnly As Boolean)
        MyBase.MappingName = strMappingName
        MyBase.HeaderText = strHeaderText
        MyBase.Width = intColWidth
        MyBase.TextBox.MaxLength = intMaxLength
        MyBase.Format = strFormat
        MyBase.Alignment = strAlignment
        MyBase.ReadOnly = blnIsReadOnly
        MyBase.TextBox.Enabled = False
        MyBase.NullText = String.Empty '"(null)"
        'AddHandler MyBase.TextBox.Leave, AddressOf FrmIzbor.TekstBoks_Leave

    End Sub

    'Public Sub TekstBoks_Leave(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles DataGrid1.DoubleClick
    '    Nadji(Me.dt.Columns(DataGrid1.CurrentCell.ColumnNumber).ColumnName, DataGrid1.CurrentCell.ToString)
    'End Sub

End Class