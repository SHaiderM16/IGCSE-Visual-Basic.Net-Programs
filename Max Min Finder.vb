Module Module1

    Sub Main()
        Dim Number As Integer
        Dim LargestN As Integer
        Dim SmallestN As Integer
        Dim Count As Integer
        Console.WriteLine("Input 10 numbers and find out the largest and the smallest number automatically")
        Number = Console.ReadLine()
        LargestN = Number
        SmallestN = Number
        For Count = 1 To 9
            Number = Console.ReadLine()
            If Number > LargestN Then
                LargestN = Number
            ElseIf Number < SmallestN Then
                SmallestN = Number
            End If
        Next
        Console.WriteLine("The largest number is " & LargestN)
        Console.WriteLine("The smallest number is " & SmallestN)
        Console.ReadLine()
    End Sub

End Module
