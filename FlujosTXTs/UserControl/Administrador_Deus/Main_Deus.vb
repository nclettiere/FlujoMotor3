﻿Imports Logica
Imports BrightIdeasSoftware

Public Class Main_Deus

    Private Sub OnMenuLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateLang()

        pnContenido.Controls.Clear()
        Dim MU As ManageUsuarios = New ManageUsuarios
        MU.Dock = DockStyle.Fill
        pnContenido.Controls.Add(MU)
    End Sub

    Private Sub BtOperario_Click(sender As Object, e As EventArgs) Handles btOperario.Click
        pnContenido.Controls.Clear
        Dim MU As ManageUsuarios = New ManageUsuarios
        MU.Dock = DockStyle.Fill
        pnContenido.Controls.Add(MU)
    End Sub

    Private Sub Btvehiculos_Click_1(sender As Object, e As EventArgs) Handles btvehiculos.Click
        pnContenido.Controls.Clear
        Dim VL As VehiculosLotes = New VehiculosLotes
        VL.Dock = DockStyle.Fill
        pnContenido.Controls.Add(VL)
    End Sub

    Private Sub Btnpatioszonas_Click(sender As Object, e As EventArgs) Handles btnpatioszonas.Click
        pnContenido.Controls.Clear
        Dim PZ As PatiosZonas = New PatiosZonas
        PZ.Dock = DockStyle.Fill
        pnContenido.Controls.Add(PZ)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim result As Integer = MessageBox.Show("Deseas salir de la aplicacion?", "Salir", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ParentForm.Close
        End If
    End Sub

    Protected _Lang As LangManager = New LangManager
    Protected Sub UpdateLang()
        ParentForm.Text = _Lang.ObtenerKey("Main", 0)
        btOperario.Text = _Lang.ObtenerKey("Main", 1)
        btvehiculos.Text = _Lang.ObtenerKey("Main", 2)
        btnpatioszonas.Text = _Lang.ObtenerKey("Main", 3)
        btnSalir.Text = _Lang.ObtenerKey("Main", 4)
    End Sub
End Class
