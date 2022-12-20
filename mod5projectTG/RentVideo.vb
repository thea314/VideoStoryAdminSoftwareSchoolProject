Public Class RentVideo

    Public chosenVideo As Integer
    Public chosenUser As Integer

    Private Sub RentVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateData()


    End Sub

    'load poster for video
    Public Sub LoadImageFromUrl(ByRef url As String, ByVal pb As PictureBox)

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

    Private Sub btn_rent_Click(sender As Object, e As EventArgs) Handles btn_rent.Click

        Dim rentVideo As DBManagerRent = New DBManagerRent()

        'verify that video isn't already rented
        If (rentVideo.VerifyRented(chosenVideo)) Then

            'verify client is active and can rent videos
            If (rentVideo.ClientActive(chosenUser)) Then

                'change status of video to rented
                rentVideo.RentChangeStatus(chosenVideo)

                'add rental to rents table
                rentVideo.NewRental(chosenVideo)

                'show confirmation
                MsgBox("Movie rented, returning you to dashboard.")

                Me.Hide()
                dashboard.RefreshGrids()
                dashboard.Show()

            Else

                MsgBox("Please activate client first.")

                Me.Hide()
                dashboard.RefreshGrids()
                dashboard.Show()

            End If
        Else
            MsgBox("Video already rented, please choose another.")
        End If


    End Sub

    Private Sub combo_videoid_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_videoid.SelectedValueChanged

        'populate video combobox
        If (IsNumeric(combo_videoid.SelectedValue)) Then

            Dim checkIfExists As DBManagerVideo = New DBManagerVideo()

            chosenVideo = combo_videoid.SelectedValue

            If (checkIfExists.VideoExists(chosenVideo)) Then

                Dim accessVideo As DBManagerVideo = New DBManagerVideo()

                Dim selectedVideo = accessVideo.GetVideo(chosenVideo)

                PopulateVideoData(selectedVideo)

            End If

        End If

    End Sub

    Function PopulateVideoData(ByVal videoid As VideoItem)

        'populate edit form with data from video and database        
        Me.txt_title.Text = videoid.Title
        Me.txt_language.Text = videoid.Language
        Me.rich_resume.Text = videoid.VideoResume
        Me.txt_director.Text = videoid.Director

        If (videoid.Status = 0) Then
            Me.txt_status.Text = "Rented"
        End If

        If (videoid.Status = 1) Then
            Me.txt_status.Text = "Avaialble"
        End If

        LoadImageFromUrl(videoid.Photo, pic_poster)

        'check to see if video is available before enabling rent button
        Dim checkVideo As DBManagerRent = New DBManagerRent()

        Dim videoRented As Boolean = checkVideo.VideoAvailable(chosenVideo)

        If (videoRented) Then
            Me.btn_rent.Enabled = True
        End If

    End Function

    Private Sub combo_clientid_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_clientid.SelectedValueChanged

        'populate client combobox
        If (IsNumeric(combo_clientid.SelectedValue)) Then

            Dim checkIfExists As DBManagerClient = New DBManagerClient()

            chosenUser = combo_clientid.SelectedValue

            If (checkIfExists.UserExists(chosenUser)) Then

                Dim accessUser As DBManagerClient = New DBManagerClient()

                Dim user = accessUser.GetUser(chosenUser)

                PopulateClientData(user)

            End If

        End If

    End Sub

    Function PopulateClientData(ByVal client As Client)

        'populate edit form with data from client and database
        Me.txt_name.Text = client.Fname & " " & client.Lname
        Me.txt_phone.Text = client.Phone
        Me.txt_address.Text = client.Address & " " & client.City & " " & client.Province & " " & client.Postal_Code

    End Function

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        dashboard.RefreshGrids()
        dashboard.Show()
    End Sub

    Private Sub RentVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        dashboard.RefreshGrids()
        dashboard.Show()
    End Sub

    Function PopulateData()

        'populate client combobox
        Dim populateCllientCombo As DBManagerClient = New DBManagerClient()

        populateCllientCombo.PopulateClientComboBoxRent()

        'populate video combobox
        Dim populateVideoCombo As DBManagerVideo = New DBManagerVideo()

        populateVideoCombo.PopulateVideoComboboxRent()

        'populate videocombobox depending on if page was referred to by advanced search
        'loop through contents of combobox to find the one clicked on in previous datagridview
        If (AdvancedSearchResults.pickedVideoFromGrid Is Nothing) Then

        Else

            For Each item As System.Data.DataRowView In combo_videoid.Items

                If (item.Row(1) = AdvancedSearchResults.pickedVideoFromGrid.VideoID) Then

                    combo_videoid.SelectedItem = item
                    Exit For

                End If

            Next

            PopulateVideoData(AdvancedSearchResults.pickedVideoFromGrid)
        End If

    End Function
End Class