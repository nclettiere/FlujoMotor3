Public Class Ventanita_Ver
    Private Sub Ventanita_Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = true
        Me.AutoSizeMode = AutoSizeMode.GrowOnly


        If Not mainContent.Contains(Menu_Wapo.Instance) Then
            mainContent.Controls.Add(Menu_Wapo.Instance)
            Menu_Wapo.Instance.Dock = DockStyle.Fill
            Menu_Wapo.Instance.BringToFront()
        Else
            Menu_Wapo.Instance.BringToFront()
        End If
    End Sub
End Class