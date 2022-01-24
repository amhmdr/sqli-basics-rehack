Imports System.Data.SqlClient

Public Class home

    Public cmd As New SqlCommand
    Public sql As String = ""
    'Public dataadapter As New SqlDataAdapter
    'Public ds As New DataSet()
    'Dim connection As New SqlConnection("Server= LAPTOP-N8MC9U3U; Database = sqli-demo; Integrated Security = true")
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql = "select * from fruits"
        dataadapter = New SqlDataAdapter(sql, connection)
        dataadapter.Fill(ds, "fruits")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "fruits"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sql = "SELECT * from fruits WHERE CONCAT(fruit_name,fruit_quantity) like '%" & txtSearch.Text & "%'"
        Dim command As New SqlCommand(sql, connection)
        dataadapter = New SqlDataAdapter(command)

        ds.Clear()

        dataadapter.Fill(ds, "fruits")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "fruits"
    End Sub
End Class