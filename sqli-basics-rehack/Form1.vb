Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        Dim cmd As New SqlCommand
        dbConnectionOpen()
        If (connection.State = ConnectionState.Open) Then
        End If


        'Below are the variables to store users input
        Dim uname As String
        Dim pword As String

        'Assigning the values to the variables
        uname = txtUname.Text
        pword = txtPword.Text

        'creating a variable to store SQL statement
        cmd = connection.CreateCommand()
        cmd.CommandType = CommandType.Text
        'Creating a SQL statement using users values
        cmd.CommandText = "select * from users where username='" + uname + "' and password ='" + pword + "' "

        'Executing query
        Dim x = cmd.ExecuteReader()
        Dim hasRow As Boolean = False
        While x.Read
            'If it returns a ROW proceed to HOME screen
            If x.HasRows = True Then
                hasRow = True
            End If
        End While

        If hasRow = True Then
            'Show home screen
            x.Close()
            home.Show()
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
