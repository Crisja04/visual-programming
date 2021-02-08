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
		Me.txtMonto = New System.Windows.Forms.TextBox()
		Me.lblOtros = New System.Windows.Forms.Label()
		Me.lblIngreso = New System.Windows.Forms.Label()
		Me.lblPlazo = New System.Windows.Forms.Label()
		Me.lblTasa = New System.Windows.Forms.Label()
		Me.lblMonto = New System.Windows.Forms.Label()
		Me.txtOtros = New System.Windows.Forms.TextBox()
		Me.txtIngreso = New System.Windows.Forms.TextBox()
		Me.txtPlazo = New System.Windows.Forms.TextBox()
		Me.txtTasa = New System.Windows.Forms.TextBox()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnCalcular = New System.Windows.Forms.Button()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txtMonto
		'
		Me.txtMonto.Location = New System.Drawing.Point(272, 27)
		Me.txtMonto.Name = "txtMonto"
		Me.txtMonto.Size = New System.Drawing.Size(132, 26)
		Me.txtMonto.TabIndex = 1
		'
		'lblOtros
		'
		Me.lblOtros.AutoSize = True
		Me.lblOtros.Location = New System.Drawing.Point(12, 294)
		Me.lblOtros.Name = "lblOtros"
		Me.lblOtros.Size = New System.Drawing.Size(239, 20)
		Me.lblOtros.TabIndex = 2
		Me.lblOtros.Text = "Otros Compromisos Financieros:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'lblIngreso
		'
		Me.lblIngreso.AutoSize = True
		Me.lblIngreso.Location = New System.Drawing.Point(12, 226)
		Me.lblIngreso.Name = "lblIngreso"
		Me.lblIngreso.Size = New System.Drawing.Size(131, 20)
		Me.lblIngreso.TabIndex = 3
		Me.lblIngreso.Text = "Ingreso Mensual:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'lblPlazo
		'
		Me.lblPlazo.AutoSize = True
		Me.lblPlazo.Location = New System.Drawing.Point(11, 158)
		Me.lblPlazo.Name = "lblPlazo"
		Me.lblPlazo.Size = New System.Drawing.Size(135, 20)
		Me.lblPlazo.TabIndex = 4
		Me.lblPlazo.Text = "Plazo (en meses):"
		'
		'lblTasa
		'
		Me.lblTasa.AutoSize = True
		Me.lblTasa.Location = New System.Drawing.Point(12, 93)
		Me.lblTasa.Name = "lblTasa"
		Me.lblTasa.Size = New System.Drawing.Size(213, 20)
		Me.lblTasa.TabIndex = 5
		Me.lblTasa.Text = "Tasa de Porcentaje Anual %:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'lblMonto
		'
		Me.lblMonto.AutoSize = True
		Me.lblMonto.Location = New System.Drawing.Point(12, 27)
		Me.lblMonto.Name = "lblMonto"
		Me.lblMonto.Size = New System.Drawing.Size(214, 20)
		Me.lblMonto.TabIndex = 6
		Me.lblMonto.Text = "Monto del Préstamo en RD$:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'txtOtros
		'
		Me.txtOtros.Location = New System.Drawing.Point(272, 294)
		Me.txtOtros.Name = "txtOtros"
		Me.txtOtros.Size = New System.Drawing.Size(132, 26)
		Me.txtOtros.TabIndex = 7
		'
		'txtIngreso
		'
		Me.txtIngreso.Location = New System.Drawing.Point(272, 226)
		Me.txtIngreso.Name = "txtIngreso"
		Me.txtIngreso.Size = New System.Drawing.Size(132, 26)
		Me.txtIngreso.TabIndex = 8
		'
		'txtPlazo
		'
		Me.txtPlazo.Location = New System.Drawing.Point(272, 158)
		Me.txtPlazo.Name = "txtPlazo"
		Me.txtPlazo.Size = New System.Drawing.Size(132, 26)
		Me.txtPlazo.TabIndex = 9
		'
		'txtTasa
		'
		Me.txtTasa.Location = New System.Drawing.Point(272, 93)
		Me.txtTasa.Name = "txtTasa"
		Me.txtTasa.Size = New System.Drawing.Size(132, 26)
		Me.txtTasa.TabIndex = 10
		'
		'btnLimpiar
		'
		Me.btnLimpiar.Location = New System.Drawing.Point(60, 341)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(83, 35)
		Me.btnLimpiar.TabIndex = 11
		Me.btnLimpiar.Text = "Limpiar"
		Me.btnLimpiar.UseVisualStyleBackColor = True
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(169, 341)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(82, 35)
		Me.btnCalcular.TabIndex = 12
		Me.btnCalcular.Text = "Calcular"
		Me.btnCalcular.UseVisualStyleBackColor = True
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(272, 341)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(86, 35)
		Me.btnCerrar.TabIndex = 13
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(471, 402)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.btnCalcular)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.txtTasa)
		Me.Controls.Add(Me.txtPlazo)
		Me.Controls.Add(Me.txtIngreso)
		Me.Controls.Add(Me.txtOtros)
		Me.Controls.Add(Me.lblMonto)
		Me.Controls.Add(Me.lblTasa)
		Me.Controls.Add(Me.lblPlazo)
		Me.Controls.Add(Me.lblIngreso)
		Me.Controls.Add(Me.lblOtros)
		Me.Controls.Add(Me.txtMonto)
		Me.Name = "Form1"
		Me.Text = "Calculadora de Prestamos"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtMonto As TextBox
	Friend WithEvents lblOtros As Label
	Friend WithEvents lblIngreso As Label
	Friend WithEvents lblPlazo As Label
	Friend WithEvents lblTasa As Label
	Friend WithEvents lblMonto As Label
	Friend WithEvents txtOtros As TextBox
	Friend WithEvents txtIngreso As TextBox
	Friend WithEvents txtPlazo As TextBox
	Friend WithEvents txtTasa As TextBox
	Friend WithEvents btnLimpiar As Button
	Friend WithEvents btnCalcular As Button
	Friend WithEvents btnCerrar As Button
End Class
