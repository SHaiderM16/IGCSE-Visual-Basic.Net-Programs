Module Module1

    Sub Main()
        Dim ID As String
        Dim Weight As Integer
        Dim Height As Integer
        Dim HeightSquare As Integer
        Dim Students As Integer
        Dim BMI As Integer
        Console.WriteLine("Input your ID, weight(kg) and height(m) separately")
        For Students = 1 To 30
            ID = Console.ReadLine()
            Weight = Console.ReadLine()
            Height = Console.ReadLine()
            HeightSquare = Height * Height
            BMI = Weight / HeightSquare
            If BMI > 25 Then
                Console.WriteLine("The student with ID number " & ID & " has a BMI value " & BMI & " which means that the student is overweight")
            ElseIf BMI <= 25 And BMI >= 19 Then
                Console.WriteLine("The student with ID number " & ID & " has a BMI value " & BMI & " which means that the student is normal")
            ElseIf BMI < 19 Then
                Console.WriteLine("The student with ID number " & ID & " has a BMI value " & BMI & " which means that the student is underweight")
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
