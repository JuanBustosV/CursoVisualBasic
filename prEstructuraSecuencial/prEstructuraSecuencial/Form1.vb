Public Class Form1
    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'Declaración de la constante
        Const pi As Double = 3.14159
        'Declaración de las variables
        Dim radio As Double
        Dim area As Double
        'Entrada de datos
        radio = Val(txtradio.Text)
        'Proceso
        area = pi * radio ^ 2
        'Salida de la información
        txtarea.Text = area

    End Sub
End Class
