Imports System.ComponentModel
Imports System.Threading
Imports CefSharp
Imports CefSharp.WinForms
Imports Logica

Public Class ListarPatio

    Private Shared _instance As ListarPatio

    Public Chromium As ChromiumWebBrowser
    Friend PatioId As String

    Friend Direccion As String

    Friend PrimeraVez As Boolean = True

    Public Shared Property Instance As ListarPatio
        Get
            If _instance Is Nothing Then
                _instance = New ListarPatio
            End If

            Return _instance
        End Get
        Set(value As ListarPatio)
            _instance = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent
        '' Iniciar Chromium
        '' En otro thread para no congestionar la UI mientras carga.
        Dim thread As Thread = New Thread(AddressOf InciarChromium)
        thread.Start()
        PrimeraVez = False
    End Sub

    Private Sub VerPatio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSubZonas

        If Not PrimeraVez And Chromium IsNot Nothing
            If Chromium.IsBrowserInitialized
                If CefSharp.Cef.IsInitialized
                    CefSharp.Cef.Shutdown
                    Dim Config As CefSettings = New CefSettings()
                    'Iniciar CefSharp con las configuraciones dadas
                    CefSharp.Cef.Initialize(Config)
                    Chromium.Load("https://www.google.com.uy/maps/place/"+Direccion)
                    ActualizarSubZonas
                End If
            End If
        End If
    End Sub

    Private Function CrearControlSubZona(ZonaId As String, Nombre As String, Capacidad As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(236, 127)
        PanelContenido.BackColor = Color.Gray
        PanelContenido.Dock = DockStyle.Top

        Dim LabelId As Label = New Label
        Dim LabelNombre As Label = New Label
        Dim LabelCapacidad As Label = New Label
        Dim BtnElim As Button = New Button
        Dim BtnMod As Button = New Button

        LabelId.AutoSize = True
        LabelNombre.AutoSize = True
        LabelCapacidad.AutoSize = True

        LabelId.Text = "Zona ID: "+ ZonaId
        LabelNombre.Text = "Nombre: "+ Nombre
        LabelCapacidad.Text = "Capacidad: "+ Capacidad + " Vehiculos"

        LabelId.Location = New Point(3, 10)
        LabelNombre.Location = New Point(3, 37)
        LabelCapacidad.Location = New Point(3, 60)

        LabelId.ForeColor = Color.Orange
        LabelNombre.ForeColor = Color.Orange
        LabelCapacidad.ForeColor = Color.Orange

        Dim fuente = New Font("Arial", 10)

        LabelId.Font = fuente
        LabelNombre.Font = fuente
        LabelCapacidad.Font = fuente

        BtnElim.Size = New Size(89, 28)
        BtnElim.Font = fuente
        BtnElim.ForeColor = Color.Orange
        BtnElim.FlatStyle = FlatStyle.Flat
        BtnElim.Text = "Eliminar"
        BtnElim.Location = New Point(6, 91)

        BtnMod.Size = New Size(87, 28)
        BtnMod.Font = fuente
        BtnMod.ForeColor = Color.Orange
        BtnMod.FlatStyle = FlatStyle.Flat
        BtnMod.Text = "Modificar"
        BtnMod.Location = New Point(136, 91)

        'AddHandler BtnElim.Click , Sub(s, ea) EliminarClick(s, ea, PatioId)
        'AddHandler BtnMod.Click , Sub(s, ea) ModClick(s, ea, Nombre)
        
        BtnElim.Enabled = false
        BtnMod.Enabled = false

        PanelContenido.Controls.Add(LabelId)
        PanelContenido.Controls.Add(LabelNombre)
        PanelContenido.Controls.Add(LabelCapacidad)
        PanelContenido.Controls.Add(BtnElim)
        PanelContenido.Controls.Add(BtnMod)

        Return PanelContenido
    End Function

    Friend Sub ShutDown()
        'MsgBox("closing")
        'CefSharp.Cef.Shutdown
    End Sub

    Private Sub ModClick(s As Object, ea As EventArgs, SZnombre As String)

    End Sub

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
            Chromium = New ChromiumWebBrowser("https://www.google.com.uy/maps/place/"+Direccion)
            panelMapa.Controls.Add(Chromium)
            Chromium.Dock = DockStyle.Fill
            Chromium.BringToFront
        Catch ex As Exception
            Dim web As WebBrowser = New WebBrowser
            web.Url = New Uri("https://www.google.com.uy/maps/place/"+Direccion)
            panelMapa.Controls.Add(web)
            web.Dock = DockStyle.Fill
            web.BringToFront

            Serilog.Log.Error(ex, "Error al cargar CefSharp. Cargando Webview del legado.")
        End Try
    End If
    End Sub


    Friend Sub ActualizarSubZonas
       flpSubZonas.Controls.Clear
        Try
            If PatioId IsNot Nothing
                Dim ZonasPatio As DataTable = Consultar("SELECT * FROM zonas WHERE patioid="+ PatioId.ToString)
                If ZonasPatio IsNot Nothing
                    If ZonasPatio.Rows.Count > 0
                        For Each Zona As DataRow In ZonasPatio.Rows
                            Dim SubZonas As DataTable = Consultar("SELECT * FROM subZonas WHERE zonaID ="+ Zona.Item("zonaid").ToString)
                            If SubZonas IsNot Nothing
                                If SubZonas.Rows.Count > 0
                                    For Each SubZona As DataRow In SubZonas.Rows
                                        Dim ctrlSubZona As Control = CrearControlSubZona(SubZona.Item("ZonaId").ToString,
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
            MsgBox("Error al crear subzonas.")
            Serilog.Log.Error(ex, "err..")
        End Try
    End Sub
End Class
