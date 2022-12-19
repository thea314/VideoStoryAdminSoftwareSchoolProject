﻿Imports System.Net
Imports System.Windows.Forms.Design
Imports Google.Protobuf
Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports Org.BouncyCastle.Utilities

Public Class DBManager

    Private connectionString = "server=localhost;user id=root;password=;database=mod5_final_project;"

    Private connect As MySqlConnection

    Public Sub DisplayEmployeesTable()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT employee_number, fname, lname, dob, address, city, province, postal_code,
                home_phone, cell_phone, start_date, sin, hourly_pay, education, 
                CASE WHEN level = 4 THEN 'Admin'
                    WHEN level = 3 THEN 'Level 3'
                    WHEN level = 2 THEN 'Level 2'
                    WHEN level = 1 THEN 'Level 1'
                    ELSE 'Invalid'
                    END,
                CASE WHEN `status` = 1 THEN 'Activated' ELSE 'Not Activated' END AS `status`
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
                .Columns(15).Width = 100

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub

    Public Sub CreateNewEmployee()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim cmd As New MySqlCommand()

            With cmd

                .CommandText = "INSERT INTO `users`(`employee_number`, `username`, `password`, `fname`, `lname`, `dob`, `address`, `city`, `province`, `postal_code`, `home_phone`, `cell_phone`, `start_date`, `sin`, `hourly_pay`, `education`, `level`, `status`) VALUES (@employee_number, @username, @password, @fname, @lname, @dob, @address, @city, @province, @postal_code, @home, @cell, @start_date, @sin, @hourly, @education, @level, @status)"
                .CommandType = CommandType.Text
                .Connection = Me.connect
                .Parameters.AddWithValue("@employee_number", addEmployee.txt_employeeno.Text)
                .Parameters.AddWithValue("@username", addEmployee.txt_username.Text)
                .Parameters.AddWithValue("@password", addEmployee.txt_password.Text)
                .Parameters.AddWithValue("@fname", addEmployee.txt_fname.Text)
                .Parameters.AddWithValue("@lname", addEmployee.txt_lname.Text)
                .Parameters.AddWithValue("@dob", addEmployee.date_dob.Value)
                .Parameters.AddWithValue("@address", addEmployee.txt_address.Text)
                .Parameters.AddWithValue("@city", addEmployee.txt_city.Text)
                .Parameters.AddWithValue("@province", addEmployee.txt_prov.Text)
                .Parameters.AddWithValue("@postal_code", addEmployee.txt_postal.Text)
                .Parameters.AddWithValue("@home", addEmployee.mtxt_homephone.Text)
                .Parameters.AddWithValue("@cell", addEmployee.mtxt_cellphone.Text)
                .Parameters.AddWithValue("@start_date", addEmployee.date_start.Value)
                .Parameters.AddWithValue("@sin", addEmployee.txt_sin.Text)
                .Parameters.AddWithValue("@hourly", addEmployee.txt_salary.Text)
                .Parameters.AddWithValue("@education", addEmployee.combo_education.SelectedItem)
                .Parameters.AddWithValue("@level", addEmployee.intAccess)
                .Parameters.AddWithValue("@status", addEmployee.check_active.Checked)

            End With

            cmd.ExecuteNonQuery()
            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub

    Public Function EditEmployeeSubmit(ByVal userid As Integer)

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText = "UPDATE `users` SET `employee_number`= @employee_number,`username`= @username,`password`= @password,`fname`= @fname,`lname`= @lname,`dob`= @dob,`address`= @address,`city`= @city,`province`= @province,`postal_code`= @postal_code,`home_phone`= @home,`cell_phone`= @cell,`start_date`= @start_date,`sin`= @sin,`hourly_pay`= @hourly,`education`= @education,`level`= @level,`status`= @status WHERE user_id = @user"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@user", userid)
            .Parameters.AddWithValue("@employee_number", EditEmployee.txt_employeeno.Text)
            .Parameters.AddWithValue("@username", EditEmployee.txt_username.Text)
            .Parameters.AddWithValue("@password", EditEmployee.txt_password.Text)
            .Parameters.AddWithValue("@fname", EditEmployee.txt_fname.Text)
            .Parameters.AddWithValue("@lname", EditEmployee.txt_lname.Text)
            .Parameters.AddWithValue("@dob", EditEmployee.date_dob.Value)
            .Parameters.AddWithValue("@address", EditEmployee.txt_address.Text)
            .Parameters.AddWithValue("@city", EditEmployee.txt_city.Text)
            .Parameters.AddWithValue("@province", EditEmployee.txt_prov.Text)
            .Parameters.AddWithValue("@postal_code", EditEmployee.txt_postal.Text)
            .Parameters.AddWithValue("@home", EditEmployee.mtxt_homephone.Text)
            .Parameters.AddWithValue("@cell", EditEmployee.mtxt_cellphone.Text)
            .Parameters.AddWithValue("@start_date", EditEmployee.date_start.Value)
            .Parameters.AddWithValue("@sin", EditEmployee.txt_sin.Text)
            .Parameters.AddWithValue("@hourly", EditEmployee.txt_salary.Text)
            .Parameters.AddWithValue("@education", EditEmployee.combo_education.SelectedItem)
            .Parameters.AddWithValue("@level", EditEmployee.intAccess)
            .Parameters.AddWithValue("@status", EditEmployee.check_active.Checked)
        End With

        cmd.ExecuteNonQuery()
        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Public Function PopulateUserComboBox()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT CONCAT_WS("" | "", user_id, employee_number, username, CONCAT_WS("" "",fname, lname))  AS identification, user_id FROM users;"

            Dim datatable As New DataTable()
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With cmd


                EditEmployee.combo_employeePicker.DataSource = datatable
                EditEmployee.combo_employeePicker.DisplayMember = "identification"
                EditEmployee.combo_employeePicker.ValueMember = "user_id"

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Public Function PopulateUserComboBoxDelete()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT CONCAT_WS("" | "", user_id, employee_number, username, CONCAT_WS("" "",fname, lname))  AS identification, user_id FROM users;"

            Dim datatable As New DataTable()
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With cmd


                DeleteEmployee.combo_employeePicker.DataSource = datatable
                DeleteEmployee.combo_employeePicker.DisplayMember = "identification"
                DeleteEmployee.combo_employeePicker.ValueMember = "user_id"

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function GetUser(ByVal userid As Integer) As User

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT employee_number, username, password, fname, lname, dob, address, city, province, postal_code,
                home_phone, cell_phone, start_date, sin, hourly_pay, education, level, status 
                FROM users WHERE user_id = @userid;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@userid", userid)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            Dim user As New User(datatable.Rows(0))

            Return user

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
            Return Nothing
        End Try

    End Function

    Function UserExists(ByVal userid As Integer) As Boolean

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText = "SELECT COUNT(*) FROM users where user_id = @user;"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@user", userid)

        End With

        Dim count As Integer = CInt(cmd.ExecuteScalar())

        'if user id exists, then return true
        If (count <> 0) Then
            Return True
        Else
            Return False
            MsgBox("User does not exist, please try again!")
        End If

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Function DeleteEmployeeById(ByVal userid As Integer)

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        Dim delete As String = MsgBox("Do you really want to delete this account?", MsgBoxStyle.YesNo)

        If (delete = vbYes) Then
            With cmd

                .CommandText = "DELETE FROM `users` WHERE user_id = @user"
                .Connection = Me.connect
                .Parameters.AddWithValue("@user", userid)

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

    Public Function Login()

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText = "SELECT COUNT(*) FROM users WHERE username = @user AND password = @pass"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@user", Form1.txt_username.Text)
            .Parameters.AddWithValue("@pass", Form1.txt_password.Text)

        End With

        Dim count As Integer = CInt(cmd.ExecuteScalar())

        If count <> 0 Then
            Form1.Hide()
            Form1.loggedUser = GetUser(Form1.txt_username.Text)
            dashboard.Show()
        Else
            MsgBox("Incorrect login details. Please try again.")
            Form1.txt_username.Text = ""
            Form1.txt_password.Text = ""
        End If

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Function GetUser(ByVal username As String) As User

        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT *
                FROM users
                WHERE username = @user
                "

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)

            cmd.Parameters.AddWithValue("@user", username)

            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            Dim userid As String = datatable.Rows(0)("employee_number")
            Dim user As String = datatable.Rows(0)("username")
            Dim firstname As String = datatable.Rows(0)("fname")
            Dim lastname As String = datatable.Rows(0)("lname")
            Dim dob As Date = datatable.Rows(0)("dob")
            Dim address As String = datatable.Rows(0)("address")
            Dim city As String = datatable.Rows(0)("city")
            Dim province As String = datatable.Rows(0)("province")
            Dim postalCode As String = datatable.Rows(0)("postal_code")
            Dim homePhone As String = datatable.Rows(0)("home_phone")
            Dim cellPhone As String = datatable.Rows(0)("cell_phone")
            Dim startDate As Date = datatable.Rows(0)("start_date")
            Dim sin As String = datatable.Rows(0)("sin")
            Dim hourlyPay As String = datatable.Rows(0)("hourly_pay")
            Dim education As String = datatable.Rows(0)("education")
            Dim level As Integer = datatable.Rows(0)("level")
            Dim status As Integer = datatable.Rows(0)("status")
            Dim password As String = datatable.Rows(0)("password")

            Dim newUser As New User(datatable.Rows(0))

            Return newUser

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Function CheckDuplicateUsername()

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText = "SELECT COUNT(*) FROM users WHERE username = @user"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@user", addEmployee.txt_username.Text)

        End With

        Dim count As Integer = CInt(cmd.ExecuteScalar())

        Me.connect.Close()
        Me.connect.Dispose()

        If (count <> 0) Then
            MsgBox("Duplicate username. Please try again.")
            addEmployee.txt_username.Text = ""
            Return True
        End If

        Return False

    End Function

    Function Logout()

        Form1.loggedUser = Nothing

        Form1.txt_username.Text = ""
        Form1.txt_password.Text = ""

        dashboard.Hide()
        Form1.Show()

    End Function

    Public Sub DashboardDisplayClientsWithMoviesRented()

        'display a list of clients with movies rented
        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT CONCAT_WS("" "", clients.fname, clients.lname) 
                FROM rents
                INNER JOIN clients ON rents.client_fk = clients.client_id;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With dashboard.dgv_clients

                .DataSource = datatable

                .Columns(0).HeaderText = "Client Name"

                .Columns(0).Width = 197

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub

    Public Sub DashboardVideosRented()

        'display a list of movies rented
        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT videos.title 
                FROM rents
                INNER JOIN videos ON rents.video_fk = videos.video_id;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With dashboard.dgv_videos

                .DataSource = datatable

                .Columns(0).HeaderText = "Video Title"

                .Columns(0).Width = 197

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub

    Public Function UpdatePassword(ByVal username As String)

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()
        With cmd

            .CommandText = "UPDATE `users` SET `password`= @password WHERE username = @user;"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@user", username)
            .Parameters.AddWithValue("@password", ChangePassword.txt_newPassword.Text)

        End With

        cmd.ExecuteNonQuery()
        Me.connect.Close()
        Me.connect.Dispose()

    End Function

End Class
