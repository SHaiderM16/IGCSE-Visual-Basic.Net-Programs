Module Module1

    Sub Main()
        Dim StartingStation As Integer
        Dim DestinationStation As Integer
        Dim TotalPassengers As Integer
        Dim Fare As Decimal
        Dim AmountReceived As Integer
        Dim Change As Decimal
        Dim Ticket As Integer
        Console.WriteLine("Input your starting station, destination station and the total number of passengers line by line")
        StartingStation = Console.ReadLine()
        DestinationStation = Console.ReadLine()
        TotalPassengers = Console.ReadLine()
        Fare = (DestinationStation - StartingStation) * 2
        If TotalPassengers >= 3 Then
            Fare = Fare * 90 / 100
        End If
        Console.WriteLine("Your fare is $" & Fare)
        Console.WriteLine("Input your amount")
        AmountReceived = Console.ReadLine()
        If AmountReceived > Fare Then
            Change = AmountReceived - Fare
            Console.WriteLine("Your change is $" & Change)
        End If
        Console.WriteLine("Your rail tickets are issued below")
        For Ticket = 1 To TotalPassengers
            Console.WriteLine("Rail Ticket")
        Next
        Console.ReadLine()
    End Sub

End Module
