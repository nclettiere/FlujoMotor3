Imports Logica

Public Class Asignar_Herencia

    Private ParentFormClass As AgregarInspeccion
    Private FacadeRef As Facade
    Private Vin As String

    Friend Sub cargar(aginsp As AgregarInspeccion, facade As Facade, vehiculoVin As String)
        ParentFormClass = aginsp
        FacadeRef = facade
        Vin = vehiculoVin
    End Sub

    Private Sub btn_asignar_Click(sender As Object, e As EventArgs) Handles btn_asignar.Click
        If Not lst_inspecciones.SelectedItem Is Nothing Then
            ParentFormClass.AsignarInspeccion(lst_inspecciones.SelectedItem.ToString)
        End If

        Me.Close()
    End Sub

    Private Sub DependencySelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Lista As List(Of Inspeccion) = FacadeRef.ObtenerInspecciones()

        If Lista.Count > 0 Then
            For Each inspeccion In Lista
                If inspeccion.VehiculoVin = Vin Then
                    lst_inspecciones.Items.Add(inspeccion.InspeccionID)
                End If
            Next
        End If
    End Sub
End Class