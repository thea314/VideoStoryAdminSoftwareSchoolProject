Public Class EditEmployee

    Public intAccess As Integer
    Public chosenUser As Integer

    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'populate selector combobox
        Dim populateCombo As DBManager = New DBManager()

        populateCombo.PopulateUserComboBox()

    End Sub

    Private Sub combo_employeePicker_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_employeePicker.SelectedValueChanged

        If (IsNumeric(combo_employeePicker.SelectedValue)) Then

            Dim checkIfExists As DBManager = New DBManager()

            chosenUser = combo_employeePicker.SelectedValue

            If (checkIfExists.UserExists(chosenUser)) Then

                Dim accessUser As DBManager = New DBManager()

                Dim user = accessUser.GetUser(chosenUser)

                PopulateEmployeeData(user)

            End If

        End If

    End Sub

    Private Sub btn_aaddnewEmployee_Click(sender As Object, e As EventArgs) Handles btn_aaddnewEmployee.Click

        'set minimum lengths of input
        If (Me.txt_employeeno.Text = "" Or (Me.txt_employeeno.Text.Length < 5)) Then
            MsgBox("Please enter an employee number of length greater than 5.")
            Me.txt_employeeno.Text = ""
            Exit Sub
        End If

        If (Me.txt_username.Text.Length < 5) Then
            MsgBox("Please enter a username of length greater than 5.")
            Me.txt_username.Text = ""
            Exit Sub
        End If

        If (Me.txt_username.Text = "") Then
            Me.txt_password.Text = "herzing"
        End If

        If (Me.txt_password.Text = "" Or (Me.txt_password.Text.Length < 4)) Then
            MsgBox("Please enter a password of length greater than 4.")
            Me.txt_password.Text = ""
            Exit Sub
        End If

        If (Me.txt_fname.Text = "" Or (Me.txt_fname.Text.Length < 4)) Then
            MsgBox("Please enter a first name of length greater than 4.")
            Me.txt_fname.Text = ""
            Exit Sub
        End If

        If (Me.txt_lname.Text = "" Or (Me.txt_lname.Text.Length < 4)) Then
            MsgBox("Please enter a last name of length greater than 4.")
            Me.txt_lname.Text = ""
            Exit Sub
        End If

        If (Me.txt_address.Text = "" Or (Me.txt_address.Text.Length < 10)) Then
            MsgBox("Please enter an address of length greater than 10.")
            Me.txt_address.Text = ""
            Exit Sub
        End If

        If (Me.txt_city.Text = "" Or (Me.txt_city.Text.Length < 4)) Then
            MsgBox("Please enter a city name of length greater than 4.")
            Me.txt_city.Text = ""
            Exit Sub
        End If

        If (Me.txt_prov.Text = "" Or (Me.txt_prov.Text.Length < 4)) Then
            MsgBox("Please enter a province name of length greater than 4.")
            Me.txt_prov.Text = ""
            Exit Sub
        End If

        If (Me.txt_postal.Text = "" Or (Me.txt_postal.Text.Length <> 7)) Then
            MsgBox("Please enter a postal code of length equal to than 7.")
            Me.txt_postal.Text = ""
            Exit Sub
        End If

        If (Me.txt_sin.Text = "" Or (Me.txt_sin.Text.Length <> 9)) Then
            MsgBox("Please enter a SIN of length 9.")
            Me.txt_sin.Text = ""
            Exit Sub
        End If

        If (Me.txt_salary.Text = "" Or (Me.txt_salary.Text.Length < 4)) Then
            MsgBox("Please enter an hourly wage of length greater than 4.")
            Me.txt_salary.Text = ""
            Exit Sub
        End If

        'set maximum lengths of input
        If (Me.txt_employeeno.Text = "" Or (Me.txt_employeeno.Text.Length > 20)) Then
            MsgBox("Please enter an employee number of length less than 20.")
            Me.txt_employeeno.Text = ""
            Exit Sub
        End If

        If (Me.txt_username.Text = "" Or (Me.txt_username.Text.Length > 16)) Then
            MsgBox("Please enter a username of length greater less 16.")
            Me.txt_username.Text = ""
            Exit Sub
        End If

        If (Me.txt_password.Text = "" Or (Me.txt_password.Text.Length > 255)) Then
            MsgBox("Please enter a password of length less than 255.")
            Me.txt_password.Text = ""
            Exit Sub
        End If

        If (Me.txt_fname.Text = "" Or (Me.txt_fname.Text.Length > 20)) Then
            MsgBox("Please enter a first name of length less than 20.")
            Me.txt_fname.Text = ""
            Exit Sub
        End If

        If (Me.txt_lname.Text = "" Or (Me.txt_lname.Text.Length > 20)) Then
            MsgBox("Please enter a last name of length less than 20.")
            Me.txt_lname.Text = ""
            Exit Sub
        End If

        If (Me.txt_address.Text = "" Or (Me.txt_address.Text.Length > 100)) Then
            MsgBox("Please enter an address of length less than 100.")
            Me.txt_address.Text = ""
            Exit Sub
        End If

        If (Me.txt_city.Text = "" Or (Me.txt_city.Text.Length > 50)) Then
            MsgBox("Please enter a city name of length less than 50.")
            Me.txt_city.Text = ""
            Exit Sub
        End If

        If (Me.txt_prov.Text = "" Or (Me.txt_prov.Text.Length > 50)) Then
            MsgBox("Please enter a province name of length less than 50.")
            Me.txt_prov.Text = ""
            Exit Sub
        End If

        If (Me.mtxt_homephone.Text = "" Or (Me.mtxt_homephone.Text.Length <> 10)) Then
            MsgBox("Please enter a phone number of length of 10.")
            Me.mtxt_homephone.Text = ""
            Exit Sub
        End If

        If (Me.mtxt_cellphone.Text = "" Or (Me.mtxt_cellphone.Text.Length <> 10)) Then
            MsgBox("Please enter a cell number of length of 10.")
            Me.mtxt_cellphone.Text = ""
            Exit Sub
        End If

        If (Me.txt_salary.Text = "" Or (Me.txt_salary.Text.Length > 6)) Then
            MsgBox("Please enter an hourly wage of length less than 6.")
            Me.txt_salary.Text = ""
            Exit Sub
        End If

        'set data for employee level
        Select Case combo_access.SelectedIndex

            Case 1
                intAccess = 2
            Case 2
                intAccess = 3
            Case 3
                intAccess = 4
            Case 4
                intAccess = 1

        End Select

        Dim edit As DBManager = New DBManager()

        edit.EditEmployeeSubmit(chosenUser)

        MsgBox("Employee edited. Returning you to dashboard.")
        Me.Hide()
        dashboard.Show()

    End Sub

    Function PopulateEmployeeData(ByVal user As User)

        'populate edit form with data from user and database
        Me.txt_employeeno.Text = user.EmployeeID
        Me.txt_username.Text = user.Username
        Me.txt_password.Text = user.Password
        Me.txt_fname.Text = user.FirstName
        Me.txt_lname.Text = user.LastName
        Me.date_dob.Value = user.DoB
        Me.txt_address.Text = user.Address
        Me.txt_city.Text = user.City
        Me.txt_prov.Text = user.Province
        Me.txt_postal.Text = user.PostalCode
        Me.mtxt_homephone.Text = user.HomePhone
        Me.mtxt_cellphone.Text = user.CellPhone
        Me.date_start.Value = user.StartDate
        Me.txt_sin.Text = user.Sin
        Me.txt_salary.Text = user.HourlyPay
        Me.combo_education.Text = user.Education
        Me.combo_access.Text = user.Level

    End Function

    Private Sub txt_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fname.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lname.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_city_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_city.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_prov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prov.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_home_KeyPress(sender As Object, e As KeyPressEventArgs)
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_cell_KeyPress(sender As Object, e As KeyPressEventArgs)
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_employeeno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_employeeno.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_sin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sin.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_salary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_salary.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub mtxt_homephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_homephone.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub mtxt_cellphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_cellphone.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub
End Class