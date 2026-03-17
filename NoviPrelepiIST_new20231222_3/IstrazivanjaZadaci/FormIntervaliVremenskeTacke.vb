Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class FormIntervaliVremenskeTacke
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
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
    Friend WithEvents lblVIText As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Logovan As System.Windows.Forms.Label
    Friend WithEvents b3 As Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIntervaliVremenskeTacke))
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
        Me.dgv.TabIndex = 212
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
        Me.PanelTop.TabIndex = 214
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
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
        'FormIntervaliVremenskeTacke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.ClientSize = New System.Drawing.Size(809, 500)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIntervaliVremenskeTacke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
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

    Dim mti As New DatasetIntervaliVremenskeTacke.IntervaliDataTable
    Public zvvt As Date

    Public Overloads Sub Dispose()
        Me.mti.Dispose()
        MyBase.Dispose()
    End Sub

    Public jezik As String

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Public Sub New(ByVal ds As DatasetIstrazivanja, ByVal txtpismo As String, ByVal jezik As String)
        Me.New()
        Dim it() As vi = {}
        Me.Logovan.Text = GetUserName.ToString.Trim
        Me.jezik = jezik
        Call SetLang()

        Me.jezik = jezik
        For Each t As System.Data.DataTable In ds.Tables
            If Not t.Columns(ds.IST.VodColumn.ColumnName) Is Nothing AndAlso Not t.Columns(ds.IST.VdoColumn.ColumnName) Is Nothing Then
                Dim ii As New vi
                For Each r As System.Data.DataRow In t.Rows
                    If Not r.IsNull(ds.IST.VodColumn.ColumnName) AndAlso Not r.IsNull(ds.IST.VdoColumn.ColumnName) Then
                        Dim i As New vi.int(CType(r.Item(ds.IST.VodColumn.ColumnName), Date), CType(r.Item(ds.IST.VdoColumn.ColumnName), Date))
                        ii.ini(i)
                    End If
                Next
                ReDim Preserve it(1 + it.GetUpperBound(0))
                it(it.GetUpperBound(0)) = ii
            End If
        Next
        Dim vin As New vi(it, Me.mti)
        Me.zvvt = vin.datum
        Me.mti.DefaultView.AllowNew = False

        Call srediGridView(Me.dgv, True, 50,,,,,,, 1)

        Me.dgv.DataSource = Me.mti

    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
        Me.b3.Text = getControlText2(dt, "lblVIText", Me.jezik)
        Me.mti.VodColumn.Caption = getControlText2(dt, "naslov11", Me.jezik)
        Me.mti.VdoColumn.Caption = getControlText2(dt, "naslov12", Me.jezik)

    End Sub

    Private Sub FormIntervaliVremenskeTacke_Load(sender As Object, e As EventArgs) Handles Me.Load

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