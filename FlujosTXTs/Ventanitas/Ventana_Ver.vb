Imports FlujosTXTs

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

    Friend Sub LoadControl(inicCamera As IniciarCamara)
        Me.ClientSize = inicCamera.Size
        mainContent.Controls.Add(inicCamera)
        inicCamera.Dock = DockStyle.Fill
        inicCamera.BringToFront()
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

    Friend Sub LoadControl(danios As VerDanios)
        Me.ClientSize = danios.Size
        mainContent.Controls.Add(danios)
        danios.Dock = DockStyle.Fill
        danios.BringToFront()
    End Sub

    Friend Sub LoadControl(agrDanio As AgregarDanio)
        Me.ClientSize = agrDanio.Size
        mainContent.Controls.Add(agrDanio)
        agrDanio.Dock = DockStyle.Fill
        agrDanio.BringToFront()
    End Sub

    Friend Sub LoadControl(verIns As VerInspeccion)
        Me.ClientSize = verIns.Size
        mainContent.Controls.Add(verIns)
        verIns.Dock = DockStyle.Fill
        verIns.BringToFront()
    End Sub

    Friend Sub LoadControl(modSubZona As ModificarSubzona)
        Me.ClientSize = modSubZona.Size
        mainContent.Controls.Add(modSubZona)
        modSubZona.Dock = DockStyle.Fill
        modSubZona.BringToFront()
    End Sub

    Friend Sub LoadControl(agregarPt As AgregarPatio)
        Me.ClientSize = agregarPt.Size
        mainContent.Controls.Add(agregarPt)
        agregarPt.Dock = DockStyle.Fill
        agregarPt.BringToFront()
    End Sub
End Class