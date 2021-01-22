Imports System.Data.OleDb
Public Class IncidentDB
    Public Shared Function GetOpenIncidents() As List(Of Incident)
        Dim openIncidents As New List(Of Incident)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectstatement As String = "SELECT CustomerID, ProductCode, TechID, DateOpened, Title " &
        "FROM Incidents " &
        "WHERE DateClosed Is NULL "

        Dim selectCommand As New OleDbCommand(selectstatement, connection)
        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()
            Dim incident As Incident
            Do While reader.Read
                incident = New Incident
                incident.CustomerID = CInt(reader("CustomerID"))
                incident.ProductCode = reader("ProductCode").ToString
                incident.DateOpened = CDate(reader("DateOpened"))
                incident.Title = reader("Title").ToString
                If IsDBNull(reader("TechID")) Then
                    incident.TechID = Nothing
                Else
                    incident.TechID = CInt(reader("TechID"))
                End If
                openIncidents.Add(incident)
            Loop
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return openIncidents
    End Function
    Public Shared Sub AddIncident(ByVal incident As Incident)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectstatement As String = "INSERT INTO Incidents " &
        "(CustomerID, ProductCode, DateOpened, Title, Description) " &
        "VALUES (@CustomerID, @ProductCode, @DateOpened, @Title, @Description) "
        Dim selectCommand As New OleDbCommand(selectstatement, connection)

        selectCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID)
        selectCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode)
        selectCommand.Parameters.AddWithValue("@DateOpened", CDate(DateTime.Today))
        selectCommand.Parameters.AddWithValue("@Title", incident.Title)
        selectCommand.Parameters.AddWithValue("@Description", incident.Description)


        Try
            connection.Open()
            selectCommand.ExecuteNonQuery()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Sub
    Public Shared Function GetIncident(ByVal incidentID As Integer) As Incident
        Dim incident As New Incident
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "SELECT IncidentID, CustomerID, ProductCode, TechID, " &
            "DateOpened, DateClosed, Title, Description " &
            "FROM Incidents " &
            "WHERE incidentID = @IncidentID "

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@IncidentID", incidentID)

        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                incident.IncidentID = CInt(reader("IncidentID"))
                incident.CustomerID = CInt(reader("CustomerID"))
                incident.ProductCode = reader("ProductCode").ToString
                incident.TechID = CInt(reader("TechID"))
                incident.DateOpened = CDate(reader("DateOpened"))
                'incident.DateClosed = CDate(reader("DateClosed"))
                incident.Title = reader("Title").ToString
                incident.Description = reader("Description").ToString
            Else
                incident = Nothing
            End If
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return incident
    End Function
    Public Shared Function UpdateIncident(ByVal incident As Incident, ByVal description As String) As Boolean
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
        "UPDATE Incidents " &
        "SET Description = @NewDescription " &
        "WHERE IncidentID = @IncidentID " &
        "AND Description = @Description " &
        "AND DateClosed IS NULL"

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@NewDescription", description)
        selectCommand.Parameters.AddWithValue("@IncidentID", incident.IncidentID)
        selectCommand.Parameters.AddWithValue("@Description", incident.Description)

        Try
            connection.Open()
            Dim count As Integer = selectCommand.ExecuteNonQuery
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function
    Public Shared Function CloseIncident(ByVal incident As Incident) As Boolean
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "UPDATE Incidents " &
            "SET DateClosed = @DateClosed " &
            "WHERE IncidentID = @IncidentID " &
            "AND Description = @Description " &
            "AND DateClosed IS NULL"

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@DateClosed", CDate(DateTime.Today))
        selectCommand.Parameters.AddWithValue("@IncidentID", incident.IncidentID)
        selectCommand.Parameters.AddWithValue("@Description", incident.Description)

        Try
            connection.Open()
            Dim count As Integer = selectCommand.ExecuteNonQuery
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function
    Public Shared Function GetOpenTechnicianIncidents(ByVal techID As Integer) As List(Of Incident)
        Dim openTechnicianIncidents As New List(Of Incident)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectstatement As String =
            "SELECT CustomerID, ProductCode, DateOpened, Title, Description " &
            "FROM Incidents " &
            "WHERE TechID = @TechID " &
            "AND DateClosed IS NULL "

        Dim selectCommand As New OleDbCommand(selectstatement, connection)
        selectCommand.Parameters.AddWithValue("@TechID", techID)

        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()
            Dim incident As Incident
            Do While reader.Read
                incident = New Incident
                incident.CustomerID = CInt(reader("CustomerID"))
                incident.ProductCode = reader("ProductCode").ToString
                incident.DateOpened = CDate(reader("DateOpened"))
                incident.Title = reader("Title").ToString
                incident.Description = reader("Description").ToString
                openTechnicianIncidents.Add(incident)
            Loop
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return openTechnicianIncidents
    End Function
End Class
