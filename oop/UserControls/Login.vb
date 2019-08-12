﻿Imports Logica
Imports DB

Public Class Login

    Private Shared _instance As Login

    Private Usuarios As List(Of Operario)

    Private facade As Facade
    Private main As MainWindow

    Private OperarioId As Integer

    Public Shared Property Instance As Login
        Get
            If _instance Is Nothing Then
                _instance = New Login()
            End If
            Return _instance
        End Get
        Set(value As Login)
            _instance = value
        End Set
    End Property

    Private Sub Btn_LogIn_Click_1(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        Dim Conexion As ODBC = New ODBC()

        Conexion.USER = tbx_user.Text
        Conexion.PWD = tbx_passwd.Text

        Dim isConnected = Conexion.Conectar(Conexion.Conectar())
        If (isConnected) Then
            ''Conexion.Hacer_consulta("Select * FROM Personas")
            MessageBox.Show("Conectado Exitosamente.")
            MainWindow.ChangeControlSummary(0, Conexion)
        Else
            MessageBox.Show("Usuario o Contrasena invalidos.")
        End If

    End Sub
End Class
