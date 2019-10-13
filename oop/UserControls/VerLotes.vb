Imports Logica

Public Class VerLotes
    Private Shared _instance As VerLotes

    Public Shared Property Instance As VerLotes
        Get
            If _instance Is Nothing Then
                _instance = New VerLotes()
            End If
            Return _instance
        End Get
        Set(value As VerLotes)
            _instance = value
        End Set
    End Property

    Private Property LoteId As String
    Private Property VinSeleccionado As String

    Friend Sub Data(loteid As String)
        Me.LoteId = loteid
        CargarDatos()
    End Sub

    Private Sub CargarDatos()   
        Try
            Dim ListaVehiculos As DataTable = VObtenerLoteId(LoteId)

            Dim Lote = LObtenerID(LoteId)

            If ListaVehiculos IsNot Nothing
                DataGridViewVehiculos.DataSource = ListaVehiculos
            End If

            If Lote IsNot Nothing
                Dim Patio = PObtenerID(Lote.Item("patioid").ToString)
                If Patio IsNot Nothing
                    lblPatio.Text = Patio.Item("pationombre")
                End If

                
                labId.Text = Lote.Item("loteid")

                Try
                    lblFechaSalida.Text = Lote.Item("lotefechasalida")
                    lblFechaLlegada.Text = Lote.Item("lotefechallegada")
                Catch ex As Exception
                    Serilog.Log.Warning(ex, "Error al obtener fecha salida/llegada.")
                End Try
                riTeBoDescripcion.Text = Lote.Item("lotedescripcion")
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error Al listar vehiculo o lote. ref Ver_Lote.vb")
        End Try
    End Sub

    Friend Sub AgregarVehiculo(vinSeleccionado As String)
        Try
            VUpdateLoteId(LoteId, vinSeleccionado)
            MessageBox.Show("Vehiculo Agregado Correctamente.")
            Dim ListaVehiculos As DataTable = VObtenerLoteId(LoteId)
            DataGridViewVehiculos.DataSource = ListaVehiculos
        Catch ex As Exception
            MessageBox.Show("HUubvo un error inesperadamente inesperado. Chequee el log. Zapallo.")
            Serilog.Log.Error(ex, "Error al agregar vehiculo a lote.")
        End Try
    End Sub

    Private Sub BtnEntregar_Click_1(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim result As Integer = MessageBox.Show("Los transportistas se encargaran de movilizar el lote.", "Desea entregar el lote?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                LUpdateFechaSalida(Now.ToString("yyyy-MM-dd hh:mm:ss"), LoteId)
                MessageBox.Show("Lote entregado correctamente.")
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al entregar lote.")
            End Try
        End If
    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        ParentForm.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If DataGridViewVehiculos.Rows.Count > 0
            btneliminar.Visible = True
        End If
        
        lblFechaLlegada.Visible = False
        lblFechaSalida.Visible = False
        DateTimeLlegada.Visible = True
        DateTimeSalida.Visible = True
        riTeBoDescripcion.ReadOnly = False
        btnEntregar.Enabled = False
        DataGridViewVehiculos.Enabled = False
        lblPatio.Visible = False
        cbxPatios.Visible = True
        btnModificar.Enabled = False
        btnMod.Visible = True
        dateTimeLlegada.Format = DateTimePickerFormat.Custom
        dateTimeSalida.Format = DateTimePickerFormat.Custom
        dateTimeLlegada.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        dateTimeSalida.CustomFormat = "yyyy-MM-dd HH:mm:ss"

        Try
            Dim ConsultaPatios = PObtenerAll()
            If ConsultaPatios IsNot Nothing
                If ConsultaPatios.Rows.Count > 0
                    Dim contador As Integer = 1
                    Dim index As Integer = 1
                    Dim Lote = LObtenerID(LoteId)
                    Dim PatioLote = PObtenerID(Lote.Item("patioid"))

                    For Each item As DataRow in ConsultaPatios.Rows()
                        cbxPatios.Items.Add(item.Item("pationombre"))
                        If String.Equals(item.Item("pationombre"), PatioLote.Item("pationombre"))
                            index = contador
                        End If
                        Contador += 1
                    Next

                    Try
                        cbxPatios.SelectedIndex = (index - 1)
                    Catch ex As Exception
                        Serilog.Log.Warning(ex, "No se pudo setear cbxpatio. Hay patios ingresados en la db?")
                    End Try

                    Try
                        DateTimeLlegada.Value = DateTime.ParseExact(Lote.Item("lotefechallegada").ToString, "yyyy-MM-dd HH:mm:ss", Nothing)
                        DateTimeSalida.Value = DateTime.ParseExact(Lote.Item("lotefechasalida").ToString, "yyyy-MM-dd HH:mm:ss", Nothing)
                    Catch ex As Exception
                        Serilog.Log.Warning(ex, "No se pudo setear DateTimeLlegada/Salida. Chequee el formato de las fechas.")
                    End Try
                End If
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al obtener patios")
        End Try

    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim Lote = LObtenerID(LoteId)
            Dim PatioLote = PObtenerNombre(cbxPatios.Text)

            If Not String.Equals(Lote.Item("patioid").ToString, PatioLote.Item("patioid").ToString)
                LUpdatePatio(PatioLote.Item("patioid"), LoteId)
            End If

            If Not String.Equals(Lote.Item("lotedescripcion").ToString, riTeBoDescripcion.Text)
                LUpdateDesc(riTeBoDescripcion.Text, LoteId)
            End If

            LUpdateFechas(DateTimeLlegada.Value.ToString, DateTimeSalida.Value.ToString, LoteId)

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al modificardatos.")
        End Try

        btneliminar.Visible = False
        lblFechaLlegada.Visible = True
        lblFechaSalida.Visible = True
        DateTimeLlegada.Visible = False
        DateTimeSalida.Visible = False
        riTeBoDescripcion.ReadOnly = True
        btnEntregar.Enabled = True
        DataGridViewVehiculos.Enabled = True
        lblPatio.Visible = True
        cbxPatios.Visible = False
        btnModificar.Enabled = True
        btnMod.Visible = False

        CargarDatos()
    End Sub

    Private Sub BtnAgregarVehiculo_Click(sender As Object, e As EventArgs) Handles btnAgregarVehiculo.Click
        Dim VentanaVerControl As Ventana_Ver = New Ventana_Ver
        Dim SelecVehiculo As SelecVehiculo = New SelecVehiculo
        SelecVehiculo.CargarDatos(Me)
        VentanaVerControl.LoadControl(SelecVehiculo)
        VentanaVerControl.ShowDialog
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As Integer = MessageBox.Show("Deseas eliminar "+ VinSeleccionado +" del lote?", "Desea eliminar el vehiculo?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                VUpdateLote("NULL", VinSeleccionado)
                MessageBox.Show("Vehiculo eliminado correctamente.")
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al eliminar vehiculo.")
            End Try
        End If
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridViewVehiculos.SelectionChanged
        if DataGridViewVehiculos.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridViewVehiculos.SelectedRows(0)
            VinSeleccionado = fila.Cells("vehiculovin").Value
            btneliminar.Enabled = True
        Else
            btneliminar.Enabled = False
        End If
    End Sub
End Class
