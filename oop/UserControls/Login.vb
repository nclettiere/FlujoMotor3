Imports Logica
Imports System.Data.Odbc
Imports System.Text
Imports System.IO

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

    Private Sub OnLoginLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.USER = "root"
            Conexion.PSWD = "root"

            If Conexion.Conectar()
                Conexion.Cerrar()
            Else
                MessageBox.Show("No se pedo establecer conexion con la DB." + Environment.NewLine + "Chequee que la VM este corriendo y que los datos sean correctos.", "Error de Conexion",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Conexion.Cerrar()
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al chquear conexion.")
        End Try

        cbxIdioma.SelectedIndex = 0
        Cargado = True
    End Sub

    Private Sub CambioIndiceIdioma(sender As Object, e As EventArgs) Handles cbxIdioma.SelectedIndexChanged
        If Cargado
            Select cbxIdioma.SelectedIndex
                Case 0
                    MessageBox.Show("oie shico, si!")
                Case 1
                    MessageBox.Show("Oh, Right!")
                Case 2:
                    MessageBox.Show("!عربيعربى")
            End Select
        End If
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
                    MsgBox(PuertoPatio.ToString)
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
End Class
