Public Class Editar_Lotesillo
    Private Sub Editar_Lotesillo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Los checbocs
        If cheBoClientes.CheckState = CheckState.Checked Then
            btSeleccionarCliente.Enabled = True
            labClientes.Enabled = True
        End If
        If cheBoDescripcion.CheckState = CheckState.Checked Then
            riTeBoDescripcion.Enabled = True
            labDescripcion.Enabled = True
        End If
        If cheBoNombre.CheckState = CheckState.Checked Then
            txtID.Enabled = True
            labID.Enabled = True
        End If
        If cheBoVehiculos.CheckState = CheckState.Checked Then
            btSeleccionarVehiculo.Enabled = True
            labVehiculos.Enabled = True
        End If
        If cheBoRutaF.CheckState = CheckState.Checked Then
            txtRutaFinal.Enabled = True
            labRutaF.Enabled = True
        End If
        If cheBoRutaI.CheckState = CheckState.Checked Then
            txtRutaInicial.Enabled = True
            labRutaI.Enabled = True
        End If

    End Sub
End Class
