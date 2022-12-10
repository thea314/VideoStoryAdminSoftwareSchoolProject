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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_genre = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_language = New System.Windows.Forms.Label()
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_director = New System.Windows.Forms.Label()
        Me.lbl_actors = New System.Windows.Forms.Label()
        Me.lbl_resume = New System.Windows.Forms.Label()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.txt_genre = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.txt_language = New System.Windows.Forms.TextBox()
        Me.num_length = New System.Windows.Forms.NumericUpDown()
        Me.txt_director = New System.Windows.Forms.TextBox()
        Me.rich_actors = New System.Windows.Forms.RichTextBox()
        Me.rich_resume = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.num_length, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rich_resume)
        Me.GroupBox1.Controls.Add(Me.rich_actors)
        Me.GroupBox1.Controls.Add(Me.txt_director)
        Me.GroupBox1.Controls.Add(Me.num_length)
        Me.GroupBox1.Controls.Add(Me.txt_language)
        Me.GroupBox1.Controls.Add(Me.txt_country)
        Me.GroupBox1.Controls.Add(Me.txt_year)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 577)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(257, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
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
        'lbl_genre
        '
        Me.lbl_genre.AutoSize = True
        Me.lbl_genre.Location = New System.Drawing.Point(21, 95)
        Me.lbl_genre.Name = "lbl_genre"
        Me.lbl_genre.Size = New System.Drawing.Size(41, 15)
        Me.lbl_genre.TabIndex = 1
        Me.lbl_genre.Text = "Genre:"
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
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Location = New System.Drawing.Point(21, 182)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(53, 15)
        Me.lbl_country.TabIndex = 3
        Me.lbl_country.Text = "Country:"
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
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.Location = New System.Drawing.Point(21, 269)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(47, 15)
        Me.lbl_length.TabIndex = 5
        Me.lbl_length.Text = "Length:"
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
        'lbl_actors
        '
        Me.lbl_actors.AutoSize = True
        Me.lbl_actors.Location = New System.Drawing.Point(21, 380)
        Me.lbl_actors.Name = "lbl_actors"
        Me.lbl_actors.Size = New System.Drawing.Size(44, 15)
        Me.lbl_actors.TabIndex = 7
        Me.lbl_actors.Text = "Actors:"
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
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(112, 44)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(239, 23)
        Me.txt_title.TabIndex = 9
        '
        'txt_genre
        '
        Me.txt_genre.Location = New System.Drawing.Point(112, 87)
        Me.txt_genre.Name = "txt_genre"
        Me.txt_genre.Size = New System.Drawing.Size(239, 23)
        Me.txt_genre.TabIndex = 10
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(112, 130)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(239, 23)
        Me.txt_year.TabIndex = 11
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(112, 174)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(239, 23)
        Me.txt_country.TabIndex = 12
        '
        'txt_language
        '
        Me.txt_language.Location = New System.Drawing.Point(112, 219)
        Me.txt_language.Name = "txt_language"
        Me.txt_language.Size = New System.Drawing.Size(239, 23)
        Me.txt_language.TabIndex = 13
        '
        'num_length
        '
        Me.num_length.Location = New System.Drawing.Point(112, 261)
        Me.num_length.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.num_length.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_length.Name = "num_length"
        Me.num_length.Size = New System.Drawing.Size(239, 23)
        Me.num_length.TabIndex = 14
        Me.num_length.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_director
        '
        Me.txt_director.Location = New System.Drawing.Point(112, 306)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(239, 23)
        Me.txt_director.TabIndex = 15
        '
        'rich_actors
        '
        Me.rich_actors.Location = New System.Drawing.Point(112, 335)
        Me.rich_actors.Name = "rich_actors"
        Me.rich_actors.Size = New System.Drawing.Size(239, 96)
        Me.rich_actors.TabIndex = 16
        Me.rich_actors.Text = ""
        '
        'rich_resume
        '
        Me.rich_resume.Location = New System.Drawing.Point(112, 437)
        Me.rich_resume.Name = "rich_resume"
        Me.rich_resume.Size = New System.Drawing.Size(239, 96)
        Me.rich_resume.TabIndex = 17
        Me.rich_resume.Text = ""
        '
        'AdvancedSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 612)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AdvancedSearch"
        Me.Text = "AdvancedSearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.num_length, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents num_length As NumericUpDown
    Friend WithEvents txt_language As TextBox
    Friend WithEvents txt_country As TextBox
    Friend WithEvents txt_year As TextBox
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
End Class
