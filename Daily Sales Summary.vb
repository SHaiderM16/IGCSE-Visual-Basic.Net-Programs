Module Module1

    Sub Main()
        Dim Item As String
        Dim SumBun As Decimal = 0
        Dim SumCoffee As Decimal = 0
        Dim SumCake As Decimal = 0
        Dim SumSandwich As Decimal = 0
        Dim SumDessert As Decimal = 0
        Dim TotalTaking As Decimal
        Dim CountBun As Integer
        Dim CountCoffee As Integer
        Dim CountCake As Integer
        Dim CountSandwich As Integer
        Dim CountDessert As Integer
        Dim HighestTaking As Integer = 0
        Console.WriteLine("Input all the items sold during the day, input 'end' to end the program")
        Do
            Item = Console.ReadLine()
            If Item = "bun" Then
                SumBun = SumBun + 0.5
                CountBun = CountBun + 1
                While CountBun > HighestTaking
                    HighestTaking = CountBun
                End While
            ElseIf Item = "coffee" Then
                SumCoffee = SumCoffee + 1.2
                CountCoffee = CountCoffee + 1
                While CountCoffee > HighestTaking
                    HighestTaking = CountCoffee
                End While
            ElseIf Item = "cake" Then
                SumCake = SumCake + 1.5
                CountCake = CountCake + 1
                While CountCake > HighestTaking
                    HighestTaking = CountCake
                End While
            ElseIf Item = "sandwich" Then
                SumSandwich = SumSandwich + 2.1
                CountSandwich = CountSandwich + 1
                While CountSandwich > HighestTaking
                    HighestTaking = CountSandwich
                End While
            ElseIf Item = "dessert" Then
                SumDessert = SumDessert + 4
                CountDessert = CountDessert + 1
                While CountDessert > HighestTaking
                    HighestTaking = CountDessert
                End While
            End If
        Loop Until Item = "end"
        TotalTaking = SumBun + SumCoffee + SumCake + SumSandwich + SumDessert
        Console.WriteLine("The total takings of the day is $" & TotalTaking)
        If HighestTaking = CountBun Then
            Console.WriteLine("Bun had the highest takings for the day")
        ElseIf HighestTaking = CountCoffee Then
            Console.WriteLine("Coffee had the highest takings for the day")
        ElseIf HighestTaking = CountCake Then
            Console.WriteLine("cake had the highest takings")
        ElseIf HighestTaking = CountSandwich Then
            Console.WriteLine("Sandwich had the highest takings for the day")
        ElseIf HighestTaking = CountDessert Then
            Console.WriteLine("Dessert had the highest takings for the day")
        End If
        Console.ReadLine()
    End Sub

End Module
