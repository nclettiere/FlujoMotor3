Imports System.Threading
Imports Logica


Public Class VerInspeccion
    Public Property FormParent As Ventana_Ver
    Private VIN As String

    Friend Sub Populate(VIN As String)
        Me.VIN = VIN
        lblVehiculoVin.Text = "Inspecciones del Vehiculo: " + VIN
        Dim Contador As Integer = 1
        Try
            For Each Inspeccion As DataRow In IObtenerVIN(VIN).Rows
                FlowInspecciones.Controls.Add(DrawInspeccion(
                                              Inspeccion.Item("inspeccionID"),
                                              Contador.ToString, 
                                              Inspeccion.Item("inspeccionFecha").ToString,
                                              Consultar("SELECT empleadonombre FROM empleados WHERE empleadoid="+Inspeccion.Item("operarioid").ToString).Rows(0).Item(0)
                                              ))
                Contador += 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) 
        ''FormParent.GoToSection(1)
    End Sub

    Private Function DrawInspeccion(InspID As String, Numero As String, InspeccionFecha As String, Operario As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(574, 148)
        PanelContenido.BackColor = Color.DimGray
        PanelContenido.Margin = New Padding(3, 3, 3, 10)

        Dim LabelInspeccon As Label = New Label
        Dim LabelFecha As Label = New Label
        Dim LabelOperario As Label = New Label

        LabelInspeccon.AutoSize = True
        LabelFecha.AutoSize = True
        LabelOperario.AutoSize = True

        LabelInspeccon.Text = "Inspeccion #"+ Numero
        LabelFecha.Text = "Realizada el: "+ InspeccionFecha
        LabelOperario.Text = "Operario a Cargo: "+ Operario

        LabelInspeccon.Location = New Point(3, 9)
        LabelFecha.Location = New Point(3, 38)
        LabelOperario.Location = New Point(3, 69)

        LabelInspeccon.ForeColor = Color.Orange
        LabelFecha.ForeColor = Color.Orange
        LabelOperario.ForeColor = Color.Orange

        Dim fuente = New Font("Arial", 10)

        LabelInspeccon.Font = fuente
        LabelFecha.Font = fuente
        LabelOperario.Font = fuente

        Dim BtnVerDanios As Button = New Button
        BtnVerDanios.Size = New Size(111, 33)
        BtnVerDanios.Font = fuente
        BtnVerDanios.ForeColor = Color.Orange
        BtnVerDanios.Text = "Ver Danios"

        Dim BtnAgDanios As Button = New Button
        BtnAgDanios.Size = New Size(150, 33)
        BtnAgDanios.Font = fuente
        BtnAgDanios.ForeColor = Color.Orange
        BtnAgDanios.Text = "Agregar Danios"

        AddHandler BtnVerDanios.Click , Sub(s, ea) VerDanio(s, ea, InspID, PanelContenido)
        AddHandler BtnAgDanios.Click , Sub(s, ea) AgregarDanioI(s, ea, InspID)

        BtnVerDanios.Location = New Point(450, 113)
        BtnAgDanios.Location = New Point(300, 113)

        PanelContenido.Controls.Add(LabelInspeccon)
        PanelContenido.Controls.Add(LabelFecha)
        PanelContenido.Controls.Add(LabelOperario)
        PanelContenido.Controls.Add(BtnVerDanios)
        PanelContenido.Controls.Add(BtnAgDanios)

        Return PanelContenido
    End Function
    Private Sub VerDanio(s As Object, ea As EventArgs, InspID As String, PanelC As Panel)
        If DIObtenerCount(InspID) > 0
            Dim Ventana As Ventana_Ver = New Ventana_Ver
            Dim danios As VerDanios = New VerDanios
            danios.CrearDanios(InspID)
            Ventana.LoadControl(danios)
            Ventana.ShowDialog()
        Else
            MsgBox("Esta Inspeccion no posee danios.")
        End If
    End Sub
    Private Sub AgregarDanioI(s As Object, ea As EventArgs, InspID As String)
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgrDanio As AgregarDanio = New AgregarDanio
        AgrDanio.VIN = VIN
        AgrDanio.InspeccionID = InspID
        Ventana.LoadControl(AgrDanio)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnAddInspeccion_Click(sender As Object, e As EventArgs) Handles btnAddInspeccion.Click
        If MessageBox.Show("Desea agregar una inpeccion? Se asignara la inspeccion a su cuenta.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                IInsertar(VIN, ObtenerOpId)
                FlowInspecciones.Controls.Clear
                Populate(VIN)
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al insertar inspeccion.")
            End Try
        End If
    End Sub
End Class
