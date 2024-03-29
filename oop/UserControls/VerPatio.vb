﻿Imports System.ComponentModel
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
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim Aparcar As AparcarVehiculo = New AparcarVehiculo
        Aparcar.VIN = (VinSeleccionado)
        Try
            Dim PatioId = LObtenerID(DataGridViewVehiculos.SelectedItem.SubItems.Item(9).Text).Item("patioid").ToString
            Aparcar.PatioId = PatioId
            Ventana.LoadControl(Aparcar)
            Ventana.ShowDialog
        Catch ex As Exception
            MessageBox.Show("Error al obtener patioid.")
            Serilog.Log.Error(ex, "err..")
        End Try
    End Sub

    Private Sub OnVerPatioLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateLang

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

            Case 1
                tbxBuscarVin.Visible = False
                cbxZonaPatio.Visible = True
            Case 2
                tbxBuscarVin.Visible = False
                cbxZonaPatio.Visible = True
                cbxZonaPatio.Items.Clear
                For Each item As DataRow In PObtenerAll.Rows
                    cbxZonaPatio.Items.Add(item.Item("pationombre"))
                Next
        End Select
    End Sub

    Private Sub BtnVendido_Click(sender As Object, e As EventArgs) Handles btnVendido.Click
        Try
            If VerificarLavado(VinSeleccionado)
                If VMarcarVendido(VinSeleccionado)
                    MessageBox.Show(_Lang.ObtenerKey("VerParking", 13))
                    ActualizarLista
                End If
            Else
                MsgBox("El vehiculo debe ser lavado antes de venderse.")
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

    Private Sub BtBuscarVIN_Click(sender As Object, e As EventArgs) Handles btBuscarVIN.Click
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

    Private Sub BtBuscarPatio_Click(sender As Object, e As EventArgs) Handles btBuscarPatio.Click

    End Sub

    Private Sub BtBuscarLote_Click(sender As Object, e As EventArgs) Handles btBuscarLote.Click

    End Sub

    Private Sub CbxZonaPatio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxZonaPatio.SelectedIndexChanged
        Dim PatioInfo = PObtenerNombre(cbxZonaPatio.Text)
        If PatioInfo IsNot Nothing
            Dim resultado As DataTable = VObtenerEnXPatio(PatioInfo.Item("patioid"))
            DataGridViewVehiculos.DataSource = resultado
        Else
            DataGridViewVehiculos.DataSource = Nothing
        End If
    End Sub

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("VerParking", 0)
        autito.Text = _Lang.ObtenerKey("VerParking", 1)
        btnLavado.Text = _Lang.ObtenerKey("VerParking", 6)
        btnPos.Text = _Lang.ObtenerKey("VerParking", 7)
        btInfoVehiculo.Text = _Lang.ObtenerKey("VerParking", 8)
        btnPatios.Text = _Lang.ObtenerKey("VerParking", 9)
        btnVendido.Text = _Lang.ObtenerKey("VerParking", 10)
        btActualizarVehiculo.Text = _Lang.ObtenerKey("VerParking", 11)
        btBuscarLote.Text = _Lang.ObtenerKey("VerParking", 12)
    End Sub

End Class
