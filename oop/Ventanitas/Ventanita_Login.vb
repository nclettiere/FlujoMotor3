Imports DB
Imports Logica
Imports Serilog

Public Class Ventanita_Login
    Private OperarioId As Integer
    Private Conexion As ODBC

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

    Friend Sub ChangeControlSummary(operarioId As Integer, Conexion As ODBC)
        Dim mainVentana = New Menu
        Hide()
        mainVentana.Conexion = Conexion
        mainVentana.ShowDialog()
        Close()
    End Sub
End Class