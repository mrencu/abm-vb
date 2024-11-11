<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Añadir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Añadir))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.razonText = New System.Windows.Forms.TextBox()
        Me.empleadoText = New System.Windows.Forms.TextBox()
        Me.clienteText = New System.Windows.Forms.TextBox()
        Me.equipoText = New System.Windows.Forms.TextBox()
        Me.modeloText = New System.Windows.Forms.TextBox()
        Me.estadoCombo = New System.Windows.Forms.ComboBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(120, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(120, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Razón"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(120, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(120, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(120, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Equipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(121, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 32)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Modelo"
        '
        'razonText
        '
        Me.razonText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.razonText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.razonText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.razonText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.razonText.Location = New System.Drawing.Point(265, 122)
        Me.razonText.Name = "razonText"
        Me.razonText.Size = New System.Drawing.Size(200, 32)
        Me.razonText.TabIndex = 9
        '
        'empleadoText
        '
        Me.empleadoText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.empleadoText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.empleadoText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empleadoText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.empleadoText.Location = New System.Drawing.Point(265, 191)
        Me.empleadoText.Name = "empleadoText"
        Me.empleadoText.Size = New System.Drawing.Size(200, 32)
        Me.empleadoText.TabIndex = 10
        '
        'clienteText
        '
        Me.clienteText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.clienteText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clienteText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clienteText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.clienteText.Location = New System.Drawing.Point(265, 260)
        Me.clienteText.Name = "clienteText"
        Me.clienteText.Size = New System.Drawing.Size(200, 32)
        Me.clienteText.TabIndex = 11
        '
        'equipoText
        '
        Me.equipoText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.equipoText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.equipoText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equipoText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.equipoText.Location = New System.Drawing.Point(265, 329)
        Me.equipoText.Name = "equipoText"
        Me.equipoText.Size = New System.Drawing.Size(200, 32)
        Me.equipoText.TabIndex = 12
        '
        'modeloText
        '
        Me.modeloText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.modeloText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.modeloText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modeloText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.modeloText.Location = New System.Drawing.Point(265, 398)
        Me.modeloText.Name = "modeloText"
        Me.modeloText.Size = New System.Drawing.Size(200, 32)
        Me.modeloText.TabIndex = 13
        '
        'estadoCombo
        '
        Me.estadoCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.estadoCombo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estadoCombo.FormattingEnabled = True
        Me.estadoCombo.Location = New System.Drawing.Point(265, 50)
        Me.estadoCombo.Name = "estadoCombo"
        Me.estadoCombo.Size = New System.Drawing.Size(200, 40)
        Me.estadoCombo.TabIndex = 14
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.DarkOrange
        Me.addButton.FlatAppearance.BorderSize = 0
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.addButton.Location = New System.Drawing.Point(177, 468)
        Me.addButton.Name = "addButton"
        Me.addButton.Padding = New System.Windows.Forms.Padding(10)
        Me.addButton.Size = New System.Drawing.Size(222, 60)
        Me.addButton.TabIndex = 16
        Me.addButton.Text = "Añadir"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'Añadir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.estadoCombo)
        Me.Controls.Add(Me.modeloText)
        Me.Controls.Add(Me.equipoText)
        Me.Controls.Add(Me.clienteText)
        Me.Controls.Add(Me.empleadoText)
        Me.Controls.Add(Me.razonText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 600)
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "Añadir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents razonText As System.Windows.Forms.TextBox
    Friend WithEvents empleadoText As System.Windows.Forms.TextBox
    Friend WithEvents clienteText As System.Windows.Forms.TextBox
    Friend WithEvents equipoText As System.Windows.Forms.TextBox
    Friend WithEvents modeloText As System.Windows.Forms.TextBox
    Friend WithEvents estadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents addButton As System.Windows.Forms.Button
End Class
