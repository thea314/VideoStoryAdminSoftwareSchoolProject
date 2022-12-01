Public Class addEmployee

    Public intAccess As Integer

    Private Sub btn_aaddnewEmployee_Click(sender As Object, e As EventArgs) Handles btn_aaddnewEmployee.Click

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

        Dim create As DBManager = New DBManager()

        create.CreateNewEmployee()

    End Sub

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set default values for comboboxes
        combo_access.SelectedIndex = 0
        combo_education.SelectedIndex = 0

    End Sub
End Class