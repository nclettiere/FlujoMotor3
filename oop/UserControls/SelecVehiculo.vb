Imports Logica

Public Class SelecVehiculo
    Private Property FormParent As VerLotes
    Private Property VinSeleccionado As String

    Friend Sub CargarDatos(FormParent As VerLotes)
        Me.FormParent = FormParent

        Try
            Dim ResultadoVehiculos = VObtenerAllFiltro("loteid IS NULL")
            DataGridVehiculos.DataSource = ResultadoVehiculos
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al cargar vehiculos")
        End Try
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        FormParent.AgregarVehiculo(VinSeleccionado)
        ParentForm.Close()
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridVehiculos.SelectionChanged
        if DataGridVehiculos.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridVehiculos.SelectedRows(0)
            VinSeleccionado = fila.Cells("vehiculovin").Value
        End If
    End Sub
End Class
