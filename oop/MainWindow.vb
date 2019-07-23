Imports Logica

Public Class MainWindow

    Private facade As Facade
    Private OperarioId As Integer

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facade = New Facade()

        If Not MainContent.Contains(Login.Instance) Then

            Login.Instance.LoadData(Me, facade)

            MainContent.Controls.Add(Login.Instance)
            Login.Instance.Dock = DockStyle.Fill
            Login.Instance.BringToFront()
        Else
            Login.Instance.BringToFront()
        End If

    End Sub

    Friend Sub ChangeControlSummary(operarioId As Integer)
        Dim currentOperario As Operario = facade.ObtenerOperario(operarioId.ToString)

        If Not MainContent.Contains(Summary.Instance) Then

            Summary.Instance.LoadData(Me, facade, currentOperario)

            MainContent.Controls.Add(Summary.Instance)
            Summary.Instance.Dock = DockStyle.Fill
            Summary.Instance.BringToFront()
        Else
            Summary.Instance.BringToFront()
        End If
    End Sub
End Class