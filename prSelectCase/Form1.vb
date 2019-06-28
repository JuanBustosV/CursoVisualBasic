Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Declaración de variables
        Dim num As Integer
        Dim dia As String

        'Entrada de datos
        num = Val(txtNum.Text)

        'Proceso
        Select Case (num)
            Case 1
                dia = "Lunes"
            Case 2
                dia = "Martes"
            Case 3
                dia = "Miércoles"
            Case 4
                dia = "Jueves"
            Case 5
                dia = "Viernes"
            Case 6
                dia = "Sábado"
            Case 7
                dia = "Domingo"
            Case Else
                dia = "¡Error! intente con un nuevo número"
        End Select

        'Salida de la información
        txtDia.Text = dia

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtDia.Clear()
        txtNum.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub
End Class
