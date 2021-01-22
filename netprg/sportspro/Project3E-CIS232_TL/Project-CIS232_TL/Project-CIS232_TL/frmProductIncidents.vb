Public Class frmProductIncidents
    Private Sub frmProductIncidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechSupportDataSet2C.Incidents' table. You can move, or remove it, as needed.
        'Me.IncidentsTableAdapter.Fill(Me.TechSupportDataSet2C.Incidents)
        'TODO: This line of code loads data into the 'TechSupportDataSet2C.Products' table. You can move, or remove it, as needed.
        'Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet2C.Products)
        Try
            Me.IncidentsTableAdapter.Fill(Me.TechSupportDataSet2C.Incidents)
            Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet2C.Products)
        Catch er As Exception
            MessageBox.Show(er.Message, er.GetType.ToString)
        End Try
    End Sub

    Private Sub IncidentsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IncidentsDataGridView.CellContentClick
        'event handler to get customer id and display customer info in child form
        If e.ColumnIndex = 5 Then
            Dim rowIndex As Integer = e.RowIndex
            Dim rowType As DataGridViewRow = IncidentsDataGridView.Rows(rowIndex)
            Dim rowCell As DataGridViewCell = rowType.Cells(3)
            Dim customerNameParameter As String = rowCell.Value
            Dim customerIDParameter As Integer = Me.IncidentsTableAdapter.GetDataByName(customerNameParameter)
            Try
                'Type Casting will not work 
                'Dim customerInstance As Customer = CType(row.DataBoundItem, Customer)
                'open instance of child form 
                Dim newMDIChild As New frmCustomer
                newMDIChild.customerID = customerIDParameter
                newMDIChild.MdiParent = frmMain
                newMDIChild.Show()
            Catch er As Exception
                MessageBox.Show(er.Message, er.GetType.ToString)
            End Try
        End If
    End Sub

End Class