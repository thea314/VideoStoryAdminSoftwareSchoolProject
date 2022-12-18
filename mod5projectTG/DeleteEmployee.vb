Public Class DeleteEmployee

    Public chosenUser As Integer
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

    Private Sub DeleteEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim populateCombo As DBManager = New DBManager()

        populateCombo.PopulateUserComboBoxDelete()

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

    Private Sub btn_aaddnewEmployee_Click(sender As Object, e As EventArgs) Handles btn_aaddnewEmployee.Click

        Dim delete As DBManager = New DBManager()

        delete.DeleteEmployeeById(chosenUser)

        MsgBox("User deleted. Returning you to the dashboard.")

        Me.Hide()
        dashboard.Show()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub DeleteEmployee_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        dashboard.Show()
    End Sub
End Class