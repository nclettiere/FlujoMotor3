﻿Imports oop

Public Class Ventanita_Ver
    Private Sub Ventanita_Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub LoadControl(verVehiculo As Ver_Vehiculillo)
        mainContent.Controls.Add(verVehiculo)
        verVehiculo.AutoSize = True
        Me.ClientSize = verVehiculo.Size
    End Sub

    Friend Sub LoadControl(verLote As Ver_Lotesillo)
        mainContent.Controls.Add(verLote)
        verLote.AutoSize = True
        Me.ClientSize = verLote.Size
    End Sub

    Friend Sub LoadControl(verFoto As Ver_Foto)
        mainContent.Controls.Add(verFoto)
        verFoto.AutoSize = True
        Me.ClientSize = verFoto.Size
    End Sub

    ''' <summary>
    ''' Metodo usado para cambiar dinamicamente el contenido del MainContent
    ''' </summary>
    ''' <param name="Section">Integer que especifica el ID de la seccion.</param>
    Friend Sub GoToSection(ByVal Section As Integer)
        '' Section => {0=>"VerVehiculos";1=>AgregarVehiculos};

        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = Ver_Inspeccionsilla.Instance
            Case 1
                Selection = Ver_Vehiculillo.Instance
            Case Else
                Selection = Ver_Inspeccionsilla.Instance
        End Select

        If Not mainContent.Contains(Selection) Then
            MainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

        Friend Sub GoToSection(ByVal Section As Integer, ByVal VIN As String, ByRef Conexion As DB.ODBC)
            Dim Selection As Object

            Select Case Section
                Case 0
                    Selection = Ver_Inspeccionsilla.Instance
                    Ver_Inspeccionsilla.Instance.FormParent = Me
                    Ver_Inspeccionsilla.Instance.Populate(VIN, Conexion)
                Case 1
                    Selection = Agregar_Inspeccion.Instance
                    Agregar_Inspeccion.Instance.FormParent = Me
                    Agregar_Inspeccion.Instance.CargarDatos(VIN, Conexion)
                Case Else
                    Selection = Ver_Inspeccionsilla.Instance
            End Select

            If Not mainContent.Contains(Selection) Then
                MainContent.Controls.Add(Selection.Instance)
                Selection.Instance.Dock = DockStyle.Fill
                Selection.Instance.BringToFront()
            Else
                Selection.Instance.BringToFront()
            End If
        End Sub
End Class