Public Class Seleccionar_Lotesillo
    Private Shared _instance As Seleccionar_Lotesillo

    Public Shared Property Instance As Seleccionar_Lotesillo
        Get
            If _instance Is Nothing Then
                _instance = New Seleccionar_Lotesillo()
            End If
            Return _instance
        End Get
        Set(value As Seleccionar_Lotesillo)
            _instance = value
        End Set
    End Property


End Class
