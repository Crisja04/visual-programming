<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtFrase = New System.Windows.Forms.TextBox()
		Me.Negrita = New System.Windows.Forms.RadioButton()
		Me.Cursiva = New System.Windows.Forms.RadioButton()
		Me.Subrayado = New System.Windows.Forms.RadioButton()
		Me.Mayuscula = New System.Windows.Forms.RadioButton()
		Me.Minuscula = New System.Windows.Forms.RadioButton()
		Me.SelectorColor = New System.Windows.Forms.ColorDialog()
		Me.btnColor = New System.Windows.Forms.Button()
		Me.btnFondo = New System.Windows.Forms.Button()
		Me.btnAgrandar = New System.Windows.Forms.Button()
		Me.btnEncoger = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(30, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(148, 20)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Introduce una frase"
		'
		'txtFrase
		'
		Me.txtFrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFrase.Location = New System.Drawing.Point(34, 53)
		Me.txtFrase.Multiline = True
		Me.txtFrase.Name = "txtFrase"
		Me.txtFrase.Size = New System.Drawing.Size(246, 104)
		Me.txtFrase.TabIndex = 8
		'
		'Negrita
		'
		Me.Negrita.AutoSize = True
		Me.Negrita.Location = New System.Drawing.Point(34, 182)
		Me.Negrita.Name = "Negrita"
		Me.Negrita.Size = New System.Drawing.Size(85, 24)
		Me.Negrita.TabIndex = 9
		Me.Negrita.TabStop = True
		Me.Negrita.Text = "Negrita" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.Negrita.UseVisualStyleBackColor = True
		'
		'Cursiva
		'
		Me.Cursiva.AutoSize = True
		Me.Cursiva.Location = New System.Drawing.Point(34, 213)
		Me.Cursiva.Name = "Cursiva"
		Me.Cursiva.Size = New System.Drawing.Size(86, 24)
		Me.Cursiva.TabIndex = 10
		Me.Cursiva.TabStop = True
		Me.Cursiva.Text = "Cursiva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.Cursiva.UseVisualStyleBackColor = True
		'
		'Subrayado
		'
		Me.Subrayado.AutoSize = True
		Me.Subrayado.Location = New System.Drawing.Point(34, 243)
		Me.Subrayado.Name = "Subrayado"
		Me.Subrayado.Size = New System.Drawing.Size(111, 24)
		Me.Subrayado.TabIndex = 11
		Me.Subrayado.TabStop = True
		Me.Subrayado.Text = "Subrayado"
		Me.Subrayado.UseVisualStyleBackColor = True
		'
		'Mayuscula
		'
		Me.Mayuscula.AutoSize = True
		Me.Mayuscula.Location = New System.Drawing.Point(171, 182)
		Me.Mayuscula.Name = "Mayuscula"
		Me.Mayuscula.Size = New System.Drawing.Size(109, 24)
		Me.Mayuscula.TabIndex = 12
		Me.Mayuscula.TabStop = True
		Me.Mayuscula.Text = "Mayuscula"
		Me.Mayuscula.UseVisualStyleBackColor = True
		'
		'Minuscula
		'
		Me.Minuscula.AutoSize = True
		Me.Minuscula.Location = New System.Drawing.Point(171, 213)
		Me.Minuscula.Name = "Minuscula"
		Me.Minuscula.Size = New System.Drawing.Size(105, 24)
		Me.Minuscula.TabIndex = 13
		Me.Minuscula.TabStop = True
		Me.Minuscula.Text = "Minuscula"
		Me.Minuscula.UseVisualStyleBackColor = True
		'
		'btnColor
		'
		Me.btnColor.Location = New System.Drawing.Point(34, 322)
		Me.btnColor.Name = "btnColor"
		Me.btnColor.Size = New System.Drawing.Size(121, 55)
		Me.btnColor.TabIndex = 14
		Me.btnColor.Text = "Cambiar color"
		Me.btnColor.UseVisualStyleBackColor = True
		'
		'btnFondo
		'
		Me.btnFondo.Location = New System.Drawing.Point(162, 322)
		Me.btnFondo.Name = "btnFondo"
		Me.btnFondo.Size = New System.Drawing.Size(136, 55)
		Me.btnFondo.TabIndex = 15
		Me.btnFondo.Text = "Cambiar Fondo"
		Me.btnFondo.UseVisualStyleBackColor = True
		'
		'btnAgrandar
		'
		Me.btnAgrandar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAgrandar.Location = New System.Drawing.Point(305, 68)
		Me.btnAgrandar.Name = "btnAgrandar"
		Me.btnAgrandar.Size = New System.Drawing.Size(39, 39)
		Me.btnAgrandar.TabIndex = 16
		Me.btnAgrandar.Text = "A"
		Me.btnAgrandar.UseVisualStyleBackColor = True
		'
		'btnEncoger
		'
		Me.btnEncoger.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEncoger.Location = New System.Drawing.Point(305, 118)
		Me.btnEncoger.Name = "btnEncoger"
		Me.btnEncoger.Size = New System.Drawing.Size(39, 39)
		Me.btnEncoger.TabIndex = 17
		Me.btnEncoger.Text = "A"
		Me.btnEncoger.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(301, 35)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 20)
		Me.Label2.TabIndex = 18
		Me.Label2.Text = "Tamaño"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(380, 401)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnEncoger)
		Me.Controls.Add(Me.btnAgrandar)
		Me.Controls.Add(Me.btnFondo)
		Me.Controls.Add(Me.btnColor)
		Me.Controls.Add(Me.Minuscula)
		Me.Controls.Add(Me.Mayuscula)
		Me.Controls.Add(Me.Subrayado)
		Me.Controls.Add(Me.Cursiva)
		Me.Controls.Add(Me.Negrita)
		Me.Controls.Add(Me.txtFrase)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Editar Texto"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents txtFrase As TextBox
	Friend WithEvents Negrita As RadioButton
	Friend WithEvents Cursiva As RadioButton
	Friend WithEvents Subrayado As RadioButton
	Friend WithEvents Mayuscula As RadioButton
	Friend WithEvents Minuscula As RadioButton
	Friend WithEvents SelectorColor As ColorDialog
	Friend WithEvents btnColor As Button
	Friend WithEvents btnFondo As Button
	Friend WithEvents btnAgrandar As Button
	Friend WithEvents btnEncoger As Button
	Friend WithEvents Label2 As Label
End Class
