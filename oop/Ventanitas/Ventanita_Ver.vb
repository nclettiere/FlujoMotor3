Imports oop

Public Class Ventanita_Ver
    Private Sub Ventanita_Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub LoadControl(verVehiculo As Ver_Vehiculillo)
        mainContent.Controls.Add(verVehiculo)
    End Sub
End Class