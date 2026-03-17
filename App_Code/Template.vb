

Imports System.Data
Imports System.Net
Imports System.Xml.Linq
Imports Microsoft.VisualBasic

Public Class Template
    Public Function NZ(ByVal nesto As Object, Optional ByVal uSta As String = Nothing) As String
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
    Public Function CASE2IIF(ByVal s As String) As String
        s = s.Replace(" N'", " '").Trim
        Dim pompo() As String = razkvantaj(s, True)
        Dim frt() As String = razkvantaj(s)
        Dim prvi As Integer = Array.IndexOf(frt, "CASE")
        Dim brw() As Integer = {}
        Dim URadu As Integer
        For i As Integer = prvi To pompo.GetUpperBound(0)
            Select Case frt(i).Trim.ToUpper
                Case "CASE"
                    ReDim Preserve brw(1 + brw.GetUpperBound(0))
                    brw(brw.GetUpperBound(0)) = 0
                    URadu = brw.GetUpperBound(0)
                    pompo(i) = ""
                Case "WHEN"
                    brw(URadu) = brw(URadu) + 1
                    If brw(URadu) > 1 Then pompo(i) = " ,IIf(" Else pompo(i) = " IIf("
                Case "THEN"
                    pompo(i) = " ~ "
                Case "ELSE"
                    pompo(i) = " ~ "
                Case "END"
                    Dim pomm As String = ""
                    For j As Integer = 1 To brw(URadu)
                        pomm = pomm & ")"
                    Next
                    pompo(i) = pomm
                    URadu = URadu - 1
                Case Else
                    'pompo(i) = frt(i)
            End Select
        Next
        Return ustringaj(pompo)
    End Function
    Public Function razCASTi(ByVal s As String, ByVal dsDB As DataSet) As String
        Dim raz As Boolean = True
        s = s.Replace(ChrW(&H200B), "").Trim
        If s.Trim.ToUpper.IndexOf("CAST") < 0 AndAlso s.Trim.ToUpper.IndexOf("CHARINDEX") < 0 AndAlso s.Trim.ToUpper.IndexOf("INSTR") < 0 AndAlso s.Trim.ToUpper.IndexOf("ISDATE") < 0 AndAlso s.Trim.ToUpper.IndexOf("ISNUMERIC") < 0 AndAlso s.Trim.ToUpper.IndexOf("LTRIM") < 0 AndAlso s.Trim.ToUpper.IndexOf("RTRIM") < 0 AndAlso s.Trim.ToUpper.IndexOf("LEFT") < 0 AndAlso s.Trim.ToUpper.IndexOf("RIGHT") < 0 AndAlso s.Trim.ToUpper.IndexOf("LEN") < 0 AndAlso s.Trim.ToUpper.IndexOf("FLOOR") < 0 AndAlso s.Trim.ToUpper.IndexOf("DAY") < 0 AndAlso s.Trim.ToUpper.IndexOf("MONTH") < 0 AndAlso s.Trim.ToUpper.IndexOf("YEAR") < 0 AndAlso s.Trim.ToUpper.IndexOf("TRIM") < 0 AndAlso s.Trim.ToUpper.IndexOf("SUBSTRING") < 0 AndAlso s.Trim.ToUpper.IndexOf("ROUND") < 0 Then
            raz = False
        End If

        If raz = True Then
            ' CAST ( nesto... AS tip )
            Dim kk() As String = razkvantaj(s, True)
            Dim tt As String = ""
            Dim i As Integer = 0
            Dim pomzaizlazak As Integer = 0
            While i <= kk.GetUpperBound(0)
                If kk(i).Trim.ToUpper = "CAST" OrElse kk(i).Trim.ToUpper = "CHARINDEX" OrElse kk(i).Trim.ToUpper = "INSTR" OrElse kk(i).Trim.ToUpper = "ISDATE" OrElse kk(i).Trim.ToUpper = "ISNUMERIC" OrElse kk(i).Trim.ToUpper = "LTRIM" OrElse kk(i).Trim.ToUpper = "RTRIM" OrElse kk(i).Trim.ToUpper = "LEFT" OrElse kk(i).Trim.ToUpper = "RIGHT" OrElse kk(i).Trim.ToUpper = "LEN" OrElse kk(i).Trim.ToUpper = "FLOOR" OrElse kk(i).Trim.ToUpper = "DAY" OrElse kk(i).Trim.ToUpper = "MONTH" OrElse kk(i).Trim.ToUpper = "YEAR" OrElse kk(i).Trim.ToUpper = "ROUND" OrElse kk(i).Trim.ToUpper.IndexOf("TRIM") = 0 OrElse kk(i).Trim.ToUpper.IndexOf("SUBSTRING") = 0 Then
                    Dim brz As Integer = 1 : Dim pC As Integer = i + 2 : Dim kC1 As Integer = 0
                    Dim Fja As String = kk(i).Trim.ToUpper
                    Dim ZnakRazdvajanja As String = IIf(kk(i).Trim.ToUpper = "CAST", "AS", ",")
                    i = i + 1
                    While brz > 0
                        i = i + 1
                        If kk(i) = "(" Then brz += 1
                        If kk(i) = ")" Then brz -= 1
                        If kk(i).Trim.ToUpper = ZnakRazdvajanja Then kC1 = i - 1
                    End While

                    Dim fraza As String = ""
                    Dim drugiP As String = ""
                    Dim treciP As String = ""
                    Dim parm As Integer = 0
                    Dim parm2 As Integer = 0
                    Dim parm3 As Integer = 0
                    Dim mm As String = ""

                    Select Case Fja
                        Case "CAST", "INSTR" '1-vi parametar
                            fraza = ustringaj(kk, pC, kC1)'.ToUpper
                        Case "CHARINDEX" '2-gi parametar
                            fraza = ustringaj(kk, kC1 + 2, i - 1)
                        Case "LEFT", "RIGHT", "ROUND" '1 i 2-gi parametar
                            fraza = ustringaj(kk, pC, kC1) '.ToUpper
                            drugiP = ustringaj(kk, kC1 + 2, i - 1)
                            parm = CType(drugiP, Int32)
                        Case "SUBSTRING" '1, 2 i 3 parametar
                            fraza = ustringaj(kk, pC, kC1 - 2) '.ToUpper
                            treciP = ustringaj(kk, kC1 + 2, i - 1)
                            drugiP = ustringaj(kk, kC1, kC1)
                            parm = CType(drugiP, Int32)
                            parm2 = CType(treciP, Int32)
                        Case "ISDATE" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                        Case "ISNUMERIC" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                        Case "RTRIM" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                        Case "LTRIM" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                        Case "TRIM" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                        Case "LEN" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                        Case "DAY" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                            If fraza.IndexOf(".") >= 0 Then mm = Fja + "(" + fraza + ")"
                        Case "MONTH" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                            If fraza.IndexOf(".") >= 0 Then mm = Fja + "(" + fraza + ")"
                        Case "YEAR" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                            If fraza.IndexOf(".") >= 0 Then mm = Fja + "(" + fraza + ")"
                        Case "FLOOR" 'samo 1 parametar
                            fraza = ustringaj(kk, pC, i - 1)
                            'Case "ROUND"  '1 i 2-gi parametar
                            '    fraza = ustringaj(kk, pC, kC) '.ToUpper
                            '    drugiP = ustringaj(kk, kC + 2, i - 1)
                            '    parm = CType(drugiP, Int32)
                    End Select

                    If mm = "" Then
                        If fraza.Trim.ToUpper.IndexOf("CAST") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("CHARINDEX") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("INSTR") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("ISDATE") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("ISNUMERIC") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("LTRIM") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("RTRIM") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("LEFT") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("RIGHT") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("LEN") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("FLOOR") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("DAY") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("MONTH") >= 0 Or fraza.Trim.ToUpper.IndexOf("YEAR") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("ROUND") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("TRIM") >= 0 OrElse fraza.Trim.ToUpper.IndexOf("SUBSTRING") >= 0 Then
                            fraza = razCASTi(fraza, dsDB)
                        End If

                        If IsNumeric(fraza) Then    'konstanta, vec je skupio vrednost sa ekrana
                            mm = fraza
                        Else
                            If dsDB.Tables(0).Columns.Contains(fraza.Trim.ToUpper) Then
                                mm = dsDB.Tables(0).Rows(0).Item(fraza.Trim.ToUpper).ToString.Trim
                            Else
                                mm = scompute(fraza.Replace("N'", "'").Trim, dsDB, 1)
                            End If


                        End If

                        mm = mm.Trim

                        Dim bezNavodnika As String = Replace(Replace(kk(pC), "'", ""), """", "")

                        Select Case Fja
                            Case "CAST"

                                If Not mm Is Nothing AndAlso mm <> "" AndAlso (mm.IndexOf("'") >= 0 OrElse mm.IndexOf("""") >= 0) Then mm = Replace(Replace(mm, "'", ""), """", "")
                                Select Case kk(kC1 + 2).Trim.ToUpper
                                    Case "DATE", "DATETIME", "CHAR", "STRING"
                                        mm = "'" & CType(mm, System.String).Trim & "'"


                                    Case "INT", "INTEGER", "REAL", "FLOAT", "DECIMAL", "NUMERIC"

                                        If CType(mm, System.String).Trim.ToUpper.IndexOf("ISNULL") >= 0 Then
                                            'ne radi nista
                                        Else
                                            If mm.GetType Is GetType(System.DBNull) OrElse CType(mm, System.String).Trim = "" OrElse IsNumeric(mm.Replace(" ", "")) = False Then
                                                mm = "0"
                                            End If
                                        End If


                                    Case Else
                                End Select

                            Case "CHARINDEX"
                                mm = InStr(mm, bezNavodnika)
                            Case "INSTR"
                                mm = InStr(bezNavodnika, mm)
                            Case "ISDATE"
                                If IsDate(mm) Then mm = " 2=3 " Else mm = " 2=2 "
                            Case "ISNUMERIC"
                                If IsNumeric(mm) = True Then
                                    mm = " 2=2 "
                                Else
                                    mm = " 2=3 "
                                End If
                            Case "LTRIM"
                                mm = "'" & CType(mm, System.String).Trim & "'"
                            Case "RTRIM"
                                mm = "'" & CType(mm, System.String).Trim & "'"
                            Case "TRIM"
                                mm = "'" & CType(mm, System.String).Trim & "'"
                            Case "LEN"
                                mm = "'" & CType(mm, System.String).Trim.Length & "'"
                            Case "DAY"
                                If mm.GetType Is GetType(System.DBNull) OrElse CDate(mm).ToString("MM/dd/yyyy").Trim = "" Then
                                    mm = "0"
                                Else
                                    mm = CInt(CDate(mm).ToString("MM/dd/yyyy").Trim.Substring(3, 2)).ToString.Trim
                                End If
                            Case "MONTH"
                                If mm.GetType Is GetType(System.DBNull) OrElse CDate(mm).ToString("MM/dd/yyyy").Trim = "" Then
                                    mm = "0"
                                Else
                                    mm = CInt(CDate(mm).ToString("MM/dd/yyyy").Trim.Substring(0, 2)).ToString.Trim
                                End If
                            Case "YEAR"
                                If mm.GetType Is GetType(System.DBNull) OrElse CDate(mm).ToString("MM/dd/yyyy").Trim = "" Then
                                    mm = "0"
                                Else
                                    mm = CInt(CDate(mm).ToString("MM/dd/yyyy").Trim.Substring(6, 4)).ToString.Trim
                                End If
                            Case "FLOOR"
                                If mm.GetType Is GetType(System.DBNull) OrElse CType(mm, System.String).Trim = "" OrElse IsNumeric(mm) = False Then
                                    mm = "0"
                                Else
                                    'mm je the largest integer less than or equal

                                    Dim pom As Double = Math.Floor(CType(mm, Double))
                                    mm = pom.ToString.Trim

                                    'mm = CType(mm, Double)
                                    'mm = Math.Floor(mm)
                                End If
                            Case "LEFT"
                                If mm.Trim.Length >= parm Then
                                    mm = "'" & mm.Substring(0, parm).ToString.Trim & "'"
                                Else
                                    mm = "'" & mm.Trim & "'"
                                End If
                            Case "RIGHT"
                                If mm.Trim.Length >= parm Then
                                    mm = "'" & mm.Substring(mm.Trim.Length - parm) & "'"
                                Else
                                    mm = "'" & mm.Trim & "'"
                                End If
                            Case "SUBSTRING"
                                If mm.Trim.Length >= parm AndAlso parm2 <= mm.Trim.Length - parm Then
                                    mm = "'" & Mid(mm.Trim, parm, parm2) & "'"
                                ElseIf mm.Trim.Length >= parm AndAlso parm2 > mm.Trim.Length - parm Then
                                    mm = "'" & mm.Trim.Substring(parm - 1) & "'"
                                Else
                                    mm = "'" & mm.Trim & "'"
                                End If
                            Case "ROUND"
                                If mm.GetType Is GetType(System.DBNull) OrElse CType(mm, System.String).Trim = "" OrElse IsNumeric(mm) = False Then
                                    mm = "0"
                                Else

                                    Dim pom As Double = Math.Round(CType(mm, Double), parm)
                                    mm = pom.ToString.Trim

                                End If
                        End Select
                    End If

                    tt = tt + " " & mm
                Else  'nije u castu
                    tt = tt + " " & kk(i)
                End If

                tt = tt.Replace(" ' ", "'")
                i = i + 1
            End While

            Return tt
        Else
            Return s
        End If
    End Function
    Public Function scompute(ByVal expression As String, ByVal dsDB As DataSet, Optional ByVal izrazcasti As Integer = 0) As String
        scompute = ""

        expression = expression.Replace(ChrW(&H200B), "").Trim
        If izrazcasti = 0 Then expression = razCASTi(expression, dsDB)
        If expression <> "Null" Then
            If Not dsDB Is Nothing AndAlso dsDB.Tables(0).Rows.Count > 0 Then
                If dsDB.Tables(0).Columns.Contains(expression.Trim.ToUpper) Then
                    scompute = dsDB.Tables(0).Rows(0).Item(expression.Trim.ToUpper).ToString.Trim
                Else

                    Dim pomkol As New DataColumn("pomKol")
                    If expression.Trim.ToUpper.IndexOf("IIF") = 0 Then
                        Dim pp() As String = expression.Split("~")
                        If pp(1).Trim.IndexOf("'") = 0 Then pp(1) = "'istististpom" + pp(1).Trim.Replace("'", "") + "'"
                        If pp(2).Trim.IndexOf("'") = 0 Then pp(2) = "'istististpom" + pp(2).Trim.Replace("'", "").Replace(")", "") + "')"
                        expression = pp(0) + "," + pp(1) + "," + pp(2)
                    End If

                    expression = Regex.Replace(expression,
                            "(\d+),(\d+)",
                            "$1.$2")


                    pomkol.Expression = expression.Replace("N'", "'").Trim
                    dsDB.Tables(0).Columns.Add(pomkol)
                    scompute = NZ(dsDB.Tables(0).Compute("MAX(pomKol)", ""))
                    If scompute.Trim.ToUpper.IndexOf("ISTISTISTPOM") = 0 Then scompute = "'" + Replace(scompute, "istististpom", "", 1, , CompareMethod.Text) + "'"
                    dsDB.Tables(0).Columns.Remove(pomkol)



                    'Dim pomkol As New DataColumn("pomKol")

                    'If expression.Trim.ToUpper.IndexOf("IIF") = 0 Then

                    '    Dim pp() As String = expression.Split("~"c)

                    '    If pp(1).Trim.IndexOf("'") = 0 Then
                    '        pp(1) = "'istististpom" & pp(1).Trim.Replace("'", "") & "'"
                    '    End If

                    '    If pp(2).Trim.IndexOf("'") = 0 Then
                    '        pp(2) = "'istististpom" & pp(2).Trim.Replace("'", "").Replace(")", "") & "')"
                    '    End If

                    '    expression = pp(0) & "," & pp(1) & "," & pp(2)

                    'End If



                    '' ✅ Преобразуем ТОЛЬКО числа вида 1,1 → 1.1
                    'expression = Regex.Replace(expression,
                    '        "(\d+),(\d+)",
                    '        "$1.$2")

                    'pomkol.Expression = expression.Replace("N'", "'").Trim
                    'dsDB.Tables(0).Columns.Add(pomkol)

                    'scompute = NZ(dsDB.Tables(0).Compute("MAX(pomKol)", ""))

                    'If scompute.Trim.ToUpper.IndexOf("ISTISTISTPOM") = 0 Then
                    '    scompute = "'" & Replace(scompute, "istististpom", "", 1, , CompareMethod.Text) & "'"
                    'End If

                    'dsDB.Tables(0).Columns.Remove(pomkol)















                End If
            End If
        End If
        Return scompute
    End Function








    Public Function zameniFP(ByVal izraz As String, ByVal dsDB As DataSet, ByVal MyTable As System.Web.UI.Control, ByVal arrayFP() As String, Optional ByVal izlk As Boolean = False) As String
        izraz = zameniFP3(zameniFP3(zameniFP3(izraz, dsDB, MyTable, arrayFP, izlk), dsDB, MyTable, arrayFP), dsDB, MyTable, arrayFP)
        izraz = spojiStringove(izraz)
        Return izraz
    End Function
    Public Function zameniFP3(ByVal izraz As String, ByVal dsDB As DataSet, ByVal MyTable As System.Web.UI.Control, ByVal arrayFP() As String, Optional ByVal izlk As Boolean = False) As String
        If Not izraz Is Nothing AndAlso izraz.Trim.ToUpper <> "" AndAlso izraz.Trim.ToUpper.IndexOf("#FP") >= 0 Then
            izraz = izraz.Trim
            Dim m As Integer = 0
            Dim bbb() As String = razkvantaj(izraz, True)
            For mm As Integer = 0 To bbb.GetUpperBound(0)
                If bbb(mm).Trim.ToUpper.IndexOf("#FP{") = 0 Then
                    'sa ekrana pokupi fiktivno polje
                    Dim p As String = bbb(mm)
                    p = NZ(Replace(p, "#FP{", "", 1,, CompareMethod.Text)).Trim
                    p = p.Replace("}", "").ToString.Trim
                    Dim FPbbb As String = p.Trim.ToUpper
                    m = 0
                    If FPbbb.Trim.IndexOf("'") > 0 Then m = 1
                    Dim ind As Integer = Array.IndexOf(arrayFP, FPbbb.Replace("'", ""))
                    Dim sev As String = ""
                    If ind > -1 Then sev = SE(FPbbb.Replace("'", ""), MyTable)
                    If IsNumeric(sev) AndAlso m = 0 Then
                        bbb(mm) = "" + sev.Trim + ""
                    Else
                        If IsNumeric(sev.Trim) Then
                            bbb(mm) = "'" + sev.Trim + "'"
                        Else
                            bbb(mm) = 0
                        End If

                    End If
                    bbb(mm) = razCASTi(bbb(mm).Trim, dsDB)
                End If
            Next
            Dim zzz As String = ustringaj(bbb)
            If izlk = False Then
                zzz = razCASTi(zzz.Trim, dsDB)
            End If
            zameniFP3 = zzz.Trim
        Else
            Return izraz
        End If
    End Function
    Public Function ucestvujePoljeuFP(ByVal izraz As String, ByVal polje As String, ByVal dsDB As DataSet, ByVal MyTable As System.Web.UI.Control, ByVal arrayFP() As String, ByVal arrayFPE() As String) As Boolean
        Dim ppp As String = ucestvujePoljeuFP3(ucestvujePoljeuFP3(ucestvujePoljeuFP3(izraz, polje, dsDB, MyTable, arrayFP, arrayFPE), polje, dsDB, MyTable, arrayFP, arrayFPE), polje, dsDB, MyTable, arrayFP, arrayFPE)
        ucestvujePoljeuFP = True
        If ppp <> "ˇ" Then
            ucestvujePoljeuFP = False
        End If
        Return ucestvujePoljeuFP
    End Function
    Public Function ucestvujePoljeuFP3(ByVal izraz As String, ByVal polje As String, ByVal dsDB As DataSet, ByVal MyTable As System.Web.UI.Control, ByVal arrayFP() As String, ByVal arrayFPE() As String) As String
        ucestvujePoljeuFP3 = ""
        If izraz.Trim = "ˇ" Then ucestvujePoljeuFP3 = "ˇ" : Exit Function
        If Not izraz Is Nothing AndAlso izraz.Trim.ToUpper <> "" AndAlso izraz.Trim <> "ˇ" AndAlso izraz.Trim.ToUpper.IndexOf("#FP") >= 0 Then
            ucestvujePoljeuFP3 = "~"
            izraz = izraz.Trim
            Dim m As Integer = 0
            Dim bbb() As String = razkvantaj(izraz, True)
            For mm As Integer = 0 To bbb.GetUpperBound(0)
                If bbb(mm).Trim.ToUpper.IndexOf("#FP{") = 0 Then
                    'sa ekrana pokupi fiktivno polje
                    Dim p As String = bbb(mm)
                    p = NZ(Replace(p, "#FP{", "", 1,, CompareMethod.Text)).Trim
                    p = p.Replace("}", "").ToString.Trim
                    Dim FPbbb As String = p.Trim.ToUpper
                    m = 0
                    If FPbbb.Trim.IndexOf("'") > 0 Then m = 1
                    Dim ind As Integer = Array.IndexOf(arrayFP, FPbbb.Replace("'", ""))
                    If ind > -1 Then
                        If arrayFPE(ind).Trim.ToUpper.IndexOf(polje.Trim.ToUpper) >= 0 Then
                            ucestvujePoljeuFP3 = "ˇ"
                        End If
                    End If
                End If
            Next
            Dim zzz As String = ustringaj(bbb)
            If ucestvujePoljeuFP3 = "~" Then ucestvujePoljeuFP3 = zzz.Trim
        End If
    End Function
    Function spojiStringove(ByVal zzz1 As String) As String
        Dim kon As String = ""
        Dim m As Integer = 0
        Dim zzz As String = zzz1.Trim
        'zzz = zzz.Replace("+ ''", "")

        If zzz.IndexOf("+") > 0 AndAlso zzz.IndexOf("'") >= 0 Then
            Dim pompp() As String = razkvantaj(zzz)
            For i As Integer = 0 To pompp.GetUpperBound(0)
                If pompp(i).Trim = "''" OrElse pompp(i).Trim = "N''" Then
                    If i >= 0 AndAlso i < pompp.GetUpperBound(0) AndAlso pompp(i + 1).Trim = "+" Then
                        pompp(i) = ""
                        pompp(i + 1) = ""
                    End If
                    If i > 0 AndAlso pompp(i - 1).Trim = "+" Then
                        pompp(i) = ""
                        pompp(i - 1) = ""
                    End If
                End If
            Next
            zzz = ustringaj(pompp).Trim
        End If
        If zzz.IndexOf("+") > 0 AndAlso zzz.IndexOf("'") >= 0 Then
            Dim bbb() As String = zzz.Split("+")
            If bbb.GetUpperBound(0) > 0 Then
                For i As Integer = 0 To bbb.GetUpperBound(0)
                    bbb(i) = bbb(i).Trim
                    kon = kon.Trim
                    If Len(kon) > 0 AndAlso kon(kon.Length - 1) = "'" Then
                        m = 1
                        Dim pp() As String = razkvantaj(kon)
                        pp(pp.GetUpperBound(0)) = pp(pp.GetUpperBound(0)).Trim.Replace("'", "").Trim
                        kon = ustringaj(pp).Trim
                    Else
                        m = 0
                    End If
                    If i = 0 Then
                        kon = kon + bbb(i)
                    Else
                        If m = 1 AndAlso bbb(i)(0) = "'" Then
                            Dim pp() As String = razkvantaj(bbb(i))
                            pp(0) = pp(0).Trim.Replace("'", "").Trim
                            kon = kon + ustringaj(pp).Trim
                        Else
                            kon = kon + "+" + bbb(i)
                        End If
                    End If
                Next

            End If
            'kon = kon + "$IST"
            'kon = kon.Replace("+$IST", "").Replace("$IST", "")
            zzz = kon.Trim
        End If
        Return zzz
    End Function
    Public Function replaceYYYMMMUser(ByVal str As String, ByVal appcode As String, ByVal gg As String, ByVal mm As String, ByVal uuser As String, ByVal tip As String) As String
        Dim sql As String = ""
        'zamena GGG,MMM
        sql = str.Replace(ChrW(&H200B), "").Trim
        sql = strrpl(sql, "{SIFIST}", "'" + appcode + "'")
        sql = strrpl(sql, "{APPCODE}", "'" + appcode + "'")
        sql = strrpl(sql, "{GGG}", "'" + gg + "'")
        sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", mm) + "'")
        sql = strrpl(sql, "{YYY}", "'" + gg + "'")
        sql = strrpl(sql, "{GGG", "'" + gg + "'")
        sql = strrpl(sql, "{YYY", "'" + gg + "'")
        sql = strrpl(sql, "{MMM", "'" + String.Format("{0:d2}", mm) + "'")
        sql = strrpl(sql, "{CAWIUSER}", "'" + uuser + "'")
        sql = strrpl(sql, "{CAWIUSER", "'" + uuser + "'")
        sql = strrpl(sql, "{TIP}", "'" + tip + "'")
        sql = strrpl(sql, "{TIP", "'" + tip + "'")
        sql = sql.Replace(ChrW(26), "")

        'If sql.Trim.ToUpper.IndexOf("{CAWIUSER") >= 0 Then
        '    sql = uuser
        'End If

        Return sql

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

    Public Function ustringaj(ByVal n As String(), Optional ByVal poc As Integer = 0, Optional ByVal kraj As Integer = -9) As String
        Dim trt As String = ""
        If kraj = -9 Then kraj = n.GetUpperBound(0)
        For i As Integer = poc To kraj
            trt = trt + " " & n(i)
        Next
        trt = trt.Replace(" ' ", "'").Replace("[ , ]", ",").Replace("[ ( ]", "(").Replace("[ ) ]", ")").Replace("[ + ]", "+").Replace("[ - ]", "-").Replace("[ * ]", "*").Replace("[ / ]", "/").Replace("[ > ]", ">").Replace("[ < ]", "<").Replace("[ = ]", "=").Replace("[ <= ]", "<=").Replace("[ >= ]", ">=").Replace("[ <> ]", "<>").Replace("[ . ]", ".").Replace("% ", "%").Replace(" %", "%")
        Return trt
    End Function
    Public Function razkvantaj(ByVal s As String, Optional notUpper As Boolean = False) As String()
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
    Enum znak
        slovo
        zagrada
        operator1
        blanko
    End Enum
    Public Function TipZnaka(ByVal s As String) As znak
        Dim c As Char = CChar(Mid(s, 1, 1))
        If ILOD(c) Then Return znak.slovo
        If c = "_"c Or c = "." Or c = "["c Or c = "]"c Or c = "'"c Then Return znak.slovo
        If c = "("c Or c = ")"c Then Return znak.zagrada
        If c = " " Then Return znak.blanko
        If c = "+"c Or c = "-"c Or c = "*"c Or c = "/" Or c = "="c Or c = ">"c Or c = "<"c Or c = "," Then Return znak.operator1
        Return Nothing 'ili return znak.slovo?
    End Function
    Public Function ILOD(ByVal cchh As Char) As Boolean
        Select Case Asc(cchh)
            Case 48 To 57, 65 To 90, 97 To 122
                ILOD = True
            Case Else
                ILOD = False
        End Select
    End Function
    Public Function zameniSpace(ByVal zzz As String, Optional ByVal Label As Boolean = False) As String
        zameniSpace = zzz
        'SPACE
        If CStr(zzz).Trim.ToUpper.IndexOf("SPACE") >= 0 Then
            Dim x1 As Integer
            Dim PozZ As String = "1"
            Dim blanko As String = ""
            x1 = CStr(zzz).ToUpper.IndexOf("SPACE")
            Dim prviDeo As String = zzz.Substring(0, x1)
            Dim ostatak As String = zzz.Substring(x1)
            Dim zagrada As String = ostatak.IndexOf(")")
            Dim drugiDeo As String = ostatak.Substring(zagrada + 1)
            Dim SpaceDeo As String = ostatak.Substring(0, zagrada + 1)

            SpaceDeo = SpaceDeo.Trim.ToUpper.Replace("SPACE", "").Replace("(", "").Replace(")", "").Trim

            If IsNumeric(SpaceDeo) Then
                For ii As Integer = 0 To CInt(SpaceDeo) - 1
                    blanko = blanko + " "
                Next
            End If

            blanko = "'" + blanko + "'"
            zzz = prviDeo + blanko + drugiDeo
            zameniSpace = zzz
            If Label = True Then zameniSpace = zzz.Replace("+", "").Replace("'", "")

        End If
    End Function
    Public Function SE(ByVal nname As String, ByVal MyTable As System.Web.UI.Control) As String

        SE = ""

        Dim txt As TextBox
        Dim lbl As Label
        Dim chbox As CheckBox
        Dim radiobutton As RadioButtonList
        Dim dropdown As DropDownList

        Dim t As Boolean = False
        Dim l As Boolean = False
        Dim ch As Boolean = False
        Dim rb As Boolean = False
        Dim ddl As Boolean = False
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
            ElseIf subName = "RB_" Then
                rb = True
            ElseIf subName = "CH_" Then
                ch = True
            ElseIf subName = "DL_" Then
                rb = True
            Else
                ostalo = True
            End If
        End If

        Dim nnname As String = nname
        If ostalo = True Then
            nnname = ""
            txt = CType(MyTable.FindControl("TP_" + nname), TextBox)
            If Not txt Is Nothing Then t = True : nnname = "TP_" + nname
            txt = CType(MyTable.FindControl("CB_" + nname), TextBox)
            If Not txt Is Nothing Then t = True : nnname = "TP_" + nname
            lbl = CType(MyTable.FindControl("LB_" + nname), Label)
            If Not lbl Is Nothing Then l = True : nnname = "LB_" + nname
            lbl = CType(MyTable.FindControl("FP_" + nname), Label)
            If Not lbl Is Nothing Then l = True : nnname = "FP_" + nname

            chbox = CType(MyTable.FindControl("CH_" + nname), CheckBox)
            If Not chbox Is Nothing Then ch = True : nnname = "CH_" + nname

            radiobutton = CType(MyTable.FindControl("RB_" + nname), RadioButtonList)
            If Not radiobutton Is Nothing Then rb = True : nnname = "RB_" + nname

            dropdown = CType(MyTable.FindControl("DL_" + nname), DropDownList)
            If Not dropdown Is Nothing Then ddl = True : nnname = "DL_" + nname
        End If


        If t = True Then
            txt = CType(MyTable.FindControl(nnname), TextBox)
            If Not txt Is Nothing Then SE = txt.Text.Replace(ChrW(&H200B), "").Trim
        End If
        If l = True Then
            lbl = CType(MyTable.FindControl(nnname), Label)
            If Not lbl Is Nothing Then SE = lbl.Text.Replace(ChrW(&H200B), "").Trim
        End If
        If ch = True Then
            chbox = CType(MyTable.FindControl(nnname), CheckBox)
            If Not chbox Is Nothing Then
                If chbox.Checked = True Then SE = "1" Else SE = "0"
            End If
        End If
        If rb = True Then
            radiobutton = CType(MyTable.FindControl(nnname), RadioButtonList)
            If Not radiobutton Is Nothing Then SE = radiobutton.SelectedValue.ToString.Trim
        End If
        If ddl = True Then
            dropdown = CType(MyTable.FindControl(nnname), DropDownList)
            If Not dropdown Is Nothing Then
                If dropdown.SelectedValue.ToString.Trim = "0" AndAlso dropdown.SelectedItem.Text.Trim = "" Then
                    SE = ""
                Else
                    SE = dropdown.SelectedValue.ToString.Trim
                End If
            End If
        End If

        Return SE

    End Function
    Public Sub NE(ByVal nname As String, ByVal MyTable As System.Web.UI.Control, ByVal vvalue As String)

        Dim txt As TextBox
        Dim lbl As Label
        Dim chbox As CheckBox
        Dim radiobutton As RadioButtonList
        Dim dropdown As DropDownList

        Dim t As Boolean = False
        Dim l As Boolean = False
        Dim ch As Boolean = False
        Dim rb As Boolean = False
        Dim ddl As Boolean = False
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
            ElseIf subName = "CH_" Then
                ch = True
            ElseIf subName = "RB_" Then
                rb = True
            ElseIf subName = "DL_" Then
                ddl = True
            Else
                ostalo = True
            End If
        End If
        Dim nnname As String = nname
        If ostalo = True Then
            nnname = ""
            txt = CType(MyTable.FindControl("TP_" + nname), TextBox)
            If Not txt Is Nothing Then t = True : nnname = "TP_" + nname
            txt = CType(MyTable.FindControl("CB_" + nname), TextBox)
            If Not txt Is Nothing Then t = True : nnname = "TP_" + nname
            lbl = CType(MyTable.FindControl("LB_" + nname), Label)
            If Not lbl Is Nothing Then l = True : nnname = "LB_" + nname
            lbl = CType(MyTable.FindControl("FP_" + nname), Label)
            If Not lbl Is Nothing Then l = True : nnname = "FP_" + nname

            chbox = CType(MyTable.FindControl("CH_" + nname), CheckBox)
            If Not chbox Is Nothing Then ch = True : nnname = "CH_" + nname

            radiobutton = CType(MyTable.FindControl("RB_" + nname), RadioButtonList)
            If Not radiobutton Is Nothing Then rb = True : nnname = "RB_" + nname

            dropdown = CType(MyTable.FindControl("DL_" + nname), DropDownList)
            If Not dropdown Is Nothing Then ddl = True : nnname = "DL_" + nname
        End If

        If t = True Then
            txt = CType(MyTable.FindControl(nnname), TextBox)
            If Not txt Is Nothing Then txt.Text = vvalue
        End If

        If l = True Then
            lbl = CType(MyTable.FindControl(nnname), Label)
            If Not lbl Is Nothing Then lbl.Text = vvalue
        End If
        If ch = True Then
            chbox = CType(MyTable.FindControl(nnname), CheckBox)
            If Not chbox Is Nothing Then
                If vvalue <> "" AndAlso vvalue <> "0" Then chbox.Checked = True Else chbox.Checked = False
            End If
        End If
        If rb = True Then
            radiobutton = CType(MyTable.FindControl(nnname), RadioButtonList)
            If Not radiobutton Is Nothing Then radiobutton.SelectedValue = vvalue
        End If
        If ddl = True Then
            dropdown = CType(MyTable.FindControl(nnname), DropDownList)
            If Not dropdown Is Nothing Then dropdown.SelectedValue = vvalue
        End If

    End Sub

    Dim dap As String = ChrW(39) & ChrW(39)
    Public Function sracunajCase(ByVal sql As String, ByVal MyTable As System.Web.UI.Control, Optional ByVal plj As String = "") As String
        If sql.Trim = "" Then
            sracunajCase = ""
            Exit Function
        End If
        sql = sql.Replace("{ ", "{").Replace(" }", "}")

        If sql.Trim.ToUpper.IndexOf("CASE ") >= 0 Then
            sql = sql.Replace("#{ ", "{").Replace("#{", "{").Replace(" }", "}").Trim
            If sql.Substring(0, 1) = "{" Then sql = sql.Substring(1)
            If sql.Substring(sql.Length - 1, 1) = "}" Then sql = sql.Substring(0, sql.Length - 1)
            sql = CASE2IIF(CStr(sql))
        End If
        sracunajCase = sql
    End Function
    Public Function sracunajIzraz(ByVal sql As String, ByVal MyTable As System.Web.UI.Control, Optional ByVal plj As String = "") As String
        'Dim txt As TextBox = CType(MyTable.FindControl(plj), TextBox) 

        If sql.Trim = "" Then
            sracunajIzraz = ""
            Exit Function
        End If
        sql = sql.Replace("{ ", "{").Replace(" }", "}")

        If sql.Trim.ToUpper.IndexOf("CASE ") >= 0 Then
            sql = sql.Replace("#{ ", "{").Replace("#{", "{").Replace(" }", "}").Trim
            If sql.Substring(0, 1) = "{" Then sql = sql.Substring(1)
            If sql.Substring(sql.Length - 1, 1) = "}" Then sql = sql.Substring(0, sql.Length - 1)
            sql = CASE2IIF(CStr(sql))
        End If



        Dim bbb() As String = razkvantaj(sql)
        Dim pp As String = ""
        For ll As Integer = 0 To bbb.GetUpperBound(0)
            bbb(ll) = bbb(ll).Trim.ToUpper.Replace("D.", "")
            If IsNumeric(bbb(ll)) = False AndAlso bbb(ll) <> "<>" AndAlso bbb(ll) <> "=" AndAlso bbb(ll) <> "(" AndAlso bbb(ll) <> ")" AndAlso
                bbb(ll) <> "IIF" AndAlso bbb(ll) <> "AND" AndAlso bbb(ll) <> "OR" AndAlso bbb(ll) <> "CAST" AndAlso bbb(ll) <> "," AndAlso bbb(ll) <> "INT" AndAlso bbb(ll) <> "AS" _
                AndAlso bbb(ll) <> "<=" AndAlso bbb(ll) <> ">=" AndAlso bbb(ll) <> "<" AndAlso bbb(ll) <> ">" AndAlso bbb(ll) <> "ISNULL" AndAlso bbb(ll) <> "ROUND" AndAlso bbb(ll) <> "IN" AndAlso bbb(ll) <> "'" AndAlso
                bbb(ll) <> "%" AndAlso bbb(ll) <> "-" AndAlso bbb(ll) <> "+" AndAlso bbb(ll) <> "/" AndAlso bbb(ll) <> "*" AndAlso bbb(ll) <> "LIKE" AndAlso bbb(ll) <> "NOT" AndAlso bbb(ll) <> "IS" AndAlso bbb(ll) <> "~" AndAlso
                bbb(ll).Substring(0, 1) <> "'" Then
                If bbb(ll).Trim = plj Then   'polje sa koga ovo radimo
                    Dim ssek As String = ""
                    ssek = SE(plj, MyTable)
                    'saekrana
                    If ssek Is Nothing OrElse ssek.Trim = "" Then
                        bbb(ll) = "Null"
                    ElseIf ssek.Trim = "?" Then
                        bbb(ll) = "'?'"
                    ElseIf ssek.Trim = "!" Then
                        bbb(ll) = "'!'"
                    Else
                        pp = ssek.Trim.Replace("'", dap)
                        If ll - 2 >= 0 AndAlso bbb(ll - 2).Length >= 5 AndAlso bbb(ll - 2).Trim.ToUpper = "ISNULL" Then
                            If ll + 2 <= bbb.GetUpperBound(0) AndAlso bbb(ll + 2).Length >= 0 AndAlso bbb(ll + 2).Trim.ToUpper = "0" Then
                                If IsNumeric(pp) = True Then
                                    bbb(ll) = pp
                                ElseIf pp = "''" OrElse pp = "" Then
                                    pp = "Null"
                                    'bbb(ll) = "Null"
                                Else
                                    bbb(ll) = "'" + pp + "'"
                                End If
                            Else
                                bbb(ll) = "'" + pp + "'"
                            End If
                        ElseIf IsNumeric(pp) = True AndAlso pp.Length >= 1 AndAlso pp.Length < 10 AndAlso Mid(pp, 1, 1) <> "0" Then 'broj i ne pocinje vodecom nulom
                            bbb(ll) = pp
                        ElseIf pp = "0" Then  'samo nula
                            bbb(ll) = pp
                        Else
                            bbb(ll) = "N'" + pp + "'"
                        End If
                    End If
                ElseIf bbb(ll).Trim <> plj Then
                    If bbb(ll).Trim.IndexOf("#FP{") = 0 Then  'fiktivno polje
                        pp = SE(bbb(ll).Replace("}", "").Substring(4), MyTable).Trim.Replace("'", dap)
                        If ll - 2 >= 0 AndAlso bbb(ll - 2).Length >= 5 AndAlso bbb(ll - 2).Trim.ToUpper = "ISNULL" Then
                            If ll + 2 <= bbb.GetUpperBound(0) AndAlso bbb(ll + 2).Length >= 0 AndAlso bbb(ll + 2).Trim.ToUpper = "0" Then
                                If IsNumeric(pp) = True Then
                                    bbb(ll) = pp
                                ElseIf pp = "''" OrElse pp = "" Then
                                    'pp = "Null"
                                    bbb(ll) = "Null"
                                Else
                                    bbb(ll) = "'" + pp + "'"
                                End If
                            Else
                                bbb(ll) = "'" + pp + "'"
                            End If
                        ElseIf IsNumeric(pp) = True AndAlso pp.Length >= 1 AndAlso pp.Length < 10 AndAlso Mid(pp, 1, 1) <> "0" Then 'broj i ne pocinje vodecom nulom
                            bbb(ll) = pp
                        ElseIf pp = "0" Then  'samo nula
                            bbb(ll) = pp
                        Else
                            bbb(ll) = "N'" + pp + "'"
                        End If
                    Else
                        'nije fiktivno polje i bbb(ll) <> plj
                        'saekrana
                        If SE(bbb(ll), MyTable).Trim = "" Then
                            bbb(ll) = "Null"
                        ElseIf SE(bbb(ll), MyTable).Trim = "?" Then
                            bbb(ll) = "Null"
                        ElseIf SE(bbb(ll), MyTable).Trim = "!" Then
                            bbb(ll) = "Null"
                        Else
                            pp = SE(bbb(ll), MyTable).Trim.Replace("'", dap)
                            If ll - 2 >= 0 AndAlso bbb(ll - 2).Length >= 5 AndAlso bbb(ll - 2).Trim.ToUpper = "ISNULL" Then
                                If ll + 2 <= bbb.GetUpperBound(0) AndAlso bbb(ll + 2).Length >= 0 AndAlso bbb(ll + 2).Trim.ToUpper = "0" Then
                                    If IsNumeric(pp) = True Then
                                        bbb(ll) = pp
                                    ElseIf pp = "''" OrElse pp = "" Then
                                        'pp = "Null"
                                        bbb(ll) = "Null"
                                    Else
                                        bbb(ll) = "'" + pp + "'"
                                    End If
                                Else
                                    bbb(ll) = "'" + pp + "'"
                                End If
                            ElseIf IsNumeric(pp) = True AndAlso pp.Length >= 1 AndAlso pp.Length < 10 AndAlso Mid(pp, 1, 1) <> "0" Then 'broj i ne pocinje vodecom nulom
                                bbb(ll) = pp
                            ElseIf pp = "0" Then  'samo nula
                                bbb(ll) = pp
                            Else
                                bbb(ll) = "N'" + pp + "'"
                            End If
                        End If
                    End If
                End If
            End If

        Next

        bbb = josJedanKrug(bbb)
        sracunajIzraz = ustringaj(bbb)


    End Function

    Public Function josJedanKrug(ByVal bbb() As String) As String()
        Dim ops As String = "=$<>$<$>$<=$>=$"

        'jos jedan prolaz da zamenim ''= 1 ili 12 ='' sa ''='1' , '12'=''
        For ll As Integer = 0 To bbb.Length - 1
            If ll - 2 >= 0 AndAlso bbb(ll - 2).Length > 0 AndAlso Mid(bbb(ll - 2).Trim.ToUpper, 1, 1) = "'" AndAlso ops.IndexOf(bbb(ll - 1).Trim.ToUpper + "$") >= 0 AndAlso IsNumeric(bbb(ll)) = True AndAlso bbb(ll).Length > 0 AndAlso Mid(bbb(ll), 1, 1) <> "'" Then
                bbb(ll) = "'" + bbb(ll) + "'"
            End If
            If ll + 2 <= bbb.Length - 1 AndAlso bbb(ll + 2).Length > 0 AndAlso Mid(bbb(ll + 2).Trim.ToUpper, 1, 1) = "'" AndAlso ops.IndexOf(bbb(ll + 1).Trim.ToUpper + "$") >= 0 AndAlso IsNumeric(bbb(ll)) = True AndAlso bbb(ll).Length > 0 AndAlso Mid(bbb(ll), 1, 1) <> "'" Then
                bbb(ll) = "'" + bbb(ll) + "'"
            End If
        Next

        ''jos jedan prolaz da zamenim NULL = .....
        'For ll As Integer = 0 To bbb.Length - 1
        'URADIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
        'Next

        Return bbb
    End Function

    'Public Sub ReadTableData()
    '    For Each row As TableRow In MyTable.Rows
    '        For Each cell As TableCell In row.Cells
    '            For Each control As Control In cell.Controls
    '                If TypeOf control Is TextBox Then
    '                    Dim textBox As TextBox = DirectCast(control, TextBox)
    '                    Dim textBoxValue As String = textBox.Text
    '                    ' Do something with textBoxValue
    '                End If
    '            Next
    '        Next
    '    Next
    'End Sub

    Public Function makeInsert(ByVal tablename As String, ByVal dsDB As DataSet, ByVal uuser As String, ByVal arrayttabindexF() As String, ByVal dsISTLK As DataSet) As String

        Dim row As DataRow
        row = dsDB.Tables(0).Rows(0)

        Dim insertStatement As New StringBuilder("INSERT INTO " + tablename + " (")
        Dim columnNames As String = ""
        ' Adding column values
        Dim columnValues As String = ""
        For i As Integer = 0 To row.Table.Columns.Count - 1
            Dim columnName As String = row.Table.Columns(i).ColumnName
            Dim columnValue As Object = row.Item(columnName)
            Dim columnType As String = row.Table.Columns(i).DataType.Name
            Dim indSave As Integer = Array.IndexOf(arrayttabindexF, columnName.Trim.ToUpper)
            If indSave >= 0 Then  'fields from form
                If IsDBNull(columnValue) Then
                    columnValues = columnValues + "NULL,"
                ElseIf TypeOf columnValue Is String Then
                    Dim value As String = columnValue.ToString().Replace("'", "''")
                    columnValues = columnValues + "N'" + value + "',"
                ElseIf TypeOf columnValue Is DateTime Then
                    If columnValue.ToString.Trim <> "" Then
                        columnValues = columnValues + "'" + columnValue.ToString("yyyy-MM-dd HH:mm:ss") + "',"
                    Else
                        columnValues = columnValues + "NULL,"
                    End If
                Else
                    columnValues = columnValues + columnValue.ToString() + ","
                End If
                'marko dodao jer nije ispravan naziv kolone (T-PHONE) puca insert
                If columnName.Contains("-") Then
                    columnName = "[" + columnName + "]"
                End If
                columnNames = columnNames + columnName + ","
            Else 'additional fields 
                Dim b As Boolean = True
                If columnName.Trim.ToUpper = "DATE_INSERT" Then
                    columnValues = columnValues + "'" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',"
                ElseIf columnName.Trim.ToUpper = "USER_INSERT" Then
                    columnValues = columnValues + "N'" + uuser + "',"
                ElseIf columnName.Trim.ToUpper = "SOURCEOF_INSERT" Then
                    columnValues = columnValues + "N'W',"
                Else
                    'nista
                    b = False
                End If
                If b = True Then
                    columnNames = columnNames + columnName + ","
                End If
            End If
        Next



        columnNames = columnNames.TrimEnd(",")
        insertStatement.Append(columnNames)
        insertStatement.Append(") VALUES (")
        columnValues = columnValues.Trim.TrimEnd(",") + ")"
        insertStatement.Append(columnValues) ' Converting List to Array

        Dim finalInsertStatement As String = insertStatement.ToString()
        Return finalInsertStatement
    End Function

    Public Function makeUpdate(ByVal tablename As String, ByVal dsDB As DataSet, ByVal uuser As String, ByVal pk() As String, ByVal arrayttabindexF() As String, ByVal dsISTLK As DataSet) As String

        Dim row As DataRow
        row = dsDB.Tables(0).Rows(0)

        Dim columnNames As String = "" : Dim columnValues As String = ""
        Dim updateStatement As New StringBuilder("UPDATE " + tablename + " set ")

        ' Adding column values
        Dim valueStatement As String = ""
        Dim whereStatement As String = ""


        For i As Integer = 0 To row.Table.Columns.Count - 1
            Dim columnName As String = row.Table.Columns(i).ColumnName
            Dim columnValue As Object = row.Item(columnName)
            Dim columnType As String = row.Table.Columns(i).DataType.Name
            Dim indSave As Integer = Array.IndexOf(arrayttabindexF, columnName.Trim.ToUpper)
            If indSave >= 0 Then  'fields from form
                Dim indPK As Integer = Array.IndexOf(pk, columnName.Trim.ToUpper)
                If indPK < 0 Then ' Skip primary key column
                    'marko dodao jer nije ispravan naziv kolone (T-PHONE) puca update
                    If columnName.Contains("-") Then
                        columnName = "[" + columnName + "]"
                    End If
                    If IsDBNull(columnValue) Then
                        valueStatement = valueStatement + columnName + "=NULL,"
                    ElseIf columnType = "String" Then
                        columnValue = columnValue.ToString().Replace("'", "''").Trim
                        valueStatement = valueStatement + columnName + "=N'" + columnValue.ToString.Trim + "',"
                    ElseIf columnType = "DateTime" Then
                        If columnValue.ToString.Trim <> "" Then
                            columnValue = columnValue.ToString("yyyy-MM-dd HH:mm:ss")
                            valueStatement = valueStatement + columnName + "='" + columnValue.ToString.Trim + "',"
                        Else
                            valueStatement = valueStatement + columnName + "=NULL,"
                        End If
                    ElseIf columnType = "Boolean" Then
                        If columnValue.ToString.Trim <> "" Then
                            If (columnValue.ToString.Trim.ToUpper = "TRUE" OrElse columnValue.ToString.Trim = "1") Then

                                valueStatement = valueStatement + columnName + "=1,"
                            Else
                                valueStatement = valueStatement + columnName + "=0,"
                            End If
                        Else
                            valueStatement = valueStatement + columnName + "=NULL,"
                        End If
                    Else  'numeric
                        If columnValue.ToString.Trim <> "" AndAlso IsNumeric(columnValue.ToString.Trim) Then
                            valueStatement = valueStatement + columnName + "=" + columnValue.ToString.Trim + ","
                        Else
                            valueStatement = valueStatement + columnName + "=NULL,"
                        End If
                    End If
                End If
                If indPK >= 0 Then 'primary key column for where
                    If columnType = "String" Then
                        columnValue = columnValue.ToString.Replace("'", "''").Trim
                        whereStatement = whereStatement + " and " + columnName + "=N'" + columnValue.ToString.Trim + "'"
                    ElseIf columnType = "DateTime" Then
                        whereStatement = whereStatement + " and " + columnName + "='" + columnValue.ToString.Trim + "'"
                    Else
                        whereStatement = whereStatement + " and " + columnName + "=" + columnValue.ToString.Trim + ""
                    End If
                End If
            Else 'additional fields 
                If columnName.Trim.ToUpper = "DATE_UPDATE" Then
                    columnValue = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    valueStatement = valueStatement + columnName + "=N'" + columnValue.ToString.Trim + "',"
                ElseIf columnName.Trim.ToUpper = "USER_UPDATE" Then
                    columnValue = uuser
                    valueStatement = valueStatement + columnName + "=N'" + columnValue.ToString.Trim + "',"
                End If
            End If
        Next

        For i As Integer = 0 To dsISTLK.Tables(0).Rows.Count - 1
            Dim rowISTErrorNumber As String = dsISTLK.Tables(0).Rows(i).Item("rbrgreske").ToString.Trim
            If dsDB.Tables(0).Rows(0).Item(rowISTErrorNumber) = True Then
                valueStatement = valueStatement + rowISTErrorNumber + "=1,"
            Else
                valueStatement = valueStatement + rowISTErrorNumber + "=0,"
            End If
        Next
        valueStatement = valueStatement + "INDGR" + "='" + dsDB.Tables(0).Rows(0).Item("INDGR").ToString.Trim + "',"

        valueStatement = valueStatement.Trim.TrimEnd(",")

        whereStatement = " where 2=2 " + whereStatement
        updateStatement.Append(valueStatement) ' Converting List to Array
        updateStatement.Append(whereStatement)

        ' The final UPDATE statement
        Dim finalUpdateStatement As String = updateStatement.ToString()
        Return finalUpdateStatement

    End Function
    Public Function makeDelete(ByVal tabela As String, ByVal pk As String) As String
        makeDelete = " DELETE from " + tabela + " WHERE " + pk
    End Function
    Public Function dajNull(ByVal mozeNull As Boolean, ByVal dt As DataTable, ByVal plj As String) As String
        If mozeNull = True Then
            dajNull = "Null,"
        Else
            Select Case dt.Columns(plj).DataType.Name
                Case "Boolean"
                    dajNull = "0,"
                Case "String", "char"
                    dajNull = "N'',"
                Case "DateTime"
                    dajNull = "N'',"
                Case "Integer"
                    dajNull = "Null,"
                Case "Int16"
                    dajNull = "Null,"
                Case "Int32"
                    dajNull = "Null,"
                Case "Int64"
                    dajNull = "Null,"
                Case "Long"
                    dajNull = "Null,"
                Case "Money"
                    dajNull = "Null,"
                Case "Decimal"
                    dajNull = "Null,"
                Case Else
                    dajNull = "cast('' as float),"
            End Select
        End If
    End Function
    Public Function ISNULL(ByVal obj As Object, ByVal sta As Object) As Object
        If obj.ToString.Trim.Length = 0 Then
            ISNULL = sta
        Else
            ISNULL = obj
        End If
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


    Public Function ispitajUslov(ByVal uslov As String) As Boolean
        Dim sc As New MSScriptControl.ScriptControl
        sc.Language = "VBScript"
        ispitajUslov = False
        Dim s As String
        s = ""
        s = s & "function iif(expr,sTrue, sFalse)" & vbLf
        s = s & "  if expr then" & vbLf
        s = s & "    iif = sTrue" & vbLf
        s = s & "  else" & vbLf
        s = s & "    iif = sFalse" & vbLf
        s = s & "  end if" & vbLf
        s = s & "end function" & vbLf
        sc.AddCode(s)
        uslov = "IIf ((" + CStr(uslov).Trim.ToUpper.Replace("D.", "") + ") ,1,0)"
        If sc.Eval("iif(" & uslov & ",""1"",""0"")") = 1 Then ispitajUslov = True
    End Function

End Class
