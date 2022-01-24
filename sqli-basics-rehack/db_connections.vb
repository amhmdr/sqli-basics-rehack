Imports System.Data.SqlClient

Module db_connections

    Public connection As New SqlConnection("Server= LAPTOP-N8MC9U3U; Database = sqli-demo; Integrated Security = true")
    Public dataadapter As New SqlDataAdapter
    Public ds As New DataSet()


    Public Sub dbConnectionOpen()
        Try
            connection.Open()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub dbConnectionClose()
        Try
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
