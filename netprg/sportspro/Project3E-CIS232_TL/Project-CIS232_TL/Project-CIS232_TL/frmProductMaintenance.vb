Imports System.Data.OleDb
Public Class frmProductMaintenance
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        'Me.ProductsBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.TechSupportDataSet2A)
        Try
            Me.ProductsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TechSupportDataSet2A)
        Catch ex As DBConcurrencyException
            MessageBox.Show("A concurency error occurred. " &
                            "One or more rows were not updated or deleted.", "Concurrency Exception")
            Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet2A.Products)
        Catch ex As DataException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            ProductsBindingSource.CancelEdit()
        Catch ex As OleDbException
            'ex.Message & vbCrLf & "You are being re-directed back to the Main Window", ex.GetType.ToString
            MessageBox.Show("OLEDB Error: " & ex.Message & vbCrLf, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub frmProductMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechSupportDataSet2A.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet2A.Products)
    End Sub

    Private Sub ProductsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles ProductsDataGridView.DataError
        Dim row As Integer = e.RowIndex + 1
        Dim errorMessage As String = "A data error has occurred. " & vbCrLf &
            "Row" & row & vbCrLf & "Error: " & e.Exception.Message
        MessageBox.Show(errorMessage, "Data Error")
    End Sub
End Class