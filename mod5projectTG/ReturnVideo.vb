Public Class ReturnVideo

    Dim selectedVideo As Integer

    Private Sub ReturnVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'display rented movies to user
        Dim display As DBManagerRent = New DBManagerRent()

        display.DisplayRentedMovies()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        'check to verify that video exists and if it has already been rented
        Dim videoExists As DBManagerVideo = New DBManagerVideo()

        Dim videoRented As DBManagerRent = New DBManagerRent()

        If (Me.txt_videoid.Text = "") Then
            MsgBox("Please enter a valid video id.")
            txt_videoid.Text = ""
            Exit Sub
        End If

        If (videoExists.VideoExists(txt_videoid.Text)) Then

            If (videoRented.VerifyRented(txt_videoid.Text)) Then

                videoRented.FiltedRentedByVideoId(txt_videoid.Text)

            Else
                MsgBox("Video hasn't been rented. Please enter a new video id.")
                txt_videoid.Text = ""
                Exit Sub
            End If

        Else
            txt_videoid.Text = ""
        End If

    End Sub

    Private Sub txt_videoid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_videoid.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Function PopulateClientData(ByVal clientid As Client)

        'populate text fields with info from database
        Me.txt_clientNo.Text = clientid.ClientNumber
        Me.txt_clientName.Text = clientid.Fname & clientid.Lname


    End Function

    Function PopulateRentalData(ByVal rentid As Rent)

        'populate rent date
        Me.txt_rentedOn.Text = rentid.RentDate

    End Function


    Public Sub LoadImageFromUrl(ByRef url As String, ByVal pb As PictureBox)
        'load poster for video
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36 Edg/83.0.478.45"
            Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
            Dim img As Image = Image.FromStream(response.GetResponseStream())
            response.Close()
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Image = img
        Catch ex As Exception
            MsgBox("Image not found.")
        End Try

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Dim askReturn As String = MsgBox("Are you sure you want to return this movie?", MsgBoxStyle.YesNo)

        If (askReturn = vbYes) Then

            Dim checkRowVideoId As Integer = data_videosout.SelectedRows(0).Cells(0).Value

            Dim returnVideo As DBManagerRent = New DBManagerRent()

            'set status to available in videos
            returnVideo.ReturnChangeStatus(checkRowVideoId)

            'remove rental from rents
            returnVideo.DeletedAfterReturn(checkRowVideoId)

            'refresh rented movies
            returnVideo.DisplayRentedMovies()

        Else
            MsgBox("Please select a video to return.")
            Exit Sub

        End If

    End Sub

    Private Sub data_videosout_SelectionChanged(sender As Object, e As EventArgs) Handles data_videosout.SelectionChanged

        'make sure selection is valid
        If (data_videosout.SelectedRows.Count > 0) Then

            'define row value
            Dim checkRowVideoId As Integer = data_videosout.SelectedRows(0).Cells(0).Value

            If ((IsNumeric(checkRowVideoId)) And (checkRowVideoId <> Nothing)) Then

                'load client info
                Dim accessClient As DBManagerRent = New DBManagerRent()

                Dim pickedClientFromGrid As Client = accessClient.GetClientFromRentedVideoId(checkRowVideoId)

                PopulateClientData(pickedClientFromGrid)

                'load rental date
                Dim accessVideoRentalDate As DBManagerRent = New DBManagerRent()

                Dim rentalDate = accessVideoRentalDate.GetRentalDate(checkRowVideoId)

                PopulateRentalData(rentalDate)

                'display poster thumbnail
                Dim accessVideoPoster As DBManagerRent = New DBManagerRent()

                Dim posterLink = accessVideoPoster.GetVideoPoster(checkRowVideoId)

                PopulatePoster(posterLink)

            End If

        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
        dashboard.RefreshGrids()
        dashboard.Show()
    End Sub

    Private Sub ReturnVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        dashboard.RefreshGrids()
        dashboard.Show()
    End Sub

    Function PopulatePoster(ByVal videoid As VideoItem)

        LoadImageFromUrl(videoid.Photo, pic_poster)

    End Function

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        Me.txt_videoid.Text = ""

        Dim display As DBManagerRent = New DBManagerRent()

        display.DisplayRentedMovies()

    End Sub
End Class