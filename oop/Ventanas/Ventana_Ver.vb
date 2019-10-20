Imports DB
Imports Menu

Public Class Ventana_Ver

    Friend CameraActiva As Boolean = False
    Private InicCamera As IniciarCamara = Nothing

    Friend Sub LoadControl(verVehiculo As VerVehiculo)
        verVehiculo.AutoSize = True
        Me.ClientSize = verVehiculo.Size
        mainContent.Controls.Add(verVehiculo)
    End Sub

    Friend Sub LoadControl(verLote As VerLotes)
        Me.ClientSize = verLote.Size
        mainContent.Controls.Add(verLote)
        verLote.AutoSize = True
    End Sub

    Friend Sub LoadControl(verFoto As VerFoto)
        Me.ClientSize = verFoto.Size
        mainContent.Controls.Add(verFoto)
    End Sub

   Friend Sub LoadControl(SelecVehiculo As SeleccionarVehiculo)
        Me.ClientSize = SelecVehiculo.Size
        mainContent.Controls.Add(SelecVehiculo)
        SelecVehiculo.AutoSize = True
    End Sub

    Friend Sub LoadControl(modSubZona As ModificarSubzona)
        Me.ClientSize = modSubZona.Size
        mainContent.Controls.Add(modSubZona)
        modSubZona.AutoSize = True
    End Sub

    Friend Sub LoadControl(selecVehiculo As SelecVehiculo)
         Me.ClientSize = selecVehiculo.Size
        mainContent.Controls.Add(selecVehiculo)
        selecVehiculo.AutoSize = True
    End Sub

    Friend Sub LoadControl(verLvd As VerLavados)
        Me.ClientSize = verLvd.Size
        mainContent.Controls.Add(verLvd)
        verLvd.AutoSize = True
    End Sub
    Friend Sub LoadControl(inicCamera As IniciarCamara)
        Me.ClientSize = inicCamera.Size
        mainContent.Controls.Add(inicCamera)
        Me.InicCamera = inicCamera
        inicCamera.AutoSize = True
    End Sub
    Friend Sub LoadControl(AgLote As AgregarLote)
        Me.ClientSize = AgLote.Size
        mainContent.Controls.Add(AgLote)
        AgLote.AutoSize = True
        AgLote.BringToFront
    End Sub

    Friend Sub LoadControl(VerInsp As VerInspeccion, VIN As String)
        Me.ClientSize = VerInsp.Size
        VerInsp.Populate(VIN)
        mainContent.Controls.Add(VerInsp)
        VerInsp.AutoSize = True
        VerInsp.BringToFront
    End Sub

    Friend Sub LoadControl(AgrDanio As AgregarDanio)
        Me.ClientSize = AgrDanio.Size
        mainContent.Controls.Add(AgrDanio)
        AgrDanio.AutoSize = True
        AgrDanio.BringToFront
    End Sub

    Friend Sub LoadControl(selecTransp As SeleccionarTransportista)
        Me.ClientSize = selecTransp.Size
        mainContent.Controls.Add(selecTransp)
        selecTransp.AutoSize = True
        selecTransp.BringToFront
    End Sub

    Friend Sub LoadControl(VerD As VerDanios)
        Me.ClientSize = VerD.Size
        mainContent.Controls.Add(VerD)
        VerD.AutoSize = True
        VerD.BringToFront()
    End Sub

    Friend Sub LoadControl(agv As AgregarVehiculo)
        Me.ClientSize = agv.Size
        mainContent.Controls.Add(agv)
        agv.AutoSize = True
        agv.BringToFront()
    End Sub

    ''' <summary>
    ''' Metodo usado para cambiar dinamicamente el contenido del MainContent
    ''' </summary>
    ''' <param name="Section">Integer que especifica el ID de la seccion.</param>
    Friend Sub GoToSection(ByVal Section As Integer)
        '' Section => {0=>"VerVehiculos";1=>AgregarVehiculos};

        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = VerInspeccion.Instance
                Me.ClientSize = VerInspeccion.Instance.Size
            Case 1
                Selection = VerVehiculo.Instance
                Me.ClientSize = VerVehiculo.Instance.Size
            Case Else
                Selection = VerInspeccion.Instance
                Me.ClientSize = VerInspeccion.Instance.Size
        End Select

        If Not mainContent.Contains(Selection) Then
            mainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

    Friend Sub GoToSection(ByVal Section As Integer, ByVal VIN As String)
        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = New VerInspeccion
                Selection.FormParent = Me
                Selection.Populate(VIN)
                Selection.AutoSize = True
                Me.ClientSize = Selection.Size
            Case 3
                Dim AgrVehiculo = New AgregarVehiculo
                AgrVehiculo.VINmodificacion = VIN
                Me.ClientSize = AgrVehiculo.Size
                Selection = AgrVehiculo
            Case 4
                Dim VerPatiosControl = New VerPatios
                Me.ClientSize = VerPatiosControl.Size
                Selection = VerPatiosControl
            Case 5
                Dim VerZonasControl = New VerZonas
                '' USA VIN COMO PATIOID <======
                VerZonasControl.PatioId = VIN '=
                '' ============================
                Me.ClientSize = VerZonasControl.Size
                Selection = VerZonasControl
            Case 6
                Dim SelecVehiculo = New SeleccionarVehiculo
                Me.ClientSize = SelecVehiculo.Size
                Selection = SelecVehiculo
            Case Else
                Selection = VerInspeccion.Instance
        End Select

        If Not mainContent.Contains(Selection) Then
            mainContent.Controls.Add(Selection)
            Selection.Dock = DockStyle.Fill
            Selection.BringToFront()
        Else
            Selection.BringToFront()
        End If
    End Sub

    Private Sub Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If CameraActiva
            InicCamera.Timer2.Stop
            InicCamera.StopWebcam
        End If
    End Sub

    Friend Sub LoadControl(selecLote As SeleccionarLote)
        Me.ClientSize = selecLote.Size
        mainContent.Controls.Add(selecLote)
        selecLote.AutoSize = True
        selecLote.BringToFront()
    End Sub
End Class