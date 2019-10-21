Imports Logica

Public Class ManageUsuarios
    Private Sub OnMUload(sender As Object, e As EventArgs) Handles MyBase.Load
        dataLstUsuarios.DataSource = UObtenerAll

        For Each column As ColumnHeader In dataLstUsuarios.Columns
            column.Width = -2
        Next
    End Sub

    Private Sub BtnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click 
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgregarUsuario = New AgregarUsuario
        AgregarUsuario.FormAnterior = Me
        Ventana.LoadControl(AgregarUsuario)
        Ventana.ShowDialog
    End Sub

    Friend Sub ActualizarLista
        dataLstUsuarios.DataSource = Nothing
        dataLstUsuarios.DataSource = UObtenerAll
    End Sub

    Private Sub SelectionChanged(sender As Object, e As EventArgs) Handles dataLstUsuarios.SelectedIndexChanged 
        If dataLstUsuarios.SelectedIndex >= 0
            btnEliminar.Enabled = True
            Try
                Dim EmpleadoId As String = dataLstUsuarios.SelectedItem.SubItems.Item(1).Text
                Dim Usuario As String = dataLstUsuarios.SelectedItem.SubItems.Item(0).Text
                Dim OpTipo As Integer = ObtenerTipoOperario(EmpleadoId)
 
                Select OpTipo
                    Case 0
                        lblOpTipo.Text = "Tipo de Operario: Puerto"
                        Dim NroVIngresados As Integer
                        Dim NroLIngresados As Integer
                        Dim NroLAsign As Integer

                        lblNroVvendidos.Visible = False
                        lblNroLEntrgados.Visible = False

                        If Integer.TryParse(Consultar("SELECT COUNT(*) FROM vehiculos WHERE operariopuertoid="+ EmpleadoId).Rows(0).Item(0).ToString, NroVIngresados)
                            lblNroVIngresados.Text = "Nro. Vehiculos Ingresados: "+ NroVIngresados.ToString
                        Else
                            lblNroVIngresados.Text = "Nro. Vehiculos Ingresados: -"
                        End If

                        If Integer.TryParse(Consultar("SELECT COUNT(*) FROM lotes WHERE operariopuertoid="+ EmpleadoId).Rows(0).Item(0).ToString, NroLIngresados)
                            lblNroLIngresados.Text = "Nro. Lotes Ingresados: "+ NroLIngresados.ToString
                        Else
                            lblNroLIngresados.Text = "Nro. Lotes Ingresados: -"
                        End If

                        If Integer.TryParse(Consultar("SELECT COUNT(*) FROM lotes WHERE operariopuertoid="+ EmpleadoId + " AND lotefechasalida IS NOT NULL").Rows(0).Item(0).ToString, NroLAsign)
                            lblNroLAsign.Text = "Nro. Lotes Asignados: "+ NroLAsign.ToString
                        Else
                            lblNroLAsign.Text = "Nro. Lotes Asignados: -"
                        End If
                    Case 1
                        lblNroVIngresados.Visible = False
                        lblNroLIngresados.Visible = False
                        lblNroLEntrgados.Visible = False
                        lblOpTipo.Text = "Tipo de Operario: Patio"
                    Case 2
                        lblNroVIngresados.Visible = False
                        lblNroLIngresados.Visible = False
                        lblNroVvendidos.Visible = False
                        lblNroLAsign.Visible = False
                        lblNroLEntrgados.Visible = True
                        lblOpTipo.Text = "Tipo de Operario: Transportista"

                        Dim NroLEntrega As Integer

                        If Integer.TryParse(Consultar("SELECT COUNT(*) FROM lotes WHERE transportistaid="+ EmpleadoId + " AND lotefechallegada IS NOT NULL").Rows(0).Item(0).ToString, NroLEntrega)
                            lblNroLEntrgados.Text = "Nro. Lotes Entregados: "+ NroLEntrega.ToString
                        Else
                            lblNroLEntrgados.Text = "Nro. Lotes Entregados: -"
                        End If
                End Select

                Dim Nombre As String = dataLstUsuarios.SelectedItem.SubItems.Item(3).Text
                Dim Apellido As String = dataLstUsuarios.SelectedItem.SubItems.Item(4).Text

                lblNombre.Text = "Nombre: " + Nombre + " " + Apellido
                lblUsuer.Text = "Usuario: " + Usuario

            Catch ex As Exception
                Serilog.Log.Error(ex, "err")
            End Try
        Else
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click 
        Try
            Dim Usuario As String = dataLstUsuarios.SelectedItem.SubItems.Item(0).Text
            Dim EmpleadoId As String = dataLstUsuarios.SelectedItem.SubItems.Item(1).Text
            Dim dialogResult As DialogResult = MessageBox.Show("Deseas Eliminar a: "+ Usuario +"?", "Eliminar Usuario", MessageBoxButtons.YesNo)

            If dialogResult = DialogResult.Yes Then
                If UEliminar(EmpleadoId)
                    ActualizarLista
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar usuario.")
            Serilog.Log.Error(ex, "Error al eliminar usuario.")
        End Try
    End Sub
End Class
