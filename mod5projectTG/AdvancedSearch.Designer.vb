<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.rich_resume = New System.Windows.Forms.RichTextBox()
        Me.rich_actors = New System.Windows.Forms.RichTextBox()
        Me.txt_director = New System.Windows.Forms.TextBox()
        Me.txt_language = New System.Windows.Forms.TextBox()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.txt_genre = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.lbl_resume = New System.Windows.Forms.Label()
        Me.lbl_actors = New System.Windows.Forms.Label()
        Me.lbl_director = New System.Windows.Forms.Label()
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_language = New System.Windows.Forms.Label()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_genre = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_length)
        Me.GroupBox1.Controls.Add(Me.txt_year)
        Me.GroupBox1.Controls.Add(Me.rich_resume)
        Me.GroupBox1.Controls.Add(Me.rich_actors)
        Me.GroupBox1.Controls.Add(Me.txt_director)
        Me.GroupBox1.Controls.Add(Me.txt_language)
        Me.GroupBox1.Controls.Add(Me.txt_country)
        Me.GroupBox1.Controls.Add(Me.txt_genre)
        Me.GroupBox1.Controls.Add(Me.txt_title)
        Me.GroupBox1.Controls.Add(Me.lbl_resume)
        Me.GroupBox1.Controls.Add(Me.lbl_actors)
        Me.GroupBox1.Controls.Add(Me.lbl_director)
        Me.GroupBox1.Controls.Add(Me.lbl_length)
        Me.GroupBox1.Controls.Add(Me.lbl_language)
        Me.GroupBox1.Controls.Add(Me.lbl_country)
        Me.GroupBox1.Controls.Add(Me.lbl_year)
        Me.GroupBox1.Controls.Add(Me.lbl_genre)
        Me.GroupBox1.Controls.Add(Me.lbl_title)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 542)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advanced Search"
        '
        'txt_length
        '
        Me.txt_length.Location = New System.Drawing.Point(112, 261)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(239, 23)
        Me.txt_length.TabIndex = 19
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(112, 130)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(239, 23)
        Me.txt_year.TabIndex = 18
        '
        'rich_resume
        '
        Me.rich_resume.Location = New System.Drawing.Point(112, 446)
        Me.rich_resume.Name = "rich_resume"
        Me.rich_resume.Size = New System.Drawing.Size(239, 87)
        Me.rich_resume.TabIndex = 17
        Me.rich_resume.Text = ""
        '
        'rich_actors
        '
        Me.rich_actors.Location = New System.Drawing.Point(112, 345)
        Me.rich_actors.Name = "rich_actors"
        Me.rich_actors.Size = New System.Drawing.Size(239, 86)
        Me.rich_actors.TabIndex = 16
        Me.rich_actors.Text = ""
        '
        'txt_director
        '
        Me.txt_director.Location = New System.Drawing.Point(112, 306)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(239, 23)
        Me.txt_director.TabIndex = 15
        '
        'txt_language
        '
        Me.txt_language.Location = New System.Drawing.Point(112, 219)
        Me.txt_language.Name = "txt_language"
        Me.txt_language.Size = New System.Drawing.Size(239, 23)
        Me.txt_language.TabIndex = 13
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(112, 174)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(239, 23)
        Me.txt_country.TabIndex = 12
        '
        'txt_genre
        '
        Me.txt_genre.Location = New System.Drawing.Point(112, 87)
        Me.txt_genre.Name = "txt_genre"
        Me.txt_genre.Size = New System.Drawing.Size(239, 23)
        Me.txt_genre.TabIndex = 10
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(112, 44)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(239, 23)
        Me.txt_title.TabIndex = 9
        '
        'lbl_resume
        '
        Me.lbl_resume.AutoSize = True
        Me.lbl_resume.Location = New System.Drawing.Point(21, 475)
        Me.lbl_resume.Name = "lbl_resume"
        Me.lbl_resume.Size = New System.Drawing.Size(52, 15)
        Me.lbl_resume.TabIndex = 8
        Me.lbl_resume.Text = "Resume:"
        '
        'lbl_actors
        '
        Me.lbl_actors.AutoSize = True
        Me.lbl_actors.Location = New System.Drawing.Point(21, 380)
        Me.lbl_actors.Name = "lbl_actors"
        Me.lbl_actors.Size = New System.Drawing.Size(44, 15)
        Me.lbl_actors.TabIndex = 7
        Me.lbl_actors.Text = "Actors:"
        '
        'lbl_director
        '
        Me.lbl_director.AutoSize = True
        Me.lbl_director.Location = New System.Drawing.Point(21, 314)
        Me.lbl_director.Name = "lbl_director"
        Me.lbl_director.Size = New System.Drawing.Size(52, 15)
        Me.lbl_director.TabIndex = 6
        Me.lbl_director.Text = "Director:"
        '
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.Location = New System.Drawing.Point(21, 269)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(47, 15)
        Me.lbl_length.TabIndex = 5
        Me.lbl_length.Text = "Length:"
        '
        'lbl_language
        '
        Me.lbl_language.AutoSize = True
        Me.lbl_language.Location = New System.Drawing.Point(21, 227)
        Me.lbl_language.Name = "lbl_language"
        Me.lbl_language.Size = New System.Drawing.Size(62, 15)
        Me.lbl_language.TabIndex = 4
        Me.lbl_language.Text = "Language:"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Location = New System.Drawing.Point(21, 182)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(53, 15)
        Me.lbl_country.TabIndex = 3
        Me.lbl_country.Text = "Country:"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Location = New System.Drawing.Point(21, 138)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(32, 15)
        Me.lbl_year.TabIndex = 2
        Me.lbl_year.Text = "Year:"
        '
        'lbl_genre
        '
        Me.lbl_genre.AutoSize = True
        Me.lbl_genre.Location = New System.Drawing.Point(21, 95)
        Me.lbl_genre.Name = "lbl_genre"
        Me.lbl_genre.Size = New System.Drawing.Size(41, 15)
        Me.lbl_genre.TabIndex = 1
        Me.lbl_genre.Text = "Genre:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(21, 52)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(32, 15)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Title:"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(143, 577)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 2
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(243, 577)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'AdvancedSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 612)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AdvancedSearch"
        Me.Text = "AdvancedSearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_language As TextBox
    Friend WithEvents txt_country As TextBox
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents lbl_resume As Label
    Friend WithEvents lbl_actors As Label
    Friend WithEvents lbl_director As Label
    Friend WithEvents lbl_length As Label
    Friend WithEvents lbl_language As Label
    Friend WithEvents lbl_country As Label
    Friend WithEvents lbl_year As Label
    Friend WithEvents lbl_genre As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents rich_resume As RichTextBox
    Friend WithEvents rich_actors As RichTextBox
    Friend WithEvents txt_director As TextBox
    Friend WithEvents txt_length As TextBox
    Friend WithEvents txt_year As TextBox
End Class
