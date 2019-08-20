Imports oop

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

    Public Property FormParent As Ventanita_Seleccionar

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        If lisBoLote.SelectedItems.Count > 0
            Ventanita_Seleccionar.SelectedLote = (lisBoLote.SelectedItems(0))  
            Ventanita_Seleccionar.UpdateLotes()
        End If
    End Sub
End Class
