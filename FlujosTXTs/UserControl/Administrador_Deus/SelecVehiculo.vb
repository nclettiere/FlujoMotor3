Imports FlujosTXTs
Imports Logica

Public Class SelecVehiculo
    Friend UC_VehiculosLotes As VehiculosLotes
    Private Property VinSeleccionado As String

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        If UC_VehiculosLotes IsNot Nothing
            UC_VehiculosLotes.AgregarALote(VinSeleccionado)
        End If
        ParentForm.Close()
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridVehiculos.SelectionChanged
        if DataGridVehiculos.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridVehiculos.SelectedRows(0)
            VinSeleccionado = fila.Cells("vehiculovin").Value
        End If
    End Sub

    Private Sub CargarDatos(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ResultadoVehiculos = VObtenerAllFiltro("loteid IS NULL")
            If ResultadoVehiculos IsNot Nothing
                If ResultadoVehiculos.Rows.Count > 0
                    DataGridVehiculos.DataSource = ResultadoVehiculos
                Else
                    MsgBox("No hay ningun vehiculo en el puerto.")
                    btAceptar.Enabled = False
                End If
            Else
                MsgBox("No hay ningun vehiculo en el puerto.")
                btAceptar.Enabled = False
            End If

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al cargar vehiculos")
        End Try
    End Sub
End Class
