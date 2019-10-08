Public Class Operario

    Inherits Funcionario

    ' 0-> Operario Puerto | 1-> Operario Patio
    Private _Tipo As Integer
    Private _OperarioID As Integer

    Public Sub New(Id As String, Nombre As String, Apellido As String, Email As String, Password As String, Fecha As Date, Tipo As Integer, OperarioID As Integer)
        MyBase.New(Id, Nombre, Apellido, Email, Password, Fecha)
        _Tipo = Tipo
        _OperarioID = OperarioID
    End Sub

    Public Property Tipo As Integer
        Get
            Return _Tipo
        End Get
        Set(value As Integer)
            _Tipo = value
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

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
End Class
