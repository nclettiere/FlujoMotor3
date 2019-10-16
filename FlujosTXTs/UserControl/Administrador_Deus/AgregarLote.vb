Imports Logica
Public Class AgregarLote

    Friend UC_AgregarVehiculo As AgregarVehiculo 


    Private Sub OnAlLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ConsultaPatios As DataTable = PObtenerAll
            For Each item As DataRow In ConsultaPatios.Rows
                cbxPatios.Items.Add(item(1).ToString)
            Next

            cbxPatios.SelectedIndex = 0
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error.")
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not String.IsNullOrWhiteSpace(tbxNombre.Text)
            If Not String.IsNullOrWhiteSpace(rtbDesc.Text)
                If cbxPatios.SelectedIndex >= 0
                    If UC_AgregarVehiculo IsNot Nothing
                        Dim loteid As String = (Consultar("SELECT MAX(loteid) FROM lotes").Rows(0).Item(0) + 1).ToString
                        UC_AgregarVehiculo.CargarLoteNuevo(loteid, false, New Action(Sub() LInsertar(rtbDesc.Text, tbxNombre.Text, ObtenerOpID, cbxPatios.Text)))
                        ParentForm.Hide
                    Else 
                        LInsertar(rtbDesc.Text, tbxNombre.Text, ObtenerOpID, cbxPatios.Text)
                        MsgBox("Lote Insertado.")
                        ParentForm.Close
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
            LInsertar(rtbDesc.Text, tbxNombre.Text, ObtenerOpID, cbxPatios.Text)
            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "err")
            Return fALSE
        End Try
    End Function
End Class
