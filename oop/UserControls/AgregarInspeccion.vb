Imports System.Drawing.Imaging
Imports DB
Imports System.Data.Odbc

Public Class AgregarInspeccion
    Private Shared _instance As AgregarInspeccion
    Public Shared Property Instance As AgregarInspeccion
        Get
            If _instance Is Nothing Then
                _instance = New AgregarInspeccion()
            End If
            Return _instance
        End Get
        Set(value As AgregarInspeccion)
            _instance = value
        End Set
    End Property

    Public Shared Property ListaVehiculosSeleccionados As List(Of String)
    Public Property FormParent As Ventana_Ver
    Public Property ParentControl As AgregarVehiculo
    Public Property Conexion As DB.ODBC
    Public Property Cliente As String
    Public Property Vin As String
    Public Property Modo As String
    Public Property PrimeraInspeccion As Boolean = False
    Public Property AgVehciulo As AgregarVehiculo
    Private TieneDanio As Boolean = False
    Private ByteFotoDanio As Byte() = Nothing

    Private Sub Agregar_Inspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(Modo) Then
            Dim ResultadoDanios = Conexion.Consultar("SELECT COUNT(*) FROM inspecciones WHERE vehiculovin='"+ Vin +"'")
            If ResultadoDanios IsNot Nothing
                If ResultadoDanios.Rows.Count
                   If ResultadoDanios.Rows(0).Item(0) > 0
                        lblTitulo.Text = "Danio #"+ ResultadoDanios.Rows(0).Item(0).ToString +" Al Vehiculo:"
                        labVIN.Text = VIN.ToUpper
                   End If
                End If
            End If
        End If
    End Sub

    Friend Sub CargarDatos(VIN As String, conexion As ODBC)
        labVIN.Text = VIN.ToUpper
        Me.Vin = VIN.ToUpper
        Me.Conexion = conexion

        If conexion Is Nothing
            MessageBox.Show("nada")
        End If
    End Sub

    Friend Sub CargarDatos(VIN As String, conexion As ODBC, AgVehciulo As AgregarVehiculo)
        labVIN.Text = VIN.ToUpper
        Me.Vin = VIN.ToUpper
        Me.Conexion = conexion
        Me.AgVehciulo = AgVehciulo
        PrimeraInspeccion = True
        btnCancelar.Visible = False

        If conexion Is Nothing
            MessageBox.Show("nada")
        End If
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs)
        Try
            Dim InpeccioensCount As DataTable = Conexion.Consultar("SELECT COUNT(*) FROM inspecciones")
            Dim CrearInspeccion As DataTable = Conexion.Consultar("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES(" + (InpeccioensCount.Rows(0).Item(0) + 1).ToString + ",'" + Vin + "', 3)")
        Catch ex As Exception
            Serilog.Log.Error(ex, "Posible valor nulo en Agregar Inspeccion.")
        End Try
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

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If TieneDanio
            Try
                Dim InpeccioensCount As DataTable = Conexion.Consultar("SELECT COUNT(*) FROM inspecciones")
                Dim CrearInspeccion As DataTable = Conexion.Consultar("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES(" + (InpeccioensCount.Rows(0).Item(0) + 1).ToString + ",'" + Vin.ToUpper + "', 3)")
                Dim DaniosCount As DataTable = Conexion.Consultar("SELECT COUNT(*) FROM danios")
                Dim CrearDanio As DataTable = Conexion.ConsultaDanio("INSERT INTO danios (danioid, daniodescripcion, daniofoto) VALUES(" + (DaniosCount.Rows(0).Item(0) + 1).ToString + ",'" + rtbx.Text + "', ?)", ByteFotoDanio)
                Dim CrearInspeccionDanio As DataTable = Conexion.Consultar("INSERT INTO inspecciondanio (inspeccionid, danioid) VALUES("+ (InpeccioensCount.Rows(0).Item(0) + 1).ToString +", "+ (DaniosCount.Rows(0).Item(0) + 1).ToString +")")

                If PrimeraInspeccion
                    MessageBox.Show("Vehiculo e Inspeccion Agregados Correctamente.")
                    ParentForm.Close()
                Else
                    MessageBox.Show("Inspeccion Agregada Correctamente.")
                End If
            Catch ex As Exception
                Serilog.Log.Error(ex, "Posible valor nulo en Agregar Inspeccion.")
            End Try
        Else
            Try
                Dim InpeccioensCount As DataTable = Conexion.Consultar("SELECT COUNT(*) FROM inspecciones")
                Dim CrearInspeccion As DataTable = Conexion.Consultar("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES(" + (InpeccioensCount.Rows(0).Item(0) + 1).ToString + ",'" + Vin + "', 3)")

                If PrimeraInspeccion
                    MessageBox.Show("Vehiculo e Inspeccion Agregados Correctamente.")
                    ParentForm.Close()
                Else
                    MessageBox.Show("Inspeccion Agregada Correctamente.")
                End If
            Catch ex As Exception
                Serilog.Log.Error(ex, "Posible valor nulo en Agregar Inspeccion.")
            End Try
        End If
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ParentForm.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 

    End Sub
End Class