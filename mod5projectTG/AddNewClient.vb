Public Class AddNewClient
    Private Sub btn_createnewclient_Click(sender As Object, e As EventArgs) Handles btn_createnewclient.Click

        'set minimum lengths of input
        If (Me.txt_client_no.Text = "" Or (Me.txt_client_no.Text.Length < 5)) Then
            MsgBox("Please enter an client number of length greater than 5.")
            Me.txt_client_no.Text = ""
            Exit Sub
        End If

        If (Me.txt_fname.Text = "" Or (Me.txt_fname.Text.Length < 3)) Then
            MsgBox("Please enter a first name of length greater than 3.")
            Me.txt_fname.Text = ""
            Exit Sub
        End If

        If (Me.txt_lname.Text = "" Or (Me.txt_lname.Text.Length < 3)) Then
            MsgBox("Please enter a last name of length greater than 3.")
            Me.txt_lname.Text = ""
            Exit Sub
        End If

        If (Me.txt_email.Text = "" Or (Me.txt_email.Text.Length < 10)) Then
            MsgBox("Please enter a email of length greater than 10.")
            Me.txt_email.Text = ""
            Exit Sub
        End If

        If (Me.mtxt_phone.Text = "" Or (Me.mtxt_phone.Text.Length < 10)) Then
            MsgBox("Please enter a phone of length greater than 10.")
            Me.mtxt_phone.Text = ""
            Exit Sub
        End If

        If (Me.txt_address.Text = "" Or (Me.txt_address.Text.Length < 10)) Then
            MsgBox("Please enter an address of length greater than 10.")
            Me.txt_address.Text = ""
            Exit Sub
        End If

        If (Me.txt_city.Text = "" Or (Me.txt_city.Text.Length < 4)) Then
            MsgBox("Please enter a city name of length greater than 4.")
            Me.txt_city.Text = ""
            Exit Sub
        End If

        If (Me.txt_prov.Text = "" Or (Me.txt_prov.Text.Length < 2)) Then
            MsgBox("Please enter a province name of length greater than 2.")
            Me.txt_prov.Text = ""
            Exit Sub
        End If

        If (Me.txt_postal.Text = "" Or (Me.txt_postal.Text.Length < 5)) Then
            MsgBox("Please enter a postal code of length greater than 5.")
            Me.txt_postal.Text = ""
            Exit Sub
        End If

        'set maximum lengths of input
        If (Me.txt_client_no.Text = "" Or (Me.txt_client_no.Text.Length > 20)) Then
            MsgBox("Please enter a client number of length less than 20.")
            Me.txt_client_no.Text = ""
            Exit Sub
        End If

        If (Me.txt_fname.Text = "" Or (Me.txt_fname.Text.Length > 20)) Then
            MsgBox("Please enter a first name of length less than 20.")
            Me.txt_fname.Text = ""
            Exit Sub
        End If

        If (Me.txt_lname.Text = "" Or (Me.txt_lname.Text.Length > 20)) Then
            MsgBox("Please enter a last name of length less than 4.")
            Me.txt_lname.Text = ""
            Exit Sub
        End If

        If (Me.txt_email.Text = "" Or (Me.txt_email.Text.Length > 50)) Then
            MsgBox("Please enter a email of length less than 50.")
            Me.txt_email.Text = ""
            Exit Sub
        End If

        If (Me.mtxt_phone.Text = "" Or (Me.mtxt_phone.Text.Length > 12)) Then
            MsgBox("Please enter a phone of length less than 12.")
            Me.mtxt_phone.Text = ""
            Exit Sub
        End If

        If (Me.txt_address.Text = "" Or (Me.txt_address.Text.Length > 100)) Then
            MsgBox("Please enter an address of length less than 100.")
            Me.txt_address.Text = ""
            Exit Sub
        End If

        If (Me.txt_city.Text = "" Or (Me.txt_city.Text.Length > 50)) Then
            MsgBox("Please enter a city name of length less than 50.")
            Me.txt_city.Text = ""
            Exit Sub
        End If

        If (Me.txt_prov.Text = "" Or (Me.txt_prov.Text.Length > 50)) Then
            MsgBox("Please enter a province name of length less than 50.")
            Me.txt_prov.Text = ""
            Exit Sub
        End If

        If (Me.txt_postal.Text = "" Or (Me.txt_postal.Text.Length > 7)) Then
            MsgBox("Please enter a postal code of length less than 7.")
            Me.txt_postal.Text = ""
            Exit Sub
        End If

        Dim confirm As String = MsgBox("Confirm this new client?", MsgBoxStyle.YesNo)

        If (confirm = vbYes) Then

            Dim create As DBManagerClient = New DBManagerClient()

            create.CreateNewClient()

        Else
            MsgBox("Client creation canceled.")
            Me.Hide()
            dashboard.Show()
        End If

    End Sub

    Private Sub txt_client_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_client_no.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fname.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lname.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_city_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_city.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_prov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prov.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub mtxt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_phone.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub AddNewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class