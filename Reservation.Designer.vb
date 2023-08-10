<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Label6 = New Label()
        TextBox1_clientID = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        ComboBox1_roomType = New ComboBox()
        DataGridView1_reservation = New DataGridView()
        TextBox3_roomNumber = New TextBox()
        TextBox2_reservationID = New TextBox()
        Button2_delete = New Button()
        Button1_edit = New Button()
        Button3_add = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        DateTimePicker1_dateIn = New DateTimePicker()
        DateTimePicker2_dateOut = New DateTimePicker()
        Label8 = New Label()
        TextBox1_id = New TextBox()
        CType(DataGridView1_reservation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(140, 155)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 38)
        Label6.TabIndex = 52
        Label6.Text = "Client ID:"
        ' 
        ' TextBox1_clientID
        ' 
        TextBox1_clientID.Location = New Point(365, 153)
        TextBox1_clientID.Multiline = True
        TextBox1_clientID.Name = "TextBox1_clientID"
        TextBox1_clientID.Size = New Size(293, 40)
        TextBox1_clientID.TabIndex = 51
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(30, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 41)
        Button1.TabIndex = 50
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(49, 420)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 38)
        Label2.TabIndex = 48
        Label2.Text = "Date In:"
        ' 
        ' ComboBox1_roomType
        ' 
        ComboBox1_roomType.FormattingEnabled = True
        ComboBox1_roomType.Items.AddRange(New Object() {"Single", "Suite", "Studio Room", "Presidential Suites", "Double Rooms"})
        ComboBox1_roomType.Location = New Point(364, 338)
        ComboBox1_roomType.Name = "ComboBox1_roomType"
        ComboBox1_roomType.Size = New Size(292, 33)
        ComboBox1_roomType.TabIndex = 47
        ' 
        ' DataGridView1_reservation
        ' 
        DataGridView1_reservation.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1_reservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1_reservation.GridColor = SystemColors.ActiveBorder
        DataGridView1_reservation.Location = New Point(775, 135)
        DataGridView1_reservation.Name = "DataGridView1_reservation"
        DataGridView1_reservation.RowHeadersWidth = 62
        DataGridView1_reservation.RowTemplate.Height = 33
        DataGridView1_reservation.Size = New Size(497, 482)
        DataGridView1_reservation.TabIndex = 46
        ' 
        ' TextBox3_roomNumber
        ' 
        TextBox3_roomNumber.Location = New Point(364, 271)
        TextBox3_roomNumber.Multiline = True
        TextBox3_roomNumber.Name = "TextBox3_roomNumber"
        TextBox3_roomNumber.Size = New Size(293, 40)
        TextBox3_roomNumber.TabIndex = 45
        ' 
        ' TextBox2_reservationID
        ' 
        TextBox2_reservationID.Location = New Point(364, 212)
        TextBox2_reservationID.Multiline = True
        TextBox2_reservationID.Name = "TextBox2_reservationID"
        TextBox2_reservationID.Size = New Size(293, 40)
        TextBox2_reservationID.TabIndex = 44
        ' 
        ' Button2_delete
        ' 
        Button2_delete.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button2_delete.Location = New Point(140, 589)
        Button2_delete.Name = "Button2_delete"
        Button2_delete.Size = New Size(497, 46)
        Button2_delete.TabIndex = 43
        Button2_delete.Text = "Delete"
        Button2_delete.UseVisualStyleBackColor = True
        ' 
        ' Button1_edit
        ' 
        Button1_edit.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1_edit.Location = New Point(140, 541)
        Button1_edit.Name = "Button1_edit"
        Button1_edit.Size = New Size(497, 42)
        Button1_edit.TabIndex = 42
        Button1_edit.Text = "Edit"
        Button1_edit.UseVisualStyleBackColor = True
        ' 
        ' Button3_add
        ' 
        Button3_add.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button3_add.Location = New Point(140, 488)
        Button3_add.Name = "Button3_add"
        Button3_add.Size = New Size(497, 47)
        Button3_add.TabIndex = 41
        Button3_add.Text = "Add"
        Button3_add.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(140, 330)
        Label5.Name = "Label5"
        Label5.Size = New Size(172, 38)
        Label5.TabIndex = 40
        Label5.Text = "Room Type:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(140, 273)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 38)
        Label4.TabIndex = 39
        Label4.Text = "Number Room:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(140, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(227, 38)
        Label3.TabIndex = 38
        Label3.Text = "Reservation ID: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(482, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 38)
        Label1.TabIndex = 37
        Label1.Text = "Reservation Page"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(384, 420)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 38)
        Label7.TabIndex = 53
        Label7.Text = "Date Out:"
        ' 
        ' DateTimePicker1_dateIn
        ' 
        DateTimePicker1_dateIn.Location = New Point(178, 426)
        DateTimePicker1_dateIn.Name = "DateTimePicker1_dateIn"
        DateTimePicker1_dateIn.Size = New Size(188, 31)
        DateTimePicker1_dateIn.TabIndex = 54
        ' 
        ' DateTimePicker2_dateOut
        ' 
        DateTimePicker2_dateOut.Location = New Point(536, 426)
        DateTimePicker2_dateOut.Name = "DateTimePicker2_dateOut"
        DateTimePicker2_dateOut.Size = New Size(207, 31)
        DateTimePicker2_dateOut.TabIndex = 55
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label8.Location = New Point(140, 97)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 38)
        Label8.TabIndex = 57
        Label8.Text = "ID:"
        Label8.Visible = False
        ' 
        ' TextBox1_id
        ' 
        TextBox1_id.Location = New Point(365, 95)
        TextBox1_id.Multiline = True
        TextBox1_id.Name = "TextBox1_id"
        TextBox1_id.Size = New Size(293, 40)
        TextBox1_id.TabIndex = 56
        TextBox1_id.Visible = False
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1298, 678)
        Controls.Add(Label8)
        Controls.Add(TextBox1_id)
        Controls.Add(DateTimePicker2_dateOut)
        Controls.Add(DateTimePicker1_dateIn)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox1_clientID)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(ComboBox1_roomType)
        Controls.Add(DataGridView1_reservation)
        Controls.Add(TextBox3_roomNumber)
        Controls.Add(TextBox2_reservationID)
        Controls.Add(Button2_delete)
        Controls.Add(Button1_edit)
        Controls.Add(Button3_add)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Reservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        CType(DataGridView1_reservation, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1_clientID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1_roomType As ComboBox
    Friend WithEvents DataGridView1_reservation As DataGridView
    Friend WithEvents TextBox3_roomNumber As TextBox
    Friend WithEvents TextBox2_reservationID As TextBox
    Friend WithEvents Button2_delete As Button
    Friend WithEvents Button1_edit As Button
    Friend WithEvents Button3_add As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1_dateIn As DateTimePicker
    Friend WithEvents DateTimePicker2_dateOut As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1_id As TextBox
End Class
