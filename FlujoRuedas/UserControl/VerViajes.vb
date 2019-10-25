Imports System.Threading
Imports CefSharp.WinForms
Imports CefSharp
Imports Logica

Public Class VerViajes

    Private IdSeleccionado As String
    Private NombreSeleccionado As String

    Public Chromium As ChromiumWebBrowser
    Private CCargado As Boolean = False

    Private Shared _instance As VerViajes

    Public Shared Property Instance As VerViajes
        Get
            If _instance Is Nothing Then
                _instance = New VerViajes()
            End If
            Return _instance
        End Get
        Set(value As VerViajes)
            _instance = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent

        '' Iniciar Chromium
        '' En otro thread para no congestionar la UI mientras carga.
        Dim thread As Thread = New Thread(AddressOf InciarChromium)
        thread.Start()
    End Sub

    Private Sub OnViajesLOad(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista
    End Sub


    Private Sub CambioSeleccion(sender As Object, e As EventArgs) Handles ListaViajes.SelectedIndexChanged
        If ListaViajes.SelectedIndex >= 0
            btnEntregar.Enabled = True
            Try
                IdSeleccionado = ListaViajes.SelectedItem.SubItems.Item(0).Text
                Dim LoteInfo = LObtenerID(IdSeleccionado)
                Dim PatioInfo = PObtenerID(LoteInfo.Item("Patioid"))
                If CCargado
                    Chromium.Load("https://www.google.com/maps/dir/Port+of+Montevideo,+Juan+Carlos+Gómez,+11000+Montevideo/"+PatioInfo.Item("ubicacion"))
                End If
            Catch ex As Exception

            End Try
        Else
            btnEntregar.Enabled = False
        End If
    End Sub

    Private Sub BtnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim DialogoLavado As DialogResult = MessageBox.Show("Deseas terminar el viaje para el lote: ID=" + IdSeleccionado + "?", "Terminar Viaje", MessageBoxButtons.YesNo)
        If DialogoLavado = DialogResult.Yes
            If LUpdateFechaLlegada(Now, IdSeleccionado)
                MessageBox.Show("El lote ha sido entregado con exito.")
            End If
        End If
        ActualizarLista
    End Sub

    Private Sub ActualizarLista
        ListaViajes.DataSource = Nothing
        Try
            Dim Datos As DataTable = LObtenerAllFitro("lotefechasalida IS NOT NULL AND lotefechallegada IS NULL AND transportistaid ="+ ObtenerOpId.ToString)
            ListaViajes.DataSource = Datos

            If Datos IsNot Nothing
                If Datos.Rows.Count = 0
                    lblNoViajes.Visible = True
                Else
                    lblNoViajes.Visible = False
                End If
            Else
                lblNoViajes.Visible = True
            End If

            For Each column As ColumnHeader In ListaViajes.Columns
                column.Width = -2
            Next
        Catch ex As Exception
            MsgBox("Error al actualizar lista.")
            Serilog.Log.Error(ex, "err...")
        End Try
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
                If ListaViajes.SelectedIndex >= 0
                    Try
                        IdSeleccionado = ListaViajes.SelectedItem.SubItems.Item(0).Text
                        Dim LoteInfo = LObtenerID(IdSeleccionado)
                        Dim PatioInfo = PObtenerID(LoteInfo.Item("Patioid"))                
                        Chromium.Load("https://www.google.com/maps/dir/Port+of+Montevideo,+Juan+Carlos+Gómez,+11000+Montevideo/"+PatioInfo.Item("ubicacion"))
                    Catch ex As Exception
                        Chromium = New ChromiumWebBrowser("https://www.google.com/maps/place/Puerto+De+Montevideo/")
                    End Try
                Else
                    Chromium = New ChromiumWebBrowser("https://www.google.com/maps/place/Puerto+De+Montevideo/")
                End If

                panelMapa.Controls.Add(Chromium)
                Chromium.Dock = DockStyle.Fill
                Chromium.BringToFront
                CCargado = True
            Catch ex As Exception
                Dim web As WebBrowser = New WebBrowser
                web.Url = New Uri("https://www.google.com/maps/place/Puerto+De+Montevideo/")
                panelMapa.Controls.Add(web)
                web.Dock = DockStyle.Fill
                web.BringToFront

                Serilog.Log.Error(ex, "Error al cargar CefSharp. Cargando Webview del legado.")
            End Try
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ActualizarLista
    End Sub

End Class
