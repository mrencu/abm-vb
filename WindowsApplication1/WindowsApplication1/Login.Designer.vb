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
        Me.userLabel = New System.Windows.Forms.Label()
        Me.passLabel = New System.Windows.Forms.Label()
        Me.userText = New System.Windows.Forms.TextBox()
        Me.passText = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.Location = New System.Drawing.Point(56, 97)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(46, 13)
        Me.userLabel.TabIndex = 0
        Me.userLabel.Text = "Usuario:"
        Me.userLabel.UseMnemonic = False
        '
        'passLabel
        '
        Me.passLabel.AutoSize = True
        Me.passLabel.Location = New System.Drawing.Point(56, 135)
        Me.passLabel.Name = "passLabel"
        Me.passLabel.Size = New System.Drawing.Size(64, 13)
        Me.passLabel.TabIndex = 1
        Me.passLabel.Text = "Contraseña:"
        '
        'userText
        '
        Me.userText.Location = New System.Drawing.Point(123, 94)
        Me.userText.Name = "userText"
        Me.userText.Size = New System.Drawing.Size(100, 20)
        Me.userText.TabIndex = 2
        '
        'passText
        '
        Me.passText.Location = New System.Drawing.Point(123, 132)
        Me.passText.Name = "passText"
        Me.passText.Size = New System.Drawing.Size(100, 20)
        Me.passText.TabIndex = 3
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(107, 211)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 4
        Me.submitButton.Text = "Ingresar"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.passText)
        Me.Controls.Add(Me.userText)
        Me.Controls.Add(Me.passLabel)
        Me.Controls.Add(Me.userLabel)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Friend WithEvents passLabel As System.Windows.Forms.Label
    Friend WithEvents userText As System.Windows.Forms.TextBox
    Friend WithEvents passText As System.Windows.Forms.TextBox
    Friend WithEvents submitButton As System.Windows.Forms.Button

End Class
