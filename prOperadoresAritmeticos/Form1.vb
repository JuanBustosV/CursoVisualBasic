Public Class Form1
    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        '(Alt + 39)
        'Declaración de variables
        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma, resta, mult As Integer
        Dim div As Double
        Dim potencia As Integer
        Dim raiz As Double

        'Entrada de datos
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)

        'Proceso
        suma = num1 + num2
        resta = num1 - num2
        mult = num1 * num2
        div = num1 / num2
        potencia = num1 ^ num2
        raiz = num1 ^ (1 / num2)

        'Salida de Información
        txtsuma.Text = suma
        txtresta.Text = resta
        txtmult.Text = mult
        txtdivision.Text = div
        txtpotencia.Text = potencia
        txtraiz.Text = raiz

    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnum1.Clear()
        txtnum2.Clear()
        txtsuma.Clear()
        txtresta.Clear()
        txtmult.Clear()
        txtdivision.Clear()
        txtpotencia.Clear()
        txtraiz.Clear()

    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End

    End Sub
End Class
