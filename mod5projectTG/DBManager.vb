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

                .Columns(0).HeaderText = "Employee Number"
                .Columns(1).HeaderText = "Firstname"
                .Columns(2).HeaderText = "Lastname"
                .Columns(3).HeaderText = "DOB"
                .Columns(4).HeaderText = "Address"
                .Columns(5).HeaderText = "City"
                .Columns(6).HeaderText = "Prov."
                .Columns(7).HeaderText = "Postal Code"
                .Columns(8).HeaderText = "Home"
                .Columns(9).HeaderText = "Cell"
                .Columns(10).HeaderText = "Start Date"
                .Columns(11).HeaderText = "SIN"
                .Columns(12).HeaderText = "Hourly"
                .Columns(13).HeaderText = "Education"
                .Columns(14).HeaderText = "Access Level"
                .Columns(15).HeaderText = "Status"

                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 300
                .Columns(5).Width = 100
                .Columns(6).Width = 100
                .Columns(7).Width = 50
                .Columns(8).Width = 100
                .Columns(9).Width = 100
                .Columns(10).Width = 100
                .Columns(11).Width = 75
                .Columns(12).Width = 50
                .Columns(13).Width = 50
                .Columns(14).Width = 50
                .Columns(15).Width = 50

            End With

            Me.connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub


End Class
