Public Class MainWindow

    Private Property Conexion As DB.ODBC = New DB.ODBC

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New DB.ODBC
        Dim VentanaLogin = Login.Instance
        VentanaLogin.Conexion = Conexion

        If Not mainContent.Contains(VentanaLogin) Then
            VentanaLogin.Conexion = Conexion
            Me.ClientSize = VentanaLogin.Size
            MainContent.Controls.Add(VentanaLogin)
            VentanaLogin.Dock = DockStyle.Fill
            VentanaLogin.BringToFront()
        Else
            VentanaLogin.BringToFront()
        End If
    End Sub

    Friend Sub CambiarControl(index As Integer)
        Dim Seleccion As Object

        Select Case index
            Case 0
                Seleccion = MenuPrincipal.Instance
                Me.ClientSize = MenuPrincipal.Instance.Size
            Case Else
                Seleccion = MenuPrincipal.Instance
                Me.ClientSize = MenuPrincipal.Instance.Size
        End Select

        If Not mainContent.Contains(Seleccion) Then
            MainContent.Controls.Add(Seleccion)
            Seleccion.Dock = DockStyle.Fill
            Seleccion.BringToFront()
        Else
            Seleccion.BringToFront()
        End If
    End Sub
End Class
