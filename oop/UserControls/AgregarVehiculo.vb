Imports Logica

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

    Private Sub OnAgrVehiculoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        VehiculoAno.Format = DateTimePickerFormat.Custom
        VehiculoAno.CustomFormat = "yyyy"
        VehiculoAno.ShowUpDown = True
        cbxTipo.SelectedIndex = 0
        LoteDatos = False
        LoteModo = False

        If EstaModificando
            txtVin.Enabled = False
            Try
                Dim VehiculoDatos = VObtenerVIN(VinAModificar)
                If VehiculoDatos IsNot Nothing
                    Dim LoteId = VehiculoDatos.Item("loteid").ToString
                    If LoteId >= 0
                        Dim LoteDatos = Consultar("SELECT * FROM lotes WHERE loteid=" + LoteId)
                        If LoteDatos IsNot Nothing
                            If LoteDatos.Rows.Count > 0
                                txtVin.Text = VehiculoDatos.Item("vehiculovin")
                                txtMarca.Text = VehiculoDatos.Item("vehiculomarca")
                                txtModelo.Text = VehiculoDatos.Item("vehiculomodelo")
                                txtColor.Text = VehiculoDatos.Item("vehiculocolor")
                                cbxTipo.SelectedValue = VehiculoDatos.Item("vehiculotipo")
                                VehiculoAno.Value = DateTime.ParseExact(VehiculoDatos.Item("vehiculoanio"), "yyyy", Nothing)
                                btnNuevoLote.Visible = False
                                btnLoteExistente.Visible = False
                                lblLoteSelection.Visible = True
                                lblLoteSelection.Text = "Lote Seleccionado: ID=" + LoteDatos.Rows(0).Item("loteid").ToString + ", Nombre=" + LoteDatos.Rows(0).Item("lotenombre").ToString
                                btnAgregar.Text = "Modificar"
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
        SelecLote.GoToSection(2, Me)
        SelecLote.ShowDialog()
    End Sub

    Private Sub BtnNuevoLote_Click_1(sender As Object, e As EventArgs) Handles btnNuevoLote.Click
        Dim SelecLote As Ventana_Seleccionar = New Ventana_Seleccionar
        SelecLote.GoToSection(0, Me)
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
                    Dim VehiculoDatos = Consultar("SELECT * FROM vehiculos WHERE vehiculovin='" + VinAModificar + "'").Rows(0)
                    If Not String.Equals(txtMarca.Text, VehiculoDatos.Item("vehiculomarca"))
                        Consultar("UPDATE vehiculos SET vehiculomarca='"+ txtMarca.Text +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                    If Not String.Equals(txtModelo.Text, VehiculoDatos.Item("vehiculomodelo"))
                        Consultar("UPDATE vehiculos SET vehiculomodelo='"+ txtModelo.Text +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                    If Not String.Equals(txtColor.Text, VehiculoDatos.Item("vehiculocolor"))
                        Consultar("UPDATE vehiculos SET vehiculocolor='"+ txtColor.Text +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                    If Not String.Equals(txtColor.Text, VehiculoDatos.Item("vehiculocolor"))
                        Consultar("UPDATE vehiculos SET vehiculocolor='"+ txtColor.Text +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                    If Not String.Equals(VehiculoAno.Value.Year.ToString, VehiculoDatos.Item("vehiculoanio"))
                        Consultar("UPDATE vehiculos SET vehiculoanio='"+ VehiculoAno.Value.Year.ToString +"' WHERE vehiculovin='"+ VinAModificar +"'")
                    End If

                     Dim vehiculoTipo = cbxTipo.Text
                    If Not (String.Equals("SUV", cbxTipo.Text))
                        vehiculoTipo = cbxTipo.Text.ToLower()
                    End If

                    Consultar("UPDATE vehiculos SET vehiculotipo='"+ vehiculoTipo +"' WHERE vehiculovin='"+ VinAModificar +"'")

                    MessageBox.Show("Vehiculo Modificado Correctamente.")
                    ParentForm.Close
                End If
            Else
                Dim ChequearVin As Integer = VCheckVin(txtVin.Text)
                If ChequearVin = 0
                    If LoteModo
                        If LoteDatos
                            MsgBox("trigger2")
                            Try
                                Dim vehiculoTipo As String = cbxTipo.Text

                                If Not (String.Equals("SUV", cbxTipo.Text))
                                    vehiculoTipo = cbxTipo.Text.ToLower()
                                End If

                                Dim LoteCount = LObtenerCountAll()
                                Dim PatioInfo = PObtenerNombre(NuevoLoteInfo(1))
                                Dim LMetaDatos As String() = {(LoteCount + 1).ToString, NuevoLoteInfo(0).ToString(), NuevoLoteInfo(2),  "1",  PatioInfo.Item("patioid").ToString} 
                                LInsertar(LMetaDatos)
                                Dim VMetaDatos As String() = {txtVin.Text.ToUpper, txtColor.Text, txtMarca.Text, txtModelo.Text, VehiculoAno.Value.Year.ToString, vehiculoTipo, "1", (LoteCount + 1).ToString} 
                                VInsertar(VMetaDatos)

                                MessageBox.Show("Vehiculo Ingresado Correctamente.")
                                Serilog.Log.Information("Vehiculo insertado correctamente.")
                                ClearFields()
                            Catch ex As Exception
                                Serilog.Log.Fatal(ex, "No se pudo insertar los datos en Agregar_Vehiculo. ref: InsertarLote, IngresarVehiculo")
                            End Try
                        Else
                            MsgBox("trigger1")
                            Dim vehiculoTipo As String = cbxTipo.Text

                            If Not (String.Equals("SUV", cbxTipo.Text))
                                vehiculoTipo = cbxTipo.Text.ToLower()
                            End If

                            Dim VMetaDatos As String() = {txtVin.Text.ToUpper, txtColor.Text, txtMarca.Text, txtModelo.Text, VehiculoAno.Value.Year.ToString, vehiculoTipo, "1"} 
                            VInsertar(VMetaDatos)

                            MessageBox.Show("Vehiculo Ingresado Correctamente.")
                            Serilog.Log.Information("Vehiculo insertado correctamente.")
                        End If
                    Else
                        If LoteDatos
                            Try
                                MsgBox("trigger3")
                                Dim vehiculoTipo As String = cbxTipo.Text
                                 If Not (String.Equals("SUV", cbxTipo.Text))
                                    vehiculoTipo = cbxTipo.Text.ToLower()
                                End If

                                'Dim InsertarVehiculo As DataTable = FormParent.Conexion.Consultar("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID,loteID) VALUES ('" + txtVin.Text.ToUpper + "','" + txtColor.Text + "', '" + txtMarca.Text + "', '" + txtModelo.Text + "', " + VehiculoAno.Value.Year.ToString + ", '" + cbxTipo.Text.ToLower() + "', 1, " + (SelectedLote.Item(0).Value).ToString + ")")

                                Dim VMetaDatos As String() = {txtVin.Text.ToUpper, txtColor.Text, txtMarca.Text, txtModelo.Text, VehiculoAno.Value.Year.ToString, vehiculoTipo, "1", (SelectedLote.Item(0).Value).ToString} 
                                VInsertar(VMetaDatos)

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

                                Dim VMetaDatos As String() = {txtVin.Text.ToUpper, txtColor.Text, txtMarca.Text, txtModelo.Text, VehiculoAno.Value.Year.ToString, vehiculoTipo} 
                                VInsertar(VMetaDatos)

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