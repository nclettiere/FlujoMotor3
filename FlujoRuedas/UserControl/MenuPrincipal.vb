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

        UpdateLang

        Dim infoL = New InfoLotes
        infoL.Dock = DockStyle.Fill
        pnCOntenedor.Controls.Add(New InfoLotes)

        GoToSection(1)
        piBoPatio.Size = New Size(56, 70)
    End Sub

    Private Sub BtPuerto_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BtViajes_Click(sender As Object, e As EventArgs) Handles btViajes.Click
        
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("Deseas salir de la aplicacion?", "Salir", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ParentForm.Close
        End If
    End Sub

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("Main", 0)
        btViajes.Text = _Lang.ObtenerKey("Main", 1)
        Button2.Text = _Lang.ObtenerKey("Main", 2)
    End Sub

End Class