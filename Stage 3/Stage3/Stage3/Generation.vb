<Serializable()> Public Class Generation
    Public cRow = 0
    Public cColumn = 0
    Public GridRow As List(Of List(Of BooleanValue)) = New List(Of List(Of BooleanValue))


    Public Sub CopyGeneration(ByVal g As Generation)
        setColumn(g.cColumn)
        setRow(g.cRow)

        Dim i, j As Integer

        While i < cRow
            j = 0
            While j < cColumn
                GridRow.ElementAt(i).ElementAt(j).value = g.GridRow.ElementAt(i).ElementAt(j).value
                j = j + 1
            End While
            i = i + 1
        End While
    End Sub

    Public Sub setRow(ByVal rRow As Long)
        cRow = rRow

        If cRow < GridRow.Count Then
            While cRow < GridRow.Count
                GridRow.RemoveAt(GridRow.Count - 1)
            End While
        ElseIf cRow > GridRow.Count Then
            While cRow > GridRow.Count
                Dim l As List(Of BooleanValue) = New List(Of BooleanValue)

                While l.Count < cColumn
                    l.Add(New BooleanValue)
                End While
                GridRow.Add(l)
            End While
        End If
    End Sub

    Public Sub setColumn(ByVal rColumn As Long)
        Dim i As Integer = 0

        If cColumn > rColumn Then
            i = 0
            While i < GridRow.Count
                While GridRow.ElementAt(i).Count > rColumn
                    GridRow.ElementAt(i).RemoveAt(GridRow.ElementAt(i).Count - 1)
                End While
                i = i + 1
            End While

        ElseIf cColumn < rColumn Then
            i = 0
            While i < GridRow.Count
                While GridRow.ElementAt(i).Count < rColumn
                    GridRow.ElementAt(i).Add(New BooleanValue)
                End While
                i = i + 1
            End While
        End If

        cColumn = rColumn
    End Sub

    Sub SetGridValue(ByVal row As Integer, ByVal column As Integer, ByVal value As Boolean)
        GridRow.ElementAt(row).ElementAt(column).value = value
    End Sub

    Function GetGridValue(ByVal row As Integer, ByVal column As Integer) As Boolean
        If row < 0 Or row >= cRow Or column < 0 Or column >= cColumn Then
            Return False
        End If
        Return GridRow.ElementAt(row).ElementAt(column).value
    End Function

    Function GetNextGenerations() As Generation

        Dim NextGeneration As Generation = New Generation()
        Dim row As Integer = 0
        Dim column As Integer = 0
        Dim occasioncount As Integer = 0

        NextGeneration.setRow(cRow)
        NextGeneration.setColumn(cColumn)

        For row = 0 To cRow - 1
            For column = 0 To cColumn - 1
                occasioncount = Occasions(row, column)
                If GetGridValue(row, column) Then
                    If occasioncount >= 2 And occasioncount <= 3 Then
                        NextGeneration.SetGridValue(row, column, True)
                    Else
                        NextGeneration.SetGridValue(row, column, False)
                    End If
                Else
                    If occasioncount = 3 Then
                        NextGeneration.SetGridValue(row, column, True)
                    Else
                        NextGeneration.SetGridValue(row, column, False)
                    End If
                End If
            Next
        Next
        Return NextGeneration

    End Function

    Function Occasions(ByVal row As Integer, ByVal column As Integer)
        Dim cell As Integer = 0
        If GetGridValue(row - 1, column - 1) Then
            cell = cell + 1
        End If
        If GetGridValue(row - 1, column) Then
            cell = cell + 1
        End If
        If GetGridValue(row - 1, column + 1) Then
            cell = cell + 1
        End If
        If GetGridValue(row, column - 1) Then
            cell = cell + 1
        End If
        If GetGridValue(row, column + 1) Then
            cell = cell + 1
        End If
        If GetGridValue(row + 1, column - 1) Then
            cell = cell + 1
        End If
        If GetGridValue(row + 1, column) Then
            cell = cell + 1
        End If
        If GetGridValue(row + 1, column + 1) Then
            cell = cell + 1
        End If
        Return cell
    End Function

    Public Sub ClearGrid()
        Dim row As Integer = 0
        Dim column As Integer = 0

        While row < cRow
            column = 0
            While column < cColumn
                SetGridValue(row, column, False)
                column = column + 1
            End While
            row = row + 1
        End While

    End Sub

    Sub ShowGrid()
        Dim Row As Integer = 0
        Dim column As Integer = 0
        For Row = 0 To cRow
            For column = 0 To cColumn

                If GridRow.ElementAt(Row).ElementAt(column).value Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Class BooleanValue
        Public value As Boolean = False
    End Class

End Class