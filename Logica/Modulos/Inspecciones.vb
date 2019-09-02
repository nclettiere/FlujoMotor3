Imports System.Data.Odbc

Public Module Inspecciones
    Public Function IObtenerAll() As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM inspecciones", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
    End Function

    Public Function IObtenerCount(VIN As String) As Integer
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM inspecciones WHERE vehiculovin='"+ Vin +"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Dim Result As Integer
            If Integer.TryParse(tabla.Rows(0).Item(0), Result)
                Return Result
            Else
                Return 0
            End If
        Else
            Return 0
        End If

        Cerrar
    End Function

    Public Function IObtenerVIN(VIN As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM inspecciones WHERE vehiculovin='"+ Vin +"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If

        Cerrar
    End Function

    Public Function IObtenerVIN(VIN As String, Filtro As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM inspecciones WHERE vehiculovin='"+ Vin +"'" + Filtro, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If

        Cerrar
    End Function

    Public Function DObtenerFiltro(Filtro As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM danios WHERE "+ Filtro, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If

        Cerrar
    End Function

    Public Function IObtenerCount() As Integer
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM inspecciones", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Dim Result As Integer
            If Integer.TryParse(tabla.Rows(0).Item(0), Result)
                Return Result
            Else
                Return 0
            End If
        Else
            Return 0
        End If

        Cerrar
    End Function

    Public Function DObtenerCount() As Integer
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM danios", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Dim Result As Integer
            If Integer.TryParse(tabla.Rows(0).Item(0), Result)
                Return Result
            Else
                Return 0
            End If
        Else
            Return 0
        End If

        Cerrar
    End Function

    Public Function IInsertar(VIN As String) As Boolean
        Conectar()

        Try
            Dim command As OdbcCommand = New OdbcCommand("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES(? ,'" + Vin.ToUpper + "', 3)")
            Dim parameters As OdbcParameterCollection = command.Parameters

            parameters.Add("inspeccionid", OdbcType.Int)
            parameters("inspeccionid").Value = (IObtenerCount + 1)

            command.Connection = DBConexion
            command.ExecuteNonQuery()

            Return True
        Catch ex As OdbcException
            Serilog.Log.Error(ex, "Error al insertar inspeccion.")
            Return False
        End Try

        Cerrar
    End Function

    Public Function IInsertar(VIN As String, Desc As String, Foto As Byte()) As Boolean
        Conectar()

        Try
            ' 1. Crear inspeccion
            Dim Icommand As OdbcCommand = New OdbcCommand("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES("+(IObtenerCount + 1).ToString+" ,'" + Vin.ToUpper + "', 3)")
            Dim Iparameters As OdbcParameterCollection = Icommand.Parameters
            Serilog.Log.Information("INSERT INTO inspecciones (inspeccionid, vehiculovin, operarioid) VALUES("+(IObtenerCount + 1).ToString+" ,'" + Vin.ToUpper + "', 3)")
            Icommand.Connection = DBConexion
            Icommand.ExecuteNonQuery()

            ' 2. Crear danio
            Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO danios (danioid, daniodescripcion, daniofoto) VALUES(" + (DObtenerCount + 1).ToString + ",'" + desc + "', ?)")
            Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters
            Dparameters.Add("daniofoto", OdbcType.Image)
            Dparameters("daniofoto").Value = Foto
            Serilog.Log.Information("INSERT INTO danios (danioid, daniodescripcion, daniofoto) VALUES(" + (DObtenerCount + 1).ToString + ",'" + desc + "', ?)")
            Dcommand.Connection = DBConexion
            Dcommand.ExecuteNonQuery()

            ' 3. Crear inspecciondanio
            Cerrar
            Conectar()
            Dim IDcommand As OdbcCommand = New OdbcCommand("INSERT INTO inspecciondanio (inspeccionid, danioid) VALUES("+ (IObtenerCount).ToString +", "+ (DObtenerCount).ToString +")")
            Serilog.Log.Information("INSERT INTO inspecciondanio (inspeccionid, danioid) VALUES("+ (IObtenerCount).ToString +", "+ (DObtenerCount).ToString +")")
            IDcommand.Connection = DBConexion
            Threading.Thread.Sleep(1000)
            IDcommand.ExecuteNonQuery()

            Return True
        Catch ex As OdbcException
            Serilog.Log.Error(ex, "Error al insertar inspeccion.")
            Return False
        End Try

        Cerrar
    End Function
End Module
