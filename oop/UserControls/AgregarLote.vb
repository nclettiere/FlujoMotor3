Imports Logica

Public Class AgregarLote

    Friend UC_AgregarVehiculo As AgregarVehiculo
    Friend Modo As Integer = 0

    Private Sub OnAlLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ConsultaPatios As DataTable = PObtenerAll()
            If ConsultaPatios IsNot Nothing
                If ConsultaPatios.Rows.Count > 0
                Else
                    MsgBox("No hay patios disponibles. Cree uno para continuar.")
                    btnAgregar.Enabled = False
                End If
            Else
                MsgBox("No hay patios disponibles. Cree uno para continuar.")
                btnAgregar.Enabled = False
            End If

            For Each item As DataRow In ConsultaPatios.Rows
                cbxPatios.Items.Add(item(1).ToString)
            Next

            cbxPatios.SelectedIndex = 0
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error.")
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not String.IsNullOrWhiteSpace(tbxNombre.Text) Then

            If Not String.IsNullOrWhiteSpace(rtbDesc.Text) Then

                If cbxPatios.SelectedIndex >= 0 Then

                    If UC_AgregarVehiculo IsNot Nothing Then
                        Dim loteid = "0"
                        Try
                            loteid = (Consultar("SELECT MAX(loteid) FROM lotes").Rows(0).Item(0) + 1).ToString
                        Catch ex As Exception

                        End Try
                        UC_AgregarVehiculo.CargarLoteNuevo(loteid, True, rtbDesc.Text, tbxNombre.Text, ObtenerOpId, cbxPatios.Text)
                        ParentForm.Hide()
                    Else
                        LInsertar(rtbDesc.Text, tbxNombre.Text, ObtenerOpId, cbxPatios.Text)
                        MsgBox("Lote Insertado.")
                        ParentForm.Close()
                    End If
                Else
                    MsgBox("Debes seleccionar un patio")
                End If
            Else
                MsgBox("Debes una descripcion")
            End If
        Else
            MsgBox("Debes ingresar un nombre para el lote")
        End If
    End Sub

    Friend Function Insertar() As Boolean
        MsgBox("Hello")
        Try
            LInsertar(rtbDesc.Text, tbxNombre.Text, ObtenerOpId, cbxPatios.Text)
            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "err")
            Return False
        End Try
    End Function
End Class
