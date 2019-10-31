Imports Logica

Public Class Login_Deus
    Private Sub Btn_LogIn_Click_1(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        If Not String.IsNullOrWhiteSpace(tbx_user.Text) Then
            If Not String.IsNullOrWhiteSpace(tbx_passwd.Text) Then

                USER = tbx_user.Text
                PSWD = tbx_passwd.Text

                Conectar

                If CheckAdmin(USER) Then
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

    Protected _Lang As LangManager  = New LangManager
    Protected Sub UpdateLang
        ParentForm.Text = _Lang.ObtenerKey("Login", 0)
        lblUser.Text = _Lang.ObtenerKey("Login", 1)
        lblPswd.Text = _Lang.ObtenerKey("Login", 2)
        btn_LogIn.Text = _Lang.ObtenerKey("Login", 3)
    End Sub

    Private Sub CbxIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIdioma.SelectedIndexChanged
        Select cbxIdioma.SelectedIndex
            Case 0
                '' Seleccionamos el directorio de idioma.
                SetDirectorioIdioma("es-UY", "admin")

                '' Actualizamos los textos de la app
                UpdateLang
            Case 1
                '' Seleccionamos el directorio de idioma.
                SetDirectorioIdioma("en-GB", "admin")

                '' Actualizamos los textos de la app
                UpdateLang()
        End Select
    End Sub

    Private Sub Login_Deus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxIdioma.SelectedIndex = 0
    End Sub
End Class
