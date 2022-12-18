<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuickSearch))
        Me.lbl_videoid = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_videoid = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.grp_search = New System.Windows.Forms.GroupBox()
        Me.data_resultViewer = New System.Windows.Forms.DataGridView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.grp_results = New System.Windows.Forms.GroupBox()
        Me.txt_genre = New System.Windows.Forms.TextBox()
        Me.lbl_genre = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.rich_resume = New System.Windows.Forms.RichTextBox()
        Me.rich_actors = New System.Windows.Forms.RichTextBox()
        Me.txt_director = New System.Windows.Forms.TextBox()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.txt_language = New System.Windows.Forms.TextBox()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_titleResult = New System.Windows.Forms.TextBox()
        Me.lbl_resume = New System.Windows.Forms.Label()
        Me.lbl_actors = New System.Windows.Forms.Label()
        Me.lbl_director = New System.Windows.Forms.Label()
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_language = New System.Windows.Forms.Label()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_titleresult = New System.Windows.Forms.Label()
        Me.pic_poster = New System.Windows.Forms.PictureBox()
        Me.lbl_quicksearch = New System.Windows.Forms.Label()
        Me.grp_search.SuspendLayout()
        CType(Me.data_resultViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_results.SuspendLayout()
        CType(Me.pic_poster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_videoid
        '
        Me.lbl_videoid.AutoSize = True
        Me.lbl_videoid.Location = New System.Drawing.Point(18, 30)
        Me.lbl_videoid.Name = "lbl_videoid"
        Me.lbl_videoid.Size = New System.Drawing.Size(61, 17)
        Me.lbl_videoid.TabIndex = 1
        Me.lbl_videoid.Text = "Video Id:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(18, 59)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(36, 17)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Title:"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Green
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Location = New System.Drawing.Point(81, 92)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 28)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_videoid
        '
        Me.txt_videoid.Location = New System.Drawing.Point(93, 22)
        Me.txt_videoid.Name = "txt_videoid"
        Me.txt_videoid.Size = New System.Drawing.Size(144, 25)
        Me.txt_videoid.TabIndex = 4
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(93, 51)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(144, 25)
        Me.txt_title.TabIndex = 5
        '
        'grp_search
        '
        Me.grp_search.Controls.Add(Me.data_resultViewer)
        Me.grp_search.Controls.Add(Me.btn_cancel)
        Me.grp_search.Controls.Add(Me.txt_videoid)
        Me.grp_search.Controls.Add(Me.btn_search)
        Me.grp_search.Controls.Add(Me.txt_title)
        Me.grp_search.Controls.Add(Me.lbl_videoid)
        Me.grp_search.Controls.Add(Me.lbl_title)
        Me.grp_search.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_search.Location = New System.Drawing.Point(12, 58)
        Me.grp_search.Name = "grp_search"
        Me.grp_search.Size = New System.Drawing.Size(675, 126)
        Me.grp_search.TabIndex = 6
        Me.grp_search.TabStop = False
        Me.grp_search.Text = "Enter your search:"
        '
        'data_resultViewer
        '
        Me.data_resultViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_resultViewer.Location = New System.Drawing.Point(291, 13)
        Me.data_resultViewer.Name = "data_resultViewer"
        Me.data_resultViewer.RowTemplate.Height = 25
        Me.data_resultViewer.Size = New System.Drawing.Size(378, 107)
        Me.data_resultViewer.TabIndex = 7
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Maroon
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(174, 92)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 28)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'grp_results
        '
        Me.grp_results.Controls.Add(Me.txt_genre)
        Me.grp_results.Controls.Add(Me.lbl_genre)
        Me.grp_results.Controls.Add(Me.txt_status)
        Me.grp_results.Controls.Add(Me.lbl_status)
        Me.grp_results.Controls.Add(Me.rich_resume)
        Me.grp_results.Controls.Add(Me.rich_actors)
        Me.grp_results.Controls.Add(Me.txt_director)
        Me.grp_results.Controls.Add(Me.txt_length)
        Me.grp_results.Controls.Add(Me.txt_language)
        Me.grp_results.Controls.Add(Me.txt_country)
        Me.grp_results.Controls.Add(Me.txt_year)
        Me.grp_results.Controls.Add(Me.txt_titleResult)
        Me.grp_results.Controls.Add(Me.lbl_resume)
        Me.grp_results.Controls.Add(Me.lbl_actors)
        Me.grp_results.Controls.Add(Me.lbl_director)
        Me.grp_results.Controls.Add(Me.lbl_length)
        Me.grp_results.Controls.Add(Me.lbl_language)
        Me.grp_results.Controls.Add(Me.lbl_country)
        Me.grp_results.Controls.Add(Me.lbl_year)
        Me.grp_results.Controls.Add(Me.lbl_titleresult)
        Me.grp_results.Controls.Add(Me.pic_poster)
        Me.grp_results.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_results.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_results.Location = New System.Drawing.Point(12, 190)
        Me.grp_results.Name = "grp_results"
        Me.grp_results.Size = New System.Drawing.Size(675, 444)
        Me.grp_results.TabIndex = 7
        Me.grp_results.TabStop = False
        Me.grp_results.Text = "Results:"
        '
        'txt_genre
        '
        Me.txt_genre.Location = New System.Drawing.Point(93, 174)
        Me.txt_genre.Name = "txt_genre"
        Me.txt_genre.Size = New System.Drawing.Size(144, 25)
        Me.txt_genre.TabIndex = 21
        '
        'lbl_genre
        '
        Me.lbl_genre.AutoSize = True
        Me.lbl_genre.Location = New System.Drawing.Point(18, 182)
        Me.lbl_genre.Name = "lbl_genre"
        Me.lbl_genre.Size = New System.Drawing.Size(47, 17)
        Me.lbl_genre.TabIndex = 20
        Me.lbl_genre.Text = "Genre:"
        '
        'txt_status
        '
        Me.txt_status.Enabled = False
        Me.txt_status.Location = New System.Drawing.Point(472, 352)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(144, 25)
        Me.txt_status.TabIndex = 19
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Enabled = False
        Me.lbl_status.Location = New System.Drawing.Point(397, 363)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(49, 17)
        Me.lbl_status.TabIndex = 18
        Me.lbl_status.Text = "Status:"
        '
        'rich_resume
        '
        Me.rich_resume.Enabled = False
        Me.rich_resume.Location = New System.Drawing.Point(93, 333)
        Me.rich_resume.Name = "rich_resume"
        Me.rich_resume.Size = New System.Drawing.Size(278, 96)
        Me.rich_resume.TabIndex = 17
        Me.rich_resume.Text = ""
        '
        'rich_actors
        '
        Me.rich_actors.Enabled = False
        Me.rich_actors.Location = New System.Drawing.Point(93, 241)
        Me.rich_actors.Name = "rich_actors"
        Me.rich_actors.Size = New System.Drawing.Size(278, 86)
        Me.rich_actors.TabIndex = 16
        Me.rich_actors.Text = ""
        '
        'txt_director
        '
        Me.txt_director.Enabled = False
        Me.txt_director.Location = New System.Drawing.Point(93, 212)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(144, 25)
        Me.txt_director.TabIndex = 15
        '
        'txt_length
        '
        Me.txt_length.Enabled = False
        Me.txt_length.Location = New System.Drawing.Point(93, 138)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(144, 25)
        Me.txt_length.TabIndex = 14
        '
        'txt_language
        '
        Me.txt_language.Enabled = False
        Me.txt_language.Location = New System.Drawing.Point(93, 109)
        Me.txt_language.Name = "txt_language"
        Me.txt_language.Size = New System.Drawing.Size(144, 25)
        Me.txt_language.TabIndex = 13
        '
        'txt_country
        '
        Me.txt_country.Enabled = False
        Me.txt_country.Location = New System.Drawing.Point(93, 80)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(144, 25)
        Me.txt_country.TabIndex = 12
        '
        'txt_year
        '
        Me.txt_year.Enabled = False
        Me.txt_year.Location = New System.Drawing.Point(93, 51)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(144, 25)
        Me.txt_year.TabIndex = 11
        '
        'txt_titleResult
        '
        Me.txt_titleResult.Enabled = False
        Me.txt_titleResult.Location = New System.Drawing.Point(93, 22)
        Me.txt_titleResult.Name = "txt_titleResult"
        Me.txt_titleResult.Size = New System.Drawing.Size(278, 25)
        Me.txt_titleResult.TabIndex = 10
        '
        'lbl_resume
        '
        Me.lbl_resume.AutoSize = True
        Me.lbl_resume.Enabled = False
        Me.lbl_resume.Location = New System.Drawing.Point(18, 372)
        Me.lbl_resume.Name = "lbl_resume"
        Me.lbl_resume.Size = New System.Drawing.Size(59, 17)
        Me.lbl_resume.TabIndex = 9
        Me.lbl_resume.Text = "Resume:"
        '
        'lbl_actors
        '
        Me.lbl_actors.AutoSize = True
        Me.lbl_actors.Enabled = False
        Me.lbl_actors.Location = New System.Drawing.Point(18, 276)
        Me.lbl_actors.Name = "lbl_actors"
        Me.lbl_actors.Size = New System.Drawing.Size(50, 17)
        Me.lbl_actors.TabIndex = 8
        Me.lbl_actors.Text = "Actors:"
        '
        'lbl_director
        '
        Me.lbl_director.AutoSize = True
        Me.lbl_director.Enabled = False
        Me.lbl_director.Location = New System.Drawing.Point(18, 220)
        Me.lbl_director.Name = "lbl_director"
        Me.lbl_director.Size = New System.Drawing.Size(60, 17)
        Me.lbl_director.TabIndex = 7
        Me.lbl_director.Text = "Director:"
        '
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.Enabled = False
        Me.lbl_length.Location = New System.Drawing.Point(18, 146)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(53, 17)
        Me.lbl_length.TabIndex = 6
        Me.lbl_length.Text = "Length:"
        '
        'lbl_language
        '
        Me.lbl_language.AutoSize = True
        Me.lbl_language.Enabled = False
        Me.lbl_language.Location = New System.Drawing.Point(18, 117)
        Me.lbl_language.Name = "lbl_language"
        Me.lbl_language.Size = New System.Drawing.Size(70, 17)
        Me.lbl_language.TabIndex = 5
        Me.lbl_language.Text = "Language:"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Enabled = False
        Me.lbl_country.Location = New System.Drawing.Point(18, 88)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(61, 17)
        Me.lbl_country.TabIndex = 4
        Me.lbl_country.Text = "Country:"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Enabled = False
        Me.lbl_year.Location = New System.Drawing.Point(18, 59)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(38, 17)
        Me.lbl_year.TabIndex = 3
        Me.lbl_year.Text = "Year:"
        '
        'lbl_titleresult
        '
        Me.lbl_titleresult.AutoSize = True
        Me.lbl_titleresult.Enabled = False
        Me.lbl_titleresult.Location = New System.Drawing.Point(18, 30)
        Me.lbl_titleresult.Name = "lbl_titleresult"
        Me.lbl_titleresult.Size = New System.Drawing.Size(36, 17)
        Me.lbl_titleresult.TabIndex = 2
        Me.lbl_titleresult.Text = "Title:"
        '
        'pic_poster
        '
        Me.pic_poster.Enabled = False
        Me.pic_poster.Location = New System.Drawing.Point(397, 28)
        Me.pic_poster.Name = "pic_poster"
        Me.pic_poster.Size = New System.Drawing.Size(258, 299)
        Me.pic_poster.TabIndex = 1
        Me.pic_poster.TabStop = False
        '
        'lbl_quicksearch
        '
        Me.lbl_quicksearch.AutoSize = True
        Me.lbl_quicksearch.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_quicksearch.ForeColor = System.Drawing.Color.LightCoral
        Me.lbl_quicksearch.Location = New System.Drawing.Point(12, 9)
        Me.lbl_quicksearch.Name = "lbl_quicksearch"
        Me.lbl_quicksearch.Size = New System.Drawing.Size(168, 32)
        Me.lbl_quicksearch.TabIndex = 8
        Me.lbl_quicksearch.Text = "Quick Search:"
        '
        'QuickSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(703, 642)
        Me.Controls.Add(Me.lbl_quicksearch)
        Me.Controls.Add(Me.grp_results)
        Me.Controls.Add(Me.grp_search)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuickSearch"
        Me.Text = "Quick Search"
        Me.grp_search.ResumeLayout(False)
        Me.grp_search.PerformLayout()
        CType(Me.data_resultViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_results.ResumeLayout(False)
        Me.grp_results.PerformLayout()
        CType(Me.pic_poster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_videoid As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_videoid As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents grp_search As GroupBox
    Friend WithEvents grp_results As GroupBox
    Friend WithEvents lbl_year As Label
    Friend WithEvents lbl_titleresult As Label
    Friend WithEvents pic_poster As PictureBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_titleResult As TextBox
    Friend WithEvents lbl_resume As Label
    Friend WithEvents lbl_actors As Label
    Friend WithEvents lbl_director As Label
    Friend WithEvents lbl_length As Label
    Friend WithEvents lbl_language As Label
    Friend WithEvents lbl_country As Label
    Friend WithEvents rich_resume As RichTextBox
    Friend WithEvents rich_actors As RichTextBox
    Friend WithEvents txt_director As TextBox
    Friend WithEvents txt_length As TextBox
    Friend WithEvents txt_language As TextBox
    Friend WithEvents txt_country As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_status As TextBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents data_resultViewer As DataGridView
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents lbl_genre As Label
    Friend WithEvents lbl_quicksearch As Label
End Class
