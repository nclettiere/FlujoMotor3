Imports Logica
Imports Serilog

Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim VentanaLogin = Login.Instance

        Log.Logger = New LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo.File("logs\\log_.txt", rollingInterval:=RollingInterval.Day).CreateLogger()

        If Not mainContent.Contains(VentanaLogin) Then
            MainContent.Controls.Add(VentanaLogin)
            VentanaLogin.Dock = DockStyle.Fill
            Me.ClientSize = VentanaLogin.Size
            VentanaLogin.BringToFront()
        Else
            VentanaLogin.BringToFront()
        End If
    End Sub

    Friend Sub CargarMenuPrincipal()
        Dim Menu = MenuPrincipal.Instance

        If Not mainContent.Contains(Menu) Then
            MainContent.Controls.Add(Menu)
            Me.ClientSize = Menu.Size
            Menu.Dock = DockStyle.Fill
            Menu.BringToFront()
        Else
            Menu.BringToFront()
        End If
    End Sub

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CefSharp.Cef.Shutdown
    End Sub
End Class
