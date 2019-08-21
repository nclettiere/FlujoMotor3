Imports DB
Imports oop
Imports Serilog

Public Class Ver_Vehiculillo

    Private Shared _instance As Ver_Vehiculillo

    Public Shared Property Instance As Ver_Vehiculillo
        Get
            If _instance Is Nothing Then
                _instance = New Ver_Vehiculillo()
            End If
            Return _instance
        End Get
        Set(value As Ver_Vehiculillo)
            _instance = value
        End Set
    End Property

    Private Property InfoAutos As Info_de_Autillos

    Friend Sub Data(info_de_Autillos As Info_de_Autillos, vin As String, ByRef Conexion As ODBC)
        InfoAutos = info_de_Autillos
        Dim resultado As DataTable = Conexion.consultar("SELECT * FROM vehiculos WHERE vehiculovin='" + vin + "'")

        Dim logg = New LoggerConfiguration()
        ''With logg
        ''    .WriteTo.Console()
        ''    .WriteTo.Seq("http://localhost:5341")
        ''    .CreateLogger()
        ''End With
            
        ''Log.Information("Hello, Serilog!")
        
        ''Log.CloseAndFlush();

        lblVin.Text = resultado.Rows(0).Item(0)
    End Sub
End Class
