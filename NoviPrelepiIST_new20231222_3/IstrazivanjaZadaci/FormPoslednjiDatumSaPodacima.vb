Option Strict Off
Imports System.Data
Imports System.Windows.Forms
Imports System
Imports System.Runtime.InteropServices


Friend Class FormPoslednjiDatumSaPodacima
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

    Friend WithEvents dgv As DataGridView
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label
    'Friend WithEvents lblPDSPText As System.Windows.Forms.Label


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPoslednjiDatumSaPodacima))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 40)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(809, 460)
        Me.dgv.TabIndex = 127
        Me.dgv.TabStop = False
        Me.dgv.Text = "dgvGreske"
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(809, 40)
        Me.PanelTop.TabIndex = 217
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.Transparent
        Me.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b3.FlatAppearance.BorderSize = 0
        Me.b3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ForeColor = System.Drawing.Color.DarkOrange
        Me.b3.Location = New System.Drawing.Point(10, 4)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(370, 32)
        Me.b3.TabIndex = 185
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(769, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Logovan
        '
        Me.Logovan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(560, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormPoslednjiDatumSaPodacima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(809, 500)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPoslednjiDatumSaPodacima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '*******
    Private originalExStyle As Integer = -1
    Private enableFormLevelDoubleBuffering As Boolean = True
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            If originalExStyle = -1 Then originalExStyle = MyBase.CreateParams.ExStyle
            Dim cp As CreateParams = MyBase.CreateParams

            If enableFormLevelDoubleBuffering Then
                cp.ExStyle = cp.ExStyle Or &H2000000
            Else
                cp.ExStyle = originalExStyle
            End If
            Return cp
        End Get
    End Property
    Public Sub TurnOffFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = False
        'Me.MaximizeBox = True
    End Sub
    Public Sub TurnOnFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = True
        ' Me.MaximizeBox = True
    End Sub
    Private Sub Form_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        TurnOnFormLevelDoubleBuffering()
    End Sub

    Private Sub Form_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        TurnOffFormLevelDoubleBuffering()
    End Sub
    '*******
    Dim jezik As String
    Public zvvt As Date
    Dim mti As New DatasetIntervaliVremenskeTacke.IntervaliDataTable
    Dim DBConnectionString As String
    Dim strsql As String
    Dim tnn As String

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Public Sub New(ByVal ds As DatasetIstrazivanja, ByVal txtpismo As String, ByVal jezik As String, ByVal DBConnectionString As String, ByVal strsql As String, ByVal tnn As String)
        Me.New()
        Dim it() As vi = {}
        Me.DBConnectionString = DBConnectionString
        Me.strsql = strsql
        Me.tnn = tnn
        Me.jezik = jezik
        Me.Logovan.Text = GetUserName.ToString.Trim
        Call SetLang()

        Me.jezik = jezik


        Call dajPodatkeZaGrid()
        Call srediGridView(Me.dgv, True, 50,,,,,,, 1)

    End Sub
    Sub dajPodatkeZaGrid()

        Dim ti As New System.Data.DataTable
        Dim cs As System.Data.DataColumn

        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
        Dim colTab As String = getControlText2(dt, "colTab", Me.jezik)
        Dim colLastDate As String = getControlText2(dt, "colLastDate", Me.jezik)
        Dim colLastYear As String = "Year"
        Dim colLastMonth As String = "Month"

        ti.Columns.Add(colTab)

        Dim t5 As New DatasetIntervaliVremenskeTacke.IzvestajDataTable

        Dim zvvt As Object = System.DBNull.Value
        Dim zvgod As Object = System.DBNull.Value
        Dim zvmes As Object = System.DBNull.Value
        Dim dspom As New System.Data.DataSet
        Dim tn() As String = tnn.Split(";")
        dspom = izvrsiSQLvratiDS(strsql, Me.DBConnectionString, Me.jezik)

        For i As Integer = 0 To dspom.Tables.Count - 1
            Dim sql As String = ""
            Dim t As DataTable = dspom.Tables(i)
            ti.TableName = tn(i)
            Dim vo As String = IstrazivanjeZadaci.mds.IST.VodColumn.ColumnName
            Dim vd As String = IstrazivanjeZadaci.mds.IST.VdoColumn.ColumnName
            If Not t.Columns(vo) Is Nothing AndAlso Not t.Columns(vd) Is Nothing Then
                If ti.Columns(colLastDate) Is Nothing Then
                    cs = ti.Columns.Add(colLastDate, GetType(Date))
                End If

                Dim ii As New vi
                sql = "select " + vo + "," + vd + " from " + tn(i)

                Dim dtpom As System.Data.DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
                Try
                    For j As Integer = 0 To dt.Rows.Count - 1
                        If Not dt.Rows(j).Item(vo) Is System.DBNull.Value AndAlso Not dt.Rows(j).Item(vd) Is System.DBNull.Value Then
                            Dim h As New vi.int(CType(dt.Rows(j).Item(vo), Date), CType(dt.Rows(j).Item(vd), Date))
                            ii.ini(h)
                        End If
                    Next
                Catch ex As System.Exception
                    Throw ex
                End Try
                If ii.Count > 0 Then
                    ii = New vi(ii)
                    zvvt = ii.datum
                End If
            Else
                If ti.Columns(colLastYear) Is Nothing Then
                    cs = ti.Columns.Add(colLastYear, GetType(String))
                End If
                If ti.Columns(colLastMonth) Is Nothing Then
                    cs = ti.Columns.Add(colLastMonth, GetType(String))
                End If

                Dim kreni As Boolean = False
                If Not t.Columns("GOD") Is Nothing AndAlso Not t.Columns("MES") Is Nothing Then
                    sql = "select max(GOD) as Year,max(MES) as Month from " + tn(i)
                    kreni = True
                ElseIf Not t.Columns("GOD") Is Nothing AndAlso t.Columns("MES") Is Nothing Then
                    sql = "select max(GOD) as Year,'-' as Month from " + tn(i)
                    kreni = True
                ElseIf Not t.Columns("ISTYEAR") Is Nothing AndAlso Not t.Columns("ISTMONTH") Is Nothing Then
                    sql = "select max(ISTYEAR) as Year,max(ISTMONTH) from " + tn(i)
                    kreni = True
                ElseIf Not t.Columns("ISTYEAR") Is Nothing AndAlso t.Columns("ISTMONTH") Is Nothing Then
                    sql = "select max(ISTYEAR) as Year, '-' as Month from " + tn(i)
                    kreni = True
                ElseIf t.Columns("GOD") Is Nothing AndAlso t.Columns("MES") Is Nothing Then
                    sql = "select '-' as Year, '-' as Month "
                    kreni = True
                ElseIf t.Columns("ISTYEAR") Is Nothing AndAlso t.Columns("ISTMONTH") Is Nothing Then
                    sql = "select '-' as Year, '-' as Month "
                    kreni = True
                End If
                If kreni = True Then
                    Dim dtt As System.Data.DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Me.jezik)
                    If dtt.Rows.Count > 0 Then
                        zvgod = dtt.Rows(0).Item("Year")
                        zvmes = dtt.Rows(0).Item("Month")
                    End If
                End If
            End If
            ti.Rows.Add(New Object() {tn(i), zvgod, zvmes})
        Next
        ti.AcceptChanges()
        ti.DefaultView.AllowNew = False
        dgv.DataSource = ti


    End Sub
    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
        Me.b3.Text = getControlText2(dt, "lblBSText", Me.jezik)


    End Sub

    Private Sub FormPoslednjiDatumSaPodacima_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call setTheme(GetTheme())

    End Sub
    Sub setTheme(ByVal theme As String)
        If theme = "L" Then
            ISTTheme.ChosenTheme("Light")

            PanelTop.BackColor = ISTTheme.PanelParent
        Else
            ISTTheme.ChosenTheme("Dark")

            PanelTop.BackColor = ISTTheme.PanelParent
        End If
    End Sub


End Class