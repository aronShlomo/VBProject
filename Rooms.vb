Imports System.Data.SqlClient

Public Class Rooms



    Private Sub BindGridView()
        Dim connection As New Connection
        connection.openConnection()
        Dim query = "select * from Room"
        Dim commend As New SqlCommand(query, connection.getConnection)
        Dim adapter As New SqlDataAdapter(commend)
        Dim table As New DataTable
        adapter.Fill(table)
        commend.ExecuteNonQuery()
        connection.closeConnection()
        DataGridView1_room.DataSource = table
    End Sub


    Private Sub Clear()
        TextBox2_first_name.Text = ""
        TextBox3_roomnumber.Text = ""
        ComboBox1_type.Text = ""
        ComboBox2_reserve.Text = ""
        TextBox1_id.Text = ""

    End Sub

    Private Sub Button3_add_Click(sender As Object, e As EventArgs) Handles Button3_add.Click
        If TextBox2_first_name.Text = "" Or TextBox3_roomnumber.Text = "" Then
            MsgBox("Missing Information")
        ElseIf ComboBox1_type.SelectedItem.ToString = "" Or ComboBox2_reserve.SelectedItem = "" Then
            MsgBox("Missing Information")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "insert into Room(name,number_room,room_type,reserve)values(@name,@room_number,@room_type,@reserve)"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = TextBox2_first_name.Text
            commend.Parameters.AddWithValue("@room_number", SqlDbType.VarChar).Value = TextBox3_roomnumber.Text
            commend.Parameters.AddWithValue("@room_type", SqlDbType.NVarChar).Value = ComboBox1_type.Text
            commend.Parameters.AddWithValue("@reserve", SqlDbType.NVarChar).Value = ComboBox2_reserve.Text

            commend.ExecuteNonQuery()
            connection.closeConnection()
            BindGridView()
            MsgBox("Room Added!!!")
            Clear()
        End If
    End Sub

    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindGridView()
    End Sub

    Private Sub DataGridView1_room_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1_room.CellClick
        TextBox1_id.Text = DataGridView1_room.CurrentRow.Cells(0).Value.ToString
        TextBox2_first_name.Text = DataGridView1_room.CurrentRow.Cells(1).Value.ToString
        TextBox3_roomnumber.Text = DataGridView1_room.CurrentRow.Cells(2).Value.ToString
        ComboBox1_type.Text = DataGridView1_room.CurrentRow.Cells(3).Value.ToString
        ComboBox2_reserve.Text = DataGridView1_room.CurrentRow.Cells(4).Value.ToString
        If TextBox2_first_name.Text = "" Then
            Button3_add.Enabled = True
        Else
            Button3_add.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Button1_edit_Click(sender As Object, e As EventArgs) Handles Button1_edit.Click
        If TextBox2_first_name.Text = "" Then
            MsgBox("No Information where selected")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "update Room Set name = @name, number_room = @numberRoom, room_type = @roomType, reserve = @reserve where Id = @id"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = TextBox1_id.Text
            commend.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = TextBox2_first_name.Text
            commend.Parameters.AddWithValue("@NumberRoom", SqlDbType.VarChar).Value = TextBox3_roomnumber.Text
            commend.Parameters.AddWithValue("@roomType", SqlDbType.VarChar).Value = ComboBox1_type.Text
            commend.Parameters.AddWithValue("@reserve", SqlDbType.VarChar).Value = ComboBox2_reserve.Text
            commend.ExecuteNonQuery()
            connection.closeConnection()
            BindGridView()
            Clear()
        End If
    End Sub

    Private Sub Button2_delete_Click(sender As Object, e As EventArgs) Handles Button2_delete.Click
        If TextBox2_first_name.Text = "" Then
            MsgBox("Select a room to delete")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "delete Room where id = @id"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = TextBox1_id.Text
            commend.ExecuteNonQuery()
            connection.closeConnection()
            BindGridView()
            MsgBox("Deleted Successfully!!!")
        End If
    End Sub
End Class