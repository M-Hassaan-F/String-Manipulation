Module Module1

    Sub Main()
        Dim STR1 As String
        Dim STR2 As String
        Dim STR3 As String
        Dim NextChar As Char
        Dim NextChar2 As Char
        Dim HasChanged As Boolean
        Dim C1 As Integer
        Dim C2 As Integer

        STR1 = ""
        STR2 = ""
        STR3 = ""
        NextChar = ""
        NextChar2 = ""
        HasChanged = False
        C1 = 0
        C2 = 0

        Console.Write("Enter first string: ")
        STR1 = Console.ReadLine()
        STR1 = UCase(STR1)

        Console.Write("Enter second string: ")
        STR2 = Console.ReadLine()
        STR2 = UCase(STR2)

        If Len(STR1) = Len(STR2) Then
            For C1 = 1 To Len(STR1)
                NextChar = Mid(STR1, C1, 1)
                STR3 = ""
                HasChanged = False
                For C2 = 1 To Len(STR2)
                    NextChar2 = Mid(STR2, C2, 1)
                    If NextChar = NextChar2 And HasChanged = False Then
                        HasChanged = True
                    Else
                        STR3 = STR3 & NextChar2
                    End If
                Next
                STR2 = STR3
            Next
            If STR2 = "" Then
                Console.Write("Strings are anagrams")
            Else
                Console.Write("Strings are not anagrams")
            End If
        Else
            Console.Write("Strings are not anagrams")
        End If
        Console.ReadKey()
    End Sub

End Module
