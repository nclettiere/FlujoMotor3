Public Class VerPatio
    Private Shared _instance As VerPatio

    Public Shared Property Instance As VerPatio
        Get
            If _instance Is Nothing Then
                _instance = New VerPatio()
            End If
            Return _instance
        End Get
        Set(value As VerPatio)
            _instance = value
        End Set
    End Property

    Public Property FormParent As MenuControl
    Public Property Conexion As DB.ODBC

    Private Sub BtnPos_Click(sender As Object, e As EventArgs) Handles btnPos.Click
        Dim VentanaVer = New Ventanita_Ver()
        Dim vin = DataGridViewVehiculos.SelectedRows(0).Cells(0).Value.ToString
        VentanaVer.GoToSection(2, vin, Conexion)
        VentanaVer.ShowDialog()
    End Sub

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos")
            DataGridViewVehiculos.DataSource = resultado
            DataGridViewVehiculos.MultiSelect = False
        Catch ex As Exception
            Serilog.Log.Warning(ex, "Error Al Cargar Vehiculos. VerPatio")
        End Try
    End Sub
End Class
