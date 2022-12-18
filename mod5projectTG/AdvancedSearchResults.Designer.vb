<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdvancedSearchResults
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedSearchResults))
        Me.lbl_searchResults = New System.Windows.Forms.Label()
        Me.data_advancedResults = New System.Windows.Forms.DataGridView()
        Me.btn_rent = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.data_advancedResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_searchResults
        '
        Me.lbl_searchResults.AutoSize = True
        Me.lbl_searchResults.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_searchResults.ForeColor = System.Drawing.Color.LightCoral
        Me.lbl_searchResults.Location = New System.Drawing.Point(12, 9)
        Me.lbl_searchResults.Name = "lbl_searchResults"
        Me.lbl_searchResults.Size = New System.Drawing.Size(304, 32)
        Me.lbl_searchResults.TabIndex = 0
        Me.lbl_searchResults.Text = "Advanced Search Results:"
        '
        'data_advancedResults
        '
        Me.data_advancedResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_advancedResults.Location = New System.Drawing.Point(12, 52)
        Me.data_advancedResults.Name = "data_advancedResults"
        Me.data_advancedResults.RowTemplate.Height = 25
        Me.data_advancedResults.Size = New System.Drawing.Size(1025, 244)
        Me.data_advancedResults.TabIndex = 1
        '
        'btn_rent
        '
        Me.btn_rent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_rent.Enabled = False
        Me.btn_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_rent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_rent.Location = New System.Drawing.Point(871, 302)
        Me.btn_rent.Name = "btn_rent"
        Me.btn_rent.Size = New System.Drawing.Size(75, 34)
        Me.btn_rent.TabIndex = 2
        Me.btn_rent.Text = "Rent"
        Me.btn_rent.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Maroon
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_close.Location = New System.Drawing.Point(962, 302)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 34)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'AdvancedSearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1049, 343)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_rent)
        Me.Controls.Add(Me.data_advancedResults)
        Me.Controls.Add(Me.lbl_searchResults)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdvancedSearchResults"
        Me.Text = "Advanced Search Results"
        CType(Me.data_advancedResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_searchResults As Label
    Friend WithEvents data_advancedResults As DataGridView
    Friend WithEvents btn_rent As Button
    Friend WithEvents btn_close As Button
End Class
