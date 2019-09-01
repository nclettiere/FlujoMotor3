Imports DB

Public Class AgregarVehiculo
    Private Shared _instance As AgregarVehiculo

    Friend EstaModificando As Boolean = False
    Friend VinAModificar As String

    Public Shared Property Instance As AgregarVehiculo
        Get
            If _instance Is Nothing Then
                _instance = New AgregarVehiculo()
            End If
            Return _instance
        End Get
        Set(value As AgregarVehiculo)
            _instance = value
        End Set
    End Property

    Public Property FormParent As MenuControl
    Public Property SelectedLote As DataGridViewCellCollection
    Public Property LoteModo As Boolean
    Public Property LoteDatos As Boolean
    Public Property NuevoLoteInfo As String()
    Public Property Conexion As ODBC

    Private Sub OnAgrVehiculoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        VehiculoAno.Format = DateTimePickerFormat.Custom
        VehiculoAno.CustomFormat = "yyyy"
        VehiculoAno.ShowUpDown = True
        cbxTipo.SelectedIndex = 0
        LoteDatos = False
        LoteModo = False

        If EstaModificando
            Try
                Dim VehiculoDatos = Conexion.Consultar("SELECT * FROM vehiculos WHERE vehiculovin='" + VinAModificar + "'")
                If VehiculoDatos IsNot Nothing
                    If VehiculoDatos.Rows.Count > 0
                        Dim LoteId = VehiculoDatos.Rows(0).Item("loteid").ToString
                        If LoteId >= 0
                            Dim LoteDatos =  Conexion.Consultar("SELECT * FROM lotes WHERE loteid=" + LoteId)
                            If LoteDatos IsNot Nothing
                                If LoteDatos.Rows.Count > 0
                                    txtVin.Text = VehiculoDatos.Rows(0).Item("vehiculovin")
                                    txtMarca.Text = VehiculoDatos.Rows(0).Item("vehiculomarca")
                                    txtModelo.Text = VehiculoDatos.Rows(0).Item("vehiculomodelo")
                                    txtColor.Text = VehiculoDatos.Rows(0).Item("vehiculocolor")
                                    cbxTipo.SelectedValue = VehiculoDatos.Rows(0).Item("vehiculotipo")
                                    VehiculoAno.Value = DateTime.ParseExact(VehiculoDatos.Rows(0).Item("vehiculoanio"), "yyyy", Nothing)
                                    btnNuevoLote.Visible = False
                                    btnLoteExistente.Visible = False
                                    lblLoteSelection.Visible = True
                                    lblLoteSelection.Text = "Lote Seleccionado: ID=" + LoteDatos.Rows(0).Item("loteid").ToString + ", Nombre=" + LoteDatos.Rows(0).Item("lotenombre").ToString
                                    btnAgregar.Text = "Modificar"
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al obtener datos de vehiculo/lote.")
            End Try
        End If
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
        lblLoteSelection.Text = "Lote Seleccionado: ID=" + rowSeleccionado.Item("loteid").Value.ToString + ", Nombre=" + rowSeleccionado.Item("lotenombre").Value.ToString
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
                                    Return True
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
    End Sub

    Private Sub BtnLoteExistente_Click_1(sender As Object, e As EventArgs) Handles btnLoteExistente.Click
        Dim SelecLote As Ventana_Seleccionar = New Ventana_Seleccionar
        SelecLote.GoToSection(2, Me, FormParent.Conexion)
        SelecLote.ShowDialog()
    End Sub

    Private Sub BtnNuevoLote_Click_1(sender As Object, e As EventArgs) Handles btnNuevoLote.Click
        Dim SelecLote As Ventana_Seleccionar = New Ventana_Seleccionar
        SelecLote.GoToSection(0, Me, FormParent.Conexion)
        SelecLote.ShowDialog()
    End Sub

    Private Sub BtnQuitarClick(sender As Object, e As EventArgs) Handles btnQuitarLote.Click
        SelectedLote = Nothing
        btnNuevoLote.Visible = True
        btnLoteExistente.Visible = True
        lblLoteSelection.Visible = False
        btnQuitarLote.Visible = False
        LoteDatos = False
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckFields() Then
            If EstaModificando
                If String.Equals(VinAModificar, txtVin.Text)
                    Dim VehiculoDatos = Conexion.Consultar("SELECT * FROM vehiculos WHERE vehiculovin='" + VinAModificar + "'").Rows(0)
                    If Not String.Equals(txtMarca.Text, VehiculoDatos.Item("vehiculomarca"))
                        Conexion.Consultar("UPDATE vehiculos SET vehiculomarca='"+ txtMarca.Text +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                    If Not String.Equals(txtModelo.Text, VehiculoDatos.Item("vehiculomodelo"))
                        Conexion.Consultar("UPDATE vehiculos SET vehiculomodelo='"+ txtModelo.Text +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                    If Not String.Equals(txtColor.Text, VehiculoDatos.Item("vehiculocolor"))
                        Conexion.Consultar("UPDATE vehiculos SET vehiculocolor='"+ txtColor.Text +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                    If Not String.Equals(txtColor.Text, VehiculoDatos.Item("vehiculocolor"))
                        Conexion.Consultar("UPDATE vehiculos SET vehiculocolor='"+ txtColor.Text +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                    If Not String.Equals(VehiculoAno.Value.Year.ToString, VehiculoDatos.Item("vehiculoanio"))
                        Conexion.Consultar("UPDATE vehiculos SET vehiculoanio='"+ VehiculoAno.Value.Year.ToString +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                     Dim vehiculoTipo = cbxTipo.Text
                    If Not (String.Equals("SUV", cbxTipo.Text))
                        vehiculoTipo = cbxTipo.Text.ToLower()
                    End If

                    Conexion.Consultar("UPDATE vehiculos SET vehiculotipo='"+ vehiculoTipo +"' WHERE vehiculovin='"+ VinAModificar +"'")
                End If
            Else
                Dim ChequearVin As DataTable =
                FormParent.Conexion.Consultar("SELECT COUNT(*) FROM vehiculos WHERE vehiculovin ='" + txtVin.Text + "';")
                If ChequearVin.Rows(0).Item(0) = 0
                    If LoteModo
                        If LoteDatos
                            Try
                                Dim vehiculoTipo As String = cbxTipo.Text

                                If Not (String.Equals("SUV", cbxTipo.Text))
                                    vehiculoTipo = cbxTipo.Text.ToLower()
                                End If

                                Dim LoteCount = FormParent.Conexion.Consultar("SELECT COUNT(*) FROM lotes")
                                Dim VehiculoCount = FormParent.Conexion.Consultar("SELECT COUNT(*) FROM vehiculos")
                                Dim PatioInfo = FormParent.Conexion.Consultar("SELECT patioid FROM patios WHERE pationombre='" + NuevoLoteInfo(1) + "'")
                                Dim InsertarLote As DataTable = FormParent.Conexion.Consultar("INSERT INTO lotes (loteid, lotedescripcion, lotenombre, operariopuertoid, patioid) VALUES (" + (LoteCount.Rows(0).Item(0) + 1).ToString + ", '" + NuevoLoteInfo(0).ToString() + "', 'LOTE #" & (LoteCount.Rows(0).Item(0) + 1).ToString & "', 1," + PatioInfo.Rows(0).Item(0).ToString + ")")
                                Dim InsertarVehiculo As DataTable = FormParent.Conexion.Consultar("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID,loteID) VALUES ('" + txtVin.Text.ToUpper + "','" + txtColor.Text + "', '" + txtMarca.Text + "', '" + txtModelo.Text + "', " + VehiculoAno.Value.Year.ToString + ", '" + vehiculoTipo + "', 1, " + (LoteCount.Rows(0).Item(0) + 1).ToString + ")")

                                Dim AgregarInspeccionControl As AgregarInspeccion = New AgregarInspeccion
                                AgregarInspeccionControl.CargarDatos(txtVin.Text, FormParent.Conexion, Me)
                                Dim VentanaVer As Ventana_Ver = New Ventana_Ver
                                VentanaVer.LoadControl(AgregarInspeccionControl)
                                VentanaVer.ShowDialog()

                                MessageBox.Show("Vehiculo Ingresado Correctamente.")
                                Serilog.Log.Information("Vehiculo insertado correctamente.")
                                ClearFields()
                            Catch ex As Exception
                                Serilog.Log.Fatal(ex, "No se pudo insertar los datos en Agregar_Vehiculo. ref: InsertarLote, IngresarVehiculo")
                            End Try
                        Else
                            MessageBox.Show("NO LOTE")

                            Dim vehiculoTipo As String = cbxTipo.Text

                            If Not (String.Equals("SUV", cbxTipo.Text))
                                vehiculoTipo = cbxTipo.Text.ToLower()
                            End If

                            Dim VehiculoCount = FormParent.Conexion.Consultar("SELECT COUNT(*) FROM vehiculos")
                            Dim InsertarVehiculo As DataTable = FormParent.Conexion.Consultar("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID) VALUES ('" + txtVin.Text.ToUpper + "','" + txtColor.Text + "', '" + txtMarca.Text + "', '" + txtModelo.Text + "', " + VehiculoAno.Value.Year.ToString + ", '" + vehiculoTipo + "', 1 )")

                            Dim AgregarInspeccionControl As AgregarInspeccion = New AgregarInspeccion
                            AgregarInspeccionControl.CargarDatos(txtVin.Text, FormParent.Conexion, Me)
                            Dim VentanaVer As Ventana_Ver = New Ventana_Ver
                            VentanaVer.LoadControl(AgregarInspeccionControl)
                            VentanaVer.ShowDialog()

                            MessageBox.Show("Vehiculo Ingresado Correctamente.")
                            Serilog.Log.Information("Vehiculo insertado correctamente.")
                        End If
                    Else
                        If LoteDatos
                            Try
                                Dim InsertarVehiculo As DataTable = FormParent.Conexion.Consultar("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID,loteID) VALUES ('" + txtVin.Text.ToUpper + "','" + txtColor.Text + "', '" + txtMarca.Text + "', '" + txtModelo.Text + "', " + VehiculoAno.Value.Year.ToString + ", '" + cbxTipo.Text.ToLower() + "', 1, " + (SelectedLote.Item(0).Value).ToString + ")")

                                Dim AgregarInspeccionControl As AgregarInspeccion = New AgregarInspeccion
                                AgregarInspeccionControl.CargarDatos(txtVin.Text, FormParent.Conexion, Me)
                                Dim VentanaVer As Ventana_Ver = New Ventana_Ver
                                VentanaVer.LoadControl(AgregarInspeccionControl)
                                VentanaVer.ShowDialog()

                                MessageBox.Show("Vehiculo Ingresado Correctamente.")
                                Serilog.Log.Information("Vehiculo insertado correctamente.")
                                ClearFields()
                            Catch ex As Exception
                                Serilog.Log.Error(ex, "Error No se pudo insertar los datos en Agregar_Vehiculo. ref: InsertarVehiculo")
                            End Try
                        Else
                            Try
                                Dim vehiculoTipo As String = cbxTipo.Text

                                If Not (String.Equals("SUV", cbxTipo.Text))
                                    vehiculoTipo = cbxTipo.Text.ToLower()
                                End If

                                Dim VehiculoCount = FormParent.Conexion.Consultar("SELECT COUNT(*) FROM vehiculos")
                                Dim InsertarVehiculo As DataTable = FormParent.FormParent.Conexion.Consultar("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID) VALUES ('" + txtVin.Text.ToUpper + "','" + txtColor.Text + "', '" + txtMarca.Text + "', '" + txtModelo.Text + "', " + VehiculoAno.Value.Year.ToString + ", '" + vehiculoTipo + "', 1 )")

                                Dim AgregarInspeccionControl As AgregarInspeccion = New AgregarInspeccion
                                AgregarInspeccionControl.CargarDatos(txtVin.Text, FormParent.Conexion, Me)
                                Dim VentanaVer As Ventana_Ver = New Ventana_Ver
                                VentanaVer.LoadControl(AgregarInspeccionControl)
                                VentanaVer.ShowDialog()

                                MessageBox.Show("Vehiculo Ingresado Correctamente.")
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
        End If
    End Sub

    Private Sub BtnIrAtras_Click(sender As Object, e As EventArgs) Handles btnIrAtras.Click
        FormParent.GoToSection(0)
    End Sub
End Class