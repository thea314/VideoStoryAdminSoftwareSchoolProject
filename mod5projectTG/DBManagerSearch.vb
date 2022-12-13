Imports System.Reflection
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Cmp

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

    Private Function GenerateQuery(ByVal queryList As List(Of AdvancedSearchClass)) As String

        Dim builtQuery As String = "SELECT `video_id`, `title`, `year`, `country`, `language`, `length`, `resume`, `genre`, `actors`, `director`, CASE WHEN `status` = 1 THEN 'Available' ELSE 'Rented' END AS `status` FROM videos WHERE "

        For i As Integer = 0 To queryList.Count - 1

            builtQuery = builtQuery & queryList(i).ValueName & " LIKE '%" & queryList(i).ValueField & "%'"

            If (i = queryList.Count - 1) Then
                builtQuery = builtQuery & ";"
            Else
                builtQuery = builtQuery & " OR "
            End If

        Next

        Return builtQuery

    End Function

    Function AdvancedSearch(ByVal queryList As List(Of AdvancedSearchClass))
        Dim cmd As MySqlCommand
        'populate datagridview on results page
        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = GenerateQuery(queryList)

            Dim datatable As New DataTable()

            cmd = New MySqlCommand(query, Me.connect)

            For Each row In queryList

                cmd.Parameters.AddWithValue(row.ValueName, row.ValueField)

            Next

            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With AdvancedSearchResults.data_advancedResults

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
                .Columns(6).Width = 400
                .Columns(7).Width = 125
                .Columns(8).Width = 400
                .Columns(9).Width = 100
                .Columns(10).Width = 60

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

End Class
