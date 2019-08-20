Public Class Agregar_Lotesillo
    Private Shared _instance As Agregar_Lotesillo
    Private Shared _FormParent As Form


    Public Shared Property Instance As Agregar_Lotesillo
        Get
            If _instance Is Nothing Then
                _instance = New Agregar_Lotesillo()
            End If
            Return _instance
        End Get
        Set(value As Agregar_Lotesillo)
            _instance = value
        End Set
    End Property

    Public Shared Property FormParent As Form
        Get
            Return _FormParent
        End Get
        Set(value As Form)
            _FormParent = value
        End Set
    End Property

    Public Shared Property ListaVehiculosSeleccionados As List(Of String)

    Private Sub BtSeleccionarVehiculo_Click(sender As Object, e As EventArgs) Handles btSeleccionarVehiculo.Click
        Dim Ventanita_Seleccion As Ventanita_Seleccionar = DirectCast(FormParent, Ventanita_Seleccionar)
        Ventanita_Seleccion.GoToSection(1)
    End Sub

    Private Sub BtnAgrExistente_Click(sender As Object, e As EventArgs) 
        DirectCast(FormParent, Ventanita_Seleccionar).GotoSection(2)
    End Sub

    Friend Sub UpdateLotes(Lista As List(Of String))
        ListaVehiculosSeleccionados = Lista

        If ListaVehiculosSeleccionados.Count > 0
            lblSelected.Text = ListaVehiculosSeleccionados.Count.ToString + " Seleccionados"
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DirectCast(FormParent, Ventanita_Seleccionar).Close()
    End Sub

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click

    End Sub
End Class
