Public Class DisplayVideos
    Private Sub DisplayVideos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim display As DBManagerVideo = New DBManagerVideo()

        display.DisplayVideosTable()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        GetRefresh()
        dashboard.Show()
    End Sub

    Private Sub DisplayVideos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        GetRefresh()
        dashboard.Show()
    End Sub

    Function GetRefresh()

        Dim display As DBManagerVideo = New DBManagerVideo()

        display.DisplayVideosTable()

    End Function
End Class