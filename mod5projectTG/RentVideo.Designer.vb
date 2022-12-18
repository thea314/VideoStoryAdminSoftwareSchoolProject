<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentVideo))
        Me.grp_video = New System.Windows.Forms.GroupBox()
        Me.rich_resume = New System.Windows.Forms.RichTextBox()
        Me.txt_director = New System.Windows.Forms.TextBox()
        Me.txt_language = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.combo_videoid = New System.Windows.Forms.ComboBox()
        Me.lbl_resume = New System.Windows.Forms.Label()
        Me.lbl_director = New System.Windows.Forms.Label()
        Me.lbl_language = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_videoid = New System.Windows.Forms.Label()
        Me.pic_poster = New System.Windows.Forms.PictureBox()
        Me.grp_client = New System.Windows.Forms.GroupBox()
        Me.lbl_client = New System.Windows.Forms.Label()
        Me.combo_clientid = New System.Windows.Forms.ComboBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.btn_rent = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.lbl_rentvideo = New System.Windows.Forms.Label()
        Me.grp_video.SuspendLayout()
        CType(Me.pic_poster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_client.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_video
        '
        Me.grp_video.Controls.Add(Me.rich_resume)
        Me.grp_video.Controls.Add(Me.txt_director)
        Me.grp_video.Controls.Add(Me.txt_language)
        Me.grp_video.Controls.Add(Me.txt_title)
        Me.grp_video.Controls.Add(Me.combo_videoid)
        Me.grp_video.Controls.Add(Me.lbl_resume)
        Me.grp_video.Controls.Add(Me.lbl_director)
        Me.grp_video.Controls.Add(Me.lbl_language)
        Me.grp_video.Controls.Add(Me.lbl_title)
        Me.grp_video.Controls.Add(Me.lbl_videoid)
        Me.grp_video.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_video.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_video.Location = New System.Drawing.Point(12, 249)
        Me.grp_video.Name = "grp_video"
        Me.grp_video.Size = New System.Drawing.Size(408, 250)
        Me.grp_video.TabIndex = 0
        Me.grp_video.TabStop = False
        Me.grp_video.Text = "Video Information:"
        '
        'rich_resume
        '
        Me.rich_resume.Enabled = False
        Me.rich_resume.Location = New System.Drawing.Point(82, 162)
        Me.rich_resume.Name = "rich_resume"
        Me.rich_resume.Size = New System.Drawing.Size(320, 71)
        Me.rich_resume.TabIndex = 9
        Me.rich_resume.Text = ""
        '
        'txt_director
        '
        Me.txt_director.Enabled = False
        Me.txt_director.Location = New System.Drawing.Point(82, 133)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(320, 25)
        Me.txt_director.TabIndex = 8
        '
        'txt_language
        '
        Me.txt_language.Enabled = False
        Me.txt_language.Location = New System.Drawing.Point(82, 96)
        Me.txt_language.Name = "txt_language"
        Me.txt_language.Size = New System.Drawing.Size(320, 25)
        Me.txt_language.TabIndex = 7
        '
        'txt_title
        '
        Me.txt_title.Enabled = False
        Me.txt_title.Location = New System.Drawing.Point(82, 60)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(320, 25)
        Me.txt_title.TabIndex = 6
        '
        'combo_videoid
        '
        Me.combo_videoid.FormattingEnabled = True
        Me.combo_videoid.Location = New System.Drawing.Point(82, 26)
        Me.combo_videoid.Name = "combo_videoid"
        Me.combo_videoid.Size = New System.Drawing.Size(320, 25)
        Me.combo_videoid.TabIndex = 5
        '
        'lbl_resume
        '
        Me.lbl_resume.AutoSize = True
        Me.lbl_resume.Location = New System.Drawing.Point(6, 178)
        Me.lbl_resume.Name = "lbl_resume"
        Me.lbl_resume.Size = New System.Drawing.Size(59, 17)
        Me.lbl_resume.TabIndex = 4
        Me.lbl_resume.Text = "Resume:"
        '
        'lbl_director
        '
        Me.lbl_director.AutoSize = True
        Me.lbl_director.Location = New System.Drawing.Point(6, 141)
        Me.lbl_director.Name = "lbl_director"
        Me.lbl_director.Size = New System.Drawing.Size(60, 17)
        Me.lbl_director.TabIndex = 3
        Me.lbl_director.Text = "Director:"
        '
        'lbl_language
        '
        Me.lbl_language.AutoSize = True
        Me.lbl_language.Location = New System.Drawing.Point(6, 104)
        Me.lbl_language.Name = "lbl_language"
        Me.lbl_language.Size = New System.Drawing.Size(70, 17)
        Me.lbl_language.TabIndex = 2
        Me.lbl_language.Text = "Language:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(6, 68)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(36, 17)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Title:"
        '
        'lbl_videoid
        '
        Me.lbl_videoid.AutoSize = True
        Me.lbl_videoid.Location = New System.Drawing.Point(6, 34)
        Me.lbl_videoid.Name = "lbl_videoid"
        Me.lbl_videoid.Size = New System.Drawing.Size(58, 17)
        Me.lbl_videoid.TabIndex = 0
        Me.lbl_videoid.Text = "VideoID:"
        '
        'pic_poster
        '
        Me.pic_poster.Location = New System.Drawing.Point(436, 93)
        Me.pic_poster.Name = "pic_poster"
        Me.pic_poster.Size = New System.Drawing.Size(265, 321)
        Me.pic_poster.TabIndex = 1
        Me.pic_poster.TabStop = False
        '
        'grp_client
        '
        Me.grp_client.Controls.Add(Me.lbl_client)
        Me.grp_client.Controls.Add(Me.combo_clientid)
        Me.grp_client.Controls.Add(Me.txt_phone)
        Me.grp_client.Controls.Add(Me.txt_address)
        Me.grp_client.Controls.Add(Me.txt_name)
        Me.grp_client.Controls.Add(Me.lbl_phone)
        Me.grp_client.Controls.Add(Me.lbl_address)
        Me.grp_client.Controls.Add(Me.lbl_name)
        Me.grp_client.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_client.Location = New System.Drawing.Point(12, 71)
        Me.grp_client.Name = "grp_client"
        Me.grp_client.Size = New System.Drawing.Size(408, 161)
        Me.grp_client.TabIndex = 2
        Me.grp_client.TabStop = False
        Me.grp_client.Text = "Client Information:"
        '
        'lbl_client
        '
        Me.lbl_client.AutoSize = True
        Me.lbl_client.Location = New System.Drawing.Point(6, 30)
        Me.lbl_client.Name = "lbl_client"
        Me.lbl_client.Size = New System.Drawing.Size(58, 17)
        Me.lbl_client.TabIndex = 8
        Me.lbl_client.Text = "ClientID:"
        '
        'combo_clientid
        '
        Me.combo_clientid.FormattingEnabled = True
        Me.combo_clientid.Location = New System.Drawing.Point(82, 22)
        Me.combo_clientid.Name = "combo_clientid"
        Me.combo_clientid.Size = New System.Drawing.Size(320, 25)
        Me.combo_clientid.TabIndex = 7
        '
        'txt_phone
        '
        Me.txt_phone.Enabled = False
        Me.txt_phone.Location = New System.Drawing.Point(82, 123)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(320, 25)
        Me.txt_phone.TabIndex = 6
        '
        'txt_address
        '
        Me.txt_address.Enabled = False
        Me.txt_address.Location = New System.Drawing.Point(82, 88)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(320, 25)
        Me.txt_address.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Enabled = False
        Me.txt_name.Location = New System.Drawing.Point(82, 58)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(320, 25)
        Me.txt_name.TabIndex = 4
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Location = New System.Drawing.Point(6, 131)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(73, 17)
        Me.lbl_phone.TabIndex = 3
        Me.lbl_phone.Text = "Telephone:"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Location = New System.Drawing.Point(6, 96)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(60, 17)
        Me.lbl_address.TabIndex = 2
        Me.lbl_address.Text = "Address:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(6, 66)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(47, 17)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Name:"
        '
        'btn_rent
        '
        Me.btn_rent.BackColor = System.Drawing.Color.Navy
        Me.btn_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_rent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_rent.Location = New System.Drawing.Point(530, 508)
        Me.btn_rent.Name = "btn_rent"
        Me.btn_rent.Size = New System.Drawing.Size(75, 28)
        Me.btn_rent.TabIndex = 3
        Me.btn_rent.Text = "Rent"
        Me.btn_rent.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Maroon
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_close.Location = New System.Drawing.Point(626, 508)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 28)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_status.Location = New System.Drawing.Point(473, 457)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(49, 17)
        Me.lbl_status.TabIndex = 5
        Me.lbl_status.Text = "Status:"
        '
        'txt_status
        '
        Me.txt_status.Enabled = False
        Me.txt_status.Location = New System.Drawing.Point(530, 449)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(128, 23)
        Me.txt_status.TabIndex = 6
        '
        'lbl_rentvideo
        '
        Me.lbl_rentvideo.AutoSize = True
        Me.lbl_rentvideo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_rentvideo.ForeColor = System.Drawing.Color.LightCoral
        Me.lbl_rentvideo.Location = New System.Drawing.Point(12, 19)
        Me.lbl_rentvideo.Name = "lbl_rentvideo"
        Me.lbl_rentvideo.Size = New System.Drawing.Size(146, 32)
        Me.lbl_rentvideo.TabIndex = 7
        Me.lbl_rentvideo.Text = "Rent Video:"
        '
        'RentVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(713, 548)
        Me.Controls.Add(Me.lbl_rentvideo)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_rent)
        Me.Controls.Add(Me.grp_client)
        Me.Controls.Add(Me.pic_poster)
        Me.Controls.Add(Me.grp_video)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RentVideo"
        Me.Text = "Rent Video"
        Me.grp_video.ResumeLayout(False)
        Me.grp_video.PerformLayout()
        CType(Me.pic_poster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_client.ResumeLayout(False)
        Me.grp_client.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_video As GroupBox
    Friend WithEvents pic_poster As PictureBox
    Friend WithEvents grp_client As GroupBox
    Friend WithEvents lbl_client As Label
    Friend WithEvents combo_clientid As ComboBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_phone As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents btn_rent As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents lbl_resume As Label
    Friend WithEvents lbl_director As Label
    Friend WithEvents lbl_language As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_videoid As Label
    Friend WithEvents rich_resume As RichTextBox
    Friend WithEvents txt_director As TextBox
    Friend WithEvents txt_language As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents combo_videoid As ComboBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents lbl_rentvideo As Label
End Class
