Imports oop

Public Class Agregar_Vehiculillo
    Private Shared _instance As Agregar_Vehiculillo

    Public Shared Property Instance As Agregar_Vehiculillo
        Get
            If _instance Is Nothing Then
                _instance = New Agregar_Vehiculillo()
            End If
            Return _instance
        End Get
        Set(value As Agregar_Vehiculillo)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Menu_Wapo
    Public Property SelectedLote As DataGridViewCellCollection
    Public Property LoteModo As Boolean
    Public Property LoteDatos As Boolean
    Public Property NuevoLoteInfo As String()

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load 
        VehiculoAno.Format = DateTimePickerFormat.Custom
        VehiculoAno.CustomFormat = "yyyy"
        VehiculoAno.ShowUpDown = true
        cbxTipo.SelectedIndex = 0
        LoteDatos = False
        LoteModo = False
    End Sub

    Private Sub TxtVin_TextChanged(sender As Object, e As EventArgs) Handles txtVin.TextChanged 
        If txtVin.Text.Length > 17
            txtVin.Text = txtVin.Text.Trim().Substring(0, txtVin.Text.Length - 1)
        End If
    End Sub

    Friend Sub UpdateLotes(rowSeleccionado As DataGridViewCellCollection)
        SelectedLote = rowSeleccionado
        btnNuevoLote.Visible = False
        btnLoteExistente.Visible = False
        lblLoteSelection.Visible = True
        btnQuitarLote.Visible = True
        lblLoteSelection.Text = "Lote Seleccionado: ID="+ rowSeleccionado.Item("loteid").Value.ToString +", Nombre="+ rowSeleccionado.Item("lotenombre").Value.ToString
        LoteModo = False
        LoteDatos = True
    End Sub

    Friend Sub UpdateLotes(datos As String())
        NuevoLoteInfo = datos
        btnNuevoLote.Visible = False
        btnLoteExistente.Visible = False
        lblLoteSelection.Visible = True
        btnQuitarLote.Visible = True
        lblLoteSelection.Text = "Se creara un nuevo lote cuando agregues el vehiculo."
        LoteModo = True
        LoteDatos = True
    End Sub

    Private Function CheckFields() As Boolean
        If Not String.IsNullOrWhiteSpace(txtVin.Text)
            If txtVin.Text.Length = 17
                If cbxTipo.SelectedIndex >= 0
                    If Not String.IsNullOrWhiteSpace(txtMarca.Text)
                        If Not String.IsNullOrWhiteSpace(txtModelo.Text)
                            If Not VehiculoAno.Value.Year > Now.Year And Not VehiculoAno.Value.Year < 1808
                                If Not String.IsNullOrWhiteSpace(txtColor.Text)
                                    If LoteModo
                                        If LoteDatos
                                            Return True
                                        Else
                                            MessageBox.Show("Debes seleccionar o crear un lote.")
                                            Return False
                                        End If
                                    Else
                                        If SelectedLote IsNot Nothing And LoteDatos
                                            Return True
                                        Else
                                            MessageBox.Show("Debes seleccionar o crear un lote.")
                                            Return False
                                        End If
                                    End If
                                Else
                                    MessageBox.Show("El campo color no debe quedar vacio.")
                                    Return False
                                End If
                            Else
                                 MessageBox.Show("No podes viajar en el tiempo.")
                                Return False
                            End If
                        Else
                             MessageBox.Show("El campo modelo no debe quedar vacio.")
                            Return False
                        End If
                    Else
                        MessageBox.Show("El campo marca no debe quedar vacio.")
                        Return False
                    End If
                Else
                    MessageBox.Show("Debes seleccionar el tipo de vehiculo.")
                    Return False
                End If
            Else
                MessageBox.Show("El campo VIN debe tener 17 caracteres.")
                Return False
            End If
        Else
            MessageBox.Show("El campo VIN no debe estar vacio.")
            Return False
        End If
    End Function

    Private Sub ClearFields()
        txtVin.Text = String.Empty
        txtColor.Text = String.Empty
        txtMarca.Text = String.Empty
        txtModelo.Text = String.Empty
        SelectedLote = Nothing
        btnNuevoLote.Visible = True
        btnLoteExistente.Visible = True
        lblLoteSelection.Visible = False
        btnQuitarLote.Visible = False
        LoteDatos = False

        FormParent.UpdateVehiculos()
    End Sub

    Private Sub BtnLoteExistente_Click_1(sender As Object, e As EventArgs) Handles btnLoteExistente.Click
        Dim SelecLote As Ventanita_Seleccionar = New Ventanita_Seleccionar
        SelecLote.GoToSection(2, Me, FormParent.Conexion)
        SelecLote.ShowDialog()
    End Sub

    Private Sub BtnNuevoLote_Click_1(sender As Object, e As EventArgs) Handles btnNuevoLote.Click
        Dim SelecLote As Ventanita_Seleccionar = New Ventanita_Seleccionar
        SelecLote.GoToSection(0, Me, FormParent.Conexion)
        SelecLote.ShowDialog()
    End Sub

    Private Sub btnQuitarClick(sender As Object, e As EventArgs) Handles btnQuitarLote.Click
        SelectedLote = Nothing
        btnNuevoLote.Visible = True
        btnLoteExistente.Visible = True
        lblLoteSelection.Visible = False
        btnQuitarLote.Visible = False
        LoteDatos = False
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckFields() Then
            Dim ChequearVin As DataTable = 
                FormParent.Conexion.consultar("SELECT COUNT(*) FROM vehiculos WHERE vehiculovin ='"+ txtVin.Text +"';")
            If ChequearVin.Rows(0).Item(0) = 0
                If LoteModo
                    If LoteDatos
                        Try
                            Dim vehiculoTipo As String = cbxTipo.Text

                            If Not (String.Equals("SUV", cbxTipo.Text))
                                vehiculoTipo = cbxTipo.Text.ToLower()
                            End If
                            
                            Dim LoteCount = FormParent.Conexion.consultar("SELECT COUNT(*) FROM lotes")
                            Dim VehiculoCount = FormParent.Conexion.consultar("SELECT COUNT(*) FROM vehiculos")
                            Dim PatioInfo = FormParent.Conexion.consultar("SELECT pationombre FROM patios WHERE patio="+ NuevoLoteInfo(0))
                            Dim InsertarLote As DataTable = FormParent.Conexion.consultar("INSERT INTO lotes (loteid, lotedescripcion, lotenombre, operariopuertoid, patioid) VALUES (" + (LoteCount.Rows(0).Item(0) + 1).ToString + ", '" + NuevoLoteInfo(0).ToString() + "', 'LOTE #"& (LoteCount.Rows(0).Item(0) + 1).ToString &"', 1,"+ PatioInfo.Rows(0).Item(0).ToString +")")
                            Dim InsertarVehiculo As DataTable = FormParent.Conexion.consultar("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID,loteID) VALUES ('"+ txtVin.Text.ToUpper +"','"+ txtColor.Text +"', '"+ txtMarca.Text +"', '"+ txtModelo.Text +"', "+ VehiculoAno.Value.Year.ToString +", '"+ vehiculoTipo +"', 1, "+ (LoteCount.Rows(0).Item(0) + 1).ToString + ")")
                            Messagebox.Show("Vehiculo Ingresado Correctamente.")
                            Serilog.Log.Information("Vehiculo insertado correctamente.")
                            ClearFields()
                        Catch ex As Exception
                            Serilog.Log.Fatal(ex, "No se pudo insertar los datos en Agregar_Vehiculo. ref: InsertarLote, IngresarVehiculo")
                        End Try
                    End If
                Else
                    If LoteDatos
                        Try
                            Dim InsertarVehiculo As DataTable = FormParent.Conexion.consultar("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID,loteID) VALUES ('"+ txtVin.Text.ToUpper +"','"+ txtColor.Text +"', '"+ txtMarca.Text +"', '"+ txtModelo.Text +"', "+ VehiculoAno.Value.Year.ToString +", '"+ cbxTipo.Text.ToLower() +"', 1, "+ (SelectedLote.Item(0).Value).ToString + ")")
                            Messagebox.Show("Vehiculo Ingresado Correctamente.")
                            Serilog.Log.Information("Vehiculo insertado correctamente.")
                            ClearFields()
                        Catch ex As Exception
                            Serilog.Log.Error(ex, "Error No se pudo insertar los datos en Agregar_Vehiculo. ref: InsertarVehiculo")
                        End Try                            
                    End If
                End If
            Else
                MessageBox.Show("Error: El VIN ingresado ya existe.")
            End If
        End If
    End Sub
End Class