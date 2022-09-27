Public Class Generation
    Public Const cRow = 9
    Public Const cColumn = 9
    Dim grid(cRow, cColumn) As Boolean

    Sub GridValue(ByVal row As Integer, ByVal column As Integer, ByVal value As Boolean)
        grid(row, column) = value
    End Sub

    Function GridNumber(ByVal row As Integer, ByVal column As Integer)
        If row < 0 Or row > cRow Or column < 0 Or column > cColumn Then
            Return False
        End If
        Return grid(row, column)
    End Function

    Function Generations()

        Dim NextGeneration As Generation = New Generation()
        Dim row As Integer = 0
        Dim column As Integer = 0
        Dim occasioncount As Integer = 0

        For row = 0 To cRow
            For column = 0 To cColumn
                occasioncount = Occasions(row, column)
                If GridNumber(row, column) Then
                    If occasioncount >= 2 And occasioncount <= 3 Then
                        NextGeneration.GridValue(row, column, True)
                    Else
                        NextGeneration.GridValue(row, column, False)
                    End If
                Else
                    If occasioncount = 3 Then
                        NextGeneration.GridValue(row, column, True)
                    Else
                        NextGeneration.GridValue(row, column, False)
                    End If
                End If
            Next
        Next
        Return NextGeneration

    End Function

    Function Occasions(ByVal row As Integer, ByVal column As Integer)
        Dim cell As Integer = 0
        If GridNumber(row - 1, column - 1) Then
            cell = cell + 1
        End If
        If GridNumber(row - 1, column) Then
            cell = cell + 1
        End If
        If GridNumber(row - 1, column + 1) Then
            cell = cell + 1
        End If
        If GridNumber(row, column - 1) Then
            cell = cell + 1
        End If
        If GridNumber(row, column + 1) Then
            cell = cell + 1
        End If
        If GridNumber(row + 1, column - 1) Then
            cell = cell + 1
        End If
        If GridNumber(row + 1, column) Then
            cell = cell + 1
        End If
        If GridNumber(row + 1, column + 1) Then
            cell = cell + 1
        End If
        Return cell
    End Function

    Sub ShowGrid()
        Dim Row As Integer = 0
        Dim column As Integer = 0
        For Row = 0 To cRow
            For column = 0 To cColumn

                If grid(Row, column) Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub
End Class