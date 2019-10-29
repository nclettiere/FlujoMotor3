Public Module Idiomas
    Public DirectorioIdioma

    Public IdiomaDir As String

    Public Sub SetDirectorioIdioma(Locale As String, App As String)

        Dim Directorio As String = My.Application.Info.DirectoryPath

        Select Locale
            Case "es-UY"
                IdiomaDir = Directorio + "\App\Locales\"+ App +"_es-UY.yaml"
                MsgBox(IdiomaDir)
            Case "en-GB"
                IdiomaDir = Directorio + "\App\Locales\"+ App +"_en-GB.yaml"
                MsgBox(IdiomaDir)
            Case Else
                IdiomaDir = Directorio + "\App\Locales\"+ App +"_es-UY.yaml"
        End Select
    End Sub
End Module
