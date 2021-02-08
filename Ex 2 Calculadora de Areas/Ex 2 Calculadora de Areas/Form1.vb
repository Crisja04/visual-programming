Imports System.Text.RegularExpressions
Public Class Form1
	Dim dNumero1 As Double
	Dim dNumero2 As Double
	Dim sFigura As String
	Dim dResultado As Double

	Public Function Calcular(ByVal sFigura As String, ByVal pNumero1 As String, Optional pNumero2 As String = "")
		Dim rgxDigito As Regex = New Regex("^[0-9]*\.?[0-9]*$")
		Dim mNumero1 As Match = rgxDigito.Match(pNumero1)
		Dim mNumero2 As Match = rgxDigito.Match(pNumero2)

		If mNumero1.Success And mNumero2.Success Then
			Select Case sFigura
				Case "Cuadrado"
					dNumero1 = txtCuadradoLado.Text
					dResultado = dNumero1 ^ 2
				Case "Rectangulo"
					dNumero1 = txtRectLadMayor.Text
					dNumero2 = txtRectLadMenor.Text
					dResultado = dNumero1 * dNumero2
				Case "Triangulo"
					dNumero1 = txtTrianBase.Text
					dNumero2 = txtTrianAltura.Text
					dResultado = (dNumero1 * dNumero2) / 2
			End Select
			Return dResultado
		Else
			MsgBox("Solo se permiten numeros positivos")
			Select Case sFigura
				Case "Cuadrado"
					txtCuadradoLado.Focus()
				Case "Rectangulo"
					txtRectLadMayor.Focus()
				Case "Triangulo"
					txtTrianBase.Focus()
			End Select
		End If
		Return Nothing
	End Function

	Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click
		sFigura = "Cuadrado"
		dResultado = Calcular(sFigura, txtCuadradoLado.Text)
		txtResultado.Text = dResultado
	End Sub

	Private Sub btnRectangulo_Click(sender As Object, e As EventArgs) Handles btnRectangulo.Click
		sFigura = "Rectangulo"
		dResultado = Calcular(sFigura, txtRectLadMayor.Text, txtRectLadMenor.Text)
		txtResultado.Text = dResultado
	End Sub

	Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click
		sFigura = "Triangulo"
		dResultado = Calcular(sFigura, txtTrianBase.Text, txtTrianAltura.Text)
		txtResultado.Text = dResultado
	End Sub
End Class
