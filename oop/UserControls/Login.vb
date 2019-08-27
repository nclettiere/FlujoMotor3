Imports Logica
Imports DB
Imports oop
Imports System.Data.Odbc
Imports System.Text
Imports System.IO

Public Class Login

    Private Shared _instance As Login

    Private Usuarios As List(Of Operario)

    Private facade As Facade
    Private main As Ventanita_Login

    Private OperarioId As Integer

    Private Conexion As ODBC = New ODBC()

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
        Conexion.USER = tbx_user.Text
        Conexion.PWD = tbx_passwd.Text

        Dim EstablacerConexionDB = Conexion.Conectar(Conexion.Conectar())
        If (EstablacerConexionDB) Then
            MessageBox.Show("Conectado Exitosamente.")
            Ventanita_Login.ChangeControlSummary(0, Conexion)
        Else
            MessageBox.Show("Usuario o Contrasena invalidos.")
        End If
    End Sub

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
End Class
