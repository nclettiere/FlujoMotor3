Imports Logica

Public Class Inspeccion

    Private _InspeccionID As Integer
    Private _VehiculoVin As String
    Private _Descripcion As String
    Private _OperarioID As Integer
    Private _Fecha As String

    Private _HerenciaID As Integer

    Public Sub New(InspeccionID As Integer, VehiculoVin As String, Descripcion As String, OperarioID As Integer, Fecha As String)
        _InspeccionID = InspeccionID
        _VehiculoVin = VehiculoVin
        _Descripcion = Descripcion
        _OperarioID = OperarioID
        _Fecha = Fecha
        _HerenciaID = Nothing
    End Sub

    Public Sub New(InspeccionID As Integer, VehiculoVin As String, Descripcion As String, OperarioID As Integer, Fecha As String, Herencia As Integer)
        _InspeccionID = InspeccionID
        _VehiculoVin = VehiculoVin
        _Descripcion = Descripcion
        _OperarioID = OperarioID
        _Fecha = Fecha
        _HerenciaID = Herencia
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

    Public Property OperarioID As Integer
        Get
            Return _OperarioID
        End Get
        Set(value As Integer)
            _OperarioID = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Herencia As Integer
        Get
            Return _HerenciaID
        End Get
        Set(value As Integer)
            _HerenciaID = value
        End Set
    End Property
End Class
