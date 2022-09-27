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
        Me.ButtonLoad = New System.Windows.Forms.Button()
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonInitialise
        '
        Me.ButtonInitialise.Location = New System.Drawing.Point(403, 12)
        Me.ButtonInitialise.Name = "ButtonInitialise"
        Me.ButtonInitialise.Size = New System.Drawing.Size(142, 30)
        Me.ButtonInitialise.TabIndex = 0
        Me.ButtonInitialise.Text = "Initialise"
        Me.ButtonInitialise.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(403, 97)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(142, 30)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(403, 133)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(142, 30)
        Me.ButtonRemove.TabIndex = 2
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonNextGeneration
        '
        Me.ButtonNextGeneration.Location = New System.Drawing.Point(403, 169)
        Me.ButtonNextGeneration.Name = "ButtonNextGeneration"
        Me.ButtonNextGeneration.Size = New System.Drawing.Size(142, 30)
        Me.ButtonNextGeneration.TabIndex = 3
        Me.ButtonNextGeneration.Text = "Next Generation"
        Me.ButtonNextGeneration.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(403, 205)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(92, 30)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(403, 277)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(92, 30)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Location = New System.Drawing.Point(501, 277)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(44, 30)
        Me.ButtonHelp.TabIndex = 6
        Me.ButtonHelp.Text = "?"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'TextBoxRowNumber
        '
        Me.TextBoxRowNumber.Location = New System.Drawing.Point(501, 48)
        Me.TextBoxRowNumber.Name = "TextBoxRowNumber"
        Me.TextBoxRowNumber.Size = New System.Drawing.Size(41, 20)
        Me.TextBoxRowNumber.TabIndex = 7
        '
        'TextBoxColumnNumber
        '
        Me.TextBoxColumnNumber.Location = New System.Drawing.Point(501, 71)
        Me.TextBoxColumnNumber.Name = "TextBoxColumnNumber"
        Me.TextBoxColumnNumber.Size = New System.Drawing.Size(41, 20)
        Me.TextBoxColumnNumber.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Row Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 74)
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
        Me.DGrid.Location = New System.Drawing.Point(12, 12)
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
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(403, 241)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(92, 30)
        Me.ButtonLoad.TabIndex = 12
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'FormGameOfLife
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 363)
        Me.Controls.Add(Me.ButtonLoad)
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
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button

End Class
