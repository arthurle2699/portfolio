Imports System.Data.OleDb
Public Class TechSupportDB
    Public Shared Function GetConnection() As OleDbConnection
        Dim connectionString As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Bob\TechSupport.mdb"
        Return New OleDbConnection(connectionString)
    End Function
End Class
