Public Class VerPosicion
    Private Shared _instance As VerPosicion

    Public Shared Property Instance As VerPosicion
        Get
            If _instance Is Nothing Then
                _instance = New VerPosicion()
            End If
            Return _instance
        End Get
        Set(value As VerPosicion)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Menu
    Public Property Conexion As DB.ODBC
    Public Property VIN As String

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim LoteId As String = Conexion.consultar("SELECT loteid FROM vehiculos WHERE vehiculovin='"+ VIN +"'").Rows(0).Item(0).ToString
            Dim PatioId As String = Conexion.consultar("SELECT patioid FROM lotes WHERE loteid="+ LoteId).Rows(0).Item(0).ToString
            Dim SubZonas As DataRowCollection = Conexion.consultar("SELECT * FROM subzonas WHERE patioid="+ PatioId).Rows()

            If SubZonas.Count > 0
                Dim ConsultaPatios As DataTable = conexion.consultar("SELECT * FROM patios")
                For Each item As DataRow In SubZonas
                    cbxZona.Items.Add(item("subzonanombre").ToString)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
