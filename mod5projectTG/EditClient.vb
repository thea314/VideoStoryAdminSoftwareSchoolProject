Public Class EditClient

    Public chosenUser As Integer

    Private Sub EditClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim populateCombo As DBManagerClient = New DBManagerClient()

        populateCombo.PopulateClientComboBox()

    End Sub

    Private Sub combo_clientpicker_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_clientpicker.SelectedValueChanged

        If (IsNumeric(combo_clientpicker.SelectedValue)) Then

            Dim checkIfExists As DBManagerClient = New DBManagerClient()

            chosenUser = combo_clientpicker.SelectedValue

            If (checkIfExists.UserExists(chosenUser)) Then

                Dim accessUser As DBManagerClient = New DBManagerClient()

                Dim user = accessUser.GetUser(chosenUser)

                PopulateEmployeeData(user)

            End If

        End If

    End Sub
End Class