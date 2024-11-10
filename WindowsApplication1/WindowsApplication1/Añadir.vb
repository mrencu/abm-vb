Public Class Añadir
    Private Sub Añadir_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SystemModule.mainForm.Show()  ' Esto cierra la aplicación completamente
    End Sub
End Class