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
                 address, city, province, postal_code, status
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

            Dim query As String = "SELECT CONCAT_WS("" | "", client_number, CONCAT_WS("" "",fname, lname))  AS identification, client_number FROM clients;"

            Dim datatable As New DataTable()
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With cmd

                EditClient.combo_clientpicker.DataSource = datatable
                EditClient.combo_clientpicker.DisplayMember = "identification"
                EditClient.combo_clientpicker.ValueMember = "client_number"

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

    Function GetUser(ByVal clientid As Integer) As User

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

            Dim user As New User(datatable.Rows(0))

            Return user

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Function

End Class
