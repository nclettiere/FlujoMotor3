Imports DB
Imports Logica

Public Class Ventanita_Login
    Private OperarioId As Integer
    Private Conexion As ODBC

    Private _ModoDatos As Integer = 0

    Public Property ModoDatos As Integer
        Get
            Return _ModoDatos
        End Get
        Set(value As Integer)
            _ModoDatos = value
        End Set
    End Property

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#If DEBUG Then
        Dim result As Integer = MessageBox.Show("Desea cargar datos de prueba? Lord, Recuerde que debe ejecutar el proceso en x64 o en x86 dependiendo del driver ODBC de Informix. (No usar Any CPU)", "MODO DEBUG DETECTADO", MessageBoxButtons.YesNoCancel)
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
        If ModoDatos =  0
            Dim mainVentana = New Menu
            Hide()
            mainVentana.Conexion = Conexion
            mainVentana.ShowDialog()
            Close()
        Else
            Dim mainVentana = New Menu
            Hide()
            mainVentana.Conexion = Conexion
            mainVentana.ShowDialog()
            Close()
        End If
        
#Else
        Dim mainVentana = New Ventanita_Ver
        mainVentana.Show()
        Hide()
#End If
    End Sub
End Class