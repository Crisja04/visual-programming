<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBancos
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
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.txtDeposito = New System.Windows.Forms.TextBox()
		Me.lblDeposito = New System.Windows.Forms.Label()
		Me.lblInteres = New System.Windows.Forms.Label()
		Me.txtInteres = New System.Windows.Forms.TextBox()
		Me.lblTiempo = New System.Windows.Forms.Label()
		Me.txtTiempo = New System.Windows.Forms.TextBox()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.txtTotal = New System.Windows.Forms.TextBox()
		Me.btnCalcular = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblTitulo
		'
		Me.lblTitulo.AutoSize = True
		Me.lblTitulo.Location = New System.Drawing.Point(124, 24)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(169, 20)
		Me.lblTitulo.TabIndex = 0
		Me.lblTitulo.Text = "Calculadora de Interes"
		'
		'txtDeposito
		'
		Me.txtDeposito.Location = New System.Drawing.Point(205, 66)
		Me.txtDeposito.Name = "txtDeposito"
		Me.txtDeposito.Size = New System.Drawing.Size(266, 26)
		Me.txtDeposito.TabIndex = 1
		'
		'lblDeposito
		'
		Me.lblDeposito.AutoSize = True
		Me.lblDeposito.Location = New System.Drawing.Point(43, 66)
		Me.lblDeposito.Name = "lblDeposito"
		Me.lblDeposito.Size = New System.Drawing.Size(73, 20)
		Me.lblDeposito.TabIndex = 2
		Me.lblDeposito.Text = "Deposito"
		'
		'lblInteres
		'
		Me.lblInteres.AutoSize = True
		Me.lblInteres.Location = New System.Drawing.Point(26, 117)
		Me.lblInteres.Name = "lblInteres"
		Me.lblInteres.Size = New System.Drawing.Size(120, 20)
		Me.lblInteres.TabIndex = 4
		Me.lblInteres.Text = "Tasa de Interes"
		'
		'txtInteres
		'
		Me.txtInteres.Location = New System.Drawing.Point(205, 117)
		Me.txtInteres.Name = "txtInteres"
		Me.txtInteres.Size = New System.Drawing.Size(266, 26)
		Me.txtInteres.TabIndex = 3
		'
		'lblTiempo
		'
		Me.lblTiempo.AutoSize = True
		Me.lblTiempo.Location = New System.Drawing.Point(12, 163)
		Me.lblTiempo.Name = "lblTiempo"
		Me.lblTiempo.Size = New System.Drawing.Size(167, 20)
		Me.lblTiempo.TabIndex = 6
		Me.lblTiempo.Text = "Cantidad de Semanas"
		'
		'txtTiempo
		'
		Me.txtTiempo.Location = New System.Drawing.Point(205, 163)
		Me.txtTiempo.Name = "txtTiempo"
		Me.txtTiempo.Size = New System.Drawing.Size(266, 26)
		Me.txtTiempo.TabIndex = 5
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Location = New System.Drawing.Point(19, 295)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(97, 20)
		Me.lblTotal.TabIndex = 7
		Me.lblTotal.Text = "Capital Total"
		'
		'txtTotal
		'
		Me.txtTotal.Location = New System.Drawing.Point(205, 289)
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.Size = New System.Drawing.Size(266, 26)
		Me.txtTotal.TabIndex = 8
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(144, 221)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(126, 42)
		Me.btnCalcular.TabIndex = 9
		Me.btnCalcular.Text = "Calcular"
		Me.btnCalcular.UseVisualStyleBackColor = True
		'
		'frmBancos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(495, 335)
		Me.Controls.Add(Me.btnCalcular)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.lblTiempo)
		Me.Controls.Add(Me.txtTiempo)
		Me.Controls.Add(Me.lblInteres)
		Me.Controls.Add(Me.txtInteres)
		Me.Controls.Add(Me.lblDeposito)
		Me.Controls.Add(Me.txtDeposito)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "frmBancos"
		Me.RightToLeftLayout = True
		Me.Text = "Bancos"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblTitulo As Label
	Friend WithEvents txtDeposito As TextBox
	Friend WithEvents lblDeposito As Label
	Friend WithEvents lblInteres As Label
	Friend WithEvents txtInteres As TextBox
	Friend WithEvents lblTiempo As Label
	Friend WithEvents txtTiempo As TextBox
	Friend WithEvents lblTotal As Label
	Friend WithEvents txtTotal As TextBox
	Friend WithEvents btnCalcular As Button
End Class
