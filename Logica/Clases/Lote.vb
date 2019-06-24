﻿Imports Test

Public Class Lote

    Private _LoteID As Integer
    Private _LoteName As String
    Private _LoteDesc As String
    Private _Vehiculos As List(Of String)
    Private _Fecha As Date
    Private _FuncionarioID As String

    Public Sub New(LoteID As Integer, LoteName As String, LoteDesc As String, Vehiculos As List(Of String), Fecha As Date, FuncionarioID As String)
        _LoteID = LoteID
        _LoteName = LoteName
        _LoteDesc = LoteDesc
        _Vehiculos = Vehiculos
        _Fecha = Fecha
        _FuncionarioID = FuncionarioID
    End Sub

    Public Property LoteID As Integer
        Get
            Return _LoteID
        End Get
        Set(value As Integer)
            _LoteID = value
        End Set
    End Property

    Public Property Vehiculos As List(Of String)
        Get
            Return _Vehiculos
        End Get
        Set(value As List(Of String))
            _Vehiculos = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property FuncionarioID As String
        Get
            Return _FuncionarioID
        End Get
        Set(value As String)
            _FuncionarioID = value
        End Set
    End Property

    Public Property LoteName As String
        Get
            Return _LoteName
        End Get
        Set(value As String)
            _LoteName = value
        End Set
    End Property

    Public Property LoteDesc As String
        Get
            Return _LoteDesc
        End Get
        Set(value As String)
            _LoteDesc = value
        End Set
    End Property
End Class