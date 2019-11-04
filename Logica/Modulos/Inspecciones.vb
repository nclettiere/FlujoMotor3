Imports System.Data.Odbc
Imports System.Drawing

Public Module Inspecciones
    Public Function IObtenerAll() As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM inspecciones", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla) Then
            Return tabla
        Else
            Return Nothing
        End If
    End Function

    Public Function DObtener(VIN As String) As DataTable
        Conectar()
        Try
            Dim ListaDanios As DataTable = New DataTable
            Dim Inspecciones = IObtenerVIN(VIN)

            For Each Inspeccion As DataRow In Inspecciones.Rows
                Dim InspeccionDanios = IDObtener(Inspeccion("inspeccionid").ToString)

                For Each InspeccionDanio In InspeccionDanios.Rows
                    Dim Danios As DataTable = Consultar("SELECT * FROM danios WHERE danioid=" + InspeccionDanio("danioid").ToString)

                    If Danios IsNot Nothing Then
                        If Danios.Rows.Count > 0 Then
                            ListaDanios.Merge(Danios)
                        End If
                    End If
                Next
            Next
            Return ListaDanios
        Catch ex As Exception
            Serilog.Log.Error(ex, "er..")
            Return Nothing
        End Try
        Cerrar()
    End Function

    Public Function DObtener() As DataTable
        Conectar()
        Try
            Dim ListaDanios As DataTable = New DataTable

            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("SELECT * FROM danios", DBConexion)
            adaptador.Fill(tabla)

            Return tabla
        Catch ex As Exception
            Serilog.Log.Error(ex, "er..")
            Return Nothing
        End Try
        Cerrar()
    End Function

    Public Function DObtenerExcep(InspeccionId As String) As DataTable
        Conectar()
        Try
            Dim ListaDanios As DataTable = New DataTable

            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("SELECT A.danioid, A.daniodescripcion, A.daniofoto FROM danios A LEFT JOIN inspecciondanio B ON A.danioid = B.danioid WHERE B.danioid <> " + InspeccionId, DBConexion)
            adaptador.Fill(tabla)

            If VerificarTabla(tabla) Then
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "er..")
            Return Nothing
        End Try
        Cerrar()
    End Function

    Public Function IObtenerCount(VIN As String) As Integer
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM inspecciones WHERE vehiculovin='" + VIN + "'", DBConexion)
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
        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("SELECT * FROM inspecciones WHERE vehiculovin='" + VIN + "'", DBConexion)
            adaptador.Fill(tabla)

            If VerificarTabla(tabla) Then
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "er..")
            Return Nothing
        End Try
        Cerrar
    End Function

    Public Function IObtenerVINCount(VIN As String) As Integer
        Conectar()
        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM inspecciones WHERE vehiculovin='" + VIN + "'", DBConexion)
            adaptador.Fill(tabla)

            If VerificarTabla(tabla)
                Return tabla.Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "err..")
            Return 0
        End Try
        Cerrar
    End Function

    Public Function IObtenerVIN(VIN As String, Filtro As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM inspecciones WHERE vehiculovin='" + VIN + "'" + Filtro, DBConexion)
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
        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("SELECT * FROM danios WHERE " + Filtro, DBConexion)
            adaptador.Fill(tabla)

            If VerificarTabla(tabla) Then
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "er..")
            Return Nothing
        End Try
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

    Public Function DIObtenerCount(InspeccionId As String) As Integer
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM inspecciondanio WHERE InspeccionId=" + InspeccionId, DBConexion)
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

    Public Function IDObtener(InspeccionId As String) As DataTable
        Conectar()
        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("SELECT * FROM inspecciondanio WHERE InspeccionId=" + InspeccionId, DBConexion)
            adaptador.Fill(tabla)

            If VerificarTabla(tabla) Then
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "err..")
            Return Nothing
        End Try
        Cerrar
    End Function

    Public Function IInsertar(VIN As String, OpId As Integer) As Boolean
        Conectar()
        Try
            Dim command As OdbcCommand = New OdbcCommand("INSERT INTO inspecciones (vehiculovin, operarioid) VALUES('" + VIN.ToUpper + "', "+ OpId.ToString +")")
            Dim parameters As OdbcParameterCollection = command.Parameters

            command.Connection = DBConexion
            command.ExecuteNonQuery()

            Return True
        Catch ex As OdbcException
            Serilog.Log.Error(ex, "Error al insertar inspeccion.")
            Return False
        End Try

        Cerrar
    End Function

    Public Function IInsertar(VIN As String, InspID As String, Desc As String, Foto As Byte()) As Boolean
        Conectar()

        Try
            ' 1. Crear danio
            Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO danios (daniodescripcion, daniofoto) VALUES('" + Desc + "', ?)")
            Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters
            Dparameters.Add("daniofoto", OdbcType.Image)
            Dparameters("daniofoto").Value = Foto
            Serilog.Log.Information("INSERT INTO danios (daniodescripcion, daniofoto) VALUES('" + Desc + "', ?)")
            Dcommand.Connection = DBConexion
            Dcommand.ExecuteNonQuery()

            ' 2. Crear inspecciondanio
            Cerrar
            Conectar()
            Dim IDcommand As OdbcCommand = New OdbcCommand("INSERT INTO inspecciondanio (inspeccionid, danioid) VALUES(" + InspID + "," + DObtenerCount.ToString + ")")
            Serilog.Log.Information("INSERT INTO inspecciondanio (inspeccionid, danioid) VALUES(" + InspID + "," + DObtenerCount.ToString + ")")
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

    Public Function DObtenerFoto(DanioId As String) As Bitmap
        Dim queryString As String = "SELECT daniofoto FROM danios WHERE danioid=" + DanioId
        Dim ByteCrudo As Byte() = Nothing
        Try
            Conectar()
            Dim command As OdbcCommand = New OdbcCommand(queryString, DBConexion)
            Dim reader As OdbcDataReader = command.ExecuteReader()

            While reader.Read()
                ByteCrudo = reader(0)
            End While

            reader.Close()

            Cerrar()

            Return ByteABitmap(ByteCrudo)
        Catch ex As Exception
            MsgBox("Error al convertir foto. Vea el logesillo para mas info.")
            Serilog.Log.Error(ex, "Error al convertir foto.")
            Return Nothing
        End Try
    End Function

    Public Function IDInsertar(DanioId As String, InspeccionId As String) As Boolean

        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("INSERT INTO inspecciondanio VALUES(" + DanioId + ", " + InspeccionId + ")", DBConexion)
            adaptador.Fill(tabla)

            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "err..")
            Return False
        End Try
    End Function
End Module
