Imports Logica

Public Class AgregarLote
    Private Shared _instance As AgregarLote
    Public Shared Property Instance As AgregarLote
        Get
            If _instance Is Nothing Then
                _instance = New AgregarLote()
            End If
            Return _instance
        End Get
        Set(value As AgregarLote)
            _instance = value
        End Set
    End Property

    Public Shared Property ListaVehiculosSeleccionados As List(Of String)
    Public Property FormParent As Ventana_Seleccionar
    Public Property ParentControl As AgregarVehiculo
    Public Property Cliente As String

    Private Sub BtnAgrExistente_Click(sender As Object, e As EventArgs) 
        DirectCast(FormParent, Ventana_Seleccionar).GotoSection(2)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DirectCast(FormParent, Ventana_Seleccionar).Close()
    End Sub

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If Not String.IsNullOrWhiteSpace(riTeBoDescripcion.Text) Then
            If cbxPatio.SelectedIndex >= 0
                Dim datos As String() = {riTeBoDescripcion.Text, cbxPatio.Text.ToString}
                ParentControl.UpdateLotes(datos)
                FormParent.Close()
            Else
                MessageBox.Show("Debes seleccionar un patio.")
            End If
        Else
            MessageBox.Show("La descripcion no debe quedar vacia.")
        End If
    End Sub

    Friend Sub CargarDatos(ventanita_Seleccionar As Ventana_Seleccionar, parent As Object)
        FormParent = ventanita_Seleccionar
        ParentControl = DirectCast(parent, AgregarVehiculo)

        Try
            Dim ConsultaPatios As DataTable = PObtenerAll
            For Each item As DataRow In ConsultaPatios.Rows
                cbxPatio.Items.Add(item(1).ToString)
            Next
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error.")
        End Try
    End Sub

End Class
