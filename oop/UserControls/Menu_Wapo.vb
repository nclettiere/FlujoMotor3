Public Class Menu_Wapo

    Private Shared _instance As Menu_Wapo

    Public Shared Property Instance As Menu_Wapo
        Get
            If _instance Is Nothing Then
                _instance = New Menu_Wapo()
            End If
            Return _instance
        End Get
        Set(value As Menu_Wapo)
            _instance = value
        End Set
    End Property

    Private Sub BtPuerto_Click(sender As Object, e As EventArgs) Handles btPuerto.Click
        btPatio.Font = New Font(btPatio.Font.FontFamily, 14)
        piBoPatio.Size = New Size(56, 30)
        btPatio.BackColor = Color.Transparent
        btPuerto.BackColor = Color.DarkGray
        btPuerto.Font = New Font(btPuerto.Font.FontFamily, 17)
        piBoPuerto.Size = New Size(56, 70)

    End Sub

    Private Sub BtPatio_Click(sender As Object, e As EventArgs) Handles btPatio.Click
        btPuerto.Font = New Font(btPuerto.Font.FontFamily, 14)
        piBoPuerto.Size = New Size(56, 30)
        btPuerto.BackColor = Color.Transparent
        btPatio.BackColor = Color.DarkGray
        btPatio.Font = New Font(btPatio.Font.FontFamily, 17)
        piBoPatio.Size = New Size(56, 70)

    End Sub

End Class
