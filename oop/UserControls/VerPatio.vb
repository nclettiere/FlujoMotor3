﻿Imports System.ComponentModel
Imports System.Reflection
Imports Logica

Public Class VerPatio
    Private Shared _instance As VerPatio

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
        Try
            Dim VentanaVer = New Ventana_Ver()
            Dim vin = DataGridViewVehiculos.SelectedRows(0).Cells(0).Value.ToString
            VentanaVer.LoadControl(vin)
            VentanaVer.ShowDialog()
        Catch ex As Exception
            Serilog.Log.Error(ex, "boi")
        End Try
    End Sub

    Private Sub OnVerPatioLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxFiltro.SelectedIndex = 0
        Try
            Dim resultado As DataTable = VObtenerAllPatio
            DataGridViewVehiculos.DataSource = resultado
            DataGridViewVehiculos.MultiSelect = False
        Catch ex As Exception
            Serilog.Log.Warning(ex, "Error Al Cargar Vehiculos. VerPatio")
        End Try
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

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridViewVehiculos.SelectionChanged
        If DataGridViewVehiculos.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridViewVehiculos.SelectedRows(0)
            VinSeleccionado = fila.Cells("vehiculovin").Value
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

    Private Sub BtActualizarVehiculo_Click(sender As Object, e As EventArgs) Handles btActualizarVehiculo.Click
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
            Serilog.Log.Error(ex, "Error al actualizar.")
            MessageBox.Show("Error al actualizar.")
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPatios_Click(sender As Object, e As EventArgs) Handles btnPatios.Click
        Dim VentanaVer As Ventana_Ver = New Ventana_Ver
        VentanaVer.GoToSection(4, String.Empty)
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
                MsgBox("Else trigered")
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
End Class
