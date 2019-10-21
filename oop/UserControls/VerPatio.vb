Imports System.ComponentModel
Imports System.Reflection
Imports Logica
Imports BrightIdeasSoftware

Public Class VerPatio
    Private Shared _instance As VerPatio

    Private DataGridViewVehiculos As FastDataListView

    Public Shared Property Instance As VerPatio
        Get
            If _instance Is Nothing Then
                _instance = New VerPatio()
            End If
            Return _instance
        End Get
        Set(value As VerPatio)
            _instance = value
        End Set
    End Property

    Public Property FormParent As MenuControl
    Public Property Conexion As DB.ODBC
    Public Property VinSeleccionado As String

    Private Sub BtnPos_Click(sender As Object, e As EventArgs) Handles btnPos.Click

    End Sub

    Private Sub OnVerPatioLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewVehiculos = New FastDataListView
        DataGridViewVehiculos.MultiSelect = False
        DataGridViewVehiculos.FullRowSelect = True
        AddHandler DataGridViewVehiculos.SelectionChanged, AddressOf CambioSeleccion
        pnlData.Controls.Add(DataGridViewVehiculos)
        DataGridViewVehiculos.Dock = DockStyle.Fill
        cbxFiltro.SelectedIndex = 0
        
        ActualizarLista
    End Sub

    Private Sub BtnLavado_Click(sender As Object, e As EventArgs) Handles btnLavado.Click
        Try
            Dim CVentanaVer As Ventana_Ver = New Ventana_Ver
            Dim VerLvd = New VerLavados()
            VerLvd.CargarDatos(VinSeleccionado)
            CVentanaVer.LoadControl(VerLvd)
            CVentanaVer.ShowDialog
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al abrir VerLavados")
        End Try
    End Sub

    Private Sub CambioSeleccion() 
        If DataGridViewVehiculos.SelectedIndex >= 0
            VinSeleccionado = DataGridViewVehiculos.SelectedItem.SubItems.Item(0).Text
            btnLavado.Enabled = True
            btnPos.Enabled = True
            btnVendido.Enabled = True
            btInfoVehiculo.Enabled = True
        Else
            btnLavado.Enabled = False
            btnPos.Enabled = False
            btnVendido.Enabled = False
            btInfoVehiculo.Enabled = False
        End If
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

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try
            If tbxBuscarVin.Text.Length > 0
                '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
                Dim resultado As DataTable = VObtenerAllPatioFiltro(tbxBuscarVin.Text.ToUpper)
                DataGridViewVehiculos.DataSource = resultado
            Else
                Dim resultado As DataTable = VObtenerAllPatio
                DataGridViewVehiculos.DataSource = resultado
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al filtrar.")
            MessageBox.Show("Error al filtrar.")
        End Try
    End Sub

    Private Sub BtnPatios_Click(sender As Object, e As EventArgs) Handles btnPatios.Click
        Dim VentanaVer As Ventana_Ver = New Ventana_Ver
        Dim PZ As PatiosZonas = New PatiosZonas
        VentanaVer.LoadControl(PZ)
        VentanaVer.ShowDialog()
    End Sub

    Private Sub OnSelectChange(sender As Object, e As EventArgs) Handles cbxFiltro.SelectedIndexChanged
        Select cbxFiltro.SelectedIndex
            Case 0
                tbxBuscarVin.Visible = True
                cbxZonaPatio.Visible = False
                RemoveClickEvent(btBuscar)
                AddHandler btBuscar.Click, Sub(s, ea) FiltrarPorVIN()
            Case 1
                tbxBuscarVin.Visible = False
                cbxZonaPatio.Visible = True
                RemoveClickEvent(btBuscar)
                AddHandler btBuscar.Click, Sub(s, ea) FiltrarPorZona()
            Case 2
                tbxBuscarVin.Visible = False
                cbxZonaPatio.Visible = True
                cbxZonaPatio.Items.Clear
                For Each item As DataRow In PObtenerAll.Rows
                    cbxZonaPatio.Items.Add(item.Item("pationombre"))
                Next
                RemoveClickEvent(btBuscar)
                AddHandler btBuscar.Click, Sub(s, ea) FiltrarPorPatio()
        End Select
    End Sub

    Private Sub FiltrarPorVIN()
        Try
            If tbxBuscarVin.Text.Length > 0
                '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
                Dim resultado As DataTable = VObtenerAllFiltro("vehiculovin LIKE '%" + tbxBuscarVin.Text.ToUpper + "%' AND loteid IN (SELECT loteid FROM lotes WHERE lotefechallegada IS NOT NULL)")
                DataGridViewVehiculos.DataSource = resultado
            Else
                Dim resultado As DataTable = VObtenerAllFiltro("SELECT * FROM vehiculos WHERE loteid IN (SELECT loteid FROM lotes WHERE lotefechallegada IS NOT NULL)")
                DataGridViewVehiculos.DataSource = resultado
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al filtrar.")
            MessageBox.Show("Error al filtrar.")
        End Try
    End Sub

    Private Sub FiltrarPorPatio()
        Try
            If tbxBuscarVin.Text.Length > 0
                '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
                Dim resultado As DataTable = VObtenerAllFiltro("SELECT loteid IN (SELECT loteid FROM lotes WHERE patioid IN (SELECT patioid FROM patios WHERE pationombre='"+ cbxZonaPatio.Text +"')")
                DataGridViewVehiculos.DataSource = resultado
            Else
                Dim resultado As DataTable = VObtenerAllFiltro("SELECT * FROM vehiculos WHERE loteid IN (SELECT loteid FROM lotes WHERE lotefechallegada IS NOT NULL)")
                DataGridViewVehiculos.DataSource = resultado
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al filtrar.")
            MessageBox.Show("Error al filtrar.")
        End Try
    End Sub

    Private Sub FiltrarPorZona()
        Try
            If tbxBuscarVin.Text.Length > 0
                '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
                Dim resultado As DataTable = VObtenerAllFiltro("vehiculovin LIKE '%" + tbxBuscarVin.Text.ToUpper + "%' AND loteid IN (SELECT loteid FROM lotes WHERE lotefechallegada IS NOT NULL)")
                DataGridViewVehiculos.DataSource = resultado
            Else
                Dim resultado As DataTable = VObtenerAllFiltro("SELECT * FROM vehiculos WHERE loteid IN (SELECT loteid FROM lotes WHERE lotefechallegada IS NOT NULL)")
                DataGridViewVehiculos.DataSource = resultado
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al filtrar.")
            MessageBox.Show("Error al filtrar.")
        End Try
    End Sub

    Private Sub RemoveClickEvent(b As Button)
        Dim f1 As FieldInfo = GetType(Control).GetField("EventClick", BindingFlags.Static Or BindingFlags.NonPublic)
        Dim obj As Object = f1.GetValue(b)
        Dim pi As PropertyInfo = b.GetType().GetProperty("Events", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim list As EventHandlerList = DirectCast(pi.GetValue(b, Nothing), EventHandlerList)
        list.RemoveHandler(obj, list(obj))
    End Sub

    Private Sub BtnVendido_Click(sender As Object, e As EventArgs) Handles btnVendido.Click
        Try
            If VMarcarVendido(VinSeleccionado)
                MessageBox.Show("Vehiculo vendido exitosamente.")
                ActualizarLista
            End If
        Catch ex As Exception
            MsgBox("Error al vender makako")
            Serilog.Log.Error(ex, "err")
        End Try
    End Sub

    Private Sub ActualizarLista
        DataGridViewVehiculos.DataSource = Nothing
        Try
            DataGridViewVehiculos.DataSource = VObtenerAllPatio

            For Each column As ColumnHeader In DataGridViewVehiculos.Columns
                column.Width = -2
            Next
        Catch ex As Exception
            MsgBox("Error al actualizar lista")
            Serilog.Log.Error(ex, "err")
        End Try
    End Sub

    Private Sub BtActualizarVehiculo_Click(sender As Object, e As EventArgs) Handles btActualizarVehiculo.Click
        ActualizarLista
    End Sub
End Class
