﻿Imports Logica

Public Class SeleccionarLote

    Private IdSeleccionado As String
    Friend ListaId As List(Of String)
    Friend TipoLista As Integer
    Friend MultiSelect As Boolean = False

    Friend Modo As Integer = 0

    Friend UC_AgregarVehiculo As AgregarVehiculo

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If UC_AgregarVehiculo IsNot Nothing
            If Not MultiSelect
                If Modo = 0
                    UC_AgregarVehiculo.CargarLoteNuevo(IdSeleccionado, False)
                Else
                    UC_AgregarVehiculo.CambiarLote(IdSeleccionado, False)
                End If
            Else

            End If
        End If

        ParentForm.Close
    End Sub

    Private Sub ListaLotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaLotes.SelectedIndexChanged
        If listaLotes.SelectedIndex >= 0
            btnSeleccionar.Enabled = True
            IdSeleccionado = listaLotes.SelectedItem.SubItems.Item(0).Text
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub OnLoderino(sender As Object, e As EventArgs) Handles MyBase.Load
        Select TipoLista
            Case 0
                listaLotes.DataSource = LObtenerAll
            Case 1
                listaLotes.DataSource = LObtenerAllPuertoNice
            Case 2
                listaLotes.DataSource = LObtenerAllTransportista
        End Select

        For Each column As ColumnHeader In listaLotes.Columns
            column.Width = -2
        Next

        If MultiSelect
            listaLotes.MultiSelect = True
        End If
    End Sub
End Class
