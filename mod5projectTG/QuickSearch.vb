Public Class QuickSearch

    Dim selectedVideo As Integer

    Private Sub QuickSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        'if video id is entered, populate datagridview
        If (txt_videoid.Text <> "") Then

            Dim searchByVideoId As DBManagerSearch = New DBManagerSearch()

            searchByVideoId.SearchVideoID(txt_videoid.Text)

        End If

        If (txt_title.Text <> "") Then

            Dim searchByTitle As DBManagerSearch = New DBManagerSearch()

            searchByTitle.QuickSearchByTitle(txt_title.Text)

        End If

    End Sub

    Private Sub data_resultViewer_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_resultViewer.CellMouseClick

        Dim selectedVideoValue As Object = data_resultViewer.Rows(e.RowIndex).Cells(0).Value
        selectedVideo = CInt(selectedVideoValue)

        Dim accessVideo As DBManagerVideo = New DBManagerVideo()

        Dim pickedVideoFromGrid = accessVideo.GetVideo(selectedVideo)

        PopulateVideoData(pickedVideoFromGrid)

    End Sub

    Function PopulateVideoData(ByVal videoid As VideoItem)

        'populate edit form with data from video and database        
        Me.txt_titleResult.Text = videoid.Title
        Me.txt_year.Text = videoid.Year
        Me.txt_country.Text = videoid.Country
        Me.txt_language.Text = videoid.Language
        Me.txt_length.Text = videoid.Length
        Me.rich_resume.Text = videoid.VideoResume
        Me.txt_genre.Text = videoid.Genre
        Me.rich_actors.Text = videoid.Actors
        Me.txt_director.Text = videoid.Director

        If (videoid.Status = 0) Then
            Me.txt_status.Text = "Rented"
        End If

        If (videoid.Status = 1) Then
            Me.txt_status.Text = "Available"
        End If


        LoadImageFromUrl(videoid.Photo, pic_poster)

    End Function
End Class