Public Class Ventana_Ver
        Friend Sub LoadControl(AgregarUsr As AgregarUsuario)
        Me.ClientSize = AgregarUsr.Size
        mainContent.Controls.Add(AgregarUsr)
        AgregarUsr.Dock = DockStyle.Fill
        AgregarUsr.BringToFront()
    End Sub
End Class