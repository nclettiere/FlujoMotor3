Public Class Info_de_Autillos

    Private Shared _instance As Info_de_Autillos

    Public Shared Property Instance As Info_de_Autillos
        Get
            If _instance Is Nothing Then
                _instance = New Info_de_Autillos()
            End If
            Return _instance
        End Get
        Set(value As Info_de_Autillos)
            _instance = value
        End Set
    End Property
End Class
