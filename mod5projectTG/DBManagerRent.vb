Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports MySql.Data.Authentication
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI
Imports Org.BouncyCastle.Crypto.Operators

Public Class DBManagerRent

    Private connectionString = "server=localhost;user id=root;password=;database=mod5_final_project;"

    Private connect As MySqlConnection

    Function NewRental(ByVal videoid As Integer)

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim cmd As New MySqlCommand()

            With cmd

                .CommandText =
                  "INSERT INTO `rents`(`client_fk`, `video_fk`, `rent_date`) 
                    VALUES (@client, @video, @rentDate);"
                .CommandType = CommandType.Text
                .Connection = Me.connect
                .Parameters.AddWithValue("@client", RentVideo.combo_clientid.SelectedValue)
                .Parameters.AddWithValue("@video", videoid)
                .Parameters.AddWithValue("@rentDate", Now.Date)

            End With

            cmd.ExecuteNonQuery()
            Me.connect.Close()
            Me.connect.Dispose()

            MsgBox("Film rented. Returning you to dashboard.")
            AddNewClient.Hide()
            dashboard.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function VideoAvailable(ByVal videoid As Integer) As Boolean

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText = "SELECT COUNT(*) FROM videos where video_id = @video AND status = 1;"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@video", videoid)

        End With

        Dim count As Integer = CInt(cmd.ExecuteScalar())

        'if video id exists, then return true
        If (count <> 0) Then
            Return True
        Else
            Return False
            MsgBox("Video is rented, please try another movie!")
        End If

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Function RentChangeStatus(ByVal videoid As Integer)

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim cmd As New MySqlCommand()

            With cmd

                .CommandText = "UPDATE `videos` SET `status`= 0 WHERE video_id = @videoid;"
                .CommandType = CommandType.Text
                .Connection = Me.connect
                .Parameters.AddWithValue("@videoid", videoid)

            End With

            cmd.ExecuteNonQuery()
            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function DisplayRentedMovies()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT  videos.video_id, CONCAT_WS("" | "", videos.title, CONCAT_WS("" "", clients.fname, clients.lname))
                    FROM `rents`
                    INNER JOIN clients
                    ON rents.client_fk = clients.client_id
                    INNER JOIN videos
                    ON rents.video_fk = videos.video_id;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With ReturnVideo.data_videosout

                .DataSource = datatable

                .Columns(0).HeaderText = "Video Id"
                .Columns(1).HeaderText = "Title and Client"

                .Columns(0).Width = 75
                .Columns(1).Width = 390

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function DisplaySearchedRentedMovieInDGV(ByVal videoid As Integer)

        'display single result when a video id is searched for
        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT  videos.video_id, CONCAT_WS("" | "", videos.title, CONCAT_WS("" "", clients.fname, clients.lname))
                    FROM `rents`
                    INNER JOIN clients
                    ON rents.client_fk = clients.client_id
                    INNER JOIN videos
                    ON rents.video_fk = videos.video_id
                    WHERE videos.video_id = @videoid;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@videoid", videoid)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With ReturnVideo.data_videosout

                .DataSource = datatable

                .Columns(0).HeaderText = "Video Id"
                .Columns(1).HeaderText = "Title and Client"

                .Columns(0).Width = 75
                .Columns(1).Width = 390

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function VerifyRented(ByVal videoid As Integer) As Boolean

        'function to verify if video is rented before proceeding with search function
        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim query As String = "SELECT COUNT(*) FROM videos WHERE video_id = @video;"

        Dim cmd As New MySqlCommand(query, Me.connect)

        With cmd

            .Parameters.AddWithValue("@video", videoid)

        End With

        Dim count As Integer = CInt(cmd.ExecuteScalar())

        'if video id exists and is rented, then return true
        If (count <> 0) Then
            Return True
        Else
            Return False
            MsgBox("Video does not exist, please try again!")
        End If

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Function FiltedRentedByVideoId(ByVal videoid As Integer)

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT  videos.video_id, CONCAT_WS("" | "", videos.title, CONCAT_WS("" "", clients.fname, clients.lname))
                    FROM `rents`
                    INNER JOIN clients
                    ON rents.client_fk = clients.client_id
                    INNER JOIN videos
                    ON rents.video_fk = videos.video_id
                    WHERE videos.video_id = @videoid;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@videoid", videoid)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With ReturnVideo.data_videosout

                .DataSource = datatable

                .Columns(0).HeaderText = "Video Id"
                .Columns(1).HeaderText = "Title and Client"

                .Columns(0).Width = 75
                .Columns(1).Width = 390

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function GetClientFromRentedVideoId(ByVal videoid As Integer) As Client

        'display client info when video is clicked on before returning film.
        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT clients.client_number, clients.fname, clients.lname
                                    FROM rents 
                                    INNER JOIN videos ON rents.video_fk = videos.video_id 
                                    INNER JOIN clients ON rents.client_fk = clients.client_id 
                                    WHERE videos.video_id = @videoid;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@videoid", videoid)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            Dim requestedClient As New Client(datatable.Rows(0)("client_number"), datatable.Rows(0)("fname"),
                                              datatable.Rows(0)("lname"), "asdf@asdf.com",
                                              "5", "1999-12-12", "123 Fake St", "Hull", "QC", "h8h8h8", 0)

            Me.connect.Close()
            Me.connect.Dispose()

            Return requestedClient

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function GetRentalDate(ByVal videoid As Integer) As Rent

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT rents.rent_date                                     
                 FROM rents                                                                         
                 WHERE video_fk = @videoid;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@videoid", videoid)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            Dim requestedRentDate As New Rent(datatable.Rows(0))

            Me.connect.Close()
            Me.connect.Dispose()

            Return requestedRentDate

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function ReturnChangeStatus(ByVal videoid As Integer)

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim cmd As New MySqlCommand()

            With cmd

                .CommandText = "UPDATE `videos` SET `status`= 1 WHERE video_id = @videoid;"
                .CommandType = CommandType.Text
                .Connection = Me.connect
                .Parameters.AddWithValue("@videoid", videoid)

            End With

            cmd.ExecuteNonQuery()
            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

End Class
