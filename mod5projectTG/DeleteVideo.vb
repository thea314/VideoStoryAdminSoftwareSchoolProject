Public Class DeleteVideo

    Public chosenVideo As Integer

    Private Sub DeleteVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim populateCombo As DBManagerVideo = New DBManagerVideo()

        populateCombo.PopulateVideoComboboxDelete()

    End Sub

    Private Sub combo_editpicker_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_editpicker.SelectedValueChanged

        'make sure input is numeric
        If (IsNumeric(combo_editpicker.SelectedValue)) Then

            Dim checkIfExists As DBManagerVideo = New DBManagerVideo()

            chosenVideo = combo_editpicker.SelectedValue

            'make sure video exists
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

    Private Sub btn_editVideo_Click(sender As Object, e As EventArgs) Handles btn_deleteVideo.Click

        Dim delete As DBManagerVideo = New DBManagerVideo()

        delete.DeleteVideoById(chosenVideo)

        MsgBox("Client deleted. Returning you to the dashboard.")

        Me.Hide()
        dashboard.Show()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub DeleteVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        dashboard.Show()
    End Sub
End Class