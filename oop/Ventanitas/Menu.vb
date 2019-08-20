Imports DB

Public Class Menu

    Public Property Conexion As ODBC

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        If Not mainContent.Contains(Menu_Wapo.Instance) Then
            Menu_Wapo.Instance.FormParent = Me
            Menu_Wapo.Instance.Conexion = Conexion
            mainContent.Controls.Add(Menu_Wapo.Instance)
            Menu_Wapo.Instance.Dock = DockStyle.Fill
            Menu_Wapo.Instance.BringToFront()
        Else
            Menu_Wapo.Instance.BringToFront()
        End If
    End Sub
End Class