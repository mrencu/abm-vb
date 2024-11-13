Imports System.Data.OleDb

Module SystemModule
    Public mainForm As New Home()
    Public addForm As New Añadir()
    Public deleteForm As New Eliminar()
    Public updateForm As New Modificar()
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\data\System.accdb")
End Module
