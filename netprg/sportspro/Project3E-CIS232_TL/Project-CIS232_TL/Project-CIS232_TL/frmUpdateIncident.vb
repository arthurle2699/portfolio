Imports TechSupportData
Public Class frmUpdateIncident
    Private Sub btnGetIncident_Click(sender As Object, e As EventArgs) Handles btnGetIncident.Click
        Dim incident As Incident
        If Validator.IsPresent(txtIncidentID, "Incident ID") AndAlso Validator.IsInt32(txtIncidentID, "Incident ID") Then
            Dim incidentID As Integer = CInt(txtIncidentID.Text)
            incident = IncidentDB.GetIncident(incidentID)
            If incident Is Nothing Then
                MessageBox.Show("There are no incidents with this ID", "Unknown ID")
            ElseIf Not IncidentDB.UpdateIncident(incident, incident.Description) Then
                MessageBox.Show("This incident has been closed", "Closed incident")
            Else
                txtIncidentID.Text = incident.IncidentID
                txtCustomer.Text = incident.CustomerName
                txtProduct.Text = incident.ProductName
                txtTechnician.Text = incident.TechnicianName
                txtTitle.Text = incident.Title
                txtDateOpened.Text = incident.DateOpened
                txtDescription.Text = incident.Description
                txtTextToAdd.Enabled = True
                btnClose.Enabled = True
                btnUpdate.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim textLong = False
        Dim incident As Incident = IncidentDB.GetIncident(CInt(txtIncidentID.Text))
        Dim Description As String = txtDescription.Text + Environment.NewLine + "<" + CDate(DateTime.Today) + "> " + txtTextToAdd.Text
        If Validator.IsPresent(txtTextToAdd, "Text to add") Then
            If Description.Length > 2000 Then
                Dim result As DialogResult = MessageBox.Show("Text will be truncated. Do you want to continue?", "Text is over 2000 letters limit", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    textLong = True
                    Description.Substring(0, 2000)
                End If
            End If
            If Description.Length < 2000 OrElse textLong = True Then
                If IncidentDB.UpdateIncident(incident, Description) Then
                    txtDescription.Text = Description
                    txtTextToAdd.Text = ""
                Else
                    MessageBox.Show("The incident had been closed", "Unable to add description")
                    txtTextToAdd.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim incident As Incident = IncidentDB.GetIncident(CInt(txtIncidentID.Text))
        Dim result As DialogResult = MessageBox.Show("This will close the incident. Do you want to continue?", "Close incident?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If IncidentDB.CloseIncident(incident) Then
                MessageBox.Show("Incident has been closed", "Notice")
                Me.Close()
            Else
                MessageBox.Show("Another user has updated this incident", "Unable to close incident")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class