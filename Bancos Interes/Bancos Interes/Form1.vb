Imports System.Text.RegularExpressions
Public Class frmBancos
	Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
		Dim dDeposito As Double
		Dim dInteres As Double
		Dim iTiempo As Double
		Dim dTotal As Double

		Dim rgxDeposito As Match = Regex.Match(txtDeposito.Text, "\d+")
		Dim rgxInteres As Match = Regex.Match(txtInteres.Text, "\d+")
		Dim rgxTiempo As Match = Regex.Match(txtTiempo.Text, "\d+")

		If Not rgxDeposito.Success Then
			MsgBox("Revisar Deposito")
			txtDeposito.Focus()
			Exit Sub
		End If
		If Not rgxInteres.Success Then
			MsgBox("Revisar Tasa de Interes")
			txtInteres.Focus()
			Exit Sub
		End If
		If Not rgxTiempo.Success Then
			MsgBox("Revisar Cantidad de Semanas")
			txtTiempo.Focus()
			Exit Sub
		End If
		dDeposito = txtDeposito.Text
		dInteres = txtInteres.Text
		iTiempo = txtTiempo.Text

		Dim dAcumulado As Double = (dDeposito * dInteres) / 365
		dTotal = dDeposito + (dAcumulado * (iTiempo * 7))
		txtTotal.Text = dTotal.ToString
	End Sub
End Class
