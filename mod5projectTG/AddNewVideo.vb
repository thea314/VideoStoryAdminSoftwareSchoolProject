Public Class AddNewVideo

    Private Sub btn_addNewVideo_Click(sender As Object, e As EventArgs) Handles btn_addNewVideo.Click

        'set minimum lengths of input
        If (Me.txt_title.Text = "") Then
            MsgBox("Please enter a title.")
            Me.txt_title.Text = ""
            Exit Sub
        End If

        If (Me.txt_genre.Text = "" Or (Me.txt_genre.Text.Length < 4)) Then
            MsgBox("Please enter a genre of length greater than 4.")
            Me.txt_genre.Text = ""
            Exit Sub
        End If

        If (Me.txt_country.Text = "" Or (Me.txt_country.Text.Length < 4)) Then
            MsgBox("Please enter a country of length greater than 4.")
            Me.txt_country.Text = ""
            Exit Sub
        End If

        If (Me.txt_director.Text = "" Or (Me.txt_director.Text.Length < 4)) Then
            MsgBox("Please enter a director name of length greater than 4.")
            Me.txt_director.Text = ""
            Exit Sub
        End If

        If (Me.rich_actors.Text = "" Or (Me.rich_actors.Text.Length < 4)) Then
            MsgBox("Please enter a list of actors of length greater than 4.")
            Me.rich_actors.Text = ""
            Exit Sub
        End If

        If (Me.rich_resume.Text = "" Or (Me.rich_resume.Text.Length < 10)) Then
            MsgBox("Please enter a resume of length greater than 10.")
            Me.rich_resume.Text = ""
            Exit Sub
        End If

        If (Me.txt_url.Text = "" Or (Me.txt_url.Text.Length < 10)) Then
            MsgBox("Please enter a poster URL of length greater than 10.")
            Me.txt_url.Text = ""
            Exit Sub
        End If

        If (Me.txt_year.Text = "" Or (Me.txt_year.Text.Length <> 4)) Then
            MsgBox("Please enter a year of length equal to 4.")
            Me.txt_year.Text = ""
            Exit Sub
        End If

        'set maximum lengths of input
        If (Me.txt_title.Text = "" Or (Me.txt_title.Text.Length > 100)) Then
            MsgBox("Please enter a title of length less than 100.")
            Me.txt_title.Text = ""
            Exit Sub
        End If

        If (Me.txt_genre.Text = "" Or (Me.txt_genre.Text.Length > 255)) Then
            MsgBox("Please enter a genre of length less than 255.")
            Me.txt_genre.Text = ""
            Exit Sub
        End If

        If (Me.txt_country.Text = "" Or (Me.txt_country.Text.Length > 50)) Then
            MsgBox("Please enter a country of length less than 50.")
            Me.txt_country.Text = ""
            Exit Sub
        End If

        If (Me.txt_director.Text = "" Or (Me.txt_director.Text.Length > 50)) Then
            MsgBox("Please enter a director name of length less than 50.")
            Me.txt_director.Text = ""
            Exit Sub
        End If

        If (Me.rich_actors.Text = "" Or (Me.rich_actors.Text.Length > 65535)) Then
            MsgBox("Please enter a list of actors of length less than 65535.")
            Me.rich_actors.Text = ""
            Exit Sub
        End If

        If (Me.rich_resume.Text = "" Or (Me.rich_resume.Text.Length > 65535)) Then
            MsgBox("Please enter a resume of length less than 65535.")
            Me.rich_resume.Text = ""
            Exit Sub
        End If

        If (Me.txt_url.Text = "" Or (Me.txt_url.Text.Length > 255)) Then
            MsgBox("Please enter a poster URL of length less than 255.")
            Me.txt_url.Text = ""
            Exit Sub
        End If

        Dim confirm As String = MsgBox("Confirm this new video?", MsgBoxStyle.YesNo)

        If (confirm = vbYes) Then

            Dim create As DBManagerVideo = New DBManagerVideo()

            create.CreateNewVideo()

        Else
            MsgBox("Client creation canceled.")
            Me.Hide()
            dashboard.Show()
        End If

    End Sub

    Private Sub txt_director_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_director.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_language_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_language.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_country_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_country.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_genre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_genre.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_year.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()

        Me.txt_country.Text = ""
        Me.txt_director.Text = ""
        Me.txt_genre.Text = ""
        Me.txt_language.Text = ""
        Me.txt_title.Text = ""
        Me.txt_url.Text = ""
        Me.txt_year.Text = ""
        Me.num_length.Value = 1
        Me.rich_actors.Text = ""
        Me.rich_resume.Text = ""

        dashboard.Show()
    End Sub

    Private Sub AddNewVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()

        Me.txt_country.Text = ""
        Me.txt_director.Text = ""
        Me.txt_genre.Text = ""
        Me.txt_language.Text = ""
        Me.txt_title.Text = ""
        Me.txt_url.Text = ""
        Me.txt_year.Text = ""
        Me.num_length.Value = 1
        Me.rich_actors.Text = ""
        Me.rich_resume.Text = ""

        dashboard.Show()
    End Sub
End Class