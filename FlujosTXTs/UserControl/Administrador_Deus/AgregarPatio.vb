Imports FlujosTXTs
Imports Logica
Public Class AgregarPatio
    Friend PZ_PatioAZonas As PatiosZonas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(tbxPatioNombre.Text)
            If Not String.IsNullOrWhiteSpace(tbxDir.Text)
                If PObtenerCount(tbxPatioNombre.Text) = 0
                    If PInsertar(tbxPatioNombre.Text, tbxDir.Text)
                        If PZ_PatioAZonas IsNot Nothing
                            PZ_PatioAZonas.ActualizarPatios
                        End If

                        ParentForm.Close
                    Else
                        MsgBox("Error al crear patio.")
                    End If
                Else
                    MsgBox("Ya existe un patio con ese nombre.")
                End If
            Else
                MsgBox("Debes ingresar una direccion.")
            End If
        Else
            MsgBox("Debes ingresar un nombre.")
        End If
    End Sub
End Class
