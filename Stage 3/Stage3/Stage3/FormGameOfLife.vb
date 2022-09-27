Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class FormGameOfLife

    Private currentG As Generation = New Generation
    Private initialG As Generation = New Generation
    Private previousG As Generation = New Generation

    Private Menus As List(Of GenerationWithName) = New List(Of GenerationWithName)
    Private serializer As New System.Xml.Serialization.XmlSerializer(GetType(List(Of GenerationWithName)))

    Private Class CBirthnDeath
        Public Stage As Integer
        Public BirthOrDeath As Integer
    End Class

    Private Sub ShowStatusBetween()

        Dim gStage, gBirth, gDeath As Integer
        Dim dMaxBirth, dMinBirth, dMaxDeath, dMinDeath As Integer
        Dim i, StartIndex, EndIndex As Integer

        Dim MaxBirth As List(Of CBirthnDeath) = New List(Of CBirthnDeath)
        Dim MaxDeath As List(Of CBirthnDeath) = New List(Of CBirthnDeath)
        Dim MinBirth As List(Of CBirthnDeath) = New List(Of CBirthnDeath)
        Dim MinDeath As List(Of CBirthnDeath) = New List(Of CBirthnDeath)

        dMinBirth = 10000
        dMinDeath = 10000

        gStage = 0
        gBirth = 1
        gDeath = 2

        DStatus.Rows.Clear()

        If Val(TextBoxFromStage.Text) > 0 Then
            StartIndex = Val(TextBoxFromStage.Text) - 1
        Else
            StartIndex = 0
        End If

        If Val(TextBoxToStage.Text) > 0 Then
            EndIndex = Val(TextBoxFromStage.Text)
        Else
            EndIndex = DReport.RowCount
        End If

        i = StartIndex
        While i < EndIndex
            'Finding Maximum Births in Stages
            If Val(DReport.Item(gBirth, i).Value) >= dMaxBirth Then
                If Val(DReport.Item(gBirth, i).Value) = dMaxBirth Then
                    Dim temp As CBirthnDeath = New CBirthnDeath
                    temp.Stage = Val(DReport.Item(gStage, i).Value)
                    temp.BirthOrDeath = Val(DReport.Item(gBirth, i).Value)
                    MaxBirth.Add(temp)                    
                Else
                    MaxBirth.Clear()
                    Dim temp As CBirthnDeath = New CBirthnDeath
                    temp.Stage = Val(DReport.Item(gStage, i).Value)
                    temp.BirthOrDeath = Val(DReport.Item(gBirth, i).Value)
                    MaxBirth.Add(temp)
                    dMaxBirth = Val(DReport.Item(gBirth, i).Value)
                End If
            End If

            'Finding Maximum Deaths in Stages
            If Val(DReport.Item(gDeath, i).Value) >= dMaxDeath Then
                If Val(DReport.Item(gDeath, i).Value) = dMaxDeath Then
                    Dim temp As CBirthnDeath = New CBirthnDeath
                    temp.Stage = Val(DReport.Item(gStage, i).Value)
                    temp.BirthOrDeath = Val(DReport.Item(gDeath, i).Value)
                    MaxDeath.Add(temp)
                Else
                    MaxDeath.Clear()
                    Dim temp As CBirthnDeath = New CBirthnDeath
                    temp.Stage = Val(DReport.Item(gStage, i).Value)
                    temp.BirthOrDeath = Val(DReport.Item(gDeath, i).Value)
                    MaxDeath.Add(temp)
                    dMaxDeath = Val(DReport.Item(gDeath, i).Value)
                End If
            End If

            'Finding Minimum Births in Stages
            If Val(DReport.Item(gBirth, i).Value) <= dMinBirth Then
                If Val(DReport.Item(gBirth, i).Value) = dMinBirth Then
                    Dim temp As CBirthnDeath = New CBirthnDeath
                    temp.Stage = Val(DReport.Item(gStage, i).Value)
                    temp.BirthOrDeath = Val(DReport.Item(gBirth, i).Value)
                    MinBirth.Add(temp)
                Else
                    MinBirth.Clear()
                    Dim temp As CBirthnDeath = New CBirthnDeath
                    temp.Stage = Val(DReport.Item(gStage, i).Value)
                    temp.BirthOrDeath = Val(DReport.Item(gBirth, i).Value)
                    MinBirth.Add(temp)
                    dMinBirth = Val(DReport.Item(gBirth, i).Value)
                End If
            End If

            'Finding Minimum Deaths in Stages
            If Val(DReport.Item(gDeath, i).Value) <= dMinDeath Then
                If Val(DReport.Item(gDeath, i).Value) = dMinDeath Then
                    Dim temp As CBirthnDeath = New CBirthnDeath
                    temp.Stage = Val(DReport.Item(gStage, i).Value)
                    temp.BirthOrDeath = Val(DReport.Item(gDeath, i).Value)
                    MinDeath.Add(temp)
                Else
                    MinDeath.Clear()
                    Dim temp As CBirthnDeath = New CBirthnDeath
                    temp.Stage = Val(DReport.Item(gStage, i).Value)
                    temp.BirthOrDeath = Val(DReport.Item(gDeath, i).Value)
                    MinDeath.Add(temp)
                    dMinDeath = Val(DReport.Item(gDeath, i).Value)
                End If
            End If
            i = i + 1
        End While

        i = 0
        While i < MaxBirth.Count
            Dim row As String() = New String() {MaxBirth.ElementAt(i).Stage, "Maximum Birth", MaxBirth.ElementAt(i).BirthOrDeath}
            DStatus.Rows.Add(row)
            DStatus.Item(0, DStatus.RowCount - 1).Style.BackColor = Color.Chocolate
            DStatus.Item(1, DStatus.RowCount - 1).Style.BackColor = Color.Chocolate
            DStatus.Item(2, DStatus.RowCount - 1).Style.BackColor = Color.Chocolate
            i = i + 1
        End While

        i = 0
        While i < MaxDeath.Count
            Dim row As String() = New String() {MaxDeath.ElementAt(i).Stage, "Maximum Death", MaxDeath.ElementAt(i).BirthOrDeath}
            DStatus.Rows.Add(row)
            DStatus.Item(0, DStatus.RowCount - 1).Style.BackColor = Color.CornflowerBlue
            DStatus.Item(1, DStatus.RowCount - 1).Style.BackColor = Color.CornflowerBlue
            DStatus.Item(2, DStatus.RowCount - 1).Style.BackColor = Color.CornflowerBlue
            i = i + 1
        End While

        i = 0
        While i < MinBirth.Count
            Dim row As String() = New String() {MinBirth.ElementAt(i).Stage, "Minimum Birth", MinBirth.ElementAt(i).BirthOrDeath}
            DStatus.Rows.Add(row)
            DStatus.Item(0, DStatus.RowCount - 1).Style.BackColor = Color.Crimson
            DStatus.Item(1, DStatus.RowCount - 1).Style.BackColor = Color.Crimson
            DStatus.Item(2, DStatus.RowCount - 1).Style.BackColor = Color.Crimson
            i = i + 1
        End While

        i = 0
        While i < MinDeath.Count
            Dim row As String() = New String() {MinDeath.ElementAt(i).Stage, "Minimum Death", MinDeath.ElementAt(i).BirthOrDeath}
            DStatus.Rows.Add(row)
            DStatus.Item(0, DStatus.RowCount - 1).Style.BackColor = Color.Cyan
            DStatus.Item(1, DStatus.RowCount - 1).Style.BackColor = Color.Cyan
            DStatus.Item(2, DStatus.RowCount - 1).Style.BackColor = Color.Cyan
            i = i + 1
        End While

        DStatus.ClearSelection()
    End Sub


    Private Sub SaveGenerations()
        Dim myFileStream As StreamWriter = New IO.StreamWriter("SavedUniverse.bin", False)
        serializer.Serialize(myFileStream, Menus)
        myFileStream.Close()
    End Sub

    Private Sub GetGenerations()
        If File.Exists("SavedUniverse.bin") Then
            Dim myFileStream As StreamReader = New IO.StreamReader("SavedUniverse.bin")
            Menus = CType(serializer.Deserialize(myFileStream), List(Of GenerationWithName))
            myFileStream.Close()
        End If
    End Sub

    Private Sub LoadMenus()
        Dim i As Integer

        TSMMenu.DropDownItems.Clear()
        While i < Menus.Count
            Dim Item As New ToolStripMenuItem
            Item.Text = Menus.ElementAt(i).Name
            TSMMenu.DropDownItems.Add(Item)
            AddHandler Item.Click, New EventHandler(AddressOf OptionClick)
            AddHandler Item.MouseUp, New MouseEventHandler(AddressOf OptionMouseUp)


            i = i + 1
        End While
        
    End Sub

    Private Sub OptionClick(ByVal sender As Object, ByVal e As EventArgs)

        Dim itemClicked As New ToolStripMenuItem
        itemClicked = CType(sender, ToolStripMenuItem)
        currentG.CopyGeneration(Menus.ElementAt(TSMMenu.DropDownItems.IndexOf(itemClicked)).Gen)
        synchronizeCurrentGWithGrid()
    End Sub

    Private Sub OptionMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim itemClicked As New ToolStripMenuItem
        itemClicked = CType(sender, ToolStripMenuItem)

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Menus.RemoveAt(TSMMenu.DropDownItems.IndexOf(itemClicked))
            TSMMenu.DropDownItems.Remove(itemClicked)
            SaveGenerations()
            Menus.Clear()
            GetGenerations()
            LoadMenus()
        End If
        
    End Sub

    Private Sub initialiseForm()
        initialiseGrid()
        currentG.setRow(10)
        currentG.setColumn(10)
        GetGenerations()
        LoadMenus()
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
        GetGenerations()
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
        DReport.Rows.Clear()
        DStatus.Rows.Clear()
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
        previousG.CopyGeneration(currentG)
        currentG.CopyGeneration(currentG.GetNextGenerations)
        synchronizeCurrentGWithGrid()
        AddReport()
    End Sub

    Private Sub AddReport()
        Dim birth, death As Long
        Dim i, j As Integer

        While i < currentG.cRow
            j = 0
            While j < currentG.cColumn
                If previousG.GetGridValue(i, j) Then
                    If Not currentG.GetGridValue(i, j) Then
                        death = death + 1
                    Else
                        DGrid.Item(j, i).Style.BackColor = Color.DodgerBlue
                    End If
                End If

                If Not previousG.GetGridValue(i, j) Then                    
                    If currentG.GetGridValue(i, j) Then
                        birth = birth + 1
                        DGrid.Item(j, i).Style.BackColor = Color.Cyan                    
                    End If
                End If
                j = j + 1
            End While
            i = i + 1
        End While

        Dim row As String() = New String() {(DReport.RowCount + 1).ToString, birth.ToString, death.ToString}
        DReport.Rows.Add(row)
        DReport.FirstDisplayedScrollingRowIndex = DReport.RowCount - 1

        DReport.Item(0, DReport.RowCount - 1).Style.BackColor = Color.Aqua
        DReport.Item(1, DReport.RowCount - 1).Style.BackColor = Color.Aqua
        DReport.Item(2, DReport.RowCount - 1).Style.BackColor = Color.Aqua
        If DReport.RowCount > 1 Then
            DReport.Item(0, DReport.RowCount - 2).Style.BackColor = Color.Aquamarine
            DReport.Item(1, DReport.RowCount - 2).Style.BackColor = Color.Aquamarine
            DReport.Item(2, DReport.RowCount - 2).Style.BackColor = Color.Aquamarine
        End If
        If DReport.RowCount > 2 Then
            DReport.Item(0, DReport.RowCount - 3).Style.BackColor = Color.White
            DReport.Item(1, DReport.RowCount - 3).Style.BackColor = Color.White
            DReport.Item(2, DReport.RowCount - 3).Style.BackColor = Color.White
        End If

        ShowStatusBetween()
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
        Dim SaveG As GenerationWithName = New GenerationWithName
        SaveG.Name = "Generation at " & TimeOfDay.Date & TimeOfDay.Minute & TimeOfDay.Millisecond
        SaveG.Gen = New Generation
        SaveG.Gen.CopyGeneration(currentG)

        Menus.Add(SaveG)
        SaveGenerations()
        Menus.Clear()
        GetGenerations()
        LoadMenus()
    End Sub

    Private Sub DGrid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGrid.Leave
        DGrid.ClearSelection()
    End Sub

    <Serializable()> Public Class GenerationWithName
        Public Gen As Generation
        Public Name As String
    End Class

    Private Sub DStatus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DStatus.CellContentClick

    End Sub

    Private Sub DStatus_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DStatus.Leave
        DStatus.ClearSelection()
    End Sub

    Private Sub TextBoxFromStage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxFromStage.TextChanged
        ShowStatusBetween()
    End Sub

    Private Sub TextBoxToStage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxToStage.TextChanged
        ShowStatusBetween()
    End Sub
End Class
