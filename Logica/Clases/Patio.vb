Public Class Patio
    Private _PatioId As Integer
    Private _Nombre As String
    Private _Longi As Double
    Private _Lat As Double

    Public Sub New(PatioId As Integer, Nombre As String, Longi As Double, Lat As Double)
        _PatioId = PatioId
        _Nombre = Nombre
        _Longi = Longi
        _Lat = Lat
    End Sub

    Public Property PatioId As Integer
        Get
            Return _PatioId
        End Get
        Set(value As Integer)
            _PatioId = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Longi As Double
        Get
            Return _Longi
        End Get
        Set(value As Double)
            _Longi = value
        End Set
    End Property

    Public Property Lat As Double
        Get
            Return _Lat
        End Get
        Set(value As Double)
            _Lat = value
        End Set
    End Property
End Class
