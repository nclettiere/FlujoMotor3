Imports System.Threading
Imports oop

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

    Public Property FormParent As Ventanita_Ver

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub Populate(VIN As String, ByRef Conexion As DB.ODBC)
        lblVehiculoVin.Text = "Viendo Vehiculo: " + VIN
        Dim ResultadoInspecciones As DataTable = Conexion.consultar("SELECT * FROM inspecciones WHERE vehiculovin='" + VIN + "'")
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
                    Me.ClientSize = widget.Size
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
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        FormParent.GoToSection(1)
    End Sub
End Class
