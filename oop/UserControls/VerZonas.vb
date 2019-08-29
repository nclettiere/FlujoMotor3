Public Class VerZonas

    Friend Property Conexion As DB.ODBC
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

    Private Function CrearSubZona(SubZonaNombre As String, Capacidad As String, Vehiculos As String) As Control
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
        LabelCantidad.Text = "SubZonas: "+ Vehiculos

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
        BtnSubZonaMod.Size = New Size(108, 23)
        BtnSubZonaMod.Font = fuente
        BtnSubZonaMod.ForeColor = Color.Orange
        BtnSubZonaMod.Text = "Ver/Agregar SubZonas"

        Dim BtnSubZonaAparcar As Button = New Button
        BtnSubZonaAparcar.Size = New Size(108, 23)
        BtnSubZonaAparcar.Font = fuente
        BtnSubZonaAparcar.ForeColor = Color.Orange
        BtnSubZonaAparcar.Text = "Ver/Agregar SubZonas"

       ' AddHandler BtnSubZonaMod.Click , Sub(s, ea) VerSubZonas(s, ea, PanelFlow, SubzonaNombre)

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

    Private Abierto As Boolean = False
    Private Sub SubZonasClick(s As Object, ea As EventArgs, panelContenido As FlowLayoutPanel, zonaId As String)
        If Abierto
            Dim CantidadSubZonas = panelContenido.Controls.Count -1

            For indice = 0 To CantidadSubZonas
                panelContenido.Controls.RemoveAt(indice)
            Next

            Abierto = False
        Else
            Dim ContadorSubZonas = 0
            Integer.TryParse(Conexion.Consultar("SELECT COUNT(*) FROM subzonas WHERE zonaid="+ zonaId).Rows(0).Item(0), ContadorSubZonas)

            If ContadorSubZonas > 0
                Dim ConsultaSubZona = Conexion.Consultar("SELECT * FROM subzonas WHERE zonaid="+ zonaId)

                Dim ContadorVehiculos = 0
                Integer.TryParse(Conexion.Consultar("SELECT COUNT(*) FROM vehiculosubzona WHERE subzonanombre='"+ ConsultaSubZona.Rows(0).Item("subzonanombre")+"'").Rows(0).Item(0), ContadorSubZonas)

                For Each SubZonaRow As DataRow In ConsultaSubZona.Rows
                    panelContenido.Controls.Add(CrearSubZona(SubZonaRow.Item("subzonanombre"), SubZonaRow.Item("subzonacapacidad"), ContadorVehiculos.ToString))
                Next
            End If

            Abierto = True
        End If
    End Sub

    Private Sub OnVerZonasLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim PatioDatos = Conexion.Consultar("SELECT * FROM patios WHERE patioid="+ PatioId)
            Dim ZonaDatos = Conexion.Consultar("SELECT * FROM zonas WHERE patioid="+ PatioId)
            lblPatioInfo.Text = "Viendo Zonas de: "+ PatioDatos.Rows(0).Item("pationombre")
            If ZonaDatos IsNot Nothing
                If ZonaDatos.Rows.Count > 0
                    Dim ContadorSubZonas = Conexion.Consultar("SELECT COUNT(*) FROM subzonas WHERE zonaid="+ ZonaDatos.Rows(0).Item("zonaid").ToString)
                    If ZonaDatos IsNot Nothing
                        If ZonaDatos.Rows.Count > 0
                            FPContenido.Controls.Add(CrearZonaInfo(ZonaDatos.Rows(0).Item("zonaid").ToString, ContadorSubZonas.Rows(0).Item(0).ToString))
                        End If
                    End If
                End If
            End If
            ParentForm.ClientSize = Me.Size
        Catch ex As Exception
            Serilog.Log.Error("Error al cargar patios, Hay patios en la db?")
        End Try
    End Sub
End Class
