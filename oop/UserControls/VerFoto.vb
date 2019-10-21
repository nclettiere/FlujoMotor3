Imports System.Drawing.Imaging
Imports System.IO

Public Class VerFoto

    Friend EsQR As Boolean = False
    Friend VIN As String

    Friend Sub SetFoto(Imagen As Bitmap)
        PbFoto.Image = Imagen
    End Sub

    Private Sub OnFotoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = PbFoto.Size
        If EsQR
            btnGuardar.Visible = True
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim guardar As SaveFileDialog = New SaveFileDialog()
        guardar.Filter = "Images|*.png;*.bmp;*.jpg"
        Dim formato As ImageFormat = ImageFormat.Png

        guardar.FileName = VIN

        If guardar.ShowDialog() = DialogResult.OK Then
            Dim extension As String = Path.GetExtension(guardar.FileName)

            Select Case extension
                Case ".jpg"
                    formato = ImageFormat.Jpeg
                Case ".bmp"
                    formato = ImageFormat.Bmp
            End Select

            PbFoto.Image.Save(guardar.FileName, formato)

            MsgBox("El QR se guardo exitosamente.")
        End If
    End Sub
End Class