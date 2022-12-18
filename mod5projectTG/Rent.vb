Public Class Rent

    'properties
    Private _RentDate As Date

    'constructor
    Public Sub New(ByVal rentDate As Date)

        Me._RentDate = rentDate

    End Sub

    'database constructor
    Public Sub New(ByVal datarow As DataRow)

        Me._RentDate = datarow("rent_date")

    End Sub

    'getters and setters
    Public Property RentDate() As Date
        Get
            Return _RentDate
        End Get
        Set(value As Date)
            _RentDate = value
        End Set
    End Property

End Class
