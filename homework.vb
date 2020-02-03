Imports System.IO

Module Module1

    Sub Main()
        Dim membershipfile As New IO.FileStream("D:\membership.txt", IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, IO.FileShare.None)
        membershipfile.Close()
        '--------------------------

        Dim x As String
        Dim y As System.IO.StreamReader
        y = New IO.StreamReader("D:\membership.txt")
        Do Until y.EndOfStream
            x = y.ReadLine()
            Console.WriteLine(x)
        Loop
        y.Close()
        '--------------------------





        Console.ReadKey()
    End Sub

End Module
