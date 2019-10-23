Module Module1

    Sub Main()
        Dim STR As String
        Dim nextchar As Char
        Dim count As Integer
        Dim isValid As Boolean

        STR = ""
        nextchar = ""
        count = 0
        isValid = True

        Console.Write("Enter string: ")
        STR = Console.ReadLine

        If Len(STR) > 11 Then isValid = False

        If isValid = True Then
            If Mid(STR, 5, 1) <> "-" Or Mid(STR, 9, 1) <> "-" Then
                isValid = False
            End If
        End If

        If isValid = True Then
            For count = 1 To 4
                nextchar = Mid(STR, count, 1)
                If nextchar < "A" Or nextchar > "Z" Then
                    isValid = False
                    Exit For
                End If
            Next
        End If

        If isValid = True Then
            For count = 6 To 8
                nextchar = Mid(STR, count, 1)
                If nextchar < "0" Or nextchar > "9" Then
                    isValid = False
                    Exit For
                End If
            Next
        End If

        If isValid = True Then
            For count = 10 To 11
                nextchar = Mid(STR, count, 1)
                If nextchar < "a" Or nextchar > "z" Then
                    isValid = False
                    Exit For
                End If
            Next
        End If

        If isValid = True Then
            Console.Write("string is valid")
        Else
            Console.Write("string is invalid")
        End If
        Console.ReadKey()

    End Sub
End Module