﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.btn_AddNewEmployee = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_view_clients = New System.Windows.Forms.Button()
        Me.btn_newclient = New System.Windows.Forms.Button()
        Me.btn_editclient = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Location = New System.Drawing.Point(208, 173)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(75, 23)
        Me.btn_dashboard.TabIndex = 0
        Me.btn_dashboard.Text = "dashboard"
        Me.btn_dashboard.UseVisualStyleBackColor = True
        '
        'btn_AddNewEmployee
        '
        Me.btn_AddNewEmployee.Location = New System.Drawing.Point(191, 240)
        Me.btn_AddNewEmployee.Name = "btn_AddNewEmployee"
        Me.btn_AddNewEmployee.Size = New System.Drawing.Size(92, 41)
        Me.btn_AddNewEmployee.TabIndex = 1
        Me.btn_AddNewEmployee.Text = "Add New"
        Me.btn_AddNewEmployee.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(206, 315)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(105, 49)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.Text = "edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(385, 328)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_view_clients
        '
        Me.btn_view_clients.Location = New System.Drawing.Point(434, 136)
        Me.btn_view_clients.Name = "btn_view_clients"
        Me.btn_view_clients.Size = New System.Drawing.Size(138, 23)
        Me.btn_view_clients.TabIndex = 4
        Me.btn_view_clients.Text = "View Clients"
        Me.btn_view_clients.UseVisualStyleBackColor = True
        '
        'btn_newclient
        '
        Me.btn_newclient.Location = New System.Drawing.Point(461, 186)
        Me.btn_newclient.Name = "btn_newclient"
        Me.btn_newclient.Size = New System.Drawing.Size(193, 23)
        Me.btn_newclient.TabIndex = 5
        Me.btn_newclient.Text = "Add New Client"
        Me.btn_newclient.UseVisualStyleBackColor = True
        '
        'btn_editclient
        '
        Me.btn_editclient.Location = New System.Drawing.Point(478, 226)
        Me.btn_editclient.Name = "btn_editclient"
        Me.btn_editclient.Size = New System.Drawing.Size(75, 23)
        Me.btn_editclient.TabIndex = 6
        Me.btn_editclient.Text = "Edit Client"
        Me.btn_editclient.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_editclient)
        Me.Controls.Add(Me.btn_view_clients)
        Me.Controls.Add(Me.btn_newclient)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_AddNewEmployee)
        Me.Controls.Add(Me.btn_dashboard)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_dashboard As Button
    Friend WithEvents btn_AddNewEmployee As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_view_clients As Button
    Friend WithEvents btn_newclient As Button
    Friend WithEvents btn_editclient As Button
End Class
