Imports System.Drawing.Imaging
Imports DB
Imports System.Data.Odbc

Public Class Agregar_Inspeccion
    Private Shared _instance As Agregar_Inspeccion
    Public Shared Property Instance As Agregar_Inspeccion
        Get
            If _instance Is Nothing Then
                _instance = New Agregar_Inspeccion()
            End If
            Return _instance
        End Get
        Set(value As Agregar_Inspeccion)
            _instance = value
        End Set
    End Property

    Public Shared Property ListaVehiculosSeleccionados As List(Of String)
    Public Property FormParent As Ventanita_Ver
    Public Property ParentControl As Agregar_Vehiculillo
    Public Property Conexion As DB.ODBC
    Public Property Cliente As String
    Public Property vin As String
    Private TieneDanio As Boolean = False
    Private ByteFotoDanio As Byte() = Nothing

    Private Sub Agregar_Inspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub CargarDatos(VIN As String, conexion As ODBC)
        labVIN.Text = VIN
        Me.vin = VIN
        Me.Conexion = conexion

        If conexion Is Nothing
            MessageBox.Show("nada")
        End If
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs)
        Try
            Dim InpeccioensCount As DataTable = Conexion.consultar("SELECT COUNT(*) FROM inspecciones")
            Dim CrearInspeccion As DataTable = Conexion.consultar("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES(" + (InpeccioensCount.Rows(0).Item(0) + 1).ToString + ",'" + vin + "', 3)")
        Catch ex As Exception
            Serilog.Log.Error(ex, "Posible valor nulo en Agregar Inspeccion.")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If TieneDanio
            TieneDanio = False
            PanelDanio.Visible = False
            btAgregar.Text = "INSERTAR FOTO"
            PbDanio.BackgroundImage = Nothing
            rtbx.Text = String.Empty
        Else
            TieneDanio = True
            PanelDanio.Visible = True
            btAgregar.Text = "QUITAR"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
        With OpenFileDialog1
            .Title = "Seleccionar Imagen"
            .Filter = "Imagenes (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"

            If .ShowDialog() = DialogResult.OK
                ByteFotoDanio = ConvertirAByteArray(New Bitmap(.FileName))
                PbDanio.BackgroundImage = New Bitmap(.FileName)
            End If
        End With
    End Sub

    Public Shared Function ConvertirAByteArray(ByVal value As Bitmap) As Byte()
        Dim bitmapBytes As Byte()
        Using stream As New System.IO.MemoryStream
            value.Save(stream, value.RawFormat)
            bitmapBytes = stream.ToArray
            Serilog.Log.Information(bitmapBytes.ToString)
        End Using
        Return bitmapBytes
    End Function

    Private Function ByteArrayAString(ByVal bytes() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If TieneDanio
            Try
                Dim InpeccioensCount As DataTable = Conexion.consultar("SELECT COUNT(*) FROM inspecciones")
                Dim CrearInspeccion As DataTable = Conexion.consultar("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES(" + (InpeccioensCount.Rows(0).Item(0) + 1).ToString + ",'" + vin + "', 3)")
                Dim DaniosCount As DataTable = Conexion.consultar("SELECT COUNT(*) FROM danios")
                Dim CrearDanio As DataTable = Conexion.consultaDanio("INSERT INTO danios (danioid, daniodescripcion, daniofoto) VALUES(" + (DaniosCount.Rows(0).Item(0) + 1).ToString + ",'" + rtbx.Text + "', ?)", ByteFotoDanio)
                Dim CrearInspeccionDanio As DataTable = Conexion.consultar("INSERT INTO inspecciondanio (inspeccionid, danioid) VALUES("+ (InpeccioensCount.Rows(0).Item(0) + 1).ToString +", "+ (DaniosCount.Rows(0).Item(0) + 1).ToString +")")
                MessageBox.Show("Inspeccion Agregada Correctamente")
            Catch ex As Exception
                Serilog.Log.Error(ex, "Posible valor nulo en Agregar Inspeccion.")
            End Try
        Else
            Try
                Dim InpeccioensCount As DataTable = Conexion.consultar("SELECT COUNT(*) FROM inspecciones")
                Dim CrearInspeccion As DataTable = Conexion.consultar("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES(" + (InpeccioensCount.Rows(0).Item(0) + 1).ToString + ",'" + vin + "', 3)")
                MessageBox.Show("Inspeccion Agregada Correctamente")
            Catch ex As Exception
                Serilog.Log.Error(ex, "Posible valor nulo en Agregar Inspeccion.")
            End Try
        End If
    End Sub
End Class