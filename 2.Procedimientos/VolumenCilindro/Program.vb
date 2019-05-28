Imports System

Module Program
    Const Pi As Single = 3.14159
    Private VolumenCilindro As Double

    Sub Main(args As String())
        Dim AlturaCilindro, RadioCilindro As Single
        Console.WriteLine("inglrese Altura del cilindro")
        AlturaCilindro = Console.ReadLine()
        Console.WriteLine("ingrese Radio del cilidro")
        RadioCilindro = Console.ReadLine()
        VolumenCilindro = CalcularCilindro(AlturaCilindro, RadioCilindro)
        Console.WriteLine("El volumen del cilindro es: " & VolumenCilindro)
    End Sub
    Private Function CalcularCilindro(AlturaCilindro As Single, RadioCilindro As Single) As Double
        VolumenCilindro = Pi * RadioCilindro ^ 2 * AlturaCilindro
        Return VolumenCilindro
    End Function
End Module
