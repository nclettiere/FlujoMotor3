Imports Serilog
Imports Logica

Public Class InfoAutos

    Private Shared _instance As InfoAutos

    Public Shared Property Instance As InfoAutos
        Get
            If _instance Is Nothing Then
                _instance = New InfoAutos()
            End If
            Return _instance
        End Get
        Set(value As InfoAutos)
            _instance = value
        End Set
    End Property

    Public Property FormParent As MenuControl

    Private Property VinSeleccionado As String

    Private Sub OnInfoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Lista = VObtenerAllPuerto()
            If Lista IsNot Nothing
                DataGridViewVehiculos.DataSource = Lista
                DataGridViewVehiculos.MultiSelect = False
            End If
        Catch ex As Exception
            Log.Warning(ex, "Error Al Cargar Vehiculos. InfoDeAutos")
        End Try
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try
            If tbxBuscarVin.Text.Length > 0
                '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
                Dim Filtro As DataTable = VObtenerAllPuerto
                DataGridViewVehiculos.DataSource = Filtro
            Else
                Try
                    Dim Lista = VObtenerAllPuerto()
                    If Lista IsNot Nothing
                        DataGridViewVehiculos.DataSource = Lista
                        DataGridViewVehiculos.MultiSelect = False
                    End If
                Catch ex As Exception
                    Log.Warning(ex, "Error Al Cargar Vehiculos. InfoDeAutos")
                End Try
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al filtrar.")
            MessageBox.Show("Error al filtrar.")
        End Try
    End Sub

    Private Sub OnTabChange(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1
            Try
                Try
                    Dim Lista = LObtenerNoSalida()
                    If Lista IsNot Nothing
                        DataGridViewLotes.DataSource = Lista
                        DataGridViewLotes.MultiSelect = False
                    End If
                Catch ex As Exception
                    Log.Warning(ex, "Error Al Cargar Vehiculos. InfoDeAutos")
                End Try
            Catch ex As Exception
                MessageBox.Show("Error al listar lotes.")
                Serilog.Log.Error(ex, "Error al listar lotes.")
            End Try
        End If
    End Sub

    Private Sub BtActualizarVehiculo_Click(sender As Object, e As EventArgs) Handles btActualizarVehiculo.Click
        Try
            If tbxBuscarVin.Text.Length > 0
                '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
                Dim Filtro As DataTable = VObtenerAllPuertoLike(tbxBuscarVin.Text.ToUpper)
                DataGridViewVehiculos.DataSource = Filtro
            Else
                Dim Lista As DataTable = VObtenerAllPuerto
                DataGridViewVehiculos.DataSource = Lista
            End If
        Catch ex As Exception
            Log.Error(ex, "Error al actualizar.")
            MessageBox.Show("Error al actualizar.")
        End Try
    End Sub

    Friend Sub ActualizarVehiculos()
        Try
            DataGridViewVehiculos.DataSource = Nothing
            DataGridViewVehiculos.DataSource = VObtenerAllPuerto()
        Catch ex As Exception
            Log.Error(ex, "err..")
        End Try
    End Sub

    Private Sub BtInfoVehiculo_Click(sender As Object, e As EventArgs) Handles btInfoVehiculo.Click
        Try
            Dim VentanaVer As Ventana_Ver = New Ventana_Ver
            Dim VerVehiculo As VerVehiculo = New VerVehiculo
            VerVehiculo.Data(VinSeleccionado)
            VentanaVer.LoadControl(VerVehiculo)
            VentanaVer.ShowDialog()
        Catch ex As Exception
            Serilog.Log.Warning(ex, "InfoAutos")
        End Try
    End Sub

    Private Sub BtVerLote_Click_1(sender As Object, e As EventArgs) Handles btVerLote.Click
        Try
            Dim VentanaVer As Ventana_Ver = New Ventana_Ver
            Dim VerLotes As VerLotes = New VerLotes
            VerLotes.Data(DataGridViewLotes.SelectedRows(0).Cells(0).Value.ToString())
            VentanaVer.LoadControl(VerLotes)
            VentanaVer.ShowDialog()
        Catch ex As Exception
            Serilog.Log.Error(ex, "bruh")
        End Try
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgVehiculo As AgregarVehiculo = New AgregarVehiculo
        AgVehiculo.UC_VehiculosLotes = Me
        Ventana.LoadControl(AgVehiculo)
        Ventana.ShowDialog()
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridViewVehiculos.SelectionChanged
        if DataGridViewVehiculos.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridViewVehiculos.SelectedRows(0)
            VinSeleccionado = fila.Cells("vehiculovin").Value
        End If
    End Sub
    Private Sub BtnAgregarLote_Click(sender As Object, e As EventArgs) Handles btnAgregarLote.Click
        Dim VVer As Ventana_Ver = New Ventana_Ver
        Dim AgLote As AgregarLote = New AgregarLote
        VVer.LoadControl(AgLote)
        VVer.ShowDialog
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        DataGridViewLotes.DataSource = Nothing
        DataGridViewLotes.DataSource = LObtenerNoSalida()
    End Sub
End Class
