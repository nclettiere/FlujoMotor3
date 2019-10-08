Public Class Editar_Lote

    Private Sub Editar_Lote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheboNombre_CheckedChanged(sender As Object, e As EventArgs) Handles cheboNombre.CheckedChanged
        If cheboNombre.Checked Then
            txtNombre.Enabled = True
        End If
    End Sub

    Private Sub CheboDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles cheboDescripcion.CheckedChanged
        If cheboDescripcion.Checked Then
            rch_desc.Enabled = True
        End If
    End Sub

    Private Sub CheboSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles cheboSeleccionar.CheckedChanged
        If cheboSeleccionar.Checked Then
            btSeleccionar.Enabled = True
        End If
    End Sub
End Class