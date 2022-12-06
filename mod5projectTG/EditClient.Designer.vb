<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditClient
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
        Me.grp_edit = New System.Windows.Forms.GroupBox()
        Me.date_dob = New System.Windows.Forms.DateTimePicker()
        Me.mtxt_phone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_postal = New System.Windows.Forms.TextBox()
        Me.txt_prov = New System.Windows.Forms.TextBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_client_no = New System.Windows.Forms.TextBox()
        Me.btn_cancelnewclient = New System.Windows.Forms.Button()
        Me.btn_createnewclient = New System.Windows.Forms.Button()
        Me.CheckBox_active = New System.Windows.Forms.CheckBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_postal = New System.Windows.Forms.Label()
        Me.lbl_prov = New System.Windows.Forms.Label()
        Me.lbl_city = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_dob = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.lbl_client_number = New System.Windows.Forms.Label()
        Me.combo_clientpicker = New System.Windows.Forms.ComboBox()
        Me.grp_edit.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_edit
        '
        Me.grp_edit.Controls.Add(Me.date_dob)
        Me.grp_edit.Controls.Add(Me.mtxt_phone)
        Me.grp_edit.Controls.Add(Me.txt_postal)
        Me.grp_edit.Controls.Add(Me.txt_prov)
        Me.grp_edit.Controls.Add(Me.txt_city)
        Me.grp_edit.Controls.Add(Me.txt_address)
        Me.grp_edit.Controls.Add(Me.txt_email)
        Me.grp_edit.Controls.Add(Me.txt_lname)
        Me.grp_edit.Controls.Add(Me.txt_fname)
        Me.grp_edit.Controls.Add(Me.txt_client_no)
        Me.grp_edit.Controls.Add(Me.btn_cancelnewclient)
        Me.grp_edit.Controls.Add(Me.btn_createnewclient)
        Me.grp_edit.Controls.Add(Me.CheckBox_active)
        Me.grp_edit.Controls.Add(Me.lbl_status)
        Me.grp_edit.Controls.Add(Me.lbl_postal)
        Me.grp_edit.Controls.Add(Me.lbl_prov)
        Me.grp_edit.Controls.Add(Me.lbl_city)
        Me.grp_edit.Controls.Add(Me.lbl_address)
        Me.grp_edit.Controls.Add(Me.lbl_dob)
        Me.grp_edit.Controls.Add(Me.lbl_phone)
        Me.grp_edit.Controls.Add(Me.lbl_email)
        Me.grp_edit.Controls.Add(Me.lbl_lname)
        Me.grp_edit.Controls.Add(Me.lbl_fname)
        Me.grp_edit.Controls.Add(Me.lbl_client_number)
        Me.grp_edit.Location = New System.Drawing.Point(12, 46)
        Me.grp_edit.Name = "grp_edit"
        Me.grp_edit.Size = New System.Drawing.Size(299, 392)
        Me.grp_edit.TabIndex = 1
        Me.grp_edit.TabStop = False
        Me.grp_edit.Text = "Edit Client:"
        '
        'date_dob
        '
        Me.date_dob.Location = New System.Drawing.Point(82, 175)
        Me.date_dob.Name = "date_dob"
        Me.date_dob.Size = New System.Drawing.Size(200, 23)
        Me.date_dob.TabIndex = 25
        '
        'mtxt_phone
        '
        Me.mtxt_phone.Location = New System.Drawing.Point(120, 146)
        Me.mtxt_phone.Mask = "999-000-0000"
        Me.mtxt_phone.Name = "mtxt_phone"
        Me.mtxt_phone.Size = New System.Drawing.Size(162, 23)
        Me.mtxt_phone.TabIndex = 24
        '
        'txt_postal
        '
        Me.txt_postal.Location = New System.Drawing.Point(120, 293)
        Me.txt_postal.Name = "txt_postal"
        Me.txt_postal.Size = New System.Drawing.Size(162, 23)
        Me.txt_postal.TabIndex = 23
        '
        'txt_prov
        '
        Me.txt_prov.Location = New System.Drawing.Point(120, 263)
        Me.txt_prov.Name = "txt_prov"
        Me.txt_prov.Size = New System.Drawing.Size(162, 23)
        Me.txt_prov.TabIndex = 22
        '
        'txt_city
        '
        Me.txt_city.Location = New System.Drawing.Point(120, 233)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(162, 23)
        Me.txt_city.TabIndex = 21
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(120, 204)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(162, 23)
        Me.txt_address.TabIndex = 20
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(120, 117)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(162, 23)
        Me.txt_email.TabIndex = 17
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(120, 89)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(162, 23)
        Me.txt_lname.TabIndex = 16
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(120, 58)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(162, 23)
        Me.txt_fname.TabIndex = 15
        '
        'txt_client_no
        '
        Me.txt_client_no.Location = New System.Drawing.Point(120, 27)
        Me.txt_client_no.Name = "txt_client_no"
        Me.txt_client_no.Size = New System.Drawing.Size(162, 23)
        Me.txt_client_no.TabIndex = 14
        '
        'btn_cancelnewclient
        '
        Me.btn_cancelnewclient.Location = New System.Drawing.Point(207, 363)
        Me.btn_cancelnewclient.Name = "btn_cancelnewclient"
        Me.btn_cancelnewclient.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelnewclient.TabIndex = 13
        Me.btn_cancelnewclient.Text = "Cancel"
        Me.btn_cancelnewclient.UseVisualStyleBackColor = True
        '
        'btn_createnewclient
        '
        Me.btn_createnewclient.Location = New System.Drawing.Point(21, 363)
        Me.btn_createnewclient.Name = "btn_createnewclient"
        Me.btn_createnewclient.Size = New System.Drawing.Size(118, 23)
        Me.btn_createnewclient.TabIndex = 12
        Me.btn_createnewclient.Text = "Edit Client"
        Me.btn_createnewclient.UseVisualStyleBackColor = True
        '
        'CheckBox_active
        '
        Me.CheckBox_active.AutoSize = True
        Me.CheckBox_active.Location = New System.Drawing.Point(56, 328)
        Me.CheckBox_active.Name = "CheckBox_active"
        Me.CheckBox_active.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox_active.TabIndex = 11
        Me.CheckBox_active.Text = "Active"
        Me.CheckBox_active.UseVisualStyleBackColor = True
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(8, 328)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(42, 15)
        Me.lbl_status.TabIndex = 10
        Me.lbl_status.Text = "Status:"
        '
        'lbl_postal
        '
        Me.lbl_postal.AutoSize = True
        Me.lbl_postal.Location = New System.Drawing.Point(8, 301)
        Me.lbl_postal.Name = "lbl_postal"
        Me.lbl_postal.Size = New System.Drawing.Size(73, 15)
        Me.lbl_postal.TabIndex = 9
        Me.lbl_postal.Text = "Postal Code:"
        '
        'lbl_prov
        '
        Me.lbl_prov.AutoSize = True
        Me.lbl_prov.Location = New System.Drawing.Point(8, 271)
        Me.lbl_prov.Name = "lbl_prov"
        Me.lbl_prov.Size = New System.Drawing.Size(56, 15)
        Me.lbl_prov.TabIndex = 8
        Me.lbl_prov.Text = "Province:"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Location = New System.Drawing.Point(8, 241)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(31, 15)
        Me.lbl_city.TabIndex = 7
        Me.lbl_city.Text = "City:"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Location = New System.Drawing.Point(8, 212)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(52, 15)
        Me.lbl_address.TabIndex = 6
        Me.lbl_address.Text = "Address:"
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Location = New System.Drawing.Point(8, 183)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(34, 15)
        Me.lbl_dob.TabIndex = 5
        Me.lbl_dob.Text = "DOB:"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Location = New System.Drawing.Point(8, 154)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(44, 15)
        Me.lbl_phone.TabIndex = 4
        Me.lbl_phone.Text = "Phone:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(8, 125)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(39, 15)
        Me.lbl_email.TabIndex = 3
        Me.lbl_email.Text = "Email:"
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Location = New System.Drawing.Point(8, 97)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(66, 15)
        Me.lbl_lname.TabIndex = 2
        Me.lbl_lname.Text = "Last Name:"
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Location = New System.Drawing.Point(8, 66)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(67, 15)
        Me.lbl_fname.TabIndex = 1
        Me.lbl_fname.Text = "First Name:"
        '
        'lbl_client_number
        '
        Me.lbl_client_number.AutoSize = True
        Me.lbl_client_number.Location = New System.Drawing.Point(8, 35)
        Me.lbl_client_number.Name = "lbl_client_number"
        Me.lbl_client_number.Size = New System.Drawing.Size(88, 15)
        Me.lbl_client_number.TabIndex = 0
        Me.lbl_client_number.Text = "Client Number:"
        '
        'combo_clientpicker
        '
        Me.combo_clientpicker.FormattingEnabled = True
        Me.combo_clientpicker.Location = New System.Drawing.Point(12, 12)
        Me.combo_clientpicker.Name = "combo_clientpicker"
        Me.combo_clientpicker.Size = New System.Drawing.Size(299, 23)
        Me.combo_clientpicker.TabIndex = 2
        '
        'EditClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 450)
        Me.Controls.Add(Me.combo_clientpicker)
        Me.Controls.Add(Me.grp_edit)
        Me.Name = "EditClient"
        Me.Text = "EditClient"
        Me.grp_edit.ResumeLayout(False)
        Me.grp_edit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_edit As GroupBox
    Friend WithEvents date_dob As DateTimePicker
    Friend WithEvents mtxt_phone As MaskedTextBox
    Friend WithEvents txt_postal As TextBox
    Friend WithEvents txt_prov As TextBox
    Friend WithEvents txt_city As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_client_no As TextBox
    Friend WithEvents btn_cancelnewclient As Button
    Friend WithEvents btn_createnewclient As Button
    Friend WithEvents CheckBox_active As CheckBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents lbl_postal As Label
    Friend WithEvents lbl_prov As Label
    Friend WithEvents lbl_city As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_dob As Label
    Friend WithEvents lbl_phone As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_lname As Label
    Friend WithEvents lbl_fname As Label
    Friend WithEvents lbl_client_number As Label
    Friend WithEvents combo_clientpicker As ComboBox
End Class
