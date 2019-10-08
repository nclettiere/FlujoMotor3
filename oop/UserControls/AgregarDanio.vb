Imports Logica

Public Class AgregarDanio

    Friend InspeccionID As String
    Friend VIN As String
    Private ByteFotoDanio As Byte()

    Private TieneImagen As Boolean = False

    Private Sub BtAdjCamara_Click(sender As Object, e As EventArgs) Handles btAdjCamara.Click
        Dim InicCamera As IniciarCamara = New IniciarCamara
        Dim VentanaVer As Ventana_Ver = New Ventana_Ver
        InicCamera.Modo = 1 ' => Tomar Fotos
        InicCamera.InspeccionRef = Me
        VentanaVer.LoadControl(InicCamera)
        VentanaVer.ShowDialog
    End Sub

    Private Sub BtnAdjArchivo_Click(sender As Object, e As EventArgs) Handles btnAdjArchivo.Click
        With OpenFileDialog1
            .Title = "Seleccionar Imagen"
            .Filter = "Imagenes (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"

            If .ShowDialog() = DialogResult.OK
                ByteFotoDanio = ConvertirAByteArray(New Bitmap(.FileName))
                PBDanio.Image = New Bitmap(.FileName)
                TieneImagen = True
            End If
        End With
    End Sub

   Friend Sub CargarImagen(Imagen As Image)
        Try
            PBDanio.Image = Imagen
            ByteFotoDanio = ConvertirAByteArray(PBDanio.Image)
            TieneImagen = True
        Catch ex As Exception
            TieneImagen = False
            MsgBox("Error al cargar la imagen. Vea el Log para mas informacion.")
            Serilog.Log.Error(ex, "Error al cargar la imagen")
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not String.IsNullOrWhiteSpace(rtbx.Text)
            If TieneImagen
                If IInsertar(VIN, InspeccionID, rtbx.Text, ByteFotoDanio)
                    MsgBox("El danio se creo exitosamente.")
                    ParentForm.Close
                Else
                    MsgBox("Error al crear danio.")
                End If
            Else
                MsgBox("El danio debe tener una foto.")
            End If
        Else
            MsgBox("La descripcion no debe quedar vacia.")
        End If
    End Sub
End Class
