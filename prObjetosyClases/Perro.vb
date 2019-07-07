Public Class Perro
    'Campos o atributos de la clase
    Public nombre As String
    Public raza As String
    Public altura As String

    'Constructores
    Public Sub New()

    End Sub

    Public Sub New(pNombre As String, pRaza As String, pAltura As String)
        Me.nombre = pNombre
        Me.raza = pRaza
        Me.altura = pAltura
    End Sub

    Public Sub New(pNombre As String, pAltura As String)
        Me.nombre = pNombre
        Me.altura = pAltura & " cm"
    End Sub

    'Métodos de la clase (Procedimientos y/o Funciones)
    Public Sub Dormir()

    End Sub

    Public Sub Ladrar()

    End Sub

    Public Function Comer(carne As String) As String
        Dim resultado As String

        If (raza = String.Empty) Then
            resultado = Me.nombre & " mide " & Me.altura & " y comerá " & carne
        Else
            resultado = Me.nombre & " (" & Me.raza & ") " & " mide " & Me.altura & " y comerá " & carne
        End If

        Return resultado
    End Function
End Class
