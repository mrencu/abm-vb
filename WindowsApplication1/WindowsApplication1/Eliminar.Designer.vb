<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar))
        Me.registroText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'registroText
        '
        Me.registroText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.registroText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.registroText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registroText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.registroText.Location = New System.Drawing.Point(92, 150)
        Me.registroText.Name = "registroText"
        Me.registroText.Size = New System.Drawing.Size(200, 32)
        Me.registroText.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(110, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 32)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "N° de registro"
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.DarkOrange
        Me.deleteButton.FlatAppearance.BorderSize = 0
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deleteButton.Location = New System.Drawing.Point(81, 223)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Padding = New System.Windows.Forms.Padding(10)
        Me.deleteButton.Size = New System.Drawing.Size(222, 60)
        Me.deleteButton.TabIndex = 17
        Me.deleteButton.Text = "Eliminar"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.registroText)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 400)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "Eliminar"
        Me.Text = "Eliminar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents registroText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents deleteButton As System.Windows.Forms.Button
End Class
