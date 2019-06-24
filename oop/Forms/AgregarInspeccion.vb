Imports Logica

Public Class AgregarInspeccion

    Private ParentFormClass As VerVehiculoPatio
    Private FacadeRef As Facade

    Private Vehiculo As VehiculoTest

    Private Inspecciones As List(Of Inspeccion)
    Private Ubicacion As Ubicacion
    Private PatioID As Integer
    Private Patio As Patio
    Private Patios As List(Of Patio)

    Private NumeroDeInspecciones As Integer

    Private DefaultItem As String

    Friend Sub cargar(op_patio As VerVehiculoPatio, facade As Facade, vin As String)
        ParentFormClass = op_patio
        FacadeRef = facade
        Vehiculo = FacadeRef.BuscarVinEnLista(vin)
        Ubicacion = FacadeRef.ObtenerUbicacion(Vehiculo.UbicacionID)
        PatioID = Ubicacion.PatioID
        Patio = FacadeRef.ObtenerPatio(PatioID)
        Patios = FacadeRef.ObtenerPatios()
        Inspecciones = FacadeRef.ObtenerInspecciones

        NumeroDeInspecciones = 0
        For Each inspeccion As Inspeccion In Inspecciones
            If String.Equals(inspeccion.VehiculoVin, Vehiculo.Vin) Then
                NumeroDeInspecciones += 1
            End If
        Next

    End Sub

    Private Sub AgregarInspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_title.Text = "Inspeccion N" + (NumeroDeInspecciones + 1).ToString + " al vehiculo " + Vehiculo.Vin

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Try
            Dim NewInspeccion = New Inspeccion(FacadeRef.GenerateInspeccionId(),
                                           Vehiculo.Vin,
                                           tbx_name.Text,
                                           rch_desc.Text,
                                           tbx_ubicacion.Text,
                                           FacadeRef.Operario.OperarioID,
                                           Date.Now.ToShortDateString)
            FacadeRef.AgregarInspeccion(NewInspeccion)
            ParentFormClass.ActualizarLista()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub
End Class