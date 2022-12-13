Public Class RentVideo

    Public chosenVideo As Integer
    Public chosenUser As Integer

    Private Sub RentVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim populateVideoCombo As DBManagerVideo = New DBManagerVideo()

        populateVideoCombo.PopulateVideoComboboxRent()

        Dim populateCllientCombo As DBManagerClient = New DBManagerClient()

        populateCllientCombo.PopulateClientComboBoxRent()

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



    End Sub

    Private Sub combo_videoid_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_videoid.SelectedValueChanged

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

        LoadImageFromUrl(videoid.Photo, pic_poster)

    End Function

    Private Sub combo_clientid_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_clientid.SelectedValueChanged

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
End Class