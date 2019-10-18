Imports Logica
Imports BrightIdeasSoftware

Public Class Main_Deus

    Private Sub OnMenuLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        pnContenido.Controls.Clear
        Dim MU As ManageUsuarios = New ManageUsuarios
        MU.Dock = DockStyle.Fill
        pnContenido.Controls.Add(MU)
    End Sub

    Private Sub BtOperario_Click(sender As Object, e As EventArgs) Handles btOperario.Click
        pnContenido.Controls.Clear
        Dim MU As ManageUsuarios = New ManageUsuarios
        MU.Dock = DockStyle.Fill
        pnContenido.Controls.Add(MU)
    End Sub

    Private Sub Btvehiculos_Click_1(sender As Object, e As EventArgs) Handles btvehiculos.Click
        pnContenido.Controls.Clear
        Dim VL As VehiculosLotes = New VehiculosLotes
        VL.Dock = DockStyle.Fill
        pnContenido.Controls.Add(VL)
    End Sub

    Private Sub Btnpatioszonas_Click(sender As Object, e As EventArgs) Handles btnpatioszonas.Click
        pnContenido.Controls.Clear
        Dim PZ As PatiosZonas = New PatiosZonas
        PZ.Dock = DockStyle.Fill
        pnContenido.Controls.Add(PZ)
    End Sub
End Class
