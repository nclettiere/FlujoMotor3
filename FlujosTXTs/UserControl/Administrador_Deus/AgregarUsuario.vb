Imports Logica
Imports Logica.Encriptacion

Public Class AgregarUsuario
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If CheckCampos
                If Disponibilidad(tbxUsername.Text)
                    Dim Usuario = tbxUsername.Text
                    Dim Nombre = tbxUsername.Text
                    Dim Apellido = tbxUsername.Text
                    Dim Telefono = tbxUsername.Text
                    Dim hashSalt As HashySalt = GenerarHash(64, tbxPswd.Text)
                    Dim UsuarioTipo As Integer = 0

                    If rbOpPuerto.Checked
                        UsuarioTipo = 0
                    Else If rbOpPatio.Checked
                        UsuarioTipo = 1
                    ElseIf rbOpTransportista.Checked
                        UsuarioTipo = 2
                    ElseIf rbAdmin.Checked
                        UsuarioTipo = 3
                    End If




                Else
                    MsgBox("El usuario elegido ya existe.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al Ingresar usuario. Chequee el log para mas info.")
            Serilog.Log.Error(ex, "Error al Ingresar usuario.")
        End Try
    End Sub

    Protected Function CheckCampos As Boolean
        If Not String.IsNullOrWhiteSpace(tbxUsername.Text)
            If Not String.IsNullOrWhiteSpace(tbxNombre.Text)
                If Not String.IsNullOrWhiteSpace(tbxApell.Text)
                    If Not String.IsNullOrWhiteSpace(tbxTel.Text)
                        If Not String.IsNullOrWhiteSpace(tbxPswd.Text)
                            If rbOpPuerto.Checked Or rbOpPatio.Checked Or rbOpTransportista.Checked Or rbAdmin.Checked
                                Return True
                            Else
                                MsgBox("Debes seleccionar un rol para el usuario.")
                                Return False
                            End If
                        Else
                            MsgBox("Debes ingresar una contrasena.")
                            Return False
                        End If
                    Else
                        MsgBox("Debes ingresar un telefono.")
                        Return False
                    End If
                Else
                    MsgBox("Debes ingresar un apellido.")
                    Return False
                End If
            Else
                MsgBox("Debes ingresar un nombre.")
                Return False
            End If
        Else
            MsgBox("Debes ingresar un usuario.")
            Return False
        End If
    End Function
End Class
