Public Class dashboard


    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        displayemployees.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        Dim logout As DBManager = New DBManager()

        logout.Logout()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        Me.Hide()
        addEmployee.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Me.Hide()
        EditEmployee.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.Hide()
        DeleteEmployee.Show()
    End Sub

    Private Sub ListToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem2.Click
        Me.Hide()
        DisplayClients.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Me.Hide()
        AddNewClient.Show()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        Me.Hide()
        EditClient.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        Me.Hide()
        DeleteClient.Show()
    End Sub

    Private Sub ListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem1.Click
        Me.Hide()
        DisplayVideos.Show()
    End Sub

    Private Sub CreateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem1.Click
        Me.Hide()
        AddNewVideo.Show()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Me.Hide()
        EditVideo.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        Me.Hide()
        DeleteVideo.Show()
    End Sub

    Private Sub QuickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickToolStripMenuItem.Click
        Me.Hide()
        QuickSearch.Show()
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        Me.Hide()
        AdvancedSearch.Show()
    End Sub

    Private Sub RentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RentToolStripMenuItem1.Click
        Me.Hide()
        RentVideo.PopulateData()
        RentVideo.Show()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide()
        ReturnVideo.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Super Video Store System, an excellent project by Thea Gregory, 5291240.")
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateMenus()

        RefreshGrids()

    End Sub

    Private Sub dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Hide()

        Dim logout As DBManager = New DBManager()

        logout.Logout()

    End Sub

    Public Sub RefreshGrids()

        Dim clients As DBManager = New DBManager()

        clients.DashboardDisplayClientsWithMoviesRented()

        clients.DashboardVideosRented()

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Me.Hide()
        ChangePassword.Show()
    End Sub

    Function PopulateMenus()

        EmployeeToolStripMenuItem.Available = True
        DeleteToolStripMenuItem.Available = True
        DeleteToolStripMenuItem1.Available = True
        DeleteToolStripMenuItem2.Available = True
        EditToolStripMenuItem.Available = True
        EditToolStripMenuItem1.Available = True
        EditToolStripMenuItem2.Available = True

        If (Form1.loggedUser.Level = 3) Then
            EmployeeToolStripMenuItem.Available = False
        End If

        If (Form1.loggedUser.Level = 2) Then

            EmployeeToolStripMenuItem.Available = False
            DeleteToolStripMenuItem.Available = False
            DeleteToolStripMenuItem1.Available = False
            DeleteToolStripMenuItem2.Available = False

        End If

        If (Form1.loggedUser.Level = 1) Then

            EmployeeToolStripMenuItem.Available = False
            DeleteToolStripMenuItem.Available = False
            DeleteToolStripMenuItem1.Available = False
            DeleteToolStripMenuItem2.Available = False
            EditToolStripMenuItem.Available = False
            EditToolStripMenuItem1.Available = False
            EditToolStripMenuItem2.Available = False

        End If


    End Function
End Class