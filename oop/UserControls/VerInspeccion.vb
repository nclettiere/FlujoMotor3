Imports System.Threading
Imports Logica

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

    Friend Sub Populate(VIN As String)
        lblVehiculoVin.Text = "Viendo Vehiculo: " + VIN
        Dim ResultadoInspecciones As DataTable = IObtenerVIN(VIN)
        If ResultadoInspecciones IsNot Nothing Then
            Dim index As Integer = 0
            If ResultadoInspecciones.Rows.Count <> 0 Then
                Dim Inspecciones As DataTable = IObtenerVIN(VIN, " AND inspeccionid not in(select inspeccionid from inspecciondanio)")
                DataGridInspecciones.DataSource = Inspecciones
                Dim QueryFiltro As String = String.Empty
                Dim Length = ResultadoInspecciones.Rows.Count - 1
                Dim Contador As Integer = 0
                For Each Row As DataRow in ResultadoInspecciones.Rows
                    Try
                        If Contador < Length
                            QueryFiltro = QueryFiltro + "inspeccionid=" +  Row.Item("inspeccionid").ToString + " OR "
                        Else
                            QueryFiltro = QueryFiltro  + "inspeccionid=" + Row.Item("inspeccionid").ToString
                        End If
                    Catch ex As Exception

                    End Try
                    Contador += 1
                Next

                Dim InspeccionesDanio As DataTable = DObtenerFiltro("danioid IN (SELECT danioid FROM inspecciondanio WHERE "+ QueryFiltro +")")
                DataGridDanios.DataSource = InspeccionesDanio
                DataGridDanios.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridDanios.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridDanios.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DataGridDanios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
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
