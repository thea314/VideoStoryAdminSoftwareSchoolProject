Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class DBManagerClient

    Private connectionString = "server=localhost;user id=root;password=;database=mod5_final_project;"

    Private connect As MySqlConnection

    Public Sub DisplayClientsTable()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT client_number, fname, lname, email, phone, dob,
                 address, city, province, postal_code, 
                CASE 
                    WHEN status = 0 THEN 'Inactive'
                    WHEN status = 1 THEN 'Active'
                    ELSE 'Invalid'
                END
                 FROM clients ORDER BY client_id DESC"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With DisplayClients.data_clients

                .DataSource = datatable

                .Columns(0).HeaderText = "Client Number"
                .Columns(1).HeaderText = "Firstname"
                .Columns(2).HeaderText = "Lastname"
                .Columns(3).HeaderText = "Email"
                .Columns(4).HeaderText = "Phone"
                .Columns(5).HeaderText = "DOB"
                .Columns(6).HeaderText = "Address"
                .Columns(7).HeaderText = "City"
                .Columns(8).HeaderText = "Province"
                .Columns(9).HeaderText = "Postal Code"
                .Columns(10).HeaderText = "Status"

                .Columns(0).Width = 75
                .Columns(1).Width = 75
                .Columns(2).Width = 75
                .Columns(3).Width = 200
                .Columns(4).Width = 75
                .Columns(5).Width = 75
                .Columns(6).Width = 200
                .Columns(7).Width = 75
                .Columns(8).Width = 75
                .Columns(9).Width = 75
                .Columns(10).Width = 50

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub

    Public Sub CreateNewClient()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim cmd As New MySqlCommand()

            With cmd

                .CommandText = "INSERT INTO `clients`( `client_number`, `fname`, `lname`,
                `email`, `phone`, `dob`, `address`, `city`, `province`, `postal_code`, `status`) 
                VALUES (@clientnumber, @fname, @lname, @email, @phone,
                 @dob, @address, @city, @province, @postal_code, @status);"
                .CommandType = CommandType.Text
                .Connection = Me.connect
                .Parameters.AddWithValue("@clientnumber", AddNewClient.txt_client_no.Text)
                .Parameters.AddWithValue("@fname", AddNewClient.txt_fname.Text)
                .Parameters.AddWithValue("@lname", AddNewClient.txt_lname.Text)
                .Parameters.AddWithValue("@email", AddNewClient.txt_email.Text)
                .Parameters.AddWithValue("@phone", AddNewClient.mtxt_phone.Text)
                .Parameters.AddWithValue("@dob", AddNewClient.date_dob.Value)
                .Parameters.AddWithValue("@address", AddNewClient.txt_address.Text)
                .Parameters.AddWithValue("@city", AddNewClient.txt_city.Text)
                .Parameters.AddWithValue("@province", AddNewClient.txt_prov.Text)
                .Parameters.AddWithValue("@postal_code", AddNewClient.txt_postal.Text)
                .Parameters.AddWithValue("@status", AddNewClient.CheckBox_active.Checked)

            End With

            cmd.ExecuteNonQuery()
            Me.connect.Close()
            Me.connect.Dispose()

            MsgBox("New Client created. Returning you to dashboard.")
            AddNewClient.Hide()
            dashboard.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub

    Public Function PopulateClientComboBox()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT CONCAT_WS("" | "", client_number, CONCAT_WS("" "",fname, lname))  AS identification, client_id FROM clients;"

            Dim datatable As New DataTable()
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With cmd

                EditClient.combo_clientpicker.DataSource = datatable
                EditClient.combo_clientpicker.DisplayMember = "identification"
                EditClient.combo_clientpicker.ValueMember = "client_id"

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Public Function PopulateClientComboBoxDelete()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT CONCAT_WS("" | "", client_number, CONCAT_WS("" "",fname, lname))  AS identification, client_id FROM clients;"

            Dim datatable As New DataTable()
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With cmd

                DeleteClient.combo_clientpicker.DataSource = datatable
                DeleteClient.combo_clientpicker.DisplayMember = "identification"
                DeleteClient.combo_clientpicker.ValueMember = "client_id"

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Public Function PopulateClientComboBoxRent()

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT CONCAT_WS("" | "", client_number, CONCAT_WS("" "",fname, lname))  AS identification, client_id FROM clients;"

            Dim datatable As New DataTable()
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With cmd

                RentVideo.combo_clientid.DataSource = datatable
                RentVideo.combo_clientid.DisplayMember = "identification"
                RentVideo.combo_clientid.ValueMember = "client_id"

            End With

            Me.connect.Close()
            Me.connect.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Function UserExists(ByVal clientid As Integer) As Boolean

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText = "SELECT COUNT(*) FROM clients where client_id = @client;"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@client", clientid)

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

    Function GetUser(ByVal clientid As Integer) As Client

        Try

            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String =
                "SELECT `client_id`, `client_number`, `fname`, `lname`, `email`, `phone`, `dob`,
                `address`, `city`, `province`, `postal_code`, `status` 
                FROM `clients` WHERE client_id = @clientid;"

            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@clientid", clientid)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            Dim client As New Client(datatable.Rows(0))

            Return client

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

    Public Function EditClientInfo(ByVal client As Integer)

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        With cmd

            .CommandText =
                "UPDATE `clients` SET `client_number`= @clientNo, `fname`= @fname,
                `lname`= @lname,`email`= @email,`phone`= @phone, `dob`= @dob,
                `address`= @address,`city`= @city,`province`= @province,
                `postal_code`= @postal_code,`status`= @status 
                WHERE client_id = @client;"
            .CommandType = CommandType.Text
            .Connection = Me.connect
            .Parameters.AddWithValue("@client", client)
            .Parameters.AddWithValue("@clientNo", EditClient.txt_client_no.Text)
            .Parameters.AddWithValue("@fname", EditClient.txt_fname.Text)
            .Parameters.AddWithValue("@lname", EditClient.txt_lname.Text)
            .Parameters.AddWithValue("@email", EditClient.txt_email.Text)
            .Parameters.AddWithValue("@phone", EditClient.mtxt_phone.Text)
            .Parameters.AddWithValue("@dob", EditClient.date_dob.Value)
            .Parameters.AddWithValue("@address", EditClient.txt_address.Text)
            .Parameters.AddWithValue("@city", EditClient.txt_city.Text)
            .Parameters.AddWithValue("@province", EditClient.txt_prov.Text)
            .Parameters.AddWithValue("@postal_code", EditClient.txt_postal.Text)
            .Parameters.AddWithValue("@status", EditClient.CheckBox_active.Checked)

        End With

        cmd.ExecuteNonQuery()
        Me.connect.Close()
        Me.connect.Dispose()

    End Function

    Function DeleteClientById(ByVal clientId As Integer)

        Me.connect = New MySqlConnection(connectionString)
        Me.connect.Open()

        Dim cmd As New MySqlCommand()

        Dim delete As String = MsgBox("Do you really want to delete this account?", MsgBoxStyle.YesNo)

        If (delete = vbYes) Then

            With cmd

                .CommandText = "DELETE FROM `clients` WHERE client_id = @client;"
                .Connection = Me.connect
                .Parameters.AddWithValue("@client", clientId)

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
