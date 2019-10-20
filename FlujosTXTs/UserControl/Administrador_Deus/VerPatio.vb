Imports System.ComponentModel
Imports System.Threading
Imports CefSharp
Imports CefSharp.WinForms
Imports Logica

Public Class VerPatio

    Public Chromium As ChromiumWebBrowser
    Friend PatioId As String

    Public Sub New()
        InitializeComponent

        '' Iniciar Chromium
        '' En otro thread para no congestionar la UI mientras carga.
        Dim thread As Thread = New Thread(AddressOf InciarChromium)
        thread.Start()
    End Sub

    Private Sub VerPatio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       flpSubZonas.Controls.Clear
        Try
            If PatioId IsNot Nothing
                Dim ZonasPatio As DataTable = Consultar("SELECT * FROM zonas WHERE patioid="+ PatioId)
                If ZonasPatio IsNot Nothing
                    If ZonasPatio.Rows.Count > 0
                        For Each Zona As DataRow In ZonasPatio.Rows
                            Dim SubZonas As DataTable = Consultar("SELECT * FROM subZonas  WHERE patioid="+ PatioId)
                            If SubZonas IsNot Nothing
                                If SubZonas.Rows.Count > 0
                                    For Each SubZona As DataRow In SubZonas.Rows
                                        Dim ctrlSubZona As Control = CrearControlSubZona(SubZona.Item("ZonaId"),
                                                                                         SubZona.Item("subZonaNombre"),
                                                                                         SubZona.Item("subZonaCapacidad"))
                                        flpSubZonas.Controls.Add(ctrlSubZona)
                                    Next
                                End If
                            End If
                        Next
                    End If
                End If

            Else
                MsgBox("Hubo un error al cargar las zonas del patio.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function CrearControlSubZona(ZonaId As String, Nombre As String, Capacidad As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(236, 127)
        PanelContenido.BackColor = Color.Silver
        PanelContenido.Dock = DockStyle.Top

        Dim LabelId As Label = New Label
        Dim LabelNombre As Label = New Label
        Dim LabelCapacidad As Label = New Label
        Dim BtnElim As Button = New Button
        Dim BtnVer As Button = New Button

        LabelId.AutoSize = True
        LabelNombre.AutoSize = True
        LabelCapacidad.AutoSize = True

        LabelId.Text = "Zona ID: "+ ZonaId
        LabelNombre.Text = "Nombre: "+ Nombre
        LabelCapacidad.Text = "Capacidad: "+ Capacidad + " Vehiculos"

        LabelId.Location = New Point(3, 10)
        LabelNombre.Location = New Point(3, 37)
        LabelCapacidad.Location = New Point(3, 60)

        LabelId.ForeColor = Color.Crimson
        LabelNombre.ForeColor = Color.Crimson
        LabelCapacidad.ForeColor = Color.Crimson

        Dim fuente = New Font("Arial", 10)

        LabelId.Font = fuente
        LabelNombre.Font = fuente
        LabelCapacidad.Font = fuente

        BtnElim.Size = New Size(89, 28)
        BtnElim.Font = fuente
        BtnElim.ForeColor = Color.Crimson
        BtnElim.FlatStyle = FlatStyle.Flat
        BtnElim.Text = "Eliminar"
        BtnElim.Location = New Point(6, 91)

        BtnVer.Size = New Size(87, 28)
        BtnVer.Font = fuente
        BtnVer.ForeColor = Color.Crimson
        BtnVer.FlatStyle = FlatStyle.Flat
        BtnVer.Text = "Modificar"
        BtnVer.Location = New Point(136, 91)

        'AddHandler BtnElim.Click , Sub(s, ea) EliminarClick(s, ea, PatioId)
        'AddHandler BtnVer.Click , Sub(s, ea) VerClick(s, ea, PatioId)
        
        PanelContenido.Controls.Add(LabelId)
        PanelContenido.Controls.Add(LabelNombre)
        PanelContenido.Controls.Add(LabelCapacidad)
        PanelContenido.Controls.Add(BtnElim)
        PanelContenido.Controls.Add(BtnVer)

        Return PanelContenido
    End Function

    Private Delegate Sub InciarChromiumDelegate()
    Private Sub InciarChromium()

    If Me.InvokeRequired Then
        Me.Invoke(New InciarChromiumDelegate(AddressOf InciarChromium))
    Else
        Try
            Dim Config As CefSettings = New CefSettings()
            'Iniciar CefSharp con las configuraciones dadas
            CefSharp.Cef.Initialize(Config)

            ' Aniadir el control al panel
            Chromium = New ChromiumWebBrowser("https://www.google.com/maps/dir/Port+of+Montevideo,+Juan+Carlos+Gómez,+11000+Montevideo/Canstatt+3052,+Montevideo/")
            panelMapa.Controls.Add(Chromium)
            Chromium.Dock = DockStyle.Fill
            Chromium.BringToFront
        Catch ex As Exception
            Dim web As WebBrowser = New WebBrowser
            web.Url = New Uri("https://www.google.com/maps/dir/Port+of+Montevideo,+Juan+Carlos+Gómez,+11000+Montevideo/Canstatt+3052,+Montevideo/")
            panelMapa.Controls.Add(web)
            web.Dock = DockStyle.Fill
            web.BringToFront

            Serilog.Log.Error(ex, "Error al cargar CefSharp. Cargando Webview del legado.")
        End Try
    End If
    End Sub
End Class
