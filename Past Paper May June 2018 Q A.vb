Module Module1

    Sub Main()
        Dim Number As Integer
        Dim Count As Integer
        Dim SumPNumbers As Integer = 0
        Dim SumZeros As Integer = 0
        Console.WriteLine("Input the numbers here")
        For Count = 1 To 1000
            Number = Console.ReadLine()
            If Number > 0 Then
                SumPNumbers = SumPNumbers + 1
            ElseIf Number = 0 Then
                SumZeros = SumZeros + 1
            End If
        Next
        Console.WriteLine("The amount of positive numbers is " & SumPNumbers)
        Console.WriteLine("The amount of zeros is " & SumZeros)
        Console.ReadLine()
    End Sub

End Module
