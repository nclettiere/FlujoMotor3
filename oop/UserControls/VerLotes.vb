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

    Friend IA_InfoAutos As InfoAutos

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

                lblnombre.Text = Lote.Item("loteNombre")
                
                labId.Text = Lote.Item("loteid")

                riTeBoDescripcion.Text = Lote.Item("lotedescripcion")
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error Al listar vehiculo o lote. ref Ver_Lote.vb")
        End Try
    End Sub

    Friend Sub TransportistaSeleccionado(eID As String)
        Dim result As Integer = MessageBox.Show("El lote quedara como completo y el transportista se encargara de entregarlo al patio correspondiente.", "Desea asignar el lote?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                LUpdateFechaSalida(Now.ToString("yyyy-MM-dd hh:mm:ss"), LoteId)
                LUpdateTransportista(eID, LoteId)
                If IA_InfoAutos IsNot Nothing
                    IA_InfoAutos.ActualizarVehiculos
                    IA_InfoAutos.ActualizarLotes
                End If
                MessageBox.Show("Lote entregado correctamente.")
                ParentForm.Close
            Catch ex As Exception
                MessageBox.Show("Error al asignar lote, Chequee el log para mas info.")
                Serilog.Log.Error(ex, "Error al entregar lote.")
            End Try
        End If
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
        Try
            Dim VehiculosEnLote = VObtenerLoteId(LoteId)
            If VehiculosEnLote IsNot Nothing
                If VehiculosEnLote.Rows.Count > 0
                    If VerificarVehiculosEntrega(LoteId)
                        Dim VentanaVerControl As Ventana_Ver = New Ventana_Ver
                        Dim SelecTransp As SeleccionarTransportista = New SeleccionarTransportista
                        SelecTransp.VL_VerLote = Me
                        VentanaVerControl.LoadControl(SelecTransp)
                        VentanaVerControl.Text = "Asignar Lote A Transportista"
                        VentanaVerControl.ShowDialog
                    End If
                Else
                    MsgBox("El lote no tiene ningun vehiculo. Agregue uno para continuar.")
                End If
            Else
                MsgBox("El lote no tiene ningun vehiculo. Agregue uno para continuar.")
            End If
        Catch ex As Exception
            MsgBox("Error inesperado.")
            Serilog.Log.Error(ex, "Error inesperado.")
        End Try
    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        ParentForm.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim ML As ModificarLote = New ModificarLote
        ML.UC_VerLote = Me
        ML.LoteId = LoteId
        ML.CargarDatos
        Ventana.LoadControl(ML)
        Ventana.ShowDialog
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

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al modificardatos.")
        End Try

        btneliminar.Visible = False
        DateTimeLlegada.Visible = False
        riTeBoDescripcion.ReadOnly = True
        btnEntregar.Enabled = True
        DataGridViewVehiculos.Enabled = True
        lblPatio.Visible = True
        cbxPatios.Visible = False
        btnModificar.Enabled = True
        btnMod.Visible = False

        CargarDatos()
    End Sub

    Private Sub BtnAgregarVehiculo_Click(sender As Object, e As EventArgs) 
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

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("VerLote", 0)
        lblID.Text = _Lang.ObtenerKey("VerLote", 1)
        lblpatio2.Text = _Lang.ObtenerKey("VerLote", 2)
        lbldesc.Text = _Lang.ObtenerKey("VerLote", 4)
        lblentregar.Text = _Lang.ObtenerKey("VerLote", 3)
        'lblNopmbre.Text = _Lang.ObtenerKey("VerLote", 5)
        lblVehiculos.Text = _Lang.ObtenerKey("VerLote", 7)

        btCerrar.Text = _Lang.ObtenerKey("VerLote", 11)
        btneliminar.Text = _Lang.ObtenerKey("VerLote", 13)
        btnEntregar.Text = _Lang.ObtenerKey("VerLote", 8)
        btnMod.Text = _Lang.ObtenerKey("VerLote", 12)
        btnModificar.Text = _Lang.ObtenerKey("VerLote", 10)
    End Sub

    Private Sub VerLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLang
    End Sub

    Friend Sub ActualizarLista(LNombre As String, LDesc As String, PNombre As String)
        Dim ListaVehiculos As DataTable = VObtenerLoteId(LoteId)
        DataGridViewVehiculos.DataSource = ListaVehiculos

        lblnombre.Text = LNombre
        riTeBoDescripcion.Text = LDesc
        lblPatio.Text = PNombre
    End Sub
End Class
