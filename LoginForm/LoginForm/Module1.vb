Imports System.Data.OleDb

Module Module1
    Public dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Robert\Desktop\ampm restobar.accdb"
    Public con As New OleDbConnection
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public trans As OleDbTransaction
    Public cmd1 As OleDbCommand
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Public dt As New DataTable

    Public Sub openDatabase()
        con.Close()
        con.ConnectionString = dbcon
        con.Open()
    End Sub

End Module
