Imports System.Windows.Forms

Module Module1


    Public Class Conexion


        Public nombre As String
        Public edad As Integer
        Public letras(5) As Integer

        Public Sub New()
            For f = 0 To 5
                letras(f) = f
            Next
        End Sub

        Sub Inicializar()
            Console.WriteLine("Ingrese Nombre: ")
            nombre = Console.ReadLine()

            Console.WriteLine("Ingrese Edad: ")
            edad = Console.ReadLine()

        End Sub

        Sub Imprimir()
            Console.Write("Tu nombre es: " & nombre)
            Console.Write("y tienes: " & edad & " años")
        End Sub

        Public Function MasEdad(ByVal mas As Integer)
            Return mas + edad
        End Function

    End Class
    Sub Main()
        'Dim per1 As Conexion
        'per1 = New Conexion()
        'per1.Inicializar()
        'per1.Imprimir()


        'Dim mas As Integer
        'Console.WriteLine("Cuantos años mas?: ")
        'mas = Console.ReadLine()
        'Dim tot As Integer
        'tot = per1.MasEdad(mas)
        'Console.WriteLine("y en" & mas & " vas a tener " & tot)
        'Console.ReadKey()
        Dim form As Form1
        form = New Form1()
        form.ShowDialog()
    End Sub
End Module
