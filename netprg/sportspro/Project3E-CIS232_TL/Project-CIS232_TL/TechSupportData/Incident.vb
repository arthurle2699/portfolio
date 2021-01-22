Public Class Incident
    Private m_IncidentID As Integer
    Private m_CustomerID As Integer
    Private m_ProductCode As String
    Private m_TechID As Nullable(Of Integer)
    Private m_DateOpened As Date
    Private m_DateClosed As Nullable(Of Date)
    Private m_Title As String
    Private m_Description As String
    Public Property IncidentID() As Integer
        Get
            Return m_IncidentID
        End Get
        Set(ByVal value As Integer)
            m_IncidentID = value
        End Set
    End Property
    Public Property CustomerID() As Integer
        Get
            Return m_CustomerID
        End Get
        Set(ByVal value As Integer)
            m_CustomerID = value
        End Set
    End Property
    Public Property ProductCode() As String
        Get
            Return m_ProductCode
        End Get
        Set(ByVal value As String)
            m_ProductCode = value
        End Set
    End Property
    Public Property TechID() As Nullable(Of Integer)
        Get
            If m_TechID.HasValue() Then
                Return m_TechID
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Nullable(Of Integer))
            m_TechID = value
        End Set
    End Property
    Public Property DateOpened() As Date
        Get
            Return m_DateOpened
        End Get
        Set(ByVal value As Date)
            m_DateOpened = value
        End Set
    End Property
    Public Property DateClosed() As Nullable(Of Date)
        Get
            If m_DateClosed.HasValue Then
                Return m_DateClosed
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_DateClosed = value
        End Set
    End Property
    Public Property Title() As String
        Get
            Return m_Title
        End Get
        Set(ByVal value As String)
            m_Title = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(ByVal value As String)
            m_Description = value
        End Set
    End Property
    Public ReadOnly Property CustomerName() As String
        Get
            Return CustomerDB.GetCustomerName(CustomerID)
        End Get
    End Property
    Public ReadOnly Property TechnicianName() As String
        Get
            Return TechnicianDB.GetTechnicianName(TechID)
        End Get
    End Property
    Public ReadOnly Property ProductName() As String
        Get
            Return ProductDB.GetProductName(ProductCode)
        End Get
    End Property
End Class
