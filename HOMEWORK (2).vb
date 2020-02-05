

Module Module1
    Dim name, ID As String

    Sub Main()
        Dim choice As Integer
        Dim valid As Boolean
        valid = False

        Do Until valid = True
            Console.WriteLine("Choose an option please")
            Console.WriteLine("")
            Console.WriteLine("1. Create file and enter information")
            Console.WriteLine("2. Output a file's contents")
            Console.WriteLine("3. Search for a member's name in a file")
            Console.WriteLine("4. Add new data in a file for new member(s)")
            Console.WriteLine("5. Add telephone numbers in new records")
            choice = Console.ReadLine
            If choice < 1 Or choice > 5 Then
                Console.Clear()
                Console.WriteLine("Enter a valid number")
            Else
                valid = True
            End If
        Loop
        If choice = 1 Then Call filecreate()
        If choice = 2 Then Call outputcont()
        If choice = 3 Then Call searchfile()
        If choice = 4 Then Call adddata()
        If choice = 5 Then Call additionalinfo()

        Console.ReadKey()
    End Sub


    Sub filecreate()
        Dim FN As String
        Console.Clear()

        Console.Write("File Name: ")
        FN = Console.ReadLine
        FileOpen(1, "D:/" & FN & ".txt", OpenMode.Output)

        Console.Write("Enter Member's Name: ")
        name = Console.ReadLine
        name = LCase(name)
        Console.Write("Enter Member's ID: ")
        ID = Console.ReadLine
        WriteLine(1, name)
        WriteLine(1, ID)

        FileClose(1)

    End Sub

    Sub outputcont()
        Dim FN As String
        Console.Clear()

        Console.Write("File Name: ")
        FN = Console.ReadLine
        FileOpen(1, "D:/" & FN & ".txt", OpenMode.Input)

        Do Until EOF(1)
            Input(1, name)
            Input(1, ID)
            Console.WriteLine("Name: " & name)
            Console.WriteLine("ID: " & ID)
        Loop
        FileClose(1)

    End Sub

    Sub searchfile()
        Dim FN, search As String
        Dim found As Boolean
        found = False
        search = ""

        Console.Clear()
        Console.Write("File Name: ")
        FN = Console.ReadLine
        FileOpen(1, "D:/" & FN & ".txt", OpenMode.Input)
        Console.Write("Enter Name: ")
        search = Console.ReadLine

        Do Until EOF(1)
            While found = False
                Input(1, name)
                Input(1, ID)
                If name = search Then
                    Console.WriteLine("Name found and the corresponding ID is " & ID)
                    found = True
                End If
            End While
        Loop
        FileClose(1)

    End Sub

    Sub adddata()
        Dim FN, name2, id2 As String
        Console.Clear()
        Console.Write("File Name: ")
        FN = Console.ReadLine


        FileOpen(1, "D:/" & FN & ".txt", OpenMode.Append)
        Console.Write("Enter Name: ")
        name2 = Console.ReadLine
        name2 = LCase(name2
                      )
        Console.Write("Enter ID: ")
        id2 = Console.ReadLine
        WriteLine(1, name2)
        WriteLine(1, id2)
        FileClose(1)

    End Sub

    Sub additionalinfo()
        Dim phone As String
        Dim start As Date
        Dim FN As String

        Console.Write("Enter Name: ")
        name = Console.ReadLine
        Console.Write("Enter ID: ")
        ID = Console.ReadLine
        Console.Write("Enter Phone Number: ")
        phone = Console.ReadLine
        Console.Write("Enter Date of joining: ")
        start = Console.ReadLine()
        Console.Write("File Name: ")
        FN = Console.ReadLine

        FileOpen(1, "D:/" & FN & ".txt", OpenMode.Output)
        WriteLine(1, name)
        WriteLine(1, ID)
        WriteLine(1, phone)
        WriteLine(1, start)

        FileClose(1)



    End Sub

End Module
