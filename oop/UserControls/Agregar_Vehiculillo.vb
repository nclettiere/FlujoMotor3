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
                                            MessageBox.Show("Valid data.")
                                            Return True
                                        Else
                                            MessageBox.Show("Debes seleccionar o crear un lote.")
                                            Return False
                                        End If
                                    Else
                                        If SelectedLote IsNot Nothing And LoteDatos
                                            MessageBox.Show("Valid data.")
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

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckFields() Then
            Dim ChequearVin As DataTable = 
                FormParent.Conexion.consultar("SELECT COUNT(*) FROM vehiculos WHERE vehiculovin ='"+ txtVin.Text +"';")
            If String.Equals(ChequearVin.Rows(0).Item(0).ToString, "0")
                If LoteModo
                    If LoteDatos
                        Try
                            Dim LoteCount = FormParent.Conexion.consultar("SELECT COUNT(*) FROM lotes")
                            Dim InsertarLote As DataTable = FormParent.Conexion.consultar("INSERT INTO lotes (loteid, lotedescripcion, lotenombre , operariopuertoid) VALUES ("+ (LoteCount.Rows(0).Item(0) + 1).ToString +", '"+ NuevoLoteInfo(0).ToString() +"', 'LOT_C', 1)")
                            Serilog.Log.Verbose("Datos insertados correctamente.")
                        Catch ex As Exception
                            Serilog.Log.Fatal(ex, "No se pudo insertar los datos en Agregar_Vehiculo. ref: InsertarLote")
                        End Try
                        
                    End If
                End If
            Else
                MessageBox.Show("Error: Vehiculo existente.")
            End If
        End If
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
End Class