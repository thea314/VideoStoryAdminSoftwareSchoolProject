<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.btn_AddNewEmployee = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Location = New System.Drawing.Point(208, 173)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(75, 23)
        Me.btn_dashboard.TabIndex = 0
        Me.btn_dashboard.Text = "dashboard"
        Me.btn_dashboard.UseVisualStyleBackColor = True
        '
        'btn_AddNewEmployee
        '
        Me.btn_AddNewEmployee.Location = New System.Drawing.Point(191, 240)
        Me.btn_AddNewEmployee.Name = "btn_AddNewEmployee"
        Me.btn_AddNewEmployee.Size = New System.Drawing.Size(92, 41)
        Me.btn_AddNewEmployee.TabIndex = 1
        Me.btn_AddNewEmployee.Text = "Add New"
        Me.btn_AddNewEmployee.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_AddNewEmployee)
        Me.Controls.Add(Me.btn_dashboard)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_dashboard As Button
    Friend WithEvents btn_AddNewEmployee As Button
End Class
