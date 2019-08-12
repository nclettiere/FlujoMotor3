Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports DB
Imports Logica

Public Class Summary

    Private Shared _instance As Summary
    Private Conexion As ODBC

    Private Usuarios As List(Of Operario)

    Private facade As Facade
    Private main As MainWindow

    Private IsReady As Boolean = False

    Private OperarioId As Integer

    Private selectedVehiculo As Vehiculo


    Public Shared Property Instance As Summary
        Get
            If _instance Is Nothing Then
                _instance = New Summary()
            End If
            Return _instance
        End Get
        Set(value As Summary)
            _instance = value
        End Set
    End Property

    Private currentUser As Operario

    Friend Sub LoadData(main As MainWindow, facade As Facade, currentUser As Operario, Conexion As ODBC)
        Me.facade = facade
        Me.main = main

        Me.currentUser = currentUser

        Me.Conexion = Conexion

        Dim a As DataTable = Conexion.consultar("Select * FROM empleados")

        Dim index As Integer = 0
        For Each Row As DataRow In a.Rows
            Dim newRow = New String() {Row("empleadoId").ToString, Row("empleadoNombre").ToString, Row("empleadoApellido").ToString, Row("empleadoTelefono").ToString}
            Dim item As ListViewItem = New ListViewItem(newRow)
            ListViewVehiculos.Items.Add(item)
        Next



    End Sub


    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each vehiculo In facade.ObtenerVehiculos()
            Dim ListaPatio(7) As String

            ListaPatio(0) = vehiculo.Vin
            ListaPatio(1) = vehiculo.Marca
            ListaPatio(2) = vehiculo.Modelo
            ListaPatio(3) = vehiculo.Tipo
            ListaPatio(4) = vehiculo.Color
            ListaPatio(5) = vehiculo.Fecha.ToString
            ListaPatio(6) = facade.ObtenerUbicacion(vehiculo.UbicacionID).Status


            Dim listViewItem As ListViewItem = New ListViewItem(ListaPatio)
            ListViewVehiculos.Items.Add(listViewItem)
        Next

        ListViewVehiculos.MultiSelect = False
        ListViewVehiculos.LabelEdit = False

        Dim i As Integer = 1
        For Each lote As Lote In facade.ObtenerLotes()
            If lote.Vehiculos.Contains(selectedVehiculo.Vin) Then
                Dim control = New PreviewLote()
                control.cargar(Me, facade, i)
                LotesContent.Controls.Add(control)
            End If
            i += 1
        Next

        IsReady = True
    End Sub

    Private Sub OnSelectedIndexChange(sender As Object, e As EventArgs) Handles ListViewVehiculos.SelectedIndexChanged
        ''If ListViewVehiculos.SelectedItems.Count > 0 Then
        ''Dim index As Integer = ListViewVehiculos.SelectedItems(0).Index
        ''Dim selected As String = ListViewVehiculos.SelectedItems(0).SubItems(0).Text

        ''MessageBox.Show("SelectedIndex:=" + index.ToString)
        ''End If
    End Sub
End Class
