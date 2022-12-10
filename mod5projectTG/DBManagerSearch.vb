Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class DBManagerSearch

    Private connectionString = "server=localhost;user id=root;password=;database=mod5_final_project;"

    Private connect As MySqlConnection

    Public Function SearchVideoID(ByVal videoid As Integer)

        'populate datagridview on results page
        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT `video_id`, `title` 
                FROM videos
                WHERE video_id = @videoid;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@videoid", videoid)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With QuickSearch.data_resultViewer

                .DataSource = datatable

                .Columns(0).HeaderText = "Video Number"
                .Columns(1).HeaderText = "Title"

                .Columns(0).Width = 75
                .Columns(1).Width = 260

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Public Function QuickSearchByTitle(ByVal title As String)

        'populate datagridview on results page
        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT `video_id`, `title` 
                FROM videos
                WHERE title LIKE @title;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@title", "%" & title & "%")
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With QuickSearch.data_resultViewer

                .DataSource = datatable

                .Columns(0).HeaderText = "Video Number"
                .Columns(1).HeaderText = "Title"

                .Columns(0).Width = 75
                .Columns(1).Width = 260

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

End Class
