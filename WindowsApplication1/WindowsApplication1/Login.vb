Imports System.Data.OleDb

Public Class Login

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        ' Prepares connection string from module
        SystemModule.con = con
        ' Prepares query string
        Dim query As String = "SELECT username, password FROM Users WHERE username = @username AND password = @password"
        ' Declares variables which values are equal to user inputs
        Dim username As String = userText.Text
        Dim password As String = passText.Text
        Dim usernameRead As String
        Dim passwordRead As String

        Try
            ' Opens connection to the Access Database
            con.Open()
            ' Execute a command to the database with the method OleDbCommand
            Dim command As New OleDbCommand(query, con)
            ' Links values of the Users table with query's placeholders
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)

            ' Reads the Users table values
            Dim reader As OleDbDataReader = command.ExecuteReader()

            ' TRUE = The reader has found data // FALSE = The reader hasn't found data
            If reader.HasRows Then
                ' While the reader has data to read, it will extract the username and password values and convert it to string
                While reader.Read()
                    usernameRead = reader("username").ToString()
                    passwordRead = reader("password").ToString()
                End While
                If username = usernameRead And password = passwordRead Then
                    MessageBox.Show("¡User found!")
                End If
            Else
                ' If the reader hasn't found data, we show a message to the user
                MessageBox.Show("No users found")
            End If
        Catch ex As Exception
            ' If an error has been produced, we show a message to the user with the information of the problem
            MessageBox.Show("An error ocurred: " & ex.Message)
        Finally
            ' Regardless of the results, we close the connection to the database
            con.Close()
        End Try

        If username = usernameRead And password = passwordRead Then
            MessageBox.Show("¡User found!")
            Me.Hide()
            SystemModule.mainForm.Show()
        End If
    End Sub

End Class
