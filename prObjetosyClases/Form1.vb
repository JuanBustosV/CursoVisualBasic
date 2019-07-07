Public Class Form1
    Private Sub BtnPerro1_Click(sender As Object, e As EventArgs) Handles btnPerro1.Click
        Dim perrito As Perro = New Perro()

        perrito.nombre = "Chizu"
        perrito.raza = "Pastor alemán"
        perrito.altura = "70 cm"

        txtResultado.Text = perrito.Comer("Carne Res")
    End Sub

    Private Sub BtnPerro2_Click(sender As Object, e As EventArgs) Handles btnPerro2.Click
        Dim perrito As Perro = New Perro()
        perrito.nombre = "Lasy"
        perrito.raza = "Chiguagua"
        perrito.altura = "60 cm"

        txtResultado.Text = perrito.Comer("Pollo")
    End Sub

    Private Sub BtnPerro3_Click(sender As Object, e As EventArgs) Handles btnPerro3.Click
        'Dim perrito As Perro = New Perro("Ozzy", "Yorkshire", "40")
        Dim perrito As Perro = New Perro("Ozzy", "40")

        txtResultado.Text = perrito.Comer("Jamón")
    End Sub
End Class
