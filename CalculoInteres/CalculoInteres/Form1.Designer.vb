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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtCDC = New System.Windows.Forms.TextBox()
		Me.txtDNI = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TabControl2 = New System.Windows.Forms.TabControl()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TabPage1.SuspendLayout()
		Me.TabControl2.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(383, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(0, 20)
		Me.Label1.TabIndex = 0
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1213, 24)
		Me.MenuStrip1.TabIndex = 5
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'TabPage1
		'
		Me.TabPage1.AccessibleDescription = ""
		Me.TabPage1.Controls.Add(Me.RadioButton3)
		Me.TabPage1.Controls.Add(Me.RadioButton2)
		Me.TabPage1.Controls.Add(Me.RadioButton1)
		Me.TabPage1.Controls.Add(Me.Button1)
		Me.TabPage1.Controls.Add(Me.Label2)
		Me.TabPage1.Controls.Add(Me.txtCDC)
		Me.TabPage1.Controls.Add(Me.txtDNI)
		Me.TabPage1.Controls.Add(Me.Label3)
		Me.TabPage1.Location = New System.Drawing.Point(4, 29)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(1074, 500)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Certificados"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(469, 155)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(174, 24)
		Me.RadioButton3.TabIndex = 9
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "Certificado Analitico"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(262, 155)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(175, 24)
		Me.RadioButton2.TabIndex = 8
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "Permiso de Examen"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(10, 155)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(228, 24)
		Me.RadioButton1.TabIndex = 7
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Certificado Alumno Regular"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(262, 210)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(115, 30)
		Me.Button1.TabIndex = 6
		Me.Button1.Text = "Enviar"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 59)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(250, 20)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Documento Nacional de Identidad"
		'
		'txtCDC
		'
		Me.txtCDC.Location = New System.Drawing.Point(262, 102)
		Me.txtCDC.Name = "txtCDC"
		Me.txtCDC.Size = New System.Drawing.Size(250, 26)
		Me.txtCDC.TabIndex = 4
		'
		'txtDNI
		'
		Me.txtDNI.Location = New System.Drawing.Point(262, 56)
		Me.txtDNI.Name = "txtDNI"
		Me.txtDNI.Size = New System.Drawing.Size(250, 26)
		Me.txtDNI.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(6, 102)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(138, 20)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Codigo de Carrera" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'TabControl2
		'
		Me.TabControl2.AccessibleName = ""
		Me.TabControl2.Controls.Add(Me.TabPage1)
		Me.TabControl2.Controls.Add(Me.TabPage2)
		Me.TabControl2.Location = New System.Drawing.Point(0, 12)
		Me.TabControl2.Name = "TabControl2"
		Me.TabControl2.SelectedIndex = 0
		Me.TabControl2.Size = New System.Drawing.Size(1082, 533)
		Me.TabControl2.TabIndex = 6
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.TextBox3)
		Me.TabPage2.Controls.Add(Me.Label6)
		Me.TabPage2.Controls.Add(Me.Button2)
		Me.TabPage2.Controls.Add(Me.Label4)
		Me.TabPage2.Controls.Add(Me.TextBox1)
		Me.TabPage2.Controls.Add(Me.TextBox2)
		Me.TabPage2.Controls.Add(Me.Label5)
		Me.TabPage2.Location = New System.Drawing.Point(4, 29)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(1074, 500)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Inscripcion"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(32, 29)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(250, 20)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Documento Nacional de Identidad"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(288, 72)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(250, 26)
		Me.TextBox1.TabIndex = 8
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(288, 26)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(250, 26)
		Me.TextBox2.TabIndex = 5
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(32, 72)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(138, 20)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Codigo de Carrera" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(249, 203)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(115, 30)
		Me.Button2.TabIndex = 9
		Me.Button2.Text = "Enviar"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(288, 125)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(250, 26)
		Me.TextBox3.TabIndex = 11
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(32, 125)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(62, 20)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "Carrera"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1213, 661)
		Me.Controls.Add(Me.TabControl2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		Me.TabControl2.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents Button1 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents txtCDC As TextBox
	Friend WithEvents txtDNI As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TabControl2 As TabControl
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label5 As Label
End Class
