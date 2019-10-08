Imports System.Data.Odbc

Public Module Lotes
    Public Function LObtenerAll() As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM lotes", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function LObtenerAllFitro(Filtro As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM lotes WHERE "+ Filtro, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function LUpdateFechaSalida(NuevaFecha As DateTime, LoteId As String) As Boolean
        Conectar()

        Try
            Dim Dcommand As OdbcCommand = New OdbcCommand("UPDATE lotes SET lotefechasalida=? WHERE loteid="+ LoteId +";")
            Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

            Dparameters.Add("lotefechasalida", OdbcType.DateTime)
            Dparameters("lotefechasalida").Value = NuevaFecha

            Dcommand.Connection = DBConexion
            Dcommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try

        Cerrar
    End Function

    Public Function LUpdatePatio(PatioId As String, LoteId As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("UPDATE lotes SET patioid ="+PatioId+" WHERE loteid="+LoteId, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function LUpdateTransportista(TransportistaId As String, LoteId As String) As Boolean
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("UPDATE lotes SET transportistaid ="+TransportistaId+" WHERE loteid="+LoteId, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return True
        Else
            Return False
        End If
        Cerrar
    End Function

    Public Function LUpdateFechaLlegada(Fecha As DateTime, LoteId As String) As Boolean
        Conectar()
        Try
            Dim Dcommand As OdbcCommand = New OdbcCommand("UPDATE lotes SET lotefechallegada=? WHERE loteid="+ LoteId +";")
            Dim Dparameters As OdbcParameterCollection = Dcommand.Parameters

            Dparameters.Add("lotefechallegada", OdbcType.DateTime)
            Dparameters("lotefechallegada").Value = Fecha

            Dcommand.Connection = DBConexion
            Dcommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Cerrar
    End Function

    Public Function LUpdateDesc(Desc As String, LoteId As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("UPDATE lotes SET lotedescripcion ='"+Desc+"' WHERE loteid="+LoteId, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function LUpdateFechas(FechaLlegada As String, FechaSalida As String, LoteId As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("UPDATE lotes SET lotefechallegada ='"+FechaLlegada+"', lotefechasalida ='"+FechaSalida+"' WHERE loteid="+LoteId, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function LObtenerNoSalida() As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM lotes WHERE lotefechasalida IS NULL", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If

        Cerrar
    End Function

    Public Function LObtenerLike(filtro As String) As DataTable
        Conectar()
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

    Public Function LObtenerID(ID As String) As DataRow
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM lotes WHERE loteid="+ ID, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows(0)
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function LObtenerVIN(VIN As String) As DataRow
        Conectar

        Dim LoteId As String = VObtenerVIN(VIN).Item("LoteId")

        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM lotes WHERE loteid='"+ LoteId +"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows(0)
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function LObtenerCountAll() As Integer
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM lotes", DBConexion)
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

    Public Function LObtenerCountID(PatioId As String) As Integer
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM lotes WHERE patioid="+ PatioId, DBConexion)
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

    Public Function LInsertar(Metadata As String()) As Boolean
        Conectar

        Try
            Dim datos As New DataTable
            Dim adapter As New OdbcDataAdapter("INSERT INTO lotes (lotedescripcion, lotenombre, operariopuertoid, patioid) VALUES ('" + Metadata(0) + "'," + Metadata(2) + ",1,"+ PObtenerNombre(Metadata(1)).Item(0).ToString +")", DBConexion)
            adapter.Fill(datos)
            Serilog.Log.Information("Consulta Exitosa.")
            Return True
        Catch ex As Exception
            For Each item As String In Metadata
                Console.WriteLine(item)
            Next
            Serilog.Log.Error(ex, "Consulta Erronea." + Environment.NewLine + "INSERT INTO lotes (lotedescripcion, lotenombre, operariopuertoid, patioid) VALUES ('" + Metadata(0) + "'," + Metadata(2) + ",1,"+ PObtenerNombre(Metadata(1)).Item(0).ToString+")")
            Return False
        End Try

        Cerrar
    End Function
End Module
