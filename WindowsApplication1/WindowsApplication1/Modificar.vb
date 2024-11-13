Imports System.Data.OleDb

Public Class Modificar

    Private Sub Modificar_formClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SystemModule.mainForm.Show()
    End Sub

    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEstadoComboBox()
    End Sub

    Private Sub LoadEstadoComboBox()
        Dim query As String = "SELECT idEstado, Estado FROM Estado"
        Dim command As New OleDbCommand(query, con)
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()

        Try
            con.Open()
            adapter.Fill(table)
            estadoCombo.DataSource = table
            estadoCombo.DisplayMember = "Estado"
            estadoCombo.ValueMember = "idEstado"
        Catch ex As Exception
            MessageBox.Show("Error al cargar el ComboBox: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim query As String = "UPDATE Registros SET idEstado = @idEstado, razon = @razon, empleado = @empleado, cliente = @cliente, equipo = @equipo, modelo = @modelo WHERE idRegistro = @idRegistro"
        Dim command As New OleDbCommand(query, con)

        Dim idRegistro As Integer
        If Integer.TryParse(registroText.Text, idRegistro) Then
            command.Parameters.Add("@idEstado", OleDbType.Integer).Value = CInt(estadoCombo.SelectedValue)
            command.Parameters.Add("@razon", OleDbType.VarChar).Value = razonText.Text
            command.Parameters.Add("@empleado", OleDbType.VarChar).Value = empleadoText.Text
            command.Parameters.Add("@cliente", OleDbType.VarChar).Value = clienteText.Text
            command.Parameters.Add("@equipo", OleDbType.VarChar).Value = equipoText.Text
            command.Parameters.Add("@modelo", OleDbType.VarChar).Value = modeloText.Text
            command.Parameters.Add("@idRegistro", OleDbType.Integer).Value = idRegistro
        Else
            MessageBox.Show("El valor de N° de registro no es un número válido.")
            Return
        End If

        Try
            con.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Registro modificado exitosamente.")
            Else
                MessageBox.Show("No se encontró ningún registro con el ID proporcionado para modificar.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al modificar el registro: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
