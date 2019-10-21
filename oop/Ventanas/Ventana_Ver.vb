Imports DB
Imports Menu

Public Class Ventana_Ver

    Friend CameraActiva As Boolean = False
    Private InicCamera As IniciarCamara = Nothing

    Friend Sub LoadControl(Ctrl As Control)
        Ctrl.AutoSize = True
        Me.ClientSize = Ctrl.Size
        mainContent.Controls.Add(Ctrl)
        Ctrl.BringToFront()
    End Sub

    Friend Sub LoadControl(VerInsp As VerInspeccion, VIN As String)
        Me.ClientSize = VerInsp.Size
        VerInsp.Populate(VIN)
        mainContent.Controls.Add(VerInsp)
        VerInsp.AutoSize = True
        VerInsp.BringToFront
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


End Class