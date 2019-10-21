Imports Logica

Public Class Login_Deus
    Private Sub Btn_LogIn_Click_1(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        If Not String.IsNullOrWhiteSpace(tbx_user.Text) Then
            If Not String.IsNullOrWhiteSpace(tbx_passwd.Text) Then

                Conexion.USER = tbx_user.Text
                Conexion.PSWD = tbx_passwd.Text
                Conexion.Conectar()

                If (LogInAdministrador) Then
                    MessageBox.Show("Conectado Exitosamente.")

                    DirectCast(ParentForm, Menu).CargarMenuPrincipal()

                    Cerrar
                End If
            Else
                MessageBox.Show("Debes ingresar una contrasena.")
                Cerrar
            End If
        Else
            MessageBox.Show("Debes ingresar un usuario.")
            Cerrar
        End If
    End Sub
End Class
