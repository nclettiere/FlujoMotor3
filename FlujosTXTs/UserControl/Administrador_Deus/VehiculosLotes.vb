Imports System.Drawing.Imaging
Imports System.IO
Imports Logica

Public Class VehiculosLotes

    Private LoteIdSelec As String

    Private Sub OnVLload(sender As Object, e As EventArgs) Handles MyBase.Load
        listaVehiculos.VirtualListSize = Integer.MaxValue
        ActualizarVehiculos
        cbxEstado.SelectedIndex = 0
    End Sub

    Private TipoBusqueda As Integer = 0

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles listaVehiculos.SelectedIndexChanged
        Try
            If listaVehiculos.SelectedIndex >= 0
                btnElim.Enabled = True
                btnMod.Enabled = True

                '' Obtener Datos
                Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
                Dim OpDatos As DataRow = EObtener(listaVehiculos.SelectedItem.SubItems.Item(8).Text)
                Dim Fecha As String = listaVehiculos.SelectedItem.SubItems.Item(1).Text
                Dim FechaVendido As String = listaVehiculos.SelectedItem.SubItems.Item(2).Text
                Dim Lote As String = listaVehiculos.SelectedItem.SubItems.Item(9).Text

                If VEstaEnPatio(VIN)
                    btnAparcar.Enabled = True
                    btnVender.Enabled = True
                Else
                    btnAparcar.Enabled = False
                    btnVender.Enabled = False
                End If

                lblVin.Text = "VIN: " + VIN
                lblOpIngresado.Text = "Ingresado Por:" + OpDatos.Item("empleadonombre") + " " + OpDatos.Item("empleadoapellido")

                lblFecha.Text = "Ingresado el: " + Fecha

                If String.IsNullOrEmpty(Lote)
                    lbllote.Text = "Lote: - "
                    btnMngLote.Enabled = False
                    btnLavado.Enabled = False
                Else
                    lbllote.Text = "Lote: SI - Lote id: " + Lote
                End If

                PbQR.BackgroundImage = GenerarQR(VIN, Nothing)
            Else
                btnElim.Enabled = False
                btnInsp.Enabled = False
                btnLavado.Enabled = False
                btnMngLote.Enabled = False
                btnMod.Enabled = False
                btnAparcar.Enabled = False
            End If

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error desconocido.")
        End Try
    End Sub

    Friend Sub AgregarALote(vinSeleccionado As String)
        Try
            If VUpdateLoteId(LoteIdSelec, vinSeleccionado)
                MsgBox("Vehiculo agregado correctamente.")
            Else
                MsgBox("Ocurrio un error al agregar vehiculo.")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al agregar vehiculo.")
            Serilog.Log.Error(ex, "err...")
        End Try
        ActualizarLV
    End Sub

    Friend Sub ActualizarLV()
        Try
            listaLV.DataSource = VObtenerLoteId(LoteIdSelec)
            For Each column As ColumnHeader In listaLV.Columns
                column.Width = -2
            Next
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub TransportistaSeleccionado(eID As String)
        Dim result As Integer = MessageBox.Show("El lote quedara como completo y el transportista se encargara de entregarlo al patio correspondiente.", "Desea asignar el lote?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim ID As String = ListaLotes.SelectedItem.SubItems.Item(0).Text
                LUpdateFechaSalida(Now.ToString("yyyy-MM-dd hh:mm:ss"), ID)
                LUpdateTransportista(eID, ID)
                ActualizarLotes
                MessageBox.Show("Lote entregado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error al asignar lote, Chequee el log para mas info.")
                Serilog.Log.Error(ex, "Error al entregar lote.")
            End Try
        End If
    End Sub

    Private Sub BtnAgrVehculo_Click(sender As Object, e As EventArgs) Handles btnAgrVehculo.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgVehiculo As AgregarVehiculo = New AgregarVehiculo
        AgVehiculo.UC_VehiculosLotes = Me
        Ventana.LoadControl(AgVehiculo)
        Ventana.ShowDialog
    End Sub

    Friend Sub ActualizarVehiculos
        Try
            listaVehiculos.DataSource = Nothing
            listaVehiculos.DataSource = VObtenerAll

            For Each column As ColumnHeader In listaVehiculos.Columns
                column.Width = -2
            Next
        Catch ex As Exception
            MsgBox("Error Al obtener vehiculos")
            Serilog.Log.Error(ex, "Error Al obtener vehiculos")
        End Try
    End Sub

    Friend Sub ActualizarLotes
        Try
            ListaLotes.DataSource = Nothing
            ListaLotes.DataSource = LObtenerAll

            For Each column As ColumnHeader In ListaLotes.Columns
                column.Width = -2
            Next
        Catch ex As Exception
            MsgBox("Error Al obtener lotes")
            Serilog.Log.Error(ex, "Error Al obtener lotes")
        End Try
    End Sub

    Friend Sub ActualizarVehiculos(dv As DataView)
        Try
            listaVehiculos.DataSource = Nothing
            listaVehiculos.DataSource = dv

            For Each column As ColumnHeader In listaVehiculos.Columns
                column.Width = -2
            Next
        Catch ex As Exception
            MsgBox("Error Al obtener vehiculos")
            Serilog.Log.Error(ex, "Error Al obtener vehiculos")
        End Try
    End Sub


    Private Sub BtnElim_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
        Dim result As Integer = MessageBox.Show("Deseas eliminar el vehiculo '" + VIN + "' permanentemente?", "Eliminar Vehiculo", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If VEliminar(VIN)
                ActualizarVehiculos
            End If
            ActualizarVehiculos
        End If
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgVehiculo As AgregarVehiculo = New AgregarVehiculo
        Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
        AgVehiculo.CargarModificacion(VIN)
        AgVehiculo.UC_VehiculosLotes = Me
        Ventana.LoadControl(AgVehiculo)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnInsp_Click(sender As Object, e As EventArgs) Handles btnInsp.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim VerIns As VerInspeccion = New VerInspeccion
        Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
        VerIns.Populate(VIN)
        Ventana.LoadControl(VerIns)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Try
            Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
            If VMarcarVendido(VIN)
                MessageBox.Show("Vehiculo vendido exitosamente.")
                ActualizarVehiculos
            End If
        Catch ex As Exception
            MsgBox("Error al vender makako")
            Serilog.Log.Error(ex, "err")
        End Try
    End Sub

    Private Sub BtnAparcar_Click(sender As Object, e As EventArgs) Handles btnAparcar.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim Aparcar As AparcarVehiculo = New AparcarVehiculo
        Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
        Aparcar.VIN = (VIN)
        Try
            Dim PatioId = LObtenerID(listaVehiculos.SelectedItem.SubItems.Item(9).Text).Item("patioid").ToString
            Aparcar.PatioId = PatioId
            Ventana.LoadControl(Aparcar)
            Ventana.ShowDialog
        Catch ex As Exception
            MessageBox.Show("Error al obtener patioid.")
            Serilog.Log.Error(ex, "err..")
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1
            ActualizarLotes
        End If
    End Sub

    Private Sub ListaLotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaLotes.SelectedIndexChanged
        Try
            If ListaLotes.SelectedIndex >= 0
                btnElimL.Enabled = True

                '' Obtener Datos
                Dim ID As String = ListaLotes.SelectedItem.SubItems.Item(0).Text
                LoteIdSelec = ID
                Dim loteNombre As String = ListaLotes.SelectedItem.SubItems.Item(1).Text
                Dim loteDescripcion As String = ListaLotes.SelectedItem.SubItems.Item(2).Text
                Dim operarioPuertoID As DataRow = EObtener(ListaLotes.SelectedItem.SubItems.Item(3).Text)
                Dim loteFecha As String = ListaLotes.SelectedItem.SubItems.Item(4).Text
                Dim patioid As String = ListaLotes.SelectedItem.SubItems.Item(8).Text
                Dim transid As String = ListaLotes.SelectedItem.SubItems.Item(7).Text
                Dim loteFechaSalida = ListaLotes.SelectedItem.SubItems.Item(5).Text
                Dim loteFechaLl = ListaLotes.SelectedItem.SubItems.Item(6).Text

                If String.IsNullOrEmpty(loteFechaSalida) And String.IsNullOrEmpty(loteFechaLl)
                    btnEntregarT.Enabled = True
                Else
                    btnEntregarT.Enabled = False
                End If

                If String.IsNullOrEmpty(loteFechaLl) And Not String.IsNullOrEmpty(loteFechaSalida)
                    btnEntreado.Enabled = True
                Else
                    btnEntreado.Enabled = False
                End If

                lblloteid.Text = "LoteId: " + ID
                lblopL.Text = "Ingresado Por:" + operarioPuertoID.Item("empleadonombre") + " " + operarioPuertoID.Item("empleadoapellido")
                lblLFecha.Text = "Fecha Ingresado: " + loteFecha

                Try
                    listaLV.DataSource = VObtenerLoteId(ID)
                    For Each column As ColumnHeader In listaLV.Columns
                        column.Width = -2
                    Next
                Catch ex As Exception

                End Try

            Else
                btnElimL.Enabled = False
                btnEntregarT.Enabled = False
                btnEntreado.Enabled = False
            End If

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error desconocido.")
        End Try
    End Sub

    Private Sub BtnEntregarT_Click(sender As Object, e As EventArgs) Handles btnEntregarT.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim Entre As SeleccionarTransportista = New SeleccionarTransportista
        Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
        Entre.VL_VehiculosLotes = Me
        Ventana.LoadControl(Entre)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnEntreado_Click(sender As Object, e As EventArgs) Handles btnEntreado.Click
        Try
            Dim ID As String = ListaLotes.SelectedItem.SubItems.Item(0).Text
            Dim DialogoLavado As DialogResult = MessageBox.Show("Deseas terminar el viaje para el lote: ID=" + ID + "?", "Terminar Viaje", MessageBoxButtons.YesNo)
            If DialogoLavado = DialogResult.Yes
                If LUpdateFechaLlegada(Now, ID)
                    MessageBox.Show("El lote ha sido entregado con exito.")
                End If
            End If
            ActualizarLotes
        Catch ex As Exception
            MsgBox("error al entregar")
            Serilog.Log.Error(ex, "err")
        End Try
    End Sub

    Private Sub BtnElimL_Click(sender As Object, e As EventArgs) Handles btnElimL.Click

    End Sub

    Private Sub ListaLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaLV.SelectedIndexChanged
        Try
            If listaLV.SelectedIndex >= 0
                btnagvl.Enabled = True
                Dim VIN As String = ListaLotes.SelectedItem.SubItems.Item(0).Text
                Dim fechaentrega = ListaLotes.SelectedItem.SubItems.Item(2)
                Dim loteid As String = LoteIdSelec

                If fechaentrega Is Nothing
                    btnquitarv.Enabled = True
                Else
                    btnquitarv.Enabled = False
                End If
            Else
                btnagvl.Enabled = False
                btnquitarv.Enabled = False
            End If

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error desconocido.")
        End Try
    End Sub

    Private Sub Btnagvl_Click(sender As Object, e As EventArgs) Handles btnagvl.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AGL As AgregarVehiculo = New AgregarVehiculo
        Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
        AGL.UC_VehiculosLotes = Me
        AGL.LoteId = LoteIdSelec
        AGL.Loteado = True
        Ventana.LoadControl(AGL)
        Ventana.ShowDialog
    End Sub

    Private Sub Btnquitarv_Click(sender As Object, e As EventArgs) Handles btnquitarv.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim guardar As SaveFileDialog = New SaveFileDialog()
        guardar.Filter = "Images|*.png;*.bmp;*.jpg"
        Dim formato As ImageFormat = ImageFormat.Png

        Dim VIN As String = listaVehiculos.SelectedItem.SubItems.Item(0).Text
        guardar.FileName = VIN

        If guardar.ShowDialog() = DialogResult.OK Then
            Dim extension As String = Path.GetExtension(guardar.FileName)

            Select Case extension
                Case ".jpg"
                    formato = ImageFormat.Jpeg
                Case ".bmp"
                    formato = ImageFormat.Bmp
            End Select

            PbQR.BackgroundImage.Save(guardar.FileName, formato)

            MsgBox("El QR se guardo exitosamente.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim SV As SelecVehiculo = New SelecVehiculo
        SV.UC_VehiculosLotes = Me
        Ventana.LoadControl(SV)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dv As DataView

        listaVehiculos.DataSource = Nothing

        Select cbxEstado.SelectedIndex
            Case 0
                dv = New DataView(VObtenerAll)
            Case 1
                dv = New DataView(VObtenerAllPuerto)
            Case 2
                dv = New DataView(VObtenerAllPatio)
            Case 3
                dv = New DataView(VObtenerAllTransportista)
            Case 4
                dv = New DataView(VObtenerAllVendidos)
            Case Else
                dv = New DataView(VObtenerAll)
        End Select

        Dim Loteid As Integer = Integer.Parse(tbxLoteid.Text)
        MsgBox(String.Format("vehiculovin LIKE '{0}' AND Loteid = {1}", tbxVIN.Text, Loteid))
        dv.RowFilter = String.Format("vehiculovin LIKE '%{0}%' AND Loteid = {1}", tbxVIN.Text, Loteid)
        ActualizarVehiculos(dv)
    End Sub

    Private Sub CbxEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEstado.SelectedIndexChanged

    End Sub
End Class
