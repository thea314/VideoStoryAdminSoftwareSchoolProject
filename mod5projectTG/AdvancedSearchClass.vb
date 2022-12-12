Public Class AdvancedSearchClass

    'properties
    Private _ColumnName As String
    Private _ValueName As String
    Private _ValueField As String

    'constructor
    Public Sub New(ByVal column As String, ByVal valuename As String, ByVal value As String)

        Me._ColumnName = column
        Me._ValueName = valuename
        Me._ValueField = value

    End Sub

    'getters and setters
    Public Property Column() As String
        Get
            Return _ColumnName
        End Get
        Set(value As String)
            _ColumnName = value
        End Set
    End Property

    Public Property ValueName() As String
        Get
            Return _ColumnName
        End Get
        Set(value As String)
            _ColumnName = value
        End Set
    End Property

    Public Property ValueField() As String
        Get
            Return _ValueField
        End Get
        Set(value As String)
            _ValueField = value
        End Set
    End Property



End Class
