Imports System.Diagnostics.Metrics
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class VideoItem

    'properties
    Private _VideoId As Integer
    Private _Photo As String
    Private _Title As String
    Private _Year As Integer
    Private _Country As String
    Private _Language As String
    Private _Length As Integer
    Private _Resume As String
    Private _Genre As String
    Private _Actors As String
    Private _Director As String
    Private _Status As Integer

    'constructor
    Public Sub New(ByVal videoId As Integer, ByVal photo As String, ByVal title As String,
                   ByVal year As Integer, ByVal country As String, ByVal language As String,
                   ByVal length As Integer, ByVal videoResume As String, ByVal genre As String,
                   ByVal actors As String, ByVal director As String, ByVal status As Integer)

        Me._VideoId = videoId
        Me._Photo = photo
        Me._Title = title
        Me._Year = year
        Me._Country = country
        Me._Language = language
        Me._Length = length
        Me._Resume = videoResume
        Me._Genre = genre
        Me._Actors = actors
        Me._Director = director
        Me._Status = status

    End Sub

    'alternate constructor from db values
    Public Sub New(ByVal datarow As DataRow)

        Me._VideoId = datarow("video_id")
        Me._Photo = datarow("photo")
        Me._Title = datarow("title")
        Me._Year = datarow("year")
        Me._Country = datarow("country")
        Me._Language = datarow("language")
        Me._Length = datarow("length")
        Me._Resume = datarow("resume")
        Me._Genre = datarow("genre")
        Me._Actors = datarow("actors")
        Me._Director = datarow("director")
        Me._Status = datarow("status")

    End Sub

    'getters and setters
    Public Property VideoID() As Integer
        Get
            Return _VideoId
        End Get
        Set(value As Integer)
            _VideoId = value
        End Set
    End Property

    Public Property Photo() As String
        Get
            Return _Photo
        End Get
        Set(value As String)
            _Photo = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Public Property Year() As Integer
        Get
            Return _Year
        End Get
        Set(value As Integer)
            _Year = value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return _Country
        End Get
        Set(value As String)
            _Country = value
        End Set
    End Property

    Public Property Language() As String
        Get
            Return _Language
        End Get
        Set(value As String)
            _Language = value
        End Set
    End Property

    Public Property Length() As Integer
        Get
            Return _Length
        End Get
        Set(value As Integer)
            _Length = value
        End Set
    End Property

    Public Property VideoResume() As String
        Get
            Return _Resume
        End Get
        Set(value As String)
            _Resume = value
        End Set
    End Property

    Public Property Genre() As String
        Get
            Return _Genre
        End Get
        Set(value As String)
            _Genre = value
        End Set
    End Property

    Public Property Actors() As String
        Get
            Return _Actors
        End Get
        Set(value As String)
            _Actors = value
        End Set
    End Property

    Public Property Director() As String
        Get
            Return _Director
        End Get
        Set(value As String)
            _Director = value
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