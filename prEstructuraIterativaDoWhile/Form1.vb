Public Class Form1
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Declaración de variables
        Dim cantAlumnos As Integer, nota As Integer
        Dim suma As Integer
        Dim promedio As Double

        'Inicialización de variables
        suma = 0
        'Entrada de Datos
        cantAlumnos = Val(txtCantAlumnos.Text)

        'Proceso
        'Implementar un bucle para pedir las notas con un inputbox
        For i As Integer = 1 To cantAlumnos Step 1
            Do
                nota = InputBox("Ingrese la nota del alumno " & i, "Notas")
            Loop While (nota < 0 Or nota > 20) 'Usuario ingresa mal la nota

            suma += nota
        Next

        promedio = suma / cantAlumnos
        'Salida de información
        txtPromedio.Text = promedio
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantAlumnos.Clear()
        txtPromedio.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub
End Class
