<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedSearchResults
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
        Me.lbl_searchResults.Location = New System.Drawing.Point(12, 9)
        Me.lbl_searchResults.Name = "lbl_searchResults"
        Me.lbl_searchResults.Size = New System.Drawing.Size(141, 15)
        Me.lbl_searchResults.TabIndex = 0
        Me.lbl_searchResults.Text = "Advanced Search Results:"
        '
        'data_advancedResults
        '
        Me.data_advancedResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_advancedResults.Location = New System.Drawing.Point(12, 38)
        Me.data_advancedResults.Name = "data_advancedResults"
        Me.data_advancedResults.RowTemplate.Height = 25
        Me.data_advancedResults.Size = New System.Drawing.Size(776, 188)
        Me.data_advancedResults.TabIndex = 1
        '
        'btn_rent
        '
        Me.btn_rent.Location = New System.Drawing.Point(622, 238)
        Me.btn_rent.Name = "btn_rent"
        Me.btn_rent.Size = New System.Drawing.Size(75, 23)
        Me.btn_rent.TabIndex = 2
        Me.btn_rent.Text = "Rent"
        Me.btn_rent.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(713, 238)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'AdvancedSearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 273)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_rent)
        Me.Controls.Add(Me.data_advancedResults)
        Me.Controls.Add(Me.lbl_searchResults)
        Me.Name = "AdvancedSearchResults"
        Me.Text = "AdvancedSearchResults"
        CType(Me.data_advancedResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_searchResults As Label
    Friend WithEvents data_advancedResults As DataGridView
    Friend WithEvents btn_rent As Button
    Friend WithEvents btn_close As Button
End Class
