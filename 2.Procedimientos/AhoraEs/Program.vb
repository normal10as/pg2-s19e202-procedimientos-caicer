Imports System
Imports System.DateTime
Module Program
    Sub Main()
        ImprimirFecha()
        Console.WriteLine("Ahora es: " & ImprimirHora())

    End Sub
    Sub ImprimirFecha()
        Console.WriteLine("Hoy es: " & Now.Date)
    End Sub
    Function ImprimirHora() As String
        Return Now.Hour & ":" & Now.Minute
    End Function

End Module