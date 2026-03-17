<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQDFilterEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me._btnOK = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me._cmbOperator = New System.Windows.Forms.ComboBox()
        Me._txtValue = New System.Windows.Forms.TextBox()
        Me._value = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me._txtFrom = New System.Windows.Forms.TextBox()
        Me._txtTo = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me._btnCancel = New System.Windows.Forms.Button()
        Me._btnClear = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.Location = New System.Drawing.Point(204, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(525, 85)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Tips:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Use 0 or 1 instead of True and False;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Enclose string and date values " &
    "in 'quotes'."
        '
        '_btnOK
        '
        Me._btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._btnOK.Location = New System.Drawing.Point(547, 218)
        Me._btnOK.Name = "_btnOK"
        Me._btnOK.Size = New System.Drawing.Size(88, 24)
        Me._btnOK.TabIndex = 12
        Me._btnOK.Text = "OK"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me._cmbOperator)
        Me.groupBox1.Controls.Add(Me._txtValue)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(186, 56)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Single value criteria"
        '
        '_cmbOperator
        '
        Me._cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbOperator.Items.AddRange(New Object() {"=", ">", ">=", "<", "<=", "<>"})
        Me._cmbOperator.Location = New System.Drawing.Point(16, 24)
        Me._cmbOperator.Name = "_cmbOperator"
        Me._cmbOperator.Size = New System.Drawing.Size(56, 22)
        Me._cmbOperator.TabIndex = 0
        '
        '_txtValue
        '
        Me._txtValue.Location = New System.Drawing.Point(90, 24)
        Me._txtValue.Name = "_txtValue"
        Me._txtValue.Size = New System.Drawing.Size(80, 22)
        Me._txtValue.TabIndex = 1
        '
        '_value
        '
        Me._value.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._value.Location = New System.Drawing.Point(12, 167)
        Me._value.Name = "_value"
        Me._value.Size = New System.Drawing.Size(717, 48)
        Me._value.TabIndex = 7
        Me._value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me._txtFrom)
        Me.groupBox2.Controls.Add(Me._txtTo)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Location = New System.Drawing.Point(15, 108)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(702, 56)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Interval criteria"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 14)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Between"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_txtFrom
        '
        Me._txtFrom.Location = New System.Drawing.Point(91, 25)
        Me._txtFrom.Name = "_txtFrom"
        Me._txtFrom.Size = New System.Drawing.Size(80, 22)
        Me._txtFrom.TabIndex = 1
        '
        '_txtTo
        '
        Me._txtTo.Location = New System.Drawing.Point(239, 25)
        Me._txtTo.Name = "_txtTo"
        Me._txtTo.Size = New System.Drawing.Size(80, 22)
        Me._txtTo.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(194, 28)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(31, 14)
        Me.label3.TabIndex = 2
        Me.label3.Text = "and"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_btnCancel
        '
        Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._btnCancel.Location = New System.Drawing.Point(641, 218)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(88, 24)
        Me._btnCancel.TabIndex = 13
        Me._btnCancel.Text = "Cancel"
        '
        '_btnClear
        '
        Me._btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._btnClear.Location = New System.Drawing.Point(12, 218)
        Me._btnClear.Name = "_btnClear"
        Me._btnClear.Size = New System.Drawing.Size(88, 24)
        Me._btnClear.TabIndex = 11
        Me._btnClear.Text = "Clear"
        '
        'FormQDFilterEditor
        '
        Me.AcceptButton = Me._btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me._btnCancel
        Me.ClientSize = New System.Drawing.Size(741, 254)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._btnOK)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me._value)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me._btnClear)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormQDFilterEditor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Filter"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents _btnOK As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents _cmbOperator As System.Windows.Forms.ComboBox
    Private WithEvents _txtValue As System.Windows.Forms.TextBox
    Private WithEvents _value As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents _txtFrom As System.Windows.Forms.TextBox
    Private WithEvents _txtTo As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents _btnCancel As System.Windows.Forms.Button
    Private WithEvents _btnClear As System.Windows.Forms.Button
End Class
