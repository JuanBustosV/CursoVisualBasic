Public Class Form1
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Declaración de variables
        Dim nombre As String

        'Entrada de datos
        nombre = InputBox("Ingrese Nombre", "Registro de Datos", "Nombre", 100, 10)

        MessageBox.Show("Bienvenido Usuario: " & nombre, "Registro de Datos", MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Realmente desea salir de la App?", "Salir de la App",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
