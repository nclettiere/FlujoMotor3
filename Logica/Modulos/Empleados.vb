Imports System.Data.Odbc
Public Module Empleados
    Public Function Disponibilidad(Usuario As String) As Boolean
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM usuario WHERE usuario='" + Usuario + "'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Dim Result As Integer
            If Integer.TryParse(tabla.Rows(0).Item(0), Result)
                If Result > 0
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        Else
            MsgBox("Hubo un error al listar usuarios.")
            Return False
        End If
        Cerrar
    End Function

    Public Function UInsertar(ByVal empleadoId As Integer, ByVal Usuario As String, ByVal Crypt As Encriptacion.HashySalt) As Boolean
        Conectar
        Try
            Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO usuario (empleadoid,usuario,hash,salt) VALUES (?, ?, ?, ?)")
            Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

            Dparameters.Add("empleadoid", OdbcType.Int)
            Dparameters("empleadoid").Value = empleadoId

            Dparameters.Add("usuario", OdbcType.VarChar)
            Dparameters("usuario").Value = Usuario

            Dparameters.Add("hash", OdbcType.VarChar)
            Dparameters("hash").Value = Crypt.Hash

            Dparameters.Add("salt", OdbcType.VarChar)
            Dparameters("salt").Value = Crypt.Salt

            Dcommand.Connection = DBConexion
            Dcommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error al insertar usuario. Vea el log para mas info.")
            Serilog.Log.Error(ex, "Error al insertar usaurio.")
            Return False
        End Try
        Cerrar
    End Function

    Public Function EInsertar(ByVal Usuario As String, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As String, Tipo As Integer, ByVal Hash As Encriptacion.HashySalt) As Boolean
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("INSERT INTO empleados (empleadoNombre,empleadoApellido,empleadoTelefono) VALUES ('"+ Nombre +"', '"+ Apellido +"', "+ Telefono +")", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Dim tablaid As New DataTable
            Dim adaptadorid As New OdbcDataAdapter("SELECT DBINFO( 'sqlca.sqlerrd1' ) FROM empleados LIMIT 1", DBConexion)
            adaptadorid.Fill(tablaid)
            If OPInsertar(tablaid.Rows(0).Item(0), Tipo)
                If UInsertar(tablaid.Rows(0).Item(0), Usuario, Hash)
                    MsgBox("Usuario Insertado exitosamente.")
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
        Cerrar
    End Function

    Public Function OPInsertar(ByVal EmpleadoId As Integer, tipo As Integer) As Boolean
        Conectar
        Try
            Dim Dcommand As OdbcCommand
            Select Case tipo
                Case 0
                    Dcommand = New OdbcCommand("INSERT INTO operarioPuertos (empleadoid) VALUES (?)")
                Case 1
                    Dcommand = New OdbcCommand("INSERT INTO operarioPatios (empleadoid) VALUES (?)")
                Case 2
                    Dcommand = New OdbcCommand("INSERT INTO transportistas  (empleadoid) VALUES (?)")
                ''Case 3
                ''    Dcommand = New OdbcCommand("INSERT INTO admin (empleadoid) VALUES (?)")
                Case Else
                    Dcommand = New OdbcCommand("INSERT INTO operarioPuertos (empleadoid) VALUES (?)")
            End Select

            Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

            Dparameters.Add("empleadoid", OdbcType.Int)
            Dparameters("empleadoid").Value = EmpleadoId

            Dcommand.Connection = DBConexion
            Dcommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox("Error al insertar operario tipo. Vea el log para mas info.")
            Serilog.Log.Error(ex, "Error al insertar operario tipo.")
            Return False
        End Try
        Cerrar
    End Function
End Module
