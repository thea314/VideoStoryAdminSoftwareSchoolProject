<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditVideo
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
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_editVideo = New System.Windows.Forms.Button()
        Me.grp_videoDetails = New System.Windows.Forms.GroupBox()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.lbl_url = New System.Windows.Forms.Label()
        Me.lbl_resume_text = New System.Windows.Forms.Label()
        Me.rich_resume = New System.Windows.Forms.RichTextBox()
        Me.grp_videoInfo = New System.Windows.Forms.GroupBox()
        Me.txt_language = New System.Windows.Forms.TextBox()
        Me.lbl_language = New System.Windows.Forms.Label()
        Me.txt_director = New System.Windows.Forms.TextBox()
        Me.num_length = New System.Windows.Forms.NumericUpDown()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.date_year = New System.Windows.Forms.DateTimePicker()
        Me.txt_genre = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.rich_actors = New System.Windows.Forms.RichTextBox()
        Me.lbl_actors = New System.Windows.Forms.Label()
        Me.lbl_director = New System.Windows.Forms.Label()
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_genre = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_picker = New System.Windows.Forms.Label()
        Me.combo_editpicker = New System.Windows.Forms.ComboBox()
        Me.grp_videoDetails.SuspendLayout()
        Me.grp_videoInfo.SuspendLayout()
        CType(Me.num_length, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(340, 440)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_editVideo
        '
        Me.btn_editVideo.Location = New System.Drawing.Point(245, 440)
        Me.btn_editVideo.Name = "btn_editVideo"
        Me.btn_editVideo.Size = New System.Drawing.Size(75, 23)
        Me.btn_editVideo.TabIndex = 6
        Me.btn_editVideo.Text = "Edit Video"
        Me.btn_editVideo.UseVisualStyleBackColor = True
        '
        'grp_videoDetails
        '
        Me.grp_videoDetails.Controls.Add(Me.txt_url)
        Me.grp_videoDetails.Controls.Add(Me.lbl_url)
        Me.grp_videoDetails.Controls.Add(Me.lbl_resume_text)
        Me.grp_videoDetails.Controls.Add(Me.rich_resume)
        Me.grp_videoDetails.Location = New System.Drawing.Point(342, 49)
        Me.grp_videoDetails.Name = "grp_videoDetails"
        Me.grp_videoDetails.Size = New System.Drawing.Size(300, 380)
        Me.grp_videoDetails.TabIndex = 5
        Me.grp_videoDetails.TabStop = False
        Me.grp_videoDetails.Text = "Video Details:"
        '
        'txt_url
        '
        Me.txt_url.Location = New System.Drawing.Point(79, 328)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(215, 23)
        Me.txt_url.TabIndex = 3
        '
        'lbl_url
        '
        Me.lbl_url.AutoSize = True
        Me.lbl_url.Location = New System.Drawing.Point(6, 336)
        Me.lbl_url.Name = "lbl_url"
        Me.lbl_url.Size = New System.Drawing.Size(67, 15)
        Me.lbl_url.TabIndex = 2
        Me.lbl_url.Text = "Poster URL:"
        '
        'lbl_resume_text
        '
        Me.lbl_resume_text.AutoSize = True
        Me.lbl_resume_text.Location = New System.Drawing.Point(6, 28)
        Me.lbl_resume_text.Name = "lbl_resume_text"
        Me.lbl_resume_text.Size = New System.Drawing.Size(85, 15)
        Me.lbl_resume_text.TabIndex = 1
        Me.lbl_resume_text.Text = "Video Resume:"
        '
        'rich_resume
        '
        Me.rich_resume.Location = New System.Drawing.Point(6, 46)
        Me.rich_resume.Name = "rich_resume"
        Me.rich_resume.Size = New System.Drawing.Size(288, 270)
        Me.rich_resume.TabIndex = 0
        Me.rich_resume.Text = ""
        '
        'grp_videoInfo
        '
        Me.grp_videoInfo.Controls.Add(Me.txt_language)
        Me.grp_videoInfo.Controls.Add(Me.lbl_language)
        Me.grp_videoInfo.Controls.Add(Me.txt_director)
        Me.grp_videoInfo.Controls.Add(Me.num_length)
        Me.grp_videoInfo.Controls.Add(Me.txt_country)
        Me.grp_videoInfo.Controls.Add(Me.date_year)
        Me.grp_videoInfo.Controls.Add(Me.txt_genre)
        Me.grp_videoInfo.Controls.Add(Me.txt_title)
        Me.grp_videoInfo.Controls.Add(Me.rich_actors)
        Me.grp_videoInfo.Controls.Add(Me.lbl_actors)
        Me.grp_videoInfo.Controls.Add(Me.lbl_director)
        Me.grp_videoInfo.Controls.Add(Me.lbl_length)
        Me.grp_videoInfo.Controls.Add(Me.lbl_country)
        Me.grp_videoInfo.Controls.Add(Me.lbl_year)
        Me.grp_videoInfo.Controls.Add(Me.lbl_genre)
        Me.grp_videoInfo.Controls.Add(Me.lbl_title)
        Me.grp_videoInfo.Location = New System.Drawing.Point(12, 49)
        Me.grp_videoInfo.Name = "grp_videoInfo"
        Me.grp_videoInfo.Size = New System.Drawing.Size(308, 380)
        Me.grp_videoInfo.TabIndex = 4
        Me.grp_videoInfo.TabStop = False
        Me.grp_videoInfo.Text = "Video Information:"
        '
        'txt_language
        '
        Me.txt_language.Location = New System.Drawing.Point(91, 157)
        Me.txt_language.Name = "txt_language"
        Me.txt_language.Size = New System.Drawing.Size(199, 23)
        Me.txt_language.TabIndex = 15
        '
        'lbl_language
        '
        Me.lbl_language.AutoSize = True
        Me.lbl_language.Location = New System.Drawing.Point(13, 165)
        Me.lbl_language.Name = "lbl_language"
        Me.lbl_language.Size = New System.Drawing.Size(62, 15)
        Me.lbl_language.TabIndex = 14
        Me.lbl_language.Text = "Language:"
        '
        'txt_director
        '
        Me.txt_director.Location = New System.Drawing.Point(91, 230)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(200, 23)
        Me.txt_director.TabIndex = 13
        '
        'num_length
        '
        Me.num_length.Location = New System.Drawing.Point(91, 191)
        Me.num_length.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_length.Name = "num_length"
        Me.num_length.Size = New System.Drawing.Size(199, 23)
        Me.num_length.TabIndex = 12
        Me.num_length.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(91, 123)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(199, 23)
        Me.txt_country.TabIndex = 11
        '
        'date_year
        '
        Me.date_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_year.Location = New System.Drawing.Point(91, 94)
        Me.date_year.Name = "date_year"
        Me.date_year.Size = New System.Drawing.Size(200, 23)
        Me.date_year.TabIndex = 10
        '
        'txt_genre
        '
        Me.txt_genre.Location = New System.Drawing.Point(91, 60)
        Me.txt_genre.Name = "txt_genre"
        Me.txt_genre.Size = New System.Drawing.Size(199, 23)
        Me.txt_genre.TabIndex = 9
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(91, 24)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(199, 23)
        Me.txt_title.TabIndex = 8
        '
        'rich_actors
        '
        Me.rich_actors.Location = New System.Drawing.Point(56, 272)
        Me.rich_actors.Name = "rich_actors"
        Me.rich_actors.Size = New System.Drawing.Size(234, 102)
        Me.rich_actors.TabIndex = 7
        Me.rich_actors.Text = ""
        '
        'lbl_actors
        '
        Me.lbl_actors.AutoSize = True
        Me.lbl_actors.Location = New System.Drawing.Point(6, 313)
        Me.lbl_actors.Name = "lbl_actors"
        Me.lbl_actors.Size = New System.Drawing.Size(44, 15)
        Me.lbl_actors.TabIndex = 6
        Me.lbl_actors.Text = "Actors:"
        '
        'lbl_director
        '
        Me.lbl_director.AutoSize = True
        Me.lbl_director.Location = New System.Drawing.Point(13, 238)
        Me.lbl_director.Name = "lbl_director"
        Me.lbl_director.Size = New System.Drawing.Size(52, 15)
        Me.lbl_director.TabIndex = 5
        Me.lbl_director.Text = "Director:"
        '
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.Location = New System.Drawing.Point(6, 199)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(79, 15)
        Me.lbl_length.TabIndex = 4
        Me.lbl_length.Text = "Length (min):"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Location = New System.Drawing.Point(12, 131)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(53, 15)
        Me.lbl_country.TabIndex = 3
        Me.lbl_country.Text = "Country:"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Location = New System.Drawing.Point(13, 100)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(32, 15)
        Me.lbl_year.TabIndex = 2
        Me.lbl_year.Text = "Year:"
        '
        'lbl_genre
        '
        Me.lbl_genre.AutoSize = True
        Me.lbl_genre.Location = New System.Drawing.Point(13, 68)
        Me.lbl_genre.Name = "lbl_genre"
        Me.lbl_genre.Size = New System.Drawing.Size(41, 15)
        Me.lbl_genre.TabIndex = 1
        Me.lbl_genre.Text = "Genre:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(13, 32)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(32, 15)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Title:"
        '
        'lbl_picker
        '
        Me.lbl_picker.AutoSize = True
        Me.lbl_picker.Location = New System.Drawing.Point(18, 14)
        Me.lbl_picker.Name = "lbl_picker"
        Me.lbl_picker.Size = New System.Drawing.Size(83, 15)
        Me.lbl_picker.TabIndex = 8
        Me.lbl_picker.Text = "Choose Video:"
        '
        'combo_editpicker
        '
        Me.combo_editpicker.FormattingEnabled = True
        Me.combo_editpicker.Location = New System.Drawing.Point(114, 6)
        Me.combo_editpicker.Name = "combo_editpicker"
        Me.combo_editpicker.Size = New System.Drawing.Size(522, 23)
        Me.combo_editpicker.TabIndex = 9
        '
        'EditVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 475)
        Me.Controls.Add(Me.combo_editpicker)
        Me.Controls.Add(Me.lbl_picker)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_editVideo)
        Me.Controls.Add(Me.grp_videoDetails)
        Me.Controls.Add(Me.grp_videoInfo)
        Me.Name = "EditVideo"
        Me.Text = "EditVideo"
        Me.grp_videoDetails.ResumeLayout(False)
        Me.grp_videoDetails.PerformLayout()
        Me.grp_videoInfo.ResumeLayout(False)
        Me.grp_videoInfo.PerformLayout()
        CType(Me.num_length, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_editVideo As Button
    Friend WithEvents grp_videoDetails As GroupBox
    Friend WithEvents txt_url As TextBox
    Friend WithEvents lbl_url As Label
    Friend WithEvents lbl_resume_text As Label
    Friend WithEvents rich_resume As RichTextBox
    Friend WithEvents grp_videoInfo As GroupBox
    Friend WithEvents txt_language As TextBox
    Friend WithEvents lbl_language As Label
    Friend WithEvents txt_director As TextBox
    Friend WithEvents num_length As NumericUpDown
    Friend WithEvents txt_country As TextBox
    Friend WithEvents date_year As DateTimePicker
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents rich_actors As RichTextBox
    Friend WithEvents lbl_actors As Label
    Friend WithEvents lbl_director As Label
    Friend WithEvents lbl_length As Label
    Friend WithEvents lbl_country As Label
    Friend WithEvents lbl_year As Label
    Friend WithEvents lbl_genre As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_picker As Label
    Friend WithEvents combo_editpicker As ComboBox
End Class
