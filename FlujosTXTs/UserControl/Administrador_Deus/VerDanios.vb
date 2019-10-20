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
        PanelContenido.Size = New Size(690, 225)
        PanelContenido.BackColor = Color.FromArgb(134, 134, 134)
        PanelContenido.Margin = New Padding(3, 3, 3, 10)

        Dim lblNumero As Label = New Label
        Dim lblDesc As Label = New Label
        Dim PBDanio As PictureBox = New PictureBox
        Dim rchDesc As RichTextBox = New RichTextBox
        Dim btnverimg As Button = New Button

        lblNumero.AutoSize = True
        lblDesc.AutoSize = True
        PBDanio.Size = New Size(271, 219)
        rchDesc.Size = New Size(407, 120)
        btnverimg.Size = New Size(166, 35)


        lblNumero.Text = "Danio #" + Numero
        lblDesc.Text = "Descripcion"
        PBDanio.BackgroundImage = Imagen
        PBDanio.BackgroundImageLayout = ImageLayout.Stretch
        rchDesc.Text = Desc
        btnverimg.Text = "Agrandar Imagen"

        lblNumero.Location = New Point(3, 12)
        lblDesc.Location = New Point(161, 12)
        PBDanio.Location = New Point(3, 3)
        rchDesc.Location = New Point(280, 3)
        btnverimg.Location = New Point(281, 130)
        
        lblNumero.ForeColor = Color.Crimson

        Dim fuente = New Font("Arial", 10)

        lblNumero.Font = fuente
        lblDesc.Font = fuente
        btnverimg.Font = fuente
        btnverimg.ForeColor = Color.Crimson
        btnverimg.FlatStyle = FlatStyle.Flat

        rchDesc.ReadOnly = True
        rchDesc.Enabled = False

        AddHandler btnverimg.Click , Sub(s, ea) VerImg(s, ea, Imagen)

        PanelContenido.Controls.Add(lblNumero)
        PanelContenido.Controls.Add(PBDanio)
        PanelContenido.Controls.Add(rchDesc)
        PanelContenido.Controls.Add(lblDesc)
        PanelContenido.Controls.Add(btnverimg)

        Return PanelContenido
    End Function

    Private Sub VerImg(s As Object, ea As EventArgs, image As Bitmap)
        Dim VentanaVer As Ventana_Ver = New Ventana_Ver
        Dim VerF As VerFoto = New VerFoto
        VerF.PbFoto.BackgroundImage = image
        VentanaVer.LoadControl(VerF)
        VentanaVer.ShowDialog()
    End Sub
End Class
