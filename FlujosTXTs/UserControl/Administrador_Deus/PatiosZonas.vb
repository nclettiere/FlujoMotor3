Imports Logica
Public Class PatiosZonas
    Private Sub OnPatiosZonasLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarPatios
    End Sub

    Private Function CrearPatioInfo(PatioId As String, PatioNombre As String, Direccion As String, PatioCantidad As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(278, 161)
        PanelContenido.BackColor = Color.Silver
        PanelContenido.Dock = DockStyle.Top

        Dim LabelId As Label = New Label
        Dim LabelNombre As Label = New Label
        Dim LabelCantidad As Label = New Label
        Dim LabelDireccion As Label = New Label
        Dim BtnElim As Button = New Button
        Dim BtnVer As Button = New Button

        LabelId.AutoSize = True
        LabelNombre.AutoSize = True
        LabelDireccion.AutoSize = True
        LabelCantidad.AutoSize = True

        LabelId.Text = "Patio ID: "+ PatioId
        LabelNombre.Text = "Patio Nombre: "+ PatioNombre
        LabelCantidad.Text = "Cant. Lotes Usando Patio: "+ PatioCantidad
        LabelDireccion.Text = "Direccion: "+ Direccion

        LabelId.Location = New Point(14, 16)
        LabelNombre.Location = New Point(14, 41)
        LabelDireccion.Location = New Point(14, 65)
        LabelCantidad.Location = New Point(14, 85)

        LabelId.ForeColor = Color.Crimson
        LabelNombre.ForeColor = Color.Crimson
        LabelDireccion.ForeColor = Color.Crimson
        LabelCantidad.ForeColor = Color.Crimson

        Dim fuente = New Font("Arial", 10)

        LabelId.Font = fuente
        LabelNombre.Font = fuente
        LabelDireccion.Font = fuente
        LabelCantidad.Font = fuente

        BtnElim.Size = New Size(99, 26)
        BtnElim.Font = fuente
        BtnElim.ForeColor = Color.Crimson
        BtnElim.FlatStyle = FlatStyle.Flat
        BtnElim.Text = "Eliminar"
        BtnElim.Location = New Point(16, 120)

        BtnVer.Size = New Size(99, 26)
        BtnVer.Font = fuente
        BtnVer.ForeColor = Color.Crimson
        BtnVer.FlatStyle = FlatStyle.Flat
        BtnVer.Text = "Ver Mas"
        BtnVer.Location = New Point(165, 120)

        AddHandler BtnElim.Click , Sub(s, ea) EliminarClick(s, ea, PatioId)
        AddHandler BtnVer.Click , Sub(s, ea) VerClick(s, ea, PatioId, Direccion)

        PanelContenido.Controls.Add(LabelId)
        PanelContenido.Controls.Add(LabelNombre)
        PanelContenido.Controls.Add(LabelCantidad)
        PanelContenido.Controls.Add(LabelDireccion)
        PanelContenido.Controls.Add(BtnElim)
        PanelContenido.Controls.Add(BtnVer)

        Return PanelContenido
    End Function

    Private Sub EliminarClick(s As Object, ea As EventArgs, PatioId As String)
        Dim result As Integer = MessageBox.Show("Deseas eliminar este patio?", "Eliminar Patio", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            PEliminar(PatioId)
        End If
    End Sub

    Private Sub VerClick(s As Object, ea As EventArgs, PatioId As String, Direccion As String)
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim VerPt As VerPatio = New VerPatio
        VerPt.PatioId = PatioId
        Dim dir As String = Direccion.Replace(" ", "+")
        VerPt.Direccion = dir
        Ventana.LoadControl(VerPt)
        Ventana.ShowDialog
    End Sub

    Private Sub BtnAgPatio_Click(sender As Object, e As EventArgs) Handles btnAgPatio.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgregarPt As AgregarPatio = New AgregarPatio
        AgregarPt.PZ_PatioAZonas = Me
        Ventana.LoadControl(AgregarPt)
        Ventana.ShowDialog
    End Sub

    Friend Sub ActualizarPatios
        Try
            flpPatios.Controls.Clear
            Dim ListaPatios = PObtenerAll
            If ListaPatios IsNot Nothing
                If ListaPatios.Rows.Count > 0
                    For Each Item As DataRow In ListaPatios.Rows
                        Dim Consultora As DataTable = Consultar("SELECT COUNT(*) FROM lotes WHERE patioid="+Item.Item("patioid").ToString)
                        If Consultora IsNot Nothing
                            If Consultora.Rows.Count > 0
                                flpPatios.Controls.Add(CrearPatioInfo(Item.Item("patioid").ToString, Item.Item("pationombre"), Item.Item("ubicacion").ToString, Consultora.Rows(0).Item(0).ToString))
                            Else
                                flpPatios.Controls.Add(CrearPatioInfo(Item.Item("patioid").ToString, Item.Item("pationombre"), Item.Item("ubicacion").ToString,"0"))
                            End If
                        Else
                            flpPatios.Controls.Add(CrearPatioInfo(Item.Item("patioid").ToString, Item.Item("pationombre"), Item.Item("ubicacion").ToString, "0"))
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "err")
        End Try
    End Sub
End Class
