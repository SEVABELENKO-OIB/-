Module programs
    Sub Main(args As String)
        Dim N As Integer
        Dim Z As Integer
        Dim F As Integer
        Console.WriteLine("я умею умножать число !")
        Console.WriteLine("Если напишешь (1) то я завершу счёт !")
        Console.WriteLine("можешь вписывать числа которые ты желаешь умножать !")
        N = Console.ReadLine
        F = N
        Do
            Z = Console.ReadLine
            If F < Int32.MaxValue Then
                F = F * Z
            Else
                Console.WriteLine("Man, число слишком большое")
                Exit Do
            End If
        Loop Until Z = 1
        Console.WriteLine("Я посчитаю это фор ю! (0), F")
        Console.WriteLine("Man, число слишком большое")
    End Sub
End Module
