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
		Me.btnA = New System.Windows.Forms.Button()
		Me.btnE = New System.Windows.Forms.Button()
		Me.btnI = New System.Windows.Forms.Button()
		Me.btnO = New System.Windows.Forms.Button()
		Me.btnU = New System.Windows.Forms.Button()
		Me.lblCadena = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnA
		'
		Me.btnA.Location = New System.Drawing.Point(22, 16)
		Me.btnA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnA.Name = "btnA"
		Me.btnA.Size = New System.Drawing.Size(50, 44)
		Me.btnA.TabIndex = 0
		Me.btnA.Text = "A"
		Me.btnA.UseVisualStyleBackColor = True
		'
		'btnE
		'
		Me.btnE.Location = New System.Drawing.Point(80, 16)
		Me.btnE.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnE.Name = "btnE"
		Me.btnE.Size = New System.Drawing.Size(51, 44)
		Me.btnE.TabIndex = 1
		Me.btnE.Text = "E"
		Me.btnE.UseVisualStyleBackColor = True
		'
		'btnI
		'
		Me.btnI.Location = New System.Drawing.Point(139, 16)
		Me.btnI.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnI.Name = "btnI"
		Me.btnI.Size = New System.Drawing.Size(46, 44)
		Me.btnI.TabIndex = 2
		Me.btnI.Text = "I"
		Me.btnI.UseVisualStyleBackColor = True
		'
		'btnO
		'
		Me.btnO.Location = New System.Drawing.Point(193, 16)
		Me.btnO.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnO.Name = "btnO"
		Me.btnO.Size = New System.Drawing.Size(45, 44)
		Me.btnO.TabIndex = 3
		Me.btnO.Text = "O"
		Me.btnO.UseVisualStyleBackColor = True
		'
		'btnU
		'
		Me.btnU.Location = New System.Drawing.Point(246, 16)
		Me.btnU.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnU.Name = "btnU"
		Me.btnU.Size = New System.Drawing.Size(46, 44)
		Me.btnU.TabIndex = 4
		Me.btnU.Text = "U"
		Me.btnU.UseVisualStyleBackColor = True
		'
		'lblCadena
		'
		Me.lblCadena.AutoSize = True
		Me.lblCadena.Location = New System.Drawing.Point(17, 109)
		Me.lblCadena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCadena.Name = "lblCadena"
		Me.lblCadena.Size = New System.Drawing.Size(88, 25)
		Me.lblCadena.TabIndex = 5
		Me.lblCadena.Text = "Cadena:"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(322, 160)
		Me.Controls.Add(Me.lblCadena)
		Me.Controls.Add(Me.btnU)
		Me.Controls.Add(Me.btnO)
		Me.Controls.Add(Me.btnI)
		Me.Controls.Add(Me.btnE)
		Me.Controls.Add(Me.btnA)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Name = "Form1"
		Me.Text = "Acumulador de letras"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnA As Button
	Friend WithEvents btnE As Button
	Friend WithEvents btnI As Button
	Friend WithEvents btnO As Button
	Friend WithEvents btnU As Button
	Friend WithEvents lblCadena As Label
End Class
