Public Class Editar_Vehiculo
    Private Sub CheboVIN_CheckedChanged(sender As Object, e As EventArgs) Handles cheboVIN.CheckedChanged
        If cheboVIN.Checked Then
            txtVIN.Enabled = True
            labVIN.Enabled = True
        End If
    End Sub
    Private Sub CheboTipo_CheckedChanged(sender As Object, e As EventArgs) Handles cheboTipo.CheckedChanged
        If cheboTipo.Checked Then
            txtTipo.Enabled = True
            labTipo.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub CheboMarca_CheckedChanged(sender As Object, e As EventArgs) Handles cheboMarca.CheckedChanged
        If cheboMarca.Checked Then
            txtMarca.Enabled = True
            labMarca.Enabled = True
        End If
    End Sub
    Private Sub CheboModelo_CheckedChanged(sender As Object, e As EventArgs) Handles cheboModelo.CheckedChanged
        If cheboModelo.Checked Then
            txtModelo.Enabled = True
            labModelo.Enabled = True
        End If
    End Sub
    Private Sub CheboAnio_CheckedChanged(sender As Object, e As EventArgs) Handles cheboAnio.CheckedChanged
        If cheboAnio.Checked Then
            txtAno.Enabled = True
            labAno.Enabled = True
        End If
    End Sub
    Private Sub CheboColor_CheckedChanged(sender As Object, e As EventArgs) Handles cheboColor.CheckedChanged
        If cheboColor.Checked Then
            txtColor.Enabled = True
            labColor.Enabled = True
        End If
    End Sub





    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub Editar_Vehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class