Imports System.Data.OleDb
Public Class RegistrationDB
    Public Shared Function ProductRegistered(ByVal customerID As Integer, ByVal productCode As String) As Boolean
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "SELECT Count(*) " &
            "FROM Registrations " &
            "WHERE CustomerID = @CustomerID " &
            "AND ProductCode = @ProductCode"
        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Dim check As Boolean = False

        selectCommand.Parameters.AddWithValue("@CustomerID", customerID)
        selectCommand.Parameters.AddWithValue("@ProductCode", productCode)

        Try
            connection.Open()
            Dim length = CInt(selectCommand.ExecuteScalar)
            If length > 0 Then
                check = True
            End If
            connection.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return check
    End Function
    Public Shared Sub AddRegistration(ByVal registration As Registration)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "INSERT INTO Registrations " &
            "(CustomerID, ProductCode, RegistrationDate) " &
            "VALUES(@CustomerID, @ProductCode, @RegistrationDate) "

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@CustomerID", registration.CustomerID)
        selectCommand.Parameters.AddWithValue("@ProductCode", registration.ProductCode)
        selectCommand.Parameters.AddWithValue("@RegistrationDate", registration.DateOpened)

        Try
            connection.Open()
            selectCommand.ExecuteNonQuery()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Sub
End Class
