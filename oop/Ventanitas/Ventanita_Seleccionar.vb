Public Class Ventanita_Seleccionar

    ''' <summary>
    ''' Metodo usado para cambiar dinamicamente el contenido del MainContent
    ''' </summary>
    ''' <param name="Section">Integer que especifica el ID de la seccion.</param>
    Friend Sub GoToSection(ByVal Section As Integer)
        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = Agregar_Lotesillo.Instance
                Agregar_Lotesillo.FormParent = Me
            Case 1
                Selection = Seleccionar_Vehiculillo.Instance
                Selection.FormParent = Me
            Case 2
                Selection = Seleccionar_Lotesillo.Instance
                Selection.FormParent = Me
                
            Case Else
                Selection = Agregar_Lotesillo.Instance
        End Select

        If Not mainContent.Contains(Selection) Then
            MainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

    Friend Sub GoToSection(ByVal Section As Integer, Parent As Object)
        Dim Selection As Object
        Select Case Section
            Case 0
                Selection = Agregar_Lotesillo.Instance
                Agregar_Lotesillo.FormParent = Me
            Case 1
                Selection = Seleccionar_Vehiculillo.Instance
                Selection.FormParent = DirectCast(Parent, Agregar_Lotesillo)
                
            Case Else
                Selection = Agregar_Lotesillo.Instance
        End Select

        If Not mainContent.Contains(Selection) Then
            MainContent.Controls.Add(Selection.Instance)
            Selection.Instance.Dock = DockStyle.Fill
            Selection.Instance.BringToFront()
        Else
            Selection.Instance.BringToFront()
        End If
    End Sub

End Class