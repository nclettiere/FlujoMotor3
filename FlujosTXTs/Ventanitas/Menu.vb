Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly
        Dim a = New Main_Deus
        mainContent.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.BringToFront()
    End Sub
End Class