Public Class Form1
    Private mPlatos(,) As String
    Private cantPlatos As String
    Private index As Byte
    Private encuentra As Byte = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVender.Enabled = False
        txtPrecio.Enabled = False
        txtDisponible.Enabled = False
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        'Entrada de datos
        cantPlatos = Val(txtCantPlatos.Text)
        'Inicializar la matriz
        ReDim Preserve mPlatos(cantPlatos, 3)

        'Ingresar los datos a la matriz
        For i As Integer = 0 To (cantPlatos - 1) Step 1
            mPlatos(i, 0) = InputBox("Ingrese nombre del plato " & (i + 1), "Restaurant")
            mPlatos(i, 1) = InputBox("Ingrese precio del plato " & (i + 1), "Restaurant")
            mPlatos(i, 2) = InputBox("Ingrese stock del plato " & (i + 1), "Restaurant")
        Next
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Declaración de variables
        Dim plato As String
        'Entrada de datos
        plato = txtPlato.Text
        'Buscamos el plato en la matriz
        For i As Integer = 0 To (cantPlatos - 1) Step 1
            If (mPlatos(i, 0) = plato) Then
                encuentra = 1
                txtPrecio.Text = mPlatos(i, 1)
                txtDisponible.Text = mPlatos(i, 2)
                index = i
                btnVender.Enabled = True
            End If
        Next
        'si no encuentra el plato en la matriz
        If (encuentra = 0) Then
            MessageBox.Show("No existe el plato", "Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnVender.Enabled = False
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub BtnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        'Declaración de variables
        Dim cant As Integer
        Dim stock As Integer
        'Entrada de datos
        cant = Val(txtCantidad.Text)
        stock = mPlatos(index, 2)

        If (stock >= cant) Then
            'Disminuimos la cantidad de stock
            mPlatos(index, 2) -= cant
            txtDisponible.Text = mPlatos(index, 2)
        Else
            MessageBox.Show("No hay suficiente stock", "Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
