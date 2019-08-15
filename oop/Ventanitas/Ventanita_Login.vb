Imports DB
Imports Logica

Public Class Ventanita_Login
    Private OperarioId As Integer
    Private Conexion As ODBC

    Private ModoDatos As Integer = 0

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#If DEBUG Then
        Dim result As Integer = MessageBox.Show("Desea cargar datos de prueba?", "MODO DEBUG DETECTADO", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Or result = DialogResult.Abort Then
            MessageBox.Show("Ha cancelado, se cargaran los datos de la VM de INFORMIX.")
            ModoDatos = 0
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("Se cargaran los datos de prueba.")
            ModoDatos = 1
        Else
            MessageBox.Show("Se cargaran los datos de la VM de INFORMIX.")
            ModoDatos = 0
        End If
#End If

        If Not MainContent.Contains(Login.Instance) Then
            MainContent.Controls.Add(Login.Instance)
            Login.Instance.Dock = DockStyle.Fill
            Login.Instance.BringToFront()
        Else
            Login.Instance.BringToFront()
        End If

    End Sub

    Friend Sub ChangeControlSummary(operarioId As Integer, Conexion As ODBC)
#If DEBUG Then
        Dim mainVentana = New Ventanita_Ver
        Hide()
        mainVentana.ShowDialog()
        Close()
#Else
        Dim mainVentana = New Ventanita_Ver
        mainVentana.Show()
        Hide()
#End If
    End Sub
End Class