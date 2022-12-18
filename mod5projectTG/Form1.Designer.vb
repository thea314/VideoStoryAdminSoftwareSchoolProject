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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_username.Location = New System.Drawing.Point(53, 191)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(72, 17)
        Me.lbl_username.TabIndex = 17
        Me.lbl_username.Text = "Username:"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(140, 183)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(154, 23)
        Me.txt_username.TabIndex = 18
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_password.Location = New System.Drawing.Point(53, 237)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(69, 17)
        Me.lbl_password.TabIndex = 19
        Me.lbl_password.Text = "Password:"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(140, 229)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(154, 23)
        Me.txt_password.TabIndex = 20
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Purple
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login.Location = New System.Drawing.Point(177, 268)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 30)
        Me.btn_login.TabIndex = 21
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(73, 33)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(273, 110)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_logo.TabIndex = 22
        Me.pic_logo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 359)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_username)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Welcome to the Super Video Store!"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents pic_logo As PictureBox
End Class
