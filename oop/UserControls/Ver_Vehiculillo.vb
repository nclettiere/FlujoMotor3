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
                Dim resultadoSubZonaVehiculo As DataTable = Conexion.consultar("SELECT * FROM vehiculoSubZona WHERE vehiculovin='" + resultadoVehiculo.Rows(0).Item(0).ToString + "'")
                lblVin.Text = resultadoVehiculo.Rows(0).Item(0).ToString
                VIN = resultadoVehiculo.Rows(0).Item(0).ToString
                labFecha.Text = resultadoVehiculo.Rows(0).Item(1).ToString
                labColor.Text = resultadoVehiculo.Rows(0).Item(2).ToString
                labMarca.Text = resultadoVehiculo.Rows(0).Item(3).ToString
                labModelo.Text = resultadoVehiculo.Rows(0).Item(4).ToString
                labAno.Text = resultadoVehiculo.Rows(0).Item(5).ToString
                labTipo.Text = resultadoVehiculo.Rows(0).Item(6).ToString 
                labLoteName.Text = resultadoLote.Rows(0).Item(1).ToString
                If resultadoPatio IsNot Nothing
                    Try
                        labPatio.Text = resultadoPatio.Rows(0).Item(1)
                    Catch ex As Exception
                        Log.Warning(ex, "Error out of index")
                    End Try
                End If

                If resultadoSubZonaVehiculo.Rows.Count > 0
                    Try
                        Dim resultadoZonaVehiculo As DataTable = Conexion.consultar("SELECT * FROM vehiculoSubZona WHERE vehiculovin='" + resultadoVehiculo.Rows(0).Item(0).ToString + "'")
                        labSubzona.Text = resultadoSubZonaVehiculo.Rows(0).Item("subzonanombre").ToString
                        labColumna.Text = resultadoSubZonaVehiculo.Rows(0).Item("columna").ToString
                        labFila.Text = resultadoSubZonaVehiculo.Rows(0).Item("fila").ToString
                        labZona.Text = resultadoSubZonaVehiculo.Rows(0).Item("zonaid").ToString
                    Catch ex As Exception
                        Log.Warning(ex, "Error al cargar datos.")
                    End Try
                End If
            End If
        End If
    
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ventana.Close()
    End Sub

    Private Sub BtVerInspeccion_Click(sender As Object, e As EventArgs) Handles btVerInspeccion.Click
        Dim ResultadoInspecciones As DataTable = Conexion.consultar("SELECT * FROM inspecciones WHERE vehiculovin='" + VIN +"'")
        If ResultadoInspecciones IsNot Nothing
            Dim index As Integer = 0
            If ResultadoInspecciones.Rows.Count <> 0
                Ventana.GotoSection(0, VIN, Conexion)
            Else
                 MessageBox.Show("Este vehiculo no tiene inspecciones.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ventana.GotoSection(1, VIN, Conexion)
    End Sub
End Class
