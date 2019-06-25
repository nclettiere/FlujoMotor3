Imports Logica

Public Class Agregar_Lote

    Private ParentFormClass As Vehiculos
    Private FacadeRef As Facade
    Private DisplayVin As String


    Friend Sub cargar(vehiculos As Vehiculos, facade As Facade)
        ParentFormClass = vehiculos
        FacadeRef = facade
    End Sub

    '' Lista de vin's seleccionados
    Private Seleccion As List(Of String)



    Private Sub Agregar_Lote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btSeleccionar.Click
        Dim SelecVehiculo = New SeleccionarVehiculos()
        SelecVehiculo.cargar(Me, FacadeRef)
        SelecVehiculo.ShowDialog()
    End Sub

    Friend Sub CargarSelecciones(ByRef lista As List(Of String))
        Seleccion = lista
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Dim LoteId As Integer = FacadeRef.GenerateLoteID()
        Dim LoteNombre As String = txtNombre.Text
        Dim LoteDesc As String = rch_desc.Text
        Dim LoteGenerado = New Lote(LoteId, LoteNombre, LoteDesc, Seleccion, Now.Date.ToShortDateString, FacadeRef.Operario.OperarioID)

        FacadeRef.AgregarLote(LoteGenerado)

        For Each vin As String In Seleccion
            Dim UbicacionID As Integer = FacadeRef.BuscarVinEnLista(vin).UbicacionID
            FacadeRef.ObtenerUbicacion(UbicacionID).Status = "A Espera de Inspeccion."
            ParentFormClass.ActualizarListaVehiculos()
            ParentFormClass.ActualizarListaLotes()
        Next

        Me.Close()
    End Sub
End Class