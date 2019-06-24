Imports Test

Public Class Inspeccion

    Private _InspeccionID As Integer
    Private _Name As String
    Private _VehiculoVin As String
    Private _Descripcion As String
    Private _Ubicacion As String
    Private _OperarioID As String
    Private _Fecha As Date

    Private _Herencias As List(Of Inspeccion)

    Public Sub New(InspeccionID As Integer, Name As String, VehiculoVin As String, Descripcion As String, Ubicacion As String, OperarioID As String, Fecha As Date)
        _InspeccionID = InspeccionID
        _Name = Name
        _VehiculoVin = VehiculoVin
        _Descripcion = Descripcion
        _Ubicacion = Ubicacion
        _OperarioID = OperarioID
        _Fecha = Fecha
    End Sub

    Public Property InspeccionID As Integer
        Get
            Return _InspeccionID
        End Get
        Set(value As Integer)
            _InspeccionID = value
        End Set
    End Property

    Public Property VehiculoVin As String
        Get
            Return _VehiculoVin
        End Get
        Set(value As String)
            _VehiculoVin = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Ubicacion As String
        Get
            Return _Ubicacion
        End Get
        Set(value As String)
            _Ubicacion = value
        End Set
    End Property

    Public Property OperarioID As String
        Get
            Return _OperarioID
        End Get
        Set(value As String)
            _OperarioID = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Herencias As List(Of Inspeccion)
        Get
            Return _Herencias
        End Get
        Set(value As List(Of Inspeccion))
            _Herencias = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property
End Class
