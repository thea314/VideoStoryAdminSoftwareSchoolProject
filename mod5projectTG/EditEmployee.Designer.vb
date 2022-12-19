<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditEmployee))
        Me.grp_system = New System.Windows.Forms.GroupBox()
        Me.txt_confirm = New System.Windows.Forms.TextBox()
        Me.lbl_confirm = New System.Windows.Forms.Label()
        Me.check_active = New System.Windows.Forms.CheckBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.combo_access = New System.Windows.Forms.ComboBox()
        Me.lbl_access = New System.Windows.Forms.Label()
        Me.grp_hr = New System.Windows.Forms.GroupBox()
        Me.date_start = New System.Windows.Forms.DateTimePicker()
        Me.lbl_start_date = New System.Windows.Forms.Label()
        Me.combo_education = New System.Windows.Forms.ComboBox()
        Me.txt_salary = New System.Windows.Forms.TextBox()
        Me.txt_sin = New System.Windows.Forms.TextBox()
        Me.txt_employeeno = New System.Windows.Forms.TextBox()
        Me.lbl_education = New System.Windows.Forms.Label()
        Me.lbl_salary = New System.Windows.Forms.Label()
        Me.lbl_SIN = New System.Windows.Forms.Label()
        Me.lbl_emplyee_no = New System.Windows.Forms.Label()
        Me.grp_primary = New System.Windows.Forms.GroupBox()
        Me.mtxt_cellphone = New System.Windows.Forms.MaskedTextBox()
        Me.mtxt_homephone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_postal = New System.Windows.Forms.TextBox()
        Me.txt_prov = New System.Windows.Forms.TextBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.date_dob = New System.Windows.Forms.DateTimePicker()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.lbl_cell = New System.Windows.Forms.Label()
        Me.lbl_home = New System.Windows.Forms.Label()
        Me.lbl_postal = New System.Windows.Forms.Label()
        Me.lbl_prov = New System.Windows.Forms.Label()
        Me.lbl_city = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_dob = New System.Windows.Forms.Label()
        Me.lbl_lastname = New System.Windows.Forms.Label()
        Me.lbl_firstname = New System.Windows.Forms.Label()
        Me.btn_aaddnewEmployee = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_employeePicker = New System.Windows.Forms.ComboBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_editemployee = New System.Windows.Forms.Label()
        Me.grp_system.SuspendLayout()
        Me.grp_hr.SuspendLayout()
        Me.grp_primary.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_system
        '
        Me.grp_system.Controls.Add(Me.txt_confirm)
        Me.grp_system.Controls.Add(Me.lbl_confirm)
        Me.grp_system.Controls.Add(Me.check_active)
        Me.grp_system.Controls.Add(Me.txt_password)
        Me.grp_system.Controls.Add(Me.lbl_password)
        Me.grp_system.Controls.Add(Me.txt_username)
        Me.grp_system.Controls.Add(Me.lbl_username)
        Me.grp_system.Controls.Add(Me.combo_access)
        Me.grp_system.Controls.Add(Me.lbl_access)
        Me.grp_system.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_system.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_system.Location = New System.Drawing.Point(572, 84)
        Me.grp_system.Name = "grp_system"
        Me.grp_system.Size = New System.Drawing.Size(274, 306)
        Me.grp_system.TabIndex = 7
        Me.grp_system.TabStop = False
        Me.grp_system.Text = "System Information"
        '
        'txt_confirm
        '
        Me.txt_confirm.Location = New System.Drawing.Point(113, 178)
        Me.txt_confirm.Name = "txt_confirm"
        Me.txt_confirm.Size = New System.Drawing.Size(155, 25)
        Me.txt_confirm.TabIndex = 11
        Me.txt_confirm.UseSystemPasswordChar = True
        '
        'lbl_confirm
        '
        Me.lbl_confirm.AutoSize = True
        Me.lbl_confirm.Location = New System.Drawing.Point(18, 186)
        Me.lbl_confirm.Name = "lbl_confirm"
        Me.lbl_confirm.Size = New System.Drawing.Size(59, 17)
        Me.lbl_confirm.TabIndex = 10
        Me.lbl_confirm.Text = "Confirm:"
        '
        'check_active
        '
        Me.check_active.AutoSize = True
        Me.check_active.Location = New System.Drawing.Point(18, 235)
        Me.check_active.Name = "check_active"
        Me.check_active.Size = New System.Drawing.Size(118, 21)
        Me.check_active.TabIndex = 7
        Me.check_active.Text = "Active Account"
        Me.check_active.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(113, 149)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(155, 25)
        Me.txt_password.TabIndex = 5
        Me.txt_password.UseSystemPasswordChar = True
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(18, 154)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(69, 17)
        Me.lbl_password.TabIndex = 4
        Me.lbl_password.Text = "Password:"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(113, 120)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(155, 25)
        Me.txt_username.TabIndex = 3
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(18, 128)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(72, 17)
        Me.lbl_username.TabIndex = 2
        Me.lbl_username.Text = "Username:"
        '
        'combo_access
        '
        Me.combo_access.FormattingEnabled = True
        Me.combo_access.Items.AddRange(New Object() {"Employee Level 1", "Employee Level 2", "Employee Level 3", "Administrator"})
        Me.combo_access.Location = New System.Drawing.Point(113, 91)
        Me.combo_access.Name = "combo_access"
        Me.combo_access.Size = New System.Drawing.Size(155, 25)
        Me.combo_access.TabIndex = 1
        '
        'lbl_access
        '
        Me.lbl_access.AutoSize = True
        Me.lbl_access.Location = New System.Drawing.Point(18, 99)
        Me.lbl_access.Name = "lbl_access"
        Me.lbl_access.Size = New System.Drawing.Size(85, 17)
        Me.lbl_access.TabIndex = 0
        Me.lbl_access.Text = "Access Level:"
        '
        'grp_hr
        '
        Me.grp_hr.Controls.Add(Me.date_start)
        Me.grp_hr.Controls.Add(Me.lbl_start_date)
        Me.grp_hr.Controls.Add(Me.combo_education)
        Me.grp_hr.Controls.Add(Me.txt_salary)
        Me.grp_hr.Controls.Add(Me.txt_sin)
        Me.grp_hr.Controls.Add(Me.txt_employeeno)
        Me.grp_hr.Controls.Add(Me.lbl_education)
        Me.grp_hr.Controls.Add(Me.lbl_salary)
        Me.grp_hr.Controls.Add(Me.lbl_SIN)
        Me.grp_hr.Controls.Add(Me.lbl_emplyee_no)
        Me.grp_hr.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_hr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_hr.Location = New System.Drawing.Point(292, 84)
        Me.grp_hr.Name = "grp_hr"
        Me.grp_hr.Size = New System.Drawing.Size(274, 306)
        Me.grp_hr.TabIndex = 8
        Me.grp_hr.TabStop = False
        Me.grp_hr.Text = "Human Resources"
        '
        'date_start
        '
        Me.date_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_start.Location = New System.Drawing.Point(113, 204)
        Me.date_start.Name = "date_start"
        Me.date_start.Size = New System.Drawing.Size(155, 25)
        Me.date_start.TabIndex = 9
        '
        'lbl_start_date
        '
        Me.lbl_start_date.AutoSize = True
        Me.lbl_start_date.Location = New System.Drawing.Point(11, 207)
        Me.lbl_start_date.Name = "lbl_start_date"
        Me.lbl_start_date.Size = New System.Drawing.Size(72, 17)
        Me.lbl_start_date.TabIndex = 8
        Me.lbl_start_date.Text = "Start Date:"
        '
        'combo_education
        '
        Me.combo_education.FormattingEnabled = True
        Me.combo_education.Items.AddRange(New Object() {"DES", "AEC", "DEC", "BAC", "Master", "Doctorate"})
        Me.combo_education.Location = New System.Drawing.Point(113, 173)
        Me.combo_education.Name = "combo_education"
        Me.combo_education.Size = New System.Drawing.Size(155, 25)
        Me.combo_education.TabIndex = 7
        '
        'txt_salary
        '
        Me.txt_salary.Location = New System.Drawing.Point(113, 144)
        Me.txt_salary.Name = "txt_salary"
        Me.txt_salary.Size = New System.Drawing.Size(155, 25)
        Me.txt_salary.TabIndex = 6
        '
        'txt_sin
        '
        Me.txt_sin.Location = New System.Drawing.Point(113, 115)
        Me.txt_sin.Name = "txt_sin"
        Me.txt_sin.Size = New System.Drawing.Size(155, 25)
        Me.txt_sin.TabIndex = 5
        '
        'txt_employeeno
        '
        Me.txt_employeeno.Location = New System.Drawing.Point(113, 83)
        Me.txt_employeeno.Name = "txt_employeeno"
        Me.txt_employeeno.Size = New System.Drawing.Size(155, 25)
        Me.txt_employeeno.TabIndex = 4
        '
        'lbl_education
        '
        Me.lbl_education.AutoSize = True
        Me.lbl_education.Location = New System.Drawing.Point(11, 179)
        Me.lbl_education.Name = "lbl_education"
        Me.lbl_education.Size = New System.Drawing.Size(71, 17)
        Me.lbl_education.TabIndex = 3
        Me.lbl_education.Text = "Education:"
        '
        'lbl_salary
        '
        Me.lbl_salary.AutoSize = True
        Me.lbl_salary.Location = New System.Drawing.Point(11, 151)
        Me.lbl_salary.Name = "lbl_salary"
        Me.lbl_salary.Size = New System.Drawing.Size(48, 17)
        Me.lbl_salary.TabIndex = 2
        Me.lbl_salary.Text = "Salary:"
        '
        'lbl_SIN
        '
        Me.lbl_SIN.AutoSize = True
        Me.lbl_SIN.Location = New System.Drawing.Point(11, 123)
        Me.lbl_SIN.Name = "lbl_SIN"
        Me.lbl_SIN.Size = New System.Drawing.Size(32, 17)
        Me.lbl_SIN.TabIndex = 1
        Me.lbl_SIN.Text = "SIN:"
        '
        'lbl_emplyee_no
        '
        Me.lbl_emplyee_no.AutoSize = True
        Me.lbl_emplyee_no.Location = New System.Drawing.Point(11, 91)
        Me.lbl_emplyee_no.Name = "lbl_emplyee_no"
        Me.lbl_emplyee_no.Size = New System.Drawing.Size(95, 17)
        Me.lbl_emplyee_no.TabIndex = 0
        Me.lbl_emplyee_no.Text = "Employee No.:"
        '
        'grp_primary
        '
        Me.grp_primary.Controls.Add(Me.mtxt_cellphone)
        Me.grp_primary.Controls.Add(Me.mtxt_homephone)
        Me.grp_primary.Controls.Add(Me.txt_postal)
        Me.grp_primary.Controls.Add(Me.txt_prov)
        Me.grp_primary.Controls.Add(Me.txt_city)
        Me.grp_primary.Controls.Add(Me.txt_address)
        Me.grp_primary.Controls.Add(Me.date_dob)
        Me.grp_primary.Controls.Add(Me.txt_lname)
        Me.grp_primary.Controls.Add(Me.txt_fname)
        Me.grp_primary.Controls.Add(Me.lbl_cell)
        Me.grp_primary.Controls.Add(Me.lbl_home)
        Me.grp_primary.Controls.Add(Me.lbl_postal)
        Me.grp_primary.Controls.Add(Me.lbl_prov)
        Me.grp_primary.Controls.Add(Me.lbl_city)
        Me.grp_primary.Controls.Add(Me.lbl_address)
        Me.grp_primary.Controls.Add(Me.lbl_dob)
        Me.grp_primary.Controls.Add(Me.lbl_lastname)
        Me.grp_primary.Controls.Add(Me.lbl_firstname)
        Me.grp_primary.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_primary.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_primary.Location = New System.Drawing.Point(12, 84)
        Me.grp_primary.Name = "grp_primary"
        Me.grp_primary.Size = New System.Drawing.Size(274, 306)
        Me.grp_primary.TabIndex = 6
        Me.grp_primary.TabStop = False
        Me.grp_primary.Text = "Primary Information"
        '
        'mtxt_cellphone
        '
        Me.mtxt_cellphone.Location = New System.Drawing.Point(100, 265)
        Me.mtxt_cellphone.Mask = "999-000-0000"
        Me.mtxt_cellphone.Name = "mtxt_cellphone"
        Me.mtxt_cellphone.Size = New System.Drawing.Size(168, 25)
        Me.mtxt_cellphone.TabIndex = 17
        '
        'mtxt_homephone
        '
        Me.mtxt_homephone.Location = New System.Drawing.Point(100, 235)
        Me.mtxt_homephone.Mask = "999-000-0000"
        Me.mtxt_homephone.Name = "mtxt_homephone"
        Me.mtxt_homephone.Size = New System.Drawing.Size(168, 25)
        Me.mtxt_homephone.TabIndex = 16
        '
        'txt_postal
        '
        Me.txt_postal.Location = New System.Drawing.Point(100, 207)
        Me.txt_postal.Name = "txt_postal"
        Me.txt_postal.Size = New System.Drawing.Size(168, 25)
        Me.txt_postal.TabIndex = 15
        '
        'txt_prov
        '
        Me.txt_prov.Location = New System.Drawing.Point(100, 179)
        Me.txt_prov.Name = "txt_prov"
        Me.txt_prov.Size = New System.Drawing.Size(168, 25)
        Me.txt_prov.TabIndex = 14
        '
        'txt_city
        '
        Me.txt_city.Location = New System.Drawing.Point(100, 151)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(168, 25)
        Me.txt_city.TabIndex = 13
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(100, 120)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(168, 25)
        Me.txt_address.TabIndex = 12
        '
        'date_dob
        '
        Me.date_dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_dob.Location = New System.Drawing.Point(100, 91)
        Me.date_dob.Name = "date_dob"
        Me.date_dob.Size = New System.Drawing.Size(168, 25)
        Me.date_dob.TabIndex = 11
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(100, 58)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(168, 25)
        Me.txt_lname.TabIndex = 10
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(100, 25)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(168, 25)
        Me.txt_fname.TabIndex = 9
        '
        'lbl_cell
        '
        Me.lbl_cell.AutoSize = True
        Me.lbl_cell.Location = New System.Drawing.Point(11, 273)
        Me.lbl_cell.Name = "lbl_cell"
        Me.lbl_cell.Size = New System.Drawing.Size(75, 17)
        Me.lbl_cell.TabIndex = 8
        Me.lbl_cell.Text = "Cell Phone:"
        '
        'lbl_home
        '
        Me.lbl_home.AutoSize = True
        Me.lbl_home.Location = New System.Drawing.Point(11, 243)
        Me.lbl_home.Name = "lbl_home"
        Me.lbl_home.Size = New System.Drawing.Size(91, 17)
        Me.lbl_home.TabIndex = 7
        Me.lbl_home.Text = "Home Phone:"
        '
        'lbl_postal
        '
        Me.lbl_postal.AutoSize = True
        Me.lbl_postal.Location = New System.Drawing.Point(11, 215)
        Me.lbl_postal.Name = "lbl_postal"
        Me.lbl_postal.Size = New System.Drawing.Size(83, 17)
        Me.lbl_postal.TabIndex = 6
        Me.lbl_postal.Text = "Postal Code:"
        '
        'lbl_prov
        '
        Me.lbl_prov.AutoSize = True
        Me.lbl_prov.Location = New System.Drawing.Point(11, 187)
        Me.lbl_prov.Name = "lbl_prov"
        Me.lbl_prov.Size = New System.Drawing.Size(63, 17)
        Me.lbl_prov.TabIndex = 5
        Me.lbl_prov.Text = "Province:"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Location = New System.Drawing.Point(11, 159)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(34, 17)
        Me.lbl_city.TabIndex = 4
        Me.lbl_city.Text = "City:"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Location = New System.Drawing.Point(11, 128)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(60, 17)
        Me.lbl_address.TabIndex = 3
        Me.lbl_address.Text = "Address:"
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Location = New System.Drawing.Point(11, 99)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(38, 17)
        Me.lbl_dob.TabIndex = 2
        Me.lbl_dob.Text = "DOB:"
        '
        'lbl_lastname
        '
        Me.lbl_lastname.AutoSize = True
        Me.lbl_lastname.Location = New System.Drawing.Point(11, 66)
        Me.lbl_lastname.Name = "lbl_lastname"
        Me.lbl_lastname.Size = New System.Drawing.Size(75, 17)
        Me.lbl_lastname.TabIndex = 1
        Me.lbl_lastname.Text = "Last Name:"
        '
        'lbl_firstname
        '
        Me.lbl_firstname.AutoSize = True
        Me.lbl_firstname.Location = New System.Drawing.Point(11, 33)
        Me.lbl_firstname.Name = "lbl_firstname"
        Me.lbl_firstname.Size = New System.Drawing.Size(77, 17)
        Me.lbl_firstname.TabIndex = 0
        Me.lbl_firstname.Text = "First Name:"
        '
        'btn_aaddnewEmployee
        '
        Me.btn_aaddnewEmployee.BackColor = System.Drawing.Color.Green
        Me.btn_aaddnewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aaddnewEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_aaddnewEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_aaddnewEmployee.Location = New System.Drawing.Point(343, 396)
        Me.btn_aaddnewEmployee.Name = "btn_aaddnewEmployee"
        Me.btn_aaddnewEmployee.Size = New System.Drawing.Size(125, 30)
        Me.btn_aaddnewEmployee.TabIndex = 5
        Me.btn_aaddnewEmployee.Text = "Edit Employee"
        Me.btn_aaddnewEmployee.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Edit Employee:"
        '
        'combo_employeePicker
        '
        Me.combo_employeePicker.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.combo_employeePicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.combo_employeePicker.FormattingEnabled = True
        Me.combo_employeePicker.Location = New System.Drawing.Point(112, 46)
        Me.combo_employeePicker.Name = "combo_employeePicker"
        Me.combo_employeePicker.Size = New System.Drawing.Size(275, 25)
        Me.combo_employeePicker.TabIndex = 9
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Maroon
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancel.Location = New System.Drawing.Point(773, 396)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 30)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'lbl_editemployee
        '
        Me.lbl_editemployee.AutoSize = True
        Me.lbl_editemployee.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_editemployee.ForeColor = System.Drawing.Color.LightCoral
        Me.lbl_editemployee.Location = New System.Drawing.Point(12, 9)
        Me.lbl_editemployee.Name = "lbl_editemployee"
        Me.lbl_editemployee.Size = New System.Drawing.Size(183, 32)
        Me.lbl_editemployee.TabIndex = 11
        Me.lbl_editemployee.Text = "Edit Employee:"
        '
        'EditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 434)
        Me.Controls.Add(Me.lbl_editemployee)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.combo_employeePicker)
        Me.Controls.Add(Me.grp_system)
        Me.Controls.Add(Me.grp_hr)
        Me.Controls.Add(Me.grp_primary)
        Me.Controls.Add(Me.btn_aaddnewEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditEmployee"
        Me.Text = "Edit Employee"
        Me.grp_system.ResumeLayout(False)
        Me.grp_system.PerformLayout()
        Me.grp_hr.ResumeLayout(False)
        Me.grp_hr.PerformLayout()
        Me.grp_primary.ResumeLayout(False)
        Me.grp_primary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_system As GroupBox
    Friend WithEvents check_active As CheckBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents combo_access As ComboBox
    Friend WithEvents lbl_access As Label
    Friend WithEvents grp_hr As GroupBox
    Friend WithEvents date_start As DateTimePicker
    Friend WithEvents lbl_start_date As Label
    Friend WithEvents combo_education As ComboBox
    Friend WithEvents txt_salary As TextBox
    Friend WithEvents txt_sin As TextBox
    Friend WithEvents txt_employeeno As TextBox
    Friend WithEvents lbl_education As Label
    Friend WithEvents lbl_salary As Label
    Friend WithEvents lbl_SIN As Label
    Friend WithEvents lbl_emplyee_no As Label
    Friend WithEvents grp_primary As GroupBox
    Friend WithEvents txt_postal As TextBox
    Friend WithEvents txt_prov As TextBox
    Friend WithEvents txt_city As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents date_dob As DateTimePicker
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents lbl_cell As Label
    Friend WithEvents lbl_home As Label
    Friend WithEvents lbl_postal As Label
    Friend WithEvents lbl_prov As Label
    Friend WithEvents lbl_city As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_dob As Label
    Friend WithEvents lbl_lastname As Label
    Friend WithEvents lbl_firstname As Label
    Friend WithEvents btn_aaddnewEmployee As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_employeePicker As ComboBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents mtxt_cellphone As MaskedTextBox
    Friend WithEvents mtxt_homephone As MaskedTextBox
    Friend WithEvents txt_confirm As TextBox
    Friend WithEvents lbl_confirm As Label
    Friend WithEvents lbl_editemployee As Label
End Class
