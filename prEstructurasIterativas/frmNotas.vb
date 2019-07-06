Public Class frmNotas
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            'Declaración de variables
            Dim numAlumnos As Integer
            Dim nota, sumaNotas, notaBaja, promedio As Double

            If (Val(txtNumero.Text) - Int(Val(txtNumero.Text)) = 0) Then
                'Entrada de datos
                numAlumnos = Val(txtNumero.Text)
                'Inicializamos las variables
                sumaNotas = 0
                notaBaja = 20

                For i = 1 To numAlumnos Step 1
                    nota = InputBox("Ingrese Nota del alumno " & i, "Registro de Notas")
                    sumaNotas += nota

                    'Evaluo si esa nota es la nota más baja
                    If (nota < notaBaja) Then
                        notaBaja = nota
                    End If
                Next

                'Calculo promedio
                promedio = sumaNotas / numAlumnos

                'Salida de la información
                txtPromedio.Text = promedio
                txtNotaBaja.Text = notaBaja
            Else
                MessageBox.Show("Ingrese un valor entero", "Promedio de Notas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNumero.Clear()
        txtNotaBaja.Clear()
        txtPromedio.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class