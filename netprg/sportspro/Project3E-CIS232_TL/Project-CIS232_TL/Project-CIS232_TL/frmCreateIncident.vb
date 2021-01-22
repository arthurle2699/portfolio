Imports TechSupportData
Public Class frmCreateIncident
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Check if title and desription is filled. If not, display error message and return to form
        'Then, check if customer is associated with product 
        'Then, set value to incident table
        'Display successful then close the form
        Try
            If Validator.IsPresent(txtTitle, "Title") AndAlso Validator.IsPresent(txtDesc, "Description") Then
                If RegistrationDB.ProductRegistered(cboCustomer.SelectedValue, cboProduct.SelectedValue) Then
                    Dim incident As New Incident
                    incident.CustomerID = CInt(cboCustomer.SelectedValue)
                    incident.ProductCode = cboProduct.SelectedValue
                    incident.Title = txtTitle.Text
                    incident.Description = txtDesc.Text
                    Try
                        IncidentDB.AddIncident(incident)
                        MessageBox.Show("Successfully added incident", "Confirmation")
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.GetType.ToString)
                    End Try
                Else
                    MessageBox.Show("Customer and Product does not match", "Error")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub frmCreateIncident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load combo boxes
        Me.LoadComboBoxes()
    End Sub
    Private Sub LoadComboBoxes()
        Try
            Dim customerList As List(Of Customer)
            customerList = CustomerDB.GetCustomerList
            cboCustomer.DataSource = customerList
            cboCustomer.DisplayMember = "Name"
            cboCustomer.ValueMember = "CustomerID"

            Dim productList As List(Of Product)
            productList = ProductDB.GetProductList
            cboProduct.DataSource = productList
            cboProduct.DisplayMember = "Name"
            cboProduct.ValueMember = "ProductCode"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub
End Class