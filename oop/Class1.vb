Imports Serilog

Public Class Class1
    Public Sub n()
        Log.Logger = New LoggerConfiguration().WriteTo.Seq("http://localhost:5341", bufferBaseFilename:="C:\MyApp\Logs\myapp").CreateLogger()
    End Sub
End Class
