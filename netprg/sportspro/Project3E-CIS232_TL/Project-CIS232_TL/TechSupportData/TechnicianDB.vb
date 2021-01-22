Imports System.Data.OleDb
Public Class TechnicianDB
    Public Shared Function GetTechnicianName(ByVal techID As Integer) As String
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectCommand As New OleDbCommand()
        Dim technicianName As String

        Dim objTechName As Object

        selectCommand.Connection = connection
        selectCommand.CommandText =
            "SELECT Name " &
            "FROM Technicians " &
            "WHERE TechID = " & techID
        Try
            connection.Open()
            objTechName = selectCommand.ExecuteScalar()
            If objTechName Is Nothing Then
                technicianName = ""
            Else
                technicianName = objTechName.ToString
            End If
            connection.Close()
        Catch ex As Exception
            Throw ex
        End Try
        Return technicianName
    End Function
    Public Shared Function GetTechnicianList() As List(Of Technician)
        Dim technicianList As New List(Of Technician)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectstatement As String =
            "SELECT TechID, Name " &
            "FROM Technicians " &
            "ORDER BY Name "

        Dim selectCommand As New OleDbCommand(selectstatement, connection)

        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()
            Dim technician As Technician
            Do While reader.Read
                technician = New Technician
                technician.TechID = CInt(reader("TechID"))
                technician.Name = reader("Name").ToString
                'technician.Phone = reader("Phone").ToString
                'technician.Email = reader("Email").ToString
                technicianList.Add(technician)
            Loop
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return technicianList
    End Function
    Public Shared Function GetTechnician(ByVal techID As Integer) As Technician
        Dim technician As New Technician
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectstatement As String =
            "SELECT TechID, Name, Email, Phone " &
            "FROM Technicians " &
            "WHERE TechID = @TechID "

        Dim selectCommand As New OleDbCommand(selectstatement, connection)
        selectCommand.Parameters.AddWithValue("@TechID", techID)

        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                technician = New Technician
                technician.TechID = CInt(reader("TechID"))
                technician.Name = reader("Name").ToString
                technician.Phone = reader("Phone").ToString
                technician.Email = reader("Email").ToString
            Else
                technician = Nothing
            End If
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return technician
    End Function
End Class
