<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCAR
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
		Me.components = New System.ComponentModel.Container()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.CarreraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		CType(Me.CarreraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(13, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(319, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Introduzca los datos  de su solicitud"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(13, 53)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(250, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Documento Nacional de Identidad"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(270, 53)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(281, 26)
		Me.TextBox1.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(101, 102)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(62, 20)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Carrera"
		'
		'CarreraBindingSource
		'
		Me.CarreraBindingSource.DataMember = "carrera"
		Me.CarreraBindingSource.DataSource = Me.AtencionAlumnosDataSet
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(293, 133)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
		Me.ComboBox1.TabIndex = 4
		'
		'frmCAR
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(678, 244)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmCAR"
		Me.Text = "frmCAR"
		CType(Me.CarreraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents AtencionAlumnosDataSet As AtencionAlumnosDataSet
	Friend WithEvents CarreraBindingSource As BindingSource
	Friend WithEvents CarreraTableAdapter As AtencionAlumnosDataSetTableAdapters.carreraTableAdapter
	Friend WithEvents ComboBox1 As ComboBox
End Class
