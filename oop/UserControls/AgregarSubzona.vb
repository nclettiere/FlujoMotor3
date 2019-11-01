Imports FlujosTXTs
Imports Logica
Public Class AgregarSubzona

    Friend PatioId As String
    Friend VP_ListarPatio As ListarPatio
    
    ' Para modificar sz
    Friend Modo As Integer = 0
    Friend SZNombre As String

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If CheckearCampos
            If Modo = 0
                If SZInsertar(cbxZonas.Text, tbxNombre.Text, NUDCapacidad.Value.ToString)
                    MsgBox("Subzona agregada correctamente.")
                    VP_ListarPatio.ActualizarSubZonas
                    ParentForm.Close
                End If
            Else
                If SZUpdate(SZNombre, NUDCapacidad.Value.ToString, tbxNombre.Text, cbxZonas.Text)
                    MsgBox("Subzona modificada correctamente.")
                    VP_ListarPatio.ActualizarSubZonas
                    ParentForm.Close
                End If
            End If
        End If
    End Sub

    Private Sub AgregarSubzona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Modo = 1
            lbltitulo.Text = "Modificar SubZona"
            btnAgregar.Text = "Modificar"
            tbxNombre.Enabled = False

            Try
                Dim SZDatos = SZObtenerNombre(SZNombre)
                If SZDatos IsNot Nothing
                    If SZDatos.Rows.Count > 0
                        tbxNombre.Text = SZDatos.Rows(0).Item("subzonanombre")
                        NUDCapacidad.Value = SZDatos.Rows(0).Item("subZonaCapacidad")
                        cbxZonas.SelectedText = SZDatos.Rows(0).Item("zonaID").ToString
                    End If
                End If
            Catch ex As Exception

            End Try

        End If

        Try
            Dim ZonasId As DataTable = ZObtener(PatioId)
            If ZonasId IsNot Nothing
                If ZonasId.Rows.Count > 0
                    For Each Zona As DataRow In ZonasId.Rows
                        cbxZonas.Items.Add(Zona.Item("zonaid"))
                    Next
                Else
                    cbxZonas.Enabled = False
                    btnAgregar.Enabled = False
                    MsgBox("El patio seleccionado no tiene zonas. Agregue una para continuar.")
                End If
            Else
                cbxZonas.Enabled = False
                btnAgregar.Enabled = False
                MsgBox("El patio seleccionado no tiene zonas. Agregue una para continuar.")
            End If
        Catch ex As Exception
            MsgBox("Error al obtener zonas. Chequee el log para mas informacion.")
            Serilog.Log.Error(ex, "err...")
        End Try
    End Sub

    Private Function CheckearCampos As Boolean
        If Not String.IsNullOrWhiteSpace(tbxNombre.Text)
            If NUDCapacidad.Value > 0
                If cbxZonas.SelectedIndex >= 0
                    If SubZObtenerCountNombre(SZNombre) = 0 And Modo = 0
                        Return True
                    ElseIf Modo = 1
                        Return True
                    Else
                        MsgBox("El nombre de la subzona ya existe.")
                        Return False
                    End If
                Else
                    MsgBox("Debes seleccionar una zona.")
                    Return False
                End If
            Else
                MsgBox("La capacidad de la subzona tiene que ser mayor a 0.")
                Return False
            End If
        Else
            MsgBox("Debes Ingresar un nombre para la subzona.")
            Return False
        End If
    End Function
End Class
