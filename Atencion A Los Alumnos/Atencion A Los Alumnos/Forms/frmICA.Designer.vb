<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmICA
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
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'ComboBox1
		'
		Me.ComboBox1.DisplayMember = "Descripcion"
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(269, 98)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(281, 28)
		Me.ComboBox1.TabIndex = 9
		Me.ComboBox1.ValueMember = "Descripcion"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(100, 98)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(62, 20)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Carrera"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(269, 49)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(281, 26)
		Me.TextBox1.TabIndex = 7
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 49)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(250, 20)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Documento Nacional de Identidad"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(319, 25)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Introduzca los datos  de su solicitud"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(100, 157)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(62, 20)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Materia"
		'
		'ComboBox2
		'
		Me.ComboBox2.DisplayMember = "Descripcion"
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(269, 149)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(281, 28)
		Me.ComboBox2.TabIndex = 11
		Me.ComboBox2.ValueMember = "Descripcion"
		'
		'frmICA
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(640, 245)
		Me.Controls.Add(Me.ComboBox2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmICA"
		Me.Text = "frmICA"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents ComboBox2 As ComboBox
End Class
