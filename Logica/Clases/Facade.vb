Imports System.IO
Imports oop

Public Class Facade

    Private ListaVehiculos = New List(Of VehiculoTest)
    Private ListaLotes = New List(Of Lote)
    Private ListaInspecciones = New List(Of Inspeccion)
    Private ListaUbicaciones = New List(Of Ubicacion)
    Private ListaPatios = New List(Of Patio)
    Private ListaOperario = New List(Of Operario)
    Private _Operario As Operario

    Public CSVVehiculos As String
    Public CSVUbicaciones As String
    Public CSVInspecciones As String



    Public Sub AgregarVehiculoACsv(csv As String(), strFile As String)

        Using writer As New StreamWriter(strFile, True)
            writer.WriteLine()
            writer.WriteLine(csv(0) + "," +
                             csv(1) + "," +
                             csv(2) + "," +
                             csv(3) + "," +
                             csv(4) + "," +
                             csv(5) + "," +
                             csv(6) + "," +
                             csv(7) + "," +
                             csv(8) + "," +
                             csv(9))
        End Using
    End Sub

    Public Sub AgregarUbicacionACsv(csv As String(), strFile As String)

        Using writer As New StreamWriter(strFile, True)
            writer.WriteLine()
            writer.WriteLine(csv(0) + "," +
                         csv(1) + "," +
                         csv(2) + "," +
                         csv(3) + "," +
                         csv(4))
        End Using
    End Sub

    Sub AgregarOperarios(operario As Operario)
        ListaOperario.Add(operario)
    End Sub

    Public Property Operario As Operario
        Get
            Return _Operario
        End Get
        Set(value As Operario)
            _Operario = value
        End Set
    End Property

    Public Function ObtenerPatios() As List(Of Patio)
        Return ListaPatios
    End Function

    Public Function ObtenerOperarios() As List(Of Operario)
        Return ListaOperario
    End Function


    '' Metodos para ListaVehiculos
    Function AgregarVehiculo(vehiculo As VehiculoTest) As Boolean
        If Not ExisteVinEnLista(vehiculo.Vin) Then
            ListaVehiculos.Add(vehiculo)
            Return True
        End If
        Return False
    End Function

    Public Function ObtenerPatio(patID As Integer) As Patio
        For Each patio As Patio In ListaPatios
            If patio.PatioId = patID Then
                Return patio
            End If
        Next
        Return Nothing
    End Function

    Public Function ObtenerUbicacion(ubID As Integer) As Ubicacion
        For Each ubicacion As Ubicacion In ListaUbicaciones
            If ubicacion.UbicaionId = ubID Then
                Return ubicacion
            End If
        Next
        Return Nothing
    End Function

    Function ObtenerVehiculos() As List(Of VehiculoTest)
        Return ListaVehiculos
    End Function

    Public Function ObtenerOperario() As Operario
        Return Operario
    End Function

    Function ObtenerOperario(id As String) As Operario
        For Each item As Operario In ListaOperario
            If String.Equals(item.OperarioID.ToString, id) Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    Public Function GenerateInspeccionId() As Object
        Dim max = 0
        For Each inspeccion As Inspeccion In ListaInspecciones
            If inspeccion.InspeccionID > max Then
                max = inspeccion.InspeccionID
            End If
        Next

        Return (max + 1)
    End Function

    Function ExisteVinEnLista(func As String) As Boolean
        If ListaVehiculos.Count() <> 0 Then
            For Each item As VehiculoTest In ListaVehiculos
                If String.Equals(item.Vin, func) Then
                    Return True
                End If
            Next
        Else
            Return False
        End If
        Return False
    End Function

    Public Function GenerateLoteID() As Integer
        Dim max = 0
        For Each lote As Lote In ListaLotes
            If lote.LoteID > max Then
                max = lote.LoteID
            End If
        Next

        Return (max + 1)
    End Function

    Public Function GenerarUbicacionId() As Integer
        Dim max = 0
        For Each ubicacion As Ubicacion In ListaUbicaciones
            If ubicacion.UbicaionId > max Then
                max = ubicacion.UbicaionId
            End If
        Next

        Return (max + 1)
    End Function

    Public Sub AgregarPatio(patio As Patio)
        ListaPatios.Add(patio)
    End Sub

    Function BuscarVinEnLista(func As String) As VehiculoTest
        If ListaVehiculos.Count() <> 0 Then
            For Each item In ListaVehiculos
                If item.Vin.Contains(func) Then
                    Return item
                End If
            Next
        Else
            Return Nothing
        End If
        Return Nothing
    End Function

    Function ObtenerListaVin(func As String) As List(Of VehiculoTest)
        Dim NewListaVehiculos = New List(Of VehiculoTest)

        If ListaVehiculos.Count() <> 0 Then

            For Each item In ListaVehiculos
                If item.Vin.Contains(func) Then
                    NewListaVehiculos.Add(item)
                End If
            Next
        End If
        Return NewListaVehiculos
    End Function

    Public Sub AgregarUbicacion(ubicacion As Ubicacion)
        ListaUbicaciones.Add(ubicacion)
    End Sub

    Function ObtenerListaLoteID(func As String) As List(Of Lote)
        Dim NewListaLotes = New List(Of Lote)

        If ListaVehiculos.Count() <> 0 Then

            For Each item As Lote In ListaLotes
                If item.LoteID.ToString.Contains(func) Then
                    NewListaLotes.Add(item)
                End If
            Next
        End If
        Return NewListaLotes
    End Function

    Function ObtenerLoteID(func As String) As Lote
        Dim lote As Lote

        If ListaVehiculos.Count() <> 0 Then

            For Each item As Lote In ListaLotes
                If String.Equals(item.LoteID.ToString, func) Then
                    lote = item
                End If
            Next
        End If
        Return lote
    End Function

    Function BuscarMarcaEnLista(func As String) As List(Of VehiculoTest)
        Dim NewListaVehiculos = New List(Of VehiculoTest)

        If ListaVehiculos.Count() <> 0 Then
            For Each item In ListaVehiculos
                If String.Equals(item.Marca, func) Then
                    NewListaVehiculos.Add(item)
                End If
            Next

            Return ListaVehiculos
        End If

        Return ListaVehiculos
    End Function

    Function BuscarModeloEnLista(func As String) As List(Of VehiculoTest)

        Dim listaVehiculos = New List(Of VehiculoTest)

        If listaVehiculos.Count() <> 0 Then
            For i As Integer = 0 To listaVehiculos.Count - 1
                If DirectCast(listaVehiculos(i), VehiculoTest).Modelo.Contains(func) Then
                    listaVehiculos.Add(listaVehiculos(i))
                End If
            Next
            Return listaVehiculos
        Else
            Return Nothing
        End If
        Return Nothing
    End Function

    '' Metodos para ListaLotes
    Sub AgregarLote(lote As Lote)
        If Not ListaLotes.Contains(lote) Then
            ListaLotes.Add(lote)
        Else
            Debug.WriteLine("Err: Ya existe ese lote.")
        End If
    End Sub

    Sub AgregarOperario(operario As Operario)
        ListaOperario.Add(operario)
    End Sub

    Function ObtenerLotes() As List(Of Lote)
        Return ListaLotes
    End Function

    '' Metodos para ListaInpecciones
    Sub AgregarInspeccion(inspeccion As Inspeccion)
        ListaInspecciones.Add(inspeccion)
    End Sub

    Function ExisteInspeccionID(func As Integer) As Boolean
        If ListaInspecciones.Count() <> 0 Then
            For i As Integer = 0 To ListaInspecciones.Count - 1
                If DirectCast(ListaInspecciones(i), Inspeccion).InspeccionID = func Then
                    Return True
                End If
            Next
        Else
            Return False
        End If
        Return False
    End Function

    Function ObtenerInspecciones() As List(Of Inspeccion)
        Return ListaInspecciones
    End Function

    Function ObtenerInspeccion(InspeccionID As Integer) As Inspeccion
        For Each inspeccion As Inspeccion In ListaInspecciones
            If InspeccionID = inspeccion.InspeccionID Then
                Return inspeccion
            End If
        Next
        Return Nothing
    End Function

    Function ObtenerInspeccionVin(VIN As String) As Inspeccion
        For Each inspeccion As Inspeccion In ListaInspecciones
            If VIN = inspeccion.VehiculoVin Then
                Return inspeccion
            End If
        Next
        Return Nothing
    End Function
End Class