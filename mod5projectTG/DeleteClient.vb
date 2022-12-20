Public Class DeleteClient

    Public chosenUser As Integer

    Private Sub DeleteClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim populateCombo As DBManagerClient = New DBManagerClient()

        populateCombo.PopulateClientComboBoxDelete()

    End Sub

    Private Sub combo_clientpicker_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_clientpicker.SelectedValueChanged
        If (IsNumeric(combo_clientpicker.SelectedValue)) Then

            Dim checkIfExists As DBManagerClient = New DBManagerClient()

            chosenUser = combo_clientpicker.SelectedValue

            If (checkIfExists.UserExists(chosenUser)) Then

                Dim accessUser As DBManagerClient = New DBManagerClient()

                Dim user = accessUser.GetUser(chosenUser)

                PopulateClientData(user)

            End If

        End If
    End Sub

    Function PopulateClientData(ByVal client As Client)

        'populate edit form with data from user and database
        Me.txt_client_no.Text = client.ClientNumber
        Me.txt_fname.Text = client.Fname
        Me.txt_lname.Text = client.Lname
        Me.txt_email.Text = client.Email
        Me.mtxt_phone.Text = client.Phone
        Me.date_dob.Value = client.DOB
        Me.txt_address.Text = client.Address
        Me.txt_city.Text = client.City
        Me.txt_prov.Text = client.Province
        Me.txt_postal.Text = client.Postal_Code
        Me.CheckBox_active.Checked = client.Status

    End Function

    Private Sub btn_createnewclient_Click(sender As Object, e As EventArgs) Handles btn_createnewclient.Click

        Dim delete As DBManagerClient = New DBManagerClient()

        delete.DeleteClientById(chosenUser)

        MsgBox("Client deleted. Returning you to the dashboard.")

        Me.Hide()
        GetRefresh()
        dashboard.Show()

    End Sub

    Private Sub btn_cancelnewclient_Click(sender As Object, e As EventArgs) Handles btn_cancelnewclient.Click
        Me.Hide()
        GetRefresh()
        dashboard.Show()
    End Sub

    Private Sub DeleteClient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        GetRefresh()
        dashboard.Show()
    End Sub

    Function GetRefresh()

        Dim populateCombo As DBManagerClient = New DBManagerClient()

        populateCombo.PopulateClientComboBoxDelete()

    End Function

End Class