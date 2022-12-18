Public Class Form1

    Public loggedUser As User

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

    Private Sub btn_view_clients_Click(sender As Object, e As EventArgs) Handles btn_view_clients.Click
        Me.Hide()
        DisplayClients.Show()
    End Sub

    Private Sub btn_newclient_Click(sender As Object, e As EventArgs) Handles btn_newclient.Click
        Me.Hide()
        AddNewClient.Show()
    End Sub

    Private Sub btn_editclient_Click(sender As Object, e As EventArgs) Handles btn_editclient.Click
        Me.Hide()
        EditClient.Show()
    End Sub

    Private Sub btn_delete_client_Click(sender As Object, e As EventArgs) Handles btn_delete_client.Click
        Me.Hide()
        DeleteClient.Show()
    End Sub

    Private Sub btn_viewvideos_Click(sender As Object, e As EventArgs) Handles btn_viewvideos.Click
        Me.Hide()
        DisplayVideos.Show()
    End Sub

    Private Sub btn_displayEmployee_Click(sender As Object, e As EventArgs) Handles btn_displayEmployee.Click
        Me.Hide()
        displayemployees.Show()
    End Sub

    Private Sub btn_addvideo_Click(sender As Object, e As EventArgs) Handles btn_addvideo.Click
        Me.Hide()
        AddNewVideo.Show()
    End Sub

    Private Sub btn_editvideo_Click(sender As Object, e As EventArgs) Handles btn_editvideo.Click
        Me.Hide()
        EditVideo.Show()
    End Sub

    Private Sub btn_deletevideo_Click(sender As Object, e As EventArgs) Handles btn_deletevideo.Click
        Me.Hide()
        DeleteVideo.ShowDialog()
    End Sub

    Private Sub btn_quick_Click(sender As Object, e As EventArgs) Handles btn_quick.Click
        Me.Hide()
        QuickSearch.Show()
    End Sub

    Private Sub btn_advancedSearch_Click(sender As Object, e As EventArgs) Handles btn_advancedSearch.Click
        Me.Hide()
        AdvancedSearch.Show()
    End Sub

    Private Sub btn_rent_Click(sender As Object, e As EventArgs) Handles btn_rent.Click
        Me.Hide()
        RentVideo.Show()
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        ReturnVideo.Show()
    End Sub


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim logMeIn As DBManager = New DBManager()

        logMeIn.Login()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
