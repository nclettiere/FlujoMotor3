Imports DB
Imports Logica

Public Class MainWindow

    Private facade As Facade
    Private OperarioId As Integer
    Private Conexion As ODBC

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facade = New Facade()

        If Not MainContent.Contains(Login.Instance) Then

            MainContent.Controls.Add(Login.Instance)
            Login.Instance.Dock = DockStyle.Fill
            Login.Instance.BringToFront()
        Else
            Login.Instance.BringToFront()
        End If

    End Sub

    Friend Sub ChangeControlSummary(operarioId As Integer, Conexion As ODBC)
        Dim currentOperario As Operario = facade.ObtenerOperario(operarioId.ToString)

        Me.Conexion = Conexion

        If Not MainContent.Contains(Summary.Instance) Then

            Summary.Instance.LoadData(Me, facade, currentOperario, Conexion)

            MainContent.Controls.Add(Summary.Instance)
            Summary.Instance.Dock = DockStyle.Fill
            Summary.Instance.BringToFront()
        Else
            Summary.Instance.BringToFront()
        End If
    End Sub
End Class