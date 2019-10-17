Imports System.Data.Odbc

Public Module Vehiculos
    Public Function VObtenerAll() As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VObtenerAllPuertoLike(filtro As String) As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos A LEFT JOIN lotes B ON A.loteid = B.loteid WHERE A.vehiculofechaentrega IS NULL AND B.lotefechallegada IS NULL AND B.lotefechasalida IS NULL AND A.vehiculovin LIKE '%" + filtro + "%'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VObtenerAllPuerto() As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos A LEFT JOIN lotes B ON A.loteid = B.loteid WHERE A.vehiculofechaentrega IS NULL AND B.lotefechallegada IS NULL AND B.lotefechasalida IS NULL", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VObtenerAllPatio() As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos A LEFT JOIN lotes B ON A.loteid = B.loteid WHERE A.vehiculofechaentrega IS NULL AND B.lotefechallegada IS NOT NULL AND B.lotefechasalida IS NOT NULL", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VObtenerAllPatioFiltro(Filtro As String) As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos A LEFT JOIN lotes B ON A.loteid = B.loteid WHERE A.vehiculofechaentrega IS NULL AND B.lotefechallegada IS NOT NULL AND B.lotefechasalida IS NOT NULL AND A.vehiculovin LIKE '%" + filtro + "%'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function
    Public Function VObtenerAllVendidos() As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos WHERE vehiculofechaentrega IS NOT NULL", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VUpdateLote(LoteId As String, VIN As String) As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("UPDATE vehiculos SET loteid ="+Loteid+" WHERE vehiculovin='"+VIN+"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VEliminar(vIN As String) As Boolean
        Conectar
        Try
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim tabla3 As New DataTable
        Try
            Dim ObtenerInspIds As New OdbcDataAdapter("SELECT inspeccionid FROM inspecciones WHERE vehiculovin='"+VIN+"'", DBConexion)
            ObtenerInspIds.Fill(tabla)
            For Each item As DataRow In tabla.Rows
                Dim Inspdan As New OdbcDataAdapter("SELECT danioid FROM inspeccionDanio WHERE inspeccionid ="+item.Item(0).ToString, DBConexion)
                Inspdan.Fill(tabla2)
                Dim deleteInspdan As New OdbcDataAdapter("DELETE FROM inspeccionDanio WHERE inspeccionid ="+item.Item(0).ToString, DBConexion)

                For Each danioid As DataRow In tabla2.Rows
                    Dim deletedanio As New OdbcDataAdapter("DELETE FROM danio WHERE danioid ="+danioid.Item(0).ToString, DBConexion)
                    deletedanio.Fill(tabla3)
                Next
                Dim deleteInsp As New OdbcDataAdapter("DELETE FROM inspecciones WHERE vehiculoVIN ='"+VIN+"'", DBConexion)
                deleteInsp.Fill(tabla)
            Next
        Catch ex As Exception
            Serilog.Log.Error(ex, "No se pudo eliminar vehiculo.")
        End Try

        Try
        Dim deleteVsUB = New OdbcDataAdapter("DELETE FROM vehiculoSubZona WHERE vehiculovin ='"+VIN+"'", DBConexion)
        Dim deletelavado = New OdbcDataAdapter("DELETE FROM lavadoVehiculo WHERE vehiculovin ='"+VIN+"'", DBConexion)
        deleteVsUB.Fill(tabla)
        deletelavado.Fill(tabla)
        Catch ex As Exception
            Serilog.Log.Error(ex, "No se pudo eliminar vehiculo.")
        End Try

        Dim DelV = New OdbcDataAdapter("DELETE FROM vehiculos WHERE vehiculoVIN ='"+VIN+"'", DBConexion)

        DelV.Fill(tabla)
        If VerificarTabla(tabla)
            MsgBox("Vehiculo eliminado correctamente.")
            Return True
        Else
            MsgBox("No se pudo eliminar vehiculo.5")
            Return False
        End If

        Catch ex As Exception
            Serilog.Log.Error(ex, "No se pudo eliminar vehiculo.")
            MsgBox("No se pudo eliminar vehiculo.")
            Return False
        End Try

        Cerrar 
    End Function

    Public Function VObtenerAllFiltro(Filtro As String) As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos WHERE "+ Filtro, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VObtenerLoteId(LoteId As String) As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos WHERE loteid="+ LoteId, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VUpdateLoteId(LoteIdNuevo As String, VIN As String) As Boolean
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("UPDATE vehiculos SET loteid ="+ LoteIdNuevo +"  WHERE vehiculovin='"+ VIN +"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return True
        Else
            Return False
        End If
        Cerrar
    End Function

    Public Function VInsertar(Metadata As String()) As Boolean
        Conectar
        Try
            If Metadata.Count >= 7
                Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID,loteID) VALUES (?, ?, ?, ?, ?, ?, ?, ?)")
                Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

                Dparameters.Add("vehiculovin", OdbcType.VarChar)
                Dparameters("vehiculovin").Value = Metadata(0)

                Dparameters.Add("vehiculocolor", OdbcType.VarChar)
                Dparameters("vehiculocolor").Value = Metadata(1)

                Dparameters.Add("vehiculomarca", OdbcType.VarChar)
                Dparameters("vehiculomarca").Value = Metadata(2)

                Dparameters.Add("vehiculomodelo", OdbcType.VarChar)
                Dparameters("vehiculomodelo").Value = Metadata(3)

                Dparameters.Add("vehiculoanio", OdbcType.SmallInt)
                Dparameters("vehiculoanio").Value = Integer.Parse(Metadata(4))

                Dparameters.Add("vehiculotipo", OdbcType.VarChar)
                Dparameters("vehiculotipo").Value = Metadata(5)

                Dparameters.Add("operariopuertoid", OdbcType.Int)
                Dparameters("operariopuertoid").Value = 1

                Dparameters.Add("loteid", OdbcType.Int)
                Dparameters("loteid").Value = Integer.Parse(Metadata(6))

                Dcommand.Connection = DBConexion
                Dcommand.ExecuteNonQuery()
            Else
                Serilog.Log.Information("Vehiculo sin Lote.")
                Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID) VALUES (?, ?, ?, ?, ?, ?, ?)")
                Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

                Dparameters.Add("vehiculovin", OdbcType.VarChar)
                Dparameters("vehiculovin").Value = Metadata(0)

                Dparameters.Add("vehiculocolor", OdbcType.VarChar)
                Dparameters("vehiculocolor").Value = Metadata(1)

                Dparameters.Add("vehiculomarca", OdbcType.VarChar)
                Dparameters("vehiculomarca").Value = Metadata(2)

                Dparameters.Add("vehiculomodelo", OdbcType.VarChar)
                Dparameters("vehiculomodelo").Value = Metadata(3)

                Dparameters.Add("vehiculoanio", OdbcType.SmallInt)
                Dparameters("vehiculoanio").Value = Integer.Parse(Metadata(4))

                Dparameters.Add("vehiculotipo", OdbcType.VarChar)
                Dparameters("vehiculotipo").Value = Metadata(5)

                Dparameters.Add("operariopuertoid", OdbcType.Int)
                Dparameters("operariopuertoid").Value = 1

                Dcommand.Connection = DBConexion
                Dcommand.ExecuteNonQuery()
            End If

            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al agregar vehiculo.")
            Return False
        End Try

        Cerrar
    End Function

    Public Function VUpdate(vINmodificacion As String, marca As String, modelo As String, color As String, tipo As String, anio As String) As Boolean
        Try
            Dim Dcommand As OdbcCommand = New OdbcCommand("UPDATE vehiculos
                                                          SET vehiculocolor = ?, vehiculomarca = ?,vehiculomodelo = ?, vehiculoanio = ?, vehiculotipo = ?
                                                          WHERE vehiculovin = '"+vINmodificacion+"';")
            Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters
            Dparameters.Add("vehiculocolor", OdbcType.VarChar)
            Dparameters("vehiculocolor").Value = Color

            Dparameters.Add("vehiculomarca", OdbcType.VarChar)
            Dparameters("vehiculomarca").Value = Marca

            Dparameters.Add("vehiculomodelo", OdbcType.VarChar)
            Dparameters("vehiculomodelo").Value = Modelo

            Dparameters.Add("vehiculoanio", OdbcType.SmallInt)
            Dparameters("vehiculoanio").Value = Integer.Parse(Anio)

            Dparameters.Add("vehiculotipo", OdbcType.VarChar)
            Dparameters("vehiculotipo").Value = Tipo
            
            Dcommand.Connection = DBConexion
            Dcommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "err...")
            Return False
        End Try
    End Function

    Public Function VInsertar(ByVal VIN As String, ByVal Marca As String, ByVal Modelo As String, ByVal Color As String, ByVal Tipo As String, ByVal Anio As String, ByVal LoteId As String, ByVal OperarioID As String) As Boolean
        Conectar
            Try
                Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID,loteID) VALUES (?, ?, ?, ?, ?, ?, ?, ?)")
                Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

                Dparameters.Add("vehiculovin", OdbcType.VarChar)
                Dparameters("vehiculovin").Value = VIN

                Dparameters.Add("vehiculocolor", OdbcType.VarChar)
                Dparameters("vehiculocolor").Value = Color

                Dparameters.Add("vehiculomarca", OdbcType.VarChar)
                Dparameters("vehiculomarca").Value = Marca

                Dparameters.Add("vehiculomodelo", OdbcType.VarChar)
                Dparameters("vehiculomodelo").Value = Modelo

                Dparameters.Add("vehiculoanio", OdbcType.SmallInt)
                Dparameters("vehiculoanio").Value = Integer.Parse(Anio)

                Dparameters.Add("vehiculotipo", OdbcType.VarChar)
                Dparameters("vehiculotipo").Value = Tipo

                Dparameters.Add("operariopuertoid", OdbcType.Int)
                Dparameters("operariopuertoid").Value = Integer.Parse(OperarioID)

                Dparameters.Add("loteid", OdbcType.Int)
                Dparameters("loteid").Value = Integer.Parse(LoteId)

                Dcommand.Connection = DBConexion
                Dcommand.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al Ingresar Vehiculo.")
                Return False
            End Try
        Cerrar
    End Function

        Public Function VInsertar(ByVal VIN As String, ByVal Marca As String, ByVal Modelo As String, ByVal Color As String, ByVal Tipo As String, ByVal Anio As String, ByVal OperarioID As String) As Boolean
        Conectar
            Try
                Dim Dcommand As OdbcCommand = New OdbcCommand("INSERT INTO vehiculos (vehiculovin,vehiculoColor,vehiculoMarca,vehiculoModelo,vehiculoAnio,vehiculoTipo,operarioPuertoID) VALUES (?, ?, ?, ?, ?, ?, ?)")
                Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

                Dparameters.Add("vehiculovin", OdbcType.VarChar)
                Dparameters("vehiculovin").Value = VIN

                Dparameters.Add("vehiculocolor", OdbcType.VarChar)
                Dparameters("vehiculocolor").Value = Color

                Dparameters.Add("vehiculomarca", OdbcType.VarChar)
                Dparameters("vehiculomarca").Value = Marca

                Dparameters.Add("vehiculomodelo", OdbcType.VarChar)
                Dparameters("vehiculomodelo").Value = Modelo

                Dparameters.Add("vehiculoanio", OdbcType.SmallInt)
                Dparameters("vehiculoanio").Value = Integer.Parse(Anio)

                Dparameters.Add("vehiculotipo", OdbcType.VarChar)
                Dparameters("vehiculotipo").Value = Tipo

                Dparameters.Add("operariopuertoid", OdbcType.Int)
                Dparameters("operariopuertoid").Value = Integer.Parse(OperarioID)

                Dcommand.Connection = DBConexion
                Dcommand.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Serilog.Log.Error(ex, "Error al Ingresar Vehiculo.")
                Return False
            End Try
        Cerrar
    End Function

    Public Function VObtenerNoEntregados() As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos WHERE vehiculofechaentrega IS NULL", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If

        Cerrar
    End Function

    Public Function VObtenerLike(filtro As String) As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos WHERE vehiculovin LIKE '%" + filtro + "%'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If

        Cerrar
    End Function

    Public Function VObtenerVIN(VIN As String) As DataRow
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculos WHERE vehiculovin='"+ VIN +"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows(0)
        Else
            Return Nothing
        End If

        Cerrar
    End Function

    Public Function VCheckVIN(VIN As String) As Integer
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT Count(*) FROM vehiculos WHERE vehiculovin='"+ VIN +"'", DBConexion)
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
End Module
