'18. Elabore un algoritmo que solicite un numero entero y diferente a cero, e indique si es par.
Module Module1

	Sub Main()
		Dim NE As Integer
		Dim Q As Integer
		Dim R As Integer
		Dim MSG As String

		Console.WriteLine("Ingrese un numero")
		NE = Console.ReadLine
		Q = NE / 2
		R = NE - (Q * 2)
		If (R = 0) Then
			MSG = "Par"
		Else
			MSG = "Es Impar"
		End If
		Console.WriteLine(MSG)
	End Sub

End Module
