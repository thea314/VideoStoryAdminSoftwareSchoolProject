Public Class AdvancedSearchResults

    Dim selectedVideo As Integer
    Dim pickedVideoFromGrid As VideoItem


    Private Sub AdvancedSearchResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub data_advancedResults_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_advancedResults.CellMouseClick

        Dim selectedVideoValue As Object = data_advancedResults.Rows(e.RowIndex).Cells(0).Value
        selectedVideo = CInt(selectedVideoValue)

        Dim accessVideo As DBManagerVideo = New DBManagerVideo()

        pickedVideoFromGrid = accessVideo.GetVideo(selectedVideo)



    End Sub
End Class