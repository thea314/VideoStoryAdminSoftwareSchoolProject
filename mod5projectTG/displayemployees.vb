Public Class displayemployees
    Private Sub displayemployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim employees As DBManager = New DBManager()

        employees.DisplayEmployeesTable()

    End Sub
End Class