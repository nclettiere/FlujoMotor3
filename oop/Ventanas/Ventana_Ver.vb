Imports DB

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

    Friend Sub LoadControl(vin As String, Conexion As ODBC)
        Dim Selection = New VerPosicion
        Selection.CargarDatos(VIN, Conexion)
        Me.ClientSize = Selection.Size
        mainContent.Controls.Add(Selection)
        Selection.Dock = DockStyle.Fill
        Selection.BringToFront()
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

    Friend Sub GoToSection(ByVal Section As Integer, ByVal VIN As String, ByRef Conexion As DB.ODBC)
        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = VerInspeccion.Instance
                VerInspeccion.Instance.FormParent = Me
                VerInspeccion.Instance.Populate(VIN, Conexion)
                VerInspeccion.Instance.AutoSize = True
                Me.ClientSize = VerInspeccion.Instance.Size
            Case 1
                Selection = AgregarInspeccion.Instance
                AgregarInspeccion.Instance.FormParent = Me
                AgregarInspeccion.Instance.CargarDatos(VIN, Conexion)
                AgregarInspeccion.Instance.AutoSize = True
                Me.ClientSize = AgregarInspeccion.Instance.Size
            Case 2
                Selection = New VerPosicion
                DirectCast(Selection, VerPosicion).CargarDatos(VIN, Conexion)
                Me.ClientSize = DirectCast(Selection, VerPosicion).Size
            Case 3
                Dim AgrVehiculo = New AgregarVehiculo
                AgrVehiculo.EstaModificando = True
                AgrVehiculo.VinAModificar = VIN
                AgrVehiculo.Conexion = Conexion
                Me.ClientSize = AgrVehiculo.Size
                Selection = AgrVehiculo
            Case 4
                Dim VerPatiosControl = New VerPatios
                VerPatiosControl.Conexion = Conexion
                Me.ClientSize = VerPatiosControl.Size
                Selection = VerPatiosControl
            Case 5
                Dim VerZonasControl = New VerZonas
                VerZonasControl.Conexion = Conexion
                '' USA VIN COMO PATIOID <======
                VerZonasControl.PatioId = VIN'=
                '' ============================
                Me.ClientSize = VerZonasControl.Size
                Selection = VerZonasControl
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