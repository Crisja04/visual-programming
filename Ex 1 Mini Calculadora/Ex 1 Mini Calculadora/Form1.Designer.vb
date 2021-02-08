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
		Me.btnSumar = New System.Windows.Forms.Button()
		Me.txtNumero1 = New System.Windows.Forms.TextBox()
		Me.lblOperacion = New System.Windows.Forms.Label()
		Me.txtResultado = New System.Windows.Forms.TextBox()
		Me.txtNumero2 = New System.Windows.Forms.TextBox()
		Me.lblIgual = New System.Windows.Forms.Label()
		Me.btnRestar = New System.Windows.Forms.Button()
		Me.btnMultiplicar = New System.Windows.Forms.Button()
		Me.btnDividir = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'btnSumar
		'
		Me.btnSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSumar.Location = New System.Drawing.Point(13, 118)
		Me.btnSumar.Name = "btnSumar"
		Me.btnSumar.Size = New System.Drawing.Size(75, 38)
		Me.btnSumar.TabIndex = 0
		Me.btnSumar.Text = "+"
		Me.btnSumar.UseVisualStyleBackColor = True
		'
		'txtNumero1
		'
		Me.txtNumero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumero1.Location = New System.Drawing.Point(12, 16)
		Me.txtNumero1.Name = "txtNumero1"
		Me.txtNumero1.Size = New System.Drawing.Size(100, 35)
		Me.txtNumero1.TabIndex = 1
		'
		'lblOperacion
		'
		Me.lblOperacion.AutoSize = True
		Me.lblOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOperacion.Location = New System.Drawing.Point(118, 19)
		Me.lblOperacion.Name = "lblOperacion"
		Me.lblOperacion.Size = New System.Drawing.Size(27, 29)
		Me.lblOperacion.TabIndex = 2
		Me.lblOperacion.Text = "+"
		'
		'txtResultado
		'
		Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtResultado.Location = New System.Drawing.Point(317, 16)
		Me.txtResultado.Name = "txtResultado"
		Me.txtResultado.Size = New System.Drawing.Size(100, 35)
		Me.txtResultado.TabIndex = 3
		'
		'txtNumero2
		'
		Me.txtNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumero2.Location = New System.Drawing.Point(153, 16)
		Me.txtNumero2.Name = "txtNumero2"
		Me.txtNumero2.Size = New System.Drawing.Size(100, 35)
		Me.txtNumero2.TabIndex = 4
		'
		'lblIgual
		'
		Me.lblIgual.AutoSize = True
		Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIgual.Location = New System.Drawing.Point(278, 19)
		Me.lblIgual.Name = "lblIgual"
		Me.lblIgual.Size = New System.Drawing.Size(27, 29)
		Me.lblIgual.TabIndex = 5
		Me.lblIgual.Text = "="
		'
		'btnRestar
		'
		Me.btnRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRestar.Location = New System.Drawing.Point(123, 118)
		Me.btnRestar.Name = "btnRestar"
		Me.btnRestar.Size = New System.Drawing.Size(75, 38)
		Me.btnRestar.TabIndex = 6
		Me.btnRestar.Text = "-"
		Me.btnRestar.UseVisualStyleBackColor = True
		'
		'btnMultiplicar
		'
		Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMultiplicar.Location = New System.Drawing.Point(236, 118)
		Me.btnMultiplicar.Name = "btnMultiplicar"
		Me.btnMultiplicar.Size = New System.Drawing.Size(75, 38)
		Me.btnMultiplicar.TabIndex = 7
		Me.btnMultiplicar.Text = "*"
		Me.btnMultiplicar.UseVisualStyleBackColor = True
		'
		'btnDividir
		'
		Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDividir.Location = New System.Drawing.Point(342, 118)
		Me.btnDividir.Name = "btnDividir"
		Me.btnDividir.Size = New System.Drawing.Size(75, 38)
		Me.btnDividir.TabIndex = 8
		Me.btnDividir.Text = "/"
		Me.btnDividir.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(437, 196)
		Me.Controls.Add(Me.btnDividir)
		Me.Controls.Add(Me.btnMultiplicar)
		Me.Controls.Add(Me.btnRestar)
		Me.Controls.Add(Me.lblIgual)
		Me.Controls.Add(Me.txtNumero2)
		Me.Controls.Add(Me.txtResultado)
		Me.Controls.Add(Me.lblOperacion)
		Me.Controls.Add(Me.txtNumero1)
		Me.Controls.Add(Me.btnSumar)
		Me.Name = "Form1"
		Me.Text = "Mini-Calculadora"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnSumar As Button
	Friend WithEvents txtNumero1 As TextBox
	Friend WithEvents lblOperacion As Label
	Friend WithEvents txtResultado As TextBox
	Friend WithEvents txtNumero2 As TextBox
	Friend WithEvents lblIgual As Label
	Friend WithEvents btnRestar As Button
	Friend WithEvents btnMultiplicar As Button
	Friend WithEvents btnDividir As Button
End Class
