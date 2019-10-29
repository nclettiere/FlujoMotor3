Imports Logica

Public Class Login

    Private Shared _instance As Login

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

    Public Property Cargado As Boolean = False

    Protected _Lang As LangManager  = New LangManager

    Private Sub OnLoginLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxIdioma.SelectedIndex = 0
        Cargado = True
    End Sub

    Private Sub CambioIndiceIdioma(sender As Object, e As EventArgs) Handles cbxIdioma.SelectedIndexChanged
        Select cbxIdioma.SelectedIndex
            Case 0
                '' Seleccionamos el directorio de idioma.
                SetDirectorioIdioma("es-UY", "operario")

                '' Actualizamos los textos de la app
                UpdateLang
            Case 1
                '' Seleccionamos el directorio de idioma.
                SetDirectorioIdioma("en-GB", "operario")

                '' Actualizamos los textos de la app
                UpdateLang
            Case 2:
                MessageBox.Show("!عربيعربى")
        End Select
    End Sub

    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        If Not String.IsNullOrWhiteSpace(tbx_user.Text) Then
            If Not String.IsNullOrWhiteSpace(tbx_passwd.Text) Then

                Conexion.USER = tbx_user.Text
                Conexion.PSWD = tbx_passwd.Text
                Conexion.Conectar()

                Dim EmpleadoId As Integer
                Dim PuertoPatio As Boolean
                If (Conexion.CheckLogueo(EmpleadoId, PuertoPatio)) Then
                    MessageBox.Show("Conectado Exitosamente.")
                    Conexion.OperarioId = EmpleadoId
                    Ventana_Login.ChangeControlSummary(0, PuertoPatio)
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

    Protected Sub UpdateLang
            ParentForm.Text = _Lang.ObtenerKey("Login", "Titulo")
            lblUser.Text = _Lang.ObtenerKey("Login", "lbl_001")

    End Sub
End Class
