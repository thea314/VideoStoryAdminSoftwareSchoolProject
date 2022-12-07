Imports Google.Protobuf.WellKnownTypes

Public Class User

    'properties
    Private _EmployeeId As Long
    Private _Username As String
    Private _Password As String
    Private _FirstName As String
    Private _LastName As String
    Private _DOB As Date
    Private _Address As String
    Private _City As String
    Private _Province As String
    Private _PostalCode As String
    Private _HomePhone As String
    Private _CellPhone As String
    Private _StartDate As Date
    Private _SIN As String
    Private _HourlyPay As Double
    Private _Education As String
    Private _Level As Integer
    Private _Status As Integer

    'constructor
    Public Sub New(ByVal employeeId As Long, ByVal username As String, ByVal password As String,
                   ByVal firstname As String, ByVal lastname As String, ByVal dob As Date,
                   ByVal address As String, ByVal city As String, ByVal province As String,
                   ByVal postalCode As String, ByVal homePhone As String, ByVal cellPhone As String,
                   ByVal startDate As Date, ByVal sin As String, ByVal hourlyPay As Double,
                   ByVal education As String, ByVal level As Integer, ByVal status As Integer)

        Me._EmployeeId = employeeId
        Me._Username = username
        Me._Password = password
        Me._FirstName = firstname
        Me._LastName = lastname
        Me._DOB = dob
        Me._Address = address
        Me._City = city
        Me._Province = province
        Me._PostalCode = postalCode
        Me._HomePhone = homePhone
        Me._CellPhone = cellPhone
        Me._StartDate = startDate
        Me._SIN = sin
        Me._HourlyPay = hourlyPay
        Me._Education = education
        Me._Level = level
        Me._Status = status

    End Sub

    Public Sub New(ByVal datarow As DataRow)

        Me._EmployeeId = datarow("employee_number")
        Me._Username = datarow("username")
        Me._Password = datarow("password")
        Me._FirstName = datarow("fname")
        Me._LastName = datarow("lname")
        Me._DOB = datarow("dob")
        Me._Address = datarow("address")
        Me._City = datarow("city")
        Me._Province = datarow("province")
        Me._PostalCode = datarow("postal_code")
        Me._HomePhone = datarow("home_phone")
        Me._CellPhone = datarow("cell_phone")
        Me._StartDate = datarow("start_date")
        Me._SIN = datarow("sin")
        Me._HourlyPay = datarow("hourly_pay")
        Me._Education = datarow("education")
        Me._Level = datarow("level")
        Me._Status = datarow("status")

    End Sub

    'Getters and setters
    Public Property EmployeeID() As Long
        Get
            Return _EmployeeId
        End Get
        Set(value As Long)
            _EmployeeId = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    Public Property DoB() As Date
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

    Public Property PostalCode() As String
        Get
            Return _PostalCode
        End Get
        Set(value As String)
            _PostalCode = value
        End Set
    End Property

    Public Property HomePhone() As String
        Get
            Return _HomePhone
        End Get
        Set(value As String)
            _HomePhone = value
        End Set
    End Property

    Public Property CellPhone() As String
        Get
            Return _CellPhone
        End Get
        Set(value As String)
            _CellPhone = value
        End Set
    End Property

    Public Property StartDate() As Date
        Get
            Return _StartDate
        End Get
        Set(value As Date)
            _StartDate = value
        End Set
    End Property

    Public Property Sin() As String
        Get
            Return _SIN
        End Get
        Set(value As String)
            _SIN = value
        End Set
    End Property

    Public Property HourlyPay() As Double
        Get
            Return _HourlyPay
        End Get
        Set(value As Double)
            _HourlyPay = value
        End Set
    End Property

    Public Property Education() As String
        Get
            Return _Education
        End Get
        Set(value As String)
            _Education = value
        End Set
    End Property

    Public Property Level() As Integer
        Get
            Return _Level
        End Get
        Set(value As Integer)
            _Level = value
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
