Imports System.Data.OleDb

Public Class Añadir

    Private Sub Añadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEstadoComboBox()
    End Sub

    Private Sub Añadir_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SystemModule.mainForm.Show()
    End Sub

    Private Sub LoadEstadoComboBox()
        SystemModule.con = con
        Dim query As String = "SELECT idEstado, Estado FROM Estado"
        Dim command As New OleDbCommand(query, con)
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()

        Try
            con.Open()
            adapter.Fill(table)
            estadoCombo.DataSource = table
            estadoCombo.DisplayMember = "Estado"    ' Nombre visible en el ComboBox
            estadoCombo.ValueMember = "idEstado"    ' Valor almacenado (id)
        Catch ex As Exception
            MessageBox.Show("Error al cargar el ComboBox: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim query As String = "INSERT INTO Registros (idEstado, razon, empleado, cliente, fechaHora, equipo, modelo) VALUES (@idEstado, @razon, @empleado, @cliente, @fechaHora, @equipo, @modelo)"
        Dim command As New OleDbCommand(query, con)

        command.Parameters.AddWithValue("@idEstado", estadoCombo.SelectedValue)
        command.Parameters.AddWithValue("@razon", razonText.Text)
        command.Parameters.AddWithValue("@empleado", empleadoText.Text)
        command.Parameters.AddWithValue("@cliente", clienteText.Text)
        command.Parameters.Add("@fechaHora", OleDbType.Date).Value = DateTime.Now
        command.Parameters.AddWithValue("@equipo", equipoText.Text)
        command.Parameters.AddWithValue("@modelo", modeloText.Text)

        Try
            con.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Registro agregado")
        Catch ex As Exception
            MessageBox.Show("Error al agregar registro: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class