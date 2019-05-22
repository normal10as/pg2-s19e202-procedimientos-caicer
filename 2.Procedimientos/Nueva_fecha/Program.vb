Imports System.DateTime

Module Program
    Sub Main()
        Dim fecha As Date
        Dim Numero As Integer
        Console.WriteLine("ingrese la fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine(fecha)
        Console.WriteLine("ingrese los dias que quiere sumar: ")
        Numero = Console.ReadLine()
        Console.WriteLine(CalcularFecha(fecha, Numero))
    End Sub
    Function CalcularFecha(fecha As Date, numero As Integer) As Date
        Return fecha + CDate(numero)
    End Function
End Module
