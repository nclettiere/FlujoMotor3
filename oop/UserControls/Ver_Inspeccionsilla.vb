Public Class Ver_Inspeccionsilla
     Private Shared _instance As Ver_Inspeccionsilla

    Public Shared Property Instance As Ver_Inspeccionsilla
        Get
            If _instance Is Nothing Then
                _instance = New Ver_Inspeccionsilla()
            End If
            Return _instance
        End Get
        Set(value As Ver_Inspeccionsilla)
            _instance = value
        End Set
    End Property
End Class
