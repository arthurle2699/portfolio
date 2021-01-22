Public Class frmCustomer
    Public customerID As Integer
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fill the datatable with the global variable
        Try
            Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet2C.Customers, customerID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'code that wires procedure to format event (p. 103) 
        Dim b As Binding = ZipCodeTextBox.DataBindings("Text")
        AddHandler b.Format, AddressOf frmMain.FormatZipCode
        AddHandler b.Parse, AddressOf frmMain.UnformatZipCode
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close button 
        Me.Close()
    End Sub
End Class