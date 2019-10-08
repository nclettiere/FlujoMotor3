Public Class Cliente
    Private _ClienteID As Integer
    Private _ClienteNombre As String
    Private _ClienteApellido As String

    Public Sub New(ClienteID As Integer, ClienteNombre As String, ClienteApellido As String)
        _ClienteID = ClienteID
        _ClienteNombre = ClienteNombre
        _ClienteApellido = ClienteApellido
    End Sub

    Public Property ClienteID As Integer
        Get
            Return _ClienteID
        End Get
        Set(value As Integer)
            _ClienteID = value
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

    Public Property ClienteApellido As String
        Get
            Return _ClienteApellido
        End Get
        Set(value As String)
            _ClienteApellido = value
        End Set
    End Property
End Class
