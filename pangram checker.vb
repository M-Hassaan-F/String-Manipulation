Module Module1

    Sub Main()
        Dim alphabets As String
        Dim STR1 As String
        Dim NextChar As Char
        Dim NextChar2 As Char
        Dim IsPangram As Boolean
        Dim C1 As Integer
        Dim C2 As Integer

        alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        STR1 = ""
        NextChar = ""
        NextChar2 = ""
        IsPangram = True
        C1 = 0
        C2 = 0

        Console.Write("Enter string: ")
        STR1 = Console.ReadLine
        STR1 = UCase(STR1)

        For C1 = 1 To Len(alphabets)
            NextChar = Mid(alphabets, C1, 1)
            If InStr(STR1, NextChar) = 0 Then
                IsPangram = False
                Exit For
            End If
        Next

        If IsPangram = True Then
            Console.Write("string is pangram")
        Else
            Console.Write("string is not pangram")
        End If
        Console.ReadKey()


    End Sub

End Module
