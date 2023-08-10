Imports System.Data.SqlClient

Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New Connection
        Dim reader As SqlDataReader
        Dim commend As New SqlCommand

        Dim username As String = TextBox1_username.Text
        Dim password As String = TextBox2_password.Text
        Try
            connection.openConnection()
            Dim selectQuery = "Select username,password from [Login] where username = '" & username & "' and password = '" & password & "'"

            commend.CommandText = selectQuery
            commend.Connection = connection.getConnection

            reader = commend.ExecuteReader

            If reader.Read = True Then
                MessageBox.Show("Login Success!!!")
                Dim mainform As New MainForm
                mainform.Show()
            Else
                MessageBox.Show("Login Field!!!")
            End If
            connection.closeConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
