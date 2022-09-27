Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class FTheGameOfLife

    Private universeOfOrganism As New List(Of COrganismPlaceHolder)
    Private iCol As Integer
    Private iRow As Integer
    Private isPlaying As Boolean = False
    Private stageNo As Long
    Delegate Sub forThreadSafe(ByVal birth As Long, ByVal death As Long)

    Private Sub saveGeneration()
        Dim myFileStream As Stream = File.Create("SaveUniverse.bin")
        Dim serializer As New BinaryFormatter()
        serializer.Serialize(myFileStream, universeOfOrganism)
        myFileStream.Close()
    End Sub

    Private Function getGeneration() As List(Of COrganismPlaceHolder)
        If File.Exists("SavedUniverse.bin") Then
            Dim myFileStream As Stream = File.OpenRead("SavedUniverse.bin")
            Dim deserializer As New BinaryFormatter()
            universeOfOrganism = CType(deserializer.Deserialize(myFileStream), List(Of COrganismPlaceHolder))
            myFileStream.Close()
        End If
        getGeneration = universeOfOrganism
    End Function

    Private Sub addCurrentGToGrid(ByVal birth As Long, ByVal death As Long)

        If DGVReport.InvokeRequired Then
            Dim d As New forThreadSafe(AddressOf addCurrentGToGrid)
            Invoke(d, New Object() {birth, death})
        Else
            stageNo = stageNo + 1
            Dim row As String() = New String() {stageNo.ToString, birth.ToString, death.ToString}
            DGVReport.Rows.Add(row)
        End If

    End Sub

    Private Sub moveTimeLine()
        While isPlaying
            generateNextG()
            Threading.Thread.Sleep(500)
        End While
    End Sub

    Private Sub clearAllG()
        Dim i As Long

        While i < DGVGrid.RowCount * DGVGrid.ColumnCount
            universeOfOrganism(i).isCurrentGOrganismExist = False
            universeOfOrganism(i).isNextGOrganismExist = False
            i = i + 1
        End While
    End Sub

    Private Sub setInitialGToCurrentG()
        Dim i As Long
        Dim r As Integer, c As Integer

        While i < DGVGrid.RowCount * DGVGrid.ColumnCount
            universeOfOrganism(i).isCurrentGOrganismExist = universeOfOrganism(i).isInitialGOrganismExist

            r = i \ DGVGrid.ColumnCount
            c = i Mod DGVGrid.ColumnCount

            If universeOfOrganism(i).isCurrentGOrganismExist Then
                DGVGrid.Item(c, r).Style.BackColor = Color.DodgerBlue
            Else
                DGVGrid.Item(c, r).Style.BackColor = Color.White
            End If

            i = i + 1
        End While
    End Sub

    Private Sub setInitialG()
        Dim i As Long

        While i < DGVGrid.RowCount * DGVGrid.ColumnCount
            universeOfOrganism(i).isInitialGOrganismExist = universeOfOrganism(i).isCurrentGOrganismExist
            i = i + 1
        End While
    End Sub

    Private Sub setNextGAsCurrentG()
        Dim i As Long

        While i < DGVGrid.RowCount * DGVGrid.ColumnCount
            universeOfOrganism(i).isCurrentGOrganismExist = universeOfOrganism(i).isNextGOrganismExist
            i = i + 1
        End While
    End Sub

    Private Sub generateNextG()
        Dim i As Long
        Dim r As Integer, c As Integer
        Dim birthCount As Long, deathCount As Long

        While i < DGVGrid.ColumnCount * DGVGrid.RowCount

            r = i \ DGVGrid.ColumnCount
            c = i Mod DGVGrid.ColumnCount

            If universeOfOrganism(i).isCurrentGOrganismExist Then
                If deathOfOrganism(i) Then
                    DGVGrid.Item(c, r).Style.BackColor = Color.DodgerBlue
                    universeOfOrganism(i).isNextGOrganismExist = True
                Else
                    DGVGrid.Item(c, r).Style.BackColor = Color.White
                    universeOfOrganism(i).isNextGOrganismExist = False
                    deathCount = deathCount + 1
                End If
            Else
                If birthOfOrganism(i) Then
                    DGVGrid.Item(c, r).Style.BackColor = Color.DodgerBlue
                    universeOfOrganism(i).isNextGOrganismExist = True
                    birthCount = birthCount + 1
                Else
                    DGVGrid.Item(c, r).Style.BackColor = Color.White
                    universeOfOrganism(i).isNextGOrganismExist = False
                End If
            End If
            i = i + 1
        End While
        addCurrentGToGrid(birthCount, deathCount)
        setNextGAsCurrentG()
    End Sub

    Private Function birthOfOrganism(ByVal i As Integer) As Boolean
        If countCrowdArround(i) = 3 Then
            birthOfOrganism = True
        Else
            birthOfOrganism = False
        End If
    End Function

    Private Function deathOfOrganism(ByVal i As Integer) As Boolean
        If countCrowdArround(i) = 2 Or countCrowdArround(i) = 3 Then
            deathOfOrganism = True
        Else
            deathOfOrganism = False
        End If
    End Function

    Private Function countCrowdArround(ByVal indX As Integer) As Long
        Dim i As Long, count As Long, lStart As Long, lEnd As Long

        If indX Mod DGVGrid.ColumnCount = 1 Then
            lStart = indX - DGVGrid.ColumnCount
        Else
            lStart = indX - DGVGrid.ColumnCount - 1
        End If

        If indX Mod DGVGrid.ColumnCount = 0 Then
            lEnd = indX - DGVGrid.ColumnCount
        Else
            lEnd = indX - DGVGrid.ColumnCount + 1
        End If

        i = lStart
        While i <= lEnd
            If i >= 0 Then
                If universeOfOrganism(i).isCurrentGOrganismExist Then
                    count = count + 1
                End If
            End If
            i = i + 1
        End While

        If indX Mod DGVGrid.ColumnCount = 1 Then
            lStart = indX
        Else
            lStart = indX - 1
        End If

        If indX Mod DGVGrid.ColumnCount = 0 Then
            lEnd = indX
        Else
            lEnd = indX + 1
        End If

        i = lStart
        While i <= lEnd
            If i >= 0 And i <> indX And i < DGVGrid.RowCount * DGVGrid.ColumnCount Then
                If universeOfOrganism(i).isCurrentGOrganismExist Then
                    count = count + 1
                End If
            End If
            i = i + 1
        End While


        If indX Mod DGVGrid.ColumnCount = 1 Then
            lStart = indX + DGVGrid.ColumnCount
        Else
            lStart = indX + DGVGrid.ColumnCount - 1
        End If

        If indX Mod DGVGrid.ColumnCount = 0 Then
            lEnd = indX + DGVGrid.ColumnCount
        Else
            lEnd = indX + DGVGrid.ColumnCount + 1
        End If

        i = lStart
        While i <= lEnd
            If i < DGVGrid.RowCount * DGVGrid.ColumnCount Then
                If universeOfOrganism(i).isCurrentGOrganismExist Then
                    count = count + 1
                End If
            End If
            i = i + 1
        End While

        countCrowdArround = count
    End Function

    Private Sub initialiseGrid()
        Dim i As Integer

        DGVGrid.ColumnCount = 40
        DGVGrid.RowCount = 30
        DGVGrid.ScrollBars = ScrollBars.None
        DGVGrid.ColumnHeadersVisible = False
        DGVGrid.RowHeadersVisible = False

        While i < DGVGrid.ColumnCount
            DGVGrid.Columns(i).Width = 20
            i = i + 1
        End While

        i = 0
        While i < DGVGrid.RowCount
            DGVGrid.Rows(i).Height = 20
            i = i + 1
        End While

        i = 0
        While i < DGVGrid.ColumnCount * DGVGrid.RowCount
            universeOfOrganism.Add(New COrganismPlaceHolder)
            i = i + 1
        End While

    End Sub

    Private Sub initialiseReportGrid()

        DGVReport.ColumnCount = 3
        DGVReport.RowCount = 3
        DGVReport.ScrollBars = ScrollBars.None
        DGVReport.ColumnHeadersVisible = True
        DGVReport.RowHeadersVisible = True

    End Sub

    Private Sub clearGrid()
        Dim i As Long
        Dim r As Integer, c As Integer

        While i < DGVGrid.ColumnCount * DGVGrid.RowCount

            r = i \ DGVGrid.ColumnCount
            c = i Mod DGVGrid.ColumnCount

            DGVGrid.Item(c, r).Style.BackColor = Color.White

            i = i + 1
        End While
    End Sub

    Private Sub BClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BClose.Click
        isPlaying = False
        Me.Close()
    End Sub

    Private Sub FTheGameOfLife_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialiseGrid()
    End Sub

    Private Sub BPlayPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPlayPause.Click
        If BPlayPause.Text = "Play" Then
            BPlayPause.Text = "Pause"
            setInitialG()
            isPlaying = True
            Dim threadLife As New Threading.Thread(AddressOf moveTimeLine)
            threadLife.Start()
        Else
            isPlaying = False
            BPlayPause.Text = "Play"
        End If
    End Sub

    Private Sub DGVGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVGrid.CellClick
        If BPlayPause.Text = "Play" Then
            If universeOfOrganism(e.RowIndex * DGVGrid.ColumnCount + e.ColumnIndex).isCurrentGOrganismExist Then
                universeOfOrganism(e.RowIndex * DGVGrid.ColumnCount + e.ColumnIndex).isCurrentGOrganismExist = False
                DGVGrid.Item(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.White
                DGVGrid.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = Color.White
                iCol = e.ColumnIndex
                iRow = e.RowIndex
            Else
                universeOfOrganism(e.RowIndex * DGVGrid.ColumnCount + e.ColumnIndex).isCurrentGOrganismExist = True
                DGVGrid.Item(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DodgerBlue
                DGVGrid.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = Color.DodgerBlue
                iCol = e.ColumnIndex
                iRow = e.RowIndex
            End If
        End If
    End Sub

    Private Sub BClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BClear.Click
        clearGrid()
        clearAllG()
        stageNo = 0
        DGVReport.Rows.Clear()
    End Sub

    Private Sub BRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRestart.Click
        setInitialGToCurrentG()
        stageNo = 0
        DGVReport.Rows.Clear()
    End Sub

    Private Sub DGVGrid_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVGrid.Leave
        'DGVGrid.Item(iCol, iRow).Style.SelectionBackColor = Color.White
        DGVGrid.ClearSelection()
    End Sub

    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        saveGeneration()

        Dim Item As New ToolStripMenuItem
        Item.Text = "First Menu"
        TSMMenu.DropDownItems.Add(Item)
        AddHandler Item.Click, New System.EventHandler(AddressOf OptionClick)
    End Sub

    Private Sub OptionClick(ByVal sender As Object, ByVal e As EventArgs)

        Dim itemClicked As New ToolStripMenuItem
        itemClicked = CType(sender, ToolStripMenuItem)
        MsgBox("You have selected the item" & itemClicked.Text)

    End Sub

    Private Sub DGVGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVGrid.CellContentClick

    End Sub
End Class
