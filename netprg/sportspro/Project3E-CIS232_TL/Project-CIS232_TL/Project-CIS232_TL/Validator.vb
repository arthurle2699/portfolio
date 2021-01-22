Public Class Validator
    Public Shared Function IsPresent(ByVal textBox As TextBox, ByVal name As String) As Boolean
        'Returns a Boolean value that indicates if a text box contains a value. If not, an error message Is displayed And the focus Is set to the text box.
        Dim check As Boolean = False
        If textBox.Text <> "" Then
            check = True
        Else
            MessageBox.Show(name + " is missing", "Error")
        End If
        Return check
    End Function
    Public Shared Function IsInt32(ByVal textBox As TextBox, ByVal name As String) As Boolean
        'Returns Boolean Check if Int32
        Try
            Convert.ToInt32(textBox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(name + " must be an integer value", "Error")
            textBox.Select()
            textBox.SelectAll()
            Return False
        End Try
    End Function
End Class
