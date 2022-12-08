Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class DBManagerSearch

    Private connectionString = "server=localhost;user id=root;password=;database=mod5_final_project;"

    Private connect As MySqlConnection

    Public Function SearchVideoID(ByVal videoid As Integer) As VideoItem

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
            "`video_id`, `title`, `photo`, `year`, `country`, `language`, `length`, `resume`,
                `genre`, `actors`, `director`, 
                CASE WHEN `status` = 1 THEN 'Available' ELSE 'Rented' END AS `status`
                FROM videos
                WHERE video_id = @videoid"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)

            cmd.Parameters.AddWithValue("@videoid", videoid)

            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            Dim video As Integer = datatable.Rows(0)("video_id")
            Dim title As String = datatable.Rows(0)("title")
            Dim photo As String = datatable.Rows(0)("photo")
            Dim year As Integer = datatable.Rows(0)("year")
            Dim country As String = datatable.Rows(0)("country")
            Dim language As String = datatable.Rows(0)("language")
            Dim length As Integer = datatable.Rows(0)("length")
            Dim resumeVideo As String = datatable.Rows(0)("resume")
            Dim actors As String = datatable.Rows(0)("actors")
            Dim director As String = datatable.Rows(0)("director")
            Dim status As Integer = datatable.Rows(0)("status")

            Dim searchedVideo As VideoItem = New VideoItem(video, photo, title, year, country, language, length, resumeVideo,
                                                actors, director, status)

            Return searchedVideo

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

End Class
