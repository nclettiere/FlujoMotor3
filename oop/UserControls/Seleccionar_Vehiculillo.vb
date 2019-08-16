Public Class Seleccionar_Vehiculillo
    Private Shared _instance As Seleccionar_Vehiculillo

    Public Shared Property Instance As Seleccionar_Vehiculillo
        Get
            If _instance Is Nothing Then
                _instance = New Seleccionar_Vehiculillo()
            End If
            Return _instance
        End Get
        Set(value As Seleccionar_Vehiculillo)
            _instance = value
        End Set
    End Property
End Class
