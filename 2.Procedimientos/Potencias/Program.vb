Imports System
private Exponente as byte = 2
Module Program
    Dim Numero As Int16
    
    Sub Main()
        Console.WriteLine("ingrese un numero")
        Numero = Console.ReadLine()
        Console.WriteLine("elevado a la dos es: " & Exponente(Numero))
        Console.WriteLine("elevado a la tres es: " & Exponente(Numero))
        Exponente(Numero)
        Console.WriteLine("elevado a la cinco es: " & Exponente(Numero))
    End Sub
    Function Exponente(Numero) As Int64
        
        Numero = Numero ^ exponente
        exponente+=1
        Return Numerodos
    End Function
    
End Module
