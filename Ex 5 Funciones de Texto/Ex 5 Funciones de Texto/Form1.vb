Public Class Form1
	Dim iHeight As Integer = 10
	Dim Estilo As FontStyle = FontStyle.Regular
	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Negrita.CheckedChanged
		txtFrase.Font = New Font(FontFamily.GenericSansSerif, iHeight, FontStyle.Bold)
		Estilo = FontStyle.Bold
	End Sub

	Private Sub Cursiva_CheckedChanged(sender As Object, e As EventArgs) Handles Cursiva.CheckedChanged
		txtFrase.Font = New Font(FontFamily.GenericSansSerif, iHeight, FontStyle.Italic)
		Estilo = FontStyle.Italic
	End Sub

	Private Sub Subrayado_CheckedChanged(sender As Object, e As EventArgs) Handles Subrayado.CheckedChanged
		txtFrase.Font = New Font(FontFamily.GenericSansSerif, iHeight, FontStyle.Underline)
		Estilo = FontStyle.Underline
	End Sub

	Private Sub Mayuscula_CheckedChanged(sender As Object, e As EventArgs) Handles Mayuscula.CheckedChanged
		txtFrase.CharacterCasing = CharacterCasing.Upper
	End Sub

	Private Sub Minuscula_CheckedChanged(sender As Object, e As EventArgs) Handles Minuscula.CheckedChanged
		txtFrase.CharacterCasing = CharacterCasing.Lower
	End Sub

	Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
		If SelectorColor.ShowDialog <> DialogResult.Cancel Then
			txtFrase.ForeColor = SelectorColor.Color
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFondo.Click
		If SelectorColor.ShowDialog <> DialogResult.Cancel Then
			txtFrase.BackColor = SelectorColor.Color
		End If
	End Sub

	Private Sub btnAgrandar_Click(sender As Object, e As EventArgs) Handles btnAgrandar.Click
		iHeight += 1
		txtFrase.Font = New Font(FontFamily.GenericSansSerif, iHeight, Estilo)
	End Sub

	Private Sub btnEncoger_Click(sender As Object, e As EventArgs) Handles btnEncoger.Click
		iHeight -= 1
		txtFrase.Font = New Font(FontFamily.GenericSansSerif, iHeight, Estilo)
	End Sub
End Class
