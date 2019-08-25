Imports DB

Public Class Menu

    Public Property Conexion As ODBC

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        If Not mainContent.Contains(MenuControl.Instance) Then
            MenuControl.Instance.FormParent = Me
            MenuControl.Instance.Conexion = Conexion
            mainContent.Controls.Add(MenuControl.Instance)
            MenuControl.Instance.Dock = DockStyle.Fill
            MenuControl.Instance.BringToFront()
        Else
            MenuControl.Instance.BringToFront()
        End If
    End Sub
End Class