Public Class Product
    Private m_ProductCode As String
    Private m_Name As String
    Public Property ProductCode() As String
        Get
            Return m_ProductCode
        End Get
        Set(value As String)
            m_ProductCode = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
End Class
