Imports System.Data.SqlClient
Public Class Connection


    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asmil\Documents\HotelMeneger.mdf;Integrated Security=True;Connect Timeout=30")


    Function getConnection() As SqlConnection
        Return connection
    End Function


    Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

End Class
