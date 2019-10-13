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
