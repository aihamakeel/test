Imports System
Imports System.Data
Imports System.Data.OleDb
Imports CarsProjectVB

Public Class GC
    Public Shared Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\CarsProject.accdb;Jet OLEDB:Database Password=@Aiham@IT")
    Public Shared PicPath As String = ""
End Class
