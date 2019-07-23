Imports Logica
Imports oop

Public Class PreviewLote

    Private parent As Summary
    Private facade As Facade

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myBrush As SolidBrush = New SolidBrush(Color.Red)
        Dim FormGraphics As Graphics
        FormGraphics = Me.CreateGraphics()
        FormGraphics.FillEllipse(myBrush, New Rectangle(0, 0, 200, 300))
        myBrush.Dispose()
        FormGraphics.Dispose()
    End Sub

    Friend Sub cargar(summary As Summary, facade As Facade, index As Integer)
        parent = summary
        Me.facade = facade
        lbl_Display.Text = "#" + index.ToString
    End Sub
End Class
