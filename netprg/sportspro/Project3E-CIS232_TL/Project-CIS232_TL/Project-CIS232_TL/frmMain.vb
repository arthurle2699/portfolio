Public Class frmMain
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close the application
        Me.Close()
    End Sub

    Private Sub MaintainProducts2AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainProducts2AToolStripMenuItem.Click
        frmProductMaintenance.MdiParent = Me
        frmProductMaintenance.Show()
    End Sub

    Private Sub MaintainCustomers2BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainCustomers2BToolStripMenuItem.Click
        frmCustomerMaintenance.MdiParent = Me
        frmCustomerMaintenance.Show()
    End Sub

    Public Sub FormatZipCode(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.Value.GetType.ToString = "System.String" Then
            Dim s As String = e.Value.ToString
            If IsNumeric(s) Then
                If s.Length = 9 Then
                    e.Value = s.Substring(0, 5) &
                                "-" &
                                s.Substring(5, 4)
                End If
            End If
        End If
    End Sub
    Public Sub UnformatZipCode(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.Value.GetType.ToString = "System.String" Then
            Dim s As String = e.Value.ToString
            e.Value = s.Replace(".", "")
        End If
    End Sub

    Private Sub DIsplayIncidentsByProducts2CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIsplayIncidentsByProducts2CToolStripMenuItem.Click
        frmProductIncidents.MdiParent = Me
        frmProductIncidents.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nothing
    End Sub

    Private Sub DisplayOpenIncidents3AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayOpenIncidents3AToolStripMenuItem.Click
        frmOpenIncidents.MdiParent = Me
        frmOpenIncidents.Show()
    End Sub

    Private Sub CreateIncident3BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateIncident3BToolStripMenuItem.Click
        frmCreateIncident.MdiParent = Me
        frmCreateIncident.Show()
    End Sub

    Private Sub UpdateIncident3CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateIncident3CToolStripMenuItem.Click
        frmUpdateIncident.MdiParent = Me
        frmUpdateIncident.Show()
    End Sub

    Private Sub DIsplayOpenIncidentsByTechnicians3DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIsplayOpenIncidentsByTechnicians3DToolStripMenuItem.Click
        frmTechnicianIncidents.MdiParent = Me
        frmTechnicianIncidents.Show()
    End Sub

    Private Sub MaintainRegistrations3EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainRegistrations3EToolStripMenuItem.Click
        frmMaintainRegistrations.MdiParent = Me
        frmMaintainRegistrations.Show()
    End Sub
End Class
