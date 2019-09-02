Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        If Not mainContent.Contains(MenuControl.Instance) Then
            MenuControl.Instance.FormParent = Me
            mainContent.Controls.Add(MenuControl.Instance)
            MenuControl.Instance.Dock = DockStyle.Fill
            MenuControl.Instance.BringToFront()
        Else
            MenuControl.Instance.BringToFront()
        End If
    End Sub
End Class