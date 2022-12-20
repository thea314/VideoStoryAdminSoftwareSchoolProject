Public Class displayemployees
    Private Sub displayemployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim employees As DBManager = New DBManager()

        employees.DisplayEmployeesTable()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        GetRefresh()
        dashboard.Show()
    End Sub

    Private Sub displayemployees_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        GetRefresh()
        dashboard.Show()
    End Sub

    Function GetRefresh()

        Dim employees As DBManager = New DBManager()

        employees.DisplayEmployeesTable()

    End Function
End Class