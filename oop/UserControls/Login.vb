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
#If RELEASE Then
        Dim Conexion As ODBC = New ODBC()

        Conexion.USER = tbx_user.Text
        Conexion.PWD = tbx_passwd.Text

        Dim isConnected = Conexion.Conectar(Conexion.Conectar())
        If (isConnected) Then
            ''Conexion.Hacer_consulta("Select * FROM Personas")
            MessageBox.Show("Conectado Exitosamente.")
            Ventanita_Login.ChangeControlSummary(0, Conexion)
        Else
            MessageBox.Show("Usuario o Contrasena invalidos.")
        End If
#Else
        If Ventanita_Login.ModoDatos = 1
            Ventanita_Login.ChangeControlSummary(0, Nothing)
        Else
            Conexion.USER = tbx_user.Text
            Conexion.PWD = tbx_passwd.Text

            Dim isConnected = Conexion.Conectar(Conexion.Conectar())
            If (isConnected) Then
                ''Conexion.Hacer_consulta("Select * FROM Personas")
                MessageBox.Show("Conectado Exitosamente.")
                Ventanita_Login.ChangeControlSummary(0, Conexion)
            Else
                MessageBox.Show("Usuario o Contrasena invalidos.")
            End If
        End If

#End If

    End Sub

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG
        Conexion.USER = "root"
        Conexion.PWD = "root"
        If Conexion.Conectar(Conexion.Conectar())
            RetrieveLargeText()
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
#End If
    End Sub

    Private Sub RetrieveLargeText()
        Dim query = "SELECT * FROM blobtest"
        Dim command As OdbcCommand = New OdbcCommand(query)
        command.Connection = Conexion.conODBC
        Dim reader As OdbcDataReader = command.ExecuteReader()

        If reader.Read()
            Dim value As byte() = reader.GetValue(0)
            PictureBox1.Image = BytesToBitmap(value)
        End If
        
        reader.Close()
    End Sub

    Private Function BytesToBitmap(byteArray As Byte()) As Bitmap
        Using ms As MemoryStream = New MemoryStream(byteArray)
            Dim img As Bitmap = DirectCast(Image.FromStream(ms), Bitmap)
            Return img
        End Using
    End Function
End Class
