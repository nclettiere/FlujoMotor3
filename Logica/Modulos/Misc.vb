Imports System.Data.Odbc
Imports System.Drawing
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

    Private Function GetIconBitmap(Icono As String) As Bitmap
        Dim img As Bitmap = Nothing

        If Icono.Length > 0 Then
            Try
                img = New Bitmap(Icono)
            Catch __Excepcion_de_mierda_2008__ As Exception
                MsgBox(__Excepcion_de_mierda_2008__.Message)
            End Try
        End If

        Return img
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
End Module
