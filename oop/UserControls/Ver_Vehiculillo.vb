Imports DB
Imports oop
Imports Serilog
Imports Serilog.Sinks.SystemConsole
Imports System

Public Class Ver_Vehiculillo

    Private Shared _instance As Ver_Vehiculillo

    Public Shared Property Instance As Ver_Vehiculillo
        Get
            If _instance Is Nothing Then
                _instance = New Ver_Vehiculillo()
            End If
            Return _instance
        End Get
        Set(value As Ver_Vehiculillo)
            _instance = value
        End Set
    End Property
    Private Property Ventana As Ventanita_Ver
    Private Property InfoAutos As Info_de_Autillos
    Private Property Conexion As DB.ODBC

    Private Property VIN As String

    Friend Sub Data(info_de_Autillos As Info_de_Autillos, vin As String, ByRef Ventana As Ventanita_Ver, ByRef Conexion As ODBC)
        InfoAutos = info_de_Autillos
        Me.Ventana = Ventana
        Me.Conexion = Conexion
        Me.VIN = vin

        Dim resultadoVehiculo As DataTable = Conexion.consultar("SELECT * FROM vehiculos WHERE vehiculovin='" + vin + "'")
        If resultadoVehiculo IsNot Nothing
            Dim resultadoLote As DataTable = Conexion.consultar("SELECT * FROM lotes WHERE loteid='" + resultadoVehiculo.Rows(0).Item(8).ToString + "'")
            If resultadoVehiculo IsNot Nothing
                Dim resultadoPatio As DataTable = Conexion.consultar("SELECT * FROM patios WHERE patioid='" + resultadoVehiculo.Rows(0).Item(8).ToString + "'")
                lblVin.Text = resultadoVehiculo.Rows(0).Item(0)
                VIN = resultadoVehiculo.Rows(0).Item(0)
                'labFecha.Text = resultadoVehiculo.Rows(0).Item(1)
                labColor.Text = resultadoVehiculo.Rows(0).Item(2)
                labMarca.Text = resultadoVehiculo.Rows(0).Item(3)
                labModelo.Text = resultadoVehiculo.Rows(0).Item(4)
                labAno.Text = resultadoVehiculo.Rows(0).Item(5)
                labTipo.Text = resultadoVehiculo.Rows(0).Item(6)  
                labLoteName.Text = resultadoLote.Rows(0).Item(1)
                If resultadoPatio IsNot Nothing
                    labPatio.Text = resultadoPatio.Rows(0).Item(1)
                End If
            End If
        End If
    
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ventana.Close()
    End Sub

    Private Sub BtVerInspeccion_Click(sender As Object, e As EventArgs) Handles btVerInspeccion.Click
        MessageBox.Show(VIN)
        Ventana.GotoSection(0, VIN, Conexion)
    End Sub
End Class
