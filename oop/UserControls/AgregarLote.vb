Imports Logica

Public Class AgregarLote

    Friend UC_AgregarVehiculo As AgregarVehiculo
    Friend UC_InfoAutos As InfoAutos
    Friend Modo As Integer = 0

    Private Sub OnAlLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateLang

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
                        MsgBox(_Lang.ObtenerKey("AgregarLote", 9))
                        If UC_InfoAutos IsNot Nothing
                            UC_InfoAutos.ActualizarLotes
                        End If
                        ParentForm.Close()
                    End If
                Else
                    MsgBox(_Lang.ObtenerKey("AgregarLote", 8))
                End If
            Else
                MsgBox(_Lang.ObtenerKey("AgregarLote", 7))
            End If
        Else
            MsgBox(_Lang.ObtenerKey("AgregarLote", 6))
        End If
    End Sub

    Friend Function Insertar() As Boolean
        Try
            LInsertar(rtbDesc.Text, tbxNombre.Text, ObtenerOpId, cbxPatios.Text)
            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "err")
            Return False
        End Try
    End Function

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("AgregarLote", 0)
        Label1.Text = _Lang.ObtenerKey("AgregarLote", 1)
        Label2.Text = _Lang.ObtenerKey("AgregarLote", 2)
        Label3.Text = _Lang.ObtenerKey("AgregarLote", 3)
        Label4.Text = _Lang.ObtenerKey("AgregarLote", 4)
        btnAgregar.Text = _Lang.ObtenerKey("AgregarLote", 5)
    End Sub
End Class
