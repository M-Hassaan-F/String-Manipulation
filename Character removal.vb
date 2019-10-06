Module Module1

    Sub Main()
        Dim Inputstring As String
        Dim RemovalChar As Char
        Dim Finalstring As String
        Dim Counter As Integer

        Inputstring = ""
        RemovalChar = ""
        Finalstring = ""
        Counter = 0


        Console.Write("Enter string : ")
        Inputstring = Console.ReadLine()

        Console.Write("Enter character to be removed from string : ")
        RemovalChar = Console.ReadLine()


        For Counter = 1 To Len(Inputstring)
            If Mid(Inputstring, Counter, 1) <> RemovalChar Then
                Finalstring = Finalstring & Mid(Inputstring, Counter, 1)
            End If

        Next
        Console.WriteLine(Finalstring)
        Console.ReadKey()

    End Sub

End Module
