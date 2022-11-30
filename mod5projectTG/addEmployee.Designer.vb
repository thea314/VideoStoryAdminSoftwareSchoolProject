<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addEmployee
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_aaddnewEmployee = New System.Windows.Forms.Button()
        Me.grp_primary = New System.Windows.Forms.GroupBox()
        Me.grp_hr = New System.Windows.Forms.GroupBox()
        Me.grp_system = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Employee:"
        '
        'btn_aaddnewEmployee
        '
        Me.btn_aaddnewEmployee.Location = New System.Drawing.Point(732, 590)
        Me.btn_aaddnewEmployee.Name = "btn_aaddnewEmployee"
        Me.btn_aaddnewEmployee.Size = New System.Drawing.Size(125, 23)
        Me.btn_aaddnewEmployee.TabIndex = 1
        Me.btn_aaddnewEmployee.Text = "Add New Employee"
        Me.btn_aaddnewEmployee.UseVisualStyleBackColor = True
        '
        'grp_primary
        '
        Me.grp_primary.Location = New System.Drawing.Point(11, 44)
        Me.grp_primary.Name = "grp_primary"
        Me.grp_primary.Size = New System.Drawing.Size(274, 530)
        Me.grp_primary.TabIndex = 2
        Me.grp_primary.TabStop = False
        Me.grp_primary.Text = "Primary Information"
        '
        'grp_hr
        '
        Me.grp_hr.Location = New System.Drawing.Point(291, 44)
        Me.grp_hr.Name = "grp_hr"
        Me.grp_hr.Size = New System.Drawing.Size(274, 530)
        Me.grp_hr.TabIndex = 3
        Me.grp_hr.TabStop = False
        Me.grp_hr.Text = "Human Resources"
        '
        'grp_system
        '
        Me.grp_system.Location = New System.Drawing.Point(571, 44)
        Me.grp_system.Name = "grp_system"
        Me.grp_system.Size = New System.Drawing.Size(274, 530)
        Me.grp_system.TabIndex = 3
        Me.grp_system.TabStop = False
        Me.grp_system.Text = "System Information"
        '
        'addEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 625)
        Me.Controls.Add(Me.grp_system)
        Me.Controls.Add(Me.grp_hr)
        Me.Controls.Add(Me.grp_primary)
        Me.Controls.Add(Me.btn_aaddnewEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addEmployee"
        Me.Text = "Add New Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_aaddnewEmployee As Button
    Friend WithEvents grp_primary As GroupBox
    Friend WithEvents grp_hr As GroupBox
    Friend WithEvents grp_system As GroupBox
End Class
