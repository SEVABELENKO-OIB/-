Imports System

Module Program
    Sub Main(args As String)
        Const HEIGHT As Integer = 30
        Const WIDTH As Integer = 60
        For J = 1 To HEIGHT
            Console.SetCursorPosition(10, 10 + 1)
            For i = 1 To WIDTH
                Console.Write("H")
            Next
        Next
    End Sub
End Module

