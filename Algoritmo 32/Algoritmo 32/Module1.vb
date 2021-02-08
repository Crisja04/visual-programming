'32. Elabore un algoritmo que permita ingresar un numero entero diferente a cero y muestre sus divisores.
Module Module1

	Sub Main()
		Dim N As Integer
		Dim Q As Integer
		Dim P As Integer
		Dim R As Decimal

		Console.WriteLine("Ingrese un numero entero")
		N = Console.ReadLine
		For K As Integer = 1 To N
			Q = N / K
			P = Q * K
			R = N - P
			If R = 0 Then
				Console.WriteLine("{0} es divisor de {1}", K, N)
			End If
		Next
	End Sub

End Module
