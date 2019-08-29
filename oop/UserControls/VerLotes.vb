Imports DB

Public Class VerLotes
    Private Shared _instance As VerLotes

    Public Shared Property Instance As VerLotes
        Get
            If _instance Is Nothing Then
                _instance = New VerLotes()
            End If
            Return _instance
        End Get
        Set(value As VerLotes)
            _instance = value
        End Set
    End Property

    Private Property Conexion As ODBC

    Private Property LoteId As String

    Friend Sub Data(loteid As String, ByRef Conexion As ODBC)
        Me.Conexion = Conexion
        Me.LoteId = loteid
        
        CargarDatos()
    End Sub

    Private Sub CargarDatos()   
        Try
            Dim ListaVehiculos As DataTable = Conexion.Consultar("SELECT * FROM vehiculos WHERE loteid=" + loteid)
            Dim Lote = Conexion.Consultar("SELECT * FROM lotes WHERE loteid=" + loteid.ToString).Rows(0)
            If ListaVehiculos IsNot Nothing
                Dim Patio = Conexion.Consultar("SELECT * FROM patios WHERE patioid=" + Lote.Item("patioid").ToString).Rows(0)
                If Patio IsNot Nothing
                    lblPatio.Text = Patio.Item("pationombre")
                End If
                DataGridViewVehiculos.DataSource = ListaVehiculos
                labId.Text = Lote.Item("loteid")
                Try
                    lblFechaSalida.Text = Lote.Item("lotefechasalida")
                    lblFechaLlegada.Text = Lote.Item("lotefechallegada")
                Catch ex As Exception
                    Serilog.Log.Warning(ex, "Error al obtener fecha salida/llegada.")
                End Try
                riTeBoDescripcion.Text = Lote.Item("lotedescripcion")
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error Al listar vehiculo o lote. ref Ver_Lote.vb")
        End Try
    End Sub

    Private Sub BtnEntregar_Click_1(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim result As Integer = MessageBox.Show("Los se encargaran de movilizar el lote.", "Desea entregar el lote?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Conexion.Consultar("UPDATE lotes SET lotedescripcion ='"+ riTeBoDescripcion.Text + ";'" +" WHERE loteid="+ LoteId +";")   
                MessageBox.Show("Lote entregado correctamente.")
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al entregar lote.")
            End Try
        End If
    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        ParentForm.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        lblFechaLlegada.Visible = False
        lblFechaSalida.Visible = False
        DateTimeLlegada.Visible = True
        DateTimeSalida.Visible = True
        riTeBoDescripcion.ReadOnly = False
        btnEntregar.Enabled = False
        DataGridViewVehiculos.Enabled = False
        lblPatio.Visible = False
        cbxPatios.Visible = True
        btnModificar.Enabled = False
        btnMod.Visible = True
        dateTimeLlegada.Format = DateTimePickerFormat.Custom
        dateTimeSalida.Format = DateTimePickerFormat.Custom
        dateTimeLlegada.CustomFormat = "dd/MM/yyyy HH:mm:ss tt"
        dateTimeSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss tt"
        Dim formatos = "dd/MM/yyyy HH:mm:ss tt"

        Try
            Dim ConsultaPatios = Conexion.Consultar("SELECT * FROM patios")
            If ConsultaPatios IsNot Nothing
                If ConsultaPatios.Rows.Count > 0
                    Dim contador As Integer = 1
                    Dim index As Integer = 1
                    Dim Lote = Conexion.Consultar("SELECT * FROM lotes WHERE loteid=" + loteid.ToString).Rows(0)
                    Dim PatioLote = Conexion.Consultar("SELECT * FROM patios WHERE patioid=" + Lote.Item("patioid").ToString).Rows(0)

                    For Each item As DataRow in ConsultaPatios.Rows()
                        cbxPatios.Items.Add(item.Item("pationombre"))
                        If String.Equals(item.Item("pationombre"), PatioLote.Item("pationombre"))
                            index = contador
                        End If
                        Contador += 1
                    Next

                    Try
                        cbxPatios.SelectedIndex = (index - 1)
                    Catch ex As Exception
                        Serilog.Log.Warning(ex, "No se pudo setear cbxpatio. Hay patios ingresados en la db?")
                    End Try

                    Try
                        MessageBox.Show(Lote.Item("lotefechallegada"))
                        DateTimeLlegada.Value = DateTime.ParseExact(Lote.Item("lotefechallegada").ToString, "dd/MM/yyyy HH:mm:ss tt", Nothing)
                        DateTimeSalida.Value = DateTime.ParseExact(Lote.Item("lotefechasalida").ToString, "dd/MM/yyyy HH:mm:ss tt", Nothing)
                    Catch ex As Exception
                        Serilog.Log.Warning(ex, "No se pudo setear DateTimeLlegada/Salida. Chequee el formato de las fechas.")
                    End Try
                End If
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al obtener patios")
        End Try

    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim Lote = Conexion.Consultar("SELECT * FROM lotes WHERE loteid=" + loteid.ToString).Rows(0)
            Dim PatioLote = Conexion.Consultar("SELECT * FROM patios WHERE pationombre='" + cbxPatios.Text +"'").Rows(0)

            If Not String.Equals(Lote.Item("patioid").ToString, PatioLote.Item("patioid").ToString)
                Conexion.Consultar("UPDATE lotes SET patioid ="+PatioLote.Item("patioid").ToString+" WHERE loteid="+LoteId)
            End If

            If Not String.Equals(Lote.Item("lotedescripcion").ToString, riTeBoDescripcion.Text)
                Conexion.Consultar("UPDATE lotes SET lotedescripcion ='"+riTeBoDescripcion.Text+"' WHERE loteid="+LoteId)
            End If

            Conexion.Consultar("UPDATE lotes SET lotefechallegada ='"+DateTimeLlegada.Value.ToString+"', lotefechasalida ='"+DateTimeSalida.Value.ToString+"' WHERE loteid="+LoteId)

        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al modificardatos.")
        End Try

        lblFechaLlegada.Visible = True
        lblFechaSalida.Visible = True
        DateTimeLlegada.Visible = False
        DateTimeSalida.Visible = False
        riTeBoDescripcion.ReadOnly = True
        btnEntregar.Enabled = True
        DataGridViewVehiculos.Enabled = True
        lblPatio.Visible = True
        cbxPatios.Visible = False
        btnModificar.Enabled = True
        btnMod.Visible = False

        CargarDatos()
    End Sub
End Class
