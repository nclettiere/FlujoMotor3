Imports System
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class LangManager

    Public Function ObtenerKey(Key As String, Index As Integer) As String


        Try
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(IdiomaDir)

            Dim googleSearch As JObject = JObject.Parse(fileReader)
            Dim results As IList(Of JToken) = googleSearch(Key).Children().ToList()

            If results IsNot Nothing
                Return results.Item(Index)
            Else
                Return "Err"
            End If
        Catch ex As Exception
            Serilog.Log.Fatal(ex, "Error al obtener paquete de idioma.")
            Return "Err"
        End Try
    End Function
End Class