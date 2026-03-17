Public Class FormTabeliranja
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.rl = New RecentList.CRecentList("Istrazivanja", Me.MenuItemStartRecentList, 6, "Tabeliranje")
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOpen As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemKaskadno As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemStartRecentList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemNew As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItemNew = New System.Windows.Forms.MenuItem
        Me.MenuItemOpen = New System.Windows.Forms.MenuItem
        Me.MenuItemStartRecentList = New System.Windows.Forms.MenuItem
        Me.MenuItemExit = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItemKaskadno = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemNew, Me.MenuItemOpen, Me.MenuItemStartRecentList, Me.MenuItemExit})
        Me.MenuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.MenuItem1.Text = "&File"
        '
        'MenuItemNew
        '
        Me.MenuItemNew.Index = 0
        Me.MenuItemNew.Text = "&Novo"
        '
        'MenuItemOpen
        '
        Me.MenuItemOpen.Index = 1
        Me.MenuItemOpen.Text = "&Otvori..."
        '
        'MenuItemStartRecentList
        '
        Me.MenuItemStartRecentList.Index = 2
        Me.MenuItemStartRecentList.MergeOrder = 1
        Me.MenuItemStartRecentList.Text = "-"
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Index = 3
        Me.MenuItemExit.MergeOrder = 1
        Me.MenuItemExit.Text = "Izlaz"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MdiList = True
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemKaskadno})
        Me.MenuItem2.Text = "&Window"
        '
        'MenuItemKaskadno
        '
        Me.MenuItemKaskadno.Index = 0
        Me.MenuItemKaskadno.Text = "&Kaskadno"
        '
        'FormTabeliranja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoScroll = False
        Me.ClientSize = New System.Drawing.Size(490, 281)
        Me.Enabled = False
        Me.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "FormTabeliranja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tabeliranja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    Private WithEvents rl As RecentList.CRecentList
    Public str As String
    Public d As DatasetIstrazivanja
    Public r2 As DatasetIstrazivanja.ISTRow
    Public v2 As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Public tabf As String

    Public Sub New( _
    ByVal r As DatasetIstrazivanja.ISTRow, _
    ByVal s As String, _
    ByVal d As DatasetIstrazivanja, _
    ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, _
    ByVal fi As String)
        Me.New()
        Me.r2 = r
        Me.str = s
        Me.d = d
        Me.v2 = vt
        Me.tabf = fi + "\Tabeliranje"
        If Not System.IO.Directory.Exists(Me.tabf) Then
            System.IO.Directory.CreateDirectory(Me.tabf)
        End If
    End Sub

    Private Sub MenuItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemExit.Click
        Me.Close()
    End Sub

    Private Sub MenuItemKaskadno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemKaskadno.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub MenuItemOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOpen.Click
        Dim dlg As New System.Windows.Forms.OpenFileDialog
        dlg.Title = "Open"
        dlg.InitialDirectory = Me.tabf
        dlg.Filter = "Tabeliranje fajlovi (*.tbl)|*.tbl"
        If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Me.rl_OnClick(dlg.FileName)
            End If
        End If
        dlg.Dispose()
    End Sub

    Private Sub rl_OnClick(ByVal menuItemText As String) Handles rl.OnClick
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As FormTabeliranje
        For Each frm In Me.MdiChildren
            If CType(frm, FormTabeliranje).MyFileName = menuItemText Then
                frm.Activate()
                Return
            End If
        Next
        Try
            frm = New FormTabeliranje(Me.r2.SIFIST, Me.r2.Naziv.Trim, Me.str, Me.d, Me.r2.ISTBAZERow, Me.v2, Me.tabf, Me.rl, menuItemText)
        Catch ex As System.Exception
            Me.rl.Delete(menuItemText)
            System.Windows.Forms.MessageBox.Show(ex.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItemNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemNew.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As FormTabeliranje
        Try
            frm = New FormTabeliranje(Me.r2.SIFIST, Me.r2.Naziv, Me.str, d, Me.r2.ISTBAZERow, Me.v2, Me.tabf, Me.rl)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class