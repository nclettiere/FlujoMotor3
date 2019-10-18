Imports Logica

Public Class SeleccionarTransportista

    Friend VL_VerLote As VerLotes

    Private Sub OnSTLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaTransportistas.FullRowSelect = True
        ListaTransportistas.MultiSelect = False
        ActualizarLista
    End Sub

    Friend Sub ActualizarLista
        Try
            Dim ListaUsuarios = Consultar("SELECT * FROM usuarios LEFT JOIN transportistas ON usuarios.empleadoid = transportistas.empleadoid WHERE transportistas.empleadoid IS NOT NULL;")
            If ListaUsuarios IsNot Nothing
                If ListaUsuarios.Rows.Count > 0
                    ListaTransportistas.DataSource = Nothing
                    ListaTransportistas.DataSource = ListaUsuarios
                    ListaTransportistas.Columns(0).Text = "Transportista"
                    ListaTransportistas.Columns.RemoveAt(2)
                    For Each column As ColumnHeader In ListaTransportistas.Columns
                        column.Width = -2
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al listar transportistas.")
            Serilog.Log.Error(ex, "err")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListaTransportistas.SelectedIndex >= 0
            Dim EID As String = ListaTransportistas.SelectedItem.SubItems.Item(1).Text
            If VL_VerLote IsNot Nothing
                VL_VerLote.TransportistaSeleccionado(EID)
                ParentForm.Close
            End If
        End If
    End Sub
End Class
