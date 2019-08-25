Imports DB

Public Class Ver_Lotesillo
    Private Shared _instance As Ver_Lotesillo

    Public Shared Property Instance As Ver_Lotesillo
        Get
            If _instance Is Nothing Then
                _instance = New Ver_Lotesillo()
            End If
            Return _instance
        End Get
        Set(value As Ver_Lotesillo)
            _instance = value
        End Set
    End Property

    Private Property Ventana As Ventanita_Ver
    Private Property InfoAutos As Info_de_Autillos
    Private Property Conexion As ODBC

    Private Property LoteId As String

    Friend Sub Data(info_de_Autillos As Info_de_Autillos, loteid As String, ByRef Ventana As Ventanita_Ver, ByRef Conexion As ODBC)
        InfoAutos = info_de_Autillos
        Me.Ventana = Ventana
        Me.Conexion = Conexion
        Me.LoteId = loteid

        Try
            Dim ListaVehiculos As DataTable = Conexion.consultar("SELECT * FROM vehiculos WHERE loteid=" + loteid)
            Dim Lote = Conexion.consultar("SELECT * FROM lotes WHERE loteid=" + loteid).Rows(0)
            If ListaVehiculos IsNot Nothing
                DataGridViewVehiculos.DataSource = ListaVehiculos
                labId.Text = Lote.Item("loteid")
                riTeBoDescripcion.Text = Lote.Item("lotedescripcion")
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error Al listar vehiculo o lote. ref Ver_Lote.vb")
        End Try
    End Sub

    Private Sub Ver_Lotesillo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim result As Integer = MessageBox.Show("Los se encargaran de movilizar el lote.", "Desea entregar el lote?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Conexion.consultar("UPDATE lotes SET lotedescripcion ='"+ riTeBoDescripcion.Text + ";'" +" WHERE loteid="+ LoteId +";")   
            MessageBox.Show("Lote entregado correctamente.")
        End If
    End Sub
End Class
