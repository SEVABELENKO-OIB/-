Imports System

Module program
    Public Sub Main(args() As String)

    End Sub
        Main(args, Version)

    Sub Main(args As String)
        Dim version As String
        Dim number As String = "1234"
        Console.WriteLine("Угадай число!")
        Dim bulls As Integer, cows As Integer
        Do
            version = Console.ReadLine()
            For j = 0 To 3
                For i As Integer = 0 To 3
                    If version.Chars(i) = number.Chars(j) Then
                        If i = j Then
                            bulls += 1
                        Else
                            cows += 1
                        End If
                    End If
                Next

            Next
            Console.WriteLine(bulls)
            Console.WriteLine(cows)
        Loop Until version
    End Sub

End Module
