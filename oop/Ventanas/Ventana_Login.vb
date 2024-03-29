﻿Imports DB
Imports Logica
Imports Serilog

Public Class Ventana_Login

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log.Logger = New LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo.File("logs\\log_.txt", rollingInterval:= RollingInterval.Day).CreateLogger()

        If Not MainContent.Contains(Login.Instance) Then
            MainContent.Controls.Add(Login.Instance)
            Login.Instance.Dock = DockStyle.Fill
            Login.Instance.BringToFront()
        Else
            Login.Instance.BringToFront()
        End If

        Log.Information(Me.Name.ToString + " Ha cargado con exito.")
    End Sub

    Friend Sub ChangeControlSummary(operarioId As Integer, PuertoPatio As Boolean)
        Try
            Dim mainVentana = New Menu
            mainVentana.PuertoPatio = PuertoPatio
            Hide()
            mainVentana.ShowDialog()
            Close()
        Catch ex As Exception

        End Try

    End Sub
End Class