<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnVideo))
        Me.grp_return = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.pic_poster = New System.Windows.Forms.PictureBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_rentedOn = New System.Windows.Forms.TextBox()
        Me.txt_clientName = New System.Windows.Forms.TextBox()
        Me.txt_clientNo = New System.Windows.Forms.TextBox()
        Me.lbl_renteddate = New System.Windows.Forms.Label()
        Me.lbl_clientNo = New System.Windows.Forms.Label()
        Me.lbl_clientName = New System.Windows.Forms.Label()
        Me.txt_videoid = New System.Windows.Forms.TextBox()
        Me.lvl_videoid = New System.Windows.Forms.Label()
        Me.data_videosout = New System.Windows.Forms.DataGridView()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_returnvideo = New System.Windows.Forms.Label()
        Me.grp_return.SuspendLayout()
        CType(Me.pic_poster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_videosout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_return
        '
        Me.grp_return.Controls.Add(Me.btn_clear)
        Me.grp_return.Controls.Add(Me.pic_poster)
        Me.grp_return.Controls.Add(Me.btn_search)
        Me.grp_return.Controls.Add(Me.txt_rentedOn)
        Me.grp_return.Controls.Add(Me.txt_clientName)
        Me.grp_return.Controls.Add(Me.txt_clientNo)
        Me.grp_return.Controls.Add(Me.lbl_renteddate)
        Me.grp_return.Controls.Add(Me.lbl_clientNo)
        Me.grp_return.Controls.Add(Me.lbl_clientName)
        Me.grp_return.Controls.Add(Me.txt_videoid)
        Me.grp_return.Controls.Add(Me.lvl_videoid)
        Me.grp_return.Controls.Add(Me.data_videosout)
        Me.grp_return.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grp_return.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_return.Location = New System.Drawing.Point(12, 54)
        Me.grp_return.Name = "grp_return"
        Me.grp_return.Size = New System.Drawing.Size(521, 383)
        Me.grp_return.TabIndex = 1
        Me.grp_return.TabStop = False
        Me.grp_return.Text = "Return Video"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Navy
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Location = New System.Drawing.Point(401, 29)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(83, 29)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "Clear Selection"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'pic_poster
        '
        Me.pic_poster.Location = New System.Drawing.Point(401, 238)
        Me.pic_poster.Name = "pic_poster"
        Me.pic_poster.Size = New System.Drawing.Size(114, 139)
        Me.pic_poster.TabIndex = 10
        Me.pic_poster.TabStop = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Green
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Location = New System.Drawing.Point(313, 29)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 29)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_rentedOn
        '
        Me.txt_rentedOn.Enabled = False
        Me.txt_rentedOn.Location = New System.Drawing.Point(112, 328)
        Me.txt_rentedOn.Name = "txt_rentedOn"
        Me.txt_rentedOn.Size = New System.Drawing.Size(200, 25)
        Me.txt_rentedOn.TabIndex = 8
        '
        'txt_clientName
        '
        Me.txt_clientName.Enabled = False
        Me.txt_clientName.Location = New System.Drawing.Point(112, 293)
        Me.txt_clientName.Name = "txt_clientName"
        Me.txt_clientName.Size = New System.Drawing.Size(200, 25)
        Me.txt_clientName.TabIndex = 7
        '
        'txt_clientNo
        '
        Me.txt_clientNo.Enabled = False
        Me.txt_clientNo.Location = New System.Drawing.Point(112, 255)
        Me.txt_clientNo.Name = "txt_clientNo"
        Me.txt_clientNo.Size = New System.Drawing.Size(200, 25)
        Me.txt_clientNo.TabIndex = 6
        '
        'lbl_renteddate
        '
        Me.lbl_renteddate.AutoSize = True
        Me.lbl_renteddate.Location = New System.Drawing.Point(6, 336)
        Me.lbl_renteddate.Name = "lbl_renteddate"
        Me.lbl_renteddate.Size = New System.Drawing.Size(76, 17)
        Me.lbl_renteddate.TabIndex = 5
        Me.lbl_renteddate.Text = "Rented On:"
        '
        'lbl_clientNo
        '
        Me.lbl_clientNo.AutoSize = True
        Me.lbl_clientNo.Location = New System.Drawing.Point(6, 263)
        Me.lbl_clientNo.Name = "lbl_clientNo"
        Me.lbl_clientNo.Size = New System.Drawing.Size(100, 17)
        Me.lbl_clientNo.TabIndex = 4
        Me.lbl_clientNo.Text = "Client Number:"
        '
        'lbl_clientName
        '
        Me.lbl_clientName.AutoSize = True
        Me.lbl_clientName.Location = New System.Drawing.Point(6, 301)
        Me.lbl_clientName.Name = "lbl_clientName"
        Me.lbl_clientName.Size = New System.Drawing.Size(85, 17)
        Me.lbl_clientName.TabIndex = 3
        Me.lbl_clientName.Text = "Client Name:"
        '
        'txt_videoid
        '
        Me.txt_videoid.Location = New System.Drawing.Point(74, 29)
        Me.txt_videoid.Name = "txt_videoid"
        Me.txt_videoid.Size = New System.Drawing.Size(226, 25)
        Me.txt_videoid.TabIndex = 2
        '
        'lvl_videoid
        '
        Me.lvl_videoid.AutoSize = True
        Me.lvl_videoid.Location = New System.Drawing.Point(6, 37)
        Me.lvl_videoid.Name = "lvl_videoid"
        Me.lvl_videoid.Size = New System.Drawing.Size(61, 17)
        Me.lvl_videoid.TabIndex = 1
        Me.lvl_videoid.Text = "Video Id:"
        '
        'data_videosout
        '
        Me.data_videosout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_videosout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_videosout.Location = New System.Drawing.Point(6, 69)
        Me.data_videosout.MultiSelect = False
        Me.data_videosout.Name = "data_videosout"
        Me.data_videosout.RowTemplate.Height = 25
        Me.data_videosout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_videosout.Size = New System.Drawing.Size(509, 163)
        Me.data_videosout.TabIndex = 0
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.Teal
        Me.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_return.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_return.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_return.Location = New System.Drawing.Point(205, 443)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(75, 34)
        Me.btn_return.TabIndex = 2
        Me.btn_return.Text = "Return"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Maroon
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancel.Location = New System.Drawing.Point(297, 443)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 34)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'lbl_returnvideo
        '
        Me.lbl_returnvideo.AutoSize = True
        Me.lbl_returnvideo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_returnvideo.ForeColor = System.Drawing.Color.LightCoral
        Me.lbl_returnvideo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_returnvideo.Name = "lbl_returnvideo"
        Me.lbl_returnvideo.Size = New System.Drawing.Size(171, 32)
        Me.lbl_returnvideo.TabIndex = 4
        Me.lbl_returnvideo.Text = "Return Video:"
        '
        'ReturnVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(546, 485)
        Me.Controls.Add(Me.lbl_returnvideo)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.grp_return)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReturnVideo"
        Me.Text = "Return Video"
        Me.grp_return.ResumeLayout(False)
        Me.grp_return.PerformLayout()
        CType(Me.pic_poster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_videosout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_return As GroupBox
    Friend WithEvents lbl_renteddate As Label
    Friend WithEvents lbl_clientNo As Label
    Friend WithEvents lbl_clientName As Label
    Friend WithEvents txt_videoid As TextBox
    Friend WithEvents lvl_videoid As Label
    Friend WithEvents data_videosout As DataGridView
    Friend WithEvents txt_rentedOn As TextBox
    Friend WithEvents txt_clientName As TextBox
    Friend WithEvents txt_clientNo As TextBox
    Friend WithEvents pic_poster As PictureBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents lbl_returnvideo As Label
End Class
