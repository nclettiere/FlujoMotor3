Public Class Agregar_Inspeccion

    Private Sub Agregar_Inspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If cheBoSIDepende.CheckState = CheckState.Checked Then
            btBuscar.Enabled = True
        Else
            btBuscar.Enabled = False
        End If
        If cheBoSIDano.CheckState = CheckState.Checked Then
            btAgregar.Enabled = True
        Else
            btAgregar.Enabled = False
        End If

    End Sub
End Class
