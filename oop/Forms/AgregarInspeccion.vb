Imports Logica

Public Class AgregarInspeccion

    Private ParentFormClass As VerVehiculoPatio
    Private FacadeRef As Facade

    Private Inspecciones As List(Of Inspeccion)
    Private NumeroDeInspecciones As Integer
    Private DefaultItem As String
    Private ImagenPath As String

    Private InspeccionID As Integer

    Private VehiculoVin As String

    Friend Sub AsignarInspeccion(InspeccionID As Integer)
        Me.InspeccionID = InspeccionID
        chk_depnd.Text = "Depende de: Inspeccion #" + InspeccionID.ToString
    End Sub

    Private DependencyID As Integer

    Friend Sub cargar(op_patio As VerVehiculoPatio, facade As Facade, vin As String)
        ParentFormClass = op_patio
        FacadeRef = facade
        Inspecciones = FacadeRef.ObtenerInspecciones
        VehiculoVin = vin
    End Sub

    Private Sub AgregarInspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If (DependencyID <> Nothing) Then
            Dim NewInspeccion = New Inspeccion(FacadeRef.GenerateInspeccionId(),
                                               VehiculoVin,
                                               rch_desc.Text,
                                               FacadeRef.Operario.OperarioID,
                                               Date.Now.ToShortDateString,
                                               DependencyID)
            FacadeRef.AgregarInspeccion(NewInspeccion)
            ParentFormClass.ActualizarLista()

            Dim CSVInspeccion() As String = {FacadeRef.GenerateInspeccionId().ToString, VehiculoVin,
                                             rch_desc.Text,
                                             FacadeRef.Operario.OperarioID,
                                             Date.Now.ToShortDateString,
                                             DependencyID}

            FacadeRef.AgregarInspeccionACsV(CSVInspeccion, FacadeRef.CSVInspecciones, True)
        Else
            Dim NewInspeccion = New Inspeccion(FacadeRef.GenerateInspeccionId(),
                                       VehiculoVin,
                                       rch_desc.Text,
                                       FacadeRef.Operario.OperarioID,
                                       Date.Now.ToShortDateString)
            Dim CSVInspeccion() As String = {FacadeRef.GenerateInspeccionId().ToString, VehiculoVin,
                                             rch_desc.Text,
                                             FacadeRef.Operario.OperarioID,
                                             Date.Now.ToShortDateString}

            FacadeRef.AgregarInspeccionACsV(CSVInspeccion, FacadeRef.CSVInspecciones, False)

            FacadeRef.AgregarInspeccion(NewInspeccion)
            ParentFormClass.ActualizarLista()
        End If
        Me.Close()
    End Sub

    Private Sub chk_depnd_CheckedChanged(sender As Object, e As EventArgs) Handles chk_depnd.CheckedChanged
        If chk_depnd.Checked Then
            btn_dpenency.Enabled = True
        Else
            btn_dpenency.Enabled = False
        End If
    End Sub

    Private Sub btn_dpenency_Click(sender As Object, e As EventArgs) Handles btn_dpenency.Click
        Dim dependency = New DependencySelector()
        dependency.cargar(Me, FacadeRef, VehiculoVin)
        dependency.ShowDialog()
    End Sub

    Private Sub rch_desc_TextChanged(sender As Object, e As EventArgs) Handles rch_desc.TextChanged
        If rch_desc.TextLength > 0 Then
            btn_agregar.Enabled = True
        End If
    End Sub
End Class