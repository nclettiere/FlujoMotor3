Public Class SeleccionarCSV

    Private PathOperarios As String
    Private PathVehiculos As String
    Private PathPatios As String
    Private PathUbicaciones As String
    Private PathInspecciones As String

    Private SetOperarios As Boolean = False
    Private SetVehiculos As Boolean = False
    Private SetPatios As Boolean = False
    Private SetUbicaciones As Boolean = False
    Private SetInspecciones As Boolean = False

    Private InicioDeSesion As Inicio_de_sesion

    Sub Cargar(Parent As Inicio_de_sesion)
        Me.InicioDeSesion = Parent
    End Sub

    Private Sub btn_op_Click(sender As Object, e As EventArgs) Handles btn_op.Click
        AbrirCSV.Title = "Seleccionar el CSV de Operarios"
        AbrirCSV.InitialDirectory = Application.StartupPath + "\CSV\"
        AbrirCSV.Filter = "CSV Files|*.csv"

        If AbrirCSV.ShowDialog() = DialogResult.OK Then
            PathOperarios = AbrirCSV.FileName
        End If

        SetOperarios = True

        If SetOperarios And SetVehiculos And SetPatios And SetUbicaciones And SetInspecciones Then
            btn_aceptar.Enabled = True
        End If
    End Sub

    Private Sub btn_ve_Click(sender As Object, e As EventArgs) Handles btn_ve.Click
        AbrirCSV.Title = "Seleccionar el CSV de Vehiculos"
        AbrirCSV.InitialDirectory = Application.StartupPath + "\CSV\"
        AbrirCSV.Filter = "CSV Files|*.csv"

        If AbrirCSV.ShowDialog() = DialogResult.OK Then
            PathVehiculos = AbrirCSV.FileName
        End If

        SetVehiculos = True

        If SetOperarios And SetVehiculos And SetPatios And SetUbicaciones And SetInspecciones Then
            btn_aceptar.Enabled = True
        End If
    End Sub

    Private Sub btn_pa_Click(sender As Object, e As EventArgs) Handles btn_pa.Click
        AbrirCSV.Title = "Seleccionar el CSV de Patios"
        AbrirCSV.InitialDirectory = Application.StartupPath + "\CSV\"
        AbrirCSV.Filter = "CSV Files|*.csv"

        If AbrirCSV.ShowDialog() = DialogResult.OK Then
            PathPatios = AbrirCSV.FileName
        End If

        SetPatios = True

        If SetOperarios And SetVehiculos And SetPatios And SetUbicaciones And SetInspecciones Then
            btn_aceptar.Enabled = True
        End If

    End Sub

    Private Sub btn_ub_Click(sender As Object, e As EventArgs) Handles btn_ub.Click
        AbrirCSV.Title = "Seleccionar el CSV de Ubicaciones"
        AbrirCSV.InitialDirectory = Application.StartupPath + "\CSV\"
        AbrirCSV.Filter = "CSV Files|*.csv"

        If AbrirCSV.ShowDialog() = DialogResult.OK Then
            PathUbicaciones = AbrirCSV.FileName
        End If

        SetUbicaciones = True

        If SetOperarios And SetVehiculos And SetPatios And SetUbicaciones And SetInspecciones Then
            btn_aceptar.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirCSV.Title = "Seleccionar el CSV de Inspecciones"
        AbrirCSV.InitialDirectory = Application.StartupPath + "\CSV\"
        AbrirCSV.Filter = "CSV Files|*.csv"

        If AbrirCSV.ShowDialog() = DialogResult.OK Then
            PathInspecciones = AbrirCSV.FileName
        End If

        SetInspecciones = True

        If SetOperarios And SetVehiculos And SetPatios And SetUbicaciones And SetInspecciones Then
            btn_aceptar.Enabled = True
        End If
    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        InicioDeSesion.cargar(PathOperarios, PathVehiculos, PathPatios, PathUbicaciones, PathInspecciones)
        Me.Close()
    End Sub
End Class