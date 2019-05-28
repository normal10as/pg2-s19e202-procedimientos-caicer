Imports System

Module Program
    Sub Main(args As String())
        Dim NumUno, NumDos, NumTres, NumCuatro As Int16
        Console.WriteLine("Ingrese un numero")
        NumUno = Console.ReadLine()
        Console.WriteLine("Ingrese un numero")
        NumDos = Console.ReadLine()
        Console.WriteLine("la suma de dos numeros es " & suma(NumDos, NumUno))
        Console.WriteLine("Ingrese un numero")
        NumTres = Console.ReadLine()
        Console.WriteLine("la suma de tres numeros es " & suma(NumDos, NumUno, NumTres))
        Console.WriteLine("ingrese un numero")
        NumCuatro = Console.ReadLine()
        Console.WriteLine("la suma de cuatro numeros es " & suma(NumDos, NumUno, NumTres, NumCuatro))
    End Sub
    Function suma(NumUno As Int16, NumDos As Int16) As Int32
        Dim sumatoria As Int32
        sumatoria = NumDos + NumUno
        Return sumatoria
    End Function
    Function suma(NumUno As Int16, NumDos As Int16, NumTres As Int16) As Int32
        Dim sumatoria As Int32
        sumatoria = NumDos + NumUno + NumTres
        Return sumatoria
    End Function
    Function suma(NumUno As Int16, NumDos As Int16, NumTres As Int16, NumCuatro As Int16) As Int32
        Dim sumatoria As Int32
        sumatoria = NumDos + NumUno + NumTres + NumCuatro
        Return sumatoria
    End Function
End Module
