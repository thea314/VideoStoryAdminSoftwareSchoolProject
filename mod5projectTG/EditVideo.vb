Public Class EditVideo

    Public chosenVideo As Integer

    Private Sub EditVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim populateCombo As DBManagerVideo = New DBManagerVideo()

        populateCombo.PopulateVideoCombobox()

    End Sub

    Private Sub combo_editpicker_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_editpicker.SelectedValueChanged

        If (IsNumeric(combo_editpicker.SelectedValue)) Then

            Dim checkIfExists As DBManagerVideo = New DBManagerVideo()

            chosenVideo = combo_editpicker.SelectedValue

            If (checkIfExists.VideoExists(chosenVideo)) Then

                Dim accessVideo As DBManagerVideo = New DBManagerVideo()

                Dim selectedVideo = accessVideo.GetVideo(chosenVideo)

                PopulateVideoData(selectedVideo)

            End If

        End If

    End Sub

    Function PopulateVideoData(ByVal videoid As VideoItem)

        'populate edit form with data from video and database
        Me.txt_url.Text = videoid.Photo
        Me.txt_title.Text = videoid.Title
        Me.txt_year.Text = videoid.Year
        Me.txt_country.Text = videoid.Country
        Me.txt_language.Text = videoid.Language
        Me.num_length.Value = videoid.Length
        Me.rich_resume.Text = videoid.VideoResume
        Me.txt_genre.Text = videoid.Genre
        Me.rich_actors.Text = videoid.Actors
        Me.txt_director.Text = videoid.Director

    End Function

    Private Sub txt_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_year.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub btn_editVideo_Click(sender As Object, e As EventArgs) Handles btn_editVideo.Click

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

        Dim confirm As String = MsgBox("Confirm this client's revisions?", MsgBoxStyle.YesNo)

        If (confirm = vbYes) Then

            Dim edit As DBManagerVideo = New DBManagerVideo()

            edit.EditVideoInfo(chosenVideo)

            MsgBox("Video edited. Returning you to dashboard.")
            Me.Hide()
            dashboard.Show()

        Else
            MsgBox("Client creation canceled.")
            Me.Hide()
            dashboard.Show()
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub EditVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        dashboard.Show()
    End Sub
End Class