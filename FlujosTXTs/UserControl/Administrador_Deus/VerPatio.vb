Imports System.ComponentModel
Imports System.Threading
Imports CefSharp
Imports CefSharp.WinForms
Imports Logica

Public Class VerPatio
    
    Private Shared _instance As VerPatio

    Public Chromium As ChromiumWebBrowser

    Friend PatioId As String

    Friend Direccion As String

    Friend PrimeraVez As Boolean = True

    Public Shared Property Instance As VerPatio
        Get
            If _instance Is Nothing Then
                _instance = New VerPatio
            End If

            Return _instance
        End Get
        Set(value As VerPatio)
            _instance = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent
    End Sub

    Private Sub VerPatio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSubZonas()

        UpdateLang()

        Chromium = New ChromiumWebBrowser("https://www.google.com.uy/maps/")

        If CefSharp.Cef.IsInitialized
            Chromium.Load("https://www.google.com.uy/maps/place/"+Direccion)
            panelMapa.Controls.Add(Chromium)
            Chromium.Dock = DockStyle.Fill
            Chromium.BringToFront
            ActualizarSubZonas
        End If

    End Sub

    Private Function doing(s As Object, args As EventArgs)
        
    End Function

    Private Function CrearControlSubZona(ZonaId As String, Nombre As String, Capacidad As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(236, 127)
        PanelContenido.BackColor = Color.Silver
        PanelContenido.Dock = DockStyle.Top

        Dim LabelId As Label = New Label
        Dim LabelNombre As Label = New Label
        Dim LabelCapacidad As Label = New Label
        Dim BtnElim As Button = New Button
        Dim BtnMod As Button = New Button

        LabelId.AutoSize = True
        LabelNombre.AutoSize = True
        LabelCapacidad.AutoSize = True

        LabelId.Text = _Lang.ObtenerKey("VerPtio", 3) + ZonaId
        LabelNombre.Text = _Lang.ObtenerKey("VerPtio", 4) + Nombre
        LabelCapacidad.Text = String.Format(_Lang.ObtenerKey("VerPtio", 5), Capacidad)

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
        BtnElim.Text = _Lang.ObtenerKey("VerPtio", 6)
        BtnElim.Location = New Point(6, 91)

        BtnMod.Size = New Size(87, 28)
        BtnMod.Font = fuente
        BtnMod.ForeColor = Color.Crimson
        BtnMod.FlatStyle = FlatStyle.Flat
        BtnMod.Text = _Lang.ObtenerKey("VerPtio", 7)
        BtnMod.Location = New Point(136, 91)

        'AddHandler BtnElim.Click , Sub(s, ea) EliminarClick(s, ea, PatioId)
        AddHandler BtnMod.Click , Sub(s, ea) ModClick(s, ea, Nombre)
        
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
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgSubZ As AgregarSubzona = New AgregarSubzona
        AgSubZ.PatioId = PatioId
        AgSubZ.VP_VerPatio = Me
        AgSubZ.Modo = 1
        AgSubZ.SZNombre = SZnombre
        Ventana.LoadControl(AgSubZ)
        Ventana.ShowDialog
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

    Private Sub BtnAgZona_Click(sender As Object, e As EventArgs) Handles btnAgZona.Click
        Dim result As Integer = MessageBox.Show("Deseas agregar una zona para este patio?", "Agregar Zona", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If ZInsertar(PatioId)
                MessageBox.Show("Zona insertada exitosamente.")
            Else
                MessageBox.Show("Hubo un error al insertar zona.")
            End If
        End If
    End Sub

    Private Sub BtnAgSubZona_Click(sender As Object, e As EventArgs) Handles btnAgSubZona.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgSubZ As AgregarSubzona = New AgregarSubzona
        AgSubZ.PatioId = PatioId
        AgSubZ.VP_VerPatio = Me
        Ventana.LoadControl(AgSubZ)
        Ventana.ShowDialog
    End Sub

    Friend Sub ActualizarSubZonas()
        flpSubZonas.Controls.Clear
        Try
            If PatioId IsNot Nothing Then
                Dim ZonasPatio As DataTable = Consultar("SELECT * FROM zonas WHERE patioid=" + PatioId.ToString)
                If ZonasPatio IsNot Nothing Then

                    If ZonasPatio.Rows.Count > 0 Then

                        For Each Zona As DataRow In ZonasPatio.Rows
                            Dim SubZonas As DataTable = Consultar("SELECT * FROM subZonas WHERE zonaID =" + Zona.Item("zonaid").ToString)
                            If SubZonas IsNot Nothing Then

                                If SubZonas.Rows.Count > 0 Then

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

    Protected _Lang As LangManager = New LangManager
    Protected Sub UpdateLang()
        ParentForm.Text = _Lang.ObtenerKey("VerPtio", 0)
        lblLoading.Text = _Lang.ObtenerKey("VerPtio", 1)
        btnAgZona.Text = _Lang.ObtenerKey("VerPtio", 8)
        btnAgSubZona.Text = _Lang.ObtenerKey("VerPtio", 9)
        GroupBox1.Text = _Lang.ObtenerKey("VerPtio", 2)
    End Sub

End Class
