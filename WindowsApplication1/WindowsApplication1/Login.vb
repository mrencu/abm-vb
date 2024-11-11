Imports System.Data.OleDb

Public Class Login
    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        ' Prepares connection string from module
        SystemModule.con = con
        ' Prepares query string
        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE strComp(nombre, @nombre, 0) = 0 AND strComp(contraseña, @contraseña, 0) = 0"
        ' Declares variables which values are equal to user inputs
        Dim username As String = userText.Text
        Dim password As String = passText.Text

        Try
            ' Opens connection to the Access Database
            con.Open()
            ' Execute a command to the database with the method OleDbCommand
            Dim command As New OleDbCommand(query, con)
            ' Links values of the Users table with query's placeholders
            command.Parameters.AddWithValue("@nombre", username)
            command.Parameters.AddWithValue("@contraseña", password)

            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            If result > 0 Then
                Me.Hide()
                SystemModule.mainForm.Show()
            Else
                '  If the result is 0, it means no matching user was found  
                MessageBox.Show("Nombre de usuario no encontrado o clave incorrecta")
            End If
        Catch ex As Exception
            ' If an error has been produced, we show a message to the user with the information of the problem
            MessageBox.Show("Un error ocurrió: " & ex.Message)
        Finally
            ' Regardless of the results, we close the connection to the database
            con.Close()
        End Try
    End Sub

    Private Sub submitButton_Paint(sender As Object, e As PaintEventArgs) Handles submitButton.Paint
        Dim buttonPath As New Drawing2D.GraphicsPath()
        Dim radio As Integer = 20 ' Radio de los bordes redondeados

        ' Definir un rectángulo con las dimensiones del botón
        Dim rect As New Rectangle(0, 0, submitButton.Width, submitButton.Height)

        ' Añadir bordes redondeados al rectángulo
        buttonPath.AddArc(rect.X, rect.Y, radio, radio, 180, 90)
        buttonPath.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90)
        buttonPath.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90)
        buttonPath.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90)
        buttonPath.CloseAllFigures()

        ' Aplicar la forma redondeada al botón
        submitButton.Region = New Region(buttonPath)
    End Sub
End Class
