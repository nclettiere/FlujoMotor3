Imports DB
Imports Serilog
Imports Serilog.Sinks.SystemConsole
Imports System

Public Class VerVehiculo

    Private Shared _instance As VerVehiculo

    Public Shared Property Instance As VerVehiculo
        Get
            If _instance Is Nothing Then
                _instance = New VerVehiculo()
            End If
            Return _instance
        End Get
        Set(value As VerVehiculo)
            _instance = value
        End Set
    End Property

    Private Property Conexion As DB.ODBC

    Private Property VIN As String

    Friend Sub Data(vin As String, ByRef Conexion As ODBC)
        Me.Conexion = Conexion
        Me.VIN = vin

        ProcesarDatos()
    End Sub

    Private Sub ProcesarDatos()
        Dim resultadoVehiculo As DataTable = Conexion.Consultar("SELECT * FROM vehiculos WHERE vehiculovin='" + vin + "'")
        If resultadoVehiculo IsNot Nothing
            Dim resultadoLote As DataTable = Conexion.Consultar("SELECT * FROM lotes WHERE loteid=" + resultadoVehiculo.Rows(0).Item("loteid").ToString + "")
            If resultadoVehiculo IsNot Nothing
                Dim resultadoPatio As DataTable = Conexion.Consultar("SELECT * FROM patios WHERE patioid=" + resultadoLote.Rows(0).Item("patioid").ToString + "")
                Dim resultadoSubZonaVehiculo As DataTable = Conexion.Consultar("SELECT * FROM vehiculoSubZona WHERE vehiculovin='" + resultadoVehiculo.Rows(0).Item(0).ToString + "'")
                VIN = resultadoVehiculo.Rows(0).Item("vehiculovin").ToString
                lblVin.Text = VIN
                labFecha.Text = resultadoVehiculo.Rows(0).Item("vehiculofecha").ToString
                labColor.Text = resultadoVehiculo.Rows(0).Item("vehiculocolor").ToString
                labMarca.Text = resultadoVehiculo.Rows(0).Item("vehiculomarca").ToString
                labModelo.Text = resultadoVehiculo.Rows(0).Item("vehiculomodelo").ToString
                labAno.Text = resultadoVehiculo.Rows(0).Item("vehiculoanio").ToString
                labTipo.Text = resultadoVehiculo.Rows(0).Item("vehiculotipo").ToString 

                If resultadoLote IsNot Nothing
                    If resultadoLote.Rows.Count > 0
                        labLoteName.Text = resultadoLote.Rows(0).Item(1).ToString
                    End If
                End If
                
                If resultadoPatio IsNot Nothing
                    Try
                        labPatio.Text = resultadoPatio.Rows(0).Item("pationombre").ToString
                    Catch ex As Exception
                        Log.Warning(ex, "Error out of index")
                    End Try
                End If

                If resultadoSubZonaVehiculo.Rows.Count > 0
                    Try
                        Dim resultadoZonaVehiculo As DataTable = Conexion.Consultar("SELECT * FROM vehiculoSubZona WHERE vehiculovin='" + resultadoVehiculo.Rows(0).Item(0).ToString + "'")
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
        DirectCast(ParentForm, Ventana_Ver).Close()
    End Sub

    Private Sub BtVerInspeccion_Click(sender As Object, e As EventArgs) Handles btVerInspeccion.Click
        Dim ResultadoInspecciones As DataTable = Conexion.Consultar("SELECT * FROM inspecciones WHERE vehiculovin='" + VIN +"'")
        If ResultadoInspecciones IsNot Nothing
            If ResultadoInspecciones.Rows.Count <> 0
                DirectCast(ParentForm, Ventana_Ver).GotoSection(0, VIN, Conexion)
            Else
                 MessageBox.Show("Este vehiculo no tiene inspecciones.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            DirectCast(ParentForm, Ventana_Ver).GotoSection(1, VIN, Conexion)
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error")
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        DirectCast(ParentForm, Ventana_Ver).GoToSection(3, VIN, Conexion)
    End Sub
End Class
