Imports Logica

Public Class VehiculosLotes
    Private Sub OnVLload(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            listaVehiculos.DataSource = VObtenerAll

            For Each column As ColumnHeader In listaVehiculos.Columns
                column.Width = -2
            Next
        Catch ex As Exception
            MsgBox("Error Al obtener vehiculos")
            Serilog.Log.Error(ex, "Error Al obtener vehiculos")
        End Try
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles listaVehiculos.SelectedIndexChanged
        Try
            If listaVehiculos.SelectedIndex >= 0
                btnElim.Enabled = True
                btnInsp.Enabled = True
                btnLavado.Enabled = True
                btnMngLote.Enabled = True
                btnMod.Enabled = True

                '' Obtener Datos
                Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
                Dim OpDatos As DataRow = EObtener(listaVehiculos.SelectedItem.SubItems.Item(8).Text)
                Dim Fecha As String = listaVehiculos.SelectedItem.SubItems.Item(1).Text
                Dim FechaVendido As String = listaVehiculos.SelectedItem.SubItems.Item(2).Text
                Dim Lote As String = listaVehiculos.SelectedItem.SubItems.Item(9).Text

                lblVin.Text = "VIN: "+ VIN
                lblOpIngresado.Text = "Ingresado Por:" + OpDatos.Item("empleadonombre") + " " + OpDatos.Item("empleadoapellido")

                lblFecha.Text = "Ingresado el: " + Fecha

                If String.IsNullOrEmpty(Lote)
                    lbllote.Text = "Lote: - "
                    lblLoteStatus.Visible = False
                Else
                    lbllote.Text = "Lote: SI - Lote id: "+ Lote
                    lblLoteStatus.Visible = True
                End If
            Else
                btnElim.Enabled = False
                btnInsp.Enabled = False
                btnLavado.Enabled = False
                btnMngLote.Enabled = False
                btnMod.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAgrVehculo_Click(sender As Object, e As EventArgs) Handles btnAgrVehculo.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgVehiculo As AgregarVehiculo = New AgregarVehiculo
        AgVehiculo.UC_VehiculosLotes = Me
        Ventana.LoadControl(AgVehiculo)
        Ventana.ShowDialog
    End Sub
End Class
