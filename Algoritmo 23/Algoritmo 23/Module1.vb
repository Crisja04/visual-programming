'23. Elaborar un algoritmo que muestre 10 numeros enteros a partir de 1 excepto los pares.
Module Module1

	Sub Main()
		Dim Q As Integer
		Dim R As Integer

		For K As Integer = 1 To 10
			Q = K / 2
			R = K - (Q * 2)
			If R = 0 Then
				Continue For
			Else
				Console.WriteLine(K)
			End If
		Next
	End Sub

End Module
