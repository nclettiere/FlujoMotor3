﻿Imports oop

Public Class Seleccionar_Vehiculillo
    Private Shared _instance As Seleccionar_Vehiculillo

    Friend _FormParent As Ventanita_Seleccionar

    Public Shared Property Instance As Seleccionar_Vehiculillo
        Get
            If _instance Is Nothing Then
                _instance = New Seleccionar_Vehiculillo()
            End If
            Return _instance
        End Get
        Set(value As Seleccionar_Vehiculillo)
            _instance = value
        End Set
    End Property

    Public Property FormParent As Ventanita_Seleccionar
        Get
            Return _FormParent
        End Get
        Set(value As Ventanita_Seleccionar)
            _FormParent = value
        End Set
    End Property

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        FormParent.GoToSection(0)
    End Sub
End Class