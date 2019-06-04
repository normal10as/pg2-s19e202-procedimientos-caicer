Imports System

Module Program
    Dim suma As Int64
    Sub Main(args As String())
        Dim numero As Int16
        Console.WriteLine("ingrese numero")
        numero = Console.ReadLine()
        acumular(numero)
        Console.WriteLine("la suma hasta ahora es " & suma)
        Console.WriteLine("ingrese numero")
        numero = Console.ReadLine()
        acumular(numero)
        Console.WriteLine("la suma hasta ahora es " & suma)
        Console.WriteLine("ingrese numero")
        numero = Console.ReadLine()
        acumular(numero)
        Console.WriteLine("la suma hasta ahora es " & suma)
    End Sub
    Sub acumular(numero As Int16)
        suma = suma + numero
    End Sub
End Module
