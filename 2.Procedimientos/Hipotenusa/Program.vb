Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim LadoA, LadoB As UInt16
        Console.WriteLine("ingrese el lado A: ")
        LadoA = Console.ReadLine()
        Console.WriteLine("ingrese el lado B: ")
        LadoB = Console.ReadLine()
        Console.WriteLine(CalculoC(LadoA, LadoB))
    End Sub
    Function CalculoC(LadoA As UInt16, LadoB As UInt16) As UInt16
        Return Sqrt(LadoA * LadoA + LadoB * LadoB)
    End Function
End Module
