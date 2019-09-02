Imports Logica

Public Class VerZonas

    Friend Property PatioId As String

    Private Function CrearZonaInfo(ZonaId As String, SubZonas As String) As Control
        Dim PanelFlow As FlowLayoutPanel = New FlowLayoutPanel
        Dim PanelContenido As Panel = New Panel

        PanelFlow.AutoSize = True
        PanelContenido.Size = New Size(571, 88)
        PanelContenido.MinimumSize = New Size(571, 0)
        PanelContenido.MaximumSize = New Size(571, 0)
        PanelContenido.AutoSize = True
        PanelContenido.BackColor = Color.Gray
        PanelContenido.Dock = DockStyle.Top

        Dim LabelId As Label = New Label
        Dim LabelCantidad As Label = New Label

        LabelId.AutoSize = True
        LabelCantidad.AutoSize = True

        LabelId.Text = "Zona ID: "+ ZonaId
        LabelCantidad.Text = "SubZonas: "+ SubZonas

        LabelId.Location = New Point(14, 16)
        LabelCantidad.Location = New Point(14, 41)

        LabelId.ForeColor = Color.Orange
        LabelCantidad.ForeColor = Color.Orange

        Dim fuente = New Font("Arial", 10)

        LabelId.Font = fuente
        LabelCantidad.Font = fuente

        Dim BtnSubZona As Button = New Button
        BtnSubZona.Size = New Size(145, 75)
        BtnSubZona.Font = fuente
        BtnSubZona.ForeColor = Color.Orange
        BtnSubZona.Text = "Ver/Agregar SubZonas"

        AddHandler BtnSubZona.Click , Sub(s, ea) SubZonasClick(s, ea, PanelFlow, ZonaId)

        BtnSubZona.Location = New Point(300, 0)

        PanelContenido.Controls.Add(LabelId)
        PanelContenido.Controls.Add(LabelCantidad)
        PanelContenido.Controls.Add(BtnSubZona)

        PanelFlow.Controls.Add(PanelContenido)
        Return PanelFlow
    End Function

    Private Function CrearSubZona(SubZonaNombre As String, ZonaId As String, Capacidad As String, Vehiculos As String) As Control
        Dim PanelFlow As FlowLayoutPanel = New FlowLayoutPanel
        Dim PanelContenido As Panel = New Panel

        PanelFlow.AutoSize = True
        PanelContenido.Size = New Size(571, 88)
        PanelContenido.MinimumSize = New Size(571, 0)
        PanelContenido.MaximumSize = New Size(571, 0)
        PanelContenido.AutoSize = True
        PanelContenido.BackColor = Color.Gray
        PanelContenido.Dock = DockStyle.Top

        Dim LabelSubZonaNombre As Label = New Label
        Dim LabelCapacidad As Label = New Label
        Dim LabelCantidad As Label = New Label

        LabelSubZonaNombre.AutoSize = True
        LabelCantidad.AutoSize = True

        LabelSubZonaNombre.Text = "SubZona Nombre: "+ SubZonaNombre
        LabelCapacidad.Text = "Capacidad: "+ Capacidad
        LabelCantidad.Text = "Vehiculos en Subzona: "+ Vehiculos

        LabelSubZonaNombre.Location = New Point(14, 16)
        LabelCapacidad.Location = New Point(14, 41)
        LabelCantidad.Location = New Point(14, 65)

        LabelSubZonaNombre.ForeColor = Color.Orange
        LabelCapacidad.ForeColor = Color.Orange
        LabelCantidad.ForeColor = Color.Orange

        Dim fuente = New Font("Arial", 10)

        LabelSubZonaNombre.Font = fuente
        LabelCapacidad.Font = fuente
        LabelCantidad.Font = fuente

        Dim BtnSubZonaMod As Button = New Button
        BtnSubZonaMod.AutoSize = True
        BtnSubZonaMod.Font = fuente
        BtnSubZonaMod.ForeColor = Color.Orange
        BtnSubZonaMod.Text = "Modificar"

        Dim BtnSubZonaAparcar As Button = New Button
        BtnSubZonaAparcar.AutoSize = True
        BtnSubZonaAparcar.Font = fuente
        BtnSubZonaAparcar.ForeColor = Color.Orange
        BtnSubZonaAparcar.Text = "Aparcar Vehiculo"

        AddHandler BtnSubZonaAparcar.Click , Sub(s, ea) AparcarVehiculo(s, ea, SubzonaNombre, ZonaId)
        AddHandler BtnSubZonaMod.Click , Sub(s, ea) ModificarVehiculo(s, ea, SubzonaNombre)

        BtnSubZonaMod.Location = New Point(360, 12)
        BtnSubZonaAparcar.Location = New Point(360, 57)

        PanelContenido.Controls.Add(LabelSubZonaNombre)
        PanelContenido.Controls.Add(LabelCapacidad)
        PanelContenido.Controls.Add(LabelCantidad)
        PanelContenido.Controls.Add(BtnSubZonaMod)
        PanelContenido.Controls.Add(BtnSubZonaAparcar)

        PanelFlow.Controls.Add(PanelContenido)
        Return PanelFlow
    End Function

    Private Sub ModificarVehiculo(s As Object, ea As EventArgs, subzonaNombre As String)
        Dim VentanaVer As Ventana_Ver = New Ventana_Ver
        Dim ModSubZona = New ModificarSubzona
        ModSubZona.SubZonaNombre = subzonaNombre
        VentanaVer.LoadControl(ModSubZona)
        VentanaVer.ShowDialog()
    End Sub

    Private Sub AparcarVehiculo(s As Object, ea As EventArgs, subzonaNombre As String, zonaid As String)
        Dim VentanaVer As Ventana_Ver = New Ventana_Ver
        Dim SelecVehiculo = New SeleccionarVehiculo
        SelecVehiculo.ZonaId = zonaid
        SelecVehiculo.SubZonaNombre = subzonaNombre
        VentanaVer.LoadControl(SelecVehiculo)
        VentanaVer.ShowDialog()
    End Sub

    Private Abierto As Boolean = False

    Private Sub SubZonasClick(s As Object, ea As EventArgs, panelContenido As FlowLayoutPanel, zonaId As String)
        If Abierto
            Dim CantidadSubZonas = panelContenido.Controls.Count -1

            Try
                For indice = CantidadSubZonas To 1 step -1
                    panelContenido.Controls.RemoveAt(indice)
                Next
            Catch
            End Try

            Abierto = False
            DirectCast(s, Button).Text = "Ver/Agregar SubZonas"
        Else
            Dim ContadorSubZonas = SZObtenerCount(zonaId)
   
            If ContadorSubZonas > 0
                Dim ConsultaSubZona = SZObtenerId(zonaId)

                Dim ContadorVehiculos = SZObtenerCountNombre(ConsultaSubZona(0).Item("subzonanombre"))

                For Each SubZonaRow As DataRow In ConsultaSubZona
                    panelContenido.Controls.Add(CrearSubZona(SubZonaRow.Item("subzonanombre"), SubZonaRow.Item("zonaId"), SubZonaRow.Item("subzonacapacidad"), ContadorVehiculos.ToString))
                Next
            End If

            Abierto = True
            DirectCast(s, Button).Text = "Ocultar"
        End If
    End Sub

    Private Sub OnVerZonasLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim PatioDatos = PObtenerID(PatioId)
            Dim ZonaDatos = ZObtenerPatioID(PatioId)
            lblPatioInfo.Text = "Viendo Zonas de: "+ PatioDatos.Item("pationombre")
            If ZonaDatos IsNot Nothing
                Dim ContadorSubZonas = SZObtenerCountId(ZonaDatos.Item("zonaid").ToString)
                If ZonaDatos IsNot Nothing
                    FPContenido.Controls.Add(CrearZonaInfo(ZonaDatos.Item("zonaid").ToString, ContadorSubZonas.ToString))
                End If
            End If
            ParentForm.ClientSize = Me.Size
        Catch ex As Exception
            Serilog.Log.Error("Error al cargar patios, Hay patios en la db?")
        End Try
    End Sub
End Class
