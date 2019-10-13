Imports Logica

Public Class Main_Deus

    Private Sub OnMenuLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function CrearUsuariosInfo(Informacion As DataRow, Nombre As String) As Control
        Dim PanelContenido As Panel = New Panel
        PanelContenido.Size = New Size(321, 134)
        PanelContenido.BackColor = Color.Silver
        PanelContenido.Dock = DockStyle.Top

        Dim LabelUsuario As Label = New Label
        Dim LabelNombre As Label = New Label
        Dim LabelUltimaCon As Label = New Label

        LabelUsuario.AutoSize = True
        LabelNombre.AutoSize = True
        LabelUltimaCon.AutoSize = True

        LabelUsuario.Text = "Usuario: "+ Informacion("usuario")
        LabelNombre.Text = "Nombre: "+ Nombre
        LabelUltimaCon.Text = "Ultima Conexion: "+ Informacion("ultimaconexion").ToString

        LabelUsuario.Location = New Point(11, 12)
        LabelNombre.Location = New Point(11, 36)
        LabelUltimaCon.Location = New Point(11, 63)

        LabelUsuario.ForeColor = Color.Crimson
        LabelNombre.ForeColor = Color.Crimson
        LabelUltimaCon.ForeColor = Color.Crimson

        Dim fuente = New Font("Arial", 10)

        LabelUsuario.Font = fuente
        LabelNombre.Font = fuente
        LabelUltimaCon.Font = fuente

        Dim BtnCerrarSesion As Button = New Button
        BtnCerrarSesion.Size = New Size(145, 75)
        BtnCerrarSesion.Font = fuente
        BtnCerrarSesion.ForeColor = Color.Crimson
        BtnCerrarSesion.Text = "Cerrar Sesion"
        BtnCerrarSesion.Location = New Point(113, 23)

        Dim BtnVerMas As Button = New Button
        BtnVerMas.Size = New Size(112, 23)
        BtnVerMas.Font = fuente
        BtnVerMas.ForeColor = Color.Crimson
        BtnVerMas.Text = "Ver Mas"
        BtnVerMas.Location = New Point(196, 99)

        ''AddHandler BtnZona.Click , Sub(s, ea) ZonasClick(s, ea, PatioId)

        PanelContenido.Controls.Add(LabelUsuario)
        PanelContenido.Controls.Add(LabelNombre)
        PanelContenido.Controls.Add(LabelUltimaCon)
        PanelContenido.Controls.Add(BtnCerrarSesion)
        PanelContenido.Controls.Add(BtnVerMas)

        Return PanelContenido
    End Function

    Private Sub BtnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Dim Ventana As Ventana_Ver = New Ventana_Ver
        Dim AgregarUsuario = New AgregarUsuario
        Ventana.LoadControl(AgregarUsuario)
        Ventana.ShowDialog
    End Sub
End Class
