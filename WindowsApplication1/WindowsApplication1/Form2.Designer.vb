<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.employeeText = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.optionCombo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGrid
        '
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(302, 41)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(429, 183)
        Me.dataGrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empleado"
        '
        'employeeText
        '
        Me.employeeText.Location = New System.Drawing.Point(126, 71)
        Me.employeeText.Name = "employeeText"
        Me.employeeText.Size = New System.Drawing.Size(100, 20)
        Me.employeeText.TabIndex = 2
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(66, 162)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 3
        Me.searchButton.Text = "Buscar"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'optionCombo
        '
        Me.optionCombo.FormattingEnabled = True
        Me.optionCombo.Items.AddRange(New Object() {"Añadir registros", "Eliminar registros", "Modificar registros", "Buscar registro"})
        Me.optionCombo.Location = New System.Drawing.Point(126, 108)
        Me.optionCombo.Name = "optionCombo"
        Me.optionCombo.Size = New System.Drawing.Size(100, 21)
        Me.optionCombo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Opción"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.optionCombo)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.employeeText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataGrid)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents employeeText As System.Windows.Forms.TextBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents optionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
