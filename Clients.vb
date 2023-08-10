Imports System.Data.SqlClient
Public Class Clients



    Private Sub BindDataGridView()
        Dim connection As New Connection
        connection.openConnection()
        Dim query = "select * from Client"
        Dim commend As New SqlCommand(query, connection.getConnection())
        Dim adapter As New SqlDataAdapter(commend)
        Dim table As New DataTable
        adapter.Fill(table)
        commend.ExecuteNonQuery()
        connection.closeConnection()
        DataGridView1.DataSource = table
    End Sub


    Private Sub Button3_clients_Click(sender As Object, e As EventArgs) Handles Button3_add.Click
        If TextBox2_first_name.Text = "" Or TextBox3_lastname.Text = "" Or TextBox4_address.Text = "" Or TextBox5_email.Text = "" Then
            MsgBox("Missing Information!!!! ")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "insert into Client(first_name,last_name,address,email)values(@firstName,@lastName,@address,@email)"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@firstName", TextBox2_first_name.Text)
            commend.Parameters.AddWithValue("@lastName", TextBox3_lastname.Text)
            commend.Parameters.AddWithValue("@address", TextBox4_address.Text)
            commend.Parameters.AddWithValue("@email", TextBox5_email.Text)
            commend.ExecuteNonQuery()
            connection.closeConnection()
            BindDataGridView()
            Clear()
        End If
    End Sub


    Private Sub Clear()
        TextBox1_id.Text = ""
        TextBox2_first_name.Text = ""
        TextBox3_lastname.Text = ""
        TextBox4_address.Text = ""
        TextBox5_email.Text = ""
    End Sub

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindDataGridView()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1_id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        TextBox2_first_name.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TextBox3_lastname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TextBox4_address.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        TextBox5_email.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        If TextBox2_first_name.Text = "" Then
            Button3_add.Enabled = True
        Else
            Button3_add.Enabled = False
        End If
    End Sub

    Private Sub Button1_edit_Click(sender As Object, e As EventArgs) Handles Button1_edit.Click
        If TextBox2_first_name.Text = "" Then
            MsgBox("No Information for Editing!!!")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "update Client Set first_name = @firstName, last_name = @lastName, address = @address, email = @email where Id = @id"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = TextBox1_id.Text
            commend.Parameters.AddWithValue("@firstName", SqlDbType.VarChar).Value = TextBox2_first_name.Text
            commend.Parameters.AddWithValue("@lastName", SqlDbType.VarChar).Value = TextBox3_lastname.Text
            commend.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = TextBox4_address.Text
            commend.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = TextBox5_email.Text
            commend.ExecuteNonQuery()
            connection.closeConnection()
            BindDataGridView()
            Clear()
        End If
    End Sub



    Private Sub Button2_delete_Click(sender As Object, e As EventArgs) Handles Button2_delete.Click
        If TextBox2_first_name.Text = "" Then
            MsgBox("No Information Where Selected to delete!!!")
        Else
            Dim connection As New Connection
            connection.openConnection()
            Dim query = "delete Client where id=@id"
            Dim commend As New SqlCommand(query, connection.getConnection)
            commend.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = TextBox1_id.Text
            commend.ExecuteNonQuery()
            connection.closeConnection()
            BindDataGridView()
            Clear()
            MsgBox("Client Successfully Deleted!!!!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MainForm.Show()
    End Sub
End Class