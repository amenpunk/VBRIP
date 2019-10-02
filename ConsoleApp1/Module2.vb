Module Module2

    Sub Main()
            Dim rectangulo1 As New Rectangulo()
            rectangulo1.lado1 = 5
            rectangulo1.lado2 = 10
            Console.WriteLine("La superficie del rectángulo es:" &
                                    rectangulo1.RetornarSuperficie())
            Console.WriteLine("El perímetro del rectángulo es:" &
                                    rectangulo1.RetornarPerimetro())
            Console.ReadKey()
        End Sub

End Module
