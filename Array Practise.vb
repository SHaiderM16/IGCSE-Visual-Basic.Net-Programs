Module Module1

    Sub Main()
        Dim StudentName As String
        Dim SName(3) As String
        Dim Count As Integer
        Dim Index As Integer
        Console.WriteLine("Input the name of three students")
        For Count = 1 To 3
            StudentName = Console.ReadLine
            SName(Count) = StudentName
        Next
        For Index = 1 To 3
            Console.WriteLine(SName(2))
        Next
        Console.ReadLine()
    End Sub

End Module
