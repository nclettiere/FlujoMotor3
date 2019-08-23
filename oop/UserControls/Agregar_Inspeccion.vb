Imports DB

Public Class Agregar_Inspeccion
        Private Shared _instance As Agregar_Inspeccion
    Public Shared Property Instance As Agregar_Inspeccion
        Get
            If _instance Is Nothing Then
                _instance = New Agregar_Inspeccion()
            End If
            Return _instance
        End Get
        Set(value As Agregar_Inspeccion)
            _instance = value
        End Set
    End Property

    Public Shared Property ListaVehiculosSeleccionados As List(Of String)
    Public Property FormParent As Ventanita_Ver
    Public Property ParentControl As Agregar_Vehiculillo
    Public Property Conexion As DB.ODBC
    Public Property Cliente As String
    Public Property vin As String

    Private Sub Agregar_Inspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub CargarDatos(VIN As String, conexion As ODBC)
        labVIN.Text = VIN
        Me.vin = VIN
        Me.Conexion = conexion
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            Dim InpeccioensCount As DataTable = Conexion.consultar("SELECT COUNT(*) FROM inspecciones")
            Dim CrearInspeccion As DataTable = Conexion.consultar("INSERT INTO inspecciones (inspeccionid, vehiculovin, operariopatioid) VALUES("+ (InpeccioensCount.Rows(0).Item(0) + 1).ToString +",'"+ VIN +"', 3)")
        Catch ex As Exception
            Serilog.Log.Error(ex, "Posible valor nulo en Agregar Inspeccion.")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
End Class