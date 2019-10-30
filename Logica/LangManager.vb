Imports System
Imports System.IO
Imports Newtonsoft.Json

Public Class LangManager

    Public Function ObtenerKey(Key As String, Index As String) As String

        Dim videogames As List(Of Dictionary(Of String, String)) = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(IdiomaDir)
        
        For Each Item In videogames
            Console.WriteLine(videogames("Titulo"))
        Next

        Return Nothing
    End Function
End Class