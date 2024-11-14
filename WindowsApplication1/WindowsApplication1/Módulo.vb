Imports System.IO
Imports System.Data.OleDb

Module SystemModule
    Public mainForm As New Home()
    Public addForm As New Añadir()
    Public deleteForm As New Eliminar()
    Public updateForm As New Modificar()
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(Application.StartupPath, "System.accdb"))
End Module
