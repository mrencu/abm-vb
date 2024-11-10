Imports System.Data.OleDb

Public Class Home
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub showData()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim query As String
        SystemModule.con = con
        query = "SELECT * FROM Registros"
        oda = New OleDbDataAdapter(query, con)
        ods.Tables.Add("Registros")
        oda.Fill(ods.Tables("Registros"))
        dataGrid.DataSource = ods.Tables("Registros")
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim employee As String
        Dim query As String
        Dim command As New OleDbCommand
        Dim oda As New OleDbDataAdapter
        Dim dataTable As New DataTable()
        employee = employeeText.Text
        SystemModule.con = con
        query = "SELECT * FROM Registros WHERE empleado = @empleado"
        command = New OleDbCommand(query, con)
        command.Parameters.AddWithValue("@empleado", employee)
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

    Private Sub hourTimer_Tick(sender As Object, e As EventArgs) Handles hourTimer.Tick
        Dim currentTime As String = DateTime.Now.ToString("HH:mm:ss")
        hourLabel.Text = currentTime
    End Sub

    Private Sub Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()  ' Esto cierra la aplicación completamente
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Me.Hide()
        SystemModule.addForm.ShowDialog()
    End Sub
End Class