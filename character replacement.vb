Module Module1

    Sub Main()

        Dim CHR1 As Char
        Dim CHR2 As Char
        Dim NextChar As Char
        Dim STR1 As String
        Dim STR2 As String
        Dim Count As Integer

        STR1 = ""
        STR2 = ""
        CHR1 = ""
        CHR2 = ""
        NextChar = ""
        Count = 0

        Console.Write("Enter string: ")
        STR1 = Console.ReadLine

        Console.WriteLine("Enter character to be removed: ")
        CHR1 = Console.ReadLine

        Console.Write("Enter character to be replaced with: ")
        CHR2 = Console.ReadLine

        For Count = 1 To Len(STR1)
            NextChar = Mid(STR1, Count, 1)
            If NextChar = CHR1 Then
                STR2 = STR2 & CHR2
            Else
                STR2 = STR2 & NextChar
            End If
        Next
        Console.Write("Final string" & STR2)
        Console.ReadKey()

    End Sub

End Module
