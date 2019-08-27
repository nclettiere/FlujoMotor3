Imports DB
Imports oop

Public Class Ventanita_Ver
    Private Sub Ventanita_Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub LoadControl(verVehiculo As Ver_Vehiculillo)
        verVehiculo.AutoSize = True
        Me.ClientSize = verVehiculo.Size
        mainContent.Controls.Add(verVehiculo)
    End Sub

    Friend Sub LoadControl(verLote As Ver_Lotesillo)
        Me.ClientSize = verLote.Size
        mainContent.Controls.Add(verLote)
        verLote.AutoSize = True
    End Sub

    Friend Sub LoadControl(verFoto As Ver_Foto)
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
                Selection = Ver_Inspeccionsilla.Instance
                Me.ClientSize = Ver_Inspeccionsilla.Instance.Size
            Case 1
                Selection = Ver_Vehiculillo.Instance
                Me.ClientSize = Ver_Vehiculillo.Instance.Size
            Case 2
                Selection = VerPosicion.Instance
                Me.ClientSize = VerPosicion.Instance.Size
            Case Else
                Selection = Ver_Inspeccionsilla.Instance
                Me.ClientSize = Ver_Inspeccionsilla.Instance.Size
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
                Selection = Ver_Inspeccionsilla.Instance
                Ver_Inspeccionsilla.Instance.FormParent = Me
                Ver_Inspeccionsilla.Instance.Populate(VIN, Conexion)
                Ver_Inspeccionsilla.Instance.AutoSize = True
                Me.ClientSize = Ver_Inspeccionsilla.Instance.Size
            Case 1
                Selection = Agregar_Inspeccion.Instance
                Agregar_Inspeccion.Instance.FormParent = Me
                Agregar_Inspeccion.Instance.CargarDatos(VIN, Conexion)
                Agregar_Inspeccion.Instance.AutoSize = True
                Me.ClientSize = Agregar_Inspeccion.Instance.Size
            Case 2
                Selection = New VerPosicion
                DirectCast(Selection, VerPosicion).CargarDatos(VIN, Conexion)
                Me.ClientSize = DirectCast(Selection, VerPosicion).Size
            Case Else
                Selection = Ver_Inspeccionsilla.Instance
        End Select

        If Not mainContent.Contains(Selection) Then
            mainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub
End Class