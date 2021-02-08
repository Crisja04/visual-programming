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
		Me.txtCuadradoLado = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblCuadLado = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnCuadrado = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.txtRectLadMenor = New System.Windows.Forms.TextBox()
		Me.lblRectLadMenor = New System.Windows.Forms.Label()
		Me.btnRectangulo = New System.Windows.Forms.Button()
		Me.txtRectLadMayor = New System.Windows.Forms.TextBox()
		Me.lblRectLadMayor = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.txtTrianAltura = New System.Windows.Forms.TextBox()
		Me.lblTrianAltura = New System.Windows.Forms.Label()
		Me.btnTriangulo = New System.Windows.Forms.Button()
		Me.txtTrianBase = New System.Windows.Forms.TextBox()
		Me.lblTrianBase = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtResultado = New System.Windows.Forms.TextBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtCuadradoLado
		'
		Me.txtCuadradoLado.Location = New System.Drawing.Point(191, 42)
		Me.txtCuadradoLado.Name = "txtCuadradoLado"
		Me.txtCuadradoLado.Size = New System.Drawing.Size(100, 28)
		Me.txtCuadradoLado.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(13, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(427, 29)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Calcular áreas de diferentes polígonos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'lblCuadLado
		'
		Me.lblCuadLado.AutoSize = True
		Me.lblCuadLado.Location = New System.Drawing.Point(31, 42)
		Me.lblCuadLado.Name = "lblCuadLado"
		Me.lblCuadLado.Size = New System.Drawing.Size(125, 44)
		Me.lblCuadLado.TabIndex = 2
		Me.lblCuadLado.Text = "Valor del lado:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnCuadrado)
		Me.GroupBox1.Controls.Add(Me.txtCuadradoLado)
		Me.GroupBox1.Controls.Add(Me.lblCuadLado)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(17, 53)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(723, 100)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Cuadrado"
		'
		'btnCuadrado
		'
		Me.btnCuadrado.Location = New System.Drawing.Point(610, 42)
		Me.btnCuadrado.Name = "btnCuadrado"
		Me.btnCuadrado.Size = New System.Drawing.Size(90, 36)
		Me.btnCuadrado.TabIndex = 3
		Me.btnCuadrado.Text = "Calcular"
		Me.btnCuadrado.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.txtRectLadMenor)
		Me.GroupBox2.Controls.Add(Me.lblRectLadMenor)
		Me.GroupBox2.Controls.Add(Me.btnRectangulo)
		Me.GroupBox2.Controls.Add(Me.txtRectLadMayor)
		Me.GroupBox2.Controls.Add(Me.lblRectLadMayor)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.Location = New System.Drawing.Point(17, 159)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(723, 100)
		Me.GroupBox2.TabIndex = 4
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Rectángulo"
		'
		'txtRectLadMenor
		'
		Me.txtRectLadMenor.Location = New System.Drawing.Point(483, 39)
		Me.txtRectLadMenor.Name = "txtRectLadMenor"
		Me.txtRectLadMenor.Size = New System.Drawing.Size(100, 28)
		Me.txtRectLadMenor.TabIndex = 6
		'
		'lblRectLadMenor
		'
		Me.lblRectLadMenor.AutoSize = True
		Me.lblRectLadMenor.Location = New System.Drawing.Point(297, 42)
		Me.lblRectLadMenor.Name = "lblRectLadMenor"
		Me.lblRectLadMenor.Size = New System.Drawing.Size(180, 22)
		Me.lblRectLadMenor.TabIndex = 5
		Me.lblRectLadMenor.Text = "Valor del lado menor:"
		'
		'btnRectangulo
		'
		Me.btnRectangulo.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.btnRectangulo.Location = New System.Drawing.Point(610, 35)
		Me.btnRectangulo.Name = "btnRectangulo"
		Me.btnRectangulo.Size = New System.Drawing.Size(90, 40)
		Me.btnRectangulo.TabIndex = 4
		Me.btnRectangulo.Text = "Calcular"
		Me.btnRectangulo.UseVisualStyleBackColor = True
		'
		'txtRectLadMayor
		'
		Me.txtRectLadMayor.Location = New System.Drawing.Point(191, 36)
		Me.txtRectLadMayor.Name = "txtRectLadMayor"
		Me.txtRectLadMayor.Size = New System.Drawing.Size(100, 28)
		Me.txtRectLadMayor.TabIndex = 0
		'
		'lblRectLadMayor
		'
		Me.lblRectLadMayor.AutoSize = True
		Me.lblRectLadMayor.Location = New System.Drawing.Point(6, 42)
		Me.lblRectLadMayor.Name = "lblRectLadMayor"
		Me.lblRectLadMayor.Size = New System.Drawing.Size(179, 22)
		Me.lblRectLadMayor.TabIndex = 2
		Me.lblRectLadMayor.Text = "Valor del lado mayor:"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.txtTrianAltura)
		Me.GroupBox3.Controls.Add(Me.lblTrianAltura)
		Me.GroupBox3.Controls.Add(Me.btnTriangulo)
		Me.GroupBox3.Controls.Add(Me.txtTrianBase)
		Me.GroupBox3.Controls.Add(Me.lblTrianBase)
		Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox3.Location = New System.Drawing.Point(17, 265)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(723, 100)
		Me.GroupBox3.TabIndex = 4
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Triángulo"
		'
		'txtTrianAltura
		'
		Me.txtTrianAltura.Location = New System.Drawing.Point(483, 39)
		Me.txtTrianAltura.Name = "txtTrianAltura"
		Me.txtTrianAltura.Size = New System.Drawing.Size(100, 28)
		Me.txtTrianAltura.TabIndex = 6
		'
		'lblTrianAltura
		'
		Me.lblTrianAltura.AutoSize = True
		Me.lblTrianAltura.Location = New System.Drawing.Point(313, 42)
		Me.lblTrianAltura.Name = "lblTrianAltura"
		Me.lblTrianAltura.Size = New System.Drawing.Size(151, 22)
		Me.lblTrianAltura.TabIndex = 7
		Me.lblTrianAltura.Text = "Valor de la altura:"
		'
		'btnTriangulo
		'
		Me.btnTriangulo.Location = New System.Drawing.Point(610, 34)
		Me.btnTriangulo.Name = "btnTriangulo"
		Me.btnTriangulo.Size = New System.Drawing.Size(90, 43)
		Me.btnTriangulo.TabIndex = 5
		Me.btnTriangulo.Text = "Calcular"
		Me.btnTriangulo.UseVisualStyleBackColor = True
		'
		'txtTrianBase
		'
		Me.txtTrianBase.Location = New System.Drawing.Point(191, 42)
		Me.txtTrianBase.Name = "txtTrianBase"
		Me.txtTrianBase.Size = New System.Drawing.Size(100, 28)
		Me.txtTrianBase.TabIndex = 0
		'
		'lblTrianBase
		'
		Me.lblTrianBase.AutoSize = True
		Me.lblTrianBase.Location = New System.Drawing.Point(31, 42)
		Me.lblTrianBase.Name = "lblTrianBase"
		Me.lblTrianBase.Size = New System.Drawing.Size(145, 22)
		Me.lblTrianBase.TabIndex = 2
		Me.lblTrianBase.Text = "Valor de la base:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(243, 390)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(99, 25)
		Me.Label5.TabIndex = 3
		Me.Label5.Text = "Resultado"
		'
		'txtResultado
		'
		Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtResultado.Location = New System.Drawing.Point(389, 389)
		Me.txtResultado.Name = "txtResultado"
		Me.txtResultado.Size = New System.Drawing.Size(197, 28)
		Me.txtResultado.TabIndex = 5
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(766, 443)
		Me.Controls.Add(Me.txtResultado)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Calcular Areas"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtCuadradoLado As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblCuadLado As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnCuadrado As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents txtRectLadMenor As TextBox
	Friend WithEvents lblRectLadMenor As Label
	Friend WithEvents btnRectangulo As Button
	Friend WithEvents txtRectLadMayor As TextBox
	Friend WithEvents lblRectLadMayor As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents txtTrianAltura As TextBox
	Friend WithEvents lblTrianAltura As Label
	Friend WithEvents btnTriangulo As Button
	Friend WithEvents txtTrianBase As TextBox
	Friend WithEvents lblTrianBase As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtResultado As TextBox
End Class
