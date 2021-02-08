Imports System.Text.RegularExpressions
Public Class Form1
	Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
		Dim dHora As Integer
		Dim dMinuto As Integer
		Dim dSegundo As Integer
		Dim rgxNumero As Regex = New Regex("^[0-9]+$")
		Dim mHora As Match = rgxNumero.Match(txtHora.Text.ToString)

		If mHora.Success Then
			dHora = txtHora.Text
			dMinuto = dHora * 60
			dSegundo = dMinuto * 60
			txtMinuto.Text = dMinuto
			txtSegundo.Text = dSegundo
		Else
			MsgBox("Solo se permiten numeros enteros positivos")
			txtHora.Focus()
		End If

	End Sub

	Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
		Close()
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
