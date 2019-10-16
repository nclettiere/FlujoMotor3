Imports Logica
Public Class AgregarVehiculo

    Private LoteIngresado As Boolean = False
    Private PreLote As Boolean = False
    Friend LoteId As String

    Friend UC_VehiculosLotes As VehiculosLotes

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckFields
            If VCheckVIN(tbxVin.Text) = 0
                Dim VIN As String = tbxVin.Text
                Dim Marca As String = tbxMarca.Text
                Dim Modelo As String = tbxModelo.Text
                Dim Color As String = tbxColor.Text
                Dim Tipo As String = cbxTipo.Text
                Dim Anio As String = VehiculoAno.Value.Year.ToString

                If Not (String.Equals("SUV", cbxTipo.Text))
                    Tipo = cbxTipo.Text.ToLower()
                End If

               If LoteIngresado
                    VInsertar(VIN, Marca, Modelo, Color, Tipo, Anio, Me.LoteId, 1)
                ElseIf PreLote
                    ''LInsertar()
                    VInsertar(VIN, Marca, Modelo, Color, Tipo, Anio, Me.LoteId, 1)
                Else
                    VInsertar(VIN, Marca, Modelo, Color, Tipo, Anio, 1)
               End If
            Else
                MsgBox("Ya eiste un vehiculo con ese VIN.")
            End If
        End If
    End Sub

    Private Function CheckFields() As Boolean
        If Not String.IsNullOrWhiteSpace(tbxVin.Text)
            If tbxVin.Text.Length = 17
                If cbxTipo.SelectedIndex >= 0
                    If Not String.IsNullOrWhiteSpace(tbxMarca.Text)
                        If Not String.IsNullOrWhiteSpace(tbxModelo.Text)
                            If Not VehiculoAno.Value.Year > Now.Year And Not VehiculoAno.Value.Year < 1808
                                If Not String.IsNullOrWhiteSpace(tbxColor.Text)
                                    Return True
                                Else
                                    MessageBox.Show("El campo color no debe quedar vacio.")
                                    Return False
                                End If
                            Else
                                MessageBox.Show("No podes viajar en el tiempo.")
                                Return False
                            End If
                        Else
                            MessageBox.Show("El campo modelo no debe quedar vacio.")
                            Return False
                        End If
                    Else
                        MessageBox.Show("El campo marca no debe quedar vacio.")
                        Return False
                    End If
                Else
                    MessageBox.Show("Debes seleccionar el tipo de vehiculo.")
                    Return False
                End If
            Else
                MessageBox.Show("El campo VIN debe tener 17 caracteres.")
                Return False
            End If
        Else
            MessageBox.Show("El campo VIN no debe estar vacio.")
            Return False
        End If
    End Function

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        VehiculoAno.Format = DateTimePickerFormat.Custom
        VehiculoAno.CustomFormat = "yyyy"
        VehiculoAno.ShowUpDown = True
        cbxTipo.SelectedIndex = 0
    End Sub

    Private Sub BtnLnew_Click(sender As Object, e As EventArgs) Handles btnLnew.Click
        LoteIngresado = True
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgLote As AgregarLote = New AgregarLote
        AgLote.UC_AgregarVehiculo = Me
        Ventana.LoadControl(AgLote)
        Ventana.ShowDialog
    End Sub

    Friend Sub CargarLoteNuevo(LoteId As String, PreLote As Boolean)
        Me.LoteId = LoteId
        btnQuitarLote.Visible = True
        Me.PreLote = PreLote
    End Sub

    Private Sub BtnExist_Click(sender As Object, e As EventArgs) Handles btnExist.Click
        LoteIngresado = True
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim SelecLote As SeleccionarLote = New SeleccionarLote
        SelecLote.UC_AgregarVehiculo = Me
        SelecLote.TipoLista = 1
        Ventana.LoadControl(SelecLote)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnQuitarLote_Click(sender As Object, e As EventArgs) Handles btnQuitarLote.Click
        LoteIngresado = False
        PreLote = False
        LoteId = Nothing
        btnQuitarLote.Visible = False
    End Sub
End Class
