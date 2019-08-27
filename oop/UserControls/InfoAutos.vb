Imports Serilog

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
            Dim resultado As DataTable = FormParent.Conexion.Consultar("SELECT * FROM vehiculos")
            DataGridViewVehiculos.DataSource = resultado
            DataGridViewVehiculos.MultiSelect = False
        Catch ex As Exception
            Log.Warning(ex, "Error Al Cargar Vehiculos. InfoDeAutos")
        End Try
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try
            If tbxBuscarVin.Text.Length > 0
                '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
                Dim resultado As DataTable = FormParent.Conexion.Consultar("SELECT * FROM vehiculos WHERE vehiculovin LIKE '%" + tbxBuscarVin.Text.ToUpper + "%'")
                DataGridViewVehiculos.DataSource = resultado
            Else
                Dim resultado As DataTable = FormParent.Conexion.Consultar("SELECT * FROM vehiculos")
                DataGridViewVehiculos.DataSource = resultado
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al filtrar.")
            MessageBox.Show("Error al filtrar.")
        End Try
    End Sub

    Private Sub OnTabChange(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1
            Try
                Dim resultado As DataTable = FormParent.Conexion.Consultar("SELECT * FROM lotes")
                DataGridViewLotes.DataSource = resultado
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
                Dim resultado As DataTable = FormParent.Conexion.Consultar("SELECT * FROM vehiculos WHERE vehiculovin LIKE '%" + tbxBuscarVin.Text.ToUpper + "%'")
                DataGridViewVehiculos.DataSource = resultado
            Else
                Dim resultado As DataTable = FormParent.Conexion.Consultar("SELECT * FROM vehiculos")
                DataGridViewVehiculos.DataSource = resultado
            End If
        Catch ex As Exception
            Log.Error(ex, "Error al actualizar.")
            MessageBox.Show("Error al actualizar.")
        End Try
    End Sub

    Private Sub BtInfoVehiculo_Click(sender As Object, e As EventArgs) Handles btInfoVehiculo.Click
        Try
            Dim VentanaVer As Ventanita_Ver = New Ventanita_Ver
            Dim VerVehiculo As VerVehiculo = New VerVehiculo
            VerVehiculo.Data(VinSeleccionado, FormParent.Conexion)
            VentanaVer.LoadControl(VerVehiculo)
            VentanaVer.ShowDialog()
        Catch ex As Exception
            Serilog.Log.Warning(ex, "InfoAutos")
        End Try
    End Sub

    Private Sub BtVerLote_Click_1(sender As Object, e As EventArgs) Handles btVerLote.Click
        Try
            Dim VentanaVer As Ventanita_Ver = New Ventanita_Ver
            VerLotes.Instance.Data(DataGridViewLotes.SelectedRows(0).Cells(0).Value.ToString(), FormParent.Conexion)
            VentanaVer.LoadControl(VerLotes.Instance)
            VentanaVer.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        FormParent.GotoSection(1)
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridViewVehiculos.SelectionChanged
        if DataGridViewVehiculos.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridViewVehiculos.SelectedRows(0)
            VinSeleccionado = fila.Cells("vehiculovin").Value
        End If
    End Sub
End Class
