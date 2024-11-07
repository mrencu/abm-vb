<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.userLabel = New System.Windows.Forms.Label()
        Me.passLabel = New System.Windows.Forms.Label()
        Me.userText = New System.Windows.Forms.TextBox()
        Me.passText = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.userLabel.Location = New System.Drawing.Point(73, 196)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(82, 25)
        Me.userLabel.TabIndex = 0
        Me.userLabel.Text = "Usuario"
        Me.userLabel.UseMnemonic = False
        '
        'passLabel
        '
        Me.passLabel.AutoSize = True
        Me.passLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.passLabel.Location = New System.Drawing.Point(73, 249)
        Me.passLabel.Name = "passLabel"
        Me.passLabel.Size = New System.Drawing.Size(117, 25)
        Me.passLabel.TabIndex = 1
        Me.passLabel.Text = "Contraseña"
        '
        'userText
        '
        Me.userText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.userText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userText.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.userText.Location = New System.Drawing.Point(205, 197)
        Me.userText.MaxLength = 30
        Me.userText.Name = "userText"
        Me.userText.Size = New System.Drawing.Size(100, 25)
        Me.userText.TabIndex = 2
        '
        'passText
        '
        Me.passText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.passText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passText.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.passText.Location = New System.Drawing.Point(205, 250)
        Me.passText.MaxLength = 30
        Me.passText.Name = "passText"
        Me.passText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passText.Size = New System.Drawing.Size(100, 25)
        Me.passText.TabIndex = 3
        '
        'submitButton
        '
        Me.submitButton.BackColor = System.Drawing.Color.DarkOrange
        Me.submitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submitButton.FlatAppearance.BorderSize = 0
        Me.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitButton.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.submitButton.Location = New System.Drawing.Point(95, 294)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Padding = New System.Windows.Forms.Padding(10)
        Me.submitButton.Size = New System.Drawing.Size(184, 55)
        Me.submitButton.TabIndex = 4
        Me.submitButton.Text = "Ingresar"
        Me.submitButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(102, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Iniciar sesión"
        Me.Label1.UseMnemonic = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.majesticons__user_box_line__1_
        Me.PictureBox1.Location = New System.Drawing.Point(111, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.passText)
        Me.Controls.Add(Me.userText)
        Me.Controls.Add(Me.passLabel)
        Me.Controls.Add(Me.userLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Friend WithEvents passLabel As System.Windows.Forms.Label
    Friend WithEvents userText As System.Windows.Forms.TextBox
    Friend WithEvents passText As System.Windows.Forms.TextBox
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
