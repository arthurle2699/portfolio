Imports System.Data.OleDb
Public Class CustomerDB
    Public Shared Function GetCustomerName(ByVal customerID As Integer) As String
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectCommand As New OleDbCommand()
        Dim customerName As String

        selectCommand.Connection = connection
        selectCommand.CommandText =
            "SELECT Name " &
            "FROM Customers " &
            "WHERE CustomerID = " & customerID
        Try
            connection.Open()
            customerName = selectCommand.ExecuteScalar.ToString
            connection.Close()
        Catch ex As Exception
            Throw ex
        End Try
        Return customerName
    End Function
    Public Shared Function GetCustomerList() As List(Of Customer)
        Dim customerList As New List(Of Customer)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "SELECT CustomerID, Name " &
            "FROM Customers " &
            "ORDER BY Name"
        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()
            Dim customer As Customer
            Do While reader.Read
                customer = New Customer
                customer.CustomerID = CInt(reader("CustomerID"))
                customer.Name = reader("Name").ToString
                customerList.Add(customer)
            Loop
            reader.Close()
        Catch ex As oledbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return customerList
    End Function
End Class
