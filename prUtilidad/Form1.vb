Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Declarando variables
        Dim salario As Double
        Dim antiguedad As Byte
        Dim utilidad As Double

        'Entrada de datos
        salario = Val(txtSalario.Text)
        antiguedad = Val(cboxAntiguedad.Text)

        'Proceso
        If (antiguedad < 1) Then
            utilidad = salario * 5 / 100
        ElseIf (antiguedad >= 1 And antiguedad < 2) Then
            utilidad = salario * 7 / 100
        ElseIf (antiguedad >= 2 And antiguedad < 5) Then
            utilidad = salario * 10 / 100
        ElseIf (antiguedad >= 5 And antiguedad < 10) Then
            utilidad = salario * 15 / 100
        ElseIf (antiguedad >= 10) Then
            utilidad = salario * 20 / 100
        End If

        'Salida de Información
        txtUtilidad.Text = utilidad

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtSalario.Clear()
        cboxAntiguedad.Text = 0
        txtUtilidad.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub
End Class
