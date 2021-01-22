Imports TechSupportData
Public Class frmTechnicianIncidents
    Private tech As Technician
    Private techList As List(Of Technician)
    Private incidentList As List(Of Incident)
    Private Sub frmTechnicianIncidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GetTechList()
        Me.GetIncidentList()
    End Sub
    Private Sub GetTechList()
        Try
            techList = TechnicianDB.GetTechnicianList
            cboTech.DataSource = techList
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub
    Private Sub GetIncidentList()
        Dim techID As Integer = CInt(cboTech.SelectedValue)
        Try
            tech = TechnicianDB.GetTechnician(techID)
            TechnicianBindingSource.Clear()
            TechnicianBindingSource.Add(tech)
            incidentList = IncidentDB.GetOpenTechnicianIncidents(techID)
            IncidentDataGridView.DataSource = incidentList
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub cboTech_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTech.SelectedIndexChanged
        Me.GetIncidentList()
    End Sub
End Class