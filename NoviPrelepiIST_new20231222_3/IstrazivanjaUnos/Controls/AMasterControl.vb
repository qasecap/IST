Imports System.Collections.Generic

Public Class AMasterControl
    Inherits DataGridView
#Region "Variables"

    'Friend childView As New detailControl With {.Height = rowExpandedDivider - rowDividerMargin * 2, .Visible = False}
    '
    Friend WithEvents RowHeaderIconList As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
    '
    Dim _cDG As DataTable
    Dim _cds As DataSet

#End Region
#Region "Initialze and Display"
    Sub New(ByVal cDG As DataTable, ByVal ds As DataSet)
        InitializeComponent()
        _cDG = cDG
        _cds = ds
        applyGridTheme(Me)
        Dock = DockStyle.Fill
    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AMasterControl))
        Me.RowHeaderIconList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RowHeaderIconList
        '
        Me.RowHeaderIconList.ImageStream = CType(resources.GetObject("RowHeaderIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RowHeaderIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.RowHeaderIconList.Images.SetKeyName(0, "expand.png")
        Me.RowHeaderIconList.Images.SetKeyName(1, "collapse.png")
        '
        'MasterControl
        '
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region

End Class
