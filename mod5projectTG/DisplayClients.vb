Public Class DisplayClients
    Private Sub DisplayClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim display As DBManagerClient = New DBManagerClient()

        display.DisplayClientsTable()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub DisplayClients_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        dashboard.Show()
    End Sub
End Class