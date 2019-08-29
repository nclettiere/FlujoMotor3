Imports System.Threading

Public Class VerInspeccion
    Private Shared _instance As VerInspeccion

    Public Shared Property Instance As VerInspeccion
        Get
            If _instance Is Nothing Then
                _instance = New VerInspeccion()
            End If
            Return _instance
        End Get
        Set(value As VerInspeccion)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Ventana_Ver

    Friend Sub Populate(VIN As String, ByRef Conexion As DB.ODBC)
        lblVehiculoVin.Text = "Viendo Vehiculo: " + VIN
        Dim ResultadoInspecciones As DataTable = Conexion.Consultar("SELECT * FROM inspecciones WHERE vehiculovin='" + VIN + "'")
        If ResultadoInspecciones IsNot Nothing
            Dim index As Integer = 0
            If ResultadoInspecciones.Rows.Count <> 0
                MainWidgets.Controls.Clear
                For Each row As DataRow In ResultadoInspecciones.Rows
                    Dim widget As New InspeccionWidget()
                    widget.CargarDatos(row("inspeccionid").ToString, Conexion, index)
                    MainWidgets.Controls.Add(widget)
                    widget.Height = 220
                    widget.Width = 1000
                    widget.Dock = DockStyle.Top
                    index += 1
                Next row
            Else
                MessageBox.Show("Este vehiculo no tiene inspecciones.")
                Thread.Sleep(1000)
                FormParent.GoToSection(1)
            End If
        Else
            MessageBox.Show("Este vehiculo no tiene inspecciones.")
            Thread.Sleep(1000)
            FormParent.GoToSection(1)
        End If
        Me.Size = MainWidgets.Size
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        FormParent.GoToSection(1)
    End Sub
End Class
