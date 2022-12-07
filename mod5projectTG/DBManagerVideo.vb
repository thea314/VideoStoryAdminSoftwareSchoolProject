Imports MySql.Data.MySqlClient

Public Class DBManagerVideo

    Private connectionString = "server=localhost;user id=root;password=;database=mod5_final_project;"

    Private connect As MySqlConnection

    Public Sub DisplayVideosTable()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT `video_id`, `title`, `year`, `country`, `language`, `length`, `resume`,
                `genre`, `actors`, `director`, 
                CASE WHEN `status` = 1 THEN 'Available' ELSE 'Rented' END AS `status`
                FROM `videos`;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With DisplayVideos.data_videos

                .DataSource = datatable

                .Columns(0).HeaderText = "Video Number"
                .Columns(1).HeaderText = "Title"
                .Columns(2).HeaderText = "Year"
                .Columns(3).HeaderText = "Country"
                .Columns(4).HeaderText = "Language"
                .Columns(5).HeaderText = "Length"
                .Columns(6).HeaderText = "Resume"
                .Columns(7).HeaderText = "Genre"
                .Columns(8).HeaderText = "Actors"
                .Columns(9).HeaderText = "Director"
                .Columns(10).HeaderText = "Status"

                .Columns(0).Width = 60
                .Columns(1).Width = 150
                .Columns(2).Width = 40
                .Columns(3).Width = 60
                .Columns(4).Width = 50
                .Columns(5).Width = 50
                .Columns(6).Width = 300
                .Columns(7).Width = 125
                .Columns(8).Width = 250
                .Columns(9).Width = 100
                .Columns(10).Width = 75

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub

    Function CreateNewVideo()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim cmd As New MySqlCommand()

            With cmd

                .CommandText =
                    "INSERT INTO `videos`(`photo`, `title`, `year`, `country`,
                    `language`, `length`, `resume`, `genre`, `actors`, `director`)
                    VALUES (@photo, @title, @year, @country,
                    @language, @length, @resume, @genre, @actors, @director);"
                .CommandType = CommandType.Text
                .Connection = Me.connect
                .Parameters.AddWithValue("@photo", AddNewVideo.txt_url.Text)
                .Parameters.AddWithValue("@title", AddNewVideo.txt_title.Text)
                .Parameters.AddWithValue("@year", AddNewVideo.date_year.Value)
                .Parameters.AddWithValue("@country", AddNewVideo.txt_country.Text)
                .Parameters.AddWithValue("@language", AddNewVideo.txt_language.Text)
                .Parameters.AddWithValue("@length", AddNewVideo.num_length.Value)
                .Parameters.AddWithValue("@resume", AddNewVideo.rich_resume.Text)
                .Parameters.AddWithValue("@genre", AddNewVideo.txt_genre.Text)
                .Parameters.AddWithValue("@actors", AddNewVideo.rich_actors.Text)
                .Parameters.AddWithValue("@director", AddNewVideo.txt_director.Text)

            End With

            cmd.ExecuteNonQuery()
            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function
End Class
