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

        'TODO: change from datepicker to textbox for year

        'populate edit form with data from video and database
        Me.txt_url.Text = videoid.Photo
        Me.txt_title.Text = videoid.Title
        Me.date_year.Text = videoid.Year
        Me.txt_country.Text = videoid.Country
        Me.txt_language.Text = videoid.Language
        Me.num_length.Value = videoid.Length
        Me.rich_resume.Text = videoid.VideoResume
        Me.txt_genre.Text = videoid.Genre
        Me.rich_actors.Text = videoid.Actors
        Me.txt_director.Text = videoid.Director

    End Function
End Class