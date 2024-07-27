Module Module1

    Sub Main()
        Dim Number As Integer
        Dim Num As Integer
        Dim Digits As Integer = 0
        Console.WriteLine("Input a positive integer")
        Number = Console.ReadLine()
        Num = Number
        Do
            Num = Num / 10
            Digits = Digits + 1
        Loop Until Num < 1
        Console.WriteLine("The number is " & Number)
        Console.WriteLine("The numbers of digits in the number is " & Digits)
        Console.ReadLine()
    End Sub

End Module
