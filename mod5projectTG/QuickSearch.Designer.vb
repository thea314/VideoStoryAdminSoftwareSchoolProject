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
        Me.lbl_videoid = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_videoid = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.grp_search = New System.Windows.Forms.GroupBox()
        Me.grp_results = New System.Windows.Forms.GroupBox()
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
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.txt_language = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_director = New System.Windows.Forms.TextBox()
        Me.rich_actors = New System.Windows.Forms.RichTextBox()
        Me.rich_resume = New System.Windows.Forms.RichTextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.grp_search.SuspendLayout()
        Me.grp_results.SuspendLayout()
        CType(Me.pic_poster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_videoid
        '
        Me.lbl_videoid.AutoSize = True
        Me.lbl_videoid.Location = New System.Drawing.Point(18, 40)
        Me.lbl_videoid.Name = "lbl_videoid"
        Me.lbl_videoid.Size = New System.Drawing.Size(53, 15)
        Me.lbl_videoid.TabIndex = 1
        Me.lbl_videoid.Text = "Video Id:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(339, 40)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(32, 15)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Title:"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(229, 82)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txt_videoid
        '
        Me.txt_videoid.Location = New System.Drawing.Point(93, 32)
        Me.txt_videoid.Name = "txt_videoid"
        Me.txt_videoid.Size = New System.Drawing.Size(144, 23)
        Me.txt_videoid.TabIndex = 4
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(414, 32)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(144, 23)
        Me.txt_title.TabIndex = 5
        '
        'grp_search
        '
        Me.grp_search.Controls.Add(Me.btn_cancel)
        Me.grp_search.Controls.Add(Me.txt_videoid)
        Me.grp_search.Controls.Add(Me.btn_search)
        Me.grp_search.Controls.Add(Me.txt_title)
        Me.grp_search.Controls.Add(Me.lbl_videoid)
        Me.grp_search.Controls.Add(Me.lbl_title)
        Me.grp_search.Location = New System.Drawing.Point(12, 12)
        Me.grp_search.Name = "grp_search"
        Me.grp_search.Size = New System.Drawing.Size(675, 111)
        Me.grp_search.TabIndex = 6
        Me.grp_search.TabStop = False
        Me.grp_search.Text = "Enter your search:"
        '
        'grp_results
        '
        Me.grp_results.Controls.Add(Me.txt_status)
        Me.grp_results.Controls.Add(Me.lbl_status)
        Me.grp_results.Controls.Add(Me.rich_resume)
        Me.grp_results.Controls.Add(Me.rich_actors)
        Me.grp_results.Controls.Add(Me.txt_director)
        Me.grp_results.Controls.Add(Me.TextBox1)
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
        Me.grp_results.Location = New System.Drawing.Point(12, 144)
        Me.grp_results.Name = "grp_results"
        Me.grp_results.Size = New System.Drawing.Size(675, 464)
        Me.grp_results.TabIndex = 7
        Me.grp_results.TabStop = False
        Me.grp_results.Text = "Results:"
        '
        'txt_year
        '
        Me.txt_year.Enabled = False
        Me.txt_year.Location = New System.Drawing.Point(93, 65)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(144, 23)
        Me.txt_year.TabIndex = 11
        '
        'txt_titleResult
        '
        Me.txt_titleResult.Enabled = False
        Me.txt_titleResult.Location = New System.Drawing.Point(93, 28)
        Me.txt_titleResult.Name = "txt_titleResult"
        Me.txt_titleResult.Size = New System.Drawing.Size(278, 23)
        Me.txt_titleResult.TabIndex = 10
        '
        'lbl_resume
        '
        Me.lbl_resume.AutoSize = True
        Me.lbl_resume.Enabled = False
        Me.lbl_resume.Location = New System.Drawing.Point(18, 365)
        Me.lbl_resume.Name = "lbl_resume"
        Me.lbl_resume.Size = New System.Drawing.Size(52, 15)
        Me.lbl_resume.TabIndex = 9
        Me.lbl_resume.Text = "Resume:"
        '
        'lbl_actors
        '
        Me.lbl_actors.AutoSize = True
        Me.lbl_actors.Enabled = False
        Me.lbl_actors.Location = New System.Drawing.Point(18, 269)
        Me.lbl_actors.Name = "lbl_actors"
        Me.lbl_actors.Size = New System.Drawing.Size(44, 15)
        Me.lbl_actors.TabIndex = 8
        Me.lbl_actors.Text = "Actors:"
        '
        'lbl_director
        '
        Me.lbl_director.AutoSize = True
        Me.lbl_director.Enabled = False
        Me.lbl_director.Location = New System.Drawing.Point(18, 213)
        Me.lbl_director.Name = "lbl_director"
        Me.lbl_director.Size = New System.Drawing.Size(52, 15)
        Me.lbl_director.TabIndex = 7
        Me.lbl_director.Text = "Director:"
        '
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.Enabled = False
        Me.lbl_length.Location = New System.Drawing.Point(18, 178)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(47, 15)
        Me.lbl_length.TabIndex = 6
        Me.lbl_length.Text = "Length:"
        '
        'lbl_language
        '
        Me.lbl_language.AutoSize = True
        Me.lbl_language.Enabled = False
        Me.lbl_language.Location = New System.Drawing.Point(18, 143)
        Me.lbl_language.Name = "lbl_language"
        Me.lbl_language.Size = New System.Drawing.Size(62, 15)
        Me.lbl_language.TabIndex = 5
        Me.lbl_language.Text = "Language:"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Enabled = False
        Me.lbl_country.Location = New System.Drawing.Point(18, 109)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(53, 15)
        Me.lbl_country.TabIndex = 4
        Me.lbl_country.Text = "Country:"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Enabled = False
        Me.lbl_year.Location = New System.Drawing.Point(18, 73)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(32, 15)
        Me.lbl_year.TabIndex = 3
        Me.lbl_year.Text = "Year:"
        '
        'lbl_titleresult
        '
        Me.lbl_titleresult.AutoSize = True
        Me.lbl_titleresult.Enabled = False
        Me.lbl_titleresult.Location = New System.Drawing.Point(18, 36)
        Me.lbl_titleresult.Name = "lbl_titleresult"
        Me.lbl_titleresult.Size = New System.Drawing.Size(32, 15)
        Me.lbl_titleresult.TabIndex = 2
        Me.lbl_titleresult.Text = "Title:"
        '
        'pic_poster
        '
        Me.pic_poster.Enabled = False
        Me.pic_poster.Location = New System.Drawing.Point(397, 28)
        Me.pic_poster.Name = "pic_poster"
        Me.pic_poster.Size = New System.Drawing.Size(258, 419)
        Me.pic_poster.TabIndex = 1
        Me.pic_poster.TabStop = False
        '
        'txt_country
        '
        Me.txt_country.Enabled = False
        Me.txt_country.Location = New System.Drawing.Point(93, 101)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(144, 23)
        Me.txt_country.TabIndex = 12
        '
        'txt_language
        '
        Me.txt_language.Enabled = False
        Me.txt_language.Location = New System.Drawing.Point(93, 135)
        Me.txt_language.Name = "txt_language"
        Me.txt_language.Size = New System.Drawing.Size(144, 23)
        Me.txt_language.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(93, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 23)
        Me.TextBox1.TabIndex = 14
        '
        'txt_director
        '
        Me.txt_director.Enabled = False
        Me.txt_director.Location = New System.Drawing.Point(93, 205)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(144, 23)
        Me.txt_director.TabIndex = 15
        '
        'rich_actors
        '
        Me.rich_actors.Enabled = False
        Me.rich_actors.Location = New System.Drawing.Point(93, 234)
        Me.rich_actors.Name = "rich_actors"
        Me.rich_actors.Size = New System.Drawing.Size(278, 86)
        Me.rich_actors.TabIndex = 16
        Me.rich_actors.Text = ""
        '
        'rich_resume
        '
        Me.rich_resume.Enabled = False
        Me.rich_resume.Location = New System.Drawing.Point(93, 326)
        Me.rich_resume.Name = "rich_resume"
        Me.rich_resume.Size = New System.Drawing.Size(278, 96)
        Me.rich_resume.TabIndex = 17
        Me.rich_resume.Text = ""
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(339, 82)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(21, 432)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(42, 15)
        Me.lbl_status.TabIndex = 18
        Me.lbl_status.Text = "Status:"
        '
        'txt_status
        '
        Me.txt_status.Enabled = False
        Me.txt_status.Location = New System.Drawing.Point(93, 424)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(144, 23)
        Me.txt_status.TabIndex = 19
        '
        'QuickSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 620)
        Me.Controls.Add(Me.grp_results)
        Me.Controls.Add(Me.grp_search)
        Me.Name = "QuickSearch"
        Me.Text = "QuickSearch"
        Me.grp_search.ResumeLayout(False)
        Me.grp_search.PerformLayout()
        Me.grp_results.ResumeLayout(False)
        Me.grp_results.PerformLayout()
        CType(Me.pic_poster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_language As TextBox
    Friend WithEvents txt_country As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_status As TextBox
    Friend WithEvents lbl_status As Label
End Class
