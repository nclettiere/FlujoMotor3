Imports Logica

Public Class SeleccionarLotes
    Private Shared _instance As SeleccionarLotes

    Public Shared Property Instance As SeleccionarLotes
        Get
            If _instance Is Nothing Then
                _instance = New SeleccionarLotes()
            End If
            Return _instance
        End Get
        Set(value As SeleccionarLotes)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Ventana_Seleccionar
    Public Property ParentControl As AgregarVehiculo

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) 
         'If lisBoLote.SelectedItems.Count > 0
         '   Ventanita_Seleccionar.SelectedLote = (lisBoLote.SelectedItems(0))  
         '   Ventanita_Seleccionar.UpdateLotes()
         'End If
    End Sub

    Friend Sub CargarDatos(ventanita_Seleccionar As Ventana_Seleccionar, parent As Object)
        FormParent = ventanita_Seleccionar
        ParentControl = DirectCast(parent, AgregarVehiculo)
        Try
            Dim resultadoLotes As DataTable = LObtenerAll
            If resultadoLotes IsNot Nothing
                DataGridViewLotes.DataSource = resultadoLotes
                Else
                MessageBox.Show("Error al cargar lotes. Vea el log para mas informacion.")
                Serilog.Log.Warning("Posible valor nulo en Seleccionar_Lotesillo. ref: resultadoLotes.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al hacer consulta. Vea el log para mas informacion.")
            Serilog.Log.Fatal("Posible error de conexion. Chequee la VM.")
        End Try
    End Sub

    Private Sub BtSelecc_Click(sender As Object, e As EventArgs) Handles btSelecc.Click
        Try
            Dim rowSeleccionado = DataGridViewLotes.SelectedRows(0).Cells()
            If rowSeleccionado IsNot Nothing Then

                ParentForm.Close()
            Else
                Serilog.Log.Error("Posible valor nulo en Seleccionar_Lotesillo. ref: rowSeleccionado")
            End If         
        Catch ex As Exception
            Serilog.Log.Warning("Posible valor nulo en Seleccionar_Lotesillo. ref: rowSeleccionado")
        End Try
    End Sub
End Class
