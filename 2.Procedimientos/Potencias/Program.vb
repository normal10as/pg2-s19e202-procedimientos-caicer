Imports System

Module Program
    Dim Numero, numerodos, numerotres, numerocinco As Int16
    Sub Main()
        Console.WriteLine("ingrese un numero")
        Numero = Console.ReadLine()
        Console.WriteLine("elevado a la dos es: " & ExponenteDos(Numero))
        Console.WriteLine("elevado a la tres es: " & ExponenteTres(Numero))
        Console.WriteLine("elevado a la cinco es: " & ExponenteCinco(Numero))
    End Sub
    Function ExponenteDos(Numero) As Int64
        Numerodos = Numero ^ 2
        Return Numerodos
    End Function
    Function ExponenteTres(Numero) As Int64
        Numerotres = Numero ^ 3
        Return Numerotres
    End Function
    Function ExponenteCinco(Numero) As Int64
        Numerocinco = Numero ^ 5
        Return Numerocinco
    End Function

End Module
