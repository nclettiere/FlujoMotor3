Imports Logica

Public Class SelecVehiculo
    Private Property FormParent As VerLotes
    Private Property VinSeleccionado As String

    Friend UC_ModificarLote As ModificarLote

    Friend Sub CargarDatos(FormParent As VerLotes)
        Me.FormParent = FormParent

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

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        If UC_ModificarLote IsNot Nothing
            UC_ModificarLote.AgregarALote(VinSeleccionado)
        Else
            FormParent.AgregarVehiculo(VinSeleccionado)
        End If

        ParentForm.Close()
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridVehiculos.SelectionChanged
        if DataGridVehiculos.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridVehiculos.SelectedRows(0)
            VinSeleccionado = fila.Cells("vehiculovin").Value
        End If
    End Sub
End Class
