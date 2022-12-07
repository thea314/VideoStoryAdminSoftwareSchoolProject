Public Class AddNewVideo
    Private Sub AddNewVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.date_year.CustomFormat = "yyyy"
        date_year.Format = DateTimePickerFormat.Custom

    End Sub

    Private Sub btn_addNewVideo_Click(sender As Object, e As EventArgs) Handles btn_addNewVideo.Click

        Dim confirm As String = MsgBox("Confirm this new video?", MsgBoxStyle.YesNo)

        If (confirm = vbYes) Then

            Dim create As DBManagerVideo = New DBManagerVideo()

            create.CreateNewVideo()

        Else
            MsgBox("Client creation canceled.")
            Me.Hide()
            dashboard.Show()
        End If

    End Sub


End Class