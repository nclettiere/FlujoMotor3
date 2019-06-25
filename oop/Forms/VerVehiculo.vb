Imports Logica

Public Class VerVehiculo

    Private ParentFormClass As Vehiculos
    Private FacadeRef As Facade
    Private DisplayVin As String


    Friend Sub cargar(vehiculos As Vehiculos, facade As Facade, vin As String)
        ParentFormClass = vehiculos
        FacadeRef = facade
        DisplayVin = vin
    End Sub

    Private Sub VerVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vehiculo = FacadeRef.BuscarVinEnLista(DisplayVin)
        lbl_vin.Text = "Viendo: " + DisplayVin
        lbl_marca.Text = "Marca: " + vehiculo.Marca
        lbl_color.Text = "Color: " + vehiculo.Color
        lbl_tipo.Text = "Tipo: " + vehiculo.Tipo
        lbl_modelo.Text = "Modelo: " + vehiculo.Modelo
        lbl_anio.Text = "Anio: " + vehiculo.Anio.ToString
        lbl_fncionario.Text = "Agregado por: " + FacadeRef.ObtenerOperario(vehiculo.OperarioID).Nombre + " " + FacadeRef.ObtenerOperario(vehiculo.OperarioID).Apellido
        lbl_fecha.Text = "El: " + vehiculo.Fecha.ToString
        lbl_cliente.Text = "Cliente: " + vehiculo.ClienteNombre

        For Each lote In FacadeRef.ObtenerLotes()
            For Each vin In lote.Vehiculos
                If String.Equals(DisplayVin, vin) Then
                    lst_lotes.Items.Add(lote.LoteName + " ID(" + lote.LoteID.ToString + ")")
                End If
            Next
        Next

    End Sub
End Class