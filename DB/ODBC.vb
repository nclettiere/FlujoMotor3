Imports System.Data.Odbc
Imports Serilog
Imports IBM.Data.Informix

Public Class ODBC
    Public Property conODBC As New OdbcConnection

    Private _USER As String
    Private _PWD As String

    Public Property USER As String
        Get
            Return _USER
        End Get
        Set(value As String)
            _USER = value
        End Set
    End Property

    Public Property PWD As String
        Get
            Return _PWD
        End Get
        Set(value As String)
            _PWD = value
        End Set
    End Property

    Public Function Conectar(connection_string As String) As Boolean
        conODBC.ConnectionString = connection_string
        Try
            conODBC.Open()
            Console.WriteLine("Conectado")
            Return True
        Catch ex As OdbcException
            Log.Information(ex, "Error de Conexion.")
            conODBC.Close()
            Return False
        End Try

    End Function

    Public Sub Cerrar()
        conODBC.Close()
    End Sub

    Public Function consultar(query As String) As DataTable
        Log.Information("Consultando Query => " + query)
        Try
            Dim datos As New DataTable
            Dim adapter As New OdbcDataAdapter(query, conODBC)
            adapter.Fill(datos)
            Log.Information("Consulta Exitosa.")
            Return datos
        Catch ex As Exception
            Log.Error(ex, "Consulta Erronea " + query)
            Return Nothing
        End Try
    End Function

    
    Public Function consultaDanio(query As String, bytes As Byte()) As DataTable
        Log.Information("Consultando Query (DANIO) => " + query)
        If bytes Is Nothing
            Log.Error("NULL")
        End If
        Try
            Dim insertQuery As String = "INSERT INTO blobtest(value) VALUES(?)"
   
            Dim command As OdbcCommand = New OdbcCommand(insertQuery)
            Dim parameters As OdbcParameterCollection = command.Parameters

            parameters.Add("value", OdbcType.Image)
            parameters("value").Value = bytes

            command.Connection = conODBC
            command.ExecuteNonQuery()

            Return Nothing
        Catch ex As Exception
            Log.Error(ex, "Consulta Erronea " + query)
            Return Nothing
        End Try
    End Function

    Public Function Conectar() As String
        Dim conexion As String
        conexion = "
        DSN=bigmamma;
        Database=big;
        Host=192.168.1.48;
        Server=ol_esi;
        Service=9088;
        Protocol=onsoctcp;
        UID=" & USER &
        ";Password=" & PWD & ";"
        Return conexion
    End Function
End Class