Imports Logica
Public Class AgregarVehiculo

    Private LoteIngresado As Boolean = False
    Private LoteModificado As Boolean = False
    Private PreLote As Boolean = False
    Private Insertar As Action
    Friend LoteId As String

    Friend VINmodificacion As String

    Private Desc As String
    Private Nombre As String
    Private OpId As Integer
    Private Patio As String


    Private Modo As Integer = 0

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

                MsgBox("VInsertar("+VIN+", "+Marca+", "+Modelo+", "+Color+", "+Tipo+", "+Anio+", "+Me.LoteId+", 1")

               If LoteIngresado
                   If VInsertar(VIN.ToUpper, Marca, Modelo, Color, Tipo, Anio, Me.LoteId, ObtenerOpId)
                        IInsertar(VIN.ToUpper, ObtenerOpId)
                        MsgBox("Vehiculo Insertado Exitosamente.")
                        UC_VehiculosLotes.ActualizarVehiculos
                        ParentForm.Close
                   End If
                ElseIf PreLote
                    If LInsertar(Desc, Nombre, OpId.ToString, Patio)
                        Me.LoteId = (Consultar("SELECT MAX(loteid) FROM lotes").Rows(0).Item(0)).ToString
                        If VInsertar(VIN.ToUpper, Marca, Modelo, Color, Tipo, Anio, Me.LoteId, 1)
                            IInsertar(VIN.ToUpper, ObtenerOpId)
                            MsgBox("Vehiculo y Lote Insertados Exitosamente.")
                            UC_VehiculosLotes.ActualizarVehiculos
                            ParentForm.Close
                        Else
                            MsgBox("No se pudo insertar vehiuclo.")
                        End If
                    Else
                        MsgBox("No se pudo insertar lote.")
                    End If
                Else
                    If VInsertar(VIN.ToUpper, Marca, Modelo, Color, Tipo, Anio, 1)
                        IInsertar(VIN.ToUpper, ObtenerOpId)
                        MsgBox("Vehiculo Insertado Exitosamente.")
                        UC_VehiculosLotes.ActualizarVehiculos
                        ParentForm.Close
                    End If
               End If
            Else
                MsgBox("Ya eiste un vehiculo con ese VIN.")
            End If
        End If
    End Sub

    Friend Sub CambiarLote(idSeleccionado As String, v As Boolean)
        LoteModificado = True
        Me.LoteId = idSeleccionado
        lblLotedesc.Text = "Lote Id = "+ LoteId
        btnQuitarLote.Visible = True
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
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgLote As AgregarLote = New AgregarLote
        AgLote.UC_AgregarVehiculo = Me
        Ventana.LoadControl(AgLote)
        Ventana.ShowDialog
    End Sub

    Friend Sub CargarLoteNuevo(LoteId As String, PreLote As Boolean)
        LoteIngresado = True
        Me.LoteId = LoteId
        btnQuitarLote.Visible = True
        Me.PreLote = false
    End Sub

    Friend Sub CargarLoteNuevo(LoteId As String, PreLote As Boolean, Desc As String, Nombre As String, OpId As Integer, Patio As String)
        Me.LoteId = LoteId
        btnQuitarLote.Visible = True
        Me.PreLote = PreLote
        Me.Insertar = Insertar

        Me.Desc = Desc
        Me.Nombre = Nombre
        Me.OpId = OpId
        Me.Patio = Patio
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
        If Not LoteModificado
            LoteIngresado = False
            PreLote = False
            LoteId = Nothing
            btnQuitarLote.Visible = False
        Else
            lblLotedesc.Text = "Lote (Opcional)"
            LoteIngresado = False
            PreLote = False
            LoteId = Nothing
            btnQuitarLote.Visible = False

            btncambiarlote.Visible = False
            btnremover2.Visible = False
            btnLnew.Visible = True
        End If
    End Sub

    Friend Sub CargarModificacion(VIN As String)
        Modo = 1
        btnmod.Visible = True
        lblmodagr.Text = "Modificar Vehiculo"
        tbxVin.Enabled = False
        Try
            Dim VDatos As DataRow = VObtenerVIN(VIN)
            If VDatos IsNot Nothing
                tbxVin.Text = VIN
                Me.VINmodificacion = VIN
                tbxMarca.Text = VDatos.Item("vehiculomarca")
                tbxModelo.Text = VDatos.Item("vehiculomodelo")
                tbxColor.Text = VDatos.Item("vehiculocolor")
                cbxTipo.SelectedText = VDatos.Item("vehiculoTipo")
                VehiculoAno.Value = new DateTime(VDatos.Item("vehiculoanio"),05,28)

                Try
                    If Not String.IsNullOrEmpty(VDatos.Item("loteid").ToString)
                        lblLotedesc.Text = "Lote Id = "+ VDatos.Item("loteid").ToString
                        Me.LoteId = VDatos.Item("loteid").ToString
                        btnremover2.Visible = True
                        btncambiarlote.Visible = True
                    Else
                        Me.LoteId = Nothing
                    End If
                Catch ex As Exception
                    Me.LoteId = Nothing
                End Try
                    
  
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Err...")
        End Try
    End Sub

    Private Sub Btncambiarlote_Click(sender As Object, e As EventArgs) Handles btncambiarlote.Click
        LoteIngresado = True
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim SelecLote As SeleccionarLote = New SeleccionarLote
        SelecLote.UC_AgregarVehiculo = Me
        SelecLote.TipoLista = 1
        SelecLote.Modo = 1
        Ventana.LoadControl(SelecLote)
        Ventana.ShowDialog
    End Sub

    Private Sub Btnremover2_Click(sender As Object, e As EventArgs) Handles btnremover2.Click
        lblLotedesc.Text = "Lote (Opcional)"
        LoteIngresado = False
        PreLote = False
        LoteId = Nothing
        btnQuitarLote.Visible = False
        
        btncambiarlote.Visible = False
        btnremover2.Visible = False
        btnLnew.Visible = True
    End Sub

    Private Sub Btnmod_Click(sender As Object, e As EventArgs) Handles btnmod.Click
        If CheckFields
            If LoteId IsNot Nothing
                VUpdateLote(LoteId, VINmodificacion)
            Else
                VUpdateLote("NULL", VINmodificacion)
            End If

             Dim VIN As String = tbxVin.Text
             Dim Marca As String = tbxMarca.Text
             Dim Modelo As String = tbxModelo.Text
             Dim Color As String = tbxColor.Text
             Dim Tipo As String = cbxTipo.Text
             Dim Anio As String = VehiculoAno.Value.Year.ToString

             If Not (String.Equals("SUV", cbxTipo.Text))
                 Tipo = cbxTipo.Text.ToLower()
             End If

             If VUpdate(VINmodificacion, Marca, Modelo, Color, Tipo, Anio)
                MsgBox("Vehiculo Actualizado Correctamente.")
             End If
        End If
    End Sub
End Class
