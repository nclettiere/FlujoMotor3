Imports Logica

Public Class VerViajes

    Private IdSeleccionado As String
    Private NombreSeleccionado As String

    Private Sub OnViajesLOad(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewLotes.DataSource = LObtenerAllFitro("lotefechasalida IS NOT NULL AND lotefechallegada IS NULL AND transportistaid IS NOT NULL")
    End Sub

    Private Sub BtEntregar_Click(sender As Object, e As EventArgs) Handles btEntregar.Click
        Dim DialogoLavado As DialogResult = MessageBox.Show("Deseas terminar el viaje para el lote: ID=" + IdSeleccionado +"?", "Terminar Viaje", MessageBoxButtons.YesNo)
        If DialogoLavado = DialogResult.Yes
            LUpdateFechaLlegada(Now, IdSeleccionado)

            MessageBox.Show("El lote ha sido entregado con exitoso exito mi lord.")
            DataGridViewLotes.DataSource = LObtenerAllFitro("lotefechasalida IS NOT NULL AND lotefechallegada IS NULL AND transportistaid IS NOT NULL")
        End If
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridViewLotes.SelectionChanged
        if DataGridViewLotes.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridViewLotes.SelectedRows(0)
            IdSeleccionado = fila.Cells("loteid").Value.ToString
            NombreSeleccionado = fila.Cells("lotenombre").Value.ToString
        End If
    End Sub
End Class
