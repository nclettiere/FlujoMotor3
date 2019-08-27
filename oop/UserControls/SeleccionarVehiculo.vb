Imports DB

Public Class SeleccionarVehiculo
    Private Shared _instance As SeleccionarVehiculo

    Friend _FormParent As Ventanita_Seleccionar

    Public Shared Property Instance As SeleccionarVehiculo
        Get
            If _instance Is Nothing Then
                _instance = New SeleccionarVehiculo()
            End If
            Return _instance
        End Get
        Set(value As SeleccionarVehiculo)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Ventanita_Seleccionar
        Get
            Return _FormParent
        End Get
        Set(value As Ventanita_Seleccionar)
            _FormParent = value
        End Set
    End Property

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Dim SelectedItems = lisBoVehiculos.SelectedItems
        Dim ListaVehiculos = New List(Of String)
        For Each item As String In SelectedItems
            ListaVehiculos.Add(item)
        Next
        FormParent.GoToSection(0)
    End Sub
End Class
