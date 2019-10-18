Imports System.IO
Imports System.Reflection
Imports Gecko

Public Class VerPatio
    Private Sub VerPatio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GeckoPreferences.User("geo.enabled") = True
        GeckoPreferences.User("browser.search.geoip.url") = "https://www.googleapis.com/geolocation/v1/geolocate?key=AIzaSyDfBZmfpEwPe6mUM-KacKOluqHq-sudoS8"
        GeckoWebBrowser3.navigate("https://www.google.com/maps/dir/Montevideo,+Montevideo+Department/Canstatt+3052,+11600+Montevideo,+Departamento+de+Montevideo/")
    End Sub
End Class
