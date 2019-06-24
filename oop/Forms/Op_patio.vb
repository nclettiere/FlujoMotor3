Imports Logica

Public Class Op_patio

    Private Facade As Facade

    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Facade = CType(ParentForm, Menu_Operario).GetFacade()

        For Each vehiculo In Facade.ObtenerVehiculos()
            Dim ListaPatio(4) As String

            ListaPatio(0) = vehiculo.Vin
            ListaPatio(1) = Facade.ObtenerUbicacion(vehiculo.UbicacionID).Long
            ListaPatio(2) = Facade.ObtenerUbicacion(vehiculo.UbicacionID).Lat
            ListaPatio(3) = Facade.ObtenerPatio(Facade.ObtenerUbicacion(vehiculo.UbicacionID).PatioID).Nombre

            Dim listViewItem As ListViewItem = New ListViewItem(ListaPatio)
            lista_vehiculos.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub ItemDoubleClick(sender As Object, e As MouseEventArgs) Handles lista_vehiculos.MouseDoubleClick
        If Facade.Operario.Tipo = 1 Then
            Dim vin = lista_vehiculos.SelectedItems(0).SubItems(0).Text
            Dim VehiclePreview = New VerVehiculoPatio()
            VehiclePreview.cargar(Me, Facade, vin)
            VehiclePreview.ShowDialog()
        End If
    End Sub

    Friend Sub ActualizarLista()
        lista_vehiculos.BeginUpdate()
        lista_vehiculos.Items.Clear()
        For Each vehiculo In Facade.ObtenerVehiculos()
            Dim ListaPatio(4) As String

            ListaPatio(0) = vehiculo.Vin
            ListaPatio(1) = Facade.ObtenerUbicacion(vehiculo.UbicacionID).Long
            ListaPatio(2) = Facade.ObtenerUbicacion(vehiculo.UbicacionID).Lat
            ListaPatio(3) = Facade.ObtenerPatio(Facade.ObtenerUbicacion(vehiculo.UbicacionID).PatioID).Nombre

            Dim listViewItem As ListViewItem = New ListViewItem(ListaPatio)
            lista_vehiculos.Items.Add(listViewItem)
        Next
        lista_vehiculos.EndUpdate()
    End Sub

    Private Sub txtBuscadorVehiculo_TextChanged(sender As Object, e As EventArgs) Handles txtBuscadorVehiculo.TextChanged
        Dim vehiculo As List(Of VehiculoTest) = Facade.ObtenerListaVin(txtBuscadorVehiculo.Text)

        lista_vehiculos.Items.Clear()

        If Not vehiculo Is Nothing Then


            Dim ListArray(4) As String
            For Each item In vehiculo
                ListArray(0) = item.Vin
                ListArray(1) = Facade.ObtenerUbicacion(item.UbicacionID).Long
                ListArray(2) = Facade.ObtenerUbicacion(item.UbicacionID).Lat
                ListArray(3) = Facade.ObtenerPatio(Facade.ObtenerUbicacion(item.UbicacionID).PatioID).Nombre

                Dim ListViewItem As ListViewItem = New ListViewItem(ListArray)

                lista_vehiculos.Items.Add(ListViewItem)
            Next
        End If
    End Sub

    Private Sub btListarVehiculo_Click(sender As Object, e As EventArgs) Handles btListarVehiculo.Click
        ActualizarLista()
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        If Facade.Operario.Tipo = 1 Then
            Try
                Dim vin = lista_vehiculos.SelectedItems(0).SubItems(0).Text
                Dim VehiclePreview = New VerVehiculoPatio()
                VehiclePreview.cargar(Me, Facade, vin)
                VehiclePreview.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Selecciona un vehiculo")
            End Try
        End If
    End Sub
End Class