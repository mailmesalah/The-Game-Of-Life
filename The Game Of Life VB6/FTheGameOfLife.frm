VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form FTheGameOfLife 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "The Game Of Life"
   ClientHeight    =   8505
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   11715
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "Arial Narrow"
      Size            =   11.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "FTheGameOfLife.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8505
   ScaleWidth      =   11715
   StartUpPosition =   1  'CenterOwner
   Begin VB.Timer Timer 
      Interval        =   10
      Left            =   765
      Top             =   390
   End
   Begin VB.CommandButton CRestart 
      Caption         =   "Restart"
      Height          =   505
      Left            =   4005
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   7335
      Width           =   1410
   End
   Begin VB.CommandButton CClear 
      Caption         =   "Clear"
      Height          =   505
      Left            =   2535
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   7350
      Width           =   1410
   End
   Begin VB.CommandButton CClose 
      Cancel          =   -1  'True
      Caption         =   "Close"
      Height          =   505
      Left            =   9060
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   7860
      Width           =   1380
   End
   Begin VB.CommandButton CPlayPause 
      Caption         =   "Play"
      Height          =   505
      Left            =   1095
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   7350
      Width           =   1380
   End
   Begin MSFlexGridLib.MSFlexGrid MGrid 
      Height          =   5880
      Left            =   930
      TabIndex        =   0
      Top             =   1005
      Width           =   9780
      _ExtentX        =   17251
      _ExtentY        =   10372
      _Version        =   393216
      Rows            =   0
      FixedRows       =   0
      FixedCols       =   0
      BackColorBkg    =   16777215
      GridColorFixed  =   12632256
      AllowBigSelection=   0   'False
      FocusRect       =   0
      HighLight       =   0
      ScrollBars      =   0
      BorderStyle     =   0
      Appearance      =   0
   End
End
Attribute VB_Name = "FTheGameOfLife"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim nextG1() As Long
Dim nextG2() As Long
Dim nG As Long

Private Sub MGridInitialise()
'INITIALISES MGRID
    Dim r As Long
    
    MGrid.Clear
    MGrid.Cols = 10
    MGrid.Rows = 10
    MGrid.FixedCols = 0
    MGrid.FixedRows = 0
    
    While r < MGrid.Cols
        MGrid.ColWidth(r) = 200
        r = r + 1
    Wend
    r = 0
    While r < MGrid.Rows
        MGrid.RowHeight(r) = 200
        r = r + 1
    Wend
    'MGrid.RowHeightMin = 10
End Sub

Private Sub CClose_Click()
    End
End Sub

Private Sub CPlayPause_Click()
    If CPlayPause.Caption = "Play" Then
        CPlayPause.Caption = "Pause"
    Else
        CPlayPause.Caption = "Play"
    End If
End Sub

Private Sub Form_Load()
    MGridInitialise
    ReDim nextG1(MGrid.Rows, MGrid.Cols) As Long
    ReDim nextG2(MGrid.Rows, MGrid.Cols) As Long
    nG = 1
End Sub

Private Sub MGrid_Click()
    If CPlayPause.Caption = "Play" Then
        If MGrid.CellBackColor = 0 Then
            MGrid.CellBackColor = &H8000000D
            If nG = 1 Then
                nextG1(MGrid.Row, MGrid.Col) = 1
            Else
                nextG2(MGrid.Row, MGrid.Col) = 1
            End If
        Else
            MGrid.CellBackColor = 0
            If nG = 1 Then
                nextG1(MGrid.Row, MGrid.Col) = 0
            Else
                nextG2(MGrid.Row, MGrid.Col) = 0
            End If
        End If
    End If
End Sub

Private Sub nextGeneration()
    Dim r As Long, c As Long
    
    If nG = 1 Then
        
        While r < MGrid.Rows
            c = 0
            While c < MGrid.Cols
                
                MGrid.Row = r
                MGrid.Col = c
                If nextG1(r, c) = 1 Then
                    nextG2(r, c) = dies(r, c)
                    MGrid.CellBackColor = IIf(nextG2(r, c) = 0, 0, &H8000000D)
                Else
                    nextG2(r, c) = borns(r, c)
                    MGrid.CellBackColor = IIf(nextG2(r, c) = 0, 0, &H8000000D)
                End If
            
                c = c + 1
            Wend
            r = r + 1
        Wend
        
        nG = 2
    Else
        
        While r < MGrid.Rows
            c = 0
            While c < MGrid.Cols
                
                MGrid.Row = r
                MGrid.Col = c
                If nextG2(r, c) = 1 Then
                    nextG1(r, c) = dies(r, c)
                    MGrid.CellBackColor = IIf(nextG1(r, c) = 0, 0, &H8000000D)
                Else
                    nextG1(r, c) = borns(r, c)
                    MGrid.CellBackColor = IIf(nextG1(r, c) = 0, 0, &H8000000D)
                End If
            
                c = c + 1
            Wend
            r = r + 1
        Wend
        
        nG = 1
    End If
'
'    r = 0
'    c = 0
'    While r < MGrid.Rows
'
'        c = 0
'        While c < MGrid.Cols
'
'            MGrid.Row = r
'            MGrid.Col = c
'            If nextG(r, c) = 1 Then
'                MGrid.CellBackColor = &H8000000D
'            Else
'                MGrid.CellBackColor = 0
'            End If
'
'            c = c + 1
'        Wend
'        r = r + 1
'    Wend
    
    MGrid.Refresh
End Sub

Private Function borns(r As Long, c As Long) As Long
    If countCrowd(r, c) = 3 Then
        borns = 1
    Else
        borns = 0
    End If
End Function

Private Function dies(r As Long, c As Long) As Long
    If countCrowd(r, c) = 2 Or countCrowd(r, c) = 3 Then
        dies = 1
    Else
        dies = 0
    End If
End Function

Private Function countCrowd(r As Long, c As Long)
    Dim count As Long
    Dim i As Long, j As Long
    
    i = r - 1
    j = c - 1
    
    While i <= r + 1
        
        j = c - 1
        While j <= c + 1
            If (i >= 0 And j >= 0 And i < MGrid.Rows And j < MGrid.Cols And (i <> r Or j <> c)) Then
                
                If nG = 1 Then
                    If nextG1(i, j) = 1 Then
                        count = count + 1
                    End If
                Else
                    If nextG2(i, j) = 1 Then
                        count = count + 1
                    End If
                End If
            End If
            j = j + 1
        Wend
        i = i + 1
    Wend
    
    countCrowd = count
End Function

Private Sub Timer_Timer()
    If CPlayPause.Caption = "Pause" Then
        DoEvents
        Timer.Enabled = False
        nextGeneration
        MGrid.Refresh
        Timer.Enabled = True
    End If
End Sub
