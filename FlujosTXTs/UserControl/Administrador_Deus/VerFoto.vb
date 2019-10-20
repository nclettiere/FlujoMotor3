Public Class VerFoto
    Friend Sub SetFoto(Imagen As Bitmap)
        PbFoto.Image = Imagen
    End Sub

    Private Sub OnFotoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = PbFoto.Size
    End Sub
End Class