Module Module1

    Sub Main()
        Dim firstSTR As String
        Dim SecondSTR As String
        Dim spacepos As Integer
        Dim Fname As String
        Dim Lname As String

        firstSTR = ""
        SecondSTR = ""
        spacepos = 0
        Fname = ""
        Lname = ""



        Console.Write("Enter first string: ")
        firstSTR = Console.ReadLine

        Console.Write("enter second string: ")
        SecondSTR = Console.ReadLine

        spacepos = InStr(firstSTR, " ")
        Fname = Left(firstSTR, spacepos)

        spacepos = InStr(SecondSTR, " ")
        Lname = Mid(SecondSTR, spacepos + 1, Len(SecondSTR))

        Console.Write(Fname & Lname)
        Console.ReadKey()


    End Sub

End Module
