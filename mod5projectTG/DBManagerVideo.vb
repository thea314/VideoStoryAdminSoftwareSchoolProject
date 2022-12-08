Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

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
                .Parameters.AddWithValue("@year", AddNewVideo.txt_year.Text)
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

            MsgBox("New video created. Returning you to dashboard.")
            AddNewClient.Hide()
            dashboard.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Public Function PopulateVideoCombobox()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT CONCAT_WS("" | "", video_id, title) AS identification, video_id
                                    FROM videos;"

            Dim datatable As New DataTable()
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With cmd

                EditVideo.combo_editpicker.DataSource = datatable
                EditVideo.combo_editpicker.DisplayMember = "identification"
                EditVideo.combo_editpicker.ValueMember = "video_id"

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Public Function PopulateVideoComboboxDelete()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT CONCAT_WS("" | "", video_id, title) AS identification, video_id
                                    FROM videos;"

            Dim datatable As New DataTable()
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With cmd

                DeleteVideo.combo_editpicker.DataSource = datatable
                DeleteVideo.combo_editpicker.DisplayMember = "identification"
                DeleteVideo.combo_editpicker.ValueMember = "video_id"

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function VideoExists(ByVal video As Integer) As Boolean

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText = "SELECT COUNT(*) FROM videos where video_id = @video;"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@video", video)

        End With

        Dim count As Integer = CInt(cmd.ExecuteScalar())

        'if video id exists, then return true
        If (count <> 0) Then
            Return True
        Else
            Return False
            MsgBox("Video does not exist, please try again!")
        End If

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Function GetVideo(ByVal videoid As Integer) As VideoItem

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT `video_id`, `photo`, `title`, `year`, `country`, `language`,
                `length`, `resume`, `genre`, `actors`, `director`, `status` 
                FROM `videos` 
                WHERE video_id = @videoid;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@videoid", videoid)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            Dim requestedVideo As New VideoItem(datatable.Rows(0))

            Return requestedVideo

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Public Function EditVideoInfo(ByVal videoid As Integer)

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText =
                "UPDATE `videos` SET `photo`= @photo, `title`= @title,
                `year`= @year,`country`= @country,`language`= @language,
                `length`= @length,`resume`= @resume,`genre`= @genre,
                `actors`= @actors,`director`= @director 
                WHERE video_id = @videoid;"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@videoid", videoid)
            .Parameters.AddWithValue("@photo", EditVideo.txt_url.Text)
            .Parameters.AddWithValue("@title", EditVideo.txt_title.Text)
            .Parameters.AddWithValue("@year", EditVideo.txt_year.Text)
            .Parameters.AddWithValue("@country", EditVideo.txt_country.Text)
            .Parameters.AddWithValue("@language", EditVideo.txt_language.Text)
            .Parameters.AddWithValue("@length", EditVideo.num_length.Value)
            .Parameters.AddWithValue("@resume", EditVideo.rich_resume.Text)
            .Parameters.AddWithValue("@genre", EditVideo.txt_genre.Text)
            .Parameters.AddWithValue("@actors", EditVideo.rich_actors.Text)
            .Parameters.AddWithValue("@director", EditVideo.txt_director.Text)

        End With

        cmd.ExecuteNonQuery()
        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Function DeleteVideoById(ByVal videoid As Integer)

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        Dim delete As String = MsgBox("Do you really want to delete this account?", MsgBoxStyle.YesNo)

        If (delete = vbYes) Then

            With cmd

                .CommandText = "DELETE FROM `videos` WHERE video_id = @videoid;"
                .Connection = Me.connect
                .Parameters.AddWithValue("@videoid", videoid)

            End With

            cmd.ExecuteNonQuery()
            Me.connect.Close()
            Me.connect.Dispose()

        Else
            Me.connect.Close()
            Me.connect.Dispose()
            Exit Function

        End If

    End Function

End Class
