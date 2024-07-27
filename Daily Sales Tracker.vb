Module Module1

    Sub Main()
        Dim Item As String
        Dim SumBun As Decimal
        Dim CountBun As Integer
        Dim SumCoffee As Decimal
        Dim CountCoffee As Integer
        Dim SumCake As Decimal
        Dim CountCake As Integer
        Dim SumSandwich As Decimal
        Dim CountSandwich As Integer
        Dim SumDessert As Decimal
        Dim CountDessert As Integer
        Dim TotalTakings As Decimal
        Dim HighestTaking As Integer = 0
        Console.WriteLine("Input the items sold during the day, input 'end' to finish the program")
        Item = Console.ReadLine()
        Do
            Select Case Item
                Case "bun"
                    SumBun = SumBun + 0.5
                    CountBun = CountBun + 1
                    If CountBun > HighestTaking Then
                        HighestTaking = CountBun
                    End If
                Case "coffee"
                    SumCoffee = SumCoffee + 1.2
                    CountCoffee = CountCoffee + 1
                    If CountCoffee > HighestTaking Then
                        HighestTaking = CountCoffee
                    End If
                Case "cake"
                    SumCake = SumCake + 1.5
                    CountCake = CountCake + 1
                    If CountCake > HighestTaking Then
                        HighestTaking = CountCake
                    End If
                Case "sandwich"
                    SumSandwich = SumSandwich + 2.1
                    CountSandwich = CountSandwich + 1
                    If CountSandwich > HighestTaking Then
                        HighestTaking = CountSandwich
                    End If
                Case "desset"
                    SumDessert = SumDessert + 4
                    CountDessert = CountDessert + 1
                    If CountDessert > HighestTaking Then
                        HighestTaking = CountDessert
                    End If
                Case Else
            End Select
        Loop Until Item = "end"
        TotalTakings = SumBun + SumCoffee + SumCake + SumSandwich + SumDessert
        Console.WriteLine("The total takings of the day are " & TotalTakings)
        Select Case HighestTaking
            Case HighestTaking = CountBun
                Console.WriteLine("Bun had the highest taking")
            Case HighestTaking = CountCoffee
                Console.WriteLine("Coffee had the highest taking")
            Case HighestTaking = CountCake
                Console.WriteLine("Cake had the highest takings")
            Case HighestTaking = CountSandwich
                Console.WriteLine("Sandwich had the highest takings")
            Case HighestTaking = CountDessert
                Console.WriteLine("Dessert had the highest takings")
        End Select
        Console.ReadLine()
    End Sub

End Module
