Imports DB

Public Class VerPatios

    Public Property Conexion As ODBC

    Private Sub VerPatios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim PatioDatos = Conexion.Consultar("SELECT * FROM patios")
            If PatioDatos IsNot Nothing
                If PatioDatos.Rows.Count > 0
                    For Each PatioRow As DataRow In PatioDatos.Rows
                        Dim PatioId As String = PatioRow.Item("patioid").ToString
                        Dim PatioNombre As String = PatioRow.Item("pationombre").ToString
                        Dim PatioCantidad = 0
                        Try
                            Dim Cantidad = Conexion.Consultar("SELECT COUNT(*) FROM lotes WHERE patioid="+ PatioId)
                            If Cantidad IsNot Nothing
                                If Cantidad.Rows.Count > 0
                                    Integer.TryParse(Cantidad.Rows(0).Item(0), PatioCantidad)
                                End If
                            End If
                        Catch ex As Exception
                            Serilog.Log.Warning(ex, "Posible valor nulo.")
                        End Try
                        FPContenido.Controls.Add(CrearPatioInfo(PatioId, PatioNombre, PatioCantidad.ToString))
                    Next
                End If
            End If
            ParentForm.ClientSize = Me.Size
        Catch ex As Exception
            Serilog.Log.Error("Error al cargar patios, Hay patios en la db?")
        End Try
    End Sub

    Private Function CrearPatioInfo(PatioId As String, PatioNombre As String, PatioCantidad As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(571, 88)
        PanelContenido.BackColor = Color.Gray
        PanelContenido.Dock = DockStyle.Top

        Dim LabelId As Label = New Label
        Dim LabelNombre As Label = New Label
        Dim LabelCantidad As Label = New Label

        LabelId.AutoSize = True
        LabelNombre.AutoSize = True
        LabelCantidad.AutoSize = True

        LabelId.Text = "Patio ID: "+ PatioId
        LabelNombre.Text = "Patio Nombre: "+ PatioNombre
        LabelCantidad.Text = "Cant. Lotes Usando Patio: "+ PatioCantidad

        LabelId.Location = New Point(14, 16)
        LabelNombre.Location = New Point(14, 41)
        LabelCantidad.Location = New Point(14, 65)

        LabelId.ForeColor = Color.Orange
        LabelNombre.ForeColor = Color.Orange
        LabelCantidad.ForeColor = Color.Orange

        Dim fuente = New Font("Arial", 10)

        LabelId.Font = fuente
        LabelNombre.Font = fuente
        LabelCantidad.Font = fuente

        Dim BtnZona As Button = New Button
        BtnZona.Size = New Size(145, 75)
        BtnZona.Font = fuente
        BtnZona.ForeColor = Color.Orange
        BtnZona.Text = "Ver/Agregar Zonas"

        AddHandler BtnZona.Click , Sub(s, ea) ZonasClick(s, ea, PatioId)

        BtnZona.Location = New Point(300, 0)

        PanelContenido.Controls.Add(LabelId)
        PanelContenido.Controls.Add(LabelNombre)
        PanelContenido.Controls.Add(LabelCantidad)
        PanelContenido.Controls.Add(BtnZona)

        Return PanelContenido
    End Function

    Private Sub ZonasClick(s As Object, ea As EventArgs, PatioId As String)
        DirectCast(ParentForm, Ventana_Ver).GoToSection(5, PatioId)
    End Sub
End Class
