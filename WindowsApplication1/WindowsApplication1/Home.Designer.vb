<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.employeeText = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.hourTimer = New System.Windows.Forms.Timer(Me.components)
        Me.hourLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.addButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.updateButton = New System.Windows.Forms.Button()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.Color.SandyBrown
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dataGrid.GridColor = System.Drawing.Color.Chocolate
        Me.dataGrid.Location = New System.Drawing.Point(318, 297)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(429, 183)
        Me.dataGrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(36, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empleado"
        '
        'employeeText
        '
        Me.employeeText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.employeeText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.employeeText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.employeeText.Location = New System.Drawing.Point(163, 297)
        Me.employeeText.Name = "employeeText"
        Me.employeeText.Size = New System.Drawing.Size(100, 32)
        Me.employeeText.TabIndex = 2
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.Color.DarkOrange
        Me.searchButton.FlatAppearance.BorderSize = 0
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchButton.Location = New System.Drawing.Point(41, 347)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Padding = New System.Windows.Forms.Padding(10)
        Me.searchButton.Size = New System.Drawing.Size(222, 60)
        Me.searchButton.TabIndex = 3
        Me.searchButton.Text = "Buscar"
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'hourTimer
        '
        Me.hourTimer.Enabled = True
        Me.hourTimer.Interval = 1
        '
        'hourLabel
        '
        Me.hourLabel.AutoSize = True
        Me.hourLabel.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourLabel.ForeColor = System.Drawing.Color.Orange
        Me.hourLabel.Location = New System.Drawing.Point(33, 49)
        Me.hourLabel.Name = "hourLabel"
        Me.hourLabel.Size = New System.Drawing.Size(439, 128)
        Me.hourLabel.TabIndex = 8
        Me.hourLabel.Text = "XX:XX:XX"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.hourLabel)
        Me.Panel1.Location = New System.Drawing.Point(300, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 225)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Peru
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 250)
        Me.Panel2.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addButton, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(790, 23)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'addButton
        '
        Me.addButton.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.addButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(65, 20)
        Me.addButton.Text = " Añadir"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.WindowsApplication1.My.Resources.Resources.minus
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 20)
        Me.ToolStripButton1.Text = "Eliminar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.WindowsApplication1.My.Resources.Resources.pencil
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(78, 20)
        Me.ToolStripButton2.Text = "Modificar"
        '
        'updateButton
        '
        Me.updateButton.BackColor = System.Drawing.Color.DarkOrange
        Me.updateButton.FlatAppearance.BorderSize = 0
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updateButton.Location = New System.Drawing.Point(41, 420)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Padding = New System.Windows.Forms.Padding(10)
        Me.updateButton.Size = New System.Drawing.Size(222, 60)
        Me.updateButton.TabIndex = 13
        Me.updateButton.Text = "Actualizar"
        Me.updateButton.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.employeeText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataGrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents employeeText As System.Windows.Forms.TextBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents hourTimer As System.Windows.Forms.Timer
    Friend WithEvents hourLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents addButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents updateButton As System.Windows.Forms.Button
End Class
