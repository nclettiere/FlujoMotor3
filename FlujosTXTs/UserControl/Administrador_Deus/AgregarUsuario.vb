﻿Imports Logica
Public Class AgregarUsuario

    Friend FormAnterior As ManageUsuarios

    Private Modificando As Boolean = False

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If CheckCampos
                If Not Modificando
                    If Disponibilidad(tbxUsername.Text)
                        Dim Usuario = tbxUsername.Text
                        Dim Nombre = tbxNombre.Text
                        Dim Apellido = tbxApell.Text
                        Dim Telefono = tbxTel.Text
                        Dim UsuarioTipo As Integer = 0

                        If rbOpPuerto.Checked
                            UsuarioTipo = 0
                        Else If rbOpPatio.Checked
                            UsuarioTipo = 1
                        ElseIf rbOpTransportista.Checked
                            UsuarioTipo = 2
                        ElseIf RBAdmin.Checked
                            UsuarioTipo = 3
                        End If

                        If EInsertar(Usuario, Nombre, Apellido, Telefono, UsuarioTipo)
                            MsgBox("Usuario Ingresado Exitosamente.")
                            If FormAnterior IsNot Nothing
                                FormAnterior.ActualizarLista
                                ParentForm.Close
                            Else
                                ParentForm.Close
                            End If
                        End If

                    Else
                        MsgBox("El usuario elegido ya existe.")
                    End If
                Else 
                    Dim Usuario = tbxUsername.Text
                    Dim Nombre = tbxNombre.Text
                    Dim Apellido = tbxApell.Text
                    Dim Telefono = tbxTel.Text
                    Dim UsuarioTipo As Integer = 0

                    If rbOpPuerto.Checked
                        UsuarioTipo = 0
                    Else If rbOpPatio.Checked
                        UsuarioTipo = 1
                    ElseIf rbOpTransportista.Checked
                        UsuarioTipo = 2
                    ElseIf RBAdmin.Checked
                        UsuarioTipo = 3
                    End If

                    If EUpdate(Usuario, Nombre, Apellido, Telefono)
                        MsgBox("Usuario Modificado Exitosamente.")
                        If FormAnterior IsNot Nothing
                            FormAnterior.ActualizarLista
                            ParentForm.Close
                        Else
                            ParentForm.Close
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Serilog.Log.Error(ex, "Error al Ingresar usuario.")
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Function CheckCampos As Boolean
        If Not String.IsNullOrWhiteSpace(tbxUsername.Text)
            If Not String.IsNullOrWhiteSpace(tbxNombre.Text)
                If Not String.IsNullOrWhiteSpace(tbxApell.Text)
                    If Not String.IsNullOrWhiteSpace(tbxTel.Text)
                        If rbOpPuerto.Checked Or rbOpPatio.Checked Or rbOpTransportista.Checked Or RBAdmin.Checked
                            Dim tel As Integer
                            If Integer.TryParse(tbxTel.Text, tel)
                                Return True
                            Else
                                MsgBox("El telefono debe ser numerico.")
                                Return False
                            End If
                        Else
                            MsgBox("Debes seleccionar un rol para el usuario.")
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

    Friend Sub Modificacion(User As String)
        Label1.Text = "Modificar Usuario"
        btnAgregar.Text = "Modificar"
        rbOpPuerto.Visible = False
        rbOpPatio.Visible = False
        rbOpTransportista.Visible = False
        RBAdmin.Visible = False

        tbxUsername.Enabled = False

        Modificando = True

        Dim Usuario As DataTable = UObtener(User)
        If Usuario IsNot Nothing
            If Usuario.Rows.Count > 0
                tbxUsername.Text = Usuario.Rows(0).Item("usuario")
                Dim EmpleadoDatos = EObtener(Usuario.Rows(0).Item("empleadoid"))
                If EmpleadoDatos IsNot Nothing
                    tbxNombre.Text = EmpleadoDatos.Item("empleadoNombre")
                    tbxApell.Text = EmpleadoDatos.Item("empleadoApellido")
                    tbxTel.Text = EmpleadoDatos.Item("empleadotelefono")
                End If
            End If
        End If
    End Sub
End Class
