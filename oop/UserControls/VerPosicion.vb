Imports DB

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
    Public Property Conexion As DB.ODBC
    Public Property VIN As String
    Public Property TieneSubzona As Boolean
    Public Property Lote As DataTable
    Public Property Patio As DataTable
    Public Property ZonaId As String
    Public Property SubZonas As DataTable

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Fila As Integer = Nothing
        Dim Columna As Integer = Nothing
        If Integer.TryParse(tbxFila.Text , Fila) Then
            If Integer.TryParse(tbxColumna.Text , Columna) Then
                If cbxZona.SelectedIndex >= 0
                    Dim resultadoPatio As String = Conexion.Consultar("SELECT pationombre FROM patios WHERE patioid=" + Lote.Rows(0).Item("patioid").ToString).Rows(0).Item(0).ToString
                    MessageBox.Show(resultadoPatio)
                    If TieneSubzona
                        Try
                            Conexion.Consultar("UPDATE vehiculosubzona SET fila="+ Fila.ToString +", columna="+ Columna.ToString  +" WHERE vehiculovin='"+ VIN +"' AND subzonanombre='"+ cbxZona.Text +"'")  
                            MessageBox.Show("La posicion del vehiculo: " + VIN + "ha sido actualizada." + Environment.NewLine +
                                            "Patio:" + resultadoPatio + Environment.NewLine +
                                            "Columna: " + Columna.ToString + Environment.NewLine +
                                            "Fila: " + Fila.ToString)
                        Catch ex As Exception
                            Serilog.Log.Error(ex, "Error al actualizar Subzona.")
                        End Try
                    Else
                        Try
                            Conexion.Consultar("INSERT INTO vehiculosubzona (vehiculoVIN, subZonaNombre, zonaID, columna, fila) VALUES ('"+ VIN +"', '"+ cbxZona.Text +"', "+ ZonaId +", "+ Columna.ToString +", "+ Fila.ToString +")")
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

    Friend Sub CargarDatos(VIN As String, Conexion As ODBC)
        Me.Conexion = Conexion
        Me.VIN = VIN
        Try
            Dim SubZonaContador As Integer = Nothing
            Dim ConsultaContadorSubZonas =  Conexion.Consultar("SELECT COUNT(*) FROM vehiculosubzona WHERE vehiculovin='" + VIN +"';").Rows(0).Item(0).ToString
            If Integer.TryParse(ConsultaContadorSubZonas, SubZonaContador)
                If SubZonaContador > 0
                    TieneSubzona = True
                Else
                    TieneSubzona = False
                End If
            Else
                TieneSubzona = False
            End If
        Catch ex As Exception
            Serilog.Log.Warning(ex, "Exception")
        End Try
    End Sub

    Private Sub OnPosicionLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim LoteId As String = Conexion.Consultar("SELECT loteid FROM vehiculos WHERE vehiculovin='" + VIN + "'").Rows(0).Item(0).ToString
            Lote     = Conexion.Consultar("SELECT * FROM lotes WHERE loteid=" + LoteId)
            Patio    = Conexion.Consultar("SELECT * FROM patios WHERE patioid=" + Lote.Rows(0).Item("patioid").ToString)
            Dim Zona = Conexion.Consultar("SELECT * FROM zonas WHERE patioid=" + Lote.Rows(0).Item("patioid").ToString)
            ZonaId   = Zona.Rows(0).Item(0).ToString
            SubZonas = Conexion.Consultar("SELECT * FROM subzonas WHERE zonaid=" + ZonaId)
            For Each item As DataRow In SubZonas.Rows
                cbxZona.Items.Add(item("subzonanombre").ToString)
            Next
            If SubZonas IsNot Nothing
                If SubZonas.Rows.Count > 0
                    If TieneSubzona
                        Dim ConsultaSubZonas =  Conexion.Consultar("SELECT * FROM vehiculosubzona WHERE vehiculovin='" + VIN +"';").Rows(0)
                        For Each Item As String in cbxZona.Items
                            If String.Equals(Item, SubZonas.Rows(0).Item("subzonanombre").ToString)
                                cbxZona.SelectedItem = Item
                            End If
                        Next
                        
                        tbxColumna.Text = ConsultaSubZonas.Item("columna").ToString
                        tbxFila.Text = ConsultaSubZonas.Item("fila").ToString
                    End If
                End If
            End If

            lblVehiculoPos.Text = "Posicion del Vehiculo: " + VIN
            lblPatio.Text = "Patio " + Patio.Rows(0).Item("pationombre").ToString
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al obtener zonas.")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ParentForm.Close
    End Sub
End Class
