﻿Imports oop
Imports Serilog

Public Class Info_de_Autillos

    Private Shared _instance As Info_de_Autillos

    Public Shared Property Instance As Info_de_Autillos
        Get
            If _instance Is Nothing Then
                _instance = New Info_de_Autillos()
            End If
            Return _instance
        End Get
        Set(value As Info_de_Autillos)
            _instance = value
        End Set
    End Property

    Public Property FormParent As MenuControl

    Private Property VinSeleccionado As String

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos")
            DataGridViewVehiculos.DataSource = resultado
            DataGridViewVehiculos.MultiSelect = False
        Catch ex As Exception
            Log.Warning(ex, "Error Al Cargar Vehiculos. InfoDeAutos")
        End Try
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        If tbxBuscarVin.Text.Length > 0
            '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos WHERE vehiculovin LIKE '%" + tbxBuscarVin.Text.ToUpper + "%'")
            DataGridViewVehiculos.DataSource = resultado
        Else
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos")
            DataGridViewVehiculos.DataSource = resultado
        End If

    End Sub

    Private Sub OnTabChange(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM lotes")
            DataGridViewLotes.DataSource = resultado
        End If
    End Sub

    Private Sub BtActualizarVehiculo_Click(sender As Object, e As EventArgs) Handles btActualizarVehiculo.Click
        If tbxBuscarVin.Text.Length > 0
            '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos WHERE vehiculovin LIKE '%" + tbxBuscarVin.Text.ToUpper + "%'")
            DataGridViewVehiculos.DataSource = resultado
        Else
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos")
            DataGridViewVehiculos.DataSource = resultado
        End If
    End Sub

    Private Sub BtInfoVehiculo_Click(sender As Object, e As EventArgs) Handles btInfoVehiculo.Click
        Try
            Dim VentanaVer As Ventanita_Ver = New Ventanita_Ver
            Dim VerVehiculo As Ver_Vehiculillo = New Ver_Vehiculillo
            MessageBox.Show(VinSeleccionado)
            VerVehiculo.Data(Me, VinSeleccionado, VentanaVer, FormParent.Conexion)
            VentanaVer.LoadControl(VerVehiculo)
            VentanaVer.ShowDialog()
        Catch ex As Exception
            Serilog.Log.Warning(ex, "InfoAutos")
        End Try
    End Sub

    Private Sub BtVerLote_Click_1(sender As Object, e As EventArgs) Handles btVerLote.Click
        Try
            Dim VentanaVer As Ventanita_Ver = New Ventanita_Ver
            Ver_Lotesillo.Instance.Data(Me, DataGridViewLotes.SelectedRows(0).Cells(0).Value.ToString(), VentanaVer, FormParent.Conexion)
            VentanaVer.LoadControl(Ver_Lotesillo.Instance)
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
