Imports System.Net
Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class DBManager

    Private connectionString = "server=localhost;user id=root;password=;database=mod5_final_project;"

    Private connect As MySqlConnection

    Public Sub DisplayEmployeesTable()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT employee_number, fname, lname, dob, address, city, province, postal_code,
                home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status 
                FROM users;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With displayemployees.data_displayemp

                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Firstname"
                .Columns(2).HeaderText = "Lastname"
                .Columns(3).HeaderText = "Age"
                .Columns(4).HeaderText = "Gender"
                .Columns(5).HeaderText = "Status"
                .Columns(6).HeaderText = "ID"
                .Columns(7).HeaderText = "Firstname"
                .Columns(8).HeaderText = "Lastname"
                .Columns(9).HeaderText = "Age"
                .Columns(10).HeaderText = "Gender"
                .Columns(11).HeaderText = "Status"
                .Columns(12).HeaderText = "ID"
                .Columns(13).HeaderText = "Firstname"
                .Columns(14).HeaderText = "Lastname"




            End With

        Catch ex As Exception

        End Try

    End Sub


End Class
