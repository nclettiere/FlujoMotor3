Imports Logica

Public Class Agregar_Lote

    Private ParentFormClass As Vehiculos
    Private FacadeRef As Facade
    Private DisplayVin As String


    Friend Sub cargar(vehiculos As Vehiculos, facade As Facade)
        ParentFormClass = vehiculos
        FacadeRef = facade
    End Sub

    '' Lista de vin's seleccionados
    Private Seleccion As List(Of String)

    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btSeleccionar.Click
        Dim SelecVehiculo = New SeleccionarVehiculos()
        SelecVehiculo.cargar(Me, FacadeRef)
        SelecVehiculo.ShowDialog()
    End Sub

    Friend Sub CargarSelecciones(lista As List(Of String))
        Seleccion = lista
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Try
            Dim LoteId As Integer = FacadeRef.GenerateLoteID()
            Dim LoteNombre As String = txtNombre.Text
            Dim LoteDesc As String = rch_desc.Text

            If String.IsNullOrEmpty(txtNombre.Text) Then
                MessageBox.Show("El campo NOMBRE no puede estar vacio.")
            ElseIf String.IsNullOrEmpty(rch_desc.Text) Then
                MessageBox.Show("La descipcion no puede estar vacia.")
            ElseIf String.IsNullOrWhiteSpace(LoteNombre) Then
                MessageBox.Show("Elije un nombre para el lote.")
            ElseIf String.IsNullOrWhiteSpace(LoteDesc) Then
                MessageBox.Show("Elije una descripcion para el lote.")
            Else
                Dim LoteGenerado = New Lote(LoteId,
                                    LoteNombre,
                                    LoteDesc,
                                    Seleccion,
                                    Now.Date.ToShortDateString,
                                    FacadeRef.Operario.OperarioID,
                                    tbx_rutaA.Text,
                                    tbx_rutaB.Text)

                FacadeRef.AgregarLote(LoteGenerado)
                If Not Seleccion Is Nothing Then
                    If Not Seleccion.Count = 0 Then
                        For Each vin As String In Seleccion
                            Dim UbicacionID As Integer = FacadeRef.BuscarVinEnLista(vin).UbicacionID
                            FacadeRef.ObtenerUbicacion(UbicacionID).Status = "A Espera de Inspeccion."
                            ParentFormClass.ActualizarListaVehiculos()
                            ParentFormClass.ActualizarListaLotes()
                        Next
                        Me.Close()
                    Else
                        MessageBox.Show("No has seleccionado ningun vehiculo.")
                    End If
                Else
                    MessageBox.Show("No has seleccionado ningun vehiculo.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error Al Agregar Lote.\n" + ex.Message)
        End Try
    End Sub
End Class