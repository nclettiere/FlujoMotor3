Public Class Ver_Inspeccionsilla
     Private Shared _instance As Ver_Inspeccionsilla

    Public Shared Property Instance As Ver_Inspeccionsilla
        Get
            If _instance Is Nothing Then
                _instance = New Ver_Inspeccionsilla()
            End If
            Return _instance
        End Get
        Set(value As Ver_Inspeccionsilla)
            _instance = value
        End Set
    End Property

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub Populate(VIN As String,ByRef Conexion As DB.ODBC)
        lblVehiculoVin.Text = "Viendo Vehiculo: " + VIN
        Dim ResultadoInspecciones As DataTable = Conexion.consultar("SELECT * FROM inspecciones WHERE vehiculovin='" + VIN +"'")
        If ResultadoInspecciones IsNot Nothing
            Dim index As Integer = 0
            MessageBox.Show(ResultadoInspecciones.Rows.Count.ToString)
            For Each row As DataRow In ResultadoInspecciones.Rows
                Dim widget As New InspeccionWidget()
                MessageBox.Show(row("inspeccionid").ToString)
                widget.CargarDatos(row("inspeccionid").ToString, Conexion, index)
                MainWidgets.Controls.Add(widget)
                index = index + 1
            Next row
        End If
    End Sub
End Class
