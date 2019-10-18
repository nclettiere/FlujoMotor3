Imports System.Data.Odbc
Imports System.IO

Public Module Conexion

    Friend DBConexion As New OdbcConnection

    Public USER As String
    Public PSWD As String

    Public OperarioId As Integer = 1

    Private PrimeraVez As Boolean = True

    Public Function Conectar() As Boolean
        Cerrar
        If PrimeraVez
            DBConexion.ConnectionString = GetArchivoConexion
            PrimeraVez = False
        End If

        Try
            DBConexion.Open()
            Console.WriteLine("Conectado")
            Return True
        Catch ex As OdbcException
            MsgBox("Hubo un error al conectarse.")
            Serilog.Log.Fatal(ex, "err")
            Return False
        End Try
    End Function

    Public Function CheckLogueo(OperarioTipo As Integer, ByRef EmpleadoId As Integer) As Boolean
        Cerrar
        If PrimeraVez
            DBConexion.ConnectionString = GetArchivoConexion
            PrimeraVez = False
        End If

        Try
            DBConexion.Open()
            Dim datos As DataTable = UObtener(USER)
            If datos IsNot Nothing
                If datos.Rows.Count > 0
                    If ObtenerTipoOperario(datos.Rows(0).Item("empleadoid")) = OperarioTipo
                        Console.WriteLine("Conectado")
                        EmpleadoId = datos.Rows(0).Item("empleadoid")
                        Return True
                    Else
                        MsgBox("No tienes permisos para utilizar esta aplicacion.")
                        Return False
                    End If
                Else
                    MsgBox("Contrasena o usuario invalidos.")
                    Return False
                End If
            Else
                MsgBox("Contrasena o usuario invalidos.")
                Return False
            End If

            Return False
        Catch ex As OdbcException
            MsgBox("Hubo un error al conectarse.")
            Serilog.Log.Fatal(ex, "err")
            Return False
        End Try
    End Function

    Public Sub Cerrar()
        DBConexion.Close()
    End Sub

    Private Function GetArchivoConexion() As String
        Try
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "conexioninformix.yaml"))
            Console.WriteLine(fileReader)
            Return fileReader + "UID=" & USER & ";PWD=" & PSWD & ";"
        Catch ex As Exception
            Return "
                Driver={IBM INFORMIX ODBC DRIVER};
                Database=big;
                Host=192.168.6.148;
                Server=ol_esi;
                Service=9088;
                Protocol=onsoctcp;" + "UID=" & USER & ";PWD=" & PSWD & ";"
        End Try
    End Function

    Friend Function VerificarTabla(tabla As DataTable) As Boolean
        If tabla IsNot Nothing And tabla.Rows.Count > 0
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ObtenerOpId() As Integer
        Return OperarioId
    End Function
End Module