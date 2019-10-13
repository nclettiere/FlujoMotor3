Imports System.Data.Odbc
Imports System.Drawing
Imports System.IO
Imports QRCoder
Public Module Misc
    Public Function MInsertarLavado(VIN As String) As Boolean
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("INSERT INTO lavadovehiculo (vehiculovin, operariopatioid) VALUES('" + VIN + "', 3)", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return True
        Else
            Return False
        End If
        Cerrar
    End Function

    Public Function MObtenerLavadoVIN(VIN As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM lavadovehiculo WHERE vehiculovin='" + VIN + "'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function Consultar(query As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter(query, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function GenerarQR(Texto As String, Icono As Bitmap) As Bitmap
        Dim level As String = "L"
        Dim eccLevel As QRCodeGenerator.ECCLevel = CType(If(level = "L", 0, If(level = "M", 1, If(level = "Q", 2, 3))), QRCodeGenerator.ECCLevel)
        Using qrGenerator As QRCodeGenerator = New QRCodeGenerator()

            Using qrCodeData As QRCodeData = qrGenerator.CreateQrCode(Texto, eccLevel)

                Using qrCode As QRCode = New QRCode(qrCodeData)
                    Return qrCode.GetGraphic(20, Color.Black, Color.White, 25)
                End Using
            End Using
        End Using
    End Function

    Public Function ConvertirAByteArray(ByVal Img As Bitmap) As Byte()
        Dim bitmapBytes As Byte()
        Using stream As New System.IO.MemoryStream
            Img.Save(stream, Img.RawFormat)
            bitmapBytes = stream.ToArray
            Serilog.Log.Information(bitmapBytes.ToString)
        End Using
        Return bitmapBytes
    End Function

    Public Function ConvertirAByteArray(ByVal Img As Image) As Byte()
        Dim imgCon As New ImageConverter()
        Return DirectCast(imgCon.ConvertTo(Img, GetType(Byte())), Byte())
    End Function

    Friend Function ByteABitmap(ImagenByt As Byte()) As Bitmap 
        Dim bmp As Bitmap

        Using ms = New MemoryStream(ImagenByt)
            bmp = New Bitmap(ms)
        End Using

        Return bmp
    End Function
End Module
