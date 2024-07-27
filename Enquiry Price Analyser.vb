Module Module1

    Sub Main()
        Dim SumEnquiries As Integer
        Dim PriceEnquiry As Integer
        Dim DEnquiriesBelow100000 As Integer = 0
        Dim WEnquiriesAbove500000 As Integer = 0
        Dim Count As Integer
        Dim PercentWEnquiriesAbove500000 As Integer
        Dim Enquiry As Integer
        Dim WeekDay As Integer
        For WeekDay = 1 To 7
            Console.WriteLine("Input the number of enquiries for the day")
            SumEnquiries = Console.ReadLine()
            Console.WriteLine("Input the house price(s) enquired by the customer(s)")
            For Enquiry = 1 To SumEnquiries
                PriceEnquiry = Console.ReadLine()
                If PriceEnquiry < 100000 Then
                    DEnquiriesBelow100000 = DEnquiriesBelow100000 + 1
                ElseIf PriceEnquiry > 500000 Then
                    WEnquiriesAbove500000 = WEnquiriesAbove500000 + 1
                End If
                Count = Count + 1
            Next
            Console.WriteLine("The number of enquiries for the day below $100000 are " & DEnquiriesBelow100000)
        Next
        PercentWEnquiriesAbove500000 = WEnquiriesAbove500000 / Count * 100
        Console.WriteLine("The percentage of enquiries above $500000 throughout the week is %" & PercentWEnquiriesAbove500000)
        Console.ReadLine()
    End Sub

End Module
