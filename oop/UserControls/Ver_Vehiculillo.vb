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
                Log.Information(lblVin.Text)
                VIN = resultadoVehiculo.Rows(0).Item(0)
                'labFecha.Text = resultadoVehiculo.Rows(0).Item(1)
                labColor.Text = resultadoVehiculo.Rows(0).Item(2)
                Log.Information(labColor.Text)
                labMarca.Text = resultadoVehiculo.Rows(0).Item(3)
                Log.Information(labMarca.Text)
                labModelo.Text = resultadoVehiculo.Rows(0).Item(4)
                Log.Information(labModelo.Text)
                labAno.Text = resultadoVehiculo.Rows(0).Item(5)
                Log.Information(labAno.Text)
                labTipo.Text = resultadoVehiculo.Rows(0).Item(6)  
                Log.Information(labTipo.Text)
                labLoteName.Text = resultadoLote.Rows(0).Item(1)
                Log.Information(labLoteName.Text)
                If resultadoPatio IsNot Nothing
                    Try
                        labPatio.Text = resultadoPatio.Rows(0).Item(1)
                    Catch ex As Exception
                        Log.Warning(ex, "Error out of index")
                    End Try
                    
                End If
            End If
        End If
    
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ventana.Close()
    End Sub

    Private Sub BtVerInspeccion_Click(sender As Object, e As EventArgs) Handles btVerInspeccion.Click
        Ventana.GotoSection(0, VIN, Conexion)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ventana.GotoSection(1, VIN, Conexion)
    End Sub
End Class
