Imports Logica
Imports DB
Imports System.Data.Odbc
Imports System.Text
Imports System.IO

Public Class Login

    Private Shared _instance As Login

    Private ReadOnly Conexion As ODBC = New ODBC()

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

    Private Sub Btn_LogIn_Click_1(sender As Object, e As EventArgs) 
        If Not String.IsNullOrWhiteSpace(tbx_user.Text)
            If Not String.IsNullOrWhiteSpace(tbx_passwd.Text)

                Conexion.USER = tbx_user.Text
                Conexion.PWD = tbx_passwd.Text
                Dim EstablacerConexionDB = Conexion.Conectar(Conexion.Conectar())

                If (EstablacerConexionDB) Then
                    MessageBox.Show("Conectado Exitosamente.")
                    Ventana_Login.ChangeControlSummary(0, Conexion)
                Else
                    MessageBox.Show("Usuario o Contrasena invalidos.")
                End If
            Else
                MessageBox.Show("Debes ingresar una contrasena.")
            End If
        Else
            MessageBox.Show("Debes ingresar un usuario.")
        End If
    End Sub

    Private Sub OnLoginLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.USER = "root"
            Conexion.PWD = "root"
            If Conexion.Conectar(Conexion.Conectar())
                Conexion.Cerrar()
            Else
                MessageBox.Show("No se pedo establecer conexion con la DB." + Environment.NewLine + "Chequee que la VM este corriendo y que los datos sean correctos.", "Error de Conexion",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Serilog.Log.Fatal("No se pudo establecer con la DB." +
                              Environment.NewLine +
                              "Query de conexion usado:" +
                              Environment.NewLine +
                              Conexion.Conectar())
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
End Class
