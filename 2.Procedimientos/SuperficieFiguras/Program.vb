Imports System

Module Program
    Private area As Decimal
    Sub Main(args As String())
        Dim Altura, BaseMayor, BaseMenor As Single
        Console.WriteLine("Ingrese el lado del cuadrado: ")
        Altura = Console.ReadLine()
        Console.WriteLine("El Area del cuadrado es: " & Areas(Altura))
        Console.WriteLine("Ingrese la base del rectangulo: ")
        BaseMenor = Console.ReadLine()
        Console.WriteLine("El Area del rectangulo es: " & Areas(Altura, BaseMenor))
        Console.WriteLine("Ingrese la base Mayor del rectangulo: ")
        BaseMayor = Console.ReadLine()
        Console.WriteLine("El Area del Trapecio es: " & Areas(Altura, BaseMenor, BaseMayor))
    End Sub
    Function Areas(LadoUno As Single) As Double
        area = LadoUno ^ 2
        Return area
    End Function
    Function Areas(LadoUno As Single, LadoDos As Single) As Double
        area = LadoUno * LadoDos
        Return area
    End Function
    Function Areas(LadoUno As Single, LadoDos As Single, LadoTres As Single) As Decimal
        area = ((LadoUno + LadoDos) / 2) * LadoTres
        Return area
    End Function
End Module
