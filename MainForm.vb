Public Class MainForm












    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1_reser.MouseHover
        Button1_reser.ForeColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1_reser.MouseLeave
        Button1_reser.ForeColor = Color.Black

    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2_rooms.MouseHover
        Button2_rooms.ForeColor = Color.Red
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2_rooms.MouseLeave
        Button2_rooms.ForeColor = Color.Black
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3_clients.MouseHover
        Button3_clients.ForeColor = Color.Red
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3_clients.MouseLeave
        Button3_clients.ForeColor = Color.Black
    End Sub

    Private Sub Button1_reser_Click(sender As Object, e As EventArgs) Handles Button1_reser.Click
        Dim reservation As New Reservation
        reservation.Show()
    End Sub

    Private Sub Button2_rooms_Click(sender As Object, e As EventArgs) Handles Button2_rooms.Click
        Dim rooms As New Rooms
        rooms.Show()
    End Sub

    Private Sub Button3_clients_Click(sender As Object, e As EventArgs) Handles Button3_clients.Click
        Dim clients As New Clients
        clients.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class