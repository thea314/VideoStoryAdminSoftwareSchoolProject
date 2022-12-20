Public Class AdvancedSearchResults

    Dim selectedVideo As Integer
    Public pickedVideoFromGrid As VideoItem


    Private Sub AdvancedSearchResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub data_advancedResults_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_advancedResults.CellMouseClick

        Dim selectedVideoValue As Object = data_advancedResults.Rows(e.RowIndex).Cells(0).Value
        selectedVideo = CInt(selectedVideoValue)

        btn_rent.Enabled = True

        Dim accessVideo As DBManagerVideo = New DBManagerVideo()

        pickedVideoFromGrid = accessVideo.GetVideo(selectedVideo)

    End Sub

    Private Sub btn_rent_Click(sender As Object, e As EventArgs) Handles btn_rent.Click

        Me.Hide()
        RentVideo.PopulateData()
        RentVideo.Show()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub AdvancedSearchResults_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        dashboard.Show()
    End Sub
End Class