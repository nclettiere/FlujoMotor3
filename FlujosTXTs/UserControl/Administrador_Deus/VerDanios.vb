Imports System.IO
Imports Logica

Public Class VerDanios

    Friend Sub CrearDanios(InspeccionId As String)
        Dim Numero As Integer = 1
        For Each insp As DataRow In IDObtener(InspeccionId).Rows
            Dim DanioDatos As DataRow = Consultar("SELECT * FROM danios WHERE danioId=" + insp.Item("danioid").ToString).Rows(0)

            Dim panel As Control = DrawDanio(
                                    Numero.ToString,
                                    DObtenerFoto(DanioDatos.Item("danioid")),
                                    DanioDatos.Item("danioDescripcion"))

            FlowInspecciones.Controls.Add(panel)
            Numero += 1
        Next

    End Sub
    Private Function DrawDanio(Numero As String, Imagen As Bitmap, Desc As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(577, 130)
        PanelContenido.BackColor = Color.FromArgb(134, 134, 134)
        PanelContenido.Margin = New Padding(3, 3, 3, 10)

        Dim lblNumero As Label = New Label
        Dim lblDesc As Label = New Label
        Dim PBDanio As PictureBox = New PictureBox
        Dim rchDesc As RichTextBox = New RichTextBox

        lblNumero.AutoSize = True
        lblDesc.AutoSize = True
        PBDanio.Size = New Size(152, 127)
        rchDesc.Size = New Size(413, 81)


        lblNumero.Text = "Danio #" + Numero
        lblDesc.Text = "Descripcion"
        PBDanio.Image = Imagen
        rchDesc.Text = Desc

        lblNumero.Location = New Point(3, 12)
        lblDesc.Location = New Point(161, 12)
        PBDanio.Location = New Point(3, 38)
        rchDesc.Location = New Point(161, 38)

        lblNumero.ForeColor = Color.Orange


        Dim fuente = New Font("Arial", 10)

        lblNumero.Font = fuente
        lblDesc.Font = fuente

        PanelContenido.Controls.Add(lblNumero)
        PanelContenido.Controls.Add(PBDanio)
        PanelContenido.Controls.Add(rchDesc)
        PanelContenido.Controls.Add(lblDesc)

        Return PanelContenido
    End Function
End Class
