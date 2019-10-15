Imports System.Data.Odbc
Public Module Empleados
    Public Function Disponibilidad(Usuario As String) As Boolean
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM usuarios WHERE usuario='" + Usuario + "'", DBConexion)
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

    Public Function UObtenerAll() As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM usuarios A INNER JOIN empleados B ON A.empleadoid = B.empleadoid", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function UInsertar(ByVal empleadoId As Integer, ByVal Usuario As String) As Boolean
        Conectar
        Try
            Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO usuarios (empleadoId,usuario) VALUES ("+empleadoId.ToString+",'"+Usuario.ToString+"')")
            Dcommand.Connection = DBConexion
            Dcommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar usuario.")
            Serilog.Log.Error(ex, "Error al ingresar usuario.")
            Return False
        End Try

        Cerrar
    End Function

    Public Function EInsertar(ByVal Usuario As String, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As String, Tipo As Integer) As Boolean
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("INSERT INTO empleados (empleadoNombre,empleadoApellido,empleadoTelefono) VALUES ('"+ Nombre +"', '"+ Apellido +"', "+ Telefono +")", DBConexion)
        adaptador.Fill(tabla)

        Dim tablaid As New DataTable
        Dim adaptadorid As New OdbcDataAdapter("SELECT MAX(empleadoid) FROM empleados", DBConexion)
        adaptadorid.Fill(tablaid)

        If OPInsertar(tablaid.Rows(0).Item(0), Tipo)
            If UInsertar(tablaid.Rows(0).Item(0), Usuario)
                Return True
            Else
                MsgBox("No se pudo ingresar usuario")
                Return False
            End If
        Else
            MsgBox("No se pudo ingresar operario tipo")
            Return False
        End If
        Cerrar
    End Function

    Public Function OPInsertar(ByVal EmpleadoId As Integer, tipo As Integer) As Boolean
        Conectar

        Dim DcommandOPbase As OdbcCommand
        DcommandOPbase = New OdbcCommand("INSERT INTO operarios (empleadoid) VALUES ("+EmpleadoId.ToString+")")
        DcommandOPbase.Connection = DBConexion
        DcommandOPbase.ExecuteNonQuery()

        Dim Dcommand As OdbcCommand

        Select Case tipo
            Case 0
                Dcommand = New OdbcCommand("INSERT INTO operarioPuertos (empleadoid) VALUES ("+EmpleadoId.ToString+")")
            Case 1
                Dcommand = New OdbcCommand("INSERT INTO operarioPatios (empleadoid) VALUES ("+EmpleadoId.ToString+")")
            Case 2
                Dcommand = New OdbcCommand("INSERT INTO transportistas  (empleadoid) VALUES ("+EmpleadoId.ToString+")")
            ''Case 3
            ''    Dcommand = New OdbcCommand("INSERT INTO admin (empleadoid) VALUES (?)")
            Case Else
                Dcommand = New OdbcCommand("INSERT INTO operarioPuertos (empleadoid) VALUES ("+EmpleadoId.ToString+")")
        End Select

        Dcommand.Connection = DBConexion
        Dcommand.ExecuteNonQuery()

        Return True
        Cerrar
    End Function
End Module
