Imports Logica

Public Class AparcarVehiculo

    Friend VIN As String
    Friend PatioId As String

    Private Sub AparcarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupControl
        UpdateLang
    End Sub

    Private Sub SetupControl
        Try
            Dim PatioInfo As DataRow = PObtenerID(PatioId)
            If PatioInfo IsNot Nothing
                lblpatio.Text = _Lang.ObtenerKey("AparcarVehiculo", 2)+": " + PatioInfo.Item("patioNombre")
                Dim ZonasId As DataTable = ZObtener(PatioInfo.Item("patioID").ToString)
                If ZonasId IsNot Nothing
                    If ZonasId.Rows.Count > 0
                        For Each Zona As DataRow In ZonasId.Rows
                            Dim SubZonas As DataTable = SZObtenerIdTable(Zona.Item("zonaid").ToString)
                            If SubZonas IsNot Nothing
                                If SubZonas.Rows.Count > 0
                                    For Each SubZona As DataRow In SubZonas.Rows
                                        cbxSubz.Items.Add(SubZona.Item("subZonaNombre"))
                                    Next

                                End If

                            End If
                        Next

                    End If
                End If
            Else
                MsgBox("Ocurrio un error. 1")
                btnAparcar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error. 0")
            btnAparcar.Enabled = False
            Serilog.Log.Error(ex, "err..")
        End Try

        Try
            cbxSubz.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos.")
            Serilog.Log.Error(ex, "err..")
        End Try
    End Sub

    Private Sub BtnAparcar_Click(sender As Object, e As EventArgs) Handles btnAparcar.Click
        Try
            If cbxSubz.SelectedIndex >= 0
                Dim VSubZ As DataRow = VSZObtener(VIN)
                Dim Zona = SZObtenerNombre(cbxSubz.Text)
                Dim Columna = NUDColumna.value.ToString
                Dim Fila = NUDFila.value.ToString

                Dim OpPatios = ObtenerOpPatios
                Dim OpId As String = "3"
                If OpPatios IsNot Nothing
                    OpId = OpPatios.Rows(0).Item("empleadoID").ToString
                End If
                If VSubZ Is Nothing
                    If Zona IsNot Nothing
                        If Zona.Rows.Count > 0
                            Dim ZonaId As String = Zona.Rows(0).Item("zonaid").ToString
                            If VSZInsertar(VIN, cbxSubz.Text, ZonaId, Columna, Fila, OpId)
                                MessageBox.Show("Vehiculo aparcado correctamente.")
                            Else 
                                MessageBox.Show("Error al aparcar.")
                            End If
                        End If
                    End If
                Else
                    If Zona IsNot Nothing
                        If Zona.Rows.Count > 0
                            Dim ZonaId As String = Zona.Rows(0).Item("zonaid").ToString
                            If VSZUpdate(VIN, cbxSubz.Text, ZonaId, Columna, Fila, OpId)
                                MessageBox.Show("Aparcamiento Modificado.")
                            Else 
                                MessageBox.Show("Error al aparcar.")
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al aparcar.")
            Serilog.Log.Error(ex, "err")
        End Try
    End Sub

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("AparcarVehiculo", 0)
        Label1.Text = _Lang.ObtenerKey("AparcarVehiculo", 1)
        lblpatio.Text = _Lang.ObtenerKey("AparcarVehiculo", 2)
        Label3.Text = _Lang.ObtenerKey("AparcarVehiculo", 3)
        Label4.Text = _Lang.ObtenerKey("AparcarVehiculo", 4)
        Label5.Text = _Lang.ObtenerKey("AparcarVehiculo", 5)
        btnAparcar.Text = _Lang.ObtenerKey("AparcarVehiculo", 6)
    End Sub
End Class
