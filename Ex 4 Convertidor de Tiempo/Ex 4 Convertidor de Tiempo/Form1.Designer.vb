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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtHora = New System.Windows.Forms.TextBox()
		Me.txtSegundo = New System.Windows.Forms.TextBox()
		Me.txtMinuto = New System.Windows.Forms.TextBox()
		Me.btnConvertir = New System.Windows.Forms.Button()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(51, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(56, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Horas:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(50, 137)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Minutos:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(51, 200)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(86, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Segundos:"
		'
		'txtHora
		'
		Me.txtHora.Location = New System.Drawing.Point(144, 15)
		Me.txtHora.Name = "txtHora"
		Me.txtHora.Size = New System.Drawing.Size(146, 26)
		Me.txtHora.TabIndex = 3
		'
		'txtSegundo
		'
		Me.txtSegundo.Location = New System.Drawing.Point(144, 197)
		Me.txtSegundo.Name = "txtSegundo"
		Me.txtSegundo.Size = New System.Drawing.Size(146, 26)
		Me.txtSegundo.TabIndex = 4
		'
		'txtMinuto
		'
		Me.txtMinuto.Location = New System.Drawing.Point(144, 134)
		Me.txtMinuto.Name = "txtMinuto"
		Me.txtMinuto.Size = New System.Drawing.Size(146, 26)
		Me.txtMinuto.TabIndex = 5
		'
		'btnConvertir
		'
		Me.btnConvertir.Location = New System.Drawing.Point(172, 57)
		Me.btnConvertir.Name = "btnConvertir"
		Me.btnConvertir.Size = New System.Drawing.Size(96, 35)
		Me.btnConvertir.TabIndex = 6
		Me.btnConvertir.Text = "Convertir"
		Me.btnConvertir.UseVisualStyleBackColor = True
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(172, 256)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(96, 35)
		Me.btnCerrar.TabIndex = 7
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(392, 301)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.btnConvertir)
		Me.Controls.Add(Me.txtMinuto)
		Me.Controls.Add(Me.txtSegundo)
		Me.Controls.Add(Me.txtHora)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Convertidor"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtHora As TextBox
	Friend WithEvents txtSegundo As TextBox
	Friend WithEvents txtMinuto As TextBox
	Friend WithEvents btnConvertir As Button
	Friend WithEvents btnCerrar As Button
End Class
