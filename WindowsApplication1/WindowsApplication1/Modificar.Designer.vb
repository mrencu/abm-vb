﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar))
        Me.updateButton = New System.Windows.Forms.Button()
        Me.estadoCombo = New System.Windows.Forms.ComboBox()
        Me.modeloText = New System.Windows.Forms.TextBox()
        Me.equipoText = New System.Windows.Forms.TextBox()
        Me.clienteText = New System.Windows.Forms.TextBox()
        Me.empleadoText = New System.Windows.Forms.TextBox()
        Me.razonText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.registroText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'updateButton
        '
        Me.updateButton.BackColor = System.Drawing.Color.DarkOrange
        Me.updateButton.FlatAppearance.BorderSize = 0
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updateButton.Location = New System.Drawing.Point(281, 535)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Padding = New System.Windows.Forms.Padding(10)
        Me.updateButton.Size = New System.Drawing.Size(222, 60)
        Me.updateButton.TabIndex = 29
        Me.updateButton.Text = "Modificar"
        Me.updateButton.UseVisualStyleBackColor = False
        '
        'estadoCombo
        '
        Me.estadoCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.estadoCombo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estadoCombo.FormattingEnabled = True
        Me.estadoCombo.Location = New System.Drawing.Point(451, 113)
        Me.estadoCombo.Name = "estadoCombo"
        Me.estadoCombo.Size = New System.Drawing.Size(200, 40)
        Me.estadoCombo.TabIndex = 28
        '
        'modeloText
        '
        Me.modeloText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.modeloText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.modeloText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modeloText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.modeloText.Location = New System.Drawing.Point(451, 461)
        Me.modeloText.Name = "modeloText"
        Me.modeloText.Size = New System.Drawing.Size(200, 32)
        Me.modeloText.TabIndex = 27
        '
        'equipoText
        '
        Me.equipoText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.equipoText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.equipoText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equipoText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.equipoText.Location = New System.Drawing.Point(451, 392)
        Me.equipoText.Name = "equipoText"
        Me.equipoText.Size = New System.Drawing.Size(200, 32)
        Me.equipoText.TabIndex = 26
        '
        'clienteText
        '
        Me.clienteText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.clienteText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clienteText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clienteText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.clienteText.Location = New System.Drawing.Point(451, 323)
        Me.clienteText.Name = "clienteText"
        Me.clienteText.Size = New System.Drawing.Size(200, 32)
        Me.clienteText.TabIndex = 25
        '
        'empleadoText
        '
        Me.empleadoText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.empleadoText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.empleadoText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empleadoText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.empleadoText.Location = New System.Drawing.Point(451, 254)
        Me.empleadoText.Name = "empleadoText"
        Me.empleadoText.Size = New System.Drawing.Size(200, 32)
        Me.empleadoText.TabIndex = 24
        '
        'razonText
        '
        Me.razonText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.razonText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.razonText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.razonText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.razonText.Location = New System.Drawing.Point(451, 185)
        Me.razonText.Name = "razonText"
        Me.razonText.Size = New System.Drawing.Size(200, 32)
        Me.razonText.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(135, 461)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 32)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(134, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 32)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Equipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(134, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 32)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(134, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 32)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(134, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 32)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Razón"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(134, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Estado"
        '
        'registroText
        '
        Me.registroText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.registroText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.registroText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registroText.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.registroText.Location = New System.Drawing.Point(450, 50)
        Me.registroText.Name = "registroText"
        Me.registroText.Size = New System.Drawing.Size(200, 32)
        Me.registroText.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(134, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 32)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "N° de registro a modificar"
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(784, 761)
        Me.Controls.Add(Me.registroText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.updateButton)
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
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.MinimumSize = New System.Drawing.Size(800, 800)
        Me.Name = "Modificar"
        Me.Text = "Modificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents estadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents modeloText As System.Windows.Forms.TextBox
    Friend WithEvents equipoText As System.Windows.Forms.TextBox
    Friend WithEvents clienteText As System.Windows.Forms.TextBox
    Friend WithEvents empleadoText As System.Windows.Forms.TextBox
    Friend WithEvents razonText As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents registroText As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
