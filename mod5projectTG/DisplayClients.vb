Public Class DisplayClients
    Private Sub DisplayClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim display As DBManagerClient = New DBManagerClient()

        display.DisplayClientsTable()

    End Sub
End Class