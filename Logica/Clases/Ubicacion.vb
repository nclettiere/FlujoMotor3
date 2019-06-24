Public Class Ubicacion
    Private _UbicaionId As Integer
    Private _Longi As Double
    Private _Lat As Double
    Private _Status As String
    Private _PatioID As Integer

    Public Sub New(UbicaionId As Integer, Longi As Double, Lat As Double, Status As String, PatioID As Integer)
        _UbicaionId = UbicaionId
        _Longi = Longi
        _Lat = Lat
        _Status = Status
        _PatioID = PatioID
    End Sub

    Public Property UbicaionId As Integer
        Get
            Return _UbicaionId
        End Get
        Set(value As Integer)
            _UbicaionId = value
        End Set
    End Property

    Public Property [Long] As Double
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

    Public Property Status As String
        Get
            Return _Status
        End Get
        Set(value As String)
            _Status = value
        End Set
    End Property

    Public Property PatioID As Integer
        Get
            Return _PatioID
        End Get
        Set(value As Integer)
            _PatioID = value
        End Set
    End Property
End Class
