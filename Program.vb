Imports System

Module Program
    Sub Main(args As String())
        Dim Version As String
        Dim number As String = "1234"
        Console.WriteLine("Угадай число")
        Do
            Version = Console.ReadLine()
            For i As Integer = 0 To 3
                If Version.Chars(0) = Version.Chars(i) Then
                    If i = 0 Then
                        Console.WriteLine("первая цифра - бык")
                    Else
                        Console.WriteLine("Первая цифра - корова")
                    End If
                End If
            Next
        Loop Until Version = number
        Console.WriteLine("")
    End Sub
End Module
