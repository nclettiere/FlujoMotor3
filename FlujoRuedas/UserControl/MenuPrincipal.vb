Imports Logica

Public Class MenuPrincipal
    Private Shared _instance As MenuPrincipal
    Friend Property MainWindowForm As MainWindow

    Public Shared Property Instance As MenuPrincipal
        Get
            If _instance Is Nothing Then
                _instance = New MenuPrincipal()
            End If
            Return _instance
        End Get
        Set(value As MenuPrincipal)
            _instance = value
        End Set
    End Property

    Private Sub OnMPLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        pnCOntenedor.Controls.Add(New InfoLotes)
        btViajes.Font = New Font(btViajes.Font.FontFamily, 14)
        piBoPatio.Size = New Size(56, 30)
        btViajes.BackColor = Color.Transparent
        btLotes.BackColor = Color.DarkGray
        btLotes.Font = New Font(btLotes.Font.FontFamily, 17)
        piBoPuerto.Size = New Size(56, 70)
    End Sub

    Private Sub BtPuerto_Click(sender As Object, e As EventArgs) Handles btLotes.Click
        GoToSection(0)
        btViajes.Font = New Font(btViajes.Font.FontFamily, 14)
        piBoPatio.Size = New Size(56, 30)
        btViajes.BackColor = Color.Transparent
        btLotes.BackColor = Color.DarkGray
        btLotes.Font = New Font(btLotes.Font.FontFamily, 17)
        piBoPuerto.Size = New Size(56, 70)
    End Sub

    Private Sub BtViajes_Click(sender As Object, e As EventArgs) Handles btViajes.Click
        GoToSection(1)
        btLotes.Font = New Font(btViajes.Font.FontFamily, 14)
        piBoPuerto.Size = New Size(56, 30)
        btLotes.BackColor = Color.Transparent
        btViajes.BackColor = Color.DarkGray
        btViajes.Font = New Font(btLotes.Font.FontFamily, 17)
        piBoPatio.Size = New Size(56, 70)
    End Sub

    Friend Sub GoToSection(ByVal Section As Integer)
        '' Section => {0=>"VerVehiculos";1=>AgregarVehiculos};
        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = New InfoLotes
            Case 1
                Selection = VerViajes.Instance
            Case Else
                Selection = New InfoLotes
        End Select

        If Not pnCOntenedor.Contains(Selection) Then
            pnCOntenedor.Controls.Add(Selection)
            Selection.Dock = DockStyle.Fill
            Selection.BringToFront()
        Else
            Selection.BringToFront()
        End If
    End Sub
End Class
