Imports Logica

Public Class InfoLotes

    Private IdSeleccionado As String
    Private NombreSeleccionado As String

    Private Sub OnInfoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DataGridViewLotes.DataSource = LObtenerAllTransportista(ObtenerOpId)
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al cargar lotes")
        End Try
    End Sub

    Private Sub LoteCambioSeleccion(sender As Object, e As EventArgs) Handles DataGridViewLotes.SelectionChanged
        If DataGridViewLotes.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridViewLotes.SelectedRows(0)
            IdSeleccionado = fila.Cells("loteid").Value.ToString
            NombreSeleccionado = fila.Cells("lotenombre").Value.ToString
        End If
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) 
        Dim DialogoLavado As DialogResult = MessageBox.Show("Deseas iniciar el viaje para el lote: ID=" + IdSeleccionado + " Nombre=" + NombreSeleccionado + "?", "Iniciar Viaje", MessageBoxButtons.YesNo)
        If DialogoLavado = DialogResult.Yes
            LUpdateTransportista("5", IdSeleccionado)

            MessageBox.Show("Se ha aniadido el lote a sus viajes lord.")
            DataGridViewLotes.DataSource = LObtenerAllFitro("lotefechasalida IS NOT NULL AND lotefechallegada IS NULL AND transportistaid IS NULL")
        End If
    End Sub
End Class
