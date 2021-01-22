Imports TechSupportData
Public Class frmMaintainRegistrations
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If RegistrationDB.ProductRegistered(cboCustomer.SelectedValue, cboProduct.SelectedValue) Then
            MessageBox.Show("Product already registered", "Registered product")
        Else
            Dim registration As New Registration
            registration.CustomerID = cboCustomer.SelectedValue
            registration.ProductCode = cboProduct.SelectedValue
            registration.DateOpened = CDate(DateTime.Today)
            RegistrationDB.AddRegistration(registration)
            MessageBox.Show("Registration success!", "Registration confirm")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMaintainRegistrations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim customerList As List(Of Customer)
        Dim productList As List(Of Product)
        Try
            customerList = CustomerDB.GetCustomerList
            cboCustomer.DataSource = customerList
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try

        Try
            productList = ProductDB.GetProductList
            cboProduct.DataSource = productList
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub
End Class