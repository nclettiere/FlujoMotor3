Imports System.Security.Cryptography

Public Class Encriptacion
    Public Class HashySalt
        Public Property Hash As String
        Public Property Salt As String
    End Class

    Public Shared Function GenerarHash(tamano As Integer, contrasena As String) As HashySalt
        Dim bytes = New Byte(tamano - 1) {}
        Dim proovedor = New RNGCryptoServiceProvider()
        proovedor.GetNonZeroBytes(bytes)
        Dim salt = Convert.ToBase64String(bytes)
        Dim rfc2898DeriveBytes = New Rfc2898DeriveBytes(contrasena, bytes, 10000)
        Dim hashContrasena = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256))
        Dim hash As HashySalt = New HashySalt With {
            .Hash = hashContrasena,
            .Salt = salt
        }
        Return hash
    End Function
End Class
