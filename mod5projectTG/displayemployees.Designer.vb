<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class displayemployees
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
        Me.lbl_listemployeetext = New System.Windows.Forms.Label()
        Me.data_displayemp = New System.Windows.Forms.DataGridView()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.data_displayemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_listemployeetext
        '
        Me.lbl_listemployeetext.AutoSize = True
        Me.lbl_listemployeetext.Location = New System.Drawing.Point(8, 8)
        Me.lbl_listemployeetext.Name = "lbl_listemployeetext"
        Me.lbl_listemployeetext.Size = New System.Drawing.Size(102, 15)
        Me.lbl_listemployeetext.TabIndex = 0
        Me.lbl_listemployeetext.Text = "List of Employees:"
        '
        'data_displayemp
        '
        Me.data_displayemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_displayemp.Location = New System.Drawing.Point(14, 33)
        Me.data_displayemp.Name = "data_displayemp"
        Me.data_displayemp.RowTemplate.Height = 25
        Me.data_displayemp.Size = New System.Drawing.Size(774, 378)
        Me.data_displayemp.TabIndex = 1
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(363, 417)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'displayemployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.data_displayemp)
        Me.Controls.Add(Me.lbl_listemployeetext)
        Me.Name = "displayemployees"
        Me.Text = "Employee List"
        CType(Me.data_displayemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_listemployeetext As Label
    Friend WithEvents data_displayemp As DataGridView
    Friend WithEvents btn_close As Button
End Class
