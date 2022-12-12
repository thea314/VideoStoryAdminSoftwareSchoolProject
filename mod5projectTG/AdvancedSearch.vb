Public Class AdvancedSearch

    Dim queryList As New List(Of AdvancedSearchClass)
    Dim builtQuery As String
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        AdvanceSearchQueryBuilder()

        builtQuery = "SELECT `video_id`, `title`, `year`, `country`, `language`, `length`, `resume`, `genre`, `actors`, `director` FROM videos WHERE "

        For i As Integer = 0 To queryList.Count - 1

            builtQuery = builtQuery & queryList(i).ValueName & " LIKE " & queryList(i).ValueField

            If (i = queryList.Count - 1) Then
                    builtQuery = builtQuery & ";"
                Else
                    builtQuery = builtQuery & " OR "
            End If

        Next

    End Sub

    Private Sub txt_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_year.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_length_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_length.KeyPress
        'make sure it's a number
        If (Not Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a number.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_genre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_genre.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_country_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_country.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Private Sub txt_language_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_language.KeyPress
        'make sure it's a letter
        If (Char.IsNumber(e.KeyChar)) Then

            MsgBox("Please enter a letter.")
            e.Handled = True
            Exit Sub

        End If
    End Sub

    Function AdvanceSearchQueryBuilder() As AdvancedSearchClass

        queryList.Clear()

        If (Not Me.txt_title.Text = "") Then

            Dim searchTitle As AdvancedSearchClass = New AdvancedSearchClass("title", "@title", Me.txt_title.Text)

            queryList.Add(searchTitle)

        End If

        If (Not Me.txt_genre.Text = "") Then

            Dim searchGenre As AdvancedSearchClass = New AdvancedSearchClass("genre", "@genre", Me.txt_genre.Text)

            queryList.Add(searchGenre)

        End If

        If (Not Me.txt_year.Text = "") Then

            Dim searchYear As AdvancedSearchClass = New AdvancedSearchClass("year", "@year", Me.txt_year.Text)

            queryList.Add(searchYear)

        End If

        If (Not Me.txt_country.Text = "") Then

            Dim searchCountry As AdvancedSearchClass = New AdvancedSearchClass("country", "@country", Me.txt_country.Text)

            queryList.Add(searchCountry)

        End If

        If (Not Me.txt_language.Text = "") Then

            Dim searchLanguage As AdvancedSearchClass = New AdvancedSearchClass("language", "@language", Me.txt_language.Text)

            queryList.Add(searchLanguage)

        End If

        If (Not Me.txt_length.Text = "") Then

            Dim searchLength As AdvancedSearchClass = New AdvancedSearchClass("length", "@length", Me.txt_length.Text)

            queryList.Add(searchLength)

        End If

        If (Not Me.txt_director.Text = "") Then

            Dim searchDirector As AdvancedSearchClass = New AdvancedSearchClass("director", "@director", Me.txt_director.Text)

            queryList.Add(searchDirector)

        End If

        If (Not Me.rich_actors.Text = "") Then

            Dim searchActors As AdvancedSearchClass = New AdvancedSearchClass("actors", "@actors", Me.rich_actors.Text)

            queryList.Add(searchActors)

        End If

        If (Not Me.rich_resume.Text = "") Then

            Dim searchResume As AdvancedSearchClass = New AdvancedSearchClass("resume", "@resume", Me.rich_resume.Text)

            queryList.Add(searchResume)

        End If

    End Function
End Class