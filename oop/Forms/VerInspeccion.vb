Imports Logica

Public Class VerInspeccion

    Private ParentFormClass As VerVehiculoPatio
    Private FacadeRef As Facade

    Private Vehiculo As VehiculoTest

    Private Inspeccion As Inspeccion

    Friend Sub cargar(parent As VerVehiculoPatio, facade As Facade, vin As String, id As Integer)
        ParentFormClass = parent
        FacadeRef = facade
        Vehiculo = FacadeRef.BuscarVinEnLista(vin)
        Inspeccion = FacadeRef.ObtenerInspeccion(id)
    End Sub

    Private Sub VerInspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_title.Text = "Inspeccion al vehiculo: " + Vehiculo.Vin + " El " + Inspeccion.Fecha.ToString
        lbl_name.Text = "Nombre: " + Inspeccion.Name
        lbl_ubicacion.Text = "Ubicacion: " + Inspeccion.Ubicacion
        rch_desc.Text = Inspeccion.Descripcion
    End Sub
End Class