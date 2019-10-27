Imports Logica

Public Class AparcarVehiculo

    Friend VIN As String
    Friend PatioId As String

    Private Sub AparcarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupControl
    End Sub

    Private Sub SetupControl
        Try
            Dim PatioInfo As DataRow = PObtenerID(PatioId)
            If PatioInfo IsNot Nothing
                lblpatio.Text = "Patio designado: " + PatioInfo.Item("patioNombre")
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
End Class
