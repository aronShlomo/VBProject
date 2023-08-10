<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Label1 = New Label()
        Button1_reser = New Button()
        Button2_rooms = New Button()
        Button3_clients = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(397, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 38)
        Label1.TabIndex = 0
        Label1.Text = "Hotel Manager"
        ' 
        ' Button1_reser
        ' 
        Button1_reser.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1_reser.Location = New Point(208, 171)
        Button1_reser.Name = "Button1_reser"
        Button1_reser.Size = New Size(605, 84)
        Button1_reser.TabIndex = 1
        Button1_reser.Text = "Reservation"
        Button1_reser.UseVisualStyleBackColor = True
        ' 
        ' Button2_rooms
        ' 
        Button2_rooms.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button2_rooms.Location = New Point(208, 288)
        Button2_rooms.Name = "Button2_rooms"
        Button2_rooms.Size = New Size(605, 84)
        Button2_rooms.TabIndex = 2
        Button2_rooms.Text = "Rooms"
        Button2_rooms.UseVisualStyleBackColor = True
        ' 
        ' Button3_clients
        ' 
        Button3_clients.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button3_clients.Location = New Point(208, 407)
        Button3_clients.Name = "Button3_clients"
        Button3_clients.Size = New Size(605, 84)
        Button3_clients.TabIndex = 3
        Button3_clients.Text = "Clients"
        Button3_clients.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(929, 536)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 4
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1081, 598)
        Controls.Add(Button1)
        Controls.Add(Button3_clients)
        Controls.Add(Button2_rooms)
        Controls.Add(Button1_reser)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1_reser As Button
    Friend WithEvents Button2_rooms As Button
    Friend WithEvents Button3_clients As Button
    Friend WithEvents Button1 As Button
End Class
