Public Class Form1
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Declaración de variables
        Dim edades(7) As Integer 'vector
        ' Inicializando vector al declararlo.
        Dim edades2 = New Integer() {14, 20, 80, 17, 16, 29, 25} 'no se usa, solo ejemplo

        'Almacenar valores en el vector
        edades(0) = 14
        edades(1) = 20
        edades(2) = 80
        edades(3) = 17
        edades(4) = 16
        edades(5) = 29
        edades(6) = 25

        Dim suma As Integer ' = 0
        Dim promedio As Double

        'Proceso
        For i As Integer = 0 To 6 Step 1
            'Mostrar las edades
            cboEdades.Items.Add(edades(i))
            suma += edades(i)
        Next
        promedio = suma / 7

        'Salida de la información
        txtPromedio.Text = promedio

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboEdades.Items.Clear()
        txtPromedio.Clear()

    End Sub
End Class
