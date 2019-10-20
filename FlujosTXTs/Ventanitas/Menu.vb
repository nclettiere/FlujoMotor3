Imports Logica
Imports Serilog
Imports CefSharp
Imports CefSharp.WinForms

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log.Logger = New LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo.File("logs\\log_.txt", rollingInterval:= RollingInterval.Day).CreateLogger()
        USER = "root"
        PSWD = "root"
        Conectar
        CargarMenuPrincipal

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
End Class