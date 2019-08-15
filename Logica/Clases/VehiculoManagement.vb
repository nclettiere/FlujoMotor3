Imports DB.ODBC

Public Class VehiculoManagement
    '' Obtener raw lista
    Function ObtenerLista(ByRef Conexion) As List(Of Vehiculo)
        Return New List(Of Vehiculo)
    End Function

    '' Obtener lista con filtros

    ''' <summary>
    ''' Obtener lista de vehiculos para todos que cumplan con el color {color}
    ''' </summary>
    ''' <param name="Conexion">Conexion de Base de datos</param>
    ''' <param name="Color">Color del vehiculo</param>
    ''' <returns></returns>
    Function ObtenerLista(ByRef Conexion As String, ByRef Color As String) As List(Of Vehiculo)
        ''Dim filtro As List(Of Vehiculo) = [LISTA].Where(Function(x) _ x.Color.ToString.ToLower.Contains(Color)).ToList()
        ''Return filtro
    End Function
End Class
