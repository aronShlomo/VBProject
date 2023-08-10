Imports System.Data.SqlClient

Public Class Reservation


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MainForm.Show()
    End Sub


    Private Sub BindViewReservation()
        Dim connection As New Connection
        connection.openConnection()
        Dim query = "select * from Reservation"
        Dim commend As New SqlCommand(query, connection.getConnection)
        Dim adapter As New SqlDataAdapter(commend)
        Dim table As New DataTable
        adapter.Fill(table)
        commend.ExecuteNonQuery()
        connection.closeConnection()
        DataGridView1_reservation.DataSource = table
    End Sub




    Private Sub Button3_add_Click(sender As Object, e As EventArgs) Handles Button3_add.Click
        If TextBox1_clientID.Text = "" Then
            MsgBox("Fill the Information")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "insert into Reservation (client_id,reservation_id,room_type,room_number,date_in,date_out)values(@clientID,@reservationID,@roomType,@roomNumber,@dateIn,@dateOut)"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@clientID", SqlDbType.VarChar).Value = TextBox1_clientID.Text
            commend.Parameters.AddWithValue("@reservationID", SqlDbType.VarChar).Value = TextBox2_reservationID.Text
            commend.Parameters.AddWithValue("@roomType", SqlDbType.VarChar).Value = ComboBox1_roomType.Text
            commend.Parameters.AddWithValue("@roomNumber", SqlDbType.VarChar).Value = TextBox3_roomNumber.Text
            commend.Parameters.AddWithValue("@dateIn", SqlDbType.Date).Value = DateTimePicker1_dateIn.Value.ToString
            commend.Parameters.AddWithValue("@dateOut", SqlDbType.VarChar).Value = DateTimePicker2_dateOut.Value.ToString
            commend.ExecuteNonQuery()
            connection.closeConnection()
            BindViewReservation()
            MsgBox("Added Successfully")
        End If
    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindViewReservation()
    End Sub


    Private Sub DataGridView1_reservation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1_reservation.CellClick
        TextBox1_id.Text = DataGridView1_reservation.CurrentRow.Cells(0).Value.ToString
        TextBox1_clientID.Text = DataGridView1_reservation.CurrentRow.Cells(1).Value.ToString
        TextBox2_reservationID.Text = DataGridView1_reservation.CurrentRow.Cells(2).Value.ToString
        TextBox3_roomNumber.Text = DataGridView1_reservation.CurrentRow.Cells(3).Value.ToString
        ComboBox1_roomType.Text = DataGridView1_reservation.CurrentRow.Cells(4).Value.ToString
        DateTimePicker1_dateIn.Text = DataGridView1_reservation.CurrentRow.Cells(5).Value.ToString
        DateTimePicker2_dateOut.Text = DataGridView1_reservation.CurrentRow.Cells(6).Value.ToString
        If TextBox1_clientID.Text = "" Then
            Button3_add.Enabled = True
        Else
            Button3_add.Enabled = False
        End If

    End Sub

    Private Sub Button1_edit_Click(sender As Object, e As EventArgs) Handles Button1_edit.Click
        If TextBox1_clientID.Text = "" Then
            MsgBox("No Information To edit")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "update Reservation Set client_id = @clientID, reservation_id = @reservationID, room_type = @roomType, room_number = @roomNumber, date_in = @dateIn, date_out = @dateOut where Id = @ID"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = TextBox1_id.Text
            commend.Parameters.AddWithValue("@clientID", SqlDbType.VarChar).Value = TextBox1_clientID.Text
            commend.Parameters.AddWithValue("@reservationID", SqlDbType.VarChar).Value = TextBox2_reservationID.Text
            commend.Parameters.AddWithValue("@roomType", SqlDbType.VarChar).Value = ComboBox1_roomType.Text
            commend.Parameters.AddWithValue("@roomNumber", SqlDbType.VarChar).Value = TextBox3_roomNumber.Text
            commend.Parameters.AddWithValue("@dateIn", SqlDbType.VarChar).Value = DateTimePicker1_dateIn.Value.ToString
            commend.Parameters.AddWithValue("@dateOut", SqlDbType.VarChar).Value = DateTimePicker2_dateOut.Value.ToString
            commend.ExecuteNonQuery()
            connection.closeConnection()
            BindViewReservation()
            MsgBox("Edit successfully")
        End If
    End Sub

    Private Sub Clear()
        TextBox1_clientID.Text = ""
        TextBox2_reservationID.Text = ""
        TextBox3_roomNumber.Text = ""
        ComboBox1_roomType.Text = ""
        DateTimePicker1_dateIn.Text = ""
        DateTimePicker2_dateOut.Text = ""
    End Sub

    Private Sub Button2_delete_Click(sender As Object, e As EventArgs) Handles Button2_delete.Click
        If TextBox1_clientID.Text = "" Then
            MsgBox("No Information To delete ")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "delete Reservation where Id = @id"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = TextBox1_id.Text
            commend.ExecuteNonQuery()
            connection.closeConnection()
            MsgBox("Successfully Deleted")
            BindViewReservation()
            Clear()
        End If
    End Sub
End Class