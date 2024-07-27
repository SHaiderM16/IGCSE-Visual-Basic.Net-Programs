Module Module1

    Sub Main()
        Dim CountryName As String
        Dim Hour As Integer
        Dim Minute As Integer
        Console.WriteLine("Enter the name of the country whose time you want to know, the hour in Italy(24 hour clock) and the minute in Italy separately")
        CountryName = Console.ReadLine()
        Hour = Console.ReadLine()
        Minute = Console.ReadLine()
        If CountryName = "Mexico" Then
            Hour = Hour - 7
        ElseIf CountryName = "India" Then
            Hour = Hour + 4
            Minute = Minute + 30
        ElseIf CountryName = "New Zealand" Then
            Hour = Hour + 11
        End If
        Console.WriteLine("The time in " & CountryName & " is currently " & Hour & ":" & Minute)
        Console.ReadLine()
    End Sub

End Module
