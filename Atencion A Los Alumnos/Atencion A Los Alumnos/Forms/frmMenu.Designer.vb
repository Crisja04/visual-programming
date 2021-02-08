<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
		Me.btnCAR = New System.Windows.Forms.Button()
		Me.btnPE = New System.Windows.Forms.Button()
		Me.btnCA = New System.Windows.Forms.Button()
		Me.btnICA = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(363, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Seleccione el trámite que quiere realizar:"
		'
		'btnCAR
		'
		Me.btnCAR.ForeColor = System.Drawing.Color.Black
		Me.btnCAR.Location = New System.Drawing.Point(64, 60)
		Me.btnCAR.Name = "btnCAR"
		Me.btnCAR.Size = New System.Drawing.Size(266, 35)
		Me.btnCAR.TabIndex = 1
		Me.btnCAR.Text = "Certificado de Alumno Regular"
		Me.btnCAR.UseVisualStyleBackColor = False
		'
		'btnPE
		'
		Me.btnPE.ForeColor = System.Drawing.Color.Black
		Me.btnPE.Location = New System.Drawing.Point(64, 118)
		Me.btnPE.Name = "btnPE"
		Me.btnPE.Size = New System.Drawing.Size(266, 35)
		Me.btnPE.TabIndex = 2
		Me.btnPE.Text = "Permiso de Examen"
		Me.btnPE.UseVisualStyleBackColor = True
		'
		'btnCA
		'
		Me.btnCA.ForeColor = System.Drawing.Color.Black
		Me.btnCA.Location = New System.Drawing.Point(64, 181)
		Me.btnCA.Name = "btnCA"
		Me.btnCA.Size = New System.Drawing.Size(266, 35)
		Me.btnCA.TabIndex = 3
		Me.btnCA.Text = "Certificado Analítico"
		Me.btnCA.UseVisualStyleBackColor = True
		'
		'btnICA
		'
		Me.btnICA.ForeColor = System.Drawing.Color.Black
		Me.btnICA.Location = New System.Drawing.Point(64, 242)
		Me.btnICA.Name = "btnICA"
		Me.btnICA.Size = New System.Drawing.Size(266, 33)
		Me.btnICA.TabIndex = 4
		Me.btnICA.Text = "Inscripción de Asignatura"
		Me.btnICA.UseVisualStyleBackColor = True
		'
		'frmMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(458, 309)
		Me.Controls.Add(Me.btnICA)
		Me.Controls.Add(Me.btnCA)
		Me.Controls.Add(Me.btnPE)
		Me.Controls.Add(Me.btnCAR)
		Me.Controls.Add(Me.Label1)
		Me.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.Name = "frmMenu"
		Me.Text = "Trámites"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents btnCAR As Button
	Friend WithEvents btnPE As Button
	Friend WithEvents btnCA As Button
	Friend WithEvents btnICA As Button
End Class
