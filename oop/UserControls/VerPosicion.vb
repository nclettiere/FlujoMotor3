Imports Logica

Public Class VerPosicion
    Private Shared _instance As VerPosicion

    Public Shared Property Instance As VerPosicion
        Get
            If _instance Is Nothing Then
                _instance = New VerPosicion()
            End If
            Return _instance
        End Get
        Set(value As VerPosicion)
            _instance = value
        End Set
    End Property

    Public Property FormParent As MenuControl
    Public Property VIN As String
    Public Property TieneSubzona As Boolean
    Public Property Lote As DataTable
    Public Property Patio As DataRow
    Public Property ZonaId As String
    Public Property SubZonas As DataTable

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Fila As Integer = Nothing
        Dim Columna As Integer = Nothing
        If Integer.TryParse(tbxFila.Text , Fila) Then
            If Integer.TryParse(tbxColumna.Text , Columna) Then
                If cbxZona.SelectedIndex >= 0
                    Dim resultadoPatio As String = PObtenerID(Lote.Rows(0).Item("patioid").ToString).Item("pationombre")
                    MessageBox.Show(resultadoPatio)
                    If TieneSubzona
                        Try
                            VSUpdate(Fila.ToString, Columna.ToString, cbxZona.Text, VIN)
                            MessageBox.Show("La posicion del vehiculo: " + VIN + "ha sido actualizada." + Environment.NewLine +
                                            "Patio:" + resultadoPatio + Environment.NewLine +
                                            "Columna: " + Columna.ToString + Environment.NewLine +
                                            "Fila: " + Fila.ToString)
                        Catch ex As Exception
                            Serilog.Log.Error(ex, "Error al actualizar Subzona.")
                        End Try
                    Else
                        Try
                            VSZInsertar(VIN,  cbxZona.Text, zonaID, Columna.ToString, Fila.ToString)
                            MessageBox.Show("La posicion del vehiculo: " + VIN + "ha sido actualizada." + Environment.NewLine +
                                        "Patio:" + resultadoPatio + Environment.NewLine +
                                        "Columna: " + Columna.ToString + Environment.NewLine +
                                        "Fila: " + Fila.ToString)
                        Catch ex As Exception
                            Serilog.Log.Error(ex, "Error al actualizar Subzona.")
                        End Try
                    End If
                Else
                    MessageBox.Show("Debes seleccionar una zona.")
                End If
            Else
                MessageBox.Show("El campo 'Columna' debe ser numerico.")
            End If
        Else
          MessageBox.Show("El campo 'Fila' debe ser numerico.")
        End If
    End Sub

    Friend Sub CargarDatos(VIN As String)
        Me.VIN = VIN
        Try
            Dim SubZonaContador As Integer = VSZObtenerCount(VIN)
            If SubZonaContador > 0
                TieneSubzona = True
            Else
                TieneSubzona = False
            End If
        Catch ex As Exception
            Serilog.Log.Warning(ex, "Exception")
        End Try
    End Sub

    Private Sub OnPosicionLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Lote As DataRow = LObtenerVIN(VIN)
            Patio    = PObtenerID(Lote.Item("loteid"))
            Dim Zona = ZObtenerPatioID(Lote.Item("patioid"))
            ZonaId   = Zona.Item("zonaid").ToString
            SubZonas = SZObtenerIdTable(ZonaId)
            For Each item As DataRow In SubZonas.Rows
                cbxZona.Items.Add(item("subzonanombre").ToString)
            Next
            If SubZonas IsNot Nothing
                If SubZonas.Rows.Count > 0
                    If TieneSubzona
                        For Each Item As String in cbxZona.Items
                            If String.Equals(Item, SubZonas.Rows(0).Item("subzonanombre").ToString)
                                cbxZona.SelectedItem = Item
                            End If
                        Next

                        Dim ConsultaVSubZonas = VSZObtenerVIN(VIN)                      
                        tbxColumna.Text = ConsultaVSubZonas.Rows(0).Item("columna").ToString
                        tbxFila.Text = ConsultaVSubZonas.Rows(0).Item("fila").ToString
                    End If
                End If
            End If

            lblVehiculoPos.Text = "Posicion del Vehiculo: " + VIN
            lblPatio.Text = "Patio " + Patio.Item("pationombre").ToString
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al obtener zonas.")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ParentForm.Close
    End Sub
End Class
