Imports Logica
Public Class MenuControl
    Private Shared _instance As MenuControl
    Friend PuertoPatio As Boolean

    Public Shared Property Instance As MenuControl
        Get
            If _instance Is Nothing Then
                _instance = New MenuControl()
            End If
            Return _instance
        End Get
        Set(value As MenuControl)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Menu
    Public Property Conexion As DB.ODBC

    Private Sub OnControlLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = true
        Me.AutoSizeMode = AutoSizeMode.GrowOnly
       
        If Not PuertoPatio
            btPatio.Enabled = False
            btPuerto.Enabled = True
            GoToSection(0)
            btPatio.Font = New Font(btPatio.Font.FontFamily, 14)
            piBoPatio.Size = New Size(56, 30)
            btPatio.BackColor = Color.Transparent
            btPuerto.BackColor = Color.DarkGray
            btPuerto.Font = New Font(btPuerto.Font.FontFamily, 17)
            piBoPuerto.Size = New Size(56, 70)
        Else
            btPuerto.Enabled = False
            btPatio.Enabled = True
            GoToSection(2)
            btPuerto.Font = New Font(btPuerto.Font.FontFamily, 14)
            piBoPuerto.Size = New Size(56, 30)
            btPuerto.BackColor = Color.Transparent
            btPatio.BackColor = Color.DarkGray
            btPatio.Font = New Font(btPatio.Font.FontFamily, 17)
            piBoPatio.Size = New Size(56, 70)
        End If
    End Sub

    ''' <summary>
    ''' Metodo usado para cambiar dinamicamente el contenido del ContenidoPrincipal
    ''' </summary>
    ''' <param name="Section">Integer que especifica el ID de la seccion.</param>
    Friend Sub GoToSection(Section As Integer)
        '' Section => {0=>"VerVehiculos";1=>AgregarVehiculos};
        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = InfoAutos.Instance
                InfoAutos.Instance.FormParent = Me
                ''btnAgregarVehiculo.BackColor = Color.DimGray
                ''btnVerVehiculo.BackColor = Color.DarkGray
            Case 2
                Selection = VerPatio.Instance
                VerPatio.Instance.FormParent = Me
                VerPatio.Instance.Conexion = Conexion
                'btnVerVehicle.BackColor = Color.DimGray
                'btnAgregarVehicle.BackColor = Color.DarkGray
            Case Else
                Selection = InfoAutos.Instance
                InfoAutos.Instance.FormParent = Me
                'btnAgregarVehicle.BackColor = Color.DimGray
                'btnVerVehicle.BackColor = Color.DarkGray
        End Select

        If Not ContenidoPrincipal.Contains(Selection) Then
            ContenidoPrincipal.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

    Private Sub BtPuerto_Click(sender As Object, e As EventArgs) Handles btPuerto.Click
        GoToSection(0)
        btPatio.Font = New Font(btPatio.Font.FontFamily, 14)
        piBoPatio.Size = New Size(56, 30)
        btPatio.BackColor = Color.Transparent
        btPuerto.BackColor = Color.DarkGray
        btPuerto.Font = New Font(btPuerto.Font.FontFamily, 17)
        piBoPuerto.Size = New Size(56, 70)
    End Sub

    Private Sub BtPatio_Click(sender As Object, e As EventArgs) Handles btPatio.Click
        GoToSection(2)
        btPuerto.Font = New Font(btPuerto.Font.FontFamily, 14)
        piBoPuerto.Size = New Size(56, 30)
        btPuerto.BackColor = Color.Transparent
        btPatio.BackColor = Color.DarkGray
        btPatio.Font = New Font(btPatio.Font.FontFamily, 17)
        piBoPatio.Size = New Size(56, 70)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim result As Integer = MessageBox.Show("Deseas salir de la aplicacion?", "Salir", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ParentForm.Close
        End If
    End Sub

    Private Sub ScanQR_Click(sender As Object, e As EventArgs) Handles ScanQR.Click
        Dim VentanaQR = New EscanearQR
        VentanaQR.ShowDialog()
    End Sub
End Class