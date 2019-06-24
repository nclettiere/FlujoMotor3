Imports Logica

Public Class SeleccionarVehiculos
    Private ParentFormClass As Agregar_Lote
    Private FacadeRef As Facade
    Private DisplayVin As String

    Private Selecciones = New List(Of String)


    Friend Sub cargar(AgLote As Agregar_Lote, facade As Facade)
        ParentFormClass = AgLote
        FacadeRef = facade
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        For Each item In lst_vehiculos.SelectedItems
            Selecciones.Add(item)
        Next

        ParentFormClass.CargarSelecciones(Selecciones)

        Me.Close()
    End Sub

    Private Sub SeleccionarVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ListaString(FacadeRef.ObtenerVehiculos().Count) As String

        For Each item In FacadeRef.ObtenerVehiculos()
            lst_vehiculos.Items.Add(item.Vin)
        Next

    End Sub
End Class