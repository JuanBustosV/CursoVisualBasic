Public Class frmPromedio
    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'Declaración de variables
        Dim notaa As Byte
        Dim notab As Byte
        Dim notac As Byte
        Dim promedio As Single
        Dim situacion As String

        'Entrada de datos
        notaa = Val(txtnotaa.Text)
        notab = Val(txtnotab.Text)
        notac = Val(txtnotac.Text)

        'Proceso
        promedio = (notaa * 3 + notab * 4 + notac * 2) / 9

        'Evaluamos siu situación

        If promedio >= 10.5 Then 'Se puede simplificar el if
            situacion = "Aprobado"
        Else
            situacion = "Suspendido"
        End If

        'Salida de Información
        txtpromedio.Text = promedio
        txtsituacion.Text = situacion

    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnotaa.Clear()
        txtnotab.Clear()
        txtnotac.Clear()
        txtpromedio.Clear()
        txtsituacion.Clear()

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End

    End Sub
End Class