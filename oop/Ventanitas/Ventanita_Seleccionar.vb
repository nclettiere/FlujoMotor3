Public Class Ventanita_Seleccionar

    ''' <summary>
    ''' Metodo usado para cambiar dinamicamente el contenido del MainContent
    ''' </summary>
    ''' <param name="Section">Integer que especifica el ID de la seccion.</param>
        Friend Sub GoToSection(ByVal Section As Integer)
        '' Section => {0=>"VerVehiculos";1=>AgregarVehiculos};

        Dim Selection As Object

        Select Case Section
            Case 0
                Selection = Agregar_Lotesillo.Instance
            Case 1
                Selection = Seleccionar_Vehiculillo.Instance
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