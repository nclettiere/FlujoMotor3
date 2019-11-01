Imports Logica

Public Class ModificarLote
    Friend LoteId As String

    Friend UC_VerLote As VerLotes

    Private VINSelected As String

    Friend Sub CargarDatos()
        Dim LoteDatos = LObtenerID(LoteId)

        If LoteDatos IsNot Nothing
            Try
                tbxLoteId.Text = LoteId
                tbxLoteNombre.Text = LoteDatos.Item("loteNombre")
                RCHtbxDesc.Text = LoteDatos.Item("loteDescripcion")

                Dim Patios = PObtenerAll

                Dim PatioSeleccionado As String = String.Empty
                If Patios IsNot Nothing
                    For Each Patio In Patios.Rows
                        cbxPatio.Items.Add(Patio.Item("PatioNombre"))

                        If Patio.Item("PatioId") = LoteDatos.Item("PatioId")
                            PatioSeleccionado = Patio.Item("PatioNombre")
                        End If
                    Next
                End If

                cbxPatio.SelectedText = PatioSeleccionado

                ActualizarListaVehiculos
            Catch ex As Exception
                Serilog.Log.Error(ex, "er..")
            End Try
        End If
    End Sub

    Friend Sub AgregarALote(vinSeleccionado As String)
        Try
            If VUpdateLoteId(LoteId, vinSeleccionado)
                MsgBox("Vehiculo agregado correctamente.")
            Else
                MsgBox("Ocurrio un error al agregar vehiculo.")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al agregar vehiculo.")
            Serilog.Log.Error(ex, "err...")
        End Try

        ActualizarListaVehiculos
    End Sub

    Private Sub ModificarLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAgVehiculo_Click(sender As Object, e As EventArgs) Handles btnAgVehiculo.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim SV As SelecVehiculo = New SelecVehiculo
        SV.CargarDatos(Nothing)
        SV.UC_ModificarLote = Me
        Ventana.LoadControl(SV)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try 
            VUpdateLoteId("NULL", VINSelected)
        Catch ex As Exception
            MsgBox(ex)
            Serilog.Log.Error(ex, "err..")
        End Try

        Try

        Catch ex As Exception
            Serilog.Log.Error(ex, "err..")
        End Try

        ActualizarListaVehiculos
    End Sub

    Private Sub ActualizarListaVehiculos
        Try
            listaVehiculos.DataSource = Nothing
            Dim VehiculosEnLote = VObtenerLoteId(LoteId)
            ListaVehiculos.DataSource = VehiculosEnLote

            For Each column As ColumnHeader In ListaVehiculos.Columns
                column.Width = -2
            Next
        Catch ex As Exception
            Serilog.Log.Error(ex, "err..")
        End Try
    End Sub

    Private Sub ListaVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaVehiculos.SelectedIndexChanged
        If ListaVehiculos.SelectedIndex >= 0
            VINSelected = ListaVehiculos.SelectedItem.SubItems.Item(0).Text
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If Not String.IsNullOrWhiteSpace(tbxLoteNombre.Text)
            If Not String.IsNullOrWhiteSpace(RCHtbxDesc.Text)
                If cbxPatio.SelectedIndex >= 0

                    Dim PatioInfo = PObtenerNombre(cbxPatio.Text)

                    If LUpdate(LoteId, tbxLoteNombre.Text, RCHtbxDesc.text, PatioInfo.Item("PatioId"))
                        MsgBox("Lote Actualizado exitosamente.")
                        If UC_VerLote IsNot Nothing
                            UC_VerLote.ActualizarLista(tbxLoteNombre.Text, RCHtbxDesc.text, PatioInfo.Item("PatioNombre"))
                        End If
                    
                        ParentForm.Close
                    End If
                Else
                    MsgBox("Debes Seleccionar un patiesito")
                End If
            Else
                MsgBox("La descripcion no debe quedar vacia")
            End If
        Else
            MsgBox("El nombre no debe quedar vacio")
        End If
    End Sub
End Class
