Module Module1

    Sub Main()
        Dim Number As Integer
        Dim Sum As Integer = 0
        Dim Count As Integer
        Dim Average As Integer
        Dim LargestN As Integer = 0
        Console.WriteLine("Input the number(s) here, -1 to finish the program")
        Do
            Number = Console.ReadLine()
            Sum = Sum + Number
            Count = Count + 1
            If Number > LargestN Then
                LargestN = Number
            End If
        Loop Until Number = -1
        Average = Sum / Count
        Console.WriteLine("The average of the number(s) input is " & Average)
        Console.WriteLine("The largest number is " & LargestN)
        Console.ReadLine()
    End Sub

End Module
