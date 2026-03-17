Friend Class FormTabeliranje
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        With Me.HP
            .SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
            .SetHelpKeyword(Me, "KreIzv.htm")
            .SetShowHelp(Me, True)
        End With
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents UserControlVremenskaTacka1 As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonDodajPretkolone As System.Windows.Forms.Button
    Friend WithEvents ButtonIzbaciPretkolone As System.Windows.Forms.Button
    Friend WithEvents ButtonIzbaciGlavneKolone As System.Windows.Forms.Button
    Friend WithEvents ButtonDodajGlavneKolone As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxFunkcija As System.Windows.Forms.ComboBox
    Friend WithEvents CheckedListBoxPretkolone As System.Windows.Forms.CheckedListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSave As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSaveAs As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemExportSQL As System.Windows.Forms.MenuItem
    Friend WithEvents MyDataGridKolone As MyDataGridControl.MyDataGrid
    Friend WithEvents MyDataGridGlavneKolone As MyDataGridControl.MyDataGrid
    Friend WithEvents ButtonPostojeciExcelIzvestaj As System.Windows.Forms.Button
    Friend WithEvents ButtonIzlaz As System.Windows.Forms.Button
    Friend WithEvents ButtonIzvestaj As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ButtonDodajPretkolone = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.UserControlVremenskaTacka1 = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonIzbaciPretkolone = New System.Windows.Forms.Button
        Me.ButtonIzbaciGlavneKolone = New System.Windows.Forms.Button
        Me.ButtonDodajGlavneKolone = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBoxFunkcija = New System.Windows.Forms.ComboBox
        Me.CheckedListBoxPretkolone = New System.Windows.Forms.CheckedListBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MyDataGridKolone = New MyDataGridControl.MyDataGrid
        Me.MyDataGridGlavneKolone = New MyDataGridControl.MyDataGrid
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItemExit = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItemSave = New System.Windows.Forms.MenuItem
        Me.MenuItemSaveAs = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItemExportSQL = New System.Windows.Forms.MenuItem
        Me.ButtonPostojeciExcelIzvestaj = New System.Windows.Forms.Button
        Me.ButtonIzlaz = New System.Windows.Forms.Button
        Me.ButtonIzvestaj = New System.Windows.Forms.Button
        CType(Me.MyDataGridKolone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDataGridGlavneKolone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDodajPretkolone
        '
        Me.ButtonDodajPretkolone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonDodajPretkolone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonDodajPretkolone.Location = New System.Drawing.Point(320, 80)
        Me.ButtonDodajPretkolone.Name = "ButtonDodajPretkolone"
        Me.ButtonDodajPretkolone.Size = New System.Drawing.Size(64, 32)
        Me.ButtonDodajPretkolone.TabIndex = 2
        Me.ButtonDodajPretkolone.Text = "Dodaj"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Raspoložive kolone:"
        '
        'UserControlVremenskaTacka1
        '
        Me.UserControlVremenskaTacka1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UserControlVremenskaTacka1.Enabled = False
        Me.UserControlVremenskaTacka1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.UserControlVremenskaTacka1.Location = New System.Drawing.Point(336, 360)
        Me.UserControlVremenskaTacka1.Name = "UserControlVremenskaTacka1"
        Me.UserControlVremenskaTacka1.Size = New System.Drawing.Size(136, 64)
        Me.UserControlVremenskaTacka1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(320, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Pretkolone:"
        '
        'ButtonIzbaciPretkolone
        '
        Me.ButtonIzbaciPretkolone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonIzbaciPretkolone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzbaciPretkolone.Location = New System.Drawing.Point(392, 80)
        Me.ButtonIzbaciPretkolone.Name = "ButtonIzbaciPretkolone"
        Me.ButtonIzbaciPretkolone.Size = New System.Drawing.Size(64, 32)
        Me.ButtonIzbaciPretkolone.TabIndex = 19
        Me.ButtonIzbaciPretkolone.Text = "Izbaci"
        '
        'ButtonIzbaciGlavneKolone
        '
        Me.ButtonIzbaciGlavneKolone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonIzbaciGlavneKolone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzbaciGlavneKolone.Location = New System.Drawing.Point(704, 80)
        Me.ButtonIzbaciGlavneKolone.Name = "ButtonIzbaciGlavneKolone"
        Me.ButtonIzbaciGlavneKolone.Size = New System.Drawing.Size(64, 32)
        Me.ButtonIzbaciGlavneKolone.TabIndex = 21
        Me.ButtonIzbaciGlavneKolone.Text = "Izbaci"
        '
        'ButtonDodajGlavneKolone
        '
        Me.ButtonDodajGlavneKolone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonDodajGlavneKolone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonDodajGlavneKolone.Location = New System.Drawing.Point(512, 80)
        Me.ButtonDodajGlavneKolone.Name = "ButtonDodajGlavneKolone"
        Me.ButtonDodajGlavneKolone.Size = New System.Drawing.Size(64, 32)
        Me.ButtonDodajGlavneKolone.TabIndex = 20
        Me.ButtonDodajGlavneKolone.Text = "Dodaj"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(512, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Glavne kolone:"
        '
        'ComboBoxFunkcija
        '
        Me.ComboBoxFunkcija.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxFunkcija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFunkcija.ItemHeight = 20
        Me.ComboBoxFunkcija.Location = New System.Drawing.Point(576, 80)
        Me.ComboBoxFunkcija.Name = "ComboBoxFunkcija"
        Me.ComboBoxFunkcija.Size = New System.Drawing.Size(112, 28)
        Me.ComboBoxFunkcija.TabIndex = 25
        '
        'CheckedListBoxPretkolone
        '
        Me.CheckedListBoxPretkolone.AllowDrop = True
        Me.CheckedListBoxPretkolone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckedListBoxPretkolone.HorizontalScrollbar = True
        Me.CheckedListBoxPretkolone.Location = New System.Drawing.Point(320, 112)
        Me.CheckedListBoxPretkolone.Name = "CheckedListBoxPretkolone"
        Me.CheckedListBoxPretkolone.Size = New System.Drawing.Size(168, 224)
        Me.CheckedListBoxPretkolone.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.CheckedListBoxPretkolone, "Ako izaberete pretkolonu, vrednosti u glavnoj koloni će biti razvrstane po toj pr" & _
        "etkoloni")
        '
        'MyDataGridKolone
        '
        Me.MyDataGridKolone.AlternatingBackColor = System.Drawing.Color.PowderBlue
        Me.MyDataGridKolone.BackColor = System.Drawing.Color.GhostWhite
        Me.MyDataGridKolone.BackgroundColor = System.Drawing.Color.Lavender
        Me.MyDataGridKolone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MyDataGridKolone.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.MyDataGridKolone.CaptionFont = New System.Drawing.Font("Tahoma", 10.2!)
        Me.MyDataGridKolone.CaptionForeColor = System.Drawing.Color.White
        Me.MyDataGridKolone.DataMember = ""
        Me.MyDataGridKolone.FlatMode = True
        Me.MyDataGridKolone.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.MyDataGridKolone.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGridKolone.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.MyDataGridKolone.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGridKolone.HeaderFont = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MyDataGridKolone.HeaderForeColor = System.Drawing.Color.White
        Me.MyDataGridKolone.LinkColor = System.Drawing.Color.Teal
        Me.MyDataGridKolone.Location = New System.Drawing.Point(16, 80)
        Me.MyDataGridKolone.Name = "MyDataGridKolone"
        Me.MyDataGridKolone.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.MyDataGridKolone.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGridKolone.SelectionBackColor = System.Drawing.Color.Teal
        Me.MyDataGridKolone.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.MyDataGridKolone.Size = New System.Drawing.Size(280, 392)
        Me.MyDataGridKolone.TabIndex = 28
        '
        'MyDataGridGlavneKolone
        '
        Me.MyDataGridGlavneKolone.AllowDrop = True
        Me.MyDataGridGlavneKolone.AlternatingBackColor = System.Drawing.Color.PowderBlue
        Me.MyDataGridGlavneKolone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MyDataGridGlavneKolone.BackColor = System.Drawing.Color.GhostWhite
        Me.MyDataGridGlavneKolone.BackgroundColor = System.Drawing.Color.Lavender
        Me.MyDataGridGlavneKolone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MyDataGridGlavneKolone.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.MyDataGridGlavneKolone.CaptionFont = New System.Drawing.Font("Tahoma", 10.2!)
        Me.MyDataGridGlavneKolone.CaptionForeColor = System.Drawing.Color.White
        Me.MyDataGridGlavneKolone.DataMember = ""
        Me.MyDataGridGlavneKolone.FlatMode = True
        Me.MyDataGridGlavneKolone.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.MyDataGridGlavneKolone.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGridGlavneKolone.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.MyDataGridGlavneKolone.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGridGlavneKolone.HeaderFont = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MyDataGridGlavneKolone.HeaderForeColor = System.Drawing.Color.White
        Me.MyDataGridGlavneKolone.LinkColor = System.Drawing.Color.Teal
        Me.MyDataGridGlavneKolone.Location = New System.Drawing.Point(512, 120)
        Me.MyDataGridGlavneKolone.Name = "MyDataGridGlavneKolone"
        Me.MyDataGridGlavneKolone.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.MyDataGridGlavneKolone.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.MyDataGridGlavneKolone.SelectionBackColor = System.Drawing.Color.Teal
        Me.MyDataGridGlavneKolone.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.MyDataGridGlavneKolone.Size = New System.Drawing.Size(152, 152)
        Me.MyDataGridGlavneKolone.TabIndex = 29
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemExit, Me.MenuItem2, Me.MenuItemSave, Me.MenuItemSaveAs, Me.MenuItem3, Me.MenuItemExportSQL})
        Me.MenuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.MenuItem1.Text = "&File"
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Index = 0
        Me.MenuItemExit.Text = "&Zatvori"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItemSave
        '
        Me.MenuItemSave.Index = 2
        Me.MenuItemSave.Text = "&Sačuvaj"
        '
        'MenuItemSaveAs
        '
        Me.MenuItemSaveAs.Index = 3
        Me.MenuItemSaveAs.Text = "Sačuvaj &kao..."
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Text = "-"
        '
        'MenuItemExportSQL
        '
        Me.MenuItemExportSQL.Index = 5
        Me.MenuItemExportSQL.Text = "&Export SQL..."
        '
        'ButtonPostojeciExcelIzvestaj
        '
        Me.ButtonPostojeciExcelIzvestaj.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonPostojeciExcelIzvestaj.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonPostojeciExcelIzvestaj.Location = New System.Drawing.Point(293, 8)
        Me.ButtonPostojeciExcelIzvestaj.Name = "ButtonPostojeciExcelIzvestaj"
        Me.ButtonPostojeciExcelIzvestaj.Size = New System.Drawing.Size(200, 32)
        Me.ButtonPostojeciExcelIzvestaj.TabIndex = 32
        Me.ButtonPostojeciExcelIzvestaj.Text = "Postojeći Excel izveštaj"
        '
        'ButtonIzlaz
        '
        Me.ButtonIzlaz.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzlaz.Location = New System.Drawing.Point(525, 8)
        Me.ButtonIzlaz.Name = "ButtonIzlaz"
        Me.ButtonIzlaz.Size = New System.Drawing.Size(120, 32)
        Me.ButtonIzlaz.TabIndex = 31
        Me.ButtonIzlaz.Text = "Izlaz"
        '
        'ButtonIzvestaj
        '
        Me.ButtonIzvestaj.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonIzvestaj.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzvestaj.Location = New System.Drawing.Point(141, 8)
        Me.ButtonIzvestaj.Name = "ButtonIzvestaj"
        Me.ButtonIzvestaj.Size = New System.Drawing.Size(120, 32)
        Me.ButtonIzvestaj.TabIndex = 30
        Me.ButtonIzvestaj.Text = "Izveštaj"
        '
        'FormTabeliranje
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(786, 520)
        Me.Controls.Add(Me.ButtonPostojeciExcelIzvestaj)
        Me.Controls.Add(Me.ButtonIzlaz)
        Me.Controls.Add(Me.ButtonIzvestaj)
        Me.Controls.Add(Me.MyDataGridGlavneKolone)
        Me.Controls.Add(Me.MyDataGridKolone)
        Me.Controls.Add(Me.CheckedListBoxPretkolone)
        Me.Controls.Add(Me.ComboBoxFunkcija)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonIzbaciGlavneKolone)
        Me.Controls.Add(Me.ButtonDodajGlavneKolone)
        Me.Controls.Add(Me.ButtonIzbaciPretkolone)
        Me.Controls.Add(Me.UserControlVremenskaTacka1)
        Me.Controls.Add(Me.ButtonDodajPretkolone)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Menu = Me.MainMenu1
        Me.Name = "FormTabeliranje"
        Me.Text = "Tabeliranje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MyDataGridKolone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDataGridGlavneKolone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mstr As String
    Public mtpolj As DatasetIstrazivanja.ISTPOLJADataTable
    Public rb As DatasetIstrazivanja.ISTBAZERow
    Public ds As DatasetIstrazivanja
    Public tkon As DatasetTabeliranje.KonsultDataTable
    Public tgk As New DatasetTabeliranje.GlavneKoloneDataTable
    Public mdf As New finf(eFunction.eMax, "Count", "Prebrojiti")
    Public fs() As finf = {New finf(eFunction.eSum, "Sum", "Suma"), New finf(eFunction.eAvg, "Avg", "Prosek"), New finf(eFunction.eMin, "Min", "Minimum"), New finf(eFunction.eMax, "Max", "Maksimum"), Me.mdf}
    Public rc As RecentList.CRecentList
    Public ftab As String
    Public mpret() As kinf = {}
    Public mgl() As kinf = {}
    Public fn As String = ""

    Public ReadOnly Property MyFileName() As String
        Get
            Return Me.fn
        End Get
    End Property

    Public Structure finf
        Dim eFunc As eFunction
        Dim Name As String
        Dim Descrip As String
        Public Sub New(ByVal eFunc As eFunction, ByVal Name As String, ByVal Descrip As String)
            Me.eFunc = eFunc
            Me.Name = Name
            Me.Descrip = Descrip
        End Sub
    End Structure

    Public Enum eFunction
        eSum
        eAvg
        eMin
        eMax
    End Enum

    Public Overloads Sub Dispose()
        Me.tgk.Dispose()
        If Not Me.ds Is Nothing Then
            Me.ds.Dispose()
        End If
        MyBase.Dispose()
    End Sub

    Private Structure kinf2
        Dim k As kinf
        Dim ptcor As String
        Dim ctcorname As String

        Public ReadOnly Property ColPref() As String
            Get
                Dim p As String
                If Me.k.IsChild Then
                    Dim rk As DatasetTabeliranje.KonsultRow
                    rk = CType(Me.k.row, DatasetTabeliranje.KonsultRow)
                    p = zpar(Me.k.rb.ISTRDBMSRow, Me.ctcorname)
                    Return p.Trim + "." + zpar(Me.k.rb.ISTRDBMSRow, rk.RELPOLJE)
                End If
                Dim rp As DatasetIstrazivanja.ISTPOLJARow
                rp = CType(Me.k.row, DatasetIstrazivanja.ISTPOLJARow)
                p = zpar(Me.k.rb.ISTRDBMSRow, Me.ptcor)
                Return p.Trim + "." + zpar(Me.k.rb.ISTRDBMSRow, rp.POLJE)
            End Get
        End Property
        Public Function zpar(ByVal r As DatasetIstrazivanja.ISTRDBMSRow, ByVal name As String) As String
            If r.FIZBAZA.Trim.ToLower = "ss" Then
                name = name.Trim
                If name.Chars(0) <> "["c Then
                    Return "[" + name + "]"
                End If
            End If
            Return name
        End Function

        Public Sub New(ByVal ki As kinf, ByVal ptcor As String, ByVal ctcor As String)
            Me.k = ki
            Me.ptcor = ptcor
            Me.ctcorname = ctcor
        End Sub
    End Structure

    Private Structure kinf3
        Dim kolona As kinf2
        Dim table As info2

        Public Sub New( _
        ByVal ki As kinf2, _
        ByVal table As info2)
            Me.kolona = ki
            Me.table = table
        End Sub
    End Structure

    Public Structure kinf
        Dim row As System.Data.DataRow
        Dim ccforr As String
        Dim colcap As String
        Dim rb As DatasetIstrazivanja.ISTBAZERow

        Public Function ColT() As System.Type
            If Me.IsChild Then
                Dim rowKonsult As DatasetTabeliranje.KonsultRow = CType(Me.row, DatasetTabeliranje.KonsultRow)
                Return System.Type.GetType(rowKonsult.TipDotNet)
            End If
            Dim rowPolja As DatasetIstrazivanja.ISTPOLJARow = CType(Me.row, DatasetIstrazivanja.ISTPOLJARow)
            Return System.Type.GetType(CStr(row.Item(PoljaFill.COLUMN_TIP_DOTNET)))
        End Function

        Public ReadOnly Property COLPref() As String
            Get
                If Me.IsChild Then
                    Dim rKonsult As DatasetTabeliranje.KonsultRow
                    rKonsult = CType(row, DatasetTabeliranje.KonsultRow)
                    Return parz(Me.rb.ISTRDBMSRow, rKonsult.RELPOLJE)
                End If
                Dim rPolja As DatasetIstrazivanja.ISTPOLJARow
                rPolja = CType(Me.row, DatasetIstrazivanja.ISTPOLJARow)
                Return parz(Me.rb.ISTRDBMSRow, rPolja.POLJE)
            End Get
        End Property
        Public Function parz( _
        ByVal rowRDBMS As DatasetIstrazivanja.ISTRDBMSRow, _
        ByVal name As String) As String
            If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
                name = name.Trim
                If name.Chars(0) <> "["c Then
                    Return "[" + name + "]"
                End If
            End If
            Return name
        End Function

        Public ReadOnly Property IsChild() As Boolean
            Get
                Return row.Table.TableName = "Konsult"
            End Get
        End Property

        Public ReadOnly Property ptName() As String
            Get
                Dim r As DatasetIstrazivanja.ISTPOLJARow
                If Me.IsChild Then
                    r = CType(row.GetParentRow(row.Table.ParentRelations(0)), DatasetIstrazivanja.ISTPOLJARow)
                Else : r = CType(Me.row, DatasetIstrazivanja.ISTPOLJARow)
                End If
                Return r.TABELA.Trim
            End Get
        End Property

        Public ReadOnly Property relForm() As String
            Get
                Dim r As DatasetIstrazivanja.ISTPOLJARow
                If Me.IsChild Then
                    r = CType(row.GetParentRow(row.Table.ParentRelations(0)), DatasetIstrazivanja.ISTPOLJARow)
                Else : r = CType(Me.row, DatasetIstrazivanja.ISTPOLJARow)
                End If
                Return r.TABELA.Trim + "_" + r.RelBaza.Trim + "_" + r.RelTabela
            End Get
        End Property

        Public Sub New(ByVal row As System.Data.DataRow, ByVal rb As DatasetIstrazivanja.ISTBAZERow)
            Me.row = row
            If row.Table.TableName = "Kolone" Then
                Me.rb = rb
                Dim rp As DatasetIstrazivanja.ISTPOLJARow
                rp = CType(row, DatasetIstrazivanja.ISTPOLJARow)
                If rp.IsOpisNull OrElse rp.Opis.Trim = "" Then
                    Me.ccforr = rp.POLJE.Trim
                Else : Me.ccforr = rp.Opis.Trim
                End If
                Me.colcap = Me.ccforr + " (" + parz(Me.rb.ISTRDBMSRow, rp.TABELA).Trim + ")"
            Else
                Dim rk As DatasetTabeliranje.KonsultRow
                rk = CType(row, DatasetTabeliranje.KonsultRow)
                Me.ccforr = rk.RELPOLJE.Trim
                Me.colcap = Me.ccforr + " (" + Me.relForm + ")"
                Dim kt As DatasetTabeliranje.KonsultDataTable
                kt = CType(rk.Table, DatasetTabeliranje.KonsultDataTable)
                Dim rp As DatasetIstrazivanja.ISTPOLJARow
                rp = CType(rk.GetParentRow(kt.ParentRelations(0)), DatasetIstrazivanja.ISTPOLJARow)
                Me.rb = CType(rb.Table, DatasetIstrazivanja.ISTBAZEDataTable).FindByBaza(rp.RelBaza)
            End If
        End Sub
    End Structure

    Private Sub Ikolona(ByVal j As Integer, ByRef k() As kinf, ByVal ki As kinf)
        If j > k.GetUpperBound(0) Then
            ReDim Preserve k(j)
        End If
        For i As Integer = k.GetUpperBound(0) To j + 1 Step -1
            k(i) = k(i - 1)
        Next
        k(j) = ki
    End Sub

    Public Sub New(ByVal sifist As String, ByVal ni As String, ByVal str As String, ByVal d As DatasetIstrazivanja, ByVal rb As DatasetIstrazivanja.ISTBAZERow, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal foldtab As String, ByVal rl As RecentList.CRecentList, ByVal fn As String)
        Me.New(sifist, ni, str, d, rb, vt, foldtab, rl)
        Dim doc As New System.Xml.XmlDocument
        doc.Load(fn)
        If doc.DocumentElement.Attributes(Me.mtpolj.SIFISTColumn.ColumnName).Value.Trim <> sifist.Trim Then
            Me.Dispose()
            Throw New System.Exception("Tabeliranje iz drugog istraživanja")
        End If
        Me.Kolone(doc.DocumentElement, "pretkolone", True)
        Me.Kolone(doc.DocumentElement, "glavneKolone", False)
        Me.fn = fn
        Me.rc.Update(fn)
        Dim fi As New System.IO.FileInfo(fn)
        Me.MySetCaption(fi.Name)
    End Sub

    Private Class PoljaFill
        Public mstr As String
        Public mtpolj As DatasetIstrazivanja.ISTPOLJADataTable
        Private m_tabele() As String = {}
        Public Const COLUMN_TIP_DOTNET As String = "TipDotNet"

        Public Sub Append(ByVal tableName As String)
            tableName = tableName.Trim
            For Each s As String In Me.m_tabele
                If s = tableName Then
                    Return
                End If
            Next
            ReDim Preserve Me.m_tabele(1 + Me.m_tabele.GetUpperBound(0))
            Me.m_tabele(Me.m_tabele.GetUpperBound(0)) = tableName
        End Sub

        Public Sub FillTypes()
            Dim colTip As System.Data.DataColumn
            colTip = Me.mtpolj.Columns.Add(Me.COLUMN_TIP_DOTNET, GetType(String))
            For Each tableName As String In Me.m_tabele
                Dim sql As String = "select * from " + tableName + " where 1=0"
                Dim adp As New System.Data.OleDb.OleDbDataAdapter(sql, Me.mstr)
                Dim t As New System.Data.DataTable
                Try
                    adp.Fill(t)
                Catch ex As System.Exception
                    t.Dispose()
                    Throw ex
                Finally
                    adp.Dispose()
                End Try
                For Each col As System.Data.DataColumn In t.Columns
                    For Each r As DatasetIstrazivanja.ISTPOLJARow In Me.mtpolj.Rows
                        If r.TABELA.Trim = tableName _
                        AndAlso r.POLJE.Trim = col.ColumnName Then
                            r.Item(Me.COLUMN_TIP_DOTNET) = col.DataType.ToString
                            Exit For
                        End If
                    Next
                Next
                t.Dispose()
            Next
        End Sub

        Public Sub New( _
        ByVal connectionString As String, _
        ByVal tableISTPolja As DatasetIstrazivanja.ISTPOLJADataTable)
            Me.mstr = connectionString
            Me.mtpolj = tableISTPolja
        End Sub
    End Class

    Public Sub New(ByVal sifist As String, ByVal ni As String, ByVal s As String, ByVal d As DatasetIstrazivanja, ByVal rb As DatasetIstrazivanja.ISTBAZERow, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal foldtab As String, ByVal rl As RecentList.CRecentList)
        Me.New()
        Me.MySetCaption(ni)
        Me.rc = rl
        ds = CType(d.Copy, DatasetIstrazivanja)
        ds.DataSetName = "Kolone"
        mtpolj = ds.ISTPOLJA
        mtpolj.TableName = "Kolone"
        Dim pt As New PoljaFill(s, Me.mtpolj)
        For Each r As DatasetIstrazivanja.ISTPOLJARow In d.ISTPOLJA.Rows
            pt.Append(r.TABELA)
        Next
        ds.AcceptChanges()
        Me.rb = rb
        Me.mstr = s
        Me.ftab = foldtab
        Me.UserControlVremenskaTacka1.Init(vt)
        pt.FillTypes()
        With Me.mtpolj
            Dim vc() As System.Data.DataColumn = {.TABELAColumn, .POLJEColumn, .OpisColumn}
            Dim nonVisibleCols() As System.Data.DataColumn = {.SIFISTColumn, .RelTabelaColumn, .RelPoljeColumn}
            Dim cols(vc.Length + nonVisibleCols.Length - 1) As System.Data.DataColumn
            vc.CopyTo(cols, 0)
            nonVisibleCols.CopyTo(cols, vc.Length)
            Me.MyDataGridKolone.MyAppendTableStyle(.TableName, Cols, vc, AddressOf Get2)
        End With
        Me.mtpolj.DefaultView.AllowNew = False
        Me.tkon = New DatasetTabeliranje.KonsultDataTable
        Me.ds.Tables.Add(Me.tkon)
        With Me.tkon
            Dim vs() As System.Data.DataColumn = {.RELPOLJEColumn}
            Dim cols(.Columns.Count - 1) As System.Data.DataColumn
            .Columns.CopyTo(cols, 0)
            Me.MyDataGridKolone.MyAppendTableStyle(.TableName, Cols, vs, AddressOf Get2)
            .DefaultView.AllowNew = False
        End With
        Dim parcol() As System.Data.DataColumn = {Me.mtpolj.SIFISTColumn, Me.mtpolj.TABELAColumn, Me.mtpolj.POLJEColumn}
        Dim ccol() As System.Data.DataColumn = {Me.tkon.SIFISTColumn, Me.tkon.TABELAColumn, Me.tkon.POLJEColumn}
        Dim l As New System.Data.DataRelation("Konsult", parcol, ccol)
        Me.ds.Relations.Add(l)
        Me.MyDataGridKolone.DataSource = Me.ds
        Dim tb2 As DatasetIstrazivanja.ISTBAZEDataTable
        tb2 = CType(Me.rb.Table, DatasetIstrazivanja.ISTBAZEDataTable)
        Dim rp As DatasetIstrazivanja.ISTPOLJARow
        For Each rp In Me.mtpolj.Rows
            If Not rp.IsRelPoljeNull AndAlso Not rp.IsRelTabelaNull AndAlso rp.RelPolje.Trim <> "" AndAlso rp.RelTabela.Trim <> "" Then
                Dim sql As String = "select * from " + uzmitabelu(Me.rb, tb2.FindByBaza(rp.RelBaza), rp.RelTabela.Trim)
                sql += " where 1=2"
                Dim adp As New System.Data.OleDb.OleDbDataAdapter(sql, Me.mstr)
                Dim t As New System.Data.DataTable
                Try
                    adp.Fill(t)
                    Dim col As System.Data.DataColumn
                    For Each col In t.Columns
                        Me.tkon.AddKonsultRow(rp.SIFIST, rp.TABELA, rp.POLJE, rp.RelTabela, col.ColumnName, rp.RelBaza, col.DataType.ToString)
                    Next
                Finally
                    t.Dispose()
                    adp.Dispose()
                End Try
            End If
        Next
        Me.ds.AcceptChanges()
        Me.MyDataGridKolone.DataMember = Me.mtpolj.TableName
        Dim i As Integer = 0
        Dim v As System.Data.DataRowView
        For Each v In Me.mtpolj.DefaultView
            If v.Row.GetChildRows(v.Row.Table.ChildRelations(0)).Length > 0 Then
                Me.MyDataGridKolone.Expand(i)
            End If
            i += 1
        Next
        Me.MyDataGridKolone.MyAutoFit(Me.tkon.TableName, True)
        With Me.tgk
            Dim cols(.Columns.Count - 1) As System.Data.DataColumn
            .Columns.CopyTo(cols, 0)
            Me.MyDataGridGlavneKolone.MyAppendTableStyle(.TableName, cols, cols, AddressOf fun2)
            .DefaultView.AllowNew = False
        End With
        Me.MyDataGridGlavneKolone.DataSource = Me.tgk
        For Each fi As finf In Me.fs
            Me.ComboBoxFunkcija.Items.Add(fi.Descrip)
        Next
        Me.ComboBoxFunkcija.Text = Me.mdf.Descrip
        Me.tab_Resize(Nothing, Nothing)
    End Sub

    Public Function uzmitabelu(ByVal crb As DatasetIstrazivanja.ISTBAZERow, ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow, ByVal tn As String) As String
        If rowBaze Is Nothing Then
            rowBaze = crb
        End If
        Dim rowRDBMS As DatasetIstrazivanja.ISTRDBMSRow
        If Not rowBaze Is crb Then
            rowRDBMS = rowBaze.ISTRDBMSRow
            If rowRDBMS Is Nothing Then
                Throw New System.Exception("Nema podataka o RDBMS")
            End If
        Else : rowRDBMS = crb.ISTRDBMSRow
        End If
        Dim t2 As String = tn.Trim
        t2 = ime_zag(crb.ISTRDBMSRow, t2)
        t2 = tabela_prefiks(rowBaze, t2)
        Dim sODBC As String = rowBaze.IzrazODBC.Trim.ToLower
        If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
            Dim db As String = uzmi_connstr(sODBC, "database")
            If db = "" Then
                db = uzmi_connstr(sODBC, "initial catalog")
                If db = "" Then
                    db = rowBaze.Baza.Trim
                End If
            End If
            Dim prefix As String = ime_uzagradi(rowRDBMS, db)
            t2 = prefix.Trim + "." + t2
        End If
        If Not crb Is rowBaze Then
            If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
                Dim provider As String = uzmi_connstr(sODBC, "provider")
                If provider = "" Then
                    provider = "SQLOLEDB"
                End If
                t2 = "OPENROWSET('" + provider + "','" + sODBC + "'," + t2 + ")"
            End If
        End If
        Return t2
    End Function

    Public Function ime_uzagradi(ByVal rowRDBMS As DatasetIstrazivanja.ISTRDBMSRow, ByVal name As String) As String
        If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
            name = name.Trim
            If name.Chars(0) <> "["c Then
                Return "[" + name + "]"
            End If
        End If
        Return name
    End Function
    Private Function uzmi_connstr(ByVal connectionString As String, ByVal parameter As String) As String
        Dim i As Integer = connectionString.ToLower.IndexOf(parameter)
        Dim iStart As Integer = i
        If i >= 0 Then
            i = connectionString.IndexOf("=", i + 1)
            If i >= 0 Then
                Dim j As Integer = connectionString.IndexOf(";", i + 1)
                If j >= 0 Then
                    Return connectionString.Substring(i + 1, j - i - 1).Trim
                Else : Return connectionString.Substring(i + 1).Trim
                End If
            End If
        End If
        Return ""
    End Function

    Public Function tabela_prefiks(ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow, ByVal tableName As String) As String
        If Not rowBaze.IsprefixNull _
        AndAlso rowBaze.prefix.Trim <> "" Then
            Dim prefix As String = rowBaze.prefix.Trim
            prefix = ime_uzagradi(rowBaze.ISTRDBMSRow, prefix)
            Return prefix + "." + tableName
        End If
        Return tableName
    End Function
    Public Function ime_zag( _
    ByVal rowRDBMS As DatasetIstrazivanja.ISTRDBMSRow, _
    ByVal name As String) As String
        If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
            name = name.Trim
            If name.Chars(0) <> "["c Then
                Return "[" + name + "]"
            End If
        End If
        Return name
    End Function
    Private Shared Function Get2(ByVal col As System.Data.DataColumn) As System.Windows.Forms.DataGridColumnStyle
        Dim cs As New MyDataGridControl.DataGridNonEditableColumn
        Return cs
    End Function

    Private Sub gl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim rv As System.Data.DataRowView
        rv = Me.MyDataGridGlavneKolone.MyCurrentRowView
        If rv Is Nothing Then
            Return
        End If
        Dim cb As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        Dim fi As finf = Me.getcol(cb.Text)
        Dim ki As kinf = Me.mgl(Me.MyDataGridGlavneKolone.CurrentCell.RowNumber)
        If ki.ColT Is GetType(String) AndAlso (fi.eFunc = eFunction.eAvg OrElse fi.eFunc = eFunction.eSum) Then
            System.Windows.Forms.MessageBox.Show("Nedozvoljena operacija nad kolonom koja ne sadrži brojčane vrednosti", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop)
            cb.SelectedItem = Me.mdf.Descrip
            rv.Row.RejectChanges()
        End If
    End Sub

    Private Function fun2(ByVal col As System.Data.DataColumn) As System.Windows.Forms.DataGridColumnStyle
        If col.ColumnName = Me.tgk.FunkcijaColumn.ColumnName Then
            Dim cs As New MyDataGridControl.DataGridComboBoxColumn
            With cs.MyComboBox
                .DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
                For Each fi As finf In Me.fs
                    .Items.Add(fi.Descrip)
                Next
            End With
            AddHandler cs.MyComboBox.SelectedIndexChanged, AddressOf gl_SelectedIndexChanged
            Return cs
        End If
        Return Nothing
    End Function

    Private Sub dod(ByVal row As System.Data.DataRow)
        For i As Integer = 0 To Me.CheckedListBoxPretkolone.Items.Count - 1
            If Me.mpret(i).row Is row Then
                System.Windows.Forms.MessageBox.Show("Postoji red.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Return
            End If
        Next
        Dim ki As New kinf(row, Me.rb)
        Dim index As Integer
        index = Me.CheckedListBoxPretkolone.Items.Add(ki.colcap)
        Me.Ikolona(index, Me.mpret, ki)
    End Sub

    Private Sub dodaj2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDodajPretkolone.Click
        Dim rv As System.Data.DataRowView
        rv = Me.MyDataGridKolone.MyCurrentRowView
        If rv Is Nothing Then
            Return
        End If
        Me.dod(rv.Row)
    End Sub

    Private Sub izb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIzbaciPretkolone.Click
        If Me.CheckedListBoxPretkolone.SelectedItem Is Nothing Then
            Return
        End If
        For i As Integer = Me.CheckedListBoxPretkolone.SelectedIndex To Me.mpret.GetUpperBound(0) - 1
            Me.mpret(i) = Me.mpret(i + 1)
        Next
        ReDim Preserve Me.mpret(Me.mpret.GetUpperBound(0) - 1)
        Me.CheckedListBoxPretkolone.Items.RemoveAt(Me.CheckedListBoxPretkolone.SelectedIndex)
    End Sub

    Private Sub kolone2(ByVal row As System.Data.DataRow, ByVal W As String)
        Dim ki As New kinf(row, Me.rb)
        Dim fi As finf = Me.getcol(W)
        For Each r As DatasetTabeliranje.GlavneKoloneRow In Me.tgk.Rows
            If r.Kolona = ki.colcap _
            AndAlso r.Funkcija = fi.Descrip Then
                System.Windows.Forms.MessageBox.Show("Postoji red sa funkcijom: " + fi.Descrip, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Return
            End If
        Next
        If ki.ColT Is GetType(String) AndAlso (fi.eFunc = eFunction.eAvg OrElse fi.eFunc = eFunction.eSum) Then
            System.Windows.Forms.MessageBox.Show("Nedozvoljena operacija nad kolonom koja ne sadrži brojčane vrednosti", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop)
            Return
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.tgk.AddGlavneKoloneRow(ki.colcap, fi.Descrip)
        Me.MyDataGridGlavneKolone.MyAutoFit_FitWidth(Me.tgk.TableName)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Dim index As Integer = Me.tgk.DefaultView.Count - 1
        Me.Ikolona(index, Me.mgl, ki)
    End Sub

    Private Sub kolone3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDodajGlavneKolone.Click
        Dim rv As System.Data.DataRowView
        rv = Me.MyDataGridKolone.MyCurrentRowView
        If rv Is Nothing Then
            Return
        End If
        Me.kolone2(rv.Row, Me.ComboBoxFunkcija.Text)
    End Sub

    Private Sub kolone4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIzbaciGlavneKolone.Click
        Dim rv As System.Data.DataRowView
        rv = Me.MyDataGridGlavneKolone.MyCurrentRowView
        If rv Is Nothing Then
            Return
        End If
        For i As Integer = Me.MyDataGridGlavneKolone.CurrentCell.RowNumber To Me.mgl.GetUpperBound(0) - 1
            Me.mgl(i) = Me.mgl(i + 1)
        Next
        ReDim Preserve Me.mgl(Me.mgl.GetUpperBound(0) - 1)
        rv.Row.Delete()
        Me.tgk.AcceptChanges()
    End Sub

    Private Function getcol(ByVal funcDescrip As String) As finf
        For Each fi As finf In Me.fs
            If fi.Descrip = funcDescrip Then
                Return fi
            End If
        Next
        Throw New System.Exception("Nema funkcije!")
    End Function

    Private Sub tab_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        With Me.MyDataGridKolone
            If Me.UserControlVremenskaTacka1.Left > .Left Then
                .Width = Me.CheckedListBoxPretkolone.Left - 10 - .Left
            End If
            If Me.ClientSize.Height > .Top Then
                .Height = Me.ClientSize.Height - .Top
            End If
            If Not Me.mtpolj Is Nothing Then
                .MyAutoFit_FitWidth(Me.mtpolj.TableName)
            End If
        End With
        With Me.MyDataGridGlavneKolone
            If Me.ClientSize.Width > .Left Then
                .Width = Me.ClientSize.Width - .Left
            End If
            If Me.ClientSize.Height > .Top Then
                .Height = Me.ClientSize.Height - .Top
            End If
            If Not Me.tgk Is Nothing Then
                .MyAutoFit_FitWidth(Me.tgk.TableName)
            End If
        End With
    End Sub

    Private Structure info2
        Dim s As String
        Dim ism As Boolean
        Dim cname As String
        Dim name2name As String
        Dim mtable2 As Boolean
        Dim mpolj As DatasetIstrazivanja.ISTPOLJARow
        Dim mkolona5() As String
        Dim m_rowBaza As DatasetIstrazivanja.ISTBAZERow
        Dim mkontrola As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
        Dim tabelezaprikaz() As info2

        Public Function getpoljeutabeli() As String
            Dim tabela As String
            If Me.mtable2 Then
                tabela = tabela_sql(Me.m_rowBaza, Me.m_rowBaza, Me.mpolj.RelTabela)
            Else : tabela = tabela_sql(Me.m_rowBaza, Me.m_rowBaza, Me.mpolj.TABELA)
            End If
            Return Me.mkontrola.vWhere(tabela, Me.cname, Me.m_rowBaza.ISTRDBMSRow, Me.s)
        End Function

        Public Function tabela_sql(ByVal currentRowBaze As DatasetIstrazivanja.ISTBAZERow, ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow, ByVal tableNameArg As String) As String
            If rowBaze Is Nothing Then
                rowBaze = currentRowBaze
            End If
            Dim rowRDBMS As DatasetIstrazivanja.ISTRDBMSRow
            If Not rowBaze Is currentRowBaze Then
                rowRDBMS = rowBaze.ISTRDBMSRow
                If rowRDBMS Is Nothing Then
                    Throw New System.Exception("Nema podataka o RDBMS")
                End If
            Else : rowRDBMS = currentRowBaze.ISTRDBMSRow
            End If
            Dim tableName As String = tableNameArg.Trim
            tableName = ime_par(currentRowBaze.ISTRDBMSRow, tableName)
            tableName = tabela_zaSQL(rowBaze, tableName)
            Dim sODBC As String = rowBaze.IzrazODBC.Trim.ToLower
            If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
                Dim db As String = ConnStrParam(sODBC, "database")
                If db = "" Then
                    db = ConnStrParam(sODBC, "initial catalog")
                    If db = "" Then
                        db = rowBaze.Baza.Trim
                    End If
                End If
                Dim prefix As String = ime_par(rowRDBMS, db)
                tableName = prefix.Trim + "." + tableName
            End If
            If Not currentRowBaze Is rowBaze Then
                If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
                    Dim provider As String = ConnStrParam(sODBC, "provider")
                    If provider = "" Then
                        provider = "SQLOLEDB"
                    End If
                    tableName = "OPENROWSET('" + provider + "','" + sODBC + "'," + tableName + ")"
                End If
            End If
            Return tableName
        End Function

        Private Function ConnStrParam(ByVal connectionString As String, ByVal parameter As String) As String
            Dim i As Integer = connectionString.ToLower.IndexOf(parameter)
            Dim iStart As Integer = i
            If i >= 0 Then
                i = connectionString.IndexOf("=", i + 1)
                If i >= 0 Then
                    Dim j As Integer = connectionString.IndexOf(";", i + 1)
                    If j >= 0 Then
                        Return connectionString.Substring(i + 1, j - i - 1).Trim
                    Else : Return connectionString.Substring(i + 1).Trim
                    End If
                End If
            End If
            Return ""
        End Function
        Public Function tabela_zaSQL(ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow, ByVal n As String) As String
            If Not rowBaze.IsprefixNull AndAlso rowBaze.prefix.Trim <> "" Then
                Dim p As String = rowBaze.prefix.Trim
                p = ime_zagr(rowBaze.ISTRDBMSRow, p)
                Return p + "." + n
            End If
            Return n
        End Function

        Public Function ime_zagr(ByVal rowRDBMS As DatasetIstrazivanja.ISTRDBMSRow, ByVal name As String) As String
            If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
                name = name.Trim
                If name.Chars(0) <> "["c Then
                    Return "[" + name + "]"
                End If
            End If
            Return name
        End Function
        Public Function ime_par( _
        ByVal rowRDBMS As DatasetIstrazivanja.ISTRDBMSRow, _
        ByVal name As String) As String
            If rowRDBMS.FIZBAZA.Trim.ToLower = "ss" Then
                name = name.Trim
                If name.Chars(0) <> "["c Then
                    Return "[" + name + "]"
                End If
            End If
            Return name
        End Function
        Public Function jcon( _
        ByVal jtab As info2) As String
            If Me.mtable2 Then
                Throw New System.Exception("Internal error 1")
            End If
            Dim sql As String = ""
            If jtab.mtable2 Then
                sql = Me.cname.Trim + "." + jtab.mpolj.POLJE + "=" + jtab.cname.Trim + "." + jtab.mpolj.RelPolje
            Else
                For Each col As String In Me.mkolona5
                    If sql <> "" Then
                        sql += " and "
                    End If
                    sql += Me.cname.Trim + "." + col + "=" + jtab.cname.Trim + "." + col
                Next
            End If
            Return sql
        End Function

        Public Function PrikaziKolonu() As String
            Dim sql As String
            If Me.KoloneZaInsert.Length = 0 Then
                sql = Me.name2name
            Else
                Dim sql2 As String = Me.name2name
                Dim ti2 As info2
                For Each ti2 In Me.KoloneZaInsert
                    If sql2 <> Me.name2name Then
                        sql2 = "(" + sql2 + ")"
                    End If
                    sql2 += " left join " + ti2.name2name + " on " + Me.jcon(ti2)
                Next
                sql = "(" + sql2 + ")"
            End If
            Return sql
        End Function

        Public ReadOnly Property KoloneZaInsert() As info2()
            Get
                Return Me.tabelezaprikaz
            End Get
        End Property

        Public Sub AppendRelTabela(ByVal ti As info2)
            ReDim Preserve Me.tabelezaprikaz(1 + Me.tabelezaprikaz.GetUpperBound(0))
            Me.tabelezaprikaz(Me.tabelezaprikaz.GetUpperBound(0)) = ti
        End Sub

        Public Sub New( _
        ByVal corelationName As String, _
        ByVal row As System.Data.DataRow, _
        ByVal rBaza As DatasetIstrazivanja.ISTBAZERow, _
        ByVal vremenskaTacka As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, _
        ByVal connectionString As String)
            Me.cname = corelationName
            Me.mkontrola = vremenskaTacka
            Me.tabelezaprikaz = New info2() {}
            ism = False
            If row.Table.TableName = "Kolone" Then
                Me.s = connectionString
                Me.mtable2 = False
                Me.m_rowBaza = rBaza
                Me.mpolj = CType(row, DatasetIstrazivanja.ISTPOLJARow)
                Me.mkolona5 = New String() {}
                Dim r As DatasetIstrazivanja.ISTPOLJARow
                For Each r In CType(row.Table, DatasetIstrazivanja.ISTPOLJADataTable).Rows
                    If r.TABELA = Me.mpolj.TABELA Then
                        Me.ism = Not r.ISTTABELERowParent.IsDGNull AndAlso r.ISTTABELERowParent.DG.Trim.ToUpper = "G"
                        If col2(r) Then
                            ReDim Preserve Me.mkolona5(1 + Me.mkolona5.GetUpperBound(0))
                            Me.mkolona5(Me.mkolona5.GetUpperBound(0)) = r.POLJE
                        End If
                    End If
                Next
                Me.name2name = tabela_sql(rBaza, Nothing, Me.mpolj.TABELA) + " " + corelationName
            Else
                Me.mtable2 = True
                Dim rKonsult As DatasetTabeliranje.KonsultRow
                rKonsult = CType(row, DatasetTabeliranje.KonsultRow)
                Me.mpolj = CType(rKonsult.GetParentRow(rKonsult.Table.ParentRelations(0)), DatasetIstrazivanja.ISTPOLJARow)
                Me.mkolona5 = New String() {Me.mpolj.RelPolje}
                Dim tBaze As DatasetIstrazivanja.ISTBAZEDataTable
                tBaze = CType(rBaza.Table, DatasetIstrazivanja.ISTBAZEDataTable)
                Me.m_rowBaza = tBaze.FindByBaza(Me.mpolj.RelBaza)
                Me.s = paramStr(eSQLServerAuthentication.eSQLServer, Me.m_rowBaza, "", "")
                Me.name2name = tabela_sql(rBaza, Me.m_rowBaza, Me.mpolj.RelTabela.Trim)
                Me.name2name += " " + Me.cname
            End If
        End Sub
        Public Enum eSQLServerAuthentication
            eWindows
            eSQLServer
        End Enum

        Public Function paramStr( _
        ByVal auth As eSQLServerAuthentication, _
        ByVal r As DatasetIstrazivanja.ISTBAZERow, _
        ByVal userID As String, _
        ByVal password As String) As String
            If r.ISTRDBMSRow.FIZBAZA.Trim.ToLower = "ss" _
            AndAlso auth = eSQLServerAuthentication.eWindows Then
                Dim s As String
                If r.IsIzrazOLENull _
                OrElse r.IzrazOLE.Trim = "" Then
                    s = r.IzrazODBC.Trim
                Else : s = r.IzrazOLE.Trim
                End If
                Dim connStr As String = s + ";Integrated Security=SSPI;Persist Security Info=False"
                Return connStr
            End If
            Dim sUSERID_PASSWORD As String = ""
            If userID <> "" Then
                sUSERID_PASSWORD += "User ID=" + userID
            End If
            If password <> "" Then
                If sUSERID_PASSWORD <> "" Then
                    sUSERID_PASSWORD += ";"
                End If
                sUSERID_PASSWORD += "Password=" + password
            End If
            If sUSERID_PASSWORD <> "" Then
                sUSERID_PASSWORD = ";" + sUSERID_PASSWORD
            End If
            If r.IsIzrazOLENull _
            OrElse r.IzrazOLE.Trim = "" Then
                Dim sODBC As String = r.IzrazODBC.Trim.ToLower
                sODBC = sODBC.Replace("driver={sql server}", "Provider=SQLOLEDB.1")
                If sODBC.IndexOf("password") >= 0 _
                OrElse sODBC.IndexOf("pwd") >= 0 Then
                    Return sODBC
                End If
                If sODBC.Chars(sODBC.Length - 1) = ";"c Then
                    sODBC = sODBC.Substring(0, sODBC.Length - 1)
                End If
                Return sODBC + sUSERID_PASSWORD
            End If
            If r.IzrazOLE.ToLower.IndexOf("password") >= 0 Then
                Return r.IzrazOLE
            End If
            Return r.IzrazOLE.Trim + sUSERID_PASSWORD
        End Function
        Public Function col2(ByVal r As DatasetIstrazivanja.ISTPOLJARow) As Boolean
            If Not r.IsKLJUCNull _
            AndAlso r.KLJUC.Trim.ToUpper = "P" Then
                Return True
            End If
            Return False
        End Function
    End Structure

    Private Sub Tabele2(ByVal kolone2() As kinf2, ByRef tabele() As info2, ByRef kolone3() As kinf3)
        ReDim kolone3(kolone2.GetUpperBound(0))
        Dim kiIndex As Integer = -1
        For Each ki As kinf2 In kolone2
            kiIndex += 1
            Do
                If Not ki.k.IsChild Then
                    Dim ti As info2
                    For Each ti In tabele
                        If ti.cname = ki.ptcor Then
                            kolone3(kiIndex) = New kinf3(ki, ti)
                            Exit Do
                        End If
                    Next
                    ti = New info2(ki.ptcor, ki.k.row, Me.rb, Me.UserControlVremenskaTacka1, Me.mstr)
                    ReDim Preserve tabele(1 + tabele.GetUpperBound(0))
                    tabele(tabele.GetUpperBound(0)) = ti
                    kolone3(kiIndex) = New kinf3(ki, ti)
                Else
                    For i As Integer = 0 To tabele.GetUpperBound(0)
                        If tabele(i).cname = ki.ptcor Then
                            For j As Integer = 0 To tabele(i).KoloneZaInsert.GetUpperBound(0)
                                If tabele(i).KoloneZaInsert(j).cname = ki.ctcorname Then
                                    kolone3(kiIndex) = New kinf3(ki, tabele(i).KoloneZaInsert(j))
                                    Exit Do
                                End If
                            Next
                            Dim ti2 As New info2(ki.ctcorname, ki.k.row, Me.rb, Me.UserControlVremenskaTacka1, Me.mstr)
                            tabele(i).AppendRelTabela(ti2)
                            kolone3(kiIndex) = New kinf3(ki, ti2)
                            Exit Do
                        End If
                    Next
                    Dim ti As New info2(ki.ptcor, ki.k.row.GetParentRow(ki.k.row.Table.ParentRelations(0)), Me.rb, Me.UserControlVremenskaTacka1, Me.mstr)
                    Dim ti3 As New info2(ki.ctcorname, ki.k.row, Me.rb, Me.UserControlVremenskaTacka1, Me.mstr)
                    ti.AppendRelTabela(ti3)
                    kolone3(kiIndex) = New kinf3(ki, ti3)
                    ReDim Preserve tabele(1 + tabele.GetUpperBound(0))
                    tabele(tabele.GetUpperBound(0)) = ti
                End If
            Loop While False
        Next
    End Sub

    Private Function GetStringKolona(ByVal w() As info2) As String
        Dim sql As String
        If w.Length > 1 Then
            Dim tip As info2
            Do
                For Each tip In w
                    If tip.ism Then
                        Exit Do
                    End If
                Next
                Dim r As DatasetIstrazivanja.ISTPOLJARow
                For Each r In Me.mtpolj.Rows
                    If r.ISTTABELERowParent.DG.Trim.ToUpper = "G" Then
                        tip = New info2(r.TABELA, r, Me.rb, Me.UserControlVremenskaTacka1, Me.mstr)
                        Exit Do
                    End If
                Next
                sql = ""
                For Each ti As info2 In w
                    If sql <> "" Then
                        sql += ","
                    End If
                    sql += ti.PrikaziKolonu
                Next
                Return sql
            Loop
            sql = tip.PrikaziKolonu
            Dim bFirst As Boolean = True
            For Each ti As info2 In w
                If Not ti.ism Then
                    If bFirst Then
                        bFirst = False
                    Else : sql = "(" + sql + ")"
                    End If
                    sql += " right join " + ti.PrikaziKolonu + " on " + tip.jcon(ti)
                End If
            Next
        Else : sql = w(0).PrikaziKolonu
        End If
        Return sql
    End Function

    Private Class Names
        Private ns() As cinf = {}

        Private Structure cinf
            Dim nameform As String
            Dim names2 As String
            Public Sub New(ByVal nameform As String, ByVal names2 As String)
                Me.nameform = nameform
                Me.names2 = names2
            End Sub
        End Structure
        Public Sub Append(ByVal corform As String)
            Dim ci As cinf
            For Each ci In Me.ns
                If ci.nameform = corform Then
                    Return
                End If
            Next
            ci = New cinf(corform, "t_" + Me.ns.Length.ToString)
            ReDim Preserve Me.ns(1 + Me.ns.GetUpperBound(0))
            Me.ns(Me.ns.GetUpperBound(0)) = ci
        End Sub

        Public Function ForKolona(ByVal corelationNameForForm As String) As String
            Dim ci As cinf
            For Each ci In Me.ns
                If ci.nameform = corelationNameForForm Then
                    Return ci.names2
                End If
            Next
            Throw New System.Exception("Tabeliranje")
        End Function
    End Class

    Private Function UradiPrikaz(ByVal b As Boolean, ByRef kolonauPrikazu As String, ByRef kolonaDodata As String) As String
        kolonauPrikazu = ""
        kolonaDodata = ""
        Dim cn As New Names
        For Each ki As kinf In Me.mpret
            If ki.IsChild Then
                cn.Append(ki.relForm)
            End If
            cn.Append(ki.ptName)
        Next
        For Each ki As kinf In Me.mgl
            If ki.IsChild Then
                cn.Append(ki.relForm)
            End If
            cn.Append(ki.ptName)
        Next
        Dim koloneW(Me.mpret.GetUpperBound(0)) As kinf2
        For j As Integer = 0 To Me.mpret.GetUpperBound(0)
            If Me.mpret(j).IsChild Then
                koloneW(j) = New kinf2(Me.mpret(j), cn.ForKolona(Me.mpret(j).ptName), cn.ForKolona(Me.mpret(j).relForm))
            Else : koloneW(j) = New kinf2(Me.mpret(j), cn.ForKolona(Me.mpret(j).ptName), "")
            End If
        Next
        Dim koloneQ(Me.mgl.GetUpperBound(0)) As kinf2
        For j As Integer = 0 To Me.mgl.GetUpperBound(0)
            If Me.mgl(j).IsChild Then
                koloneQ(j) = New kinf2(Me.mgl(j), cn.ForKolona(Me.mgl(j).ptName), cn.ForKolona(Me.mgl(j).relForm))
            Else : koloneQ(j) = New kinf2(Me.mgl(j), cn.ForKolona(Me.mgl(j).ptName), "")
            End If
        Next
        Dim tabele() As info2 = {}
        Dim koloneA() As kinf3
        Me.Tabele2(koloneW, tabele, koloneA)
        Dim glavneKolone3() As kinf3
        Me.Tabele2(koloneQ, tabele, glavneKolone3)
        Dim sKolona As String = ""
        Dim ssKolona As String = ""
        Dim gb As String = ""
        Dim iPretkolona As Integer = -1
        Dim kolonaUSQL As String = ""
        Dim jkKolona As Integer
        For Each pk As kinf2 In koloneW
            iPretkolona += 1
            Dim colCaption As String = nshr_2(Me.rb.ISTRDBMSRow, pk.k.ccforr)
            If Me.CheckedListBoxPretkolone.CheckedItems.Count = 1 AndAlso Me.CheckedListBoxPretkolone.CheckedIndices(0) = iPretkolona Then
                kolonauPrikazu = colCaption
                kolonaUSQL = pk.ColPref
                jkKolona = iPretkolona
            Else
                If sKolona <> "" Then
                    sKolona += ","
                    ssKolona += ","
                End If
                sKolona += pk.ColPref
                ssKolona += pk.ColPref
            End If
            If kolonaUSQL <> pk.ColPref OrElse Not b Then
                If gb <> "" Then
                    gb += ","
                End If
                gb += pk.ColPref + " as """ + colCaption + """"
            End If
        Next
        If kolonaUSQL <> "" AndAlso Not b Then
            If sKolona <> "" Then
                sKolona += ","
            End If
            sKolona += kolonaUSQL
            If ssKolona <> "" Then
                ssKolona += ","
            End If
            ssKolona += kolonaUSQL
        End If
        Dim sexpr As String = ""
        If b AndAlso kolonaUSQL <> "" AndAlso Me.tgk.Rows.Count = 1 Then
            Dim i As Integer = -1
            Dim funkcija As String
            For Each r As DatasetTabeliranje.GlavneKoloneRow In Me.tgk.Rows
                i += 1
                Dim ki As kinf = Me.mgl(i)
                kolonaDodata = ki.COLPref
                funkcija = Me.getcol(r.Funkcija).Name
                Exit For
            Next
            sexpr = Me.GetString3(kolonaUSQL, jkKolona, koloneA(jkKolona), kolonaDodata, funkcija)
        Else
            Dim i As Integer = -1
            For Each r As DatasetTabeliranje.GlavneKoloneRow In Me.tgk.Rows
                i += 1
                Dim kolona As kinf2 = koloneQ(i)
                If sexpr <> "" Then
                    sexpr += ","
                End If
                Dim cc As String = nshr_2(Me.rb.ISTRDBMSRow, kolona.k.ccforr + " - " + r.Funkcija)
                If Me.tgk.Rows.Count = 1 Then
                    kolonaDodata = cc
                End If
                sexpr += Me.getcol(r.Funkcija).Name + "(" + kolona.ColPref + ") as """ + cc + """"
            Next
        End If
        Dim sql As String = ""
        If gb <> "" Then
            sql += gb
        End If
        If sexpr <> "" Then
            If sql <> "" Then
                sql += ","
            End If
            sql += sexpr
        End If
        If sql = "" Then
            System.Windows.Forms.MessageBox.Show("Dodajte bar jednu kolonu", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            Return sql
        End If
        sql = "select " + sql + " from " + Me.GetStringKolona(tabele)
        Dim sw As String = Me.GETW(tabele)
        If sw <> "" Then
            sql += " where " + sw
        End If
        If sKolona <> "" Then
            sql += " group by " + sKolona
            sql += " order by " + ssKolona
        End If
        Return sql
    End Function

    Public Function nshr_2( _
    ByVal rowRDBMS As DatasetIstrazivanja.ISTRDBMSRow, _
    ByVal name As String) As String
        If rowRDBMS.FIZBAZA.Trim.ToLower = "db2" Then
            If name.Length > 18 Then
                Return name.Substring(0, 18)
            End If
        End If
        Return name
    End Function

    Private Function GETW( _
    ByVal tabele() As info2) As String
        Dim sql As String = ""
        For Each ti As info2 In tabele
            Dim sv As String = ti.getpoljeutabeli()
            If sv <> "" Then
                If sql <> "" Then
                    sql += " and "
                End If
                sql += sv
            End If
            For Each ti2 As info2 In ti.KoloneZaInsert
                sv = ti2.getpoljeutabeli()
                If sv <> "" Then
                    If sql <> "" Then
                        sql += " and "
                    End If
                    sql += sv
                End If
            Next
        Next
        Return sql
    End Function

    Private Function GetString3( _
    ByVal kolonaUSQL As String, _
    ByVal jkKolona As Integer, _
    ByVal pk As kinf3, _
    ByVal kolonaDodata As String, _
    ByVal f As String) As String
        Dim ki As kinf = Me.mpret(jkKolona)
        Dim sql As String
        sql = "select distinct " + kolonaUSQL
        sql += " from " + pk.table.name2name
        Dim v As String = pk.table.getpoljeutabeli
        If v <> "" Then
            sql += " where " + v
        End If
        Dim t As New System.Data.DataTable
        Dim adp As New System.Data.OleDb.OleDbDataAdapter(sql, pk.table.s)
        Try
            adp.Fill(t)
        Finally
            adp.Dispose()
            t.Dispose()
        End Try
        Dim s As String = ""
        For Each r As System.Data.DataRow In t.Rows
            If s <> "" Then
                s += ","
            End If
            Dim asStr As String
            Dim val As String
            If r.IsNull(0) Then
                val = " is null "
                asStr = "null"
            Else
                val = CStr(r.Item(0))
                asStr = val
                If r.Item(0).GetType Is GetType(String) Then
                    val = "'" + val + "'"
                End If
                val = "=" + val
            End If
            s += f + "(case when(" + kolonaUSQL + val + ") then " + kolonaDodata + " else null end)"
            s += " as """ + asStr + """"
        Next
        Return s
    End Function

    Private Sub prikazi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIzvestaj.Click
        Dim pdod As String
        Dim kdod As String
        Dim sql As String
        Try
            sql = Me.UradiPrikaz(False, pdod, kdod)
        Catch ex2 As System.Exception
            System.Windows.Forms.MessageBox.Show(ex2.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            Return
        End Try
        If sql = "" Then
            Return
        End If
        Dim adp As New System.Data.OleDb.OleDbDataAdapter(sql, Me.mstr)
        Dim t As New System.Data.DataTable("Izveštaj")
        Dim ex As System.Exception = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            adp.Fill(t)
        Catch ex2 As System.Exception
            ex = ex2
        Finally
            adp.Dispose()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        If Not ex Is Nothing Then
            t.Dispose()
            System.Windows.Forms.MessageBox.Show(ex.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            Return
        End If
        Dim t2 As System.Data.DataTable = Me.GetTable(t, pdod, kdod)
        If Not t2 Is Nothing Then
            t.Dispose()
            t = t2
        End If
        Dim frm As New FormTabeliranjeIzvestaj(Me.ftab)
        Try
            frm.ShowDialog(t)
        Catch ex3 As System.Exception
            System.Windows.Forms.MessageBox.Show(ex3.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try
        frm.Dispose()
        t.Dispose()
    End Sub

    Private Sub kolone_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles CheckedListBoxPretkolone.ItemCheck
        If e.NewValue = System.Windows.Forms.CheckState.Checked Then
            For Each i As Integer In Me.CheckedListBoxPretkolone.CheckedIndices
                If i <> e.Index Then
                    Me.CheckedListBoxPretkolone.SetItemChecked(i, False)
                End If
            Next
        End If
    End Sub

    Private Function GetTable(ByVal t As System.Data.DataTable, ByVal pdod As String, ByVal kdod As String) As System.Data.DataTable
        If Me.CheckedListBoxPretkolone.CheckedItems.Count <> 1 OrElse Me.tgk.Rows.Count <> 1 Then
            Return Nothing
        End If
        Dim pk As System.Data.DataColumn = t.Columns(pdod)
        Dim kolona As System.Data.DataColumn = t.Columns(kdod)
        Dim t2 As New System.Data.DataTable(t.TableName)
        For Each col2 As System.Data.DataColumn In t.Columns
            If Not col2 Is pk AndAlso Not col2 Is kolona Then
                t2.Columns.Add(col2.ColumnName, col2.DataType)
            End If
        Next
        Dim r3 As System.Data.DataRow = Nothing
        For Each r As System.Data.DataRow In t.Rows
            Dim cn As String
            If r.IsNull(pk.Ordinal) Then
                cn = "(null)"
            Else : cn = CStr(r.Item(pk.Ordinal))
            End If
            cn += System.Environment.NewLine
            cn += pk.ColumnName + "/" + kolona.ColumnName
            Dim bFound As Boolean = False
            Dim col As System.Data.DataColumn
            For Each col In t2.Columns
                If col.ColumnName = cn Then
                    bFound = True
                    Exit For
                End If
            Next
            If Not bFound Then
                col = t2.Columns.Add(cn, kolona.DataType)
            End If
            Dim bEqual As Boolean = True
            If r3 Is Nothing Then
                bEqual = False
            Else
                For Each col2 As System.Data.DataColumn In t.Columns
                    If Not col2 Is pk _
                    AndAlso Not col2 Is kolona Then
                        If Not Object.Equals(r3.Item(col2.Ordinal), r.Item(col2.Ordinal)) Then
                            bEqual = False
                            Exit For
                        End If
                    End If
                Next
            End If
            If bEqual Then
                t2.Rows(t2.Rows.Count - 1).Item(col.Ordinal) = r.Item(kolona.Ordinal)
            Else
                Dim values(t2.Columns.Count - 1) As Object
                For j As Integer = 0 To values.GetUpperBound(0)
                    values(j) = System.DBNull.Value
                Next
                Dim r2 As System.Data.DataRow = t2.Rows.Add(values)
                r2.Item(col.Ordinal) = r.Item(kolona.Ordinal)
                For Each col2 As System.Data.DataColumn In t.Columns
                    If Not col2 Is pk AndAlso Not col2 Is kolona Then
                        r2.Item(col2.ColumnName) = r.Item(col2.ColumnName)
                    End If
                Next
            End If
            r3 = r
        Next
        Return t2
    End Function

    Private Sub Kolone( _
    ByVal pk As System.Xml.XmlNode, _
    ByVal kolone As String, _
    ByVal b As Boolean)
        Dim i As Integer = -1
        For Each node As System.Xml.XmlNode In pk.SelectNodes(kolone)
            Dim r As System.Data.DataRow
            If node.Attributes("konsult") Is Nothing Then
                With Me.mtpolj
                    r = .FindBySIFISTTABELAPOLJE(node.Attributes(.SIFISTColumn.ColumnName).Value, node.Attributes(.TABELAColumn.ColumnName).Value, node.Attributes(.POLJEColumn.ColumnName).Value)
                End With
            Else
                With Me.tkon
                    r = .FindBySIFISTTABELAPOLJERELTABELARELPOLJERELBAZA(node.Attributes(.SIFISTColumn.ColumnName).Value, node.Attributes(.TABELAColumn.ColumnName).Value, node.Attributes(.POLJEColumn.ColumnName).Value, node.Attributes(.RELTABELAColumn.ColumnName).Value, node.Attributes(.RELPOLJEColumn.ColumnName).Value, node.Attributes(.RELBAZAColumn.ColumnName).Value)
                End With
            End If
            If b Then
                Me.dod(r)
                Dim a As System.Xml.XmlAttribute = node.Attributes("Razvrstati")
                If Not a Is Nothing Then
                    i = CInt(a.Value)
                End If
            Else : Me.kolone2(r, node.Attributes("funkcija").Value)
            End If
        Next
        If i >= 0 Then
            Me.CheckedListBoxPretkolone.SetItemChecked(i, True)
        End If
    End Sub

    Private Sub MenuItemSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSave.Click
        If Me.fn <> "" Then
        Else : Me.MenuItemSaveAs_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub MenuItemSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSaveAs.Click
        If Me.mtpolj.Rows.Count = 0 Then
            Return
        End If
        Dim dlg As New System.Windows.Forms.SaveFileDialog
        dlg.Title = "Save"
        dlg.InitialDirectory = Me.ftab
        dlg.FileName = CType(Me.mtpolj.Rows(0), DatasetIstrazivanja.ISTPOLJARow).SIFIST.Trim + "_Tabeliranje1"
        dlg.Filter = "Tabeliranje fajlovi (*.tbl)|*.tbl"
        If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
            End If
        End If
        dlg.Dispose()
    End Sub

    Private Sub MySetCaption(ByVal text As String)
        Me.Text = "Tabeliranje - " + text.Trim
    End Sub

    Private Sub MenuItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonIzlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIzlaz.Click
        Me.Close()
    End Sub

    Private Sub ButtonPostojeciExcelIzvestaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPostojeciExcelIzvestaj.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim dlg As New System.Windows.Forms.OpenFileDialog
        dlg.InitialDirectory = Me.ftab
        dlg.Filter = "Excel files (*.xls)|*.xls"
        dlg.FileName = dlg.InitialDirectory + "\Report1"
        If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK AndAlso dlg.FileName <> "" Then
            start(dlg.FileName, True, "", "")
        End If
        dlg.Dispose()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Public Sub start(ByVal fn As String, ByVal b As Boolean, ByVal wd As String, ByVal a As String)
        Dim p As New System.Diagnostics.ProcessStartInfo
        p.FileName = fn
        p.UseShellExecute = b
        If p.UseShellExecute Then
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Else
            p.WorkingDirectory = wd
            p.Arguments = a
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
        Try
            System.Diagnostics.Process.Start(p)
        Catch e As System.Exception
            System.Windows.Forms.MessageBox.Show(e.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub
    Private Sub izvestaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemExportSQL.Click
        Dim pretkolonaDodata As String
        Dim kolonaDodata As String
        Dim sql As String
        Try
            sql = Me.UradiPrikaz(True, pretkolonaDodata, kolonaDodata)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            Return
        End Try
        If sql = "" Then
            Return
        End If
        Dim dlg As New System.Windows.Forms.SaveFileDialog
        dlg.Title = "Export SQL"
        dlg.InitialDirectory = Me.ftab
        dlg.FileName = CType(Me.mtpolj.Rows(0), DatasetIstrazivanja.ISTPOLJARow).SIFIST.Trim + "_Tabeliranje_SQL1"
        dlg.Filter = "SQL scripts (*.sql)|*.sql"
        If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Dim sw As System.IO.StreamWriter
                Try
                    sw = System.IO.File.CreateText(dlg.FileName)
                    sw.WriteLine(sql)
                    sw.Close()
                    sw = Nothing
                    System.Windows.Forms.MessageBox.Show("SQL sačuvan.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
                Finally
                    If Not sw Is Nothing Then
                        sw.Close()
                    End If
                End Try
            End If
        End If
        dlg.Dispose()
    End Sub

    Private Sub FormTabeliranje_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.rc.Save()
    End Sub
End Class