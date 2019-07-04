Public Class Form1
    Private Sub Limpiar()
        cboSuma.Items.Clear()
        cboResta.Items.Clear()
        cboMulti.Items.Clear()
        cboDivision.Items.Clear()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call Limpiar()
        txtNumero.Clear()

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Dejar en blanco los comboboxes
        Call Limpiar()

        'Declaración de variables
        Dim num As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multi As Integer
        Dim div As Double

        'Entrada de datos
        num = Val(txtNumero.Text)

        'Proceso
        For i = 1 To 12 Step 1
            suma = num + i
            resta = num - i
            multi = num * i
            div = num / i

            'Salida de Información
            cboSuma.Items.Add(num & " + " & i & " = " & suma)
            cboResta.Items.Add(num & " - " & i & " = " & resta)
            cboMulti.Items.Add(num & " * " & i & " = " & multi)
            cboDivision.Items.Add(num & " / " & i & " = " & div)

        Next
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
