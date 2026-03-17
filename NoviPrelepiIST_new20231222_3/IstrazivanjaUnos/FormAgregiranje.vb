Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class FormAgregiranje
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
    Friend WithEvents BtnAgregiraj As System.Windows.Forms.Button

    Private WithEvents btnResetG As System.Windows.Forms.Button
    Private WithEvents chkClose As System.Windows.Forms.CheckBox
    Private WithEvents dgvAgrColumns As System.Windows.Forms.DataGridView
    Private WithEvents btnDeleteLevelG As System.Windows.Forms.Button
    Private WithEvents btnAddLevelG As System.Windows.Forms.Button
    Private WithEvents dgvGroupByColumns As System.Windows.Forms.DataGridView
    Private WithEvents btnResetA As System.Windows.Forms.Button
    Private WithEvents btnDeleteLevelA As System.Windows.Forms.Button
    Private WithEvents btnAddLevelA As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOrder As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbFieldA As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbFieldG As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BtnCancel As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregiranje))
        Me.BtnAgregiraj = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.btnResetG = New System.Windows.Forms.Button()
        Me.chkClose = New System.Windows.Forms.CheckBox()
        Me.dgvAgrColumns = New System.Windows.Forms.DataGridView()
        Me.cmbOrder = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbFieldA = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnDeleteLevelG = New System.Windows.Forms.Button()
        Me.btnAddLevelG = New System.Windows.Forms.Button()
        Me.dgvGroupByColumns = New System.Windows.Forms.DataGridView()
        Me.cmbFieldG = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnResetA = New System.Windows.Forms.Button()
        Me.btnDeleteLevelA = New System.Windows.Forms.Button()
        Me.btnAddLevelA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAgrColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGroupByColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAgregiraj
        '
        Me.BtnAgregiraj.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.BtnAgregiraj.Location = New System.Drawing.Point(437, 265)
        Me.BtnAgregiraj.Name = "BtnAgregiraj"
        Me.BtnAgregiraj.Size = New System.Drawing.Size(96, 24)
        Me.BtnAgregiraj.TabIndex = 1
        Me.BtnAgregiraj.Text = "Агрегација"
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.BtnCancel.Location = New System.Drawing.Point(558, 263)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(96, 24)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Излаз"
        '
        'btnResetG
        '
        Me.btnResetG.Image = CType(resources.GetObject("btnResetG.Image"), System.Drawing.Image)
        Me.btnResetG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetG.Location = New System.Drawing.Point(215, 12)
        Me.btnResetG.Name = "btnResetG"
        Me.btnResetG.Size = New System.Drawing.Size(80, 23)
        Me.btnResetG.TabIndex = 13
        Me.btnResetG.Text = "Reset"
        Me.btnResetG.UseVisualStyleBackColor = True
        '
        'chkClose
        '
        Me.chkClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkClose.AutoSize = True
        Me.chkClose.Checked = True
        Me.chkClose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClose.Location = New System.Drawing.Point(6, 271)
        Me.chkClose.Name = "chkClose"
        Me.chkClose.Size = New System.Drawing.Size(151, 18)
        Me.chkClose.TabIndex = 12
        Me.chkClose.Text = "Close on Agreggate"
        Me.chkClose.UseVisualStyleBackColor = True
        '
        'dgvAgrColumns
        '
        Me.dgvAgrColumns.AllowUserToAddRows = False
        Me.dgvAgrColumns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAgrColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgrColumns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmbOrder, Me.cmbFieldA})
        Me.dgvAgrColumns.Location = New System.Drawing.Point(437, 64)
        Me.dgvAgrColumns.Name = "dgvAgrColumns"
        Me.dgvAgrColumns.RowHeadersWidth = 20
        Me.dgvAgrColumns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAgrColumns.Size = New System.Drawing.Size(625, 196)
        Me.dgvAgrColumns.TabIndex = 11
        '
        'cmbOrder
        '
        Me.cmbOrder.FillWeight = 60.9137!
        Me.cmbOrder.HeaderText = "∑ Total"
        Me.cmbOrder.Items.AddRange(New Object() {"Sum", "Avg", "Min", "Max", "Count", "StDev", "Var"})
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cmbOrder.Width = 200
        '
        'cmbFieldA
        '
        Me.cmbFieldA.FillWeight = 139.0863!
        Me.cmbFieldA.HeaderText = "Polje"
        Me.cmbFieldA.Items.AddRange(New Object() {"Sum", "Avg", "Min", "Max", "Count", "StDev", "Var"})
        Me.cmbFieldA.Name = "cmbFieldA"
        Me.cmbFieldA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmbFieldA.Width = 400
        '
        'btnDeleteLevelG
        '
        Me.btnDeleteLevelG.Image = CType(resources.GetObject("btnDeleteLevelG.Image"), System.Drawing.Image)
        Me.btnDeleteLevelG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteLevelG.Location = New System.Drawing.Point(107, 12)
        Me.btnDeleteLevelG.Name = "btnDeleteLevelG"
        Me.btnDeleteLevelG.Size = New System.Drawing.Size(104, 23)
        Me.btnDeleteLevelG.TabIndex = 10
        Me.btnDeleteLevelG.Text = "Delete Level"
        Me.btnDeleteLevelG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteLevelG.UseVisualStyleBackColor = True
        '
        'btnAddLevelG
        '
        Me.btnAddLevelG.Image = CType(resources.GetObject("btnAddLevelG.Image"), System.Drawing.Image)
        Me.btnAddLevelG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddLevelG.Location = New System.Drawing.Point(10, 12)
        Me.btnAddLevelG.Name = "btnAddLevelG"
        Me.btnAddLevelG.Size = New System.Drawing.Size(93, 23)
        Me.btnAddLevelG.TabIndex = 9
        Me.btnAddLevelG.Text = "Add Level"
        Me.btnAddLevelG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddLevelG.UseVisualStyleBackColor = True
        '
        'dgvGroupByColumns
        '
        Me.dgvGroupByColumns.AllowUserToAddRows = False
        Me.dgvGroupByColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGroupByColumns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmbFieldG})
        Me.dgvGroupByColumns.Location = New System.Drawing.Point(6, 64)
        Me.dgvGroupByColumns.Name = "dgvGroupByColumns"
        Me.dgvGroupByColumns.RowHeadersWidth = 20
        Me.dgvGroupByColumns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGroupByColumns.Size = New System.Drawing.Size(423, 196)
        Me.dgvGroupByColumns.TabIndex = 14
        '
        'cmbFieldG
        '
        Me.cmbFieldG.FillWeight = 139.0863!
        Me.cmbFieldG.HeaderText = "Polje"
        Me.cmbFieldG.Name = "cmbFieldG"
        Me.cmbFieldG.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmbFieldG.Width = 400
        '
        'btnResetA
        '
        Me.btnResetA.Image = CType(resources.GetObject("btnResetA.Image"), System.Drawing.Image)
        Me.btnResetA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetA.Location = New System.Drawing.Point(639, 12)
        Me.btnResetA.Name = "btnResetA"
        Me.btnResetA.Size = New System.Drawing.Size(80, 23)
        Me.btnResetA.TabIndex = 17
        Me.btnResetA.Text = "Reset"
        Me.btnResetA.UseVisualStyleBackColor = True
        '
        'btnDeleteLevelA
        '
        Me.btnDeleteLevelA.Image = CType(resources.GetObject("btnDeleteLevelA.Image"), System.Drawing.Image)
        Me.btnDeleteLevelA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteLevelA.Location = New System.Drawing.Point(531, 12)
        Me.btnDeleteLevelA.Name = "btnDeleteLevelA"
        Me.btnDeleteLevelA.Size = New System.Drawing.Size(104, 23)
        Me.btnDeleteLevelA.TabIndex = 16
        Me.btnDeleteLevelA.Text = "Delete Level"
        Me.btnDeleteLevelA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteLevelA.UseVisualStyleBackColor = True
        '
        'btnAddLevelA
        '
        Me.btnAddLevelA.Image = CType(resources.GetObject("btnAddLevelA.Image"), System.Drawing.Image)
        Me.btnAddLevelA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddLevelA.Location = New System.Drawing.Point(434, 12)
        Me.btnAddLevelA.Name = "btnAddLevelA"
        Me.btnAddLevelA.Size = New System.Drawing.Size(93, 23)
        Me.btnAddLevelA.TabIndex = 15
        Me.btnAddLevelA.Text = "Add Level"
        Me.btnAddLevelA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddLevelA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Груписати по:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Функција:"
        '
        'FormAgregiranje
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(1074, 294)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnResetA)
        Me.Controls.Add(Me.btnDeleteLevelA)
        Me.Controls.Add(Me.btnAddLevelA)
        Me.Controls.Add(Me.dgvGroupByColumns)
        Me.Controls.Add(Me.btnResetG)
        Me.Controls.Add(Me.chkClose)
        Me.Controls.Add(Me.dgvAgrColumns)
        Me.Controls.Add(Me.btnDeleteLevelG)
        Me.Controls.Add(Me.btnAddLevelG)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAgregiraj)
        
        Me.Name = "FormAgregiranje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAgrColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGroupByColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _allColumnsList As List(Of String)
    Private _parentForm As FormNaprednaPretragaUnos
    Private _dgvColumnListA As List(Of DataGridViewColumn)
    Private _dgvColumnListG As List(Of DataGridViewColumn)

    Public Sub New(ByVal form As FormNaprednaPretragaUnos, ByVal dgvColumnList As List(Of DataGridViewColumn))
        InitializeComponent()
        _dgvColumnListA = dgvColumnList
        _dgvColumnListG = dgvColumnList
        _parentForm = form
        _allColumnsList = New List(Of String)()
        For Each dgvCol As DataGridViewColumn In dgvColumnList
            _allColumnsList.Add(dgvCol.HeaderText)
        Next
        cmbFieldA.DataSource = _allColumnsList
        cmbFieldG.DataSource = _allColumnsList
    End Sub

    Private Sub AgrColumnsForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        If dgvAgrColumns.Rows.Count = 0 Then
            AddRowA()
        End If
    End Sub

    Private Sub GroupByColumnsForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        If dgvGroupByColumns.Rows.Count = 0 Then
            AddRowG()
        End If
    End Sub

    Private Sub btnAddLevelG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddLevelG.Click
        AddRowG()
    End Sub

    Private Sub btnAddLevelA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddLevelA.Click
        AddRowA()
    End Sub

    Private Sub AddRowG()
        Dim dgvRow As New DataGridViewRow()
        dgvGroupByColumns.Rows.Add(dgvRow)
    End Sub

    Private Sub AddRowA()
        Dim dgvRow As New DataGridViewRow()
        dgvAgrColumns.Rows.Add(dgvRow)
    End Sub

    Private Sub btnDeleteLevelG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteLevelG.Click
        Dim dgvRowColl As DataGridViewSelectedRowCollection = dgvGroupByColumns.SelectedRows

        If dgvRowColl.Count = 0 Then
            ISTMessageBox.Show("Please select a row.", "Group by", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        For Each dgvRow As DataGridViewRow In dgvRowColl
            dgvGroupByColumns.Rows.Remove(dgvRow)
        Next
    End Sub

    Private Sub btnDeleteLevelA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteLevelA.Click
        Dim dgvRowColl As DataGridViewSelectedRowCollection = dgvAgrColumns.SelectedRows

        If dgvRowColl.Count = 0 Then
            ISTMessageBox.Show("Please select a row.", "Function", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        For Each dgvRow As DataGridViewRow In dgvRowColl
            dgvAgrColumns.Rows.Remove(dgvRow)
        Next
    End Sub

    Private Function GetRepeatedColumn(ByVal dgv As DataGridView) As String
        Dim tempColumnList As New List(Of String)()
        For Each dgvRow As DataGridViewRow In dgv.Rows
            If tempColumnList.Contains(dgvRow.Cells(0).Value.ToString()) Then
                Return dgvRow.Cells(0).Value.ToString()
            Else
                tempColumnList.Add(dgvRow.Cells(0).Value.ToString())
            End If
        Next
        Return String.Empty
    End Function

    Private Function HaveUnAssignedCells(ByVal dgv As DataGridView) As Boolean
        For Each dgvRow As DataGridViewRow In dgv.Rows
            For Each dgvCell As DataGridViewCell In dgvRow.Cells
                If Convert.ToString(dgvCell.Value) = String.Empty OrElse dgvCell.Value Is Nothing Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Private Sub BtnAgregate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAgregiraj.Click
        If dgvAgrColumns.Rows.Count = 0 AndAlso chkClose.Checked Then
            If ISTMessageBox.Show("No grouping defined, Please press 'Yes' to confirm.", "Group by", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                Return
            End If
        ElseIf dgvAgrColumns.Rows.Count = 0 AndAlso Not chkClose.Checked Then
            ISTMessageBox.Show("No grouping defined. Please complete the grouping and try again.", "Group by", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If HaveUnAssignedCells(Me.dgvAgrColumns) Then
            ISTMessageBox.Show("Function contains unassigned columns. Please complete the function and try again.", "Function", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If GetRepeatedColumn(Me.dgvGroupByColumns) <> String.Empty Then
            ISTMessageBox.Show((Convert.ToString("'") & GetRepeatedColumn(dgvGroupByColumns)) + "' is being grouped more than once. Delete the duplicate group and try again.", "Group by", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If chkClose.Checked Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            '_parentForm.PerformAgr(GroupByListG)
        End If
    End Sub

    Private Sub btnResetA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetA.Click
        Dim dgvRows As New List(Of DataGridViewRow)()
        For Each dgvRow As DataGridViewRow In dgvAgrColumns.Rows
            dgvRows.Add(dgvRow)
        Next
        For Each dgvRow As DataGridViewRow In dgvRows
            dgvAgrColumns.Rows.Remove(dgvRow)
        Next
    End Sub

    Private Sub btnResetG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetG.Click
        'get List of all Rows
        Dim dgvRows As New List(Of DataGridViewRow)()
        For Each dgvRow As DataGridViewRow In dgvAgrColumns.Rows
            dgvRows.Add(dgvRow)
        Next
        'Delete the roows in the above list
        For Each dgvRow As DataGridViewRow In dgvRows
            dgvGroupByColumns.Rows.Remove(dgvRow)
        Next
    End Sub

    Private Sub dataGridViewSortColumns_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        'exit if header column clicked
        Dim dgv As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        If (e.ColumnIndex = -1) OrElse (e.RowIndex = -1) Then
            Return
        End If
        ' the combobox column index
        If e.ColumnIndex = 0 OrElse e.ColumnIndex = 1 Then
            dgv.BeginEdit(False)
            If dgv.EditingControl IsNot Nothing AndAlso TypeOf dgv.EditingControl Is ComboBox Then
                Dim cmb As ComboBox = TryCast(dgv.EditingControl, ComboBox)
                cmb.DroppedDown = True
            End If
        End If
    End Sub

    Friend ReadOnly Property AgrByList() As List(Of KeyValuePair(Of DataGridViewColumn, String))
        Get
            Dim agrList As New List(Of KeyValuePair(Of DataGridViewColumn, String))()
            For Each dgvRow As DataGridViewRow In dgvAgrColumns.Rows
                'get 1.ColumnNmae, 2.SortMode
                Dim myCol As DataGridViewColumn = Nothing
                For Each dgvCol As DataGridViewColumn In _dgvColumnListA
                    If dgvCol.HeaderText = dgvRow.Cells(1).Value.ToString() Then
                        myCol = dgvCol
                        Exit For
                    End If
                Next
                agrList.Add(New KeyValuePair(Of DataGridViewColumn, String)(myCol, dgvRow.Cells(0).Value.ToString()))
            Next
            Return agrList
        End Get

    End Property

    Friend ReadOnly Property GroupByList() As List(Of KeyValuePair(Of DataGridViewColumn, String))
        Get
            Dim groupList As New List(Of KeyValuePair(Of DataGridViewColumn, String))()
            For Each dgvRow As DataGridViewRow In dgvGroupByColumns.Rows
                'get 1.ColumnNmae, 2.SortMode
                Dim myCol As DataGridViewColumn = Nothing
                For Each dgvCol As DataGridViewColumn In _dgvColumnListG
                    If dgvCol.HeaderText = dgvRow.Cells(0).Value.ToString() Then
                        myCol = dgvCol
                        Exit For
                    End If
                Next
                groupList.Add(New KeyValuePair(Of DataGridViewColumn, String)(myCol, dgvRow.Cells(0).Value.ToString()))
            Next
            Return groupList
        End Get

    End Property

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

End Class