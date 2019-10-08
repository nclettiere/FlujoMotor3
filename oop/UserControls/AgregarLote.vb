Imports Logica

Public Class AgregarLote
    Private Shared _instance As AgregarLote
    Public Shared Property Instance As AgregarLote
        Get
            If _instance Is Nothing Then
                _instance = New AgregarLote()
            End If
            Return _instance
        End Get
        Set(value As AgregarLote)
            _instance = value
        End Set
    End Property

    Friend Modo As Integer = 0

    Public Property FormParent As Ventana_Seleccionar
    Public Property ParentControl As AgregarVehiculo

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click

        If Not String.IsNullOrWhiteSpace(tbxNombre.Text)
            If Not String.IsNullOrWhiteSpace(riTeBoDescripcion.Text) Then
                If cbxPatio.SelectedIndex >= 0
                    Dim datos As String() = {riTeBoDescripcion.Text.ToString, cbxPatio.Text.ToString, "'"+tbxNombre.Text.ToString+"'"}
                    If Modo = 0
                        ParentControl.UpdateLotes(datos)
                        FormParent.Close()
                    Else
                        If LInsertar(datos)
                            MessageBox.Show("Lote Agregado Correctamente.")
                            ParentForm.Close
                        Else
                            MessageBox.Show("Error al inserar lote. Vea el log porfavort dddxd")
                        End If
                    End If
                Else
                    MessageBox.Show("Debes seleccionar un patio.")
                End If
            Else
                MessageBox.Show("La descripcion no debe quedar vacia.")
            End If
        Else
            MessageBox.Show("El Nombre no debe quedar vacio.")
        End If
    End Sub

    Friend Sub CargarDatos(ventanita_Seleccionar As Ventana_Seleccionar, parent As Object)
        FormParent = ventanita_Seleccionar
        ParentControl = DirectCast(parent, AgregarVehiculo)
    End Sub

    Private Sub OnAgLoteLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ConsultaPatios As DataTable = PObtenerAll
            For Each item As DataRow In ConsultaPatios.Rows
                cbxPatio.Items.Add(item(1).ToString)
            Next
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error.")
        End Try
    End Sub
End Class
