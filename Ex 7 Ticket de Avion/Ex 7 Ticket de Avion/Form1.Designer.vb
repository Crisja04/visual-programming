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
		Me.btnCalcular = New System.Windows.Forms.Button()
		Me.txtDistancia = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtEstancia = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtCosto = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(143, 115)
		Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(117, 40)
		Me.btnCalcular.TabIndex = 0
		Me.btnCalcular.Text = "Calcular"
		Me.btnCalcular.UseVisualStyleBackColor = True
		'
		'txtDistancia
		'
		Me.txtDistancia.Location = New System.Drawing.Point(229, 9)
		Me.txtDistancia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtDistancia.Name = "txtDistancia"
		Me.txtDistancia.Size = New System.Drawing.Size(132, 30)
		Me.txtDistancia.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(175, 25)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Distancia del vuelo"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(13, 69)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(142, 25)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Estancia (dias)"
		'
		'txtEstancia
		'
		Me.txtEstancia.Location = New System.Drawing.Point(229, 65)
		Me.txtEstancia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtEstancia.Name = "txtEstancia"
		Me.txtEstancia.Size = New System.Drawing.Size(132, 30)
		Me.txtEstancia.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(47, 173)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 25)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Costo"
		'
		'txtCosto
		'
		Me.txtCosto.Location = New System.Drawing.Point(229, 173)
		Me.txtCosto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtCosto.Name = "txtCosto"
		Me.txtCosto.Size = New System.Drawing.Size(132, 30)
		Me.txtCosto.TabIndex = 5
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(432, 227)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtCosto)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtEstancia)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtDistancia)
		Me.Controls.Add(Me.btnCalcular)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Calculadora de Tickets Aereos"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnCalcular As Button
	Friend WithEvents txtDistancia As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtEstancia As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtCosto As TextBox
End Class
