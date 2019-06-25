Imports Logica

Public Class AgregarVehiculo

    Private ParentFormClass As Vehiculos
    Private FacadeRef As Facade


    Public Sub cargar(fomr As Vehiculos, facade As Facade)
        ParentFormClass = fomr
        FacadeRef = facade
    End Sub

    Private Sub Operario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'BOTON "ACEPTAR"
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Try
            If (String.IsNullOrWhiteSpace(txtVIN.Text)) And (String.IsNullOrWhiteSpace(cbx_tipo.SelectedItem.ToString)) And (String.IsNullOrWhiteSpace(txtMarca.Text)) And (String.IsNullOrWhiteSpace(txtModelo.Text)) And (String.IsNullOrWhiteSpace(txtAno.Text)) And (String.IsNullOrWhiteSpace(tbx_cNombre.Text)) Then
                MessageBox.Show("Nunguno de los campos puede quedar vacio", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (String.IsNullOrWhiteSpace(txtVIN.Text)) Then
                MessageBox.Show("El campo 'V.I.N.' no debe quedar vacio", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (txtVIN.Text.Count < 17 Or txtVIN.Text.Count > 17) Then
                MessageBox.Show("El campo 'V.I.N.' debe tener exactamente 17 caracteres.", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (String.IsNullOrWhiteSpace(cbx_tipo.SelectedItem.ToString)) Then
                MessageBox.Show("El campo 'TIPO' no debe quedar vacio", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (String.IsNullOrWhiteSpace(txtMarca.Text)) Then
                MessageBox.Show("El campo 'MARCA' no debe quedar vacio", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (String.IsNullOrWhiteSpace(txtModelo.Text)) Then
                MessageBox.Show("El campo 'MODELO' no debe quedar vacio", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (String.IsNullOrWhiteSpace(txtColor.Text)) Then
                MessageBox.Show("El campo 'COLOR' no debe quedar vacio", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (String.IsNullOrWhiteSpace(txtAno.Text)) Then
                MessageBox.Show("El campo 'AÑO' no debe quedar vacio", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (Not IsNumeric(txtAno.Text)) Then
                MessageBox.Show("El campo 'AÑO' debe ser numerico.", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (IsNumeric(txtColor.Text)) Then
                MessageBox.Show("El campo 'COLOR' NO debe ser numerico.", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (String.IsNullOrWhiteSpace(tbx_cNombre.Text)) Then
                MessageBox.Show("El campo 'Cliente Nombre' no debe quedar vacio.", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim NuevaUbicacionID = FacadeRef.GenerarUbicacionId()
                Dim NuevaUbicacion = New Ubicacion(NuevaUbicacionID,
                                                   0,
                                                   0,
                                                   "Esperando Inspeccion",
                                                   0)
                Dim UbicacionCsv() As String = {NuevaUbicacionID.ToString, "0", "0", "Esperando Inspeccion", 0}

                Dim NuevoVehiculo As VehiculoTest = New VehiculoTest(txtVIN.Text,
                                                                     txtMarca.Text,
                                                                     txtModelo.Text,
                                                                     cbx_tipo.SelectedItem.ToString,
                                                                     txtColor.Text,
                                                                     "Esperando Inspeccion",
                                                                     Int32.Parse(txtAno.Text),
                                                                     Date.Now.ToShortDateString,
                                                                     0,
                                                                     FacadeRef.Operario.Id,
                                                                     NuevaUbicacionID,
                                                                     tbx_cNombre.Text)
                Dim VehiculoCsv() As String = {txtVIN.Text,
                                               txtMarca.Text,
                                               txtModelo.Text,
                                               cbx_tipo.SelectedItem.ToString,
                                               txtColor.Text,
                                               txtAno.Text,
                                               Date.Now.ToShortDateString,
                                               "0",
                                               FacadeRef.Operario.Id.ToString,
                                               NuevaUbicacionID.ToString,
                                               tbx_cNombre.Text}

                If FacadeRef.AgregarVehiculo(NuevoVehiculo) Then

                    FacadeRef.AgregarUbicacion(NuevaUbicacion)

                    FacadeRef.AgregarVehiculoACsv(VehiculoCsv, FacadeRef.CSVVehiculos)
                    FacadeRef.AgregarUbicacionACsv(UbicacionCsv, FacadeRef.CSVUbicaciones)

                    MessageBox.Show("Vehiculo Agregado Correctamente.", "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ParentFormClass.ActualizarListaVehiculos()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Uno de los campos es incorrecto.")
        End Try
    End Sub




    'BOTON "CANCELAR"
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub
End Class