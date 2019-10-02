Imports Microsoft.VisualBasic

Partial Class Rectangulo

    Public Function RetornarSuperficie() As Integer
        Dim sup As Integer = lado1 * lado2
        Return sup
    End Function

    Public Function RetornarPerimetro() As Integer
        Dim per As Integer = lado1 * 2 + lado2 * 2
        Return per
    End Function

End Class
