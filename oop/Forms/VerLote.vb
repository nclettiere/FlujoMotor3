﻿Imports Logica

Public Class VerLote
    Private ParentFormClass As Vehiculos
    Private FacadeRef As Facade
    Private DisplayLoteId As String

    Friend Sub cargar(vehiculos As Vehiculos, facade As Facade, id As String)
        ParentFormClass = vehiculos
        FacadeRef = facade
        DisplayLoteId = id
    End Sub

    Private Sub VerLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lote = FacadeRef.ObtenerLoteID(DisplayLoteId)
        For Each item In lote.Vehiculos
            lst_vin.Items.Add(item)
        Next

        lbl_name.Text = "Nombre: " + lote.LoteName
        lbl_client.Text = "Cliente: " + FacadeRef.ObtenerCliente(lote.ClienteID).ClienteNombre + " " + FacadeRef.ObtenerCliente(lote.ClienteID).ClienteApellido
        lbl_rutaA.Text = "Ruta inicial: " + lote.RutaA
        lbl_rutaB.Text = "Ruta Final: " + lote.RutaB
        rch_desc.Text = lote.LoteDesc
    End Sub
End Class