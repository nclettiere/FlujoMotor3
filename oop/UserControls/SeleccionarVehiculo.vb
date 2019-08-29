Imports DB

Public Class SeleccionarVehiculo
    Private Shared _instance As SeleccionarVehiculo
    Friend Property Conexion As DB.ODBC

    Friend _FormParent As Ventana_Seleccionar

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

    Public Property FormParent As Ventana_Seleccionar
        Get
            Return _FormParent
        End Get
        Set(value As Ventana_Seleccionar)
            _FormParent = value
        End Set
    End Property

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        
    End Sub

    Private Sub OnSelecVecloLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim VehiculosAparcados = Conexion.Consultar("SELECT vehiculovin FROM vehiculosubzona")
            Dim QueryFiltro As String = ""
            Dim Contador As Integer = 0
            Dim Max = VehiculosAparcados.Rows.Count
            For Each AparcadoRow As DataRow In VehiculosAparcados.Rows
                If Contador < Max - 1
                    QueryFiltro = QueryFiltro + " vehiculovin='"+ AparcadoRow.Item("vehiculovin") + "' OR"
                Else
                    QueryFiltro = QueryFiltro + " vehiculovin='"+ AparcadoRow.Item("vehiculovin") + "'"
                End If
                Serilog.Log.Information(Contador.ToString)
                Contador += 1
            Next

            Dim VehiculosDataTable As DataTable
            If Not String.IsNullOrWhiteSpace(QueryFiltro)
                VehiculosDataTable = Conexion.Consultar("SELECT DISTINCT * FROM vehiculos WHERE vehiculovin NOT IN (SELECT vehiculovin FROM vehiculosubzona WHERE"+ QueryFiltro +")")
            Else
                VehiculosDataTable = Conexion.Consultar("SELECT * FROM vehiculos")
            End If
            
            DataGridVehiculos.DataSource = VehiculosDataTable

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al obtener vehiculos.")
        End Try
    End Sub
End Class
