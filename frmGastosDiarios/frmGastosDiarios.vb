Public Class frmGastosDiarios
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Declaración de variables
        Dim vGastos() As Double
        Dim gasto As Double, totalGasto As Double, diaMayor As Integer
        Dim gastoMayor As Double
        Dim cantDias As Integer

        'Inicializar variables
        totalGasto = 0
        diaMayor = 1
        gastoMayor = 0

        'Leer los gastos
        cantDias = Val(txtCantDias.Text)
        ReDim Preserve vGastos(cantDias)    'Establece el tamaño del vector
        For i As Integer = 0 To (cantDias - 1) Step 1
            gasto = InputBox("Ingrese el gasto del día " & (i + 1), "Gastos")
            vGastos(i) = gasto
        Next

        For j As Integer = 0 To (cantDias - 1) Step 1
            If (vGastos(j) > gastoMayor) Then
                gastoMayor = vGastos(j)
                diaMayor = j + 1
            End If
            cboGastos.Items.Add("Día " & (j + 1) & " Total: " & vGastos(j))
            totalGasto += vGastos(j)
        Next
        ' Salida de Información
        txtGastoMayor.Text = gastoMayor
        txtDiaMayor.Text = "Día: " & diaMayor
        txtTotalGastos.Text = totalGasto

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboGastos.Items.Clear()
        txtCantDias.Clear()
        txtGastoMayor.Clear()
        txtDiaMayor.Clear()
        txtTotalGastos.Clear()


    End Sub
End Class
