Public Class Cliente
    Inherits Persona
    'Atributos

    'Propiedades automáticas
    Public Property Categoria As String
    Public Property Codigo As String

    'Métodos
    Public Sub GenerarCodigo()
        Me.Codigo = "C" & Me.Apellidos.Substring(0, 3) & "16"
    End Sub
End Class
