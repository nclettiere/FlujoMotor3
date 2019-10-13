Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly
        Dim a = New Login_Deus
        mainContent.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.BringToFront()
    End Sub

    Friend Sub CargarMenuPrincipal()
        Dim Menu = New Main_Deus

        If Not mainContent.Contains(Menu) Then
            Me.ClientSize = Menu.Size
            MainContent.Controls.Add(Menu)
            Menu.Dock = DockStyle.Fill
            Menu.BringToFront()
        Else
            Menu.BringToFront()
        End If
    End Sub
End Class