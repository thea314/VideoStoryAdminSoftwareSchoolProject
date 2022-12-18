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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayVideos))
        Me.lbl_videoslist = New System.Windows.Forms.Label()
        Me.data_videos = New System.Windows.Forms.DataGridView()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.data_videos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_videoslist
        '
        Me.lbl_videoslist.AutoSize = True
        Me.lbl_videoslist.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_videoslist.ForeColor = System.Drawing.Color.LightCoral
        Me.lbl_videoslist.Location = New System.Drawing.Point(12, 9)
        Me.lbl_videoslist.Name = "lbl_videoslist"
        Me.lbl_videoslist.Size = New System.Drawing.Size(175, 32)
        Me.lbl_videoslist.TabIndex = 0
        Me.lbl_videoslist.Text = "List of Videos:"
        '
        'data_videos
        '
        Me.data_videos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_videos.Location = New System.Drawing.Point(12, 44)
        Me.data_videos.Name = "data_videos"
        Me.data_videos.RowTemplate.Height = 25
        Me.data_videos.Size = New System.Drawing.Size(1010, 478)
        Me.data_videos.TabIndex = 1
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Maroon
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_close.Location = New System.Drawing.Point(478, 528)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 32)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'DisplayVideos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1034, 571)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.data_videos)
        Me.Controls.Add(Me.lbl_videoslist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DisplayVideos"
        Me.Text = "Display Videos"
        CType(Me.data_videos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_videoslist As Label
    Friend WithEvents data_videos As DataGridView
    Friend WithEvents btn_close As Button
End Class
