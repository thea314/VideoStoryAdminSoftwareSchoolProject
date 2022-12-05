Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub btn_AddNewEmployee_Click(sender As Object, e As EventArgs) Handles btn_AddNewEmployee.Click
        Me.Hide()
        addEmployee.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Me.Hide()
        EditEmployee.Show()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Me.Hide()
        DeleteEmployee.Show()
    End Sub
End Class
