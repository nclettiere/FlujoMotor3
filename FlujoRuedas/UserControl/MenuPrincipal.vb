Imports DB

Public Class MenuPrincipal
    Private Shared _instance As MenuPrincipal

    Friend Property Conexion As ODBC
    Friend Property MainWindowForm As MainWindow

    Public Shared Property Instance As MenuPrincipal
        Get
            If _instance Is Nothing Then
                _instance = New MenuPrincipal()
            End If
            Return _instance
        End Get
        Set(value As MenuPrincipal)
            _instance = value
        End Set
    End Property
End Class
