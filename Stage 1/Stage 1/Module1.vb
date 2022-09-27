Module Module1

    Sub Main()
        Dim Row As Integer
        Dim Column As Integer
        Dim Repeat As Integer = 1
        Dim CurrentGen As generation = New generation()
        Dim GenNumbers As Integer
        Dim Generations As Integer


        While Repeat = 1
            Console.WriteLine("Please choose row number from 1 - 10")
            Row = Console.ReadLine()
            Console.WriteLine("Please choose column number from 1 - 10")
            Column = Console.ReadLine()
            Console.WriteLine("Organism insterted into Row " & Row & ", Column " & Column)
            CurrentGen.GridValue(Row - 1, Column - 1, True)
            Console.WriteLine()


            Console.WriteLine("Would you like to enter another organism? Y/N")
            If Console.ReadLine.ToUpper = "Y" Then
                Repeat = 1
            Else
                Repeat = 0
            End If
        End While

        Console.WriteLine("Please Enter the Amount of Generations Required")
        GenNumbers = Console.ReadLine

        For Generations = 0 To GenNumbers - 1

        Next

        For Generations = 0 To GenNumbers - 1
            Console.Clear()
            CurrentGen.ShowGrid()
            CurrentGen = CurrentGen.Generations()
            Console.ReadLine()
        Next
    End Sub

End Module

