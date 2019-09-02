Imports System.Data.Odbc

Public Module Patios
    Public Function PObtenerAll() As DataTable
        Conectar()
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM patios", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla
        Else
            Return Nothing
        End If
    End Function

    Public Function PObtenerID(ID As String) As DataRow
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM patios WHERE patioid="+ ID, DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows(0)
        Else
            Return Nothing
        End If
        Cerrar
    End Function

    Public Function PObtenerNombre(Nombre As String) As DataRow
        Conectar
        Dim tabla As New DataTable
        Dim adaptador As New OdbcDataAdapter("SELECT * FROM patios WHERE pationombre='"+ Nombre + "'", DBConexion)
        adaptador.Fill(tabla)

        If VerificarTabla(tabla)
            Return tabla.Rows(0)
        Else
            Return Nothing
        End If
        Cerrar
    End Function
End Module
