'Option Strict Off


Public Class mFormAppereanceLBL
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chbRight As CheckBox
    Friend WithEvents chbCentar As CheckBox
    Friend WithEvents chbFB As CheckBox
    Friend WithEvents chbItalic As CheckBox
    Friend WithEvents chbFU As CheckBox
    Friend WithEvents tbFSize As TrackBar
    Friend WithEvents chbFSize As CheckBox
    Friend WithEvents ttekst As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Mkc_ColorCombobox2T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox1T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbBC As CheckBox
    Friend WithEvents cbFC As CheckBox
    Friend WithEvents cbN As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtVS1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chbRight = New System.Windows.Forms.CheckBox()
        Me.chbCentar = New System.Windows.Forms.CheckBox()
        Me.chbFB = New System.Windows.Forms.CheckBox()
        Me.chbItalic = New System.Windows.Forms.CheckBox()
        Me.chbFU = New System.Windows.Forms.CheckBox()
        Me.tbFSize = New System.Windows.Forms.TrackBar()
        Me.chbFSize = New System.Windows.Forms.CheckBox()
        Me.ttekst = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Mkc_ColorCombobox2T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox1T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbBC = New System.Windows.Forms.CheckBox()
        Me.cbFC = New System.Windows.Forms.CheckBox()
        Me.cbN = New System.Windows.Forms.CheckBox()
        Me.txtVS1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(355, 3)
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
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label appereance"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 320)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 30)
        Me.Panel1.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCancel.Location = New System.Drawing.Point(239, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.HP.SetHelpString(Me.pb1, "aaa")
        Me.pb1.ImageLocation = ""
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.HP.SetShowHelp(Me.pb1, True)
        Me.pb1.Size = New System.Drawing.Size(542, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(9, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Appereance"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(20, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Font"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(9, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Text aligment"
        '
        'chbRight
        '
        Me.chbRight.AccessibleName = "lRightA"
        Me.chbRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRight.Location = New System.Drawing.Point(9, 43)
        Me.chbRight.Name = "chbRight"
        Me.chbRight.Size = New System.Drawing.Size(82, 19)
        Me.chbRight.TabIndex = 271
        Me.chbRight.Text = "Right"
        '
        'chbCentar
        '
        Me.chbCentar.AccessibleName = "lCenterA"
        Me.chbCentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCentar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCentar.Location = New System.Drawing.Point(9, 68)
        Me.chbCentar.Name = "chbCentar"
        Me.chbCentar.Size = New System.Drawing.Size(82, 19)
        Me.chbCentar.TabIndex = 270
        Me.chbCentar.Text = "Center"
        '
        'chbFB
        '
        Me.chbFB.AccessibleName = "fontBold"
        Me.chbFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFB.Location = New System.Drawing.Point(9, 143)
        Me.chbFB.Name = "chbFB"
        Me.chbFB.Size = New System.Drawing.Size(60, 19)
        Me.chbFB.TabIndex = 263
        Me.chbFB.Text = "Bold"
        '
        'chbItalic
        '
        Me.chbItalic.AccessibleName = "fontItalic"
        Me.chbItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbItalic.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbItalic.Location = New System.Drawing.Point(75, 143)
        Me.chbItalic.Name = "chbItalic"
        Me.chbItalic.Size = New System.Drawing.Size(56, 19)
        Me.chbItalic.TabIndex = 262
        Me.chbItalic.Text = "Italic"
        '
        'chbFU
        '
        Me.chbFU.AccessibleName = "fontUnderline"
        Me.chbFU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFU.Location = New System.Drawing.Point(136, 143)
        Me.chbFU.Name = "chbFU"
        Me.chbFU.Size = New System.Drawing.Size(92, 19)
        Me.chbFU.TabIndex = 261
        Me.chbFU.Text = "Underline"
        '
        'tbFSize
        '
        Me.tbFSize.AccessibleName = ""
        Me.tbFSize.LargeChange = 1
        Me.tbFSize.Location = New System.Drawing.Point(100, 168)
        Me.tbFSize.Maximum = 20
        Me.tbFSize.Minimum = 7
        Me.tbFSize.Name = "tbFSize"
        Me.tbFSize.Size = New System.Drawing.Size(84, 45)
        Me.tbFSize.TabIndex = 285
        Me.tbFSize.TabStop = False
        Me.tbFSize.Tag = "8"
        Me.tbFSize.Value = 7
        Me.tbFSize.Visible = False
        '
        'chbFSize
        '
        Me.chbFSize.AccessibleName = ""
        Me.chbFSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFSize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFSize.Location = New System.Drawing.Point(9, 168)
        Me.chbFSize.Name = "chbFSize"
        Me.chbFSize.Size = New System.Drawing.Size(84, 19)
        Me.chbFSize.TabIndex = 284
        Me.chbFSize.Text = "Font size"
        '
        'ttekst
        '
        Me.ttekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ttekst.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttekst.Location = New System.Drawing.Point(355, 46)
        Me.ttekst.Multiline = True
        Me.ttekst.Name = "ttekst"
        Me.ttekst.Size = New System.Drawing.Size(175, 44)
        Me.ttekst.TabIndex = 286
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(295, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 287
        Me.Label8.Text = "Text"
        '
        'Mkc_ColorCombobox2T
        '
        Me.Mkc_ColorCombobox2T.AccessibleName = ""
        Me.Mkc_ColorCombobox2T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox2T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox2T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox2T.Location = New System.Drawing.Point(100, 230)
        Me.Mkc_ColorCombobox2T.Name = "Mkc_ColorCombobox2T"
        Me.Mkc_ColorCombobox2T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox2T.Size = New System.Drawing.Size(150, 21)
        Me.Mkc_ColorCombobox2T.TabIndex = 291
        Me.Mkc_ColorCombobox2T.Tag = "VF"
        Me.Mkc_ColorCombobox2T.Visible = False
        '
        'Mkc_ColorCombobox1T
        '
        Me.Mkc_ColorCombobox1T.AccessibleName = ""
        Me.Mkc_ColorCombobox1T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox1T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox1T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox1T.Location = New System.Drawing.Point(100, 210)
        Me.Mkc_ColorCombobox1T.Name = "Mkc_ColorCombobox1T"
        Me.Mkc_ColorCombobox1T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox1T.Size = New System.Drawing.Size(150, 21)
        Me.Mkc_ColorCombobox1T.TabIndex = 290
        Me.Mkc_ColorCombobox1T.Tag = "VF"
        Me.Mkc_ColorCombobox1T.Visible = False
        '
        'cbBC
        '
        Me.cbBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBC.Location = New System.Drawing.Point(9, 230)
        Me.cbBC.Name = "cbBC"
        Me.cbBC.Size = New System.Drawing.Size(92, 19)
        Me.cbBC.TabIndex = 289
        Me.cbBC.Text = "Back color"
        '
        'cbFC
        '
        Me.cbFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFC.Location = New System.Drawing.Point(9, 210)
        Me.cbFC.Name = "cbFC"
        Me.cbFC.Size = New System.Drawing.Size(92, 19)
        Me.cbFC.TabIndex = 288
        Me.cbFC.Text = "Fore color"
        '
        'cbN
        '
        Me.cbN.AccessibleName = ""
        Me.cbN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbN.Location = New System.Drawing.Point(355, 96)
        Me.cbN.Name = "cbN"
        Me.cbN.Size = New System.Drawing.Size(176, 19)
        Me.cbN.TabIndex = 292
        Me.cbN.Text = "Without DB colum name "
        '
        'txtVS1
        '
        Me.txtVS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVS1.Location = New System.Drawing.Point(419, 171)
        Me.txtVS1.Name = "txtVS1"
        Me.txtVS1.Size = New System.Drawing.Size(110, 21)
        Me.txtVS1.TabIndex = 293
        Me.txtVS1.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(419, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 294
        Me.Label7.Text = "Width"
        Me.Label7.Visible = False
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.Label4)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.chbFU)
        Me.gb1.Controls.Add(Me.Mkc_ColorCombobox2T)
        Me.gb1.Controls.Add(Me.chbItalic)
        Me.gb1.Controls.Add(Me.Mkc_ColorCombobox1T)
        Me.gb1.Controls.Add(Me.chbFB)
        Me.gb1.Controls.Add(Me.cbBC)
        Me.gb1.Controls.Add(Me.chbCentar)
        Me.gb1.Controls.Add(Me.cbFC)
        Me.gb1.Controls.Add(Me.chbRight)
        Me.gb1.Controls.Add(Me.chbFSize)
        Me.gb1.Controls.Add(Me.tbFSize)
        Me.gb1.Location = New System.Drawing.Point(12, 31)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(266, 263)
        Me.gb1.TabIndex = 295
        Me.gb1.TabStop = False
        '
        'mFormAppereanceLBL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(542, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.txtVS1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ttekst)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormAppereanceLBL"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Appereance"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim pp() As String
    Dim tk As Boolean
    Dim lbl As Boolean
    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal lbl As Boolean, ByVal tk As Boolean)
        InitializeComponent()
        _parentForm = form
        Me.AccessibleName = ""
        Me.sifist = sifist
        Me.lbl = lbl
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.tk = tk
        If tk = True Then
            Label7.Visible = True
            txtVS1.Visible = True
            Me.gb1.Enabled = False
        End If
        Me.dIst = dIst
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        If lbl = True AndAlso tk = False Then 'labela
            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    getMetaDataPaneP4()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
            Me.Label1.Text = "Label appereance " + pp(2).Trim
        End If
        If lbl = False AndAlso tk = True Then 'pk
            Dim dt As System.Data.DataTable = getDTK()
            If dt.Rows.Count = 1 Then
                txtVS1.Text = dt.Rows(0).Item("vs").ToString.Trim
            End If
            Dim dtO As System.Data.DataTable = getDTC()
            Call getVariablesC(dtO)
            If label.Trim.Substring(0, 1) = "$" Then
                Me.cbN.Checked = True
            Else
                Me.cbN.Checked = False
            End If
            Me.ttekst.Text = label.Replace("$", "")
            Me.Label1.Text = "Appereance " + pp(2).Trim
        End If
        If lbl = True AndAlso tk = True Then 'labela iz PK
            Dim dt As System.Data.DataTable = getDTC()
            Call getVariablesC(dt)
            Me.Label1.Text = "Label appereance " + pp(2).Trim
        End If

    End Sub

    Dim label As String = ""
    Dim tkvs As String = ""

    Function getDTC() As System.Data.DataTable
        Dim strSQl As String = "select label " +
                " from _ISTTablesColumns " +
                " where appCode=N'" + sifist + "' and tableName=N'" + pp(0).Trim + "' and columnName=N'" + pp(2).Trim + "'" +
                " and cast (validFrom as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function
    Function getDTK() As System.Data.DataTable
        'samo vs za sad

        Dim strSQl As String = "select vs " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"


        getDTK = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        If dt.Rows.Count > 0 Then
            label = dt.Rows(0).Item("label").ToString.Trim
        Else
            label = "..."
        End If

    End Sub
    Sub getVariablesVS(ByVal dt As System.Data.DataTable)
        If dt.Rows.Count > 0 Then
            tkvs = dt.Rows(0).Item("vs").ToString.Trim
        Else
            tkvs = "100"
        End If

    End Sub
    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

        Dim strU As String = "update istpolja "
        Dim strS As String = ""
        Dim strIST As String = ""
        Dim strW As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor
            strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                "' and polje=N'" + pp(2).Trim + "'" +
                "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
            'labela ili polje u kljucu

            If Me.tk = False Then
                Dim popis As String = setMetaDataPaneP4()
                If popis.Trim <> "" Then
                    popis = popis.Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
                    strS = strS + " set opis=N'" + popis + "'"
                End If
            End If
            If Me.tk = True Then
                Dim vs As String = "100"
                Dim popis As String = ""
                If ttekst.Text <> "" Then popis = Me.ttekst.Text.Trim
                If Me.cbN.Checked = True Then popis = "$" + popis
                If popis.Trim <> "" Then
                    popis = popis.Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
                    strS = " set opis=N'" + popis + "'"
                End If
                If txtVS1.Text <> "" AndAlso IsNumeric(txtVS1.Text) Then
                    vs = txtVS1.Text
                End If
                If popis <> "" Then
                    strS = strS + ", vs='" + txtVS1.Text + "'"
                Else
                    strS = "set vs='" + vs + "'"
                End If
            End If

            strIST = strU + nvrd + strS + nvrd + strW
            'Dim pI As String = izvrsiSQL(strIST, Me.ISTConnectionString)

            Dim pI As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strIST)

            If pI = "ok" Then
                Me.Cursor = Cursors.Default
                Me.Close()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Function setMetaDataPaneP4() As String
        'izraz
        Dim pom As String = ""

        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim + "$"
            End If
        Next

        If Mkc_ColorCombobox2T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox2T.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox1T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox1T.SelectedColor = Color.Chocolate

        If Mkc_ColorCombobox2T.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox2T.SelectedColor = Color.Snow
        'If Mkc_ColorComboboxFC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxBC.SelectedColor = Color.Snow

        If cbN.Checked = True Then pom = "$" + pom + "$"
        If cbFC.Checked = True AndAlso Mkc_ColorCombobox1T.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorCombobox1T.SelectedColor.Name + "$"
        If cbBC.Checked = True AndAlso Mkc_ColorCombobox2T.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorCombobox2T.SelectedColor.Name + "$"

        If chbRight.Checked = True Then pom = pom + "LRIGHTA" + "$"
        If chbCentar.Checked = True Then pom = pom + "LCENTERA" + "$"

        If chbFB.Checked = True Then pom = pom + "FONTBOLD" + "$"
        If chbItalic.Checked = True Then pom = pom + "FONTITALIC" + "$"
        If chbFU.Checked = True Then pom = pom + "FONTUNDERLINE" + "$"

        If chbFSize.Checked = True Then
            Dim ffs As String = "8"
            Dim fs As Integer = CInt(tbFSize.Value.ToString())
            ffs = CStr(fs).Trim
            pom = pom + "fontSize" + ffs + "$"
        End If

        If ttekst.Text <> "" Then pom = pom + "" + ttekst.Text.TrimStart("'").TrimEnd("'") + ""

        Return pom
    End Function

    Private Sub chbFSize_CheckedChanged(sender As Object, e As EventArgs) Handles chbFSize.CheckedChanged
        Me.tbFSize.Visible = chbFSize.Checked
    End Sub

    Sub getMetaDataPaneP4()

        Dim multilineheight As String = ""
        Dim forecolor As String = ""
        Dim backcolor As String = ""
        Dim lllabel As String = label
        If lllabel.Trim = "" Then Exit Sub
        Dim naslovFontSize As String = ""

        Dim pp() As String = lllabel.Split("$")
        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i).Trim = "" Then
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") >= 0 Then
                cbFC.Checked = True
                Dim fc As String = getttt(pp(i), "FORECOLOR")
                If fc <> "" Then Mkc_ColorCombobox1T.SelectedColor = Color.FromName(fc)
                'naslovForeColor = fc
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") >= 0 Then
                cbBC.Checked = True
                Dim bc As String = getttt(pp(i), "BACKCOLOR")
                If bc <> "" Then Mkc_ColorCombobox2T.SelectedColor = Color.FromName(bc)
                'naslovBackColor = bc
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                chbFB.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                chbItalic.Checked = True
            ElseIf pp(i).Length > 12 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTUNDERLINE") = 0 Then
                chbFU.Checked = True
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("LRIGHTA") = 0 Then
                chbRight.Checked = True
            ElseIf pp(i).Length > 7 AndAlso (pp(i).Trim.ToUpper.IndexOf("LCENTERA") = 0 OrElse pp(i).Trim.ToUpper.IndexOf("LCENTREA") = 0) Then
                chbCentar.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTSIZE") = 0 Then
                Dim fs As Integer = CInt(pp(i).Trim.ToUpper.Replace("FONTSIZE", ""))
                chbFSize.Checked = True
                tbFSize.Value = fs
                naslovFontSize = CStr(fs).Trim
            ElseIf pp(i).Trim <> "" Then
                ttekst.Text = pp(i).Trim.TrimStart("'").TrimEnd("'")
            End If
        Next

        If lllabel.IndexOf("$") = 0 Then
            cbN.Checked = True
        Else
            cbN.Checked = False
        End If

    End Sub
    Private Sub cbFC_CheckedChanged(sender As Object, e As EventArgs) Handles cbFC.CheckedChanged
        Mkc_ColorCombobox1T.Visible = cbFC.Checked
        If cbFC.Checked = False Then Mkc_ColorCombobox1T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbBC_CheckedChanged(sender As Object, e As EventArgs) Handles cbBC.CheckedChanged
        Mkc_ColorCombobox2T.Visible = cbBC.Checked
        If cbBC.Checked = False Then Mkc_ColorCombobox2T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.AccessibleName = "cancel"
        Me.Close()
    End Sub
End Class