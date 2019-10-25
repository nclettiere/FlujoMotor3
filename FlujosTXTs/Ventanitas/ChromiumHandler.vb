Imports System.Threading
Imports CefSharp
Imports CefSharp.WinForms
Imports Logica

Public Class ChromiumHandler : Implements ILifeSpanHandler

    Friend Chromium As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent

        Dim Config As CefSettings = New CefSettings()
        CefSharpSettings.SubprocessExitIfParentProcessClosed = true
        CefSharp.Cef.Initialize(Config)
        Chromium = New ChromiumWebBrowser("https://www.google.com.uy/maps/")
    End Sub

    Friend Sub LoadControl(Ctrl As Control)
        Try
            Me.ClientSize = Ctrl.Size
            Me.Controls.Add(Ctrl)
            Ctrl.Dock = DockStyle.Fill
            Ctrl.BringToFront()
        Catch ex As Exception
            MsgBox("Wow. Error inesperado al cargar control. Chequee el log para mas info.")
            Serilog.Log.Error(ex, "err...")
        End Try
    End Sub

    Private Sub ChromiumHandler_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Chromium.Dispose
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