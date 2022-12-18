<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayVideos
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
        Me.lbl_videoslist = New System.Windows.Forms.Label()
        Me.data_videos = New System.Windows.Forms.DataGridView()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.data_videos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_videoslist
        '
        Me.lbl_videoslist.AutoSize = True
        Me.lbl_videoslist.Location = New System.Drawing.Point(7, 4)
        Me.lbl_videoslist.Name = "lbl_videoslist"
        Me.lbl_videoslist.Size = New System.Drawing.Size(80, 15)
        Me.lbl_videoslist.TabIndex = 0
        Me.lbl_videoslist.Text = "List of Videos:"
        '
        'data_videos
        '
        Me.data_videos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_videos.Location = New System.Drawing.Point(12, 22)
        Me.data_videos.Name = "data_videos"
        Me.data_videos.RowTemplate.Height = 25
        Me.data_videos.Size = New System.Drawing.Size(1010, 509)
        Me.data_videos.TabIndex = 1
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(478, 537)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'DisplayVideos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 571)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.data_videos)
        Me.Controls.Add(Me.lbl_videoslist)
        Me.Name = "DisplayVideos"
        Me.Text = "DisplayVideos"
        CType(Me.data_videos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_videoslist As Label
    Friend WithEvents data_videos As DataGridView
    Friend WithEvents btn_close As Button
End Class
