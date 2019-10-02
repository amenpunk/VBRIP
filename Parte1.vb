Imports Microsoft.VisualBasic

Partial Class Rectangulo

    Private _lado1 As Integer
    Private _lado2 As Integer

    Public Property lado1() As Integer
        Get
            Return _lado1
        End Get
        Set(ByVal value As Integer)
            _lado1 = value
        End Set
    End Property

    Public Property lado2() As Integer
        Get
            Return _lado2
        End Get
        Set(ByVal value As Integer)
            _lado2 = value
        End Set
    End Property

End Class