<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayClients
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
        Me.lbl_list = New System.Windows.Forms.Label()
        Me.data_clients = New System.Windows.Forms.DataGridView()
        CType(Me.data_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_list
        '
        Me.lbl_list.AutoSize = True
        Me.lbl_list.Location = New System.Drawing.Point(9, 6)
        Me.lbl_list.Name = "lbl_list"
        Me.lbl_list.Size = New System.Drawing.Size(81, 15)
        Me.lbl_list.TabIndex = 0
        Me.lbl_list.Text = "List of Clients:"
        '
        'data_clients
        '
        Me.data_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_clients.Location = New System.Drawing.Point(13, 25)
        Me.data_clients.Name = "data_clients"
        Me.data_clients.RowTemplate.Height = 25
        Me.data_clients.Size = New System.Drawing.Size(775, 413)
        Me.data_clients.TabIndex = 1
        '
        'DisplayClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.data_clients)
        Me.Controls.Add(Me.lbl_list)
        Me.Name = "DisplayClients"
        Me.Text = "DisplayClients"
        CType(Me.data_clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_list As Label
    Friend WithEvents data_clients As DataGridView
End Class
