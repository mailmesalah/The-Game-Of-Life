Public Class FormGameOfLife

    Private currentG As Generation = New Generation
    Private initialG As Generation = New Generation

    Private Sub initialiseForm()
        initialiseGrid()        
        currentG.setRow(10)
        currentG.setColumn(10)
    End Sub

    Private Sub initialiseGrid()
        Dim i As Integer

        DGrid.ColumnCount = 10
        DGrid.RowCount = 10
        DGrid.ScrollBars = ScrollBars.Both
        DGrid.ColumnHeadersVisible = False
        DGrid.RowHeadersVisible = False

        While i < DGrid.ColumnCount
            DGrid.Columns(i).Width = 20
            i = i + 1
        End While

        i = 0
        While i < DGrid.RowCount
            DGrid.Rows(i).Height = 20
            i = i + 1
        End While

    End Sub

    Private Sub FormGameOfLife_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialiseForm()
    End Sub

    Private Sub ButtonInitialise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInitialise.Click
        initialiseGrid()
        currentG.setRow(10)
        currentG.setColumn(10)
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Dim i As Integer
        DGrid.ColumnCount = DGrid.ColumnCount + Val(TextBoxColumnNumber.Text)
        DGrid.RowCount = DGrid.RowCount + Val(TextBoxRowNumber.Text)

        currentG.setRow(DGrid.RowCount)
        currentG.setColumn(DGrid.ColumnCount)

        While i < DGrid.ColumnCount
            DGrid.Columns(i).Width = 20
            i = i + 1
        End While

        i = 0
        While i < DGrid.RowCount
            DGrid.Rows(i).Height = 20
            i = i + 1
        End While
    End Sub

    Private Sub ButtonRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemove.Click
        Dim i As Integer

        If DGrid.RowCount - Val(TextBoxRowNumber.Text) < 0 Then
            DGrid.RowCount = 0
            currentG.setRow(0)
        Else
            DGrid.RowCount = DGrid.RowCount - Val(TextBoxRowNumber.Text)
            currentG.setRow(DGrid.RowCount)
        End If

        If (DGrid.ColumnCount - Val(TextBoxColumnNumber.Text)) < 0 Then
            DGrid.ColumnCount = 0
            currentG.setColumn(0)
        Else
            DGrid.ColumnCount = DGrid.ColumnCount - Val(TextBoxColumnNumber.Text)
            currentG.setColumn(DGrid.ColumnCount)
        End If


        While i < DGrid.ColumnCount
            DGrid.Columns(i).Width = 20
            i = i + 1
        End While

        i = 0
        While i < DGrid.RowCount
            DGrid.Rows(i).Height = 20
            i = i + 1
        End While
    End Sub

    Private Sub clearGrid()
        Dim i As Long
        Dim r As Integer, c As Integer

        While i < DGrid.ColumnCount * DGrid.RowCount

            r = i \ DGrid.ColumnCount
            c = i Mod DGrid.ColumnCount

            DGrid.Item(c, r).Style.BackColor = Color.White

            i = i + 1
        End While
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        clearGrid()
        currentG.ClearGrid()
    End Sub

    Private Sub DGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGrid.CellClick
        If currentG.GetGridValue(e.RowIndex, e.ColumnIndex) Then
            currentG.SetGridValue(e.RowIndex, e.ColumnIndex, False)
            DGrid.Item(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.White
            DGrid.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = Color.White

        Else
            currentG.SetGridValue(e.RowIndex, e.ColumnIndex, True)
            DGrid.Item(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DodgerBlue
            DGrid.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = Color.DodgerBlue
        End If
    End Sub

    Private Sub DGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGrid.CellContentClick

    End Sub

    Private Sub ButtonNextGeneration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNextGeneration.Click
        currentG.CopyGeneration(currentG.GetNextGenerations)
        synchronizeCurrentGWithGrid()
    End Sub

    Private Sub synchronizeCurrentGWithGrid()
        Dim i As Long
        Dim r As Integer, c As Integer

        While i < DGrid.ColumnCount * DGrid.RowCount

            r = i \ DGrid.ColumnCount
            c = i Mod DGrid.ColumnCount

            If currentG.GetGridValue(r, c) Then
                DGrid.Item(c, r).Style.BackColor = Color.DodgerBlue
            Else
                DGrid.Item(c, r).Style.BackColor = Color.White
            End If

            i = i + 1
        End While

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        initialG.CopyGeneration(currentG)
    End Sub

    Private Sub ButtonLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoad.Click
        currentG.CopyGeneration(initialG)
        synchronizeCurrentGWithGrid()
    End Sub

    Private Sub DGrid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGrid.Leave
        DGrid.ClearSelection()
    End Sub
End Class
