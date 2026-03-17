'Option Strict Off
Public Class mFormAppereanceTab
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
    Friend WithEvents BtnFormat As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbFS As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Mkc_ColorCombobox2T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox1T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbBC As CheckBox
    Friend WithEvents cbFC As CheckBox
    Friend WithEvents cbN As CheckBox
    Friend WithEvents tbH As TrackBar
    Friend WithEvents cbH As CheckBox
    Friend WithEvents txtTL1 As TextBox
    Friend WithEvents cbAR As CheckBox
    Friend WithEvents cbI As CheckBox
    Friend WithEvents cbTBold As CheckBox
    Friend WithEvents cbTAC As CheckBox
    Friend WithEvents cbS As CheckBox
    Friend WithEvents cbTc4 As CheckBox
    Friend WithEvents cboBGCAT As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbU As CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.tbFS = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Mkc_ColorCombobox2T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox1T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbBC = New System.Windows.Forms.CheckBox()
        Me.cbFC = New System.Windows.Forms.CheckBox()
        Me.cbN = New System.Windows.Forms.CheckBox()
        Me.tbH = New System.Windows.Forms.TrackBar()
        Me.cbH = New System.Windows.Forms.CheckBox()
        Me.txtTL1 = New System.Windows.Forms.TextBox()
        Me.cbAR = New System.Windows.Forms.CheckBox()
        Me.cbI = New System.Windows.Forms.CheckBox()
        Me.cbTBold = New System.Windows.Forms.CheckBox()
        Me.cbTAC = New System.Windows.Forms.CheckBox()
        Me.cbS = New System.Windows.Forms.CheckBox()
        Me.cbTc4 = New System.Windows.Forms.CheckBox()
        Me.cboBGCAT = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbU = New System.Windows.Forms.CheckBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(512, 2)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(108, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.Text = "Set appereance"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Title and form background"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(646, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'tbFS
        '
        Me.tbFS.AccessibleName = "lHeight"
        Me.tbFS.LargeChange = 1
        Me.tbFS.Location = New System.Drawing.Point(139, 173)
        Me.tbFS.Maximum = 20
        Me.tbFS.Minimum = 6
        Me.tbFS.Name = "tbFS"
        Me.tbFS.Size = New System.Drawing.Size(84, 45)
        Me.tbFS.TabIndex = 163
        Me.tbFS.TabStop = False
        Me.tbFS.Tag = "8"
        Me.tbFS.Value = 8
        Me.tbFS.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(43, 64)
        Me.txtTitle.MaxLength = 1250
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(577, 68)
        Me.txtTitle.TabIndex = 161
        '
        'Mkc_ColorCombobox2T
        '
        Me.Mkc_ColorCombobox2T.AccessibleName = ""
        Me.Mkc_ColorCombobox2T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox2T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox2T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox2T.Location = New System.Drawing.Point(355, 210)
        Me.Mkc_ColorCombobox2T.Name = "Mkc_ColorCombobox2T"
        Me.Mkc_ColorCombobox2T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox2T.Size = New System.Drawing.Size(150, 21)
        Me.Mkc_ColorCombobox2T.TabIndex = 160
        Me.Mkc_ColorCombobox2T.Tag = "VF"
        Me.Mkc_ColorCombobox2T.Visible = False
        '
        'Mkc_ColorCombobox1T
        '
        Me.Mkc_ColorCombobox1T.AccessibleName = ""
        Me.Mkc_ColorCombobox1T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox1T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox1T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox1T.Location = New System.Drawing.Point(355, 190)
        Me.Mkc_ColorCombobox1T.Name = "Mkc_ColorCombobox1T"
        Me.Mkc_ColorCombobox1T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox1T.Size = New System.Drawing.Size(150, 21)
        Me.Mkc_ColorCombobox1T.TabIndex = 159
        Me.Mkc_ColorCombobox1T.Tag = "VF"
        Me.Mkc_ColorCombobox1T.Visible = False
        '
        'cbBC
        '
        Me.cbBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBC.Location = New System.Drawing.Point(264, 210)
        Me.cbBC.Name = "cbBC"
        Me.cbBC.Size = New System.Drawing.Size(92, 19)
        Me.cbBC.TabIndex = 158
        Me.cbBC.Text = "Back color"
        '
        'cbFC
        '
        Me.cbFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFC.Location = New System.Drawing.Point(264, 190)
        Me.cbFC.Name = "cbFC"
        Me.cbFC.Size = New System.Drawing.Size(92, 19)
        Me.cbFC.TabIndex = 157
        Me.cbFC.Text = "Fore color"
        '
        'cbN
        '
        Me.cbN.AccessibleName = ""
        Me.cbN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbN.Location = New System.Drawing.Point(442, 153)
        Me.cbN.Name = "cbN"
        Me.cbN.Size = New System.Drawing.Size(204, 19)
        Me.cbN.TabIndex = 156
        Me.cbN.Text = "Without DB table name in title"
        '
        'tbH
        '
        Me.tbH.AccessibleName = "lHeight"
        Me.tbH.LargeChange = 1
        Me.tbH.Location = New System.Drawing.Point(351, 153)
        Me.tbH.Maximum = 5
        Me.tbH.Minimum = 1
        Me.tbH.Name = "tbH"
        Me.tbH.Size = New System.Drawing.Size(84, 45)
        Me.tbH.TabIndex = 155
        Me.tbH.TabStop = False
        Me.tbH.Tag = "1"
        Me.tbH.Value = 1
        Me.tbH.Visible = False
        '
        'cbH
        '
        Me.cbH.AccessibleName = ""
        Me.cbH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbH.Location = New System.Drawing.Point(264, 155)
        Me.cbH.Name = "cbH"
        Me.cbH.Size = New System.Drawing.Size(91, 19)
        Me.cbH.TabIndex = 152
        Me.cbH.Text = "Title height"
        '
        'txtTL1
        '
        Me.txtTL1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL1.Location = New System.Drawing.Point(0, 25)
        Me.txtTL1.Multiline = True
        Me.txtTL1.Name = "txtTL1"
        Me.txtTL1.ReadOnly = True
        Me.txtTL1.Size = New System.Drawing.Size(646, 20)
        Me.txtTL1.TabIndex = 148
        Me.txtTL1.TabStop = False
        Me.txtTL1.Tag = "VP"
        Me.txtTL1.Text = "Title"
        '
        'cbAR
        '
        Me.cbAR.AccessibleName = "lRightA"
        Me.cbAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAR.Location = New System.Drawing.Point(16, 242)
        Me.cbAR.Name = "cbAR"
        Me.cbAR.Size = New System.Drawing.Size(130, 19)
        Me.cbAR.TabIndex = 151
        Me.cbAR.Text = "Aligment right"
        '
        'cbI
        '
        Me.cbI.AccessibleName = "fontItalic"
        Me.cbI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbI.Location = New System.Drawing.Point(16, 173)
        Me.cbI.Name = "cbI"
        Me.cbI.Size = New System.Drawing.Size(72, 19)
        Me.cbI.TabIndex = 153
        Me.cbI.Text = "Italic"
        '
        'cbTBold
        '
        Me.cbTBold.AccessibleDescription = ""
        Me.cbTBold.AccessibleName = "fontBold"
        Me.cbTBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTBold.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTBold.Location = New System.Drawing.Point(16, 153)
        Me.cbTBold.Name = "cbTBold"
        Me.cbTBold.Size = New System.Drawing.Size(72, 19)
        Me.cbTBold.TabIndex = 149
        Me.cbTBold.Tag = ""
        Me.cbTBold.Text = "Bold"
        '
        'cbTAC
        '
        Me.cbTAC.AccessibleName = "lCenterA"
        Me.cbTAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTAC.Location = New System.Drawing.Point(16, 222)
        Me.cbTAC.Name = "cbTAC"
        Me.cbTAC.Size = New System.Drawing.Size(130, 19)
        Me.cbTAC.TabIndex = 150
        Me.cbTAC.Text = "Aligment center"
        '
        'cbS
        '
        Me.cbS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbS.Location = New System.Drawing.Point(139, 153)
        Me.cbS.Name = "cbS"
        Me.cbS.Size = New System.Drawing.Size(53, 19)
        Me.cbS.TabIndex = 154
        Me.cbS.Text = "Font size"
        '
        'cbTc4
        '
        Me.cbTc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTc4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTc4.Location = New System.Drawing.Point(16, 259)
        Me.cbTc4.Name = "cbTc4"
        Me.cbTc4.Size = New System.Drawing.Size(94, 72)
        Me.cbTc4.TabIndex = 277
        Me.cbTc4.Text = "Background color"
        '
        'cboBGCAT
        '
        Me.cboBGCAT.AccessibleName = ""
        Me.cboBGCAT.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.cboBGCAT.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.cboBGCAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBGCAT.Location = New System.Drawing.Point(119, 282)
        Me.cboBGCAT.Name = "cboBGCAT"
        Me.cboBGCAT.SelectedColor = System.Drawing.Color.Empty
        Me.cboBGCAT.Size = New System.Drawing.Size(220, 21)
        Me.cboBGCAT.TabIndex = 276
        Me.cboBGCAT.Tag = "VF"
        Me.cboBGCAT.Visible = False
        '
        'cbU
        '
        Me.cbU.AccessibleName = "fontUnderline"
        Me.cbU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbU.Location = New System.Drawing.Point(16, 194)
        Me.cbU.Name = "cbU"
        Me.cbU.Size = New System.Drawing.Size(117, 19)
        Me.cbU.TabIndex = 278
        Me.cbU.Text = "Underline"
        '
        'mFormAppereanceTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(646, 398)
        Me.Controls.Add(Me.cbU)
        Me.Controls.Add(Me.cbTc4)
        Me.Controls.Add(Me.cboBGCAT)
        Me.Controls.Add(Me.tbFS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Mkc_ColorCombobox2T)
        Me.Controls.Add(Me.Mkc_ColorCombobox1T)
        Me.Controls.Add(Me.cbBC)
        Me.Controls.Add(Me.cbFC)
        Me.Controls.Add(Me.cbN)
        Me.Controls.Add(Me.tbH)
        Me.Controls.Add(Me.cbH)
        Me.Controls.Add(Me.txtTL1)
        Me.Controls.Add(Me.cbAR)
        Me.Controls.Add(Me.cbI)
        Me.Controls.Add(Me.cbTBold)
        Me.Controls.Add(Me.cbTAC)
        Me.Controls.Add(Me.cbS)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormAppereanceTab"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " "
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim pp() As String
    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String)
        InitializeComponent()
        _parentForm = form
        With Me
            '.TopMost = True
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.dIst = dIst
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        Dim dt As System.Data.DataTable = getDTT()
        If dt.Rows.Count = 1 Then
            Call getVariablesT(dt)
            Try
                getMetaDataPaneT1()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        End If
        Me.Label1.Text = "Title and form background for " + pp(0).Trim
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

        Dim strIST As String = ""
        Dim strU As String = "update isttabele "
        Dim strS As String = ""
        Dim strW As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor
            'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
            'gde sam

            Dim pOpis As String = setMetaDataPaneT1()
            Dim pТ1 As String = setMetaDataPaneT2()
            strS = " set opis=N'" + pOpis + "', T1=N'" + pТ1 + "' " + nvrd
            strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

            strIST = strU + nvrd + strS + nvrd + strW

            Dim pI As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strIST)

            Me.Cursor = Cursors.Default

            If pI = "ok" Then
                ISTMessageBox.Show("Please refresh!")
                Me.Close()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim typeOfTableParentChild As String = ""
    Dim parentTableName As String = ""
    Dim ValidFrom As String = ""
    Dim ValidTo As String = ""
    Dim tableDescription As String = ""
    Dim tableOrder As String = ""

    Dim dataentryScreenOrder As String = ""
    Dim parentAtributes As String = ""
    Dim childAtributes As String = ""

    Dim tableDescriptionOst As String = ""
    Dim parentAtributesOst As String = ""

    Function getDTT() As DataTable
        typeOfTableParentChild = "" : parentTableName = "" : tableDescription = "" : dataentryScreenOrder = "" : tableOrder = ""
        parentAtributes = "" : childAtributes = "" : ValidFrom = "" : ValidTo = ""

        Dim strSQl As String = "select appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder," +
                "tableOrder,parentAtributes,childAtributes,ValidFrom,ValidTo from _ISTTables where appCode='" + sifist +
                "' and tableName='" + pp(0).Trim + "' and cast (validFrom as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTT = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesT(ByVal dt As DataTable)
        typeOfTableParentChild = dt.Rows(0).Item("typeOfTableParentChild").ToString.Trim
        parentTableName = dt.Rows(0).Item("parentTableName").ToString.Trim
        tableOrder = dt.Rows(0).Item("tableOrder").ToString.Trim
        tableDescription = dt.Rows(0).Item("tableDescription").ToString.Trim
        parentAtributes = dt.Rows(0).Item("parentAtributes").ToString.Trim
        childAtributes = dt.Rows(0).Item("childAtributes").ToString.Trim
        ValidFrom = CDate(dt.Rows(0).Item("VALIDFROM")).ToString("dd.MM.yyyy")
        ValidTo = CDate(dt.Rows(0).Item("VALIDTO")).ToString("dd.MM.yyyy")
        dataentryScreenOrder = dt.Rows(0).Item("dataentryScreenOrder").ToString.Trim
    End Sub

    Sub getMetaDataPaneT1()

        tableDescriptionOst = ""

        Dim opisG As String = tableDescription
        Dim pa As String = parentAtributes
        Dim naslovForeColor As String = ""
        Dim naslovBackColor As String = ""
        Dim naslovVisina As String = ""
        Dim naslovFontSize As String = ""
        Dim naslovBackGroundColor As String = ""

        If tableDescription.Trim = "" Then Exit Sub

        Dim pp() As String = tableDescription.Split("$")

        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i) = "" Then cbN.Checked = True
            If pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") >= 0 Then
                cbFC.Checked = True
                Dim fc As String = getttt(pp(i), "FORECOLOR")
                If fc <> "" Then Mkc_ColorCombobox1T.SelectedColor = Color.FromName(fc)
                naslovForeColor = fc
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") >= 0 Then
                cbBC.Checked = True
                Dim bc As String = getttt(pp(i), "BACKCOLOR")
                If bc <> "" Then Mkc_ColorCombobox2T.SelectedColor = Color.FromName(bc)
                naslovBackColor = bc
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                cbTBold.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                cbI.Checked = True
            ElseIf pp(i).Length > 12 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTUNDERLINE") = 0 Then
                cbU.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("LCENTERA") = 0 Then
                cbTAC.Checked = True
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("LRIGHTA") = 0 Then
                cbAR.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTSIZE") = 0 Then
                Dim fs As Integer = CInt(pp(i).Trim.ToUpper.Replace("FONTSIZE", ""))
                cbS.Checked = True
                tbFS.Value = fs
                naslovFontSize = getttt(pp(i), "FONTSIZE")
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("LHEIGHT") = 0 Then
                cbH.Checked = True
                Dim h As String = getttt(pp(i), "LHEIGHT")
                If IsNumeric(h.Trim) = True Then tbH.Value = CInt(h.Trim)
                naslovVisina = h
            ElseIf pp(i).Trim <> "" Then
                txtTitle.Text = pp(i)
                'Else
                '    tableDescriptionOst = tableDescriptionOst + "$" + pp(i).Trim
            End If
        Next

        opisG = Replace(opisG, "fontbold", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontitalic", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontunderline", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "ldesnop", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentarp", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lrighta", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentera", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "forecolor" + naslovForeColor.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "backcolor" + naslovBackColor.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontsize" + naslovFontSize.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lheight" + naslovVisina.ToLower, "", 1, , CompareMethod.Text)

        opisG = opisG.Replace("$$", "$")

        If opisG.IndexOf("$") >= 0 AndAlso opisG.Trim.Substring(0, 1) = "$" Then
            cbN.Checked = True
        ElseIf opisG.Length > 0 AndAlso opisG.IndexOf("$") < 0 Then
            cbN.Checked = False
        ElseIf opisG.Length = 0 Then
            cbN.Checked = True
        End If

        If parentAtributes.Trim = "" Then Exit Sub
        parentAtributesOst = ""
        Dim pp2() As String = parentAtributes.Split(";")
        For i As Integer = 0 To pp2.GetUpperBound(0)
            pp2(i) = pp2(i).Replace(vbCrLf, "").Trim
            If pp2(i).Length > 14 AndAlso pp2(i).Trim.ToUpper.IndexOf("BACKGROUNDCOLOR") >= 0 Then
                cbTc4.Checked = True
                Dim bgc As String = getttt(pp2(i), "BACKGROUNDCOLOR")
                If bgc <> "" Then cboBGCAT.SelectedColor = Color.FromName(bgc)
                naslovBackGroundColor = bgc
            ElseIf pp2(i) <> "" Then
                parentAtributesOst = parentAtributesOst + ";" + pp2(i).Trim
            End If
        Next
    End Sub

    'Function getttt(ByVal text As String, ByVal what As String) As String
    '    getttt = ""
    '    If text.Trim.ToUpper.IndexOf(what) >= 0 Then
    '        Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
    '        getttt = text.Trim.ToUpper.Substring(b + what.Length)
    '    End If
    'End Function
    Function setMetaDataPaneT1() As String

        Dim pom As String = ""

        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim + "$"
            End If
        Next

        If cbN.Checked = True Then pom = "$" + pom + "$"

        If Mkc_ColorCombobox2T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox2T.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox1T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox1T.SelectedColor = Color.Chocolate

        If Mkc_ColorCombobox2T.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox2T.SelectedColor = Color.Snow

        If cbFC.Checked = True AndAlso Mkc_ColorCombobox1T.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorCombobox1T.SelectedColor.Name + "$"
        If cbBC.Checked = True AndAlso Mkc_ColorCombobox2T.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorCombobox2T.SelectedColor.Name + "$"
        If txtTitle.Text.Trim <> "" Then pom = pom + txtTitle.Text + "$"

        Dim ffs As String = "8"
        Dim fs As Integer = CInt(tbFS.Value.ToString())
        ffs = CStr(fs).Trim
        pom = pom + "fontSize" + ffs + "$"

        Dim h As String = tbH.Value.ToString()
        If h > 1 Then pom = pom + "lHeight" + h + "$"
        pom = pom.Replace("$$", "$")

        If tableDescriptionOst.Trim = "" Then
            'pom
        ElseIf pom.Trim = "" AndAlso tableDescriptionOst.Trim <> "" Then
            pom = tableDescriptionOst
        ElseIf pom.Trim <> "" AndAlso tableDescriptionOst.Trim <> "" Then
            pom = pom + "$" + tableDescriptionOst
        End If

        Return pom
    End Function

    Function setMetaDataPaneT2() As String

        Dim pom As String = ""

        If cboBGCAT.SelectedColor.Name = "Chocalate" Then cboBGCAT.SelectedColor = Color.Chocolate
        If cboBGCAT.SelectedColor.Name = "Transparent" Then cboBGCAT.SelectedColor = Color.Snow

        If cbTc4.Checked = True AndAlso cboBGCAT.SelectedColor.Name <> "0" Then pom = pom + "backGroundColor" + cboBGCAT.SelectedColor.Name + ";"
        pom = pom.Replace(";;", ";")

        If parentAtributesOst.Trim = "" Then
            'pom
        ElseIf pom.Trim = "" AndAlso parentAtributesOst.Trim <> "" Then
            pom = parentAtributesOst
        ElseIf pom.Trim <> "" AndAlso parentAtributesOst.Trim <> "" Then
            pom = pom + ";" + parentAtributesOst
        End If

        Return pom
    End Function

    'If cboBGCAT.SelectedColor.Name <> "0" Then pa = pa + ";" + "backGroundColor" + cboBGCAT.SelectedColor.Name + ";"
    Private Sub cbTc4_CheckedChanged(sender As Object, e As EventArgs) Handles cbTc4.CheckedChanged
        cboBGCAT.Visible = cbTc4.Checked
        If cbTc4.Checked = False Then
            cboBGCAT.SelectedColor = System.Drawing.Color.Empty
        Else
            cboBGCAT.Focus()
        End If
    End Sub

    Private Sub cbS_CheckedChanged(sender As Object, e As EventArgs) Handles cbS.CheckedChanged
        tbFS.Visible = cbS.Checked
        If cbS.Checked = True Then tbFS.Value = tbFS.Tag
    End Sub

    Private Sub cbH_CheckedChanged(sender As Object, e As EventArgs) Handles cbH.CheckedChanged
        tbH.Visible = cbH.Checked
        If cbH.Checked = True Then tbH.Value = tbH.Tag
    End Sub

    Private Sub cbFC_CheckedChanged(sender As Object, e As EventArgs) Handles cbFC.CheckedChanged
        Mkc_ColorCombobox1T.Visible = cbFC.Checked
        If cbFC.Checked = False Then Mkc_ColorCombobox1T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbBC_CheckedChanged(sender As Object, e As EventArgs) Handles cbBC.CheckedChanged
        Mkc_ColorCombobox2T.Visible = cbBC.Checked
        If cbBC.Checked = False Then Mkc_ColorCombobox2T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbTAC_CheckedChanged(sender As Object, e As EventArgs) Handles cbTAC.CheckedChanged
        If cbTAC.Checked = True Then cbAR.Checked = False
    End Sub

    Private Sub cbAR_CheckedChanged(sender As Object, e As EventArgs) Handles cbAR.CheckedChanged
        If cbAR.Checked = True Then cbTAC.Checked = False
    End Sub

End Class