Imports DB
Imports Logica
Imports Serilog

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
        Log.Logger = New LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo.File("logs\\log_.txt", rollingInterval:= RollingInterval.Day).CreateLogger()
#If DEBUG Then
        Dim result As Integer = MessageBox.Show("Si => Cargar datos (usa objetos y es inestable)" + Environment.NewLine + "No => Usar VM de INFROMIX", "Cargar Datos de Prueba?", MessageBoxButtons.YesNo)
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

        Log.Information(Me.Name.ToString + " Loaded.")
    End Sub

    Friend Sub ChangeControlSummary(operarioId As Integer, Conexion As ODBC)
#If DEBUG Then
        If ModoDatos = 0
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