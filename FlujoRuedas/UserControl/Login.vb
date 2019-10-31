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

                USER = tbx_user.Text
                PSWD = tbx_passwd.Text
                Conectar()

                Dim EmpleadoId As Integer

                If (CheckLogueo(2, EmpleadoId)) Then
                    MessageBox.Show("Conectado Exitosamente.")

                    OperarioId = EmpleadoId
                    DirectCast(ParentForm, MainWindow).CargarMenuPrincipal()

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

    Private Sub CbxIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIdioma.SelectedIndexChanged
        Select Case cbxIdioma.SelectedIndex
            Case 0
                '' Seleccionamos el directorio de idioma.
                SetDirectorioIdioma("es-UY", "transportista")

                '' Actualizamos los textos de la app
                UpdateLang
            Case 1
                '' Seleccionamos el directorio de idioma.
                SetDirectorioIdioma("en-GB", "transportista")

                '' Actualizamos los textos de la app
                UpdateLang
        End Select
    End Sub

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("Login", 0)
        lblUser.Text = _Lang.ObtenerKey("Login", 1)
        lblPswd.Text = _Lang.ObtenerKey("Login", 2)
        btn_LogIn.Text = _Lang.ObtenerKey("Login", 3)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxIdioma.SelectedIndex = 0
        MainWindow.Size = New Size(392, 499)
    End Sub
End Class