Imports Logica

Public Class Menu_Operario

    Private FacadeRef As Facade

    'METODO PARA ABRIR VENTANA
    Private Sub Abrir(Of ventana As {Form, New})()
        Dim ventanita As Form

        ventanita = pnVentanas.Controls.OfType(Of ventana)().FirstOrDefault()

        If ventanita Is Nothing Then
            ventanita = New ventana()
            ventanita.TopLevel = False
            ventanita.Dock = DockStyle.Fill
            pnVentanas.Controls.Add(ventanita)
            pnVentanas.Tag = ventanita
            ventanita.Show()
            ventanita.BringToFront()
        Else
            ventanita.BringToFront()
        End If
    End Sub


    Friend Sub crear(facade As Facade, session As Inicio_de_sesion, operario As Operario, usuarios As List(Of Operario), charge As Boolean)
        FacadeRef = facade
        FacadeRef.Operario = operario

        If Not charge Then
            For Each item In usuarios
                facade.AgregarOperario(item)
            Next
        End If

        btn_perfil.Text = FacadeRef.Operario.Nombre + " " + FacadeRef.Operario.Apellido
    End Sub

    'BOTON "VEHICULOS"
    Private Sub BtVehiculos_Click(sender As Object, e As EventArgs) Handles btVehiculos.Click
        Abrir(Of Vehiculos)()
    End Sub

    Private Sub btVehiculos_MouseEnter(sender As Object, e As EventArgs) Handles btVehiculos.MouseEnter
        btVehiculos.ForeColor = Color.Gray
    End Sub

    Private Sub btVehiculos_MouseLeave(sender As Object, e As EventArgs) Handles btVehiculos.MouseLeave
        btVehiculos.ForeColor = Color.White
    End Sub


    'BOTON "PATIO"
    Private Sub BtPatio_Click(sender As Object, e As EventArgs) Handles btPatio.Click
        Abrir(Of Op_patio)()
    End Sub

    Private Sub btPatio_MouseEnter(sender As Object, e As EventArgs) Handles btPatio.MouseEnter
        btPatio.ForeColor = Color.Gray
    End Sub

    Private Sub btPatio_MouseLeave(sender As Object, e As EventArgs) Handles btPatio.MouseLeave
        btPatio.ForeColor = Color.White
    End Sub



    'BOTON "TRANSPORTE"
    Private Sub BtTransporte_Click(sender As Object, e As EventArgs)
        Abrir(Of Transporte)()
    End Sub

    Friend Function GetFacade() As Facade
        Return FacadeRef
    End Function


    Private Sub btn_perfil_Click(sender As Object, e As EventArgs) Handles btn_perfil.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Inicio As New Inicio_de_sesion
        Me.Hide()
        Inicio.cargar(Me, FacadeRef)
        Inicio.ShowDialog()
    End Sub
End Class