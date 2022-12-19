Public Class ChangePassword

    Dim password As String
    Dim confirmPassword As String

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        If (Form1.loggedUser.Password = Me.txt_oldPassword.Text) Then

            password = Me.txt_newPassword.Text
            confirmPassword = Me.txt_confirmPassword.Text

            If (password <> confirmPassword) Then
                MsgBox("Passwords do not match. Please try again.")
                Me.txt_newPassword.Text = ""
                Me.txt_confirmPassword.Text = ""
            End If

            If (password = confirmPassword) Then

                Dim update As DBManager = New DBManager()

                update.UpdatePassword(Form1.loggedUser.Username)

                MsgBox("Password updated successfully, returning to dashboard.")
                Me.Hide()
                dashboard.Show()

            End If

        Else
            MsgBox("Old password doesn't match! Try again!")
            Me.txt_oldPassword.Text = ""
            Me.txt_newPassword.Text = ""
            Me.txt_confirmPassword.Text = ""
        End If

    End Sub

    Private Sub ChangePassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        dashboard.Show()
    End Sub
End Class