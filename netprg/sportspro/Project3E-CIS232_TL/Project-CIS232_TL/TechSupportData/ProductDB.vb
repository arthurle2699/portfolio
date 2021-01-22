Imports System.Data.OleDb
Public Class ProductDB
    Public Shared Function GetProductList() As List(Of Product)
        Dim productList As New List(Of Product)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "SELECT ProductCode, Name " &
            "FROM Products " &
            "ORDER BY Name"
        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()
            Dim product As Product
            Do While reader.Read
                product = New Product
                product.ProductCode = reader("ProductCode").ToString
                product.Name = reader("Name").ToString
                productList.Add(product)
            Loop
            reader.Close()
        Catch ex As oledbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return productList
    End Function
    Public Shared Function GetProductName(ByVal productCode As String) As String
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectCommand As New OleDbCommand()
        Dim productName As String

        'Dim objReturn As Object

        selectCommand.Connection = connection
        selectCommand.CommandText =
            "SELECT Name " &
            "FROM Products " &
            "WHERE ProductCode = @productCode"
        selectCommand.Parameters.AddWithValue("@productCode", productCode)

        Try
            connection.Open()
            productName = selectCommand.ExecuteScalar.ToString
            connection.Close()
        Catch ex As Exception
            Throw ex
        End Try
        Return productName
    End Function
End Class
