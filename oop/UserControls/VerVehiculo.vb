Imports DB
Imports Serilog
Imports Logica

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

    Private Property VIN As String

    Friend Sub Data(vin As String)
        Me.VIN = vin

        ProcesarDatos()
    End Sub

    Private Sub ProcesarDatos()
        Try
            Dim Vehiculo As DataRow = VObtenerVIN(VIN)
            If Vehiculo IsNot Nothing
                VIN = Vehiculo.Item("vehiculovin").ToString
                lblVin.Text = VIN
                labFecha.Text = Vehiculo.Item("vehiculofecha").ToString
                labColor.Text = Vehiculo.Item("vehiculocolor").ToString
                labMarca.Text = Vehiculo.Item("vehiculomarca").ToString
                labModelo.Text = Vehiculo.Item("vehiculomodelo").ToString
                labAno.Text = Vehiculo.Item("vehiculoanio").ToString
                labTipo.Text = Vehiculo.Item("vehiculotipo").ToString 

                If Vehiculo.Item("loteid") IsNot Nothing
                    Dim Lote As DataRow = LObtenerID(Vehiculo.Item("loteid"))
                    If Lote IsNot Nothing
                        labLoteName.Text = Lote.Item("lotenombre")
                        Try
                            Dim Patio As DataRow = PObtenerID(Lote.Item("patioid").ToString)
                            Dim Zonas As DataRow = ZObtenerPatioID(Lote.Item("patioid").ToString)
                            If Patio IsNot Nothing
                                Try
                                    labPatio.Text = Patio.Item("pationombre")
                                    Dim SubZona = SZObtenerId(Zonas.Item("zonaid"))
                                    If SubZona IsNot Nothing
                                        Dim VSubZona = VSZObtener(Vehiculo.Item("vehiculovin"))
                                        labSubzona.Text = SubZona(0).Item("subzonanombre").ToString
                                        labZona.Text = SubZona(0).Item("zonaid").ToString
                                        labColumna.Text = VSubZona.Item("columna").ToString
                                        labFila.Text = VSubZona.Item("fila").ToString
                                    End If
                                Catch ex As Exception
                                    Log.Warning(ex, "Error out of index")
                                End Try
                            End If
                        Catch ex As Exception
                            Serilog.Log.Warning(ex, "El vehiculo tiene subzona asignada?")
                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            Serilog.Log.Warning(ex, "Error al extraer cierta informacion del vehiculo. Chequee el log para mas informacion.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DirectCast(ParentForm, Ventana_Ver).Close()
    End Sub

    Private Sub BtVerInspeccion_Click(sender As Object, e As EventArgs) Handles btVerInspeccion.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Ventana.LoadControl(New VerInspeccion, VIN)
        Ventana.ShowDialog
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Try
            DirectCast(ParentForm, Ventana_Ver).GotoSection(1, VIN)
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error")
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        DirectCast(ParentForm, Ventana_Ver).GoToSection(3, VIN)
    End Sub

    Private Sub BtnGenerarQR_Click(sender As Object, e As EventArgs) Handles btnGenerarQR.Click
        Dim icono As New Bitmap(My.Resources.FE01001LOGO)
        Dim vFoto As VerFoto = New VerFoto
        vFoto.SetFoto(GenerarQR(VIN, icono))
        vFoto.EsQR = True
        Dim vVer = New Ventana_Ver
        vVer.LoadControl(vFoto)
        vVer.TopMost = True
        vVer.ShowDialog()
    End Sub
End Class
