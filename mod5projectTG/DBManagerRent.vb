Imports MySql.Data.MySqlClient

Public Class DBManagerRent

    Private connectionString = "server=localhost;user id=root;password=;database=mod5_final_project;"

    Private connect As MySqlConnection

    Function NewRental()

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
                .Parameters.AddWithValue("@video", RentVideo.combo_videoid.SelectedValue)
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




End Class
