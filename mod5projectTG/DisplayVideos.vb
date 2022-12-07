Public Class DisplayVideos
    Private Sub DisplayVideos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim display As DBManagerVideo = New DBManagerVideo()

        display.DisplayVideosTable()

    End Sub
End Class