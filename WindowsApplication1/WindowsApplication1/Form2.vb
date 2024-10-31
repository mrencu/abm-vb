Imports System.Data.OleDb

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub showData()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim query As String
        SystemModule.con = con
        query = "SELECT * FROM Records"
        oda = New OleDbDataAdapter(query, con)
        ods.Tables.Add("Records")
        oda.Fill(ods.Tables("Records"))
        dataGrid.DataSource = ods.Tables("Records")
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim employee As String
        Dim query As String
        Dim command As New OleDbCommand
        Dim oda As New OleDbDataAdapter
        Dim dataTable As New DataTable()
        employee = employeeText.Text
        SystemModule.con = con
        query = "SELECT * FROM Records WHERE employee = @employee"
        command = New OleDbCommand(query, con)
        command.Parameters.AddWithValue("@employee", employee)
        oda = New OleDbDataAdapter(command)
        Try
            con.Open()
            oda.Fill(dataTable)
            dataGrid.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class