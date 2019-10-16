Module Module1

    Sub Main()
        Dim STR1 As String
        Dim STR2 As String
        Dim CHR1 As Char
        Dim count As Integer
        Dim NextChar As Char

        count = 0
        STR1 = ""
        STR2 = ""
        CHR1 = ""
        NextChar = ""

        Console.Write("enter string: ")
        STR1 = Console.ReadLine

        For count = Len(STR1) To 1 Step count - 1
            NextChar = Mid(STR1, count, 1)
            STR2 = STR2 & NextChar
        Next

        Console.Write("inverse string: " & STR2)
        Console.ReadKey()
    End Sub

End Module
