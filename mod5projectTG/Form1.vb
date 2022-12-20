Public Class Form1

    Public loggedUser As User

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim logMeIn As DBManager = New DBManager()

        If (logMeIn.AccountStatus(Me.txt_username.Text)) Then

            logMeIn.Login()
        Else
            MsgBox("Account not activated, please have an admin activate your account.")
            Me.txt_username.Text = ""
            Me.txt_password.Text = ""
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
