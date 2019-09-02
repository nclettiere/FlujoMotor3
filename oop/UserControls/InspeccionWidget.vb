Imports System.Data.Odbc
Imports System.IO
Imports Menu
Imports Serilog

Public Class InspeccionWidget
    Private Shared _instance As InspeccionWidget

    Public Shared Property Instance As InspeccionWidget
        Get
            If _instance Is Nothing Then
                _instance = New InspeccionWidget()
            End If
            Return _instance
        End Get
        Set(value As InspeccionWidget)
            _instance = value
        End Set
    End Property

    Private Property Conexion As DB.ODBC
    Private Property VIN As String
    Private Property QueryFoto As String = Nothing
    Public Property EstaVinculado As Boolean

    Friend Sub CargarDatos(ByVal inspeccionId As String, ByRef Conexion As DB.ODBC, ByVal index As Integer, vin As String)
        Me.Conexion = Conexion
        Me.VIN = vin
        Try
            Dim resultadoInspeccion As DataTable = Conexion.Consultar("SELECT * FROM inspecciones WHERE inspeccionid='" + inspeccionId + "'")
            If resultadoInspeccion IsNot Nothing Then
                lblId.Text = "INSPECCION #" + index.ToString
                Dim resultadoEmpleado As DataTable = Conexion.Consultar("SELECT empleadonombre, empleadoapellido FROM empleados WHERE empleadoid='" + resultadoInspeccion.Rows(0).Item("operarioid").ToString + "'")
                lblOp.Text = "Hecha por: " + resultadoEmpleado.Rows(0).Item(0) + " " + resultadoEmpleado.Rows(0).Item(1)
                lblFecha.Text = "Fecha: " + resultadoInspeccion.Rows(0).Item("inspeccionfecha")
                Dim resultadoInspeccionDanio As DataTable = Conexion.Consultar("SELECT * FROM inspeccionDanio WHERE inspeccionid='" + inspeccionId + "'")
                If resultadoInspeccionDanio IsNot Nothing Then

                    If resultadoInspeccionDanio.Rows().Count > 0 Then
                        QueryFoto = "SELECT daniofoto FROM danios WHERE danioid=" + resultadoInspeccionDanio.Rows(0).Item("danioid").ToString
                        Dim resultadoDanio As DataTable = Conexion.Consultar("SELECT danioid, daniodescripcion FROM danios WHERE danioid=" + resultadoInspeccionDanio.Rows(0).Item("danioid").ToString)
                        If resultadoDanio IsNot Nothing Then

                            Try
                                rchtbxDesc.Text = resultadoDanio.Rows(0).Item("daniodescripcion").ToString
                            Catch ex As Exception
                                Log.Information(ex, "Error InspeccionWidget")
                            End Try
                        End If
                    Else
                        lblOp.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            Log.Fatal(ex, "Error al procesar datos en InspeccionWidget.CargarDatos().")
#If DEBUG Then
            MessageBox.Show("Error: " + ex.Message)
#Else
                MessageBox.Show("Error al cargar datos. Vea el Log para mas informacion.")
#End If

        End Try
    End Sub

    Friend Sub Vincular(inspeccionWidget As InspeccionWidget)
        inspeccionWidget.BackColor = Color.Maroon
        FlowContent.Controls.Add(inspeccionWidget)
        inspeccionWidget.AutoSize = False
        inspeccionWidget.Size = New Size(100, 173)
        inspeccionWidget.Dock = DockStyle.None
    End Sub

    Private Function ObtenerDanioImagen(query As String) As Bitmap
        Dim command As OdbcCommand = New OdbcCommand(query) With {
            .Connection = Conexion.ConODBC
        }

        Dim reader As OdbcDataReader = command.ExecuteReader()

        If reader.Read()
            Log.Information(reader.GetValue(0).ToString)
            Dim value As Byte() = reader.GetValue(0)
            Return ConvertirBytesABitmap(value)
        End If

        reader.Close()

        Return Nothing
    End Function

    Private Function ConvertirBytesABitmap(byteArray As Byte()) As Bitmap
        Using ms As MemoryStream = New MemoryStream(byteArray)
            Dim img As Bitmap = DirectCast(Image.FromStream(ms), Bitmap)
            Return img
        End Using
    End Function

    Private Sub btnVincularDanio_Click(sender As Object, e As EventArgs) 
        Dim AgregarInsp As AgregarInspeccion = New AgregarInspeccion
        AgregarInsp.Modo = "VINCULAR"
        AgregarInsp.CargarDatos(VIN)
        Dim vntVer As Ventana_Ver = New Ventana_Ver
        vntVer.LoadControl(AgregarInsp)
        vntVer.ShowDialog()
    End Sub

    Private Sub Btnfoto_Click(sender As Object, e As EventArgs) 
        Dim VentanaVer As Ventana_Ver = New Ventana_Ver()
        Dim VerFoto As VerFoto = New VerFoto
        If QueryFoto IsNot Nothing
            VerFoto.SetFoto(ObtenerDanioImagen(QueryFoto))
        End If
        VentanaVer.LoadControl(VerFoto)
        VentanaVer.ShowDialog()
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
