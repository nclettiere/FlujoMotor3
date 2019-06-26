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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        FolderBrowserDialog1.SelectedPath = Application.StartupPath + "\CSV\"
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            btn_aceptar.Enabled = True
        End If
    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Not System.IO.Directory.Exists(TextBox1.Text) Then
            MessageBox.Show(TextBox1.Text)
            MessageBox.Show("Error: La ruta no existe.")
        ElseIf Not System.IO.File.Exists(TextBox1.Text + "\operarios.csv") Then
            MessageBox.Show("Error: CSV 'operarios.csv' no encontrado.")
        ElseIf Not System.IO.File.Exists(TextBox1.Text + "\vehiculos.csv") Then
            MessageBox.Show("Error: CSV 'vehiculos.csv' no encontrado.")
        ElseIf Not System.IO.File.Exists(TextBox1.Text + "\patios.csv") Then
            MessageBox.Show("Error: CSV 'patios.csv' no encontrado.")
        ElseIf Not System.IO.File.Exists(TextBox1.Text + "\ubicaciones.csv") Then
            MessageBox.Show("Error: CSV 'ubicaciones.csv' no encontrado.")
        ElseIf Not System.IO.File.Exists(TextBox1.Text + "\inspecciones.csv") Then
            MessageBox.Show("Error: CSV 'inspecciones.csv' no encontrado.")
        ElseIf Not System.IO.File.Exists(TextBox1.Text + "\clientes.csv") Then
            MessageBox.Show("Error: CSV 'inspecciones.csv' no encontrado.")
        Else
            InicioDeSesion.cargar(TextBox1.Text)
            InicioDeSesion.Show()
            Me.Close()
        End If
    End Sub
End Class