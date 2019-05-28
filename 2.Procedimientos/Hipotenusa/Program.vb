Imports System
Imports System.Math
Module Program
    Private LadoC As Double

    Sub Main(args As String())
        Dim LadoA, LadoB As UInt16
        Console.WriteLine("ingrese el lado A: ")
        LadoA = Console.ReadLine()
        Console.WriteLine("ingrese el lado B: ")
        LadoB = Console.ReadLine()
        LadoC = CalculoC(LadoA, LadoB)
        Console.WriteLine(LadoC)
    End Sub
    Function CalculoC(LadoA As UInt16, LadoB As UInt16) As Double
        LadoC = Sqrt(LadoA * LadoA + LadoB * LadoB)
        Return LadoC
    End Function
End Module
