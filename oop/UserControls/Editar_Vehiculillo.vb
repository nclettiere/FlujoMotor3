Public Class Editar_Vehiculillo
    Private Sub Editar_Vehiculillo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Los shrekboxs
        If cheBoAno.CheckState = CheckState.Checked Then
            txtAno.Enabled = True
            labAno.Enabled = True
        End If
        If cheBoColor.CheckState = CheckState.Checked Then
            txtColor.Enabled = True
            labColor.Enabled = True
        End If
        If cheBoMarca.CheckState = CheckState.Checked Then
            txtMarca.Enabled = True
            labMarca.Enabled = True
        End If
        If cheBoModelo.CheckState = CheckState.Checked Then
            txtMarca.Enabled = True
            labModelo.Enabled = True
        End If
        If cheBoTipo.CheckState = CheckState.Checked Then
            coBoTipo.Enabled = True
            labTipo.Enabled = True
        End If
        If cheBoLote.CheckState = CheckState.Checked Then
            txtLoteID.Enabled = True
            labLote.Enabled = True
        End If


    End Sub
End Class
