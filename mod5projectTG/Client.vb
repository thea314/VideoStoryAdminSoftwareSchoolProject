Public Class Client

    'properties
    Private _ClientNo As String
    Private _FirstName As String
    Private _LastName As String
    Private _Email As String
    Private _Phone As String
    Private _DOB As Date
    Private _Address As String
    Private _City As String
    Private _Province As String
    Private _Postal_Code As String
    Private _Status As Integer

    'constructor
    Public Sub New(ByVal clientno As String, ByVal firstname As String, ByVal lastname As String,
                   ByVal email As String, ByVal phone As String, ByVal dob As Date,
                   ByVal address As String, ByVal city As String, ByVal province As String,
                   ByVal postal_code As String, ByVal status As Integer)

        Me._ClientNo = clientno
        Me._FirstName = firstname
        Me._LastName = lastname
        Me._Email = email
        Me._Phone = phone
        Me._DOB = dob
        Me._Address = address
        Me._City = city
        Me._Province = province
        Me._Postal_Code = postal_code
        Me._Status = status

    End Sub

    'alternate constructor from db values
    Public Sub New(ByVal datarow As DataRow)

        Me._ClientNo = datarow("client_number")
        Me._FirstName = datarow("fname")
        Me._LastName = datarow("lname")
        Me._Email = datarow("email")
        Me._Phone = datarow("phone")
        Me._DOB = datarow("dob")
        Me._Address = datarow("address")
        Me._City = datarow("city")
        Me._Province = datarow("province")
        Me._Postal_Code = datarow("postal_code")
        Me._Status = datarow("status")

    End Sub

    'Getters and Setters
    Public Property ClientNumber() As String
        Get
            Return _ClientNo
        End Get
        Set(value As String)
            _ClientNo = value
        End Set
    End Property

    Public Property Fname() As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property Lname() As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(value As String)
            _Phone = value
        End Set
    End Property

    Public Property DOB() As Date
        Get
            Return _DOB
        End Get
        Set(value As Date)
            _DOB = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(value As String)
            _Address = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return _City
        End Get
        Set(value As String)
            _City = value
        End Set
    End Property

    Public Property Province() As String
        Get
            Return _Province
        End Get
        Set(value As String)
            _Province = value
        End Set
    End Property

    Public Property Postal_Code() As String
        Get
            Return _Postal_Code
        End Get
        Set(value As String)
            _Postal_Code = value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return _Status
        End Get
        Set(value As Integer)
            _Status = value
        End Set
    End Property

End Class
