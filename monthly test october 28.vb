Module Module1

    Sub Main()
        Dim STR As String
        Dim ValidBinaryString As Boolean
        Dim NextChar As Char
        Dim count As Integer
        Dim denary As Integer
        Dim worth As Integer
        Dim wcount As Integer
        Dim nextcharval As Integer
        Dim ncount As Integer
        Dim NextChar1 As Char

        STR = ""
        ValidBinaryString = True
        NextChar = ""
        count = 0
        denary = 0

        Do
            ValidBinaryString = True
            Console.Write("Enter binary number: ")
            STR = Console.ReadLine

            If Len(STR) < 1 Or Len(STR) > 8 Then
                ValidBinaryString = False
            End If

            If ValidBinaryString = True Then
                For count = 1 To Len(STR)
                    NextChar = Mid(STR, count, 1)
                    If NextChar = "0" Or NextChar = "1" Then
                    Else
                        ValidBinaryString = False
                        Exit For
                    End If
                Next
            End If

            If ValidBinaryString = False Then
                Console.WriteLine("Not a valid binary number")
            End If

        Loop Until ValidBinaryString = True

        ncount = 0
        NextChar1 = ""
        worth = 0
        wcount = 0
        nextcharval = 0

        For ncount = 1 To Len(STR)
            NextChar1 = Mid(STR, ncount, 1)
            nextcharval = Val(NextChar1)
            worth = 1
            For wcount = (8 - ncount) To 1 Step -1
                worth = worth * 2
            Next
            denary = denary + (nextcharval * worth)
        Next
        Console.WriteLine(STR & " = " & denary)

        Console.ReadKey()


    End Sub

End Module
