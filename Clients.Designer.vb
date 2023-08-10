<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button3_add = New Button()
        Button1_edit = New Button()
        Button2_delete = New Button()
        TextBox1_id = New TextBox()
        TextBox2_first_name = New TextBox()
        TextBox3_lastname = New TextBox()
        TextBox4_address = New TextBox()
        TextBox5_email = New TextBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(487, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 38)
        Label1.TabIndex = 1
        Label1.Text = "Client Page"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(40, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 38)
        Label2.TabIndex = 2
        Label2.Text = "ID:"
        Label2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(40, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 38)
        Label3.TabIndex = 3
        Label3.Text = "First Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(40, 281)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 38)
        Label4.TabIndex = 4
        Label4.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(40, 339)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 38)
        Label5.TabIndex = 5
        Label5.Text = "Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(40, 394)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 38)
        Label6.TabIndex = 6
        Label6.Text = "Email:"
        ' 
        ' Button3_add
        ' 
        Button3_add.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button3_add.Location = New Point(220, 509)
        Button3_add.Name = "Button3_add"
        Button3_add.Size = New Size(684, 55)
        Button3_add.TabIndex = 7
        Button3_add.Text = "Add"
        Button3_add.UseVisualStyleBackColor = True
        ' 
        ' Button1_edit
        ' 
        Button1_edit.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1_edit.Location = New Point(220, 558)
        Button1_edit.Name = "Button1_edit"
        Button1_edit.Size = New Size(684, 58)
        Button1_edit.TabIndex = 8
        Button1_edit.Text = "Edit"
        Button1_edit.UseVisualStyleBackColor = True
        ' 
        ' Button2_delete
        ' 
        Button2_delete.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button2_delete.Location = New Point(220, 614)
        Button2_delete.Name = "Button2_delete"
        Button2_delete.Size = New Size(684, 54)
        Button2_delete.TabIndex = 9
        Button2_delete.Text = "Delete"
        Button2_delete.UseVisualStyleBackColor = True
        ' 
        ' TextBox1_id
        ' 
        TextBox1_id.Location = New Point(257, 164)
        TextBox1_id.Multiline = True
        TextBox1_id.Name = "TextBox1_id"
        TextBox1_id.Size = New Size(226, 40)
        TextBox1_id.TabIndex = 10
        TextBox1_id.Visible = False
        ' 
        ' TextBox2_first_name
        ' 
        TextBox2_first_name.Location = New Point(257, 222)
        TextBox2_first_name.Multiline = True
        TextBox2_first_name.Name = "TextBox2_first_name"
        TextBox2_first_name.Size = New Size(226, 40)
        TextBox2_first_name.TabIndex = 11
        ' 
        ' TextBox3_lastname
        ' 
        TextBox3_lastname.Location = New Point(257, 279)
        TextBox3_lastname.Multiline = True
        TextBox3_lastname.Name = "TextBox3_lastname"
        TextBox3_lastname.Size = New Size(226, 40)
        TextBox3_lastname.TabIndex = 12
        ' 
        ' TextBox4_address
        ' 
        TextBox4_address.Location = New Point(257, 337)
        TextBox4_address.Multiline = True
        TextBox4_address.Name = "TextBox4_address"
        TextBox4_address.Size = New Size(226, 40)
        TextBox4_address.TabIndex = 13
        ' 
        ' TextBox5_email
        ' 
        TextBox5_email.Location = New Point(257, 394)
        TextBox5_email.Multiline = True
        TextBox5_email.Name = "TextBox5_email"
        TextBox5_email.Size = New Size(226, 40)
        TextBox5_email.TabIndex = 14
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ActiveBorder
        DataGridView1.Location = New Point(561, 147)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(636, 315)
        DataGridView1.TabIndex = 15
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 41)
        Button1.TabIndex = 16
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Clients
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1220, 686)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox5_email)
        Controls.Add(TextBox4_address)
        Controls.Add(TextBox3_lastname)
        Controls.Add(TextBox2_first_name)
        Controls.Add(TextBox1_id)
        Controls.Add(Button2_delete)
        Controls.Add(Button1_edit)
        Controls.Add(Button3_add)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Clients"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Clients"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3_add As Button
    Friend WithEvents Button1_edit As Button
    Friend WithEvents Button2_delete As Button
    Friend WithEvents TextBox1_id As TextBox
    Friend WithEvents TextBox2_first_name As TextBox
    Friend WithEvents TextBox3_lastname As TextBox
    Friend WithEvents TextBox4_address As TextBox
    Friend WithEvents TextBox5_email As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
