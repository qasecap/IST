<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQDParametersDialog
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
        Me._btnOK = New System.Windows.Forms.Button()
        Me._panel = New System.Windows.Forms.TableLayoutPanel()
        Me._btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_btnOK
        '
        Me._btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me._btnOK.Location = New System.Drawing.Point(116, 54)
        Me._btnOK.Name = "_btnOK"
        Me._btnOK.Size = New System.Drawing.Size(75, 23)
        Me._btnOK.TabIndex = 4
        Me._btnOK.Text = "OK"
        Me._btnOK.UseVisualStyleBackColor = True
        '
        '_panel
        '
        Me._panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._panel.AutoSize = True
        Me._panel.ColumnCount = 2
        Me._panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me._panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me._panel.Location = New System.Drawing.Point(12, 12)
        Me._panel.Name = "_panel"
        Me._panel.RowCount = 1
        Me._panel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me._panel.Size = New System.Drawing.Size(260, 26)
        Me._panel.TabIndex = 3
        '
        '_btnCancel
        '
        Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.Location = New System.Drawing.Point(197, 54)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(75, 23)
        Me._btnCancel.TabIndex = 5
        Me._btnCancel.Text = "Cancel"
        Me._btnCancel.UseVisualStyleBackColor = True
        '
        'FormQDParametersDialog
        '
        Me.AcceptButton = Me._btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.CancelButton = Me._btnCancel
        Me.ClientSize = New System.Drawing.Size(284, 89)
        Me.Controls.Add(Me._btnOK)
        Me.Controls.Add(Me._panel)
        Me.Controls.Add(Me._btnCancel)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormQDParametersDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Parameters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents _btnOK As System.Windows.Forms.Button
    Private WithEvents _panel As System.Windows.Forms.TableLayoutPanel
    Private WithEvents _btnCancel As System.Windows.Forms.Button
End Class
