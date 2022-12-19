<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_password = New System.Windows.Forms.GroupBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.txt_confirmPassword = New System.Windows.Forms.TextBox()
        Me.txt_newPassword = New System.Windows.Forms.TextBox()
        Me.txt_oldPassword = New System.Windows.Forms.TextBox()
        Me.lbl_confirm = New System.Windows.Forms.Label()
        Me.lbl_newpassword = New System.Windows.Forms.Label()
        Me.lbl_oldpassword = New System.Windows.Forms.Label()
        Me.grp_password.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.LightCoral
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Your Password:"
        '
        'grp_password
        '
        Me.grp_password.Controls.Add(Me.btn_cancel)
        Me.grp_password.Controls.Add(Me.btn_submit)
        Me.grp_password.Controls.Add(Me.txt_confirmPassword)
        Me.grp_password.Controls.Add(Me.txt_newPassword)
        Me.grp_password.Controls.Add(Me.txt_oldPassword)
        Me.grp_password.Controls.Add(Me.lbl_confirm)
        Me.grp_password.Controls.Add(Me.lbl_newpassword)
        Me.grp_password.Controls.Add(Me.lbl_oldpassword)
        Me.grp_password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_password.Location = New System.Drawing.Point(22, 58)
        Me.grp_password.Name = "grp_password"
        Me.grp_password.Size = New System.Drawing.Size(301, 203)
        Me.grp_password.TabIndex = 1
        Me.grp_password.TabStop = False
        Me.grp_password.Text = "Please enter your new password:"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Maroon
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(185, 159)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 27)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.Green
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Location = New System.Drawing.Point(48, 159)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 27)
        Me.btn_submit.TabIndex = 6
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'txt_confirmPassword
        '
        Me.txt_confirmPassword.Location = New System.Drawing.Point(160, 108)
        Me.txt_confirmPassword.Name = "txt_confirmPassword"
        Me.txt_confirmPassword.Size = New System.Drawing.Size(130, 25)
        Me.txt_confirmPassword.TabIndex = 5
        Me.txt_confirmPassword.UseSystemPasswordChar = True
        '
        'txt_newPassword
        '
        Me.txt_newPassword.Location = New System.Drawing.Point(160, 77)
        Me.txt_newPassword.Name = "txt_newPassword"
        Me.txt_newPassword.Size = New System.Drawing.Size(130, 25)
        Me.txt_newPassword.TabIndex = 4
        Me.txt_newPassword.UseSystemPasswordChar = True
        '
        'txt_oldPassword
        '
        Me.txt_oldPassword.Location = New System.Drawing.Point(160, 42)
        Me.txt_oldPassword.Name = "txt_oldPassword"
        Me.txt_oldPassword.Size = New System.Drawing.Size(130, 25)
        Me.txt_oldPassword.TabIndex = 3
        Me.txt_oldPassword.UseSystemPasswordChar = True
        '
        'lbl_confirm
        '
        Me.lbl_confirm.AutoSize = True
        Me.lbl_confirm.Location = New System.Drawing.Point(6, 116)
        Me.lbl_confirm.Name = "lbl_confirm"
        Me.lbl_confirm.Size = New System.Drawing.Size(152, 17)
        Me.lbl_confirm.TabIndex = 2
        Me.lbl_confirm.Text = "Confirm New Password:"
        '
        'lbl_newpassword
        '
        Me.lbl_newpassword.AutoSize = True
        Me.lbl_newpassword.Location = New System.Drawing.Point(6, 85)
        Me.lbl_newpassword.Name = "lbl_newpassword"
        Me.lbl_newpassword.Size = New System.Drawing.Size(100, 17)
        Me.lbl_newpassword.TabIndex = 1
        Me.lbl_newpassword.Text = "New Password:"
        '
        'lbl_oldpassword
        '
        Me.lbl_oldpassword.AutoSize = True
        Me.lbl_oldpassword.Location = New System.Drawing.Point(6, 50)
        Me.lbl_oldpassword.Name = "lbl_oldpassword"
        Me.lbl_oldpassword.Size = New System.Drawing.Size(94, 17)
        Me.lbl_oldpassword.TabIndex = 0
        Me.lbl_oldpassword.Text = "Old Password:"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 280)
        Me.Controls.Add(Me.grp_password)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangePassword"
        Me.Text = "Change Password"
        Me.grp_password.ResumeLayout(False)
        Me.grp_password.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grp_password As GroupBox
    Friend WithEvents lbl_confirm As Label
    Friend WithEvents lbl_newpassword As Label
    Friend WithEvents lbl_oldpassword As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents txt_confirmPassword As TextBox
    Friend WithEvents txt_newPassword As TextBox
    Friend WithEvents txt_oldPassword As TextBox
End Class
