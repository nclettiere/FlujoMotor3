Public Class Funcionario
    Private _Id As String
    Private _Nombre As String
    Private _Apellido As String
    Private _Email As String
    Private _Password As String
    Private _Fecha As Date

    Public Sub New(Id As String, Nombre As String, Apellido As String, Email As String, Password As String, Fecha As Date)
        _Id = Id
        _Nombre = Nombre
        _Apellido = Apellido
        _Email = Email
        _Password = Password
        _Fecha = Fecha
    End Sub

    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(value As String)
            _Id = value
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

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
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

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property
End Class
