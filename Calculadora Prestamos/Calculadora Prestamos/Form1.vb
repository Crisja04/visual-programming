Imports System.Text.RegularExpressions
Imports System
Imports System.IO
Imports System.Globalization

Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtMonto.Text = "100000"
		txtTasa.Text = "12"
		txtPlazo.Text = "12"
		txtIngreso.Text = "0"
		txtOtros.Text = "0"
	End Sub

	Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
		txtMonto.Clear()
		txtTasa.Clear()
		txtPlazo.Clear()
		txtIngreso.Clear()
		txtOtros.Clear()
	End Sub

	Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
		Dim Direccion_txt As String = "C:\Users\crist\OneDrive - Universidad APEC - Academico\Programacion Visual\Visual Basic .NET\Textos\Resultado.txt"
		Dim objLector As String
		objLector = My.Computer.FileSystem.ReadAllText(Direccion_txt)
		Dim objEscritor As System.IO.StreamWriter
		objEscritor = My.Computer.FileSystem.OpenTextFileWriter(Direccion_txt, False) 'False to overrite file

		Dim rgxNumero As Regex = New Regex("\d+")
		Dim rgxOpcional As Regex = New Regex("(\d+?|\s?)?")
		Dim mMonto As Match = rgxNumero.Match(txtMonto.ToString)
		Dim mTasa As Match = rgxNumero.Match(txtTasa.ToString)
		Dim mPlazo As Match = rgxNumero.Match(txtPlazo.ToString)
		Dim mIngreso As Match = rgxNumero.Match(txtIngreso.ToString)
		Dim mOtros As Match = rgxNumero.Match(txtOtros.ToString)

		Dim dMonto As Double
		Dim dTasa As Double
		Dim iPlazo As Integer
		Dim dIngreso As Double
		Dim dOtros As Double

		Dim dCuota As Double
		Dim dCapital(120) As Double
		Dim dInteres(120) As Double
		Dim dBalance(120) As Double
		Dim Fecha As Date = Today

		If Not mMonto.Success Then
			MsgBox("Revisar el Monto, solo se permiten numeros.")
			txtMonto.Focus()
			Exit Sub
		End If
		If Not mTasa.Success Then
			MsgBox("Revisar la tasa, solo se permiten numeros.")
			txtTasa.Focus()
			Exit Sub
		End If
		If Not mPlazo.Success Then
			MsgBox("Revisar el plazo, solo se permiten numeros.")
			txtPlazo.Focus()
			Exit Sub
		End If
		If Not mIngreso.Success Then
			MsgBox("Revisar el ingreso, solo se permiten numeros.")
			txtIngreso.Focus()
			Exit Sub
		End If
		If Not mOtros.Success Then
			MsgBox("Revisar otros, solo se permiten numeros.")
			txtOtros.Focus()
			Exit Sub
		End If

		dMonto = txtMonto.Text
		dTasa = txtTasa.Text
		iPlazo = txtPlazo.Text
		dIngreso = txtIngreso.Text
		dOtros = txtOtros.Text

		Dim dTasaMensual As Double
		dTasaMensual = (dTasa / 100) / 12
		dCuota = (dTasaMensual * dMonto) / (1 - (1 + dTasaMensual) ^ -iPlazo)
		dBalance(0) = dMonto

		Dim sLinea(120) As String
		objEscritor.WriteLine("Mes" & "  " & "Fecha" & "  " & "Cuota" & "  " & "Capital" & "  " & "Interes" & "  " & "Balance")
		For i As Integer = 0 To iPlazo - 1
			dInteres(i) = dBalance(i) * dTasaMensual
			Fecha = DateAdd(DateInterval.Month, 1, Fecha)
			dCapital(i) = dCuota - dInteres(i)
			dBalance(i + 1) = dBalance(i) - dCapital(i)
			sLinea(i) = i + 1.ToString() & "  " & Fecha.ToShortDateString & "  " & dCuota.ToString("C", CultureInfo.CurrentCulture) & "  " & dCapital(i).ToString("C", CultureInfo.CurrentCulture) & "  " & dInteres(i).ToString("C", CultureInfo.CurrentCulture) & "  " & dBalance(i + 1).ToString("C", CultureInfo.CurrentCulture)
			objEscritor.WriteLine(sLinea(i))
		Next
		objEscritor.Close()
		Process.Start(Direccion_txt)
	End Sub

	Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
		Me.Close()
	End Sub
End Class
