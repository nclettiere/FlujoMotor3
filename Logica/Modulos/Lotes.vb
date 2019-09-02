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
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM lotes WHERE vehiculovin='"+ VIN +"'", DBConexion)
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

    Public Function LInsertar(Metadata As String()) As Boolean
        Conectar

        Try
            Dim datos As New DataTable
            Dim adapter As New OdbcDataAdapter("INSERT INTO lotes (loteid, lotedescripcion, lotenombre, operariopuertoid, patioid) VALUES (" + Metadata(0) + ", '" + Metadata(1) + "'," + Metadata(2) + "," + Metadata(3) + ","+Metadata(4)+")", DBConexion)
            adapter.Fill(datos)
            Serilog.Log.Information("Consulta Exitosa.")
            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "Consulta Erronea." + Environment.NewLine + "INSERT INTO lotes (loteid, lotedescripcion, lotenombre, operariopuertoid, patioid) VALUES (" + Metadata(0) + ", '" + Metadata(1) + "'," + Metadata(2) + "," + Metadata(3) + ","+Metadata(4)+")")
            Return False
        End Try

        Cerrar
    End Function
End Module
