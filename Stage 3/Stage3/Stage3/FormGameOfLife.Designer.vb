<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGameOfLife
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonInitialise = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonNextGeneration = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.TextBoxRowNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxColumnNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGrid = New System.Windows.Forms.DataGridView()
        Me.DReport = New System.Windows.Forms.DataGridView()
        Me.columnStage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDeath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSMain = New System.Windows.Forms.MenuStrip()
        Me.TSMMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DStatus = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxToStage = New System.Windows.Forms.TextBox()
        Me.TextBoxFromStage = New System.Windows.Forms.TextBox()
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSMain.SuspendLayout()
        CType(Me.DStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonInitialise
        '
        Me.ButtonInitialise.Location = New System.Drawing.Point(404, 38)
        Me.ButtonInitialise.Name = "ButtonInitialise"
        Me.ButtonInitialise.Size = New System.Drawing.Size(142, 30)
        Me.ButtonInitialise.TabIndex = 0
        Me.ButtonInitialise.Text = "Initialise"
        Me.ButtonInitialise.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(404, 123)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(142, 30)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(404, 159)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(142, 30)
        Me.ButtonRemove.TabIndex = 2
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonNextGeneration
        '
        Me.ButtonNextGeneration.Location = New System.Drawing.Point(404, 195)
        Me.ButtonNextGeneration.Name = "ButtonNextGeneration"
        Me.ButtonNextGeneration.Size = New System.Drawing.Size(142, 30)
        Me.ButtonNextGeneration.TabIndex = 3
        Me.ButtonNextGeneration.Text = "Next Generation"
        Me.ButtonNextGeneration.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(404, 231)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(92, 30)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(404, 303)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(92, 30)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Location = New System.Drawing.Point(502, 303)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(44, 30)
        Me.ButtonHelp.TabIndex = 6
        Me.ButtonHelp.Text = "?"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'TextBoxRowNumber
        '
        Me.TextBoxRowNumber.Location = New System.Drawing.Point(502, 74)
        Me.TextBoxRowNumber.Name = "TextBoxRowNumber"
        Me.TextBoxRowNumber.Size = New System.Drawing.Size(41, 20)
        Me.TextBoxRowNumber.TabIndex = 7
        '
        'TextBoxColumnNumber
        '
        Me.TextBoxColumnNumber.Location = New System.Drawing.Point(502, 97)
        Me.TextBoxColumnNumber.Name = "TextBoxColumnNumber"
        Me.TextBoxColumnNumber.Size = New System.Drawing.Size(41, 20)
        Me.TextBoxColumnNumber.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Row Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(409, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Column Number"
        '
        'DGrid
        '
        Me.DGrid.AllowUserToAddRows = False
        Me.DGrid.AllowUserToDeleteRows = False
        Me.DGrid.AllowUserToOrderColumns = True
        Me.DGrid.AllowUserToResizeColumns = False
        Me.DGrid.AllowUserToResizeRows = False
        Me.DGrid.BackgroundColor = System.Drawing.Color.White
        Me.DGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGrid.Location = New System.Drawing.Point(13, 38)
        Me.DGrid.MultiSelect = False
        Me.DGrid.Name = "DGrid"
        Me.DGrid.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGrid.RowHeadersWidth = 20
        Me.DGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGrid.Size = New System.Drawing.Size(385, 339)
        Me.DGrid.TabIndex = 11
        '
        'DReport
        '
        Me.DReport.AllowUserToAddRows = False
        Me.DReport.AllowUserToDeleteRows = False
        Me.DReport.BackgroundColor = System.Drawing.Color.White
        Me.DReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnStage, Me.columnBirth, Me.columnDeath})
        Me.DReport.EnableHeadersVisualStyles = False
        Me.DReport.Location = New System.Drawing.Point(13, 383)
        Me.DReport.Name = "DReport"
        Me.DReport.ReadOnly = True
        Me.DReport.RowHeadersVisible = False
        Me.DReport.Size = New System.Drawing.Size(302, 111)
        Me.DReport.TabIndex = 13
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
        Me.MSMain.Size = New System.Drawing.Size(635, 24)
        Me.MSMain.TabIndex = 14
        Me.MSMain.Text = "Menu"
        '
        'TSMMenu
        '
        Me.TSMMenu.Name = "TSMMenu"
        Me.TSMMenu.Size = New System.Drawing.Size(116, 20)
        Me.TSMMenu.Text = "Saved Generations"
        '
        'DStatus
        '
        Me.DStatus.AllowUserToAddRows = False
        Me.DStatus.AllowUserToDeleteRows = False
        Me.DStatus.BackgroundColor = System.Drawing.Color.White
        Me.DStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DStatus.EnableHeadersVisualStyles = False
        Me.DStatus.Location = New System.Drawing.Point(321, 412)
        Me.DStatus.Name = "DStatus"
        Me.DStatus.ReadOnly = True
        Me.DStatus.RowHeadersVisible = False
        Me.DStatus.Size = New System.Drawing.Size(302, 82)
        Me.DStatus.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Stage"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Birth/Death"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "To Stage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "From Stage"
        '
        'TextBoxToStage
        '
        Me.TextBoxToStage.Location = New System.Drawing.Point(563, 384)
        Me.TextBoxToStage.Name = "TextBoxToStage"
        Me.TextBoxToStage.Size = New System.Drawing.Size(41, 20)
        Me.TextBoxToStage.TabIndex = 17
        '
        'TextBoxFromStage
        '
        Me.TextBoxFromStage.Location = New System.Drawing.Point(422, 384)
        Me.TextBoxFromStage.Name = "TextBoxFromStage"
        Me.TextBoxFromStage.Size = New System.Drawing.Size(41, 20)
        Me.TextBoxFromStage.TabIndex = 16
        '
        'FormGameOfLife
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 501)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxToStage)
        Me.Controls.Add(Me.TextBoxFromStage)
        Me.Controls.Add(Me.DStatus)
        Me.Controls.Add(Me.MSMain)
        Me.Controls.Add(Me.DReport)
        Me.Controls.Add(Me.DGrid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxColumnNumber)
        Me.Controls.Add(Me.TextBoxRowNumber)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonNextGeneration)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonInitialise)
        Me.Name = "FormGameOfLife"
        Me.Text = "Game of Life"
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSMain.ResumeLayout(False)
        Me.MSMain.PerformLayout()
        CType(Me.DStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonInitialise As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents ButtonNextGeneration As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents TextBoxRowNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxColumnNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DReport As System.Windows.Forms.DataGridView
    Friend WithEvents columnStage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnBirth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDeath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MSMain As System.Windows.Forms.MenuStrip
    Friend WithEvents TSMMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DStatus As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxToStage As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFromStage As System.Windows.Forms.TextBox

End Class
