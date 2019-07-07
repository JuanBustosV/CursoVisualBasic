Public Class Form1
    Private Sub BtnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        'Declaracion de variables
        Dim cadena As String = txtCadena.Text

        'APLICAR LAS FUNCIONES
        'Calculamos la longitud de la cadena
        txtLongitud.Text = cadena.Length
        'Mostrar el primer carácter
        txtPrimer.Text = cadena.First() '.Substring(0, 1)
        'Mostrar el último carácter
        txtUltimo.Text = cadena.Substring((cadena.Length - 1), 1)
        'Mostrar del segundo al sexto carácter
        txt26.Text = cadena.Substring(1, 5)
        'Buscar la ubicación de la primera letra A
        txtPrimeraA.Text = cadena.IndexOf("A", 0) + 1
        'Convertimos el texto en Mayúsculas
        txtMayusculas.Text = cadena.ToUpper()
        'Convertimos el texto en Minúsculas
        txtMinusculas.Text = cadena.ToLower()
        'Borrar espacios en blanco
        txtBorrarEspacios.Text = cadena.Replace(" ", "")

    End Sub
End Class
