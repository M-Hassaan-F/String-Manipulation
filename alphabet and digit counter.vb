Module Module1

    Sub Main()
        Dim count As Integer
        Dim digit As Integer
        Dim alpha As Integer
        Dim STR As String
        Dim NextChar As Char

        count = 0
        alpha = 0
        digit = 0
        STR = ""
        NextChar = ""

        Console.Write("enter string: ")
        STR = Console.ReadLine

        For count = 1 To Len(STR)
            NextChar = Mid(STR, count, 1)
            NextChar = UCase(NextChar)
            If Asc(NextChar) >= 65 And Asc(NextChar) <= 90 Then
                alpha = alpha + 1
            Else
                If Asc(NextChar) >= 47 And Asc(NextChar) <= 57 Then
                    digit = digit + 1
                End If
            End If
        Next

        Console.WriteLine("number of digits: " & digit)
        Console.Write("number of alphabets: " & alpha)
        Console.ReadKey()

    End Sub

End Module
