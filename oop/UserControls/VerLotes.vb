Imports DB

Public Class VerLotes
    Private Shared _instance As VerLotes

    Public Shared Property Instance As VerLotes
        Get
            If _instance Is Nothing Then
                _instance = New VerLotes()
            End If
            Return _instance
        End Get
        Set(value As VerLotes)
            _instance = value
        End Set
    End Property

    Private Property Conexion As ODBC

    Private Property LoteId As String

    Friend Sub Data(loteid As String, ByRef Conexion As ODBC)
        Me.Conexion = Conexion
        Me.LoteId = loteid

        Try
            Dim ListaVehiculos As DataTable = Conexion.Consultar("SELECT * FROM vehiculos WHERE loteid=" + loteid)
            Dim Lote = Conexion.Consultar("SELECT * FROM lotes WHERE loteid=" + loteid.ToString).Rows(0)
            If ListaVehiculos IsNot Nothing
                Dim Patio = Conexion.Consultar("SELECT * FROM patios WHERE patioid=" + Lote.Item("patioid").ToString).Rows(0)
                If Patio IsNot Nothing
                    labPatio.Text = Patio.Item("pationombre")
                End If
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

    Private Sub BtnEntregar_Click_1(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim result As Integer = MessageBox.Show("Los se encargaran de movilizar el lote.", "Desea entregar el lote?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Conexion.Consultar("UPDATE lotes SET lotedescripcion ='"+ riTeBoDescripcion.Text + ";'" +" WHERE loteid="+ LoteId +";")   
                MessageBox.Show("Lote entregado correctamente.")
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al entregar lote.")
            End Try
        End If
    End Sub
End Class
