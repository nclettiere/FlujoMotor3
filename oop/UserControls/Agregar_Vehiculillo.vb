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

    Private _vin As String
    Private _tipo As String
    Private _marca As String
    Private _modelo As String
    Private _anio As Short
    Private _color As String

    Public Property Vin As String
        Get
            Return _vin
        End Get
        Set(value As String)
            _vin = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property Anio As Short
        Get
            Return _anio
        End Get
        Set(value As Short)
            _anio = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Public Property FormParent As Menu_Wapo
    Public Property SelectedLote As DataGridViewCellCollection

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load 
        VehiculoAno.Format = DateTimePickerFormat.Custom
        VehiculoAno.CustomFormat = "yyyy"
        VehiculoAno.ShowUpDown = true

        cbxTipo.SelectedIndex = 0
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
    End Sub

    Private Function CheckFields() As Boolean
        If Not String.IsNullOrWhiteSpace(txtVin.Text)
            If txtVin.Text.Length = 17
                If cbxTipo.SelectedIndex >= 0
                    If Not String.IsNullOrWhiteSpace(txtMarca.Text)
                        If Not String.IsNullOrWhiteSpace(txtModelo.Text)
                            If Not VehiculoAno.Value.Year > DateTime.Now.Year And Not VehiculoAno.Value.Year < 1808
                                If Not String.IsNullOrWhiteSpace(txtColor.Text)
                                    If SelectedLote IsNot Nothing
                                        MessageBox.Show("Valid data.")
                                        Return True
                                    Else
                                        MessageBox.Show("Debes seleccionar o crear un lote.")
                                        Return False
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

        End If
    End Sub

    Private Sub BtnLoteExistente_Click_1(sender As Object, e As EventArgs) Handles btnLoteExistente.Click
        Dim SelecLote As Ventanita_Seleccionar = New Ventanita_Seleccionar
        SelecLote.GoToSection(2, Me, FormParent.Conexion)
        SelecLote.ShowDialog()
    End Sub

    Private Sub BtnNuevoLote_Click_1(sender As Object, e As EventArgs) Handles btnNuevoLote.Click
        Dim SelecLote As Ventanita_Seleccionar = New Ventanita_Seleccionar
        SelecLote.GoToSection(2, Me, FormParent.Conexion)
        SelecLote.ShowDialog()
    End Sub

    Private Sub btnQuitarClick(sender As Object, e As EventArgs) Handles btnQuitarLote.Click
        SelectedLote = Nothing
        btnNuevoLote.Visible = True
        btnLoteExistente.Visible = True
        lblLoteSelection.Visible = False
        btnQuitarLote.Visible = False
    End Sub
End Class
