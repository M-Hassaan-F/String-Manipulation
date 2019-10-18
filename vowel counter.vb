Module Module1

    Sub Main()
        Dim vowels As String
        Dim STR As String
        Dim NextChar As Char
        Dim NextCharSTR As Char
        Dim vcount As Integer
        Dim count As Integer
        Dim count2 As Integer

        vowels = "aeiou"
        STR = ""
        NextChar = ""
        NextCharSTR = ""
        vcount = 0
        count = 0
        count2 = 0

        Console.Write("enter string: ")
        STR = Console.Readline

        For count = 1 To Len(vowels)
            NextChar = Mid(vowels, count, 1)
            For count2 = 1 To Len(STR)
                NextCharSTR = Mid(STR, count2, 1)
                If NextChar = NextCharSTR Then
                    vcount = vcount + 1
                End If
            Next
        Next

        Console.Write("Number of vowels: " & vcount)
        Console.ReadKey()

    End Sub

End Module
