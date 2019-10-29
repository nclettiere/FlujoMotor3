
'' Option Infer Off, para hacer dynamic cast. Vease variable LANG
Option Infer Off

Imports System.IO
Imports YamlDotNet.Serialization
Imports YamlDotNet.Serialization.NamingConventions

Public Class LangManager

    Public Function ObtenerKey(Key As String, Index As String) As String
        Dim deserializer = New DeserializerBuilder().WithNamingConvention(New CamelCaseNamingConvention()).Build()
        Dim result = deserializer.Deserialize(Of List(Of String))(File.OpenText(IdiomaDir))

        If result IsNot Nothing
            Return result.Item(Index)
        Else
            Serilog.Log.Fatal("FATAL: LA LISTA DE IDIOMAS RETORNO NUL")
            Return String.Empty
        End If

    End Function
End Class
