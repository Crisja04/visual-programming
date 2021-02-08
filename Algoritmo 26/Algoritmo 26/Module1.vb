'26. Elabore un algoritmo que muestre los terminos de la serie Fibonacci que sean menores a 100000.
Module Module1

	Sub Main()
		Dim A As Integer = 0
		Dim B As Integer = 1
		Dim C As Integer = 0

		C = A + B
		Console.WriteLine(C)
		While C < 100000
			Console.WriteLine(C)
			A = B
			B = C
			C = A + B
		End While

	End Sub

End Module
