Imports TechSupportData
Public Class frmOpenIncidents
    Private Sub frmOpenIncidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listIncident As List(Of Incident)
        Try
            listIncident = IncidentDB.GetOpenIncidents()
            If listIncident.Count > 0 Then
                Dim incident As Incident
                For i As Integer = 0 To listIncident.Count - 1
                    incident = listIncident(i)
                    lvIncidents.Items.Add(incident.ProductCode)
                    lvIncidents.Items(i).SubItems.Add(CDate(incident.DateOpened).ToShortDateString)
                    lvIncidents.Items(i).SubItems.Add(incident.CustomerName)
                    lvIncidents.Items(i).SubItems.Add(incident.TechnicianName)
                    lvIncidents.Items(i).SubItems.Add(incident.Title)
                Next
            Else
                MessageBox.Show("There are currently no open incidents.", "Notice")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            Me.Close()
        End Try
    End Sub
End Class