Imports System.Text.RegularExpressions
Public Class Form1
	Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
		Const dPrecio As Decimal = 2.5
		Dim dDistancia As Decimal
		Dim iEstancia As Integer
		Dim dCosto As Decimal
		Dim rgxNumero As Regex = New Regex("^[0-9]+$")
		Dim mDistancia As Match = rgxNumero.Match(txtDistancia.Text.ToString)
		Dim mDias As Match = rgxNumero.Match(txtEstancia.Text.ToString)

		If Not mDistancia.Success And mDias.Success Then
			MsgBox("Ingrese valores validos")
			txtDistancia.Focus()
		End If

		dDistancia = txtDistancia.Text
		iEstancia = txtEstancia.Text

		dCosto = dDistancia * dPrecio

		If dDistancia >= 800 And iEstancia >= 7 Then
			dCosto = dCosto * 0.7
		End If

		txtCosto.Text = dCosto

	End Sub
End Class
