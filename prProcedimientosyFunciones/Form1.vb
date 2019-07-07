Public Class Form1
    'Campos
    Private _numero1 As Integer
    'Private _numero2 As Integer
    'Propiedades
    Public Property Numero1 As Integer
        Get
            Return _numero1
        End Get
        Set(value As Integer)
            _numero1 = value
        End Set
    End Property
    'Propiedad automática
    Public Property Numero2 As Integer
    '    Get
    '        Return _numero2
    '    End Get
    '    Set(value As Integer)
    '        _numero2 = value
    '    End Set
    'End Property

    'PROCEDIMIENTO, no devuelve ningún valor SUB
    Private Sub Limpiar()
        txtNumero1.Clear()
        txtNumero2.Clear()
        txtResultado.Clear()
    End Sub
    'Función devuelve un valor FUNCTION
    Private Function Sumar(num1 As Integer, num2 As Integer) As Integer
        Dim resultado As Integer
        resultado = num1 + num2
        Return resultado
    End Function

    Private Function Operaciones(num1 As Integer, num2 As Integer, op As String) As Double
        Dim resultado As Double
        'If (op = "s") Then
        '    resultado = num1 + num2
        'ElseIf (op = "r") Then
        '    resultado = num1 - num2
        'ElseIf (op = "m") Then
        '    resultado = num1 * num2
        'Else
        '    resultado = num1 / num2
        'End If

        Select Case (op)
            Case "s"
                resultado = num1 + num2
            Case "r"
                resultado = num1 - num2
            Case "m"
                resultado = num1 * num2
            Case Else
                resultado = num1 / num2

        End Select

        Return resultado
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Call Limpiar()  'También es válido sin Call
    End Sub

    Private Sub BtnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim numero1 As Integer
        Dim numero2 As Integer
        numero1 = Val(txtNumero1.Text)
        numero2 = Val(txtNumero2.Text)

        txtResultado.Text = Sumar(numero1, numero2)

    End Sub

    Private Sub BtnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        txtResultado.Text = Operaciones(Val(txtNumero1.Text), Val(txtNumero2.Text), "r")
    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        'Declaración de Variables
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim resultado As Double 'Operaciones retorna Double

        'Entrada de datos
        numero1 = Val(txtNumero1.Text)
        numero2 = Val(txtNumero2.Text)

        'Proceso
        resultado = Operaciones(numero1, numero2, "m")
        'Salida información
        txtResultado.Text = resultado
    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        txtResultado.Text = Operaciones(Val(txtNumero1.Text), Val(txtNumero2.Text), "d")
    End Sub

    Private Sub BtnPropiedades_Click(sender As Object, e As EventArgs) Handles btnPropiedades.Click
        Numero1 = Val(txtNumero1.Text) ' llama a set
        Numero2 = Val(txtNumero2.Text)

        Dim suma As Integer
        suma = Numero1 + Numero2 ' Llaman a get

        txtResultado.Text = suma

    End Sub
    'Estructura
    Structure cliente
        Public nombre As String
        Public apellidos As String
        Public telefono As String
    End Structure

    Private Sub BtnEstructura_Click(sender As Object, e As EventArgs) Handles btnEstructura.Click
        Dim cliente1 As cliente
        cliente1.nombre = "Juan Antonio"
        cliente1.apellidos = "Bustos Vázquez"
        cliente1.telefono = "649212237"

        txtResultado.Text = cliente1.nombre

    End Sub
End Class
