﻿Imports Logica
Imports Serilog
Imports CefSharp
Imports CefSharp.WinForms

Public Class Menu : Implements ILifeSpanHandler

    Friend Chromium As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent

        Dim Config As CefSettings = New CefSettings()
        CefSharpSettings.SubprocessExitIfParentProcessClosed = true
        'Config.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\.CacheCef"
        Config.CachePath = My.Application.Info.DirectoryPath + "\.CacheCef"

        Environment.SetEnvironmentVariable("GOOGLE_API_KEY", "AIzaSyBbpL8iCQT8R5p5c-tWblkfy0YAXMb-pwY")
        Environment.SetEnvironmentVariable("GOOGLE_DEFAULT_CLIENT_ID", "766996483210-rl29kav23s636oofcco8o0s31o3vbagp.apps.googleusercontent.com")
        Environment.SetEnvironmentVariable("GOOGLE_DEFAULT_CLIENT_SECRET", "wGP-Ei-lQvAzW5vw83x7v2j_")

        Config.CefCommandLineArgs.Add("enable-geolocation", "1")
        Config.LocalesDirPath = Application.StartupPath + "\locales"
        Config.Locale = "es"

        CefSharp.Cef.Initialize(Config)
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log.Logger = New LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo.File("logs\\log_.txt", rollingInterval:= RollingInterval.Day).CreateLogger()

        Dim Menu = New Login_Deus
        If Not mainContent.Contains(Menu) Then
            Me.ClientSize = Menu.Size
            MainContent.Controls.Add(Menu)
            Menu.Dock = DockStyle.Fill
            Menu.BringToFront()
        Else
            Menu.BringToFront()
        End If
    End Sub

    Friend Sub CargarMenuPrincipal()
        Dim Menu = New Main_Deus

        If Not mainContent.Contains(Menu) Then
            Me.ClientSize = Menu.Size
            MainContent.Controls.Add(Menu)
            Menu.Dock = DockStyle.Fill
            Menu.BringToFront()
        Else
            Menu.BringToFront()
        End If
    End Sub

    Private Sub ChromiumHandler_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CefSharp.Cef.Shutdown
    End Sub

    '' Implementaciones de la interfaz de CefSharp: ILifeSpanHandler
    Public Function DoClose(chromiumWebBrowser As IWebBrowser, browser As IBrowser) As Boolean Implements ILifeSpanHandler.DoClose
        Return False
    End Function

    Public Function OnBeforePopup(chromiumWebBrowser As IWebBrowser, browser As IBrowser, frame As IFrame, targetUrl As String, targetFrameName As String, targetDisposition As WindowOpenDisposition, userGesture As Boolean, popupFeatures As IPopupFeatures, windowInfo As IWindowInfo, browserSettings As IBrowserSettings, ByRef noJavascriptAccess As Boolean, ByRef newBrowser As IWebBrowser) As Boolean Implements ILifeSpanHandler.OnBeforePopup
    End Function

    Public Sub OnAfterCreated(chromiumWebBrowser As IWebBrowser, browser As IBrowser) Implements ILifeSpanHandler.OnAfterCreated
    End Sub

    Public Sub OnBeforeClose(chromiumWebBrowser As IWebBrowser, browser As IBrowser) Implements ILifeSpanHandler.OnBeforeClose   
    End Sub
End Class