Public Class Technician
    Private m_TechID As Integer
    Private m_Name As String
    Private m_Email As String
    Private m_Phone As String
    Public Property TechID() As Integer
        Get
            Return m_TechID
        End Get
        Set(ByVal value As Integer)
            m_TechID = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return m_Email
        End Get
        Set(ByVal value As String)
            m_Email = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return m_Phone
        End Get
        Set(ByVal value As String)
            m_Phone = value
        End Set
    End Property
End Class
