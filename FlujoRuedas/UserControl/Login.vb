Imports Logica

Public Class Login
    Private Shared _instance As Login

    Friend Property MainWindowForm As MainWindow

    Public Shared Property Instance As Login
        Get
            If _instance Is Nothing Then
                _instance = New Login()
            End If
            Return _instance
        End Get
        Set(value As Login)
            _instance = value
        End Set
    End Property

    Private Sub Btn_LogIn_Click_1(sender As Object, e As EventArgs) Handles btn_LogIn.Click 
        If Not String.IsNullOrWhiteSpace(tbx_user.Text) Then
            If Not String.IsNullOrWhiteSpace(tbx_passwd.Text) Then

                Conexion.USER = tbx_user.Text
                Conexion.PSWD = tbx_passwd.Text
                Conexion.Conectar()

                If (Conexion.Conectar()) Then
                    MessageBox.Show("Conectado Exitosamente.")
                    
                    DirectCast(ParentForm, MainWindow).CargarMenuPrincipal()

                    Cerrar
                Else
                    MessageBox.Show("Usuario o Contrasena invalidos.")
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
