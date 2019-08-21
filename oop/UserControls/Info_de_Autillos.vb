Imports oop
Imports Serilog

Public Class Info_de_Autillos

    Private Shared _instance As Info_de_Autillos

    Public Shared Property Instance As Info_de_Autillos
        Get
            If _instance Is Nothing Then
                _instance = New Info_de_Autillos()
            End If
            Return _instance
        End Get
        Set(value As Info_de_Autillos)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Menu_Wapo

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG
        If FormParent.FormParent.Conexion IsNot Nothing
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos")
            DataGridViewVehiculos.DataSource = resultado
        Else
            Console.WriteLine("######[POTENTIAL ERROR]######" + Environment.NewLine + "Menu.Conexion was NULL on 'Info_de_Autillos.vb'" + Environment.NewLine + "######[END POTENTIAL ERROR]######")
        End If
#End If

        DataGridViewVehiculos.MultiSelect = False
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        If tbxBuscarVin.Text.Length > 0
            '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos WHERE vehiculovin LIKE '%" + tbxBuscarVin.Text.ToUpper + "%'")
            DataGridViewVehiculos.DataSource = resultado
        Else
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos")
            DataGridViewVehiculos.DataSource = resultado
        End If

    End Sub

    Private Sub OnTabChange(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM lotes")
            DataGridViewLotes.DataSource = resultado
        End If
    End Sub

    Private Sub BtActualizarVehiculo_Click(sender As Object, e As EventArgs) Handles btActualizarVehiculo.Click
        If tbxBuscarVin.Text.Length > 0
            '' LAS LETRAS DEL VIN TIENEN QUE SER CAPITAL LETTERS.
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos WHERE vehiculovin LIKE '%" + tbxBuscarVin.Text.ToUpper + "%'")
            DataGridViewVehiculos.DataSource = resultado
        Else
            Dim resultado As DataTable = FormParent.Conexion.consultar("SELECT * FROM vehiculos")
            DataGridViewVehiculos.DataSource = resultado
        End If
    End Sub

    Private Sub BtInfoVehiculo_Click(sender As Object, e As EventArgs) Handles btInfoVehiculo.Click
        Try
            Dim IndiceSeleccion As Integer = DataGridViewVehiculos.SelectedCells(0).RowIndex
            Dim VentanaVer As Ventanita_Ver = New Ventanita_Ver
            Ver_Vehiculillo.Instance.Data(Me, DataGridViewVehiculos.Rows(IndiceSeleccion).Cells(0).Value.ToString, VentanaVer, FormParent.Conexion)
            VentanaVer.LoadControl(Ver_Vehiculillo.Instance)
            VentanaVer.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class
