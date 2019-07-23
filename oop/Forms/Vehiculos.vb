Imports Logica

Public Class Vehiculos

    Private Facade As Facade

    Dim SearchClicked = False

    '- - - VEHICULOS - - -

    'BOTON "AGREGAR" VEHICULO
    Private Sub BtAgregarVehiculo_Click(sender As Object, e As EventArgs) Handles btAgregarVehiculo.Click
        Dim agVehiculo = New AgregarVehiculo()

        agVehiculo.cargar(Me, Facade)
        agVehiculo.ShowDialog()
    End Sub

    'BOTON "EDITAR" VEHICULO
    Private Sub BtEditarVehiculo_Click(sender As Object, e As EventArgs)
        Editar_Vehiculo.Show()
    End Sub

    'BOTON "ELIMINAR" VEHICULO
    Private Sub BtEliminarVehiculo_Click(sender As Object, e As EventArgs)
        Eliminar_Vehiculo.Show()
    End Sub

    'BOTON "BUSCAR"
    Private Sub BtBuscarVehiculo_Click(sender As Object, e As EventArgs) Handles btBuscarVehiculo.Click

    End Sub
    Private Sub btBuscarVehiculo_MouseEnter(sender As Object, e As EventArgs) Handles btBuscarVehiculo.MouseEnter
        btBuscarVehiculo.ForeColor = Color.DimGray
    End Sub
    Private Sub btBuscarVehiculo_MouseLeave(sender As Object, e As EventArgs) Handles btBuscarVehiculo.MouseLeave
        btBuscarVehiculo.ForeColor = Color.White
    End Sub

    '- - - LOTES - - -

    'BOTON "AGREGAR" LOTE
    Private Sub BtAgregarLote_Click(sender As Object, e As EventArgs)
        Agregar_Lote.Show()
    End Sub

    'BOTON "EDITAR" LOTE
    Private Sub BtEditarLote_Click(sender As Object, e As EventArgs)
        Editar_Lote.Show()
    End Sub

    'BOTON "ELIMINAR" LOTE
    Private Sub BtEliminarLote_Click(sender As Object, e As EventArgs)
        Eliminar_Lote.Show()
    End Sub

    'BOTON "BUSCAR"
    Private Sub BtBuscarLote_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VehiculoLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        Facade = CType(ParentForm, Menu_Operario).GetFacade()

        For Each vehiculo In Facade.ObtenerVehiculos()
            Dim ListaPatio(7) As String

            ListaPatio(0) = vehiculo.Vin
            ListaPatio(1) = vehiculo.Marca
            ListaPatio(2) = vehiculo.Modelo
            ListaPatio(3) = vehiculo.Tipo
            ListaPatio(4) = vehiculo.Color
            ListaPatio(5) = vehiculo.Fecha.ToString
            ListaPatio(6) = Facade.ObtenerUbicacion(vehiculo.UbicacionID).Status


            Dim listViewItem As ListViewItem = New ListViewItem(ListaPatio)
            lista_vehiculos.Items.Add(listViewItem)
        Next

        If Facade.Operario.Tipo = 1 Then
            btn_AgregarLote.Enabled = False
            btAgregarVehiculo.Enabled = False
        End If
    End Sub

    Friend Sub ActualizarListaLotes()
        lista_lotes.Items.Clear()

        Dim lotes As New List(Of Lote)

        For Each item In Facade.ObtenerLotes

            Dim lvFilmDetailGroup = New ListViewGroup(item.LoteID.ToString, item.LoteName + " (ID:" + item.LoteID.ToString + ")")
            lista_lotes.Groups.Add(lvFilmDetailGroup)

            Dim i As Integer = 0

            For Each vin As String In item.Vehiculos
                Dim myLVI = New ListViewItem()
                myLVI.SubItems(0).Text = item.LoteID
                myLVI.SubItems(0).Text = vin
                myLVI.Group = lvFilmDetailGroup
                lista_lotes.Items.Add(myLVI)

                i += 1
            Next
        Next
    End Sub

    Private Sub txtBuscadorVehiculo_TextChanged(sender As Object, e As EventArgs) Handles txtBuscadorVehiculo.TextChanged
        Dim vehiculo As List(Of Vehiculo) = Facade.ObtenerListaVin(txtBuscadorVehiculo.Text)

        lista_vehiculos.Items.Clear()

        If Not vehiculo Is Nothing Then


            Dim ListArray(7) As String
            For Each item In vehiculo
                ListArray(0) = item.Vin
                ListArray(1) = item.Marca
                ListArray(2) = item.Modelo
                ListArray(3) = item.Tipo
                ListArray(4) = item.Color
                ListArray(5) = item.Fecha
                ListArray(6) = Facade.ObtenerUbicacion(item.UbicacionID).Status

                Dim ListViewItem As ListViewItem = New ListViewItem(ListArray)

                lista_vehiculos.Items.Add(ListViewItem)
            Next
        End If
    End Sub

    Private Sub SearboxClick(sender As Object, e As EventArgs) Handles txtBuscadorVehiculo.Click
        SearchClicked = True
    End Sub

    Friend Sub ActualizarListaVehiculos()
        Dim vehiculo As List(Of Vehiculo) = Facade.ObtenerListaVin("")

        lista_vehiculos.Items.Clear()

        If Not vehiculo Is Nothing Then
            Dim ListArray(7) As String
            For Each item In vehiculo
                ListArray(0) = item.Vin
                ListArray(1) = item.Marca
                ListArray(2) = item.Modelo
                ListArray(3) = item.Tipo
                ListArray(4) = item.Color
                ListArray(5) = item.Fecha
                ListArray(6) = Facade.ObtenerUbicacion(item.UbicacionID).Status

                Dim ListViewItem As ListViewItem = New ListViewItem(ListArray)
                lista_vehiculos.Items.Add(ListViewItem)
            Next
        End If
    End Sub

    Private Sub ItemDoubleClick(sender As Object, e As MouseEventArgs) Handles lista_vehiculos.MouseDoubleClick
        If Facade.Operario.Tipo = 0 Then
            Dim vin = lista_vehiculos.SelectedItems(0).SubItems(0).Text
            Dim VehiclePreview = New VerVehiculo()
            VehiclePreview.cargar(Me, Facade, vin)
            VehiclePreview.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lista_lotes.Items.Clear()

        Dim lotes As New List(Of Lote)

        For Each item In Facade.ObtenerLotes

            Dim lvFilmDetailGroup = New ListViewGroup(item.LoteID.ToString, item.LoteName + " (ID:" + item.LoteID.ToString + ")")
            lista_lotes.Groups.Add(lvFilmDetailGroup)

            Dim i As Integer = 0

            For Each vin As String In item.Vehiculos
                Dim myLVI = New ListViewItem()
                myLVI.SubItems(0).Text = item.LoteID
                myLVI.SubItems(0).Text = vin
                myLVI.Group = lvFilmDetailGroup
                lista_lotes.Items.Add(myLVI)

                i += 1
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_AgregarLote.Click
        Dim AgLote = New Agregar_Lote()
        AgLote.cargar(Me, Facade)
        AgLote.ShowDialog()
    End Sub

    Private Sub LoteDoubleClick(sender As Object, e As MouseEventArgs) Handles lista_lotes.MouseDoubleClick
        If Facade.Operario.Tipo = 0 Then
            Dim id = lista_lotes.SelectedItems(0).SubItems(0).Text
            Dim verlote = New VerLote()
            verlote.cargar(Me, Facade, lista_lotes.SelectedItems(0).Group.Name)
            verlote.ShowDialog()
        End If
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        Try
            Dim vin = lista_vehiculos.SelectedItems(0).SubItems(0).Text
            Dim VehiclePreview = New VerVehiculo()
            VehiclePreview.cargar(Me, Facade, vin)
            VehiclePreview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Selecciona un vehiculo.")
        End Try
    End Sub

    Private Sub btn_verlote_Click(sender As Object, e As EventArgs) Handles btn_verlote.Click
        Try
            If Facade.Operario.Tipo = 0 Then
                Dim id = lista_lotes.SelectedItems(0).SubItems(0).Text
                Dim verlote = New VerLote()
                verlote.cargar(Me, Facade, lista_lotes.SelectedItems(0).Group.Name)
                verlote.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecciona un lote.")
        End Try
    End Sub

    Private Sub btListarVehiculo_Click(sender As Object, e As EventArgs) Handles btListarVehiculo.Click
        ActualizarListaVehiculos()
    End Sub

    Private Sub lista_lotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista_lotes.SelectedIndexChanged

    End Sub

    Private Sub Lista_vehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista_vehiculos.SelectedIndexChanged

    End Sub
End Class