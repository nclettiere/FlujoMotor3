Imports System.Data.Odbc

Public Module Zonas
    Public Function ZObtenerAll() As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM zonas", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function SZObtenerNombre(SubZonaNombre As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM subzonas WHERE subzonanombre='" + SubZonaNombre + "'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function SZObtenerAll(VIN As String) As DataRow
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM subzonas", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows(0)
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function SZObtenerId(ZonaId As String) As DataRowCollection
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM subzonas WHERE zonaid='"+ ZonaId +"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function SZObtenerIdTable(ZonaId As String) As DataTable
        Conectar()
        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("SELECT * FROM subzonas WHERE zonaid="+ ZonaId, DBConexion)
            adaptador.Fill(tabla)

            If VerificarTabla(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
        Cerrar
    End Function

    Public Function VSZInsertar(VIN As String, SubZonaNombre As String, zonaID As String, Columna As String, Fila As String, OpId As String) As Boolean
        Conectar()
        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("INSERT INTO vehiculosubzona (vehiculoVIN, subZonaNombre, zonaID, columna, fila, empleadoid) VALUES ('"+ VIN +"', '"+ SubZonaNombre +"', "+ ZonaId +", "+ Columna.ToString +", "+ Fila.ToString +", "+OpId+")", DBConexion)
            adaptador.Fill(tabla)

            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "err..")
            Return False
        End Try

        Cerrar
    End Function

    Public Function VSZUpdate(VIN As String, SubZonaNombre As String, zonaID As String, Columna As String, Fila As String, OpId As String) As Boolean
        Conectar()
        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("UPDATE vehiculosubzona SET vehiculoVIN = '"+ VIN +"', subZonaNombre = '"+ SubZonaNombre +"', zonaID = "+ ZonaId +", columna = "+ Columna.ToString +", fila = "+ Fila.ToString +", empleadoid = "+OpId, DBConexion)
            adaptador.Fill(tabla)

            Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "err..")
            Return False
        End Try

        Cerrar
    End Function

    Public Function ZInsertar(PatioId As String) As Boolean
        Conectar()
        Try

        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("INSERT INTO Zonas (patioid) VALUES ("+ PatioId +")", DBConexion)
        adaptador.Fill(tabla)

        Return True

        Catch ex As Exception
            Serilog.Log.Error(ex, "err...")
            Return False
        End Try
        Cerrar
    End Function

    Public Function SZInsertar(zonaID  As String, subZonaNombre   As String, subZonaCapacidad   As String) As Boolean
        Conectar()
        Try

        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("INSERT INTO SubZonas VALUES ("+ zonaID +", '"+subZonaNombre+"',"+ subZonaCapacidad +")", DBConexion)
        adaptador.Fill(tabla)

        Return True
        Catch ex As Exception
            Serilog.Log.Error(ex, "err...")
            Return False
        End Try
        Cerrar
    End Function

    Public Function SZObtenerVIN(VIN As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM subzonas WHERE vehiculovin='"+ VIN +"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VSZObtenerVIN() As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT vehiculovin FROM vehiculosubzona", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function VSZObtenerVIN(VIN As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculosubzona WHERE vehiculovin='"+VIN+"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function SubZObtenerCountNombre(Nombre As String) As Integer
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM subzonas WHERE subzonanombre='" + Nombre + "';", DBConexion)
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

    Public Function VSUpdate(Fila As String, Columna As String, SZNombre As String, VIN As String) As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("UPDATE vehiculosubzona SET fila="+ Fila +", columna="+ Columna  +" WHERE vehiculovin='"+ VIN +"' AND subzonanombre='"+ SZNombre +"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function SZUpdate(SZNombre As String, SZCapacidad As String, SZModNombre As String, ZonaId As String) As Boolean
        Conectar()
        Try
            Dim tabla As New DataTable
            Dim adaptador As New OdbcDataAdapter("UPDATE subzonas SET subzonanombre ='" + SZNombre + "', subzonacapacidad = " + SZCapacidad + ", zonaid = "+ZonaId+" WHERE subzonanombre='" + SZModNombre + "';", DBConexion)
            adaptador.Fill(tabla)

            Return True
        Catch ex As Exception
            Return False
        End Try
        Cerrar
    End Function

    Public Function SZObtenerCount(Id As String) As Integer
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM subzonas WHERE zonaid='"+ Id +"'", DBConexion)
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

    Public Function VSZObtenerCountNombre(SNombre As String) As Integer
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM vehiculosubzona WHERE subzonanombre='"+SNombre+"'", DBConexion)
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

    Public Function ZObtenerPatioID(ID As String) As DataRow
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM zonas WHERE patioid="+ ID, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows(0)
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function ZObtener(PatioID As String) As DataTable
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM zonas WHERE patioid="+ PatioID, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function SZObtenerCountId(Id As String) As Integer
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM subzonas WHERE zonaid="+ ID, DBConexion)
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

    Public Function VSZObtenerCount(VIN As String) As Integer
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT COUNT(*) FROM vehiculosubzona WHERE vehiculovin='"+ VIN+"'", DBConexion)
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

    Public Function VSZObtener(VIN As String) As DataRow
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM vehiculosubzona WHERE vehiculovin='"+ VIN+"'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows(0)
        Else
            Return Nothing
        End If
        Cerrar
    End Function
End Module
