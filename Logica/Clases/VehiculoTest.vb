Public Class VehiculoTest

    Private _Vin As String
    Private _Marca As String
    Private _Modelo As String
    Private _Tipo As String
    Private _Color As String
    Private _Status As String
    Private _Anio As Short
    Private _Fecha As String
    Private _CantInsp As Integer
    Private _OperarioID As Integer
    Private _UbicacionID As Integer
    Private _ClienteNombre As String


    Public Sub New()
    End Sub

    Public Sub New(Vin As String, Marca As String, Modelo As String, Tipo As String, Color As String, Status As String, Anio As Short, Fecha As String, CantInsp As Integer, OperarioID As Integer, UbicacionID As Integer, ClienteNombre As String)
        _Vin = Vin
        _Marca = Marca
        _Modelo = Modelo
        _Tipo = Tipo
        _Color = Color
        _Status = Status
        _Anio = Anio
        _Fecha = Fecha
        _CantInsp = CantInsp
        _OperarioID = OperarioID
        _UbicacionID = UbicacionID
        _ClienteNombre = ClienteNombre
    End Sub

    Public Property Vin As String
        Get
            Return _Vin
        End Get
        Set(value As String)
            _Vin = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(value As String)
            _Modelo = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
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

    Public Property Anio As Short
        Get
            Return _Anio
        End Get
        Set(value As Short)
            _Anio = value
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

    Public Property CantInsp As Integer
        Get
            Return _CantInsp
        End Get
        Set(value As Integer)
            _CantInsp = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _Color
        End Get
        Set(value As String)
            _Color = value
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

    Public Property UbicacionID As Integer
        Get
            Return _UbicacionID
        End Get
        Set(value As Integer)
            _UbicacionID = value
        End Set
    End Property

    Public Property ClienteNombre As String
        Get
            Return _ClienteNombre
        End Get
        Set(value As String)
            _ClienteNombre = value
        End Set
    End Property
End Class
