Option Strict Off
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization
Imports System.Windows.Forms
Imports System.Xml
Public Module module1

    Public Sub ExportDataGridViewToXMLSpreadsheet2003(dgvs() As DataGridView, ByVal filePath As String)


        Using xtw As New XmlTextWriter(filePath, Encoding.UTF8)
            xtw.Formatting = Formatting.Indented ' Makes the XML readable.
            xtw.WriteStartDocument()
            xtw.WriteProcessingInstruction("mso-application", "progid=""Excel.Sheet""")
            xtw.WriteStartElement("Workbook")
            xtw.WriteAttributeString("xmlns", "urn:schemas-microsoft-com:office:spreadsheet")
            xtw.WriteAttributeString("xmlns:o", "urn:schemas-microsoft-com:office:office")
            xtw.WriteAttributeString("xmlns:x", "urn:schemas-microsoft-com:office:excel")
            xtw.WriteAttributeString("xmlns:ss", "urn:schemas-microsoft-com:office:spreadsheet")
            xtw.WriteAttributeString("xmlns:html", "http://www.w3.org/TR/REC-html40")

            For Each dgv As DataGridView In dgvs
                If Not dgv.Rows.Count > 0 Then Continue For ' Skip any non-visible DataGridViews.

                ' Create a new XML worksheet.
                xtw.WriteStartElement("Worksheet")
                xtw.WriteAttributeString("ss:Name", dgv.Name)

                ' Create a Table element.
                xtw.WriteStartElement("Table")
                xtw.WriteStartElement("Row")
                ' Add column definitions for the table.
                For i As Integer = 0 To dgv.Columns.Count - 1
                    If dgv.Columns(i).Visible Then ' Add only visible columns.

                        xtw.WriteStartElement("Cell")
                        xtw.WriteStartElement("Data")
                        xtw.WriteAttributeString("ss:Type", "String")
                        xtw.WriteString(dgv.Columns(i).HeaderText)
                        xtw.WriteEndElement() ' </Data>
                        xtw.WriteEndElement() ' </Cell>

                        'xtw.WriteStartElement("Column")
                        'xtw.WriteAttributeString("ss:Width", dgv.Columns(i).Width.ToString())
                        'xtw.WriteEndElement()
                    End If
                Next
                xtw.WriteEndElement() ' </Row>
                ' Add rows to the table.
                For Each row As DataGridViewRow In dgv.Rows
                    If Not row.IsNewRow Then ' Skip the new row for data entry.
                        xtw.WriteStartElement("Row")
                        For Each cell As DataGridViewCell In row.Cells
                            If cell.Visible Then ' Add only cells of visible columns.
                                xtw.WriteStartElement("Cell")
                                xtw.WriteStartElement("Data")
                                xtw.WriteAttributeString("ss:Type", "String") ' Assuming all data is text.
                                xtw.WriteString(If(cell.Value IsNot Nothing, cell.Value.ToString(), String.Empty))
                                xtw.WriteEndElement() ' </Data>
                                xtw.WriteEndElement() ' </Cell>
                            End If
                        Next
                        xtw.WriteEndElement() ' </Row>
                    End If
                Next

                xtw.WriteEndElement() ' </Table>
                xtw.WriteEndElement() ' </Worksheet>
            Next

            xtw.WriteEndElement() ' </Workbook>
            xtw.WriteEndDocument()
        End Using
    End Sub

    Function nizCHB(gr As String, ByVal istpolja As DatasetIstrazivanja.ISTPOLJADataTable, ByVal a As Object) As String
        Dim tabela As String = a.trim.toupper
        nizCHB = ""
        For Each p As DatasetIstrazivanja.ISTPOLJARow In istpolja.Rows
            If p.TABELA.ToUpper.Trim = tabela Then
                Dim pomIzraz As String = ""
                Dim ppolje As String = p.POLJE.Trim.ToUpper
                If p.IsIzrazNull = False Then
                    If p.Izraz.Trim.ToUpper.IndexOf("READONLY") >= 0 Then
                        pomIzraz = Replace(p.Izraz.Trim, "readonly", "", 1, , CompareMethod.Text)
                    Else
                        pomIzraz = p.Izraz.Trim
                    End If
                    If pomIzraz.Trim.ToUpper.IndexOf("MULTILINE") >= 0 Then
                        pomIzraz = Replace(pomIzraz.Trim, "multiline", "", 1, , CompareMethod.Text)
                    End If
                    If pomIzraz.Trim.ToUpper.IndexOf("FONTBOLD") >= 0 Then
                        pomIzraz = Replace(pomIzraz.Trim, "fontbold", "", 1, , CompareMethod.Text)
                    End If
                    'default 3D
                    If pomIzraz.Trim.ToUpper.IndexOf("BORDERFIXED") >= 0 Then
                        pomIzraz = Replace(pomIzraz.Trim, "borderfixed", "", 1, , CompareMethod.Text)
                    End If
                    If pomIzraz.Trim.ToUpper.IndexOf("BORDERNONE") >= 0 Then
                        pomIzraz = Replace(pomIzraz.Trim, "bordernone", "", 1, , CompareMethod.Text)
                    End If
                    If pomIzraz.Trim.ToUpper.IndexOf("PDESNOP") >= 0 Then
                        pomIzraz = Replace(pomIzraz.Trim, "pdesnop", "", 1, , CompareMethod.Text)
                    End If
                    If pomIzraz.Trim.ToUpper.IndexOf("$") >= 0 Then
                        pomIzraz = pomIzraz.Trim.Replace("$", "")
                    End If
                End If
                If pomIzraz.Length >= 8 AndAlso pomIzraz.ToUpper.Substring(0, 8) = "CHECKBOX" OrElse
                            pomIzraz.Length >= 10 AndAlso pomIzraz.ToUpper.Substring(0, 10) = "\NCHECKBOX" Then
                    Dim pom As String = ""
                    pomIzraz = pomIzraz.Trim.ToUpper.Replace("CHECKBOXL", "").Replace("_", "")
                    pomIzraz = pomIzraz.Trim.ToUpper.Replace("CHECKBOXR", "").Replace("_", "")
                    pomIzraz = pomIzraz.Trim.ToUpper.Replace("CHECKBOX", "").Replace("_", "")
                    pom = pomIzraz.Trim.ToUpper.Replace("\N", "").Replace("_", "")

                    If pom = gr.Trim.ToUpper Then nizCHB = nizCHB + ppolje + "$"
                    'nadji sve iz grupe
                End If
            End If 'tabela
        Next
        nizCHB = nizCHB + "$"
        nizCHB = nizCHB.Replace("$$", "")
    End Function

    Function mvchb(gr As String, ByVal istpolja As DatasetIstrazivanja.ISTPOLJADataTable, ByVal a As Object) As String
        Dim dd() As String = nizCHB(gr, istpolja, a).Split("$")
        Dim koliko As Integer = dd.Length
        Return koliko
    End Function

    Function prviCHBopis(gr As String, ByVal istpolja As DatasetIstrazivanja.ISTPOLJADataTable, ByVal a As Object) As String
        Dim dd() As String = nizCHB(gr, istpolja, a).Split("$")
        Dim plj As String = dd(0)

        Dim pomtxt As String = "tabela= '" & a.Trim & "' and polje='" & plj & "'"
        Dim popis As String = IIf(istpolja.Select(pomtxt)(0).Item("opis") Is System.DBNull.Value, "...nedostaje opis u ISTPoljima...", istpolja.Select(pomtxt)(0).Item("opis").Trim.ToUpper)

        Dim pOpisPom As String = System.Text.RegularExpressions.Regex.Replace(popis.Trim, "([Ww][Ee][Bb][Ss][Tt][Rr])", "")
        Dim ii As Integer = pOpisPom.IndexOf("#")
        If ii > 0 Then
            popis = pOpisPom.Substring(0, ii)
        Else
            popis = pOpisPom
        End If

        If popis.Trim.ToUpper.IndexOf("FONTSIZE") >= 0 AndAlso popis.Substring(popis.Trim.ToUpper.IndexOf("FONTSIZE")).Trim.ToUpper.IndexOf("$") > 0 Then
            popis = popis.Replace(Mid(popis.Substring(popis.Trim.ToUpper.IndexOf("FONTSIZE")).Trim.ToUpper, 1 + 8, InStr(popis.Substring(popis.Trim.ToUpper.IndexOf("FONTSIZE") + 8).Trim.ToUpper, "$")), "")
            popis = Replace(popis, "fontsize", "", 1, , CompareMethod.Text)
        End If
        If popis.Trim.ToUpper.IndexOf("FORECOLOR") >= 0 AndAlso popis.Substring(popis.Trim.ToUpper.IndexOf("FORECOLOR")).Trim.ToUpper.IndexOf("$") > 0 Then
            popis = popis.Replace(Mid(popis.Substring(popis.Trim.ToUpper.IndexOf("FORECOLOR")).Trim.ToUpper, 1 + 9, InStr(popis.Substring(popis.Trim.ToUpper.IndexOf("FORECOLOR") + 9).Trim.ToUpper, "$")), "")
            popis = Replace(popis, "forecolor", "", 1, , CompareMethod.Text)
        End If
        If popis.Trim.ToUpper.IndexOf("BACKCOLOR") >= 0 AndAlso popis.Substring(popis.Trim.ToUpper.IndexOf("BACKCOLOR")).Trim.ToUpper.IndexOf("$") > 0 Then
            popis = popis.Replace(Mid(popis.Substring(popis.Trim.ToUpper.IndexOf("BACKCOLOR")).Trim.ToUpper, 1 + 9, InStr(popis.Substring(popis.Trim.ToUpper.IndexOf("BACKCOLOR") + 9).Trim.ToUpper, "$")), "")
            popis = Replace(popis, "backcolor", "", 1, , CompareMethod.Text)
        End If

        popis = Replace(popis, "multiline", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "fontbold", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "fontitalic", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "fontunderline", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "pdesnop", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "ldesnop", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "lcentarp", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "frighta", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "lrighta", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "lcentera", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "lcentrea", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "$", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "lcolorgreen", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "lcolorred", "", 1, , CompareMethod.Text)
        popis = Replace(popis, "lcolorblue", "", 1, , CompareMethod.Text)

        If popis Is Nothing Then popis = ""

        Dim ff As String = popis

        Dim pp As Integer = popis.IndexOf(";")
        If pp > 0 Then ff = popis.Substring(0, pp)
        pp = ff.ToUpper.IndexOf("\N")
        If pp > 0 Then ff = ff.Substring(0, pp)
        prviCHBopis = ff
    End Function

    Function poslednjiCHugrupi(gr As String, ByVal istpolja As DatasetIstrazivanja.ISTPOLJADataTable, ByVal a As Object) As String
        Dim dd() As String = nizCHB(gr, istpolja, a).Split("$")
        poslednjiCHugrupi = dd(dd.GetUpperBound(0))
    End Function

    Function chtxt(gr As String, ByVal istpolja As DatasetIstrazivanja.ISTPOLJADataTable, ByVal a As Object) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim dd() As String = nizCHB(gr, istpolja, a).Split("$")
        Dim tabela As String = a.trim.toupper
        Dim txt As String = ""
        For i As Integer = 0 To dd.GetUpperBound(0)
            For Each p As DatasetIstrazivanja.ISTPOLJARow In istpolja.Rows
                If p.TABELA.ToUpper.Trim = tabela Then
                    If p.POLJE.Trim.ToUpper = dd(i).Trim.ToUpper Then
                        Dim popis As String = ""
                        If Not p.IsOpisNull Then
                            Dim pOpisPom As String = System.Text.RegularExpressions.Regex.Replace(p.Opis.Trim, "([Ww][Ee][Bb][Ss][Tt][Rr])", "")
                            Dim ii As Integer = pOpisPom.IndexOf("#")
                            If ii > 0 Then
                                popis = pOpisPom.Substring(0, ii)
                            Else
                                popis = pOpisPom
                            End If
                        End If

                        If popis.Trim.ToUpper.IndexOf("FONTSIZE") >= 0 AndAlso popis.Substring(popis.Trim.ToUpper.IndexOf("FONTSIZE")).Trim.ToUpper.IndexOf("$") > 0 Then
                            popis = popis.Replace(Mid(popis.Substring(popis.Trim.ToUpper.IndexOf("FONTSIZE")).Trim.ToUpper, 1 + 8, InStr(popis.Substring(popis.Trim.ToUpper.IndexOf("FONTSIZE") + 8).Trim.ToUpper, "$")), "")
                            popis = Replace(popis, "fontsize", "", 1, , CompareMethod.Text)
                        End If
                        If popis.Trim.ToUpper.IndexOf("FORECOLOR") >= 0 AndAlso popis.Substring(popis.Trim.ToUpper.IndexOf("FORECOLOR")).Trim.ToUpper.IndexOf("$") > 0 Then
                            popis = popis.Replace(Mid(popis.Substring(popis.Trim.ToUpper.IndexOf("FORECOLOR")).Trim.ToUpper, 1 + 9, InStr(popis.Substring(popis.Trim.ToUpper.IndexOf("FORECOLOR") + 9).Trim.ToUpper, "$")), "")
                            popis = Replace(popis, "forecolor", "", 1, , CompareMethod.Text)
                        End If
                        If popis.Trim.ToUpper.IndexOf("BACKCOLOR") >= 0 AndAlso popis.Substring(popis.Trim.ToUpper.IndexOf("BACKCOLOR")).Trim.ToUpper.IndexOf("$") > 0 Then
                            popis = popis.Replace(Mid(popis.Substring(popis.Trim.ToUpper.IndexOf("BACKCOLOR")).Trim.ToUpper, 1 + 9, InStr(popis.Substring(popis.Trim.ToUpper.IndexOf("BACKCOLOR") + 9).Trim.ToUpper, "$")), "")
                            popis = Replace(popis, "backcolor", "", 1, , CompareMethod.Text)
                        End If

                        popis = Replace(popis, "multiline", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "fontbold", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "fontitalic", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "fontunderline", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "pdesnop", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "ldesnop", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "lcentarp", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "frighta", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "lrighta", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "lcentera", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "lcentrea", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "$", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "lcolorgreen", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "lcolorred", "", 1, , CompareMethod.Text)
                        popis = Replace(popis, "lcolorblue", "", 1, , CompareMethod.Text)

                        If popis Is Nothing Then popis = ""

                        Dim ff As String = popis
                        Dim pp As Integer = popis.IndexOf(";")
                        If pp > 0 Then ff = popis.Substring(pp + 1)

                        If i = 0 Then
                            txt = " " + Str(i + 1).Trim + "  " + ff
                        Else
                            txt = txt + nvrd + "                                  " + Str(i + 1).Trim + "  " + ff
                        End If

                    End If

                End If
            Next
        Next
        chtxt = txt
    End Function

    Private Function ToLen(text As String, length As Integer)
        If text.Length > length Then
            Return text.Substring(0, length)
        Else
            Return text.PadRight(length)
        End If
    End Function

    Function duzinaPolja(ByVal plj As String, ByVal a As Object, ByVal istpolja As DatasetIstrazivanja.ISTPOLJADataTable) As Integer
        duzinaPolja = 10
        Dim pomtxt As String = "tabela= '" & a.Trim & "' and polje='" & plj & "'"
        'Dim pduzina As String = IIf(istpolja.Select(pomtxt)(0).Item("duzina") Is System.DBNull.Value, "", istpolja.Select(pomtxt)(0).Item("duzina").Trim.ToUpper)

        Dim pduzina As String = ""
        If istpolja.Select(pomtxt)(0).Item("duzina") Is System.DBNull.Value Then
        Else
            pduzina = istpolja.Select(pomtxt)(0).Item("duzina")
            '.Trim.ToUpper
        End If

        If IsNumeric(pduzina) = True Then duzinaPolja = CInt(pduzina)
    End Function
    Public nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
    Public nvd As String = Microsoft.VisualBasic.ChrW(34)

    Function dajTextZaAwlsIzISTAwls(ByVal awlNovo() As DataRow) As String
        Dim awltext As String = ""
        If awlNovo(0).Item("qmt").Trim.toupper.indexof("M0") = 0 Then
            awltext = awlNovo(0).Item("qmt").trim.toupper.replace("M0", "") + ". " + awlNovo(0).Item("Ttext").Replace("<br>", "").Replace(vbTab, "").Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "")
        Else
            awltext = awlNovo(0).Item("qmt").trim.toupper.replace("M", "") + ". " + awlNovo(0).Item("Ttext").Replace("<br>", "").Replace(vbTab, "").Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "")
        End If
        For k As Integer = 1 To awlNovo.GetUpperBound(0)
            If awlNovo(k).Item("qmt").Trim.toupper.indexof("M0") = 0 Then
                awltext = awltext + nvrd + "                                 " + awlNovo(k).Item("qmt").trim.toupper.replace("M0", "") + ". " + awlNovo(k).Item("Ttext").Replace("<br>", "").Replace(vbTab, "").Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "")
            Else
                awltext = awltext + nvrd + "                                 " + awlNovo(k).Item("qmt").trim.toupper.replace("M", "") + ". " + awlNovo(k).Item("Ttext").Replace("<br>", "").Replace(vbTab, "").Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "")
            End If
        Next
        dajTextZaAwlsIzISTAwls = awltext
    End Function
End Module