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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MyDataGrid1 As MyDataGridControl.MyDataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.MyDataGrid1 = New MyDataGridControl.MyDataGrid
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Валидни интервали за временску тачку:"
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.AlternatingBackColor = System.Drawing.Color.PowderBlue
        Me.MyDataGrid1.BackColor = System.Drawing.Color.GhostWhite
        Me.MyDataGrid1.BackgroundColor = System.Drawing.Color.Lavender
        Me.MyDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MyDataGrid1.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.MyDataGrid1.CaptionFont = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.MyDataGrid1.Location = New System.Drawing.Point(14, 38)
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.MyDataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGrid1.SelectionBackColor = System.Drawing.Color.Teal
        Me.MyDataGrid1.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.MyDataGrid1.Size = New System.Drawing.Size(301, 186)
        Me.MyDataGrid1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(116, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Излаз"
        '
        'FormIntervaliVremenskeTacke
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(330, 289)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MyDataGrid1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIntervaliVremenskeTacke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Интервали за временску тачку"
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mti As New DatasetIntervaliVremenskeTacke.IntervaliDataTable
    Public zvvt As Date

    Public Overloads Sub Dispose()
        Me.mti.Dispose()
        MyBase.Dispose()
    End Sub

    Public Sub New(ByVal ds As DatasetIstrazivanja, ByVal txtpismo As String)
        Me.New()
        Dim it() As vi = {}

        If txtpismo.ToUpper.Trim = "LAT" Then Call sveuLAT()

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
        Me.mti.VodColumn.Caption = "Važi od"
        Me.mti.VdoColumn.Caption = "Važi do"
        Me.MyDataGrid1.DataSource = Me.mti
        Me.MyDataGrid1.MyAutoFit(Me.mti.TableName, True)
        Me.MyDataGrid1.MySetColumnHeaderTextStyle(MyDataGridControl.MyDataGrid.eColumnHeaderTextStyle.eDescription)
    End Sub


End Class