<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewVideo
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
        Me.grp_videoInfo = New System.Windows.Forms.GroupBox()
        Me.grp_videoDetails = New System.Windows.Forms.GroupBox()
        Me.rich_resume = New System.Windows.Forms.RichTextBox()
        Me.lbl_resume_text = New System.Windows.Forms.Label()
        Me.lbl_url = New System.Windows.Forms.Label()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.btn_addNewVideo = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.grp_videoDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_videoInfo
        '
        Me.grp_videoInfo.Location = New System.Drawing.Point(12, 12)
        Me.grp_videoInfo.Name = "grp_videoInfo"
        Me.grp_videoInfo.Size = New System.Drawing.Size(308, 380)
        Me.grp_videoInfo.TabIndex = 0
        Me.grp_videoInfo.TabStop = False
        Me.grp_videoInfo.Text = "Video Information:"
        '
        'grp_videoDetails
        '
        Me.grp_videoDetails.Controls.Add(Me.txt_url)
        Me.grp_videoDetails.Controls.Add(Me.lbl_url)
        Me.grp_videoDetails.Controls.Add(Me.lbl_resume_text)
        Me.grp_videoDetails.Controls.Add(Me.rich_resume)
        Me.grp_videoDetails.Location = New System.Drawing.Point(342, 12)
        Me.grp_videoDetails.Name = "grp_videoDetails"
        Me.grp_videoDetails.Size = New System.Drawing.Size(300, 380)
        Me.grp_videoDetails.TabIndex = 1
        Me.grp_videoDetails.TabStop = False
        Me.grp_videoDetails.Text = "Video Details:"
        '
        'rich_resume
        '
        Me.rich_resume.Location = New System.Drawing.Point(6, 46)
        Me.rich_resume.Name = "rich_resume"
        Me.rich_resume.Size = New System.Drawing.Size(288, 270)
        Me.rich_resume.TabIndex = 0
        Me.rich_resume.Text = ""
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
        'lbl_url
        '
        Me.lbl_url.AutoSize = True
        Me.lbl_url.Location = New System.Drawing.Point(6, 336)
        Me.lbl_url.Name = "lbl_url"
        Me.lbl_url.Size = New System.Drawing.Size(67, 15)
        Me.lbl_url.TabIndex = 2
        Me.lbl_url.Text = "Poster URL:"
        '
        'txt_url
        '
        Me.txt_url.Location = New System.Drawing.Point(79, 328)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(215, 23)
        Me.txt_url.TabIndex = 3
        '
        'btn_addNewVideo
        '
        Me.btn_addNewVideo.Location = New System.Drawing.Point(245, 403)
        Me.btn_addNewVideo.Name = "btn_addNewVideo"
        Me.btn_addNewVideo.Size = New System.Drawing.Size(75, 23)
        Me.btn_addNewVideo.TabIndex = 2
        Me.btn_addNewVideo.Text = "Add Video"
        Me.btn_addNewVideo.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(340, 403)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'AddNewVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 438)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_addNewVideo)
        Me.Controls.Add(Me.grp_videoDetails)
        Me.Controls.Add(Me.grp_videoInfo)
        Me.Name = "AddNewVideo"
        Me.Text = "AddNewVideo"
        Me.grp_videoDetails.ResumeLayout(False)
        Me.grp_videoDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_videoInfo As GroupBox
    Friend WithEvents grp_videoDetails As GroupBox
    Friend WithEvents txt_url As TextBox
    Friend WithEvents lbl_url As Label
    Friend WithEvents lbl_resume_text As Label
    Friend WithEvents rich_resume As RichTextBox
    Friend WithEvents btn_addNewVideo As Button
    Friend WithEvents btn_cancel As Button
End Class
