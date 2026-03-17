Option Explicit On
Option Strict Off

Module OOo_Examples

    ' ---------- divers exemples , faire ConnectOpenOffice avant de les appeler -------------
    ' ---------- various examples , ConnectOpenOffice before calling them -------------------

    Sub HelloWorldExample()
        'Dim myDoc As Object, myText As Object, myCursor As Object
        'myDoc = StarDesktop.loadComponentFromURL("private:factory/swriter", "_blank", 0, dummyArray)
        'myText = myDoc.Text
        'myCursor = myText.createTextCursor
        'myText.insertString(myCursor, OOoMess111, False)
        '' insertion d'une marque de paragraphe, avec une constante API
        '' inserting a paragraph break, using an API constant
        'myText.insertControlCharacter(myCursor, OOOtextControlCharacterPARAGRAPH_BREAK, False)
        'myCursor.CharColor = OOoRGB(0, 200, 0)
        'myText.insertString(myCursor, OOoMess112, False)
        'myCursor.CharWeight = OOOawtFontWeightBOLD ' an API constant
        'myText.insertString(myCursor, OOoMess113, False)
        'myCursor.CharColor = -1
        'myCursor.CharWeight = OOOawtFontWeightNORMAL ' an API constant
        'myText.insertControlCharacter(myCursor, OOOtextControlCharacterPARAGRAPH_BREAK, False)
        'ISTMessageBox.Show(OOoMess105)
        'myDoc.close(True)

        Dim myDoc As Object, mySheet As Object

        myDoc = StarDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, dummyArray)
        mySheet = myDoc.getSheets().getByIndex(0) 'seleciona primeira planilha

        Call mySheet.getCellByPosition(3, 1).SetValue(111) 'seta valor col,linha
        Call mySheet.getCellByPosition(3, 2).SetValue(222) 'seta valor col,linha
        Call mySheet.getCellByPosition(3, 3).SetString("Marcos") 'seta valor da celular do tipo string
        Call mySheet.getCellByPosition(3, 5).SetFormula("=SUM(D2:D4)") 'seta celula do tipo formula
        'Save the doc

    End Sub

    'Sub showWorkDirectory()
    '    ' cette routine est indépendante de tout document
    '    ' elle affiche l'adresse du répertoire de travail indiqué dans la configuration d'OpenOffice

    '    ' this routine is independent from any document
    '    ' it displays the work directory indicated in the configuration of OpenOffice
    '    Dim sv As Object, w As String
    '    sv = CreateUnoService("com.sun.star.util.PathSettings")
    '    w = sv.Work
    '    ISTMessageBox.Show(convertFromURL(w))
    'End Sub

    'Sub defineTabulations()
    '    Dim myDoc As Object, myText As Object, myCursor As Object
    '    Dim tabStopsList As Object, Texte1 As String, Tab As String

    '    Tab = Chr(9)
    '    myDoc = StarDesktop.loadComponentFromURL("private:factory/swriter", "_blank", 0, dummyArray)
    '    myText = myDoc.Text
    '    myCursor = myText.createTextCursor
    '    ' création et remplissage d'un tableau de structures Uno
    '    ' create and fill an array of Uno structures
    '    tabStopsList = CreateUnoStruct("com.sun.star.style.TabStop", 2)
    '    ' mettre 3 taquets sur le paragraphe en cours
    '    ' put 3 tab stops on the current paragraph
    '    tabStopsList(0).DecimalChar = ","
    '    tabStopsList(0).FillChar = " "
    '    tabStopsList(0).Position = 2500 ' 25 mm ( 2,5 cm )
    '    tabStopsList(0).Alignment = OOOstyleTabAlignLEFT
    '    tabStopsList(1).DecimalChar = ","
    '    tabStopsList(1).FillChar = " "
    '    tabStopsList(1).Position = 4700 ' 47 mm
    '    tabStopsList(1).Alignment = OOOstyleTabAlignCENTER
    '    tabStopsList(2).DecimalChar = ","
    '    tabStopsList(2).FillChar = " "
    '    tabStopsList(2).Position = 7010 ' 70,1 mm
    '    tabStopsList(2).Alignment = OOOstyleTabAlignRIGHT
    '    myCursor.ParaTabStops = tabStopsList
    '    ' utiliser ces tabulations
    '    ' use these tabulation stops
    '    Texte1 = "Début" & Tab & "Tab0" & Tab & "Tab1" & Tab & "Tab2" & Tab
    '    myText.insertString(myCursor, Texte1, False)
    '    myText.insertControlCharacter(myCursor, OOOtextControlCharacterPARAGRAPH_BREAK, False)
    '    ISTMessageBox.Show(OOoMess105)
    '    myDoc.close(True)
    'End Sub

    'Sub CalcSortingExample()
    '    Dim myDoc As Object, firstSheet As Object, aRange As Object
    '    Dim fields As Object, unoWrap As Object, sortDx As Object, n As Integer

    '    myDoc = StarDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, dummyArray)
    '    firstSheet = myDoc.Sheets.getByIndex(0)
    '    firstSheet.getCellRangeByName("A1").String = "Texts"
    '    firstSheet.getCellRangeByName("B1").String = "Values"
    '    Randomize()
    '    For n = 1 To 15
    '        firstSheet.getCellByPosition(0, n).String = "Row" & (n + 1)
    '        firstSheet.getCellByPosition(1, n).Value = Rnd() * 1000.0
    '    Next
    '    ISTMessageBox.Show(OOoMess107)
    '    aRange = firstSheet.getCellRangeByName("A1:B16")
    '    fields = CreateUnoStruct("com.sun.star.table.TableSortField", 0)
    '    fields(0).Field = 1
    '    fields(0).IsAscending = True
    '    fields(0).IsCaseSensitive = True

    '    ' il faut préciser quel type de séquence est transmis à la propriété SortFields
    '    ' you must specify which type of sequence is transmitted to SortFields property
    '    unoWrap = OpenOffice.Bridge_GetValueObject
    '    unoWrap.set("[]com.sun.star.table.TableSortField", fields)
    '    ' remplissage de SortDescriptor : propriétés ayant des valeurs autres que défaut
    '    ' filling of SortDescriptor : properties with non-default values
    '    sortDx = CreateProperties("ContainsHeader", True, "SortFields", unoWrap)

    '    aRange.sort(sortDx)
    '    ISTMessageBox.Show(OOoMess108)
    '    myDoc.close(True)
    'End Sub

    'Sub setCellBorders()
    '    Dim myDoc As Object, allSheets As Object, mySheet As Object
    '    Dim myCell As Object, oneBorder As Object

    '    myDoc = StarDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, dummyArray)
    '    ' un nouveau document Calc a toujours 3 feuilles
    '    ' a new Calc document always has 3 sheets
    '    allSheets = myDoc.Sheets
    '    mySheet = allSheets.getByIndex(2)  ' third sheet of the spreadsheet
    '    mySheet.Name = "test"  ' change its name
    '    myCell = mySheet.getCellRangeByName("C2")
    '    myCell.String = OOoMess111
    '    ' il faut créer une nouvelle structure Uno pour chaque bord,
    '    ' sinon les quatre bordures vont pointer sur la même structure Uno

    '    ' you must create a new Uno structure for each border
    '    ' otherwise all 4 borders will point at the same Uno structure
    '    oneBorder = CreateUnoStruct("com.sun.star.table.BorderLine")
    '    oneBorder.Color = RGB(200, 0, 0)
    '    oneBorder.OuterLineWidth = 30
    '    myCell.LeftBorder = oneBorder ' single red line
    '    oneBorder = CreateUnoStruct("com.sun.star.table.BorderLine")
    '    oneBorder.Color = RGB(200, 0, 0)
    '    oneBorder.OuterLineWidth = 100
    '    myCell.RightBorder = oneBorder ' single red line
    '    oneBorder = CreateUnoStruct("com.sun.star.table.BorderLine")
    '    oneBorder.Color = RGB(0, 120, 0)
    '    oneBorder.OuterLineWidth = 100
    '    oneBorder.InnerLineWidth = 60
    '    oneBorder.LineDistance = 30
    '    myCell.TopBorder = oneBorder ' double green line
    '    oneBorder = CreateUnoStruct("com.sun.star.table.BorderLine")
    '    oneBorder.Color = RGB(0, 0, 120)
    '    oneBorder.OuterLineWidth = 100
    '    oneBorder.InnerLineWidth = 60
    '    oneBorder.LineDistance = 30
    '    myCell.BottomBorder = oneBorder ' double blue line
    '    myDoc.CurrentController.ActiveSheet = mySheet  ' show this sheet
    '    ISTMessageBox.Show(OOoMess105)
    '    myDoc.close(True)
    'End Sub

    'Sub drawPolygon()
    '    Dim myDoc As Object, myPage As Object, myDrawing As Object, thePoints As Object
    '    Dim PolygonsList(0) As Object

    '    myDoc = StarDesktop.loadComponentFromURL("private:factory/sdraw", "_blank", 0, dummyArray)
    '    myPage = myDoc.DrawPages.getByIndex(0)
    '    ' invoquer un service à  partir d"un objet Uno
    '    ' invoke a service from a Uno object
    '    myDrawing = myDoc.createInstance("com.sun.star.drawing.PolyLineShape")
    '    myPage.add(myDrawing)
    '    myDrawing.LineWidth = 100
    '    myDrawing.LineColor = RGB(50, 200, 200)
    '    ' créer et remplir un tableau de structures pour l'affecter à une propriété
    '    ' create and fill an array of structures to assign it to a property
    '    thePoints = CreateUnoStruct("com.sun.star.awt.Point", 3)
    '    thePoints(0).X = 4000
    '    thePoints(0).Y = 2000
    '    thePoints(1).X = 4500
    '    thePoints(1).Y = 5000
    '    thePoints(2).X = 11500
    '    thePoints(2).Y = 8000
    '    thePoints(3).X = 6000
    '    thePoints(3).Y = 11000
    '    ' dans ce dessin : un seul polygone
    '    ' in this drawing : only one polygon
    '    PolygonsList(0) = thePoints
    '    myDrawing.PolyPolygon = PolygonsList
    '    ISTMessageBox.Show(OOoMess105)
    '    myDoc.close(True)
    'End Sub

    '' Ces séquences sont à usage interne, mais elles peuvent servir d'exemples
    '' These sequences are for internal use but may be useful as examples

    'Sub TestSequences()
    '    Dim myDoc As Object, v As Object, insp As Object, info2 As Object
    '    Dim myTest As Integer, c As Integer, c2 As Integer
    '    Dim m As String, p As String, p2 As String

    '    Do
    '        m = InputBox("Choose a test number", "COM_OOo tests", "0")
    '        If Not IsNumeric(m) Then myTest = 0 Else myTest = CInt(m)
    '        Select Case myTest
    '            Case 1 ' get an array of String from a Uno object (more than 800 items)
    '                v = OpenOffice.AvailableServiceNames
    '                ISTMessageBox.Show("Index max = " & UBound(v) & vbLf & "v(10) = " & v(10))
    '            Case 2 ' Convert to and from URL
    '                Do
    '                    m = InputBox("MS-Windows address", "COM_OOo tests", "")
    '                    If Len(m) = 0 Then Exit Do
    '                    p = convertToURL(m)
    '                    p2 = convertFromURL(p)
    '                    ISTMessageBox.Show(m & vbLf & p & vbLf & p2 & vbLf & vbLf & "Identity ? " & CBool(m = p2))
    '                Loop
    '            Case 3 ' color conversions
    '                Do
    '                    m = InputBox("Color value ", "COM_OOo tests", "0")
    '                    If Not IsNumeric(m) Then c = 0 Else c = CInt(m)
    '                    c2 = OOoRGB(Red(c), Green(c), Blue(c))
    '                    ISTMessageBox.Show("Color : " & c & vbLf & "Red = " & Red(c) _
    '                      & vbLf & "Green = " & Green(c) & vbLf & "Blue = " & Blue(c) _
    '                      & vbLf & "OOoRGB(R,G,B) : " & c2 & vbLf & vbLf & "Identity ? " & CBool(c = c2))
    '                Loop Until c = 0
    '            Case 20 ' CreateUnoStruct, one structure
    '                v = CreateUnoStruct("com.sun.star.table.BorderLine")
    '                v.Color = 12345
    '                ISTMessageBox.Show("Color : " & v.Color)
    '            Case 21 ' CreateUnoStruct, array of structures
    '                v = CreateUnoStruct("com.sun.star.table.BorderLine", 3)
    '                c = UBound(v)
    '                v(0).Color = 54321
    '                v(c).OuterLineWidth = 147
    '                ISTMessageBox.Show("Index max : " & c & vbLf & "Color : " & v(0).Color _
    '                  & vbLf & "OuterLineWidth : " & v(c).OuterLineWidth)
    '            Case 30 ' MakePropertyValue
    '                v = MakePropertyValue("Height", 175)
    '                ISTMessageBox.Show("Property name : " & v.Name)
    '            Case 40 ' CreateProperties
    '                v = CreateProperties("Width", 369, "PrintNotes", True, "Title", "Hello")
    '                c = UBound(v)
    '                ISTMessageBox.Show("Index max : " & c & vbLf & v(0).Name & " : " & v(0).Value _
    '                    & vbLf & v(1).Name & " : " & v(1).Value & vbLf & v(c).Name & " : " & v(c).Value)
    '        End Select
    '        If (myTest >= 100) And (myTest < 200) Then ' Writer document is needed
    '            myDoc = StarDesktop.LoadComponentFromURL("private:factory/swriter", "_blank", 0, dummyArray)
    '            ISTMessageBox.Show("Document is displayed")
    '            Select Case myTest
    '                Case 101 ' HasUnoInterfaces
    '                    ISTMessageBox.Show("All interfaces supported ? " & HasUnoInterfaces(myDoc, _
    '                      "com.sun.star.frame.XStorable", _
    '                      "com.sun.star.style.XAutoStylesSupplier", _
    '                      "com.sun.star.text.XTextGraphicObjectsSupplier"))
    '                Case 110 ' dispatcher
    '                    v = CreateProperties("Text", "Hello World !")
    '                    execDispatch(".uno:InsertText", v)
    '                    execDispatch(".uno:InsertPara", dummyArray)
    '                Case 111 ' Clipboard
    '                    ISTMessageBox.Show("Select something")
    '                    copyToClipboard()
    '                    ISTMessageBox.Show("Put cursor elsewhere")
    '                    pasteFromClipboard()
    '                Case 120 ' runBasicMacro
    '                    ISTMessageBox.Show("Manually load the document testScript.odt with macros enabled")
    '                    runBasicMacro("Standard.Module1.convertDevise", "73.5, 6.55957, Euros", "testScript")
    '                Case 130 ' run script residing in "OpenOffice.org Macros"
    '                    runScript("HelloWorld.helloworld.bsh", dummyArray, "BeanShell", "share")
    '                Case 131 ' get returned value from a script
    '                    ISTMessageBox.Show("Using resident macro : Standard.Testage.MultiplyByPi")
    '                    Dim args(0) As Object
    '                    args(0) = 67
    '                    v = runScript("Standard.Testage.MultiplyByPi", args)
    '                    ISTMessageBox.Show("Result from macro : " & v)
    '                Case 140
    '                    xray(myDoc)
    '                Case 150 ' checks that print method is not intercepted by the VB interpreter
    '                    myDoc.print(dummyArray)
    '                Case 151 ' check UBound for an empty array
    '                    v = myDoc.TextTables.ElementNames
    '                    ISTMessageBox.Show("index max : " & UBound(v))
    '                Case 152 ' check that a Null object is recognized
    '                    v = myDoc.TextTables
    '                    ISTMessageBox.Show("TextTables object is Null ? " & isNullEmpty(v))
    '                    v = myDoc.XForms
    '                    ISTMessageBox.Show("XForms object is Null ? " & isNullEmpty(v))
    '                Case 160 ' this may not work if OpenOffice Registry is incorrect
    '                    insp = OOoIntrospection.inspect(myDoc)
    '                    info2 = insp.getProperty("ApplyFormDesignMode", -1)
    '                    v = info2.Type
    '                    m = v.Name  ' check that v is a com.sun.star.beans.Property
    '                    ISTMessageBox.Show("info2.Type.Name = boolean ? " & CBool(m = "boolean"))
    '            End Select
    '            ISTMessageBox.Show("Document will close")
    '            myDoc.Close(True)
    '        End If
    '    Loop Until myTest = 0

    'End Sub

End Module