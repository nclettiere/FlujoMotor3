Public Class Ventana_Ver
    Friend Sub LoadControl(AgregarUsr As AgregarUsuario)
        Me.ClientSize = AgregarUsr.Size
        mainContent.Controls.Add(AgregarUsr)
        AgregarUsr.Dock = DockStyle.Fill
        AgregarUsr.BringToFront()
    End Sub

    Friend Sub LoadControl(AgregarV As AgregarVehiculo)
        Me.ClientSize = AgregarV.Size
        mainContent.Controls.Add(AgregarV)
        AgregarV.Dock = DockStyle.Fill
        AgregarV.BringToFront()
    End Sub

    Friend Sub LoadControl(AgregarLote As AgregarLote)
        Me.ClientSize = AgregarLote.Size
        mainContent.Controls.Add(AgregarLote)
        AgregarLote.Dock = DockStyle.Fill
        AgregarLote.BringToFront()
    End Sub

    Friend Sub LoadControl(SelecLote As SeleccionarLote)
        Me.ClientSize = SelecLote.Size
        mainContent.Controls.Add(SelecLote)
        SelecLote.Dock = DockStyle.Fill
        SelecLote.BringToFront()
    End Sub
End Class