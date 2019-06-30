Imports System.ComponentModel

Public Class Form1
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0 And txtSalario.Text <> String.Empty Then
                MessageBox.Show("Datos registrados correctamente", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingrese correctamente algunos datos remarcados", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre, este dato es obligatorio")
        End If
    End Sub

    Private Sub TxtSalario_TextChanged(sender As Object, e As EventArgs) Handles txtSalario.TextChanged

    End Sub

    Private Sub txtSalario_Validating(sender As Object, e As CancelEventArgs) Handles txtSalario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el salario, este dato es obligatorio")
        End If
    End Sub
    Private Sub TxtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub
    Private Sub TxtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If (Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0) Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese una edad válida, este dato es obligatorio")
        End If
    End Sub

    Private Sub LblSalir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSalir.LinkClicked
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Clear()
        txtEdad.Clear()
        txtSalario.Clear()
        txtDesc.Clear()
    End Sub

End Class
