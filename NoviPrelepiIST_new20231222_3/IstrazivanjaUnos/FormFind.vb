Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormFind
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
    Friend WithEvents BtnFindNext As System.Windows.Forms.Button
    Friend WithEvents PanelContext As Panel
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents cboWhere As ComboBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents meText As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelBottom As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFind))
        Me.BtnFindNext = New System.Windows.Forms.Button()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cboWhere = New System.Windows.Forms.ComboBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.meText = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottom.SuspendLayout()
        Me.PanelContext.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFindNext
        '
        Me.BtnFindNext.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnFindNext.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindNext.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFindNext.Location = New System.Drawing.Point(113, 3)
        Me.BtnFindNext.Name = "BtnFindNext"
        Me.BtnFindNext.Size = New System.Drawing.Size(76, 24)
        Me.BtnFindNext.TabIndex = 1
        Me.BtnFindNext.Text = "Find next"
        Me.BtnFindNext.UseVisualStyleBackColor = False
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelBottom.Controls.Add(Me.BtnFindNext)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 128)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(200, 30)
        Me.PanelBottom.TabIndex = 38
        '
        'PanelContext
        '
        Me.PanelContext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContext.Controls.Add(Me.gbOptions)
        Me.PanelContext.Controls.Add(Me.txtFind)
        Me.PanelContext.Controls.Add(Me.cboWhere)
        Me.PanelContext.Controls.Add(Me.PanelBottom)
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(0, 40)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(202, 160)
        Me.PanelContext.TabIndex = 41
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cb2)
        Me.gbOptions.Controls.Add(Me.cb1)
        Me.gbOptions.Location = New System.Drawing.Point(11, 53)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(145, 65)
        Me.gbOptions.TabIndex = 40
        Me.gbOptions.TabStop = False
        '
        'cb2
        '
        Me.cb2.AccessibleDescription = " "
        Me.cb2.AutoSize = True
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb2.Location = New System.Drawing.Point(12, 38)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(116, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Match whole cell"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb1.Location = New System.Drawing.Point(12, 17)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(86, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Match case"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFind.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtFind.Location = New System.Drawing.Point(11, 5)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(145, 20)
        Me.txtFind.TabIndex = 1
        '
        'cboWhere
        '
        Me.cboWhere.CausesValidation = False
        Me.cboWhere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboWhere.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboWhere.FormattingEnabled = True
        Me.cboWhere.Items.AddRange(New Object() {"Current table", "Current column"})
        Me.cboWhere.Location = New System.Drawing.Point(11, 28)
        Me.cboWhere.Name = "cboWhere"
        Me.cboWhere.Size = New System.Drawing.Size(145, 21)
        Me.cboWhere.TabIndex = 26
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.meText)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(202, 40)
        Me.PanelTop.TabIndex = 145
        '
        'meText
        '
        Me.meText.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.meText.BackColor = System.Drawing.Color.Transparent
        Me.meText.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.meText.ForeColor = System.Drawing.Color.DarkOrange
        Me.meText.Location = New System.Drawing.Point(5, 0)
        Me.meText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.meText.Name = "meText"
        Me.meText.Size = New System.Drawing.Size(135, 40)
        Me.meText.TabIndex = 59
        Me.meText.Tag = "nediraj"
        Me.meText.Text = "Find"
        Me.meText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnCerrar.Location = New System.Drawing.Point(160, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 146
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FormFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(202, 200)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelContext.ResumeLayout(False)
        Me.PanelContext.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _parentForm As Form
    Public kolona As String
    Private m_DataGridView As DataGridView
    Private m_SearchStartRow As Integer
    Private m_SearchStartColumn As Integer
    Private m_SearchSelectionIndex As Integer
    Private m_SelectedCells As List(Of DataGridViewCell)

    Public Sub New(ByVal form As Form, ByVal datagridview As DataGridView, ByVal kolona As String, ByVal tvRight As Integer, ByVal tvTop As Integer)
        InitializeComponent()
        Me.kolona = kolona
        _parentForm = form
        AddHandler Me.Paint, AddressOf DrawBorder
        m_SelectedCells = New List(Of DataGridViewCell)()
        InitializeForm(datagridview)
        With Me
            .TopMost = True
            .Left = tvRight - Me.Width - 20
            .Top = tvTop + 30
        End With
        Call SetLang()
    End Sub
    Private Sub SetLang()

        'Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")

    End Sub
    Private Sub DrawBorder(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim rect1 As New Rectangle(cboWhere.Location.X - 1, cboWhere.Location.Y - 1, cboWhere.Width + 1, cboWhere.Height + 1)
        Dim pen As New Pen(Color.Black, 1)
        Dim g As Graphics = e.Graphics
        g.DrawRectangle(pen, rect1)
    End Sub

    Public Sub InitializeForm(ByVal datagridview As DataGridView)
        If Not m_DataGridView Is datagridview Then
            If m_DataGridView IsNot Nothing Then RemoveHandler m_DataGridView.MouseClick, AddressOf DataGridView_MouseClick
            m_DataGridView = datagridview
            AddHandler m_DataGridView.MouseClick, AddressOf DataGridView_MouseClick
            AddHandler m_DataGridView.SelectionChanged, AddressOf DataGridView_SelectionChanged
        End If
        If m_DataGridView.SelectedCells.Count > 1 Then
            Me.cboWhere.SelectedIndex = 1
        Else
            Me.cboWhere.SelectedIndex = 0
        End If
        If m_DataGridView.CurrentCell IsNot Nothing Then
            m_SearchStartRow = m_DataGridView.CurrentCell.RowIndex
            m_SearchStartColumn = m_DataGridView.CurrentCell.ColumnIndex
            If m_DataGridView.CurrentCell.Value IsNot Nothing Then
                Me.txtFind.Text = m_DataGridView.CurrentCell.Value.ToString()
            End If
        End If
        SelectionCellsChanged()
    End Sub

    Private Sub DataGridView_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        SelectionCellsChanged()
    End Sub

    Private Sub SelectionCellsChanged()
        m_SearchSelectionIndex = 0
        m_SelectedCells.Clear()
        For Each cell As DataGridViewCell In m_DataGridView.SelectedCells
            m_SelectedCells.Add(cell)
        Next
    End Sub

    Private Sub DataGridView_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim hitTest As DataGridView.HitTestInfo = m_DataGridView.HitTest(e.X, e.Y)
            If hitTest.Type = DataGridViewHitTestType.Cell Then
                m_SearchStartRow = hitTest.RowIndex
                m_SearchStartColumn = hitTest.ColumnIndex
            End If
        End If
    End Sub

    Private Sub BtnFindNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFindNext.Click
        Dim FindCell As DataGridViewCell = Nothing
        If Me.cboWhere.SelectedIndex = 0 Then
            FindCell = FindInTable(True)
        ElseIf Me.cboWhere.SelectedIndex = 1 Then
            Dim iSearchStartColumn As Integer = m_DataGridView.CurrentCell.ColumnIndex
            FindCell = FindInTable(True, iSearchStartColumn) 'FindInColumn()
        End If
        If FindCell IsNot Nothing Then
            Dim cells As DataGridViewCell() = m_SelectedCells.ToArray()
            Dim iSearchIndex As Integer = m_SearchSelectionIndex
            m_DataGridView.CurrentCell = FindCell
            m_SearchSelectionIndex = iSearchIndex
            m_SelectedCells.Clear()
            m_SelectedCells.AddRange(cells)
        End If
    End Sub

    Private Function FindInTable(ByVal bStopOnFind As Boolean, Optional ByVal currentcolumn As Integer = -1) As DataGridViewCell
        If m_DataGridView.CurrentCell Is Nothing Then Return Nothing
        Dim sFindWhat As String = Me.txtFind.Text
        Dim bMatchCase As Boolean = Me.cb1.Checked
        Dim bMatchCell As Boolean = Me.cb2.Checked

        Dim iSearchMethod As Integer = -1
        iSearchMethod = Me.cboWhere.SelectedIndex
        Dim iSearchStartRow As Integer = m_DataGridView.CurrentCell.RowIndex
        Dim iSearchStartColumn As Integer
        If currentcolumn <> -1 Then
            iSearchStartColumn = currentcolumn
        Else
            iSearchStartColumn = m_DataGridView.CurrentCell.ColumnIndex
        End If

        Dim iRowIndex As Integer = m_DataGridView.CurrentCell.RowIndex
        Dim iColIndex As Integer = m_DataGridView.CurrentCell.ColumnIndex

        iColIndex = iColIndex + 1
        If iColIndex >= m_DataGridView.ColumnCount Then
            iColIndex = 0
            iRowIndex += 1
        End If
        If iRowIndex >= m_DataGridView.RowCount Then
            iRowIndex = 0
        ElseIf iRowIndex < 0 Then
            iRowIndex = m_DataGridView.RowCount - 1
        End If

        While Not (iRowIndex = iSearchStartRow AndAlso iColIndex = iSearchStartColumn)
            ' Search end of search
            Dim FindCell As DataGridViewCell = Nothing
            If fFindString(m_DataGridView(iColIndex, iRowIndex), sFindWhat, bMatchCase, bMatchCell, iSearchMethod) Then
                FindCell = m_DataGridView(iColIndex, iRowIndex)
            End If
            If bStopOnFind AndAlso FindCell IsNot Nothing Then Return FindCell
            iColIndex = iColIndex + 1
            If iColIndex >= m_DataGridView.ColumnCount Then
                iColIndex = 0
                iRowIndex = iRowIndex + 1
            ElseIf iColIndex < 0 Then
                iColIndex = m_DataGridView.ColumnCount - 1
                iRowIndex = iRowIndex - 1
            End If
            If iRowIndex >= m_DataGridView.RowCount Then
                iRowIndex = 0
            ElseIf iRowIndex < 0 Then
                iRowIndex = m_DataGridView.RowCount - 1
            End If
        End While
        If fFindString(m_DataGridView(iColIndex, iRowIndex), sFindWhat, bMatchCase, bMatchCell, iSearchMethod) Then
            Return m_DataGridView(iColIndex, iRowIndex)
        End If
        Return Nothing
    End Function

    Private Function fFindString(ByVal SearchCell As DataGridViewCell, ByVal sFindWhat As String, ByVal bMatchCase As Boolean, ByVal bMatchCell As Boolean, ByVal iSearchMethod As Integer) As Boolean
        Dim SearchString As String = SearchCell.FormattedValue.ToString()
        Dim RegexPattern As String = sFindWhat
        If iSearchMethod = 1 Then RegexPattern = "^" + System.Text.RegularExpressions.Regex.Escape(sFindWhat).Replace("\*", ".*").Replace("\?", ".") + "$"
        Dim strCompare As System.Text.RegularExpressions.RegexOptions = System.Text.RegularExpressions.RegexOptions.None
        If Not bMatchCase Then strCompare = System.Text.RegularExpressions.RegexOptions.IgnoreCase
        Dim regex As New System.Text.RegularExpressions.Regex(RegexPattern, strCompare)
        If regex.IsMatch(SearchString) Then
            Return True
        End If
        Return False
    End Function

    Private Sub FormFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call setTheme(GetTheme())
        cboWhere.SelectedIndex = 0
        Me.txtFind.Focus()


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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class