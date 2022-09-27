<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTheGameOfLife
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVGrid = New System.Windows.Forms.DataGridView()
        Me.BPlayPause = New System.Windows.Forms.Button()
        Me.BClear = New System.Windows.Forms.Button()
        Me.BRestart = New System.Windows.Forms.Button()
        Me.BClose = New System.Windows.Forms.Button()
        Me.DGVReport = New System.Windows.Forms.DataGridView()
        Me.columnStage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDeath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSMain = New System.Windows.Forms.MenuStrip()
        Me.TSMMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BSave = New System.Windows.Forms.Button()
        CType(Me.DGVGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVGrid
        '
        Me.DGVGrid.AllowUserToAddRows = False
        Me.DGVGrid.AllowUserToDeleteRows = False
        Me.DGVGrid.AllowUserToOrderColumns = True
        Me.DGVGrid.AllowUserToResizeColumns = False
        Me.DGVGrid.AllowUserToResizeRows = False
        Me.DGVGrid.BackgroundColor = System.Drawing.Color.White
        Me.DGVGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVGrid.Location = New System.Drawing.Point(12, 88)
        Me.DGVGrid.MultiSelect = False
        Me.DGVGrid.Name = "DGVGrid"
        Me.DGVGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVGrid.RowHeadersWidth = 20
        Me.DGVGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGVGrid.Size = New System.Drawing.Size(403, 303)
        Me.DGVGrid.TabIndex = 0
        '
        'BPlayPause
        '
        Me.BPlayPause.Location = New System.Drawing.Point(40, 423)
        Me.BPlayPause.Name = "BPlayPause"
        Me.BPlayPause.Size = New System.Drawing.Size(118, 34)
        Me.BPlayPause.TabIndex = 1
        Me.BPlayPause.Text = "Play"
        Me.BPlayPause.UseVisualStyleBackColor = True
        '
        'BClear
        '
        Me.BClear.Location = New System.Drawing.Point(164, 423)
        Me.BClear.Name = "BClear"
        Me.BClear.Size = New System.Drawing.Size(118, 34)
        Me.BClear.TabIndex = 2
        Me.BClear.Text = "Clear"
        Me.BClear.UseVisualStyleBackColor = True
        '
        'BRestart
        '
        Me.BRestart.Location = New System.Drawing.Point(288, 423)
        Me.BRestart.Name = "BRestart"
        Me.BRestart.Size = New System.Drawing.Size(118, 34)
        Me.BRestart.TabIndex = 3
        Me.BRestart.Text = "Reset"
        Me.BRestart.UseVisualStyleBackColor = True
        '
        'BClose
        '
        Me.BClose.Location = New System.Drawing.Point(537, 423)
        Me.BClose.Name = "BClose"
        Me.BClose.Size = New System.Drawing.Size(118, 34)
        Me.BClose.TabIndex = 4
        Me.BClose.Text = "Close"
        Me.BClose.UseVisualStyleBackColor = True
        '
        'DGVReport
        '
        Me.DGVReport.AllowUserToAddRows = False
        Me.DGVReport.AllowUserToDeleteRows = False
        Me.DGVReport.BackgroundColor = System.Drawing.Color.White
        Me.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnStage, Me.columnBirth, Me.columnDeath})
        Me.DGVReport.EnableHeadersVisualStyles = False
        Me.DGVReport.Location = New System.Drawing.Point(421, 89)
        Me.DGVReport.Name = "DGVReport"
        Me.DGVReport.ReadOnly = True
        Me.DGVReport.RowHeadersVisible = False
        Me.DGVReport.Size = New System.Drawing.Size(280, 301)
        Me.DGVReport.TabIndex = 5
        '
        'columnStage
        '
        Me.columnStage.HeaderText = "Stage"
        Me.columnStage.Name = "columnStage"
        Me.columnStage.ReadOnly = True
        Me.columnStage.Width = 80
        '
        'columnBirth
        '
        Me.columnBirth.HeaderText = "Birth"
        Me.columnBirth.Name = "columnBirth"
        Me.columnBirth.ReadOnly = True
        '
        'columnDeath
        '
        Me.columnDeath.HeaderText = "Death"
        Me.columnDeath.Name = "columnDeath"
        Me.columnDeath.ReadOnly = True
        '
        'MSMain
        '
        Me.MSMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMMenu})
        Me.MSMain.Location = New System.Drawing.Point(0, 0)
        Me.MSMain.Name = "MSMain"
        Me.MSMain.Size = New System.Drawing.Size(716, 24)
        Me.MSMain.TabIndex = 6
        Me.MSMain.Text = "Menu"
        '
        'TSMMenu
        '
        Me.TSMMenu.Name = "TSMMenu"
        Me.TSMMenu.Size = New System.Drawing.Size(116, 20)
        Me.TSMMenu.Text = "Saved Generations"
        '
        'BSave
        '
        Me.BSave.Location = New System.Drawing.Point(413, 423)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(118, 34)
        Me.BSave.TabIndex = 7
        Me.BSave.Text = "Save"
        Me.BSave.UseVisualStyleBackColor = True
        '
        'FTheGameOfLife
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 473)
        Me.Controls.Add(Me.BSave)
        Me.Controls.Add(Me.DGVReport)
        Me.Controls.Add(Me.BClose)
        Me.Controls.Add(Me.BRestart)
        Me.Controls.Add(Me.BClear)
        Me.Controls.Add(Me.BPlayPause)
        Me.Controls.Add(Me.DGVGrid)
        Me.Controls.Add(Me.MSMain)
        Me.MainMenuStrip = Me.MSMain
        Me.Name = "FTheGameOfLife"
        Me.Text = "The Game Of Life"
        CType(Me.DGVGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSMain.ResumeLayout(False)
        Me.MSMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVGrid As System.Windows.Forms.DataGridView
    Friend WithEvents BPlayPause As System.Windows.Forms.Button
    Friend WithEvents BClear As System.Windows.Forms.Button
    Friend WithEvents BRestart As System.Windows.Forms.Button
    Friend WithEvents BClose As System.Windows.Forms.Button
    Friend WithEvents DGVReport As System.Windows.Forms.DataGridView
    Friend WithEvents columnStage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnBirth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDeath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MSMain As System.Windows.Forms.MenuStrip
    Friend WithEvents BSave As System.Windows.Forms.Button
    Friend WithEvents TSMMenu As System.Windows.Forms.ToolStripMenuItem

End Class
