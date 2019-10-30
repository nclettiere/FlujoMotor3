Public Module Idiomas
    Public DirectorioIdioma

    Public IdiomaDir As String

    Public Sub SetDirectorioIdioma(Locale As String, App As String)

        Dim Directorio As String = My.Application.Info.DirectoryPath

        Select Locale
            Case "es-UY"
                IdiomaDir = Directorio + "\App\Locales\"+ App +"_es-UY.json"
            Case "en-GB"
                IdiomaDir = Directorio + "\App\Locales\"+ App +"_en-GB.json"
            Case Else
                IdiomaDir = Directorio + "\App\Locales\"+ App +"_es-UY.json"
        End Select
    End Sub
End Module
