Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        Dim cmd As New SqlCommand
        dbConnectionOpen()
        If (connection.State = ConnectionState.Open) Then
        End If

        cmd = connection.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from users where username='" + txtUname.Text + "' and password ='" + txtPword.Text + "' "
        Dim x = cmd.ExecuteReader()

        While x.Read
            If x.HasRows = True Then
                MessageBox.Show("Hello")

                home.Show()
            End If
        End While

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
