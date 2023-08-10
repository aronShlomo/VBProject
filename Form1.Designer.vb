<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        TextBox1_username = New TextBox()
        TextBox2_password = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(318, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 32)
        Label1.TabIndex = 0
        Label1.Text = "Sign In"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(92, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 32)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(92, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 32)
        Label3.TabIndex = 2
        Label3.Text = "User Name:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(270, 353)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 59)
        Button1.TabIndex = 3
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1_username
        ' 
        TextBox1_username.Location = New Point(292, 150)
        TextBox1_username.Multiline = True
        TextBox1_username.Name = "TextBox1_username"
        TextBox1_username.Size = New Size(232, 31)
        TextBox1_username.TabIndex = 4
        ' 
        ' TextBox2_password
        ' 
        TextBox2_password.Location = New Point(292, 251)
        TextBox2_password.Multiline = True
        TextBox2_password.Name = "TextBox2_password"
        TextBox2_password.PasswordChar = "*"c
        TextBox2_password.Size = New Size(232, 31)
        TextBox2_password.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(742, 449)
        Controls.Add(TextBox2_password)
        Controls.Add(TextBox1_username)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1_username As TextBox
    Friend WithEvents TextBox2_password As TextBox
End Class
