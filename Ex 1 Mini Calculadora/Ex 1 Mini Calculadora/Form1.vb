Imports System.Text.RegularExpressions
Public Class Form1
	Dim dNumero1 As Double
	Dim dNumero2 As Double
	Dim sOperador As String
	Dim dResultado As Double

	Public Function Calcular(ByVal pNumero1 As String, ByVal pNumero2 As String, ByVal sOperador As String)
		Dim rgxDigito As Regex = New Regex("^[-+]?[0-9]*\.?[0-9]*$")
		Dim mNumero1 As Match = rgxDigito.Match(pNumero1)
		Dim mNumero2 As Match = rgxDigito.Match(pNumero2)

		If mNumero1.Success And mNumero2.Success Then
			dNumero1 = txtNumero1.Text
			dNumero2 = txtNumero2.Text
			Select Case sOperador
				Case "+"
					dResultado = dNumero1 + dNumero2
				Case "-"
					dResultado = dNumero1 - dNumero2
				Case "*"
					dResultado = dNumero1 * dNumero2
				Case "/"
					dResultado = dNumero1 / dNumero2
			End Select
			Return dResultado
		Else
			MsgBox("Solo se permiten numeros")
			txtNumero1.Focus()
		End If
		Return Nothing
	End Function

	Public Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
		sOperador = "+"
		dResultado = Calcular(txtNumero1.Text, txtNumero2.Text, sOperador)
		txtResultado.Text = dResultado
		lblOperacion.Text = "+"
	End Sub

	Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
		sOperador = "-"
		dResultado = Calcular(txtNumero1.Text, txtNumero2.Text, sOperador)
		txtResultado.Text = dResultado
		lblOperacion.Text = "-"
	End Sub

	Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
		sOperador = "*"
		dResultado = Calcular(txtNumero1.Text, txtNumero2.Text, sOperador)
		txtResultado.Text = dResultado
		lblOperacion.Text = "*"
	End Sub

	Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
		sOperador = "/"
		dResultado = Calcular(txtNumero1.Text, txtNumero2.Text, sOperador)
		txtResultado.Text = dResultado
		lblOperacion.Text = "/"
	End Sub
End Class
