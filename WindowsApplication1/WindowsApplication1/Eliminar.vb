Imports System.Data.OleDb

Public Class Eliminar

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim query As String = "DELETE FROM Registros WHERE idRegistro = @idRegistro"
        Dim command As New OleDbCommand(query, con)
        command.Parameters.AddWithValue("@idRegistro", registroText.Text)

        Try
            con.Open()
            Dim result As Integer = command.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Registro eliminado")
            Else
                MessageBox.Show("No se encontro ningún registro con el ID especificado")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar registro: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Eliminar_formClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SystemModule.mainForm.Show()
    End Sub
End Class