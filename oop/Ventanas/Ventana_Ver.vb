Imports DB
Imports Menu

Public Class Ventana_Ver

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

    Friend Sub LoadControl(vin As String)
        Dim Selection = New VerPosicion
        Selection.CargarDatos(VIN)
        Me.ClientSize = Selection.Size
        mainContent.Controls.Add(Selection)
        Selection.Dock = DockStyle.Fill
        Selection.BringToFront()
    End Sub

    Friend Sub LoadControl(modSubZona As ModificarSubzona)
        Me.ClientSize = modSubZona.Size
        mainContent.Controls.Add(modSubZona)
        modSubZona.AutoSize = True
    End Sub

    Friend Sub LoadControl(agregarInsp As AgregarInspeccion)
        Me.ClientSize = agregarInsp.Size
        mainContent.Controls.Add(agregarInsp)
        agregarInsp.AutoSize = True
    End Sub

    Friend Sub LoadControl(selecVehiculo As SelecVehiculo)
         Me.ClientSize = selecVehiculo.Size
        mainContent.Controls.Add(selecVehiculo)
        selecVehiculo.AutoSize = True
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
            Case 2
                Selection = VerPosicion.Instance
                Me.ClientSize = VerPosicion.Instance.Size
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
                Selection = VerInspeccion.Instance
                VerInspeccion.Instance.FormParent = Me
                VerInspeccion.Instance.Populate(VIN)
                VerInspeccion.Instance.AutoSize = True
                Me.ClientSize = VerInspeccion.Instance.Size
            Case 1
                Selection = AgregarInspeccion.Instance
                AgregarInspeccion.Instance.FormParent = Me
                AgregarInspeccion.Instance.CargarDatos(VIN)
                AgregarInspeccion.Instance.AutoSize = True
                Me.ClientSize = AgregarInspeccion.Instance.Size
            Case 2
                Selection = New VerPosicion
                DirectCast(Selection, VerPosicion).CargarDatos(VIN)
                Me.ClientSize = DirectCast(Selection, VerPosicion).Size
            Case 3
                Dim AgrVehiculo = New AgregarVehiculo
                AgrVehiculo.EstaModificando = True
                AgrVehiculo.VinAModificar = VIN
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
End Class