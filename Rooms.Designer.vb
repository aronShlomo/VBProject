<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rooms
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
        DataGridView1_room = New DataGridView()
        TextBox3_roomnumber = New TextBox()
        TextBox2_first_name = New TextBox()
        Button2_delete = New Button()
        Button1_edit = New Button()
        Button3_add = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        ComboBox1_type = New ComboBox()
        Label2 = New Label()
        ComboBox2_reserve = New ComboBox()
        Button1 = New Button()
        TextBox1_id = New TextBox()
        Label6 = New Label()
        CType(DataGridView1_room, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1_room
        ' 
        DataGridView1_room.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1_room.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1_room.GridColor = SystemColors.ActiveBorder
        DataGridView1_room.Location = New Point(532, 122)
        DataGridView1_room.Name = "DataGridView1_room"
        DataGridView1_room.RowHeadersWidth = 62
        DataGridView1_room.RowTemplate.Height = 33
        DataGridView1_room.Size = New Size(497, 457)
        DataGridView1_room.TabIndex = 30
        ' 
        ' TextBox3_roomnumber
        ' 
        TextBox3_roomnumber.Location = New Point(254, 239)
        TextBox3_roomnumber.Multiline = True
        TextBox3_roomnumber.Name = "TextBox3_roomnumber"
        TextBox3_roomnumber.Size = New Size(226, 40)
        TextBox3_roomnumber.TabIndex = 27
        ' 
        ' TextBox2_first_name
        ' 
        TextBox2_first_name.Location = New Point(254, 180)
        TextBox2_first_name.Multiline = True
        TextBox2_first_name.Name = "TextBox2_first_name"
        TextBox2_first_name.Size = New Size(226, 40)
        TextBox2_first_name.TabIndex = 26
        ' 
        ' Button2_delete
        ' 
        Button2_delete.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button2_delete.Location = New Point(61, 560)
        Button2_delete.Name = "Button2_delete"
        Button2_delete.Size = New Size(394, 45)
        Button2_delete.TabIndex = 24
        Button2_delete.Text = "Delete"
        Button2_delete.UseVisualStyleBackColor = True
        ' 
        ' Button1_edit
        ' 
        Button1_edit.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1_edit.Location = New Point(61, 504)
        Button1_edit.Name = "Button1_edit"
        Button1_edit.Size = New Size(394, 49)
        Button1_edit.TabIndex = 23
        Button1_edit.Text = "Edit"
        Button1_edit.UseVisualStyleBackColor = True
        ' 
        ' Button3_add
        ' 
        Button3_add.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button3_add.Location = New Point(61, 455)
        Button3_add.Name = "Button3_add"
        Button3_add.Size = New Size(394, 46)
        Button3_add.TabIndex = 22
        Button3_add.Text = "Add"
        Button3_add.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(30, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(172, 38)
        Label5.TabIndex = 20
        Label5.Text = "Room Type:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(30, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 38)
        Label4.TabIndex = 19
        Label4.Text = "Number Room:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(30, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 38)
        Label3.TabIndex = 18
        Label3.Text = "Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(404, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 38)
        Label1.TabIndex = 16
        Label1.Text = "Room Page"
        ' 
        ' ComboBox1_type
        ' 
        ComboBox1_type.FormattingEnabled = True
        ComboBox1_type.Items.AddRange(New Object() {"Single", "Suite", "Studio Room", "Presidential Suites", "Double Rooms"})
        ComboBox1_type.Location = New Point(254, 306)
        ComboBox1_type.Name = "ComboBox1_type"
        ComboBox1_type.Size = New Size(225, 33)
        ComboBox1_type.TabIndex = 31
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(30, 355)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 38)
        Label2.TabIndex = 32
        Label2.Text = "Reserve:"
        ' 
        ' ComboBox2_reserve
        ' 
        ComboBox2_reserve.FormattingEnabled = True
        ComboBox2_reserve.Items.AddRange(New Object() {"Yes", "No"})
        ComboBox2_reserve.Location = New Point(255, 363)
        ComboBox2_reserve.Name = "ComboBox2_reserve"
        ComboBox2_reserve.Size = New Size(225, 33)
        ComboBox2_reserve.TabIndex = 33
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 41)
        Button1.TabIndex = 34
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1_id
        ' 
        TextBox1_id.Location = New Point(255, 121)
        TextBox1_id.Multiline = True
        TextBox1_id.Name = "TextBox1_id"
        TextBox1_id.Size = New Size(226, 40)
        TextBox1_id.TabIndex = 35
        TextBox1_id.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(30, 123)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 38)
        Label6.TabIndex = 36
        Label6.Text = "ID"
        Label6.Visible = False
        ' 
        ' Rooms
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1073, 652)
        Controls.Add(Label6)
        Controls.Add(TextBox1_id)
        Controls.Add(Button1)
        Controls.Add(ComboBox2_reserve)
        Controls.Add(Label2)
        Controls.Add(ComboBox1_type)
        Controls.Add(DataGridView1_room)
        Controls.Add(TextBox3_roomnumber)
        Controls.Add(TextBox2_first_name)
        Controls.Add(Button2_delete)
        Controls.Add(Button1_edit)
        Controls.Add(Button3_add)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Rooms"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rooms"
        CType(DataGridView1_room, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1_room As DataGridView
    Friend WithEvents TextBox3_roomnumber As TextBox
    Friend WithEvents TextBox2_first_name As TextBox
    Friend WithEvents Button2_delete As Button
    Friend WithEvents Button1_edit As Button
    Friend WithEvents Button3_add As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1_type As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2_reserve As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1_id As TextBox
    Friend WithEvents Label6 As Label
End Class
