﻿Imports Logica
Imports Serilog

Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim VentanaLogin = Login.Instance

        Log.Logger = New LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo.File("logs\\log_.txt", rollingInterval:=RollingInterval.Day).CreateLogger()

        If Not mainContent.Contains(VentanaLogin) Then
            Me.ClientSize = VentanaLogin.Size
            MainContent.Controls.Add(VentanaLogin)
            VentanaLogin.Dock = DockStyle.Fill
            VentanaLogin.BringToFront()
        Else
            VentanaLogin.BringToFront()
        End If
    End Sub

    Friend Sub CargarMenuPrincipal()
        Dim Menu = MenuPrincipal.Instance

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
