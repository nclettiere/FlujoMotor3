Imports Logica

Public Class VerVehiculoPatio

    Private ParentFormClass As Op_patio
    Private FacadeRef As Facade

    Private Vehiculo As VehiculoTest
    Private VehiculoVin As String

    Private Ubicacion As Ubicacion
    Private PatioID As Integer
    Private Patio As Patio
    Private Patios As List(Of Patio)
    Private Inspecciones As List(Of Inspeccion)

    Private DefaultItem As String

    Friend Sub cargar(op_patio As Op_patio, facade As Facade, vin As String)
        ParentFormClass = op_patio
        FacadeRef = facade
        VehiculoVin = vin
        Vehiculo = FacadeRef.BuscarVinEnLista(vin)
        Ubicacion = FacadeRef.ObtenerUbicacion(Vehiculo.UbicacionID)
        PatioID = Ubicacion.PatioID
        Patio = FacadeRef.ObtenerPatio(PatioID)
        Patios = FacadeRef.ObtenerPatios()
        Inspecciones = FacadeRef.ObtenerInspecciones
    End Sub

    Private Sub VerVehiculoPatio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbx_posA.Text = Ubicacion.Lat.ToString
        txb_PosB.Text = Ubicacion.Long.ToString
        For Each item As Patio In Patios
            cbx_patios.Items.Add(item.Nombre)
            If item.PatioId = PatioID Then
                cbx_patios.SelectedItem = item.Nombre
                DefaultItem = cbx_patios.SelectedItem.ToString
            End If
        Next

        For Each inspeccion In Inspecciones
            lst_inspecciones.Items.Add(inspeccion.InspeccionID)
        Next
    End Sub

    Private Sub chk_1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_1.CheckedChanged
        If DirectCast(sender, CheckBox).Checked Then
            tbx_posA.Enabled = True
        Else
            tbx_posA.Enabled = False
        End If
    End Sub

    Private Sub chk_2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_2.CheckedChanged
        If DirectCast(sender, CheckBox).Checked Then
            txb_PosB.Enabled = True
        Else
            txb_PosB.Enabled = False
        End If
    End Sub

    Friend Sub ActualizarLista()
        lst_inspecciones.BeginUpdate()
        lst_inspecciones.Items.Clear()
        For Each inspeccion In Inspecciones
            lst_inspecciones.Items.Add(inspeccion.InspeccionID)
        Next
        lst_inspecciones.EndUpdate()
    End Sub

    Private Sub chk_3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_3.CheckedChanged
        If DirectCast(sender, CheckBox).Checked Then
            cbx_patios.Enabled = True
        Else
            cbx_patios.Enabled = False
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If chk_1.Checked Then
            Try
                Dim Val As Double
                If Double.TryParse(tbx_posA.Text, Val) Then
                    Ubicacion.Lat = Val
                End If
            Catch ex As Exception
                MessageBox.Show("Error, la posicionA debe ser un numero.")
            End Try
        End If

        If chk_2.Checked Then
            Try
                Dim Val As Double
                If Double.TryParse(txb_PosB.Text, Val) Then
                    Ubicacion.Long = Val
                End If
            Catch ex As Exception
                MessageBox.Show("Error, la posicionA debe ser un numero.")
            End Try
        End If

        If chk_3.Checked Then
            Try
                If cbx_patios.SelectedItem.ToString <> DefaultItem Then
                    For Each PatioItem In Patios
                        If String.Equals(PatioItem.Nombre, cbx_patios.SelectedItem.ToString) Then
                            Ubicacion.PatioID = PatioItem.PatioId
                        End If
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("Error en el checkbox.")
            End Try
        End If

        ParentFormClass.ActualizarLista()
        Me.Close()
    End Sub

    Private Sub ItemDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_inspecciones.MouseDoubleClick
        Try
            Dim InspeccionId As Integer = Int32.Parse(lst_inspecciones.SelectedItem.ToString)
            Dim verInspeccion = New VerInspeccion()
            verInspeccion.cargar(Me, FacadeRef, VehiculoVin, InspeccionId)
            verInspeccion.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub InspeccionClick(sender As Object, e As EventArgs) Handles btn_inspeccion.Click
        Dim agregarInspeccion = New AgregarInspeccion()
        agregarInspeccion.cargar(Me, FacadeRef, VehiculoVin)
        agregarInspeccion.ShowDialog()
    End Sub
End Class