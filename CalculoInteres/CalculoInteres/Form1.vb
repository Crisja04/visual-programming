Imports System.Text.RegularExpressions
Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim DNI As String = txtDNI.Text
		'Dim rDNI As Regex = New Regex("\w+")
		Dim mDNI As Match = Regex.Match(DNI, "\d+")
		Dim CDC As String = txtCDC.Text
		Dim mCDC As Match = Regex.Match(CDC, "\w+")

		If Not mDNI.Success Then
			MsgBox("Revisar Documento de identidad")
			txtDNI.Focus()
			Exit Sub
		End If
		If Not mCDC.Success Then
			MsgBox("Revisar Codigo de Carrera")
			txtCDC.Focus()
			Exit Sub
		End If
		MsgBox("Exito")
	End Sub

End Class
