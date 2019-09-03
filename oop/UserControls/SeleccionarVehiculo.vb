Imports Logica

Public Class SeleccionarVehiculo
    Private Shared _instance As SeleccionarVehiculo

    Friend FormParent As Ventana_Seleccionar

    Private _VinSeleccionado As String

    Public Shared Property Instance As SeleccionarVehiculo
        Get
            If _instance Is Nothing Then
                _instance = New SeleccionarVehiculo()
            End If
            Return _instance
        End Get
        Set(value As SeleccionarVehiculo)
            _instance = value
        End Set
    End Property

    Friend Property SubZonaNombre As String
    Friend Property ZonaId As String

    Public Property VinSeleccionado As String
        Get
            Return _VinSeleccionado
        End Get
        Set(value As String)
            _VinSeleccionado = value
        End Set
    End Property

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Dim Columna As Integer
        Dim Fila As Integer
        If Not String.IsNullOrWhiteSpace(VinSeleccionado)
            If Not String.IsNullOrWhiteSpace(tbxColumna.Text)
                If Integer.TryParse(tbxColumna.Text, Columna)
                    If Not String.IsNullOrWhiteSpace(tbxFila.Text)
                        If Integer.TryParse(tbxFila.Text, Fila)
                            Try
                                Dim VehiculosAparcados = VSZInsertar(VinSeleccionado, SubzonaNombre, ZonaId, Columna.ToString, Fila.ToString)
                                MessageBox.Show("Vehiculo agregado en subzona correctamente.")
                                ParentForm.Close()
                            Catch ex As Exception
                                Serilog.Log.Error(ex, "Error al insertarvehiculo en subzona.")
                            End Try
                             
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub OnSelecVecloLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim VehiculosAparcados = VSZObtenerVIN()
            Dim QueryFiltro As String = ""
            Dim Contador As Integer = 0
            Dim Max = VehiculosAparcados.Rows.Count
            For Each AparcadoRow As DataRow In VehiculosAparcados.Rows
                If Contador < Max - 1
                    QueryFiltro = QueryFiltro + " vehiculovin='"+ AparcadoRow.Item("vehiculovin") + "' OR"
                Else
                    QueryFiltro = QueryFiltro + " vehiculovin='"+ AparcadoRow.Item("vehiculovin") + "')"
                End If
                Serilog.Log.Information(Contador.ToString)
                Contador += 1
            Next

            Dim VehiculosDataTable As DataTable
            If Not String.IsNullOrWhiteSpace(QueryFiltro)
                '' Obtiene los vehiculos que no estan en una subzona.
                VehiculosDataTable = VObtenerAllFiltro("vehiculovin NOT IN (SELECT vehiculovin FROM vehiculosubzona WHERE"+ QueryFiltro)
            Else
                VehiculosDataTable = VObtenerAll()
            End If
            
            DataGridVehiculos.DataSource = VehiculosDataTable

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al obtener vehiculos.")
        End Try
    End Sub

    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles DataGridVehiculos.SelectionChanged
        if DataGridVehiculos.SelectedRows.Count <> 0
            Dim fila As DataGridViewRow = DataGridVehiculos.SelectedRows(0)
            VinSeleccionado = fila.Cells("vehiculovin").Value.ToString
            lblSeleccionVin.Text = "Vehiculo Seleccionado: "+ VinSeleccionado
        End If
    End Sub
End Class
