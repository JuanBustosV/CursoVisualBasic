Public Class Form1
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtStockInicial.Clear()
        txtStock.Clear()
        txtCantPersonas.Clear()

    End Sub

    Private Sub BtnRepartir_Click(sender As Object, e As EventArgs) Handles btnRepartir.Click
        'Declaración de variables
        Dim stock As Integer
        Dim cantPersonas As Integer, cantEntrega As Integer

        'Inicialización de variables
        'cantPersonas = 0
        'Entrada de datos
        stock = txtStockInicial.Text

        'Empezamos a repartir las vacunas
        Do While (stock >= 10)
            cantEntrega = InputBox("Ingrese cantidad a entregar a la persona " & (cantPersonas + 1), "Reparto de Vacunas")
            'Validar cantidad entregada sea menor o igual que el stock disponible
            If (stock >= cantEntrega) Then
                cantPersonas += 1
                stock -= cantEntrega
            Else
                MessageBox.Show("No hay suficiente stock", "Reparto de Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Loop

        MessageBox.Show("El stock es inferior a 10 unidades", "Reparto de Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Salida de información
        txtStock.Text = stock
        txtCantPersonas.Text = cantPersonas
    End Sub
End Class
